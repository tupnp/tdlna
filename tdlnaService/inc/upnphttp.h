#ifndef __UPNPHTTP_H__
#define __UPNPHTTP_H__

#include <netinet/in.h>
#include <sys/queue.h>

#include "comm_types.h"

/* server: HTTP header returned in all HTTP responses : */
//#define MINIDLNA_SERVER_STRING	OS_VERSION " DLNADOC/1.50 UPnP/1.0 " SERVER_NAME "/" MINIDLNA_VERSION
#define MINIDLNA_SERVER_STRING "DLNADOC/1.50 UPnP/1.0 " SERVER_NAME "/" MINIDLNA_VERSION

/*
 states :
 0 - waiting for data to read
 1 - waiting for HTTP Post Content.
 ...
 >= 100 - to be deleted
 */
enum httpCommands {
	EUnknown = 0, EGet, EPost, EHead, ESubscribe, EUnSubscribe
};

struct upnphttp {
	int socket;
	struct in_addr clientaddr; /* client address */
	int iface;
	int state;
	char HttpVer[16];
	/* request */
	char * req_buf;
	int req_buflen;
	int req_contentlen;
	int req_contentoff; /* header length */
	enum httpCommands req_command;
	struct client_cache_s * req_client;
	const char * req_soapAction;
	int req_soapActionLen;
	const char * req_Callback; /* For SUBSCRIBE */
	int req_CallbackLen;
	const char * req_NT;
	int req_NTLen;
	int req_Timeout;
	const char * req_SID; /* For UNSUBSCRIBE */
	int req_SIDLen;
	off_t req_RangeStart;
	off_t req_RangeEnd;
	long int req_chunklen;
	uint32_t reqflags;

	/* response */

	char * res_buf;
	int res_buflen;
	int res_buf_alloclen;
	uint32_t respflags;
	/*int res_contentlen;*/
	/*int res_contentoff;*//* header length */LIST_ENTRY(upnphttp) entries;
};

#define FLAG_TIMEOUT            0x00000001
#define FLAG_SID                0x00000002
#define FLAG_RANGE              0x00000004
#define FLAG_HOST               0x00000008
#define FLAG_LANGUAGE           0x00000010

#define FLAG_INVALID_REQ        0x00000040
#define FLAG_HTML               0x00000080

#define FLAG_CHUNKED            0x00000100
#define FLAG_TIMESEEK           0x00000200
#define FLAG_REALTIMEINFO       0x00000400
#define FLAG_PLAYSPEED          0x00000800
#define FLAG_XFERSTREAMING      0x00001000
#define FLAG_XFERINTERACTIVE    0x00002000
#define FLAG_XFERBACKGROUND     0x00004000
#define FLAG_CAPTION            0x00008000

#ifndef MSG_MORE
#define MSG_MORE 0
#endif

#define ROOT_DESC_XML "<?xml version=\"1.0\"?>" \
"<root xmlns=\"urn:schemas-upnp-org:device-1-0\">" \
"    <specVersion>" \
"        <major>1</major>" \
"        <minor>0</minor>" \
"    </specVersion>" \
"    <device>" \
"        <deviceType>urn:schemas-upnp-org:device:MediaServer:1</deviceType>" \
"        <friendlyName>Samsung Z1</friendlyName>" \
"        <manufacturer>T-DLNA Team</manufacturer>" \
"        <manufacturerURL>http://www.taengz.tk/</manufacturerURL>" \
"        <modelDescription>Samsung Z1 Tizen Phone</modelDescription>" \
"        <modelName>Z1</modelName>" \
"        <modelNumber>1</modelNumber>" \
"        <modelURL>http://www.taengz.tk/</modelURL>" \
"        <serialNumber>12345678</serialNumber>" \
"        <UDN>uuid:12345678-0000-0000-0000-00000000abcd</UDN>" \
"        <dlna:X_DLNADOC xmlns:dlna=\"urn:schemas-dlna-org:device-1-0\">DMS-1.50</dlna:X_DLNADOC>" \
"        <presentationURL>http://%s:%d/</presentationURL>" \
"        <iconList>" \
"            <icon>" \
"                <mimetype>image/png</mimetype>" \
"                <width>48</width>" \
"                <height>48</height>" \
"                <depth>24</depth>" \
"                <url>/icons/sm.png</url>" \
"            </icon>" \
"            <icon>" \
"                <mimetype>image/png</mimetype>" \
"                <width>120</width>" \
"                <height>120</height>" \
"                <depth>24</depth>" \
"                <url>/icons/lrg.png</url>" \
"            </icon>" \
"            <icon>" \
"                <mimetype>image/jpeg</mimetype>" \
"                <width>48</width>" \
"                <height>48</height>" \
"                <depth>24</depth>" \
"                <url>/icons/sm.jpg</url>" \
"            </icon>" \
"            <icon>" \
"                <mimetype>image/jpeg</mimetype>" \
"                <width>120</width>" \
"                <height>120</height>" \
"                <depth>24</depth>" \
"                <url>/icons/lrg.jpg</url>" \
"            </icon>" \
"        </iconList>" \
"        <serviceList>" \
"            <service>" \
"                <serviceType>urn:schemas-upnp-org:service:ContentDirectory:1</serviceType>" \
"                <serviceId>urn:upnp-org:serviceId:ContentDirectory</serviceId>" \
"                <controlURL>/ctl/ContentDir</controlURL>" \
"                <eventSubURL>/evt/ContentDir</eventSubURL>" \
"                <SCPDURL>/ContentDir.xml</SCPDURL>" \
"            </service>" \
"            <service>" \
"                <serviceType>urn:schemas-upnp-org:service:ConnectionManager:1</serviceType>" \
"                <serviceId>urn:upnp-org:serviceId:ConnectionManager</serviceId>" \
"                <controlURL>/ctl/ConnectionMgr</controlURL>" \
"                <eventSubURL>/evt/ConnectionMgr</eventSubURL>" \
"                <SCPDURL>/ConnectionMgr.xml</SCPDURL>" \
"            </service>" \
"        </serviceList>" \
"    </device>" \
"</root>"

/* New_upnphttp() */
struct upnphttp *New_upnphttp(int);

/* CloseSocket_upnphttp() */
void CloseSocket_upnphttp(struct upnphttp *);

/* Delete_upnphttp() */
void Delete_upnphttp(struct upnphttp *);

/* Process_upnphttp() */
void Process_upnphttp(struct upnphttp *);

/* BuildHeader_upnphttp()
 * build the header for the HTTP Response
 * also allocate the buffer for body data */
void BuildHeader_upnphttp(struct upnphttp * h, int respcode, const char * respmsg, int bodylen);

/* BuildResp_upnphttp()
 * fill the res_buf buffer with the complete
 * HTTP 200 OK response from the body passed as argument */
void BuildResp_upnphttp(struct upnphttp *, const char *, int);

/* BuildResp2_upnphttp()
 * same but with given response code/message */
void BuildResp2_upnphttp(struct upnphttp * h, int respcode, const char * respmsg, const char * body, int bodylen);


/* Error messages */
void Send500(struct upnphttp *);
void Send501(struct upnphttp *);

/* SendResp_upnphttp() */
void SendResp_upnphttp(struct upnphttp *);

#endif


