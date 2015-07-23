#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <unistd.h>
#include <sys/socket.h>
#include <sys/un.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <errno.h>
#include <dlog.h>

#include "upnphttp.h"
#include "upnpglobalvars.h"
#include "upnpssdp.h"

/* SSDP ip/port */
#define SSDP_PORT 1900
#define SSDP_MCAST_ADDR "239.255.255.250"


//m-search에 응답하는 클라이언트 목록 등록
static int
AddMulticastMembership(int s, struct lan_addr_s *iface)
{
	int ret;

	struct ip_mreq imr;	/* Ip multicast membership */
	/* setting up imr structure */
	memset(&imr, '\0', sizeof(imr));
	imr.imr_multiaddr.s_addr = inet_addr(SSDP_MCAST_ADDR);
	imr.imr_interface.s_addr = iface->addr.s_addr;

	ret = setsockopt(s, IPPROTO_IP, IP_ADD_MEMBERSHIP, (void *)&imr, sizeof(imr));
	if (ret < 0 && errno != EADDRINUSE)
	{
		printf("setsockopt(udp, IP_ADD_MEMBERSHIP): %s\n",
			strerror(errno));
		return -1;
	}

	return 0;
}

// SSDP udp 패킷 전송 239.255.255.250 port 1900
//SSDP 수신 소켓 설정 함수
int
OpenAndConfSSDPReceiveSocket(void)
{
	int s;
	int i = 1;
	struct sockaddr_in sockname;
	
	s = socket(PF_INET, SOCK_DGRAM, 0);
	if (s < 0)
	{
		printf("socket(udp): %s\n", strerror(errno));
		return -1;
	}	

	if (setsockopt(s, SOL_SOCKET, SO_REUSEADDR, &i, sizeof(i)) < 0)
		dlog_print(DLOG_ERROR,"setsockopt(udp, SO_REUSEADDR): %s\n", strerror(errno));
	
	memset(&sockname, 0, sizeof(struct sockaddr_in));
	sockname.sin_family = AF_INET;
	sockname.sin_port = htons(SSDP_PORT);
	sockname.sin_addr.s_addr = htonl(INADDR_ANY);

	if (bind(s, (struct sockaddr *)&sockname, sizeof(struct sockaddr_in)) < 0)
	{
		printf("bind(udp): %s\n", strerror(errno));
		close(s);
		return -1;
	}

	return s;
}

//SSDP Notify 전송 소켓 설정
int
OpenAndConfSSDPNotifySocket(struct lan_addr_s *iface)
{
	int s;
	unsigned char loopchar = 0;
	int bcast = 1;
	uint8_t ttl = 4;
	struct in_addr mc_if;
	struct sockaddr_in sockname;
	
	s = socket(PF_INET, SOCK_DGRAM, 0);
	if (s < 0)
	{
		printf("socket(udp_notify): %s\n", strerror(errno));
		return -1;
	}

	mc_if.s_addr = iface->addr.s_addr;

	if (setsockopt(s, IPPROTO_IP, IP_MULTICAST_LOOP, (char *)&loopchar, sizeof(loopchar)) < 0)
	{
		printf("setsockopt(udp_notify, IP_MULTICAST_LOOP): %s\n", strerror(errno));
		close(s);
		return -1;
	}

	if (setsockopt(s, IPPROTO_IP, IP_MULTICAST_IF, (char *)&mc_if, sizeof(mc_if)) < 0)
	{
		printf("setsockopt(udp_notify, IP_MULTICAST_IF): %s\n", strerror(errno));
		close(s);
		return -1;
	}

	setsockopt(s, IPPROTO_IP, IP_MULTICAST_TTL, &ttl, sizeof(ttl));
	
	if (setsockopt(s, SOL_SOCKET, SO_BROADCAST, &bcast, sizeof(bcast)) < 0)
	{
		printf("setsockopt(udp_notify, SO_BROADCAST): %s\n", strerror(errno));
		close(s);
		return -1;
	}

	memset(&sockname, 0, sizeof(struct sockaddr_in));
	sockname.sin_family = AF_INET;
	sockname.sin_addr.s_addr = iface->addr.s_addr;

	if (bind(s, (struct sockaddr *)&sockname, sizeof(struct sockaddr_in)) < 0)
	{
		printf("bind(udp_notify): %s\n", strerror(errno));
		close(s);
		return -1;
	}

	if (AddMulticastMembership(sssdp, iface) < 0)
	{
		printf("Failed to add multicast membership for address %s\n", 
			iface->str);
	}

	return s;
}

