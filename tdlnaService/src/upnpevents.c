#include <stdio.h>
#include <string.h>
#include <errno.h>
#include <sys/queue.h>
#include <stdlib.h>
#include <unistd.h>
#include <time.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/param.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <fcntl.h>
#include <errno.h>
#include <dlog.h>

#include "upnpevents.h"
#include "upnpglobalvars.h"
//#include "upnpdescgen.h"
//#include "uuid.h"
//#include "utils.h"

#define CONTENTDIRECTORY_PATH			"/ContentDir.xml"
#define CONTENTDIRECTORY_CONTROLURL		"/ctl/ContentDir"
#define CONTENTDIRECTORY_EVENTURL		"/evt/ContentDir"
#define CONNECTIONMGR_PATH			"/ConnectionMgr.xml"
#define CONNECTIONMGR_CONTROLURL		"/ctl/ConnectionMgr"
#define CONNECTIONMGR_EVENTURL			"/evt/ConnectionMgr"
//#define X_MS_MEDIARECEIVERREGISTRAR_PATH	"/X_MS_MediaReceiverRegistrar.xml"
//#define X_MS_MEDIARECEIVERREGISTRAR_CONTROLURL	"/ctl/X_MS_MediaReceiverRegistrar"
//#define X_MS_MEDIARECEIVERREGISTRAR_EVENTURL	"/evt/X_MS_MediaReceiverRegistrar"

/* stuctures definitions */
struct subscriber {
	LIST_ENTRY(subscriber) entries;
	struct upnp_event_notify * notify;
	time_t timeout;
	uint32_t seq;
	enum subscriber_service_enum service;
	char uuid[42];
	char callback[];
};

struct upnp_event_notify {
	LIST_ENTRY(upnp_event_notify) entries;
    int s;  /* socket */
    enum { ECreated=1,
	       EConnecting,
	       ESending,
	       EWaitingForResponse,
	       EFinished,
	       EError } state;
    struct subscriber * sub;
    char * buffer;
    int buffersize;
	int tosend;
    int sent;
	const char * path;
	char addrstr[16];
	char portstr[8];
};

// prototypes 
static void upnp_event_create_notify(struct subscriber * sub);
// Subscriber list
LIST_HEAD(listhead, subscriber) subscriberlist = { NULL };

// notify list 
LIST_HEAD(listheadnotif, upnp_event_notify) notifylist = { NULL };


static inline void strncpyt(char *dst, const char *src, size_t len)
{
	strncpy(dst, src, len);
	dst[len-1] = '\0';
}
//
//static char* strstrc(const char *s, const char *p, const char t)
//{
//	char *endptr;
//	size_t slen, plen;
//
//
//	// strchr - 문자열에서 임의의 문자가 처음으로 발견된 위치를 구합니다.
//	// 문자를 못찾으면 null 반환
//	endptr = strchr(s, t);
//	if (!endptr)
//	{
//		return strstr(s, p);
//	}
//
//	plen = strlen(p);
//	slen = endptr - s;
//	while (slen >= plen)
//	{
//		if (*s == *p && strncmp(s+1, p+1, plen-1) == 0)
//		{
//			return (char*)s;
//		}
//		s++;
//		slen--;
//	}
//
//	return NULL;
//}

int get_uuid_string(char *buf)
{
	/*
	char uuid[16];

	if( generate_uuid(uuid) != 0 )
		return -1;

	sprintf(buf, "%02x%02x%02x%02x-%02x%02x-%02x%02x-%02x%02x-%02x%02x%02x%02x%02x%02x",
	        uuid[0], uuid[1], uuid[2], uuid[3], uuid[4], uuid[5], uuid[6], uuid[7], uuid[8], 
	        uuid[9], uuid[10], uuid[11], uuid[12], uuid[13], uuid[14], uuid[15]);
	buf[36] = '\0';
	*/
	sprintf(buf, "12345678-0000-0000-0000-00000000abcd"); //default
	return 0;
}

