/*
 * TDLNA Service App / UPnP DMS 서비스 메인
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <unistd.h>
#include <sys/param.h>
#include <sys/errno.h>
#include <sys/socket.h>
#include <sys/un.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <errno.h>
#include <time.h>
#include <fcntl.h>
#include <sys/ioctl.h>
#include <net/if.h>
#include <dlog.h>
#include <pthread.h>

#include "upnphttp.h"
#include "upnpglobalvars.h"
#include "upnpevents.h"
#include "clients.h"
#include "upnpssdp.h"

#include "main-app.h"
#include "tdlnamain.h"

//static int OpenAndConfHTTPSocket(unsigned short port);
//static int getifaddr(const char *ifname);
//void reload_ifaces(int force_notify);

//서비스 시작
int serviceOn(void* data){
	app_data *ad = data;
	int r;

	if(ad->tdlna_td != NULL){
		dlog_print(DLOG_ERROR,"tdlna", "이전 실행된 서비스가 정상적으로 종료되지 않았습니다.");
		return 0;
	}
	ad->run_tdlna = true;
	r = pthread_create(&(ad->tdlna_td), NULL, tdlnamain, (void*)data);
	dlog_print(DLOG_INFO,"tdlna","◆ 서비스 스레드 생성: %d", r);

	return 1;
}

//서비스 종료
int serviceOff(void* data){
	app_data *ad = data;
	int r;
	ad->run_tdlna = false;

	r = pthread_join(&(ad->tdlna_td), NULL);
	ad->tdlna_td = NULL;
	dlog_print(DLOG_INFO,"tdlna","◆ 서비스 스레드 종료: %d", r);

	return 1;
}

void* ssdpAlive(void* data){
	app_data *ad = data;

	while(ad->run_tdlna){
		dlog_print(DLOG_INFO, "tdlna", "SSDP Alive (run:%d)", ad->run_tdlna);
		SendSSDPNotifies(lan_addr[0].snotify, lan_addr[0].str, runtime_vars.port, runtime_vars.notify_interval);
		//sleep(runtime_vars.notify_interval - 10 ); // 딜레이를 기존보다 10초 정도 적게 보냄
		sleep(3); //테스트 3초
	}

	dlog_print(DLOG_INFO, "tdlna", "♠♠♠ GoodBye~ (ssdp)♠♠♠ %d", ad->run_tdlna);
	SendSSDPGoodbyes(lan_addr[0].snotify);
}

// main
void* tdlnamain(void* data)
{
		app_data *ad = data;
		pthread_t ssdptd;

		int shttpl = -1; //http 수신 소켓
		int sssdp = -1;  //ssdp (udp) 소켓
		int ret, i;
		LIST_HEAD(httplisthead, upnphttp) upnphttphead; //http 요청 Queue로 사용할 링크드리스트
		struct upnphttp * e = 0; //들어오는 http 요청
		struct upnphttp * next;  //큐에 있는 다음 요청
		fd_set readset;	// select() 사용
		fd_set writeset;
		int max_fd = -1;
		struct timeval timeout;

		dlog_print(DLOG_INFO, "tdlna", "Main Start!!!");

		//초기화
		runtime_vars.port = 9090; //http요청 수신 포트
		runtime_vars.notify_interval = 20; //ssdp notify알림주기(sec)
		runtime_vars.max_connections = 50; //최대 접속수
		runtime_vars.root_container = NULL;
		runtime_vars.ifaces[0] = NULL;

		reload_ifaces(0); //네트워크 초기화(기존 연결된 기기들이 있으면 끊고 다시 ssdp알림 발송)

		LIST_INIT(&upnphttphead);
		shttpl = OpenAndConfHTTPSocket(runtime_vars.port); // Http 수신 소켓 설정

		if (shttpl < 0)
		{
			close(shttpl);
			dlog_print(DLOG_ERROR, "tdlna", "HTTP 수신 소켓 실패");
			exit(0);
			return 0;
		}
		else
			dlog_print(DLOG_INFO, "tdlna", "shttpl: %d\n", shttpl);

		sssdp = OpenAndConfSSDPReceiveSocket();
		if (sssdp < 0)
			dlog_print(DLOG_ERROR, "tdlna", "SSDP 수신 소켓 실패");

	//	JustSend_M_Search(0); //M-search 패킷 테스트
	//	return 0;

		//ssdp alive 스레드 생성 (이녀석은 서비스 실행중인 동안 주기적으로 Alive패킷을 보낸다.)
		pthread_create(&ssdptd, NULL, ssdpAlive, (void*)data);

		//***** 메인루프 *****//
		while(ad->run_tdlna)
		{
			//dlog_print(DLOG_INFO, "tdlna", "Main Loop");
			timeout.tv_sec = 1;
			timeout.tv_usec = 0;

			FD_ZERO(&readset);
			if (shttpl >= 0)
			{
				FD_SET(shttpl, &readset);
				max_fd = MAX(max_fd, shttpl);
			}

			i = 0;	//연결 되어있는 http소켓 수를 카운트
			for (e = upnphttphead.lh_first; e != NULL; e = e->entries.le_next)
			{
				if ((e->socket >= 0) && (e->state <= 2))
				{
					FD_SET(e->socket, &readset);
					max_fd = MAX(max_fd, e->socket);
					i++;
				}
			}
			FD_ZERO(&writeset);
	//		upnpevents_selectfds(&readset, &writeset, &max_fd);


			ret = select(max_fd+1, &readset, &writeset, 0, &timeout);
			if (ret < 0)
			{
			//	if(quitting) goto shutdown;
				if(errno == EINTR) continue;
			}

			//dlog_print(DLOG_DEBUG, "max_fd - %d\n",max_fd);
	//		upnpevents_processfds(&readset, &writeset);

			//리스트에 접속된 http요청을 처리한다.
			for (e = upnphttphead.lh_first; e != NULL; e = e->entries.le_next)
			{

				if ((e->socket >= 0) && (e->state <= 2) && (FD_ISSET(e->socket, &readset)))
				{
					dlog_print(DLOG_INFO, "tdlna", "Process_upnpHttp 호출");
					Process_upnphttp(e); // 본격적 처리부분
				}
			}


			// 들어오는 http연결을 수락한 후 리스트에 추가한다.
			if (shttpl >= 0 && FD_ISSET(shttpl, &readset))
			{
				int shttp;
				socklen_t clientnamelen;
				struct sockaddr_in clientname;
				clientnamelen = sizeof(struct sockaddr_in);

				//수락
				shttp = accept(shttpl, (struct sockaddr *) &clientname, &clientnamelen);

				if(shttp <0)
					dlog_print(DLOG_ERROR, "tdlna", "Http accept error !!!");
				else
					dlog_print(DLOG_INFO, "tdlna", "client socket: %d\n", shttp);

				struct upnphttp * tmp = 0;
				tmp = New_upnphttp(shttp); //노드 할당
				if(tmp)
				{
					tmp->clientaddr = clientname.sin_addr;
					LIST_INSERT_HEAD(&upnphttphead, tmp, entries); //리스트 추가
				}
				else
				{
					dlog_print(DLOG_ERROR, "tdlna", "New_upnphttp() failed");
					close(shttp);
				}
			}

			//연결이 끊긴 소켓 헤제
			for (e = upnphttphead.lh_first; e != NULL; e = next)
			{
				next = e->entries.le_next;
				if(e->state >= 100)
				{
					dlog_print(DLOG_INFO, "tdlna", "Delete upnphttp (%d)", e->clientaddr);
					LIST_REMOVE(e, entries);
					Delete_upnphttp(e);
				}
			}

		}
	//Main Loop End


	shutdown:
		dlog_print(DLOG_INFO, "tdlna", "+=== Shutdown ====+\n");
		/* kill the scanner */
	//	if (scanning && scanner_pid)
	//		kill(scanner_pid, SIGKILL);

		/* kill other child processes */
	//	process_reap_children();
	//	free(children);

		// 연결된 모든 소켓을 닫는다.
		while (upnphttphead.lh_first != NULL)
		{
			e = upnphttphead.lh_first;
			LIST_REMOVE(e, entries);
			Delete_upnphttp(e);
		}
		if (sssdp >= 0)
			close(sssdp);
		if (shttpl >= 0)
			close(shttpl);

		//종료시 네트워크의 모든 인터페이스로 ssdp byebye패킷을 보낸다.
		for (i = 0; i < n_lan_addr; i++)
		{
			SendSSDPGoodbyes(lan_addr[i].snotify);
			close(lan_addr[i].snotify);
			dlog_print(DLOG_INFO, "tdlna", "send ByeBye");
		}

		//ssdp Alive 스레드가 완전히 종료되기를 기다린다.
		if (ssdptd)
			pthread_join(ssdptd, NULL);

	//	sqlite3_close(db);
	//	upnpevents_removeSubscribers();
	//	freeoptions();

		dlog_print(DLOG_INFO, "tdlna", "+=== 서비스 Main 종료됨!! ====+\n");
		return 0;
}