static const char * const known_service_types[] =
{
	uuidvalue,
	"upnp:rootdevice",
	"urn:schemas-upnp-org:device:MediaServer:",
	"urn:schemas-upnp-org:service:ContentDirectory:",
	"urn:schemas-upnp-org:service:ConnectionManager:",
//	"urn:microsoft.com:service:X_MS_MediaReceiverRegistrar:",
	0
};

static void
_usleep(long usecs)
{
	struct timespec sleep_time;

	sleep_time.tv_sec = 0;
	sleep_time.tv_nsec = usecs * 1000;
	nanosleep(&sleep_time, NULL);
}

/* not really an SSDP "announce" as it is the response
 * to a SSDP "M-SEARCH" */
static void
SendSSDPResponse(int s, struct sockaddr_in sockname, int st_no,
                  const char *host, unsigned short port)
{
	int l, n;
	char buf[512];
	char tmstr[30];
	time_t tm = time(NULL);

	/*
	 * follow guideline from document "UPnP Device Architecture 1.0"
	 * uppercase is recommended.
	 * DATE: is recommended
	 * SERVER: OS/ver UPnP/1.0 minidlna/1.0
	 * - check what to put in the 'Cache-Control' header 
	 * */
	strftime(tmstr, sizeof(tmstr), "%a, %d %b %Y %H:%M:%S GMT", gmtime(&tm));
	l = snprintf(buf, sizeof(buf), "HTTP/1.1 200 OK\r\n"
		"CACHE-CONTROL: max-age=%u\r\n"
		"DATE: %s\r\n"
		"ST: %s%s\r\n"
		"USN: %s%s%s%s\r\n"
		"EXT:\r\n"
		"SERVER: " MINIDLNA_SERVER_STRING "\r\n"
		"LOCATION: http://%s:%u" ROOTDESC_PATH "\r\n"
		"Content-Length: 0\r\n"
		"\r\n",
		(runtime_vars.notify_interval<<1)+10,
		tmstr,
		known_service_types[st_no],
		(st_no > 1 ? "1" : ""),
		uuidvalue,
		(st_no > 0 ? "::" : ""),
		(st_no > 0 ? known_service_types[st_no] : ""),
		(st_no > 1 ? "1" : ""),
		host, (unsigned int)port);
	printf("Sending M-SEARCH response to %s:%d ST: %s\n",
		inet_ntoa(sockname.sin_addr), ntohs(sockname.sin_port),
		known_service_types[st_no]);
	n = sendto(s, buf, l, 0,
	           (struct sockaddr *)&sockname, sizeof(struct sockaddr_in) );
	if (n < 0)
		printf("sendto(udp): %s\n", strerror(errno));
}