// 새로운 subscriber 생성
static struct subscriber *
newSubscriber(const char * eventurl, const char * callback, int callbacklen)
{
	struct subscriber * tmp;
	if(!eventurl || !callback || !callbacklen)
		return NULL;
	tmp = calloc(1, sizeof(struct subscriber)+callbacklen+1);
	if(strcmp(eventurl, CONTENTDIRECTORY_EVENTURL)==0)
		tmp->service = EContentDirectory;
	else if(strcmp(eventurl, CONNECTIONMGR_EVENTURL)==0)
		tmp->service = EConnectionManager;
//	else if(strcmp(eventurl, X_MS_MEDIARECEIVERREGISTRAR_EVENTURL)==0)
//		tmp->service = EMSMediaReceiverRegistrar;
	else {
		free(tmp);
		return NULL;
	}
	memcpy(tmp->callback, callback, callbacklen);
	tmp->callback[callbacklen] = '\0';
	/* make a dummy uuid */
	strncpyt(tmp->uuid, uuidvalue, sizeof(tmp->uuid));
	if( get_uuid_string(tmp->uuid+5) != 0 )
	{
		tmp->uuid[sizeof(tmp->uuid)-1] = '\0';
		snprintf(tmp->uuid+37, 5, "%04lx", random() & 0xffff);
	}

	return tmp;
}

/* creates a new subscriber and adds it to the subscriber list
 * also initiate 1st notify */
const char *
upnpevents_addSubscriber(const char * eventurl,
                         const char * callback, int callbacklen,
                         int timeout)
{
	struct subscriber * tmp;
	printf("addSubscriber(%s, %.*s, %d)\n",
	       eventurl, callbacklen, callback, timeout);
	tmp = newSubscriber(eventurl, callback, callbacklen);
	if(!tmp)
		return NULL;
	if(timeout)
		tmp->timeout = time(NULL) + timeout;
	LIST_INSERT_HEAD(&subscriberlist, tmp, entries);
	upnp_event_create_notify(tmp);
	return tmp->uuid;
}

/* renew a subscription (update the timeout) */
int
renewSubscription(const char * sid, int sidlen, int timeout)
{
	struct subscriber * sub;
	for(sub = subscriberlist.lh_first; sub != NULL; sub = sub->entries.le_next) {
		if(memcmp(sid, sub->uuid, 41) == 0) {
			sub->timeout = (timeout ? time(NULL) + timeout : 0);
			return 0;
		}
	}
	return -1;
}

int
upnpevents_removeSubscriber(const char * sid, int sidlen)
{
	struct subscriber * sub;
	if(!sid)
		return -1;
	printf("removeSubscriber(%.*s)\n",
	       sidlen, sid);
	for(sub = subscriberlist.lh_first; sub != NULL; sub = sub->entries.le_next) {
		if(memcmp(sid, sub->uuid, 41) == 0) {
			if(sub->notify) {
				sub->notify->sub = NULL;
			}
			LIST_REMOVE(sub, entries);
			free(sub);
			return 0;
		}
	}
	return -1;
}

void
upnpevents_removeSubscribers(void)
{
	struct subscriber * sub;

	for(sub = subscriberlist.lh_first; sub != NULL; sub = subscriberlist.lh_first) {
		upnpevents_removeSubscriber(sub->uuid, sizeof(sub->uuid));
	}
}

/* notifies all subscribers of a SystemUpdateID change */
void
upnp_event_var_change_notify(enum subscriber_service_enum service)
{
	struct subscriber * sub;
	for(sub = subscriberlist.lh_first; sub != NULL; sub = sub->entries.le_next) {
		if(sub->service == service && sub->notify == NULL)
			upnp_event_create_notify(sub);
	}
}

