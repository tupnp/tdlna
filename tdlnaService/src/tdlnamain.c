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
#include <system_settings.h>   //serUUID (getMAC Addr)
#include <wifi.h>
#include <device/power.h>

#include "upnphttp.h"
#include "upnpglobalvars.h"
#include "upnpevents.h"
#include "clients.h"
#include "upnpssdp.h"
#include "upnpsoap.h"
#include "main-app.h"
#include "tdlnamain.h"

//서비스 시작
int serviceOn(void* data){
	app_data *ad = data;
	int r;


	if(!WifiState())
	{
		dlog_print(DLOG_ERROR,"tdlna_wifi", "WIFI 실행이 안되어 있습니다. 종료합니다. %d", ad->tdlna_td);
		return 0;
	}

	if(ad->tdlna_td != 0){
		dlog_print(DLOG_ERROR,"tdlna", "이전 실행된 서비스가 정상적으로 종료되지 않았습니다. %d", ad->tdlna_td);
		return 0;
	}

	ad->run_tdlna = true;
	r = pthread_create(&(ad->tdlna_td), NULL, tdlnamain, (void*)data);

	dlog_print(DLOG_INFO,"tdlna", "◆ 서비스 스레드 생성: %d", r);

	return 1;
}

//서비스 종료
int serviceOff(void* data){
	app_data *ad = data;
	int status;
	int r = 0;
	ad->run_tdlna = false;

	if(ad->tdlna_td){
		r = pthread_join(ad->tdlna_td,  (void *)&status);
		ad->tdlna_td = 0;
	}

	dlog_print(DLOG_INFO,"tdlna","tdlna 스레드 종료: %d", r);
	return 1;
}

void setUUID()
{
	   struct ifreq ifr;
	   int fd;
	   char mac[6];
	   char buf[13];
	   fd = socket(AF_INET, SOCK_DGRAM, 0);      //소켓 생성
	   strncpy(ifr.ifr_name, "wlan0", IFNAMSIZ);   //interface의 eth0 등록.
	   ioctl(fd, SIOCGIFHWADDR, &ifr);            //연결시도.
	   close(fd);                           //소켓 닫음

	   memcpy(mac, ifr.ifr_hwaddr.sa_data, 6);      //가져온다.
	   dlog_print(DLOG_INFO, "tdlna","MAC[wlan0]: %02x:%02x:%02x:%02x:%02x:%02x\n", mac[0], mac[1], mac[2], mac[3], mac[4], mac[5]);
	   sprintf(buf, "%02x%02x%02x%02x%02x%02x", mac[0]&0xFF, mac[1]&0xFF, mac[2]&0xFF,mac[3]&0xFF, mac[4]&0xFF, mac[5]&0xFF);
	   strcpy(uuidvalue+5, "3d696e69-444c-164e-9d41-");
	   strncat(uuidvalue, buf, 12);
	   dlog_print(DLOG_INFO, "tdlna","uuid설정: %s", uuidvalue);
}

//디바이스명 등의 환경설정 적용하는부분
void setDeviceProperty(void* data){

	app_data *ad = data;
	char* dName = ad->deviceName;
	bool saveState = ad->run_tdlna;

	//설정값이 기존 값이랑 동일하다면 아무일 안함
	if(!strcmp(modelname, dName)) return;

	//기존 서비스 가동중이라면 중지
	if(ad->run_tdlna == true){
		serviceOff(data);
	}

	sprintf(modelname, "%s", dName);
	if(saveState == true){
		//sleep(1);
		serviceOn(data); //(기존 가동상태였다면)변경 후 서비스 재시작
	}
}

void sSleep(app_data* data, int sTime){
	unsigned long long i, dst;
	dst = sTime*1000;
	for(i=0; i<dst && data->run_tdlna; i++){
		usleep(1000);
	}
}