void
SendSSDPNotifies(int s, const char *host, unsigned short port,
                 unsigned int interval)
{
	struct sockaddr_in sockname;
	int l, n, dup, i=0;
	unsigned int lifetime;
	char bufr[512];

	memset(&sockname, 0, sizeof(struct sockaddr_in));
	sockname.sin_family = AF_INET;
	sockname.sin_port = htons(SSDP_PORT);
	sockname.sin_addr.s_addr = inet_addr(SSDP_MCAST_ADDR);
	//lifetime = interval;//(interval << 1) + 10;
	lifetime = 1800;

	for (dup = 0; dup < 2; dup++)
	{
		if (dup)
			_usleep(200000);
		i = 0;
		while (known_service_types[i])
		{
			l = snprintf(bufr, sizeof(bufr), 
					"NOTIFY * HTTP/1.1\r\n"
					"HOST:%s:%d\r\n"
					"CACHE-CONTROL:max-age=%u\r\n"
					"LOCATION:http://%s:%d" ROOTDESC_PATH"\r\n"
					"SERVER: " MINIDLNA_SERVER_STRING "\r\n"
					"NT:%s%s\r\n"
					"USN:%s%s%s%s\r\n"
					"NTS:ssdp:alive\r\n"
					"\r\n",
					SSDP_MCAST_ADDR, SSDP_PORT,
					lifetime,
					host, port,
					known_service_types[i],
					(i > 1 ? "1" : ""),
					uuidvalue,
					(i > 0 ? "::" : ""),
					(i > 0 ? known_service_types[i] : ""),
					(i > 1 ? "1" : ""));
			if (l >= sizeof(bufr))
			{
				printf("SendSSDPNotifies(): truncated output\n");
				l = sizeof(bufr);
			}
			//printf("Sending ssdp:alive [%d]\n", s);
			n = sendto(s, bufr, l, 0,
				(struct sockaddr *)&sockname, sizeof(struct sockaddr_in));
			if (n < 0)
				printf("sendto(udp_notify=%d, %s): %s\n", s, host, strerror(errno));
			i++;
		}
	}

	printf("Send ssdp:alive \n");
}


/*
void
ParseUPnPClient(char *location)
{
	char buf[8192];
	struct sockaddr_in dest;
	int s, n, do_headers = 0, nread = 0;
	struct timeval tv;
	char *addr, *path, *port_str;
	long port = 80;
	char *off = NULL, *p;
	int content_len = sizeof(buf);
	struct NameValueParserData xml;
	struct client_cache_s *client;
	int type = 0;
	char *model, *serial, *name;

	if (strncmp(location, "http://", 7) != 0)
		return;
	path = location + 7;
	port_str = strsep(&path, "/");
	if (!path)
		return;
	addr = strsep(&port_str, ":");
	if (port_str)
	{
		port = strtol(port_str, NULL, 10);
		if (!port)
			port = 80;
	}

	memset(&dest, '\0', sizeof(dest));
	if (!inet_aton(addr, &dest.sin_addr))
		return;
	// Check if the client is already in cache 
	dest.sin_family = AF_INET;
	dest.sin_port = htons(port);

	s = socket(PF_INET, SOCK_STREAM, 0);
	if (s < 0)
		return;

	tv.tv_sec = 0;
	tv.tv_usec = 500000;
	setsockopt(s, SOL_SOCKET, SO_RCVTIMEO, &tv, sizeof(tv));
	setsockopt(s, SOL_SOCKET, SO_SNDTIMEO, &tv, sizeof(tv));

	if (connect(s, (struct sockaddr*)&dest, sizeof(struct sockaddr_in)) < 0)
		goto close;

	n = snprintf(buf, sizeof(buf), "GET /%s HTTP/1.0\r\n"
	                               "HOST: %s:%ld\r\n\r\n",
	                               path, addr, port);
	if (write(s, buf, n) < 1)
		goto close;

	while ((n = read(s, buf+nread, sizeof(buf)-nread-1)) > 0)
	{
		nread += n;
		buf[nread] = '\0';
		n = nread - 4;
		p = buf;

		while (!off && (n-- > 0))
		{
			if (p[0] == '\r' && p[1] == '\n' && p[2] == '\r' && p[3] == '\n')
			{
				off = p + 4;
				do_headers = 1;
			}
			p++;
		}
		if (!off)
			continue;

		if (do_headers)
		{
			p = buf;
			if (strncmp(p, "HTTP/", 5) != 0)
				goto close;
			while (*p != ' ' && *p != '\t')
				p++;
			// If we don't get a 200 status, ignore it 
			if (strtol(p, NULL, 10) != 200)
				goto close;
			p = strcasestr(p, "Content-Length:");
			if (p)
				content_len = strtol(p+15, NULL, 10);
			do_headers = 0;
		}
		if ((buf + nread - off) >= content_len)
			break;
	}
close:
	close(s);
	if (!off)
		return;
	nread -= off - buf;
	ParseNameValue(off, nread, &xml, 0);
	model = GetValueFromNameValueList(&xml, "modelName");
	serial = GetValueFromNameValueList(&xml, "serialNumber");
	name = GetValueFromNameValueList(&xml, "friendlyName");
	if (model)
	{
		int i;
		DPRINTF(E_DEBUG, L_SSDP, "Model: %s\n", model);
		for (i = 0; client_types[i].name; i++)
		{
			if (client_types[i].match_type != EModelName)
				continue;
			if (strstr(model, client_types[i].match) != NULL)
			{
				type = i;
				break;
			}
		}

		// Special Samsung handling.  It's very hard to tell Series A from B 
		if (type > 0 && client_types[type].type == ESamsungSeriesB)
		{
			if (serial)
			{
				DPRINTF(E_DEBUG, L_SSDP, "Serial: %s\n", serial);
				//* The Series B I saw was 20081224DMR.  Series A should be older than that.
				if (atoi(serial) < 20081201)
					type = 0;
			}
			else
			{
				type = 0;
			}
		}

		if (type == 0 && name != NULL)
		{
			for (i = 0; client_types[i].name; i++)
			{
				if (client_types[i].match_type != EFriendlyNameSSDP)
					continue;
				if (strcmp(name, client_types[i].match) == 0)
				{
					type = i;
					break;
				}
			}
		}
	}
	ClearNameValueList(&xml);
	if (!type)
		return;
	// Add this client to the cache if it's not there already.
	client = SearchClientCache(dest.sin_addr, 1);
	if (!client)
	{
		AddClientCache(dest.sin_addr, type);
	}
	else
	{
		client->type = &client_types[type];
		client->age = time(NULL);
	}
}
*/


