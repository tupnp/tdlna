#ifndef __UPNPSOAP_H__
#define __UPNPSOAP_H__

#define DEFAULT_RESP_SIZE 131072
#define MAX_RESPONSE_SIZE 2097152

#define CONTENT_DIRECTORY_SCHEMAS \
	" xmlns:dc=\"http://purl.org/dc/elements/1.1/\"" \
	" xmlns:upnp=\"urn:schemas-upnp-org:metadata-1-0/upnp/\"" \
	" xmlns=\"urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/\""
#define DLNA_NAMESPACE \
	" xmlns:dlna=\"urn:schemas-dlna-org:metadata-1-0/\""
#define PV_NAMESPACE \
	" xmlns:pv=\"http://www.pv.com/pvns/\""


#define BROWSE_ROOT_RESULT \
	"&lt;container id=\"0/video\"" \
	" parentID=\"0\" restricted=\"1\" searchable=\"0\"" \
    " childCount=\"%d\"&gt;&lt;dc:title&gt;동영상&lt;/dc:title&gt;&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;&lt;/container&gt;&lt;container" \
    " id=\"0/audio\" parentID=\"0\" restricted=\"1\" searchable=\"0\"" \
    " childCount=\"%d\"&gt;&lt;dc:title&gt;음악&lt;/dc:title&gt;&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;&lt;/container&gt;&lt;container" \
    " id=\"0/image\" parentID=\"0\" restricted=\"1\" searchable=\"0\"" \
    " childCount=\"%d\"&gt;&lt;dc:title&gt;사진&lt;/dc:title&gt;&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;&lt;/container&gt;"

#define BROWSE_VIDEO_ITEM \
"&lt;item id=\"0/Video/test\" parentID=\"0/video\" restricted=\"1\"&gt;" \
    "&lt;dc:title&gt;테스트비디오&lt;/dc:title&gt;" \
    "&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;" \
    "&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;" \
    "&lt;res" \
    "    protocolInfo=\"http-get:*:video/mp4:DLNA.ORG_OP=01;DLNA.ORG_CI=0;DLNA.ORG_FLAGS=01500000000000000000000000000000\"" \
    "    size=\"95894397\"&gt;http://%s:%d/test.mp4&lt;/res&gt;" \
    "&lt;upnp:class&gt;object.item.videoItem&lt;/upnp:class&gt;" \
"&lt;/item&gt;"


struct Response
{
	struct string_s *str;
	int start;
	int returned;
	int requested;
	int iface;
	uint32_t filter;
	uint32_t flags;
	enum client_types client;
};

/* ExecuteSoapAction():
 * this method executes the requested Soap Action */
void
ExecuteSoapAction(struct upnphttp *, const char *, int);

/* SoapError():
 * sends a correct SOAP error with an UPNPError code and 
 * description */
void
SoapError(struct upnphttp * h, int errCode, const char * errDesc);

#endif

