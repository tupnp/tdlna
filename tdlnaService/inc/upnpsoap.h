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