// ProcessSSDPRequest()
// process SSDP M-SEARCH requests and responds to them 
/*
void
ProcessSSDPRequest(int s, unsigned short port)
{
	int n;
	char bufr[1500];
	socklen_t len_r;
	struct sockaddr_in sendername;
	int i;
	char *st = NULL, *mx = NULL, *man = NULL, *mx_end = NULL;
	int man_len = 0;
	len_r = sizeof(struct sockaddr_in);

	n = recvfrom(s, bufr, sizeof(bufr)-1, 0,
	             (struct sockaddr *)&sendername, &len_r);
	if (n < 0)
	{
		DPRINTF(E_ERROR, L_SSDP, "recvfrom(udp): %s\n", strerror(errno));
		return;
	}
	bufr[n] = '\0';
	n -= 2;

	if (memcmp(bufr, "NOTIFY", 6) == 0)
	{
		char *loc = NULL, *srv = NULL, *nts = NULL, *nt = NULL;
		int loc_len = 0;
		//DEBUG DPRINTF(E_DEBUG, L_SSDP, "Received SSDP notify:\n%.*s", n, bufr);
		for (i = 0; i < n; i++)
		{
			if( bufr[i] == '*' )
				break;
		}
		if (strcasestrc(bufr+i, "HTTP/1.1", '\r') == NULL)
			return;
		while (i < n)
		{
			while ((i < n) && (bufr[i] != '\r' || bufr[i+1] != '\n'))
				i++;
			i += 2;
			if (strncasecmp(bufr+i, "SERVER:", 7) == 0)
			{
				srv = bufr+i+7;
				while (*srv == ' ' || *srv == '\t')
					srv++;
			}
			else if (strncasecmp(bufr+i, "LOCATION:", 9) == 0)
			{
				loc = bufr+i+9;
				while (*loc == ' ' || *loc == '\t')
					loc++;
				while (loc[loc_len]!='\r' && loc[loc_len]!='\n')
					loc_len++;
			}
			else if (strncasecmp(bufr+i, "NTS:", 4) == 0)
			{
				nts = bufr+i+4;
				while (*nts == ' ' || *nts == '\t')
					nts++;
			}
			else if (strncasecmp(bufr+i, "NT:", 3) == 0)
			{
				nt = bufr+i+3;
				while(*nt == ' ' || *nt == '\t')
					nt++;
			}
		}
		if (!loc || !srv || !nt || !nts || (strncmp(nts, "ssdp:alive", 10) != 0) ||
		    (strncmp(nt, "urn:schemas-upnp-org:device:MediaRenderer", 41) != 0))
			return;
		loc[loc_len] = '\0';
		if ((strncmp(srv, "Allegro-Software-RomPlug", 24) == 0) || //* Roku
		    (strstr(loc, "SamsungMRDesc.xml") != NULL) || //* Samsung TV
		    (strstrc(srv, "DigiOn DiXiM", '\r') != NULL)) //* Marantz Receiver
		{
			//Check if the client is already in cache 
			struct client_cache_s *client = SearchClientCache(sendername.sin_addr, 1);
			if (client)
			{
				if (client->type->type < EStandardDLNA150 &&
				    client->type->type != ESamsungSeriesA)
				{
					client->age = time(NULL);
					return;
				}
			}
			ParseUPnPClient(loc);
		}
	}
	else if (memcmp(bufr, "M-SEARCH", 8) == 0)
	{
		int st_len = 0, mx_len = 0, mx_val = 0;
		//DPRINTF(E_DEBUG, L_SSDP, "Received SSDP request:\n%.*s\n", n, bufr);
		for (i = 0; i < n; i++)
		{
			if (bufr[i] == '*')
				break;
		}
		if (strcasestrc(bufr+i, "HTTP/1.1", '\r') == NULL)
			return;
		while (i < n)
		{
			while ((i < n) && (bufr[i] != '\r' || bufr[i+1] != '\n'))
				i++;
			i += 2;
			if (strncasecmp(bufr+i, "ST:", 3) == 0)
			{
				st = bufr+i+3;
				st_len = 0;
				while (*st == ' ' || *st == '\t')
					st++;
				while (st[st_len]!='\r' && st[st_len]!='\n')
					st_len++;
			}
			else if (strncasecmp(bufr+i, "MX:", 3) == 0)
			{
				mx = bufr+i+3;
				mx_len = 0;
				while (*mx == ' ' || *mx == '\t')
					mx++;
				while (mx[mx_len]!='\r' && mx[mx_len]!='\n')
					mx_len++;
				mx_val = strtol(mx, &mx_end, 10);
			}
			else if (strncasecmp(bufr+i, "MAN:", 4) == 0)
			{
				man = bufr+i+4;
				man_len = 0;
				while (*man == ' ' || *man == '\t')
					man++;
				while (man[man_len]!='\r' && man[man_len]!='\n')
					man_len++;
			}
		}
		//DPRINTF(E_INFO, L_SSDP, "SSDP M-SEARCH packet received from %s:%d\n",
		//	inet_ntoa(sendername.sin_addr), ntohs(sendername.sin_port) );
		if (GETFLAG(DLNA_STRICT_MASK) && (ntohs(sendername.sin_port) <= 1024 || ntohs(sendername.sin_port) == 1900))
		{
			DPRINTF(E_INFO, L_SSDP, "WARNING: Ignoring invalid SSDP M-SEARCH from %s [bad source port %d]\n",
				inet_ntoa(sendername.sin_addr), ntohs(sendername.sin_port));
		}
		else if (!man || (strncmp(man, "\"ssdp:discover\"", 15) != 0))
		{
			DPRINTF(E_INFO, L_SSDP, "WARNING: Ignoring invalid SSDP M-SEARCH from %s [bad %s header '%.*s']\n",
				inet_ntoa(sendername.sin_addr), "MAN", man_len, man);
		}
		else if (!mx || mx == mx_end || mx_val < 0)
		{
			DPRINTF(E_INFO, L_SSDP, "WARNING: Ignoring invalid SSDP M-SEARCH from %s [bad %s header '%.*s']\n",
				inet_ntoa(sendername.sin_addr), "MX", mx_len, mx);
		}
		else if (st && (st_len > 0))
		{
			int l;
			int iface = 0;
			// find in which sub network the client is 
			for (i = 0; i < n_lan_addr; i++)
			{
				if((sendername.sin_addr.s_addr & lan_addr[i].mask.s_addr) ==
				   (lan_addr[i].addr.s_addr & lan_addr[i].mask.s_addr))
				{
					iface = i;
					break;
				}
			}
			if (n_lan_addr == i)
			{
				DPRINTF(E_DEBUG, L_SSDP, "Ignoring SSDP M-SEARCH on other interface [%s]\n",
					inet_ntoa(sendername.sin_addr));
				return;
			}
			DPRINTF(E_DEBUG, L_SSDP, "SSDP M-SEARCH from %s:%d ST: %.*s, MX: %.*s, MAN: %.*s\n",
				inet_ntoa(sendername.sin_addr),
				ntohs(sendername.sin_port),
				st_len, st, mx_len, mx, man_len, man);
			// Responds to request with a device as ST header 
			for (i = 0; known_service_types[i]; i++)
			{
				l = strlen(known_service_types[i]);
				if ((l > st_len) || (memcmp(st, known_service_types[i], l) != 0))
					continue;
				if (st_len != l)
				{
					// Check version number - we only support 1. 
					if ((st[l-1] == ':') && (st[l] == '1'))
						l++;
					while (l < st_len)
					{
						if (isdigit(st[l]))
							break;
						if (isspace(st[l]))
						{
							l++;
							continue;
						}
						DPRINTF(E_MAXDEBUG, L_SSDP,
							"Ignoring SSDP M-SEARCH with bad extra data '%c' [%s]\n",
							st[l], inet_ntoa(sendername.sin_addr));
						break;
					}
					if (l != st_len)
						break;
				}
				_usleep(random()>>20);
				SendSSDPResponse(s, sendername, i,
						lan_addr[iface].str, port);
				return;
			}
			// Responds to request with ST: ssdp:all
			// strlen("ssdp:all") == 8
			if ((st_len == 8) && (memcmp(st, "ssdp:all", 8) == 0))
			{
				for (i=0; known_service_types[i]; i++)
				{
					l = strlen(known_service_types[i]);
					SendSSDPResponse(s, sendername, i,
							lan_addr[iface].str, port);
				}
			}
		}
		else
		{
			DPRINTF(E_INFO, L_SSDP, "Invalid SSDP M-SEARCH from %s:%d\n",
				inet_ntoa(sendername.sin_addr), ntohs(sendername.sin_port));
		}
	}
	else if (memcmp(bufr, "YOUKU-NOTIFY", 12) == 0)
	{
		return;
	}
	else
	{
		DPRINTF(E_WARN, L_SSDP, "Unknown udp packet received from %s:%d\n",
			inet_ntoa(sendername.sin_addr), ntohs(sendername.sin_port));
	}
}
*/

