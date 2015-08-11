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



#define SAMSUNG_BROWSE_VIDEO \
"	&lt;container childCount=\"1\" id=\"2$8\" parentID=\"2\" restricted=\"1\"&gt;" \
"	&lt;dc:title&gt;All Video&lt;/dc:title&gt;:" \
"	&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;"\
"	&lt;upnp:storageUsed&gt;-1&lt;/upnp:storageUsed&gt;" \
"&lt;/container&gt;" \
"&lt;container childCount=\"1\" id=\"2$15\" parentID=\"2\" restricted=\"1\"&gt;" \
"	&lt;dc:title&gt;Folders&lt;/dc:title&gt;" \
"	&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;" \
"	&lt;upnp:storageUsed&gt;-1&lt;/upnp:storageUsed&gt;" \
"&lt;/container&gt;"


#define BROWSE_ROOT_RESULT \
	"&lt;container id=\"2$8\"" \
	" parentID=\"2\" restricted=\"1\" searchable=\"0\"" \
    " childCount=\"%d\"&gt;&lt;dc:title&gt;동영상&lt;/dc:title&gt;&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;&lt;upnp:class&gt;object.item.videoItem&lt;/upnp:class&gt; &lt;upnp:storageUsed&gt;-1&lt;/upnp:storageUsed&gt; &lt;/container&gt;&lt;container" \
    " id=\"1$4\" parentID=\"1\" restricted=\"1\" searchable=\"0\"" \
    " childCount=\"%d\"&gt;&lt;dc:title&gt;음악&lt;/dc:title&gt;&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;&lt;/container&gt;&lt;container" \
    " id=\"3$B\" parentID=\"3\" restricted=\"1\" searchable=\"0\"" \
    " childCount=\"%d\"&gt;&lt;dc:title&gt;사진&lt;/dc:title&gt;&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;&lt;upnp:class&gt;object.container.storageFolder&lt;/upnp:class&gt;&lt;/container&gt;"

#define BROWSE_VIDEO_ITEM \
"&lt;item id=\"2$8$%d\" parentID=\"2$8\" refID=\"64$0\" restricted=\"1\"&gt;" \
    "&lt;dc:title&gt;%s&lt;/dc:title&gt;" \
    "&lt;dc:creator&gt;Unknown&lt;/dc:creator&gt;" \
    "&lt;upnp:genre&gt;Unknown&lt;/upnp:genre&gt;" \
    "&lt;res protocolInfo=\"http-get:*:video/mp4:DLNA.ORG_OP=01;DLNA.ORG_CI=0;DLNA.ORG_FLAGS=01700000000000000000000000000000\" "\
    "size=\"%ld\"&gt;http://%s:%d/%s&lt;/res&gt;" \
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