/* create and add the notify object to the list */
static void
upnp_event_create_notify(struct subscriber * sub)
{
	struct upnp_event_notify * obj;
	int flags;
	obj = calloc(1, sizeof(struct upnp_event_notify));
	if(!obj) {
		printf( "%s: calloc(): %s\n", "upnp_event_create_notify", strerror(errno));
		return;
	}
	obj->sub = sub;
	obj->state = ECreated;
	obj->s = socket(PF_INET, SOCK_STREAM, 0);
	if(obj->s<0) {
		printf("%s: socket(): %s\n", "upnp_event_create_notify", strerror(errno));
		goto error;
	}
	if((flags = fcntl(obj->s, F_GETFL, 0)) < 0) {
		printf("%s: fcntl(..F_GETFL..): %s\n",
		       "upnp_event_create_notify", strerror(errno));
		goto error;
	}
	if(fcntl(obj->s, F_SETFL, flags | O_NONBLOCK) < 0) {
		printf("%s: fcntl(..F_SETFL..): %s\n",
		       "upnp_event_create_notify", strerror(errno));
		goto error;
	}
	if(sub)
		sub->notify = obj;
	LIST_INSERT_HEAD(&notifylist, obj, entries);
	return;
error:
	if(obj->s >= 0)
		close(obj->s);
	free(obj);
}
/*
static void
upnp_event_notify_connect(struct upnp_event_notify * obj)
{
	int i;
	const char * p;
	unsigned short port;
	struct sockaddr_in addr;
	if(!obj)
		return;
	memset(&addr, 0, sizeof(addr));
	i = 0;
	if(obj->sub == NULL) {
		obj->state = EError;
		return;
	}
	p = obj->sub->callback;
	p += 7;	// http://
	while(*p != '/' && *p != ':' && i < (sizeof(obj->addrstr)-1))
		obj->addrstr[i++] = *(p++);
	obj->addrstr[i] = '\0';
	if(*p == ':') {
		obj->portstr[0] = *p;
		i = 1;
		p++;
		port = (unsigned short)atoi(p);
		while(*p != '/' && *p != '\0') {
			if(i<7) obj->portstr[i++] = *p;
			p++;
		}
		obj->portstr[i] = 0;
	} else {
		port = 80;
		obj->portstr[0] = '\0';
	}
	if( *p )
		obj->path = p;
	else
		obj->path = "/";
	addr.sin_family = AF_INET;
	inet_aton(obj->addrstr, &addr.sin_addr);
	addr.sin_port = htons(port);
	printf("%s: '%s' %hu '%s'\n", "upnp_event_notify_connect",
	       obj->addrstr, port, obj->path);
	obj->state = EConnecting;
	if(connect(obj->s, (struct sockaddr *)&addr, sizeof(addr)) < 0) {
		if(errno != EINPROGRESS && errno != EWOULDBLOCK) {
			printf("%s: connect(): %s\n", "upnp_event_notify_connect", strerror(errno));
			obj->state = EError;
		}
	}
}
*/
/*
static void upnp_event_prepare(struct upnp_event_notify * obj)
{
	static const char notifymsg[] = 
		"NOTIFY %s HTTP/1.1\r\n"
		"Host: %s%s\r\n"
		"Content-Type: text/xml; charset=\"utf-8\"\r\n"
		"Content-Length: %d\r\n"
		"NT: upnp:event\r\n"
		"NTS: upnp:propchange\r\n"
		"SID: %s\r\n"
		"SEQ: %u\r\n"
		"Connection: close\r\n"
		"Cache-Control: no-cache\r\n"
		"\r\n"
		"%.*s\r\n";
	char * xml;
	int l;
	if(obj->sub == NULL) {
		obj->state = EError;
		return;
	}
	switch(obj->sub->service) {
	case EContentDirectory:
		xml = getVarsContentDirectory(&l);
		break;
	case EConnectionManager:
		xml = getVarsConnectionManager(&l);
		break;
	case EMSMediaReceiverRegistrar:
		xml = getVarsX_MS_MediaReceiverRegistrar(&l);
		break;
	default:
		xml = NULL;
		l = 0;
	}
	obj->tosend = asprintf(&(obj->buffer), notifymsg,
	                       obj->path, obj->addrstr, obj->portstr, l+2,
	                       obj->sub->uuid, obj->sub->seq,
	                       l, xml);
	obj->buffersize = obj->tosend;
	free(xml);
	printf("Sending UPnP Event response:\n%s\n", obj->buffer);
	obj->state = ESending;
}
*/
static void upnp_event_send(struct upnp_event_notify * obj)
{
	int i;
	//DEBUG DPRINTF(E_DEBUG, L_HTTP, "Sending UPnP Event:\n%s", obj->buffer+obj->sent);
	while( obj->sent < obj->tosend ) {
		i = send(obj->s, obj->buffer + obj->sent, obj->tosend - obj->sent, 0);
		if(i<0) {
			printf("%s: send(): %s\n", "upnp_event_send", strerror(errno));
			obj->state = EError;
			return;
		}
		obj->sent += i;
	}
	if(obj->sent == obj->tosend)
		obj->state = EWaitingForResponse;
}