void* ssdpAlive(void* data){
	app_data *ad = data;

	while(ad->run_tdlna){
		//dlog_print(DLOG_INFO, "tdlna", "SSDP Alive (run:%d)", ad->run_tdlna);
		SendSSDPNotifies(lan_addr[0].snotify, lan_addr[0].str, runtime_vars.port, runtime_vars.notify_interval);
		//sSleep(ad, runtime_vars.notify_interval - 10 ); // 딜레이를 기존보다 10초 정도 적게 보냄
		sSleep(ad, 5);
		cpu_power_lock();
	}

	dlog_print(DLOG_INFO, "tdlna", "(Thread) GoodBye~ (ssdp) %d", ad->run_tdlna);
	SendSSDPGoodbyes(lan_addr[0].snotify);

	return NULL;
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
static int getifaddr(const char *ifname, int sssdpr)
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
		    (ioctl(s, SIOCGIFFLAGS, ifr) < 0 || (ifr->ifr_ifru.ifru_flags & IFF_LOOPBACK)))
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
		lan_addr[n_lan_addr].snotify = OpenAndConfSSDPNotifySocket(&lan_addr[n_lan_addr], sssdpr);
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
static void reload_ifaces(int force_notify, int sssdpr)
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
		getifaddr(runtime_vars.ifaces[i], sssdpr);
		i++;
	} while (runtime_vars.ifaces[i]);

	for (i = 0; i < n_lan_addr; i++)
	{
		for (j = 0; j < MAX_LAN_ADDR; j++)
		{
			if (memcmp(&lan_addr[i].addr, &old_addr[j], sizeof(struct in_addr)) == 0)
				break;
		}
		//초기 ssdp 패킷을 보낼때 모든 네트워크로 ssdp byebye를 먼저 보낸 후
		// ssdi alive notifiy를 보낸다.
		if (force_notify || j == MAX_LAN_ADDR)
		{
			dlog_print(DLOG_DEBUG, "tdlna", "Enabling interface %s/%s\n",
					lan_addr[i].str, inet_ntoa(lan_addr[i].mask));
			SendSSDPGoodbyes(lan_addr[i].snotify);
			SendSSDPNotifies(lan_addr[i].snotify, lan_addr[i].str, runtime_vars.port, runtime_vars.notify_interval);
		}
	}
}

//  upnp server main
void* tdlnamain(void* data)
{
		app_data *ad = data;
		pthread_t ssdptd; //ssdp alive thread

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

		dlog_print(DLOG_INFO, "tdlna", "tdlna Server Main Start!!!");

		//초기화
		runtime_vars.port = 9090; //http요청 수신 포트
		runtime_vars.notify_interval = 20; //ssdp notify알림주기(sec)
		runtime_vars.max_connections = 50; //최대 접속수
		runtime_vars.root_container = NULL;
		runtime_vars.ifaces[0] = NULL;

		//디바이스 이름 설정
		strcpy(modelname, ad->deviceName);
		//UUID 설정
		setUUID();
		SetAppDataSoap(ad); //Soap.c에서 사용할 appData설정

		//http요청 리스트 초기화
		LIST_INIT(&upnphttphead);

		shttpl = OpenAndConfHTTPSocket(runtime_vars.port); // Http 수신 소켓 설정

		if (shttpl < 0)
		{
			close(shttpl);
			dlog_print(DLOG_ERROR, "tdlna", "HTTP 수신 소켓 실패");
			ad->run_tdlna = false;
			//serviceOff(data);
			return 0;
		}
		else
			dlog_print(DLOG_INFO, "tdlna", "shttpl: %d\n", shttpl);

		sssdp = OpenAndConfSSDPReceiveSocket();
		if (sssdp < 0)
			dlog_print(DLOG_ERROR, "tdlna", "SSDP 수신 소켓 실패");

		dlog_print(DLOG_DEBUG, "tdlna", "sssdp (Recivce): %d", sssdp);

		reload_ifaces(0, sssdp); //인터페이스 리로드(기존 연결된 기기들이 있으면 끊고 다시 ssdp알림 발송)

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

			i = 0;	//연결 되어있는 http소켓 카운트
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
				if(!ad->run_tdlna) goto shutdown;
				if(errno == EINTR) continue;
			}

			//upnpevents_processfds(&readset, &writeset);