//M-Search 패킷 테스트용
int JustSend_M_Search(int s)
{
	struct sockaddr_in sockname;
	int n, l;
	int i;
	int dup, ret = 0;
	char bufr[512];

	memset(&sockname, 0, sizeof(struct sockaddr_in));
	sockname.sin_family = AF_INET;
	sockname.sin_port = htons(SSDP_PORT);
	sockname.sin_addr.s_addr = inet_addr(SSDP_MCAST_ADDR);


	for (i = 0; i<1 /*known_service_types[i]*/; i++)
	{
		l = snprintf(bufr, sizeof(bufr),
				"M-SEARCH * HTTP/1.1\r\n"
				"HOST:239.255.255.255:1900\r\n"
				"MAN: \"ssdp:discover\"\r\n"
				"MX: 30\r\n"
				"ST:ssdp:all\r\n"
				"\r\n");

		printf("Sending M-SEARCH ssdp:all(discover) [%d]\n", s);
		n = sendto(s, bufr, l, 0,
		           (struct sockaddr *)&sockname, sizeof(struct sockaddr_in) );
		if (n < 0)
		{
			printf("sendto(udp_shutdown=%d): %s\n", s, strerror(errno));
			ret = -1;
			break;
		}
	}

	return ret;
}


//서비스가 종료될 때 SSDP byebye 패킷을 전송해주는 함수
int
SendSSDPGoodbyes(int s)
{
	struct sockaddr_in sockname;
	int n, l;
	int i;
	int dup, ret = 0;
	char bufr[512];

	memset(&sockname, 0, sizeof(struct sockaddr_in));
	sockname.sin_family = AF_INET;
	sockname.sin_port = htons(SSDP_PORT);
	sockname.sin_addr.s_addr = inet_addr(SSDP_MCAST_ADDR);

	for (dup = 0; dup < 2; dup++)
	{
		for (i = 0; known_service_types[i]; i++)
		{
			l = snprintf(bufr, sizeof(bufr),
					"NOTIFY * HTTP/1.1\r\n"
					"HOST:%s:%d\r\n"
					"NT:%s%s\r\n"
					"USN:%s%s%s%s\r\n"
					"NTS:ssdp:byebye\r\n"
					"\r\n",
					SSDP_MCAST_ADDR, SSDP_PORT,
					known_service_types[i],
					(i > 1 ? "1" : ""), uuidvalue,
					(i > 0 ? "::" : ""),
					(i > 0 ? known_service_types[i] : ""),
					(i > 1 ? "1" : ""));
			printf("Sending ssdp:byebye [%d]\n", s);
			n = sendto(s, bufr, l, 0,
			           (struct sockaddr *)&sockname, sizeof(struct sockaddr_in) );
			if (n < 0)
			{
				printf("sendto(udp_shutdown=%d): %s\n", s, strerror(errno));
				ret = -1;
				break;
			}
		}
	}
	return ret;
}