static void upnp_event_recv(struct upnp_event_notify * obj)
{
	int n;
	n = recv(obj->s, obj->buffer, obj->buffersize, 0);
	if(n<0) {
		printf("%s: recv(): %s\n", "upnp_event_recv", strerror(errno));
		obj->state = EError;
		return;
	}
	printf("%s: (%dbytes) %.*s\n", "upnp_event_recv",
	       n, n, obj->buffer);
	obj->state = EFinished;
	if(obj->sub)
	{
		obj->sub->seq++;
		if (!obj->sub->seq)
			obj->sub->seq++;
	}
}

static void
upnp_event_process_notify(struct upnp_event_notify * obj)
{
	switch(obj->state) {
	case EConnecting:
		/* now connected or failed to connect */
		//upnp_event_prepare(obj);
		upnp_event_send(obj);
		break;
	case ESending:
		upnp_event_send(obj);
		break;
	case EWaitingForResponse:
		upnp_event_recv(obj);
		break;
	case EFinished:
		close(obj->s);
		obj->s = -1;
		break;
	default:
		printf("upnp_event_process_notify: unknown state\n");
	}
}
//
//void upnpevents_selectfds(fd_set *readset, fd_set *writeset, int * max_fd)
//{
//	struct upnp_event_notify * obj;
//	for(obj = notifylist.lh_first; obj != NULL; obj = obj->entries.le_next)
//	{
//
//		dlog_print(DLOG_INFO, "tdlna","◆◆ upnpevents_selectfds: %p %d %d\n", obj, obj->state, obj->s);
//		if(obj->s >= 0) {
//			switch(obj->state) {
//			case ECreated:
//				upnp_event_notify_connect(obj);
//				dlog_print(DLOG_INFO, "tdlna", "◆◆ upnp_event_notify_connect(obj) - %d", (int)obj->state);
//
////				enum { ECreated=1,
////						EConnecting,
////						ESending,
////						EWaitingForResponse,
////						EFinished,
////						EError } state;
//
//				if(obj->state != EConnecting){
//					break;
//				}
//			case EConnecting:
//			case ESending:
//				FD_SET(obj->s, writeset);
//				if(obj->s > *max_fd)
//					*max_fd = obj->s;
//				break;
//			case EWaitingForResponse:
//				FD_SET(obj->s, readset);
//				if(obj->s > *max_fd)
//					*max_fd = obj->s;
//				break;
//			default:
//				break;
//			}
//		}
//	}
//}

void upnpevents_processfds(fd_set *readset, fd_set *writeset)
{
	struct upnp_event_notify * obj;
	struct upnp_event_notify * next;
	struct subscriber * sub;
	struct subscriber * subnext;
	time_t curtime;
	for(obj = notifylist.lh_first; obj != NULL; obj = obj->entries.le_next) {
		printf("%s: %p %d %d %d %d\n",
		       "upnpevents_processfds", obj, obj->state, obj->s,
		       FD_ISSET(obj->s, readset), FD_ISSET(obj->s, writeset));
		if(obj->s >= 0) {
			if(FD_ISSET(obj->s, readset) || FD_ISSET(obj->s, writeset))
				upnp_event_process_notify(obj);
		}
	}
	obj = notifylist.lh_first;
	while(obj != NULL) {
		next = obj->entries.le_next;
		if(obj->state == EError || obj->state == EFinished) {
			if(obj->s >= 0) {
				close(obj->s);
			}
			if(obj->sub)
				obj->sub->notify = NULL;
#if 0 /* Just let it time out instead of explicitly removing the subscriber */
			/* remove also the subscriber from the list if there was an error */
			if(obj->state == EError && obj->sub) {
				LIST_REMOVE(obj->sub, entries);
				free(obj->sub);
			}
#endif
			free(obj->buffer);
			LIST_REMOVE(obj, entries);
			free(obj);
		}
		obj = next;
	}
	/* remove timeouted subscribers */
	curtime = time(NULL);
	for(sub = subscriberlist.lh_first; sub != NULL; ) {
		subnext = sub->entries.le_next;
		if(sub->timeout && curtime > sub->timeout && sub->notify == NULL) {
			LIST_REMOVE(sub, entries);
			free(sub);
		}
		sub = subnext;
	}
}