// http 접속 소켓을 설정한다.
 static int OpenAndConfHTTPSocket(unsigned short port)
{
	int s;
	int i = 1;
	struct sockaddr_in listenname;

	// 클라이언트 초기화 및 할당
	memset(&clients, 0, sizeof(struct client_cache_s));

	s = socket(PF_INET, SOCK_STREAM, 0);
	if (s < 0)
	{
		dlog_print(DLOG_ERROR, "tdlna", "socket(http) error");
		return -1;
	}

	if (setsockopt(s, SOL_SOCKET, SO_REUSEADDR, &i, sizeof(i)) < 0)
	dlog_print(DLOG_ERROR, "tdlna", "setsockopt(http, SO_REUSEADDR): error");

	memset(&listenname, 0, sizeof(struct sockaddr_in));
	listenname.sin_family = AF_INET;
	listenname.sin_port = htons(port); //포트설정
	listenname.sin_addr.s_addr = htonl(INADDR_ANY); //모든 IP로 부터 수신

	if (bind(s, (struct sockaddr *)&listenname, sizeof(struct sockaddr_in)) < 0)
	{
		dlog_print(DLOG_ERROR, "tdlna", "bind(http): error\n");
		close(s);
		return -1;
	}

	if (listen(s, 6) < 0)
	{
		dlog_print(DLOG_ERROR, "tdlna", "listen(http): error\n");
		close(s);
		return -1;
	}

	return s;
}