/* SubmitServicesToMiniSSDPD() :
 * register services offered by MiniUPnPd to a running instance of
 * MiniSSDPd */
/*
int
SubmitServicesToMiniSSDPD(const char *host, unsigned short port)
{
	struct sockaddr_un addr;
	int s;
	unsigned char buffer[2048];
	char strbuf[256];
	unsigned char *p;
	int i, l;

	s = socket(AF_UNIX, SOCK_STREAM, 0);
	if (s < 0)
	{
		printf("socket(unix): %s", strerror(errno));
		return -1;
	}
	addr.sun_family = AF_UNIX;
	strncpyt(addr.sun_path, minissdpdsocketpath, sizeof(addr.sun_path));
	if (connect(s, (struct sockaddr *)&addr, sizeof(struct sockaddr_un)) < 0)
	{
		printf("connect(\"%s\"): %s", minissdpdsocketpath, strerror(errno));
		close(s);
		return -1;
	}
	for (i = 0; known_service_types[i]; i++)
	{
		buffer[0] = 4;
		p = buffer + 1;
		l = strlen(known_service_types[i]);
		if (i > 0)
			l++;
		CODELENGTH(l, p);
		memcpy(p, known_service_types[i], l);
		if (i > 0)
			p[l-1] = '1';
		p += l;
		l = snprintf(strbuf, sizeof(strbuf), "%s::%s%s", 
		             uuidvalue, known_service_types[i], (i==0)?"":"1");
		CODELENGTH(l, p);
		memcpy(p, strbuf, l);
		p += l;
		l = strlen(MINIDLNA_SERVER_STRING);
		CODELENGTH(l, p);
		memcpy(p, MINIDLNA_SERVER_STRING, l);
		p += l;
		l = snprintf(strbuf, sizeof(strbuf), "http://%s:%u" ROOTDESC_PATH,
		             host, (unsigned int)port);
		CODELENGTH(l, p);
		memcpy(p, strbuf, l);
		p += l;
		if(write(s, buffer, p - buffer) < 0)
		{
			DPRINTF(E_ERROR, L_SSDP, "write(): %s", strerror(errno));
			close(s);
			return -1;
		}
	}
	close(s);
	return 0;
}
*/