//			//SSDP패킷 처리
			if (sssdp >= 0) //|| FD_ISSET(sssdp, &readset))
			{
				//dlog_print(DLOG_INFO, "tdlna", "▶ 메인에서 SSDP 처리 들어옴 %d", sssdp);
				ProcessSSDPRequest(sssdp, (unsigned short)runtime_vars.port);
			}

			//리스트에 접속된 http요청을 처리한다.
			for (e = upnphttphead.lh_first; e != NULL; e = e->entries.le_next)
			{

				if ((e->socket >= 0) && (e->state <= 2) && (FD_ISSET(e->socket, &readset)))
				{
					//dlog_print(DLOG_INFO, "tdlna", "Process_upnpHttp 호출");
					Process_upnphttp(e); // 본격적 처리부분
				}
			}

			// 들어오는 http연결이 있으면 수락한 후 리스트에 추가한다.
			if (shttpl >= 0  && FD_ISSET(shttpl, &readset))
			{
				int shttp;
				socklen_t clientnamelen;
				struct sockaddr_in clientname;
				clientnamelen = sizeof(struct sockaddr_in);

				//수락
				shttp = accept(shttpl, (struct sockaddr *) &clientname, &clientnamelen);

				//dlog_print(DLOG_INFO, "tdlna", "shttp accept!");

				if(shttp <0)
					dlog_print(DLOG_ERROR, "tdlna", "Http accept error !!!");
				else{
					//dlog_print(DLOG_INFO, "tdlna", "client socket: %d\n", shttp);

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
			}

			//연결이 끊긴 소켓 헤제
			for (e = upnphttphead.lh_first; e != NULL; e = next)
			{
				next = e->entries.le_next;
				if(e->state >= 100)
				{
					//dlog_print(DLOG_INFO, "tdlna", "Delete upnphttp (%d)", e->clientaddr);
					LIST_REMOVE(e, entries);
					Delete_upnphttp(e);
				}
			}

		}
	//Main Loop End


shutdown:
		dlog_print(DLOG_INFO, "tdlna", "+=== Shutdown ====+\n");


		// 연결된 모든 소켓을 닫는다.
		while (upnphttphead.lh_first != NULL)
		{
			e = upnphttphead.lh_first;
			LIST_REMOVE(e, entries);
			Delete_upnphttp(e);
		}

//		if (sssdp >= 0)
//			close(sssdp);
		if (shttpl >= 0)
			close(shttpl);

		//ssdp Alive 스레드가 완전히 종료되기를 기다린다.
		if (ssdptd)
			pthread_join(ssdptd, NULL);

		//종료시 네트워크의 모든 인터페이스로 ssdp byebye패킷을 보낸다.
		for (i = 0; i < n_lan_addr; i++)
		{
			SendSSDPGoodbyes(lan_addr[i].snotify);
			close(lan_addr[i].snotify);
			dlog_print(DLOG_INFO, "tdlna", "send ByeBye");
		}

		upnpevents_removeSubscribers();

		dlog_print(DLOG_INFO, "tdlna", "+=== tdlna 종료!! ====+\n");
		return 0;
}

// WIFI state
int WifiState()
{
   wifi_connection_state_e connection_state;
   int error_code = 0;
   wifi_ap_h ap;

   // wifi 초기화
   error_code = wifi_initialize();
   if (error_code != WIFI_ERROR_NONE)
   {
      dlog_print(DLOG_DEBUG, "tdlna_wifi", "wifi_Initialize_not");
   }

   error_code = wifi_get_connection_state(&connection_state);
      if(error_code != WIFI_ERROR_NONE)
   {
      dlog_print(DLOG_DEBUG, "tdlna_wifi", "WIFI _ 1");
      return 0;
   }
    else if(connection_state == WIFI_CONNECTION_STATE_CONNECTED)
    {
      error_code = wifi_get_connected_ap(&ap);
      if(error_code != WIFI_ERROR_NONE)
      {
         wifi_ap_destroy(ap);
         return 0;
      }

      error_code = wifi_ap_get_connection_state(ap, &connection_state);
      if(error_code == WIFI_ERROR_NONE && connection_state == WIFI_CONNECTION_STATE_CONNECTED)
      {
         wifi_ap_destroy(ap);
         return 1;
      }

      if(connection_state == WIFI_CONNECTION_STATE_CONNECTED)
      {
         return 1;
      }
      wifi_ap_destroy(ap);
   }

    if(connection_state == 3)
    {
       return 1;
    }else
    {
      return 0;
    }
}

void cpu_power_lock()
{
     int error;
     error = device_power_request_lock(POWER_LOCK_CPU, 0);
}