//네트워크 인터페이스 설정
static int getifaddr(const char *ifname)
{
	int s = socket(PF_INET, SOCK_STREAM, 0);
	struct sockaddr_in addr;
	struct ifconf ifc;
	struct ifreq *ifr;
	char buf[8192];
	int i, n;

	memset(&ifc, '\0', sizeof(ifc));
	ifc.ifc_buf = buf;
	ifc.ifc_len = sizeof(buf);

	if (ioctl(s, SIOCGIFCONF, &ifc) < 0)
	{
		dlog_print(DLOG_INFO, "tdlna", "SIOCGIFCONF: %s\n", strerror(errno));
		close(s);
		return -1;
	}

	n = ifc.ifc_len / sizeof(struct ifreq);
	for (i = 0; i < n; i++)
	{
		ifr = &ifc.ifc_req[i];
		if (ifname && strcmp(ifr->ifr_name, ifname) != 0)
			continue;
		if (!ifname &&
		    (ioctl(s, SIOCGIFFLAGS, ifr) < 0 || ifr->ifr_ifru.ifru_flags & IFF_LOOPBACK))
			continue;
		if (ioctl(s, SIOCGIFADDR, ifr) < 0)
			continue;
		memcpy(&addr, &(ifr->ifr_addr), sizeof(addr));
		memcpy(&lan_addr[n_lan_addr].addr, &addr.sin_addr, sizeof(lan_addr[n_lan_addr].addr));
		if (!inet_ntop(AF_INET, &addr.sin_addr, lan_addr[n_lan_addr].str, sizeof(lan_addr[0].str)))
		{
			dlog_print(DLOG_INFO, "tdlna", "inet_ntop(): %s\n", strerror(errno));
			close(s);
			continue;
		}
		if (ioctl(s, SIOCGIFNETMASK, ifr) < 0)
			continue;
		memcpy(&addr, &(ifr->ifr_addr), sizeof(addr));
		memcpy(&lan_addr[n_lan_addr].mask, &addr.sin_addr, sizeof(addr));
		lan_addr[n_lan_addr].ifindex = if_nametoindex(ifr->ifr_name);
		lan_addr[n_lan_addr].snotify = OpenAndConfSSDPNotifySocket(&lan_addr[n_lan_addr]);
		if (lan_addr[n_lan_addr].snotify >= 0)
			n_lan_addr++;
		if (ifname || n_lan_addr >= MAX_LAN_ADDR)
			break;
	}
	close(s);
	if (ifname && i == n)
	{
		dlog_print(DLOG_ERROR, "tdlna", "Network interface %s not found\n", ifname);
		return -1;
	}

	return n_lan_addr;
}

//인터페이스 초기화
void reload_ifaces(int force_notify)
{
	struct in_addr old_addr[4];
	int i, j;

	memset(&old_addr, 0xFF, sizeof(old_addr));
	for (i = 0; i < n_lan_addr; i++)
	{
		memcpy(&old_addr[i], &lan_addr[i].addr, sizeof(struct in_addr));
		close(lan_addr[i].snotify);
	}
	n_lan_addr = 0;

	i = 0;
	do {
		getifaddr(runtime_vars.ifaces[i]);
		i++;
	} while (runtime_vars.ifaces[i]);

	for (i = 0; i < n_lan_addr; i++)
	{
		for (j = 0; j < MAX_LAN_ADDR; j++)
		{
			if (memcmp(&lan_addr[i].addr, &old_addr[j], sizeof(struct in_addr)) == 0)
				break;
		}
		//Send out startup notifies if it's a new interface, or on SIGHUP 
		if (force_notify || j == MAX_LAN_ADDR)
		{
			dlog_print(DLOG_INFO, "tdlna", "Enabling interface %s/%s\n",
				lan_addr[i].str, inet_ntoa(lan_addr[i].mask));
			SendSSDPGoodbyes(lan_addr[i].snotify);
			SendSSDPNotifies(lan_addr[i].snotify, lan_addr[i].str, runtime_vars.port, runtime_vars.notify_interval);
		}
	}
}


