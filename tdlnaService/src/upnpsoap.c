#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <unistd.h>
#include <dirent.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <arpa/inet.h>
#include <netinet/in.h>
#include <netdb.h>
#include <ctype.h>
#include <sys/param.h>
#include <stdarg.h>
#include <dlog.h>
#include <dirent.h> //opendir

#include "upnpglobalvars.h"
#include "upnpreplyparse.h"
#include "upnphttp.h"
#include "upnpsoap.h"

static inline int
__attribute__((__format__ (__printf__, 2, 3)))
strcatf(struct string_s *str, const char *fmt, ...)
{
	int ret;
	int size;
	va_list ap;

	if (str->off >= str->size)
		return 0;

	va_start(ap, fmt);
	size = str->size - str->off;
	ret = vsnprintf(str->data + str->off, size, fmt, ap);
	str->off += MIN(ret, size);
	va_end(ap);

	return ret;
}

/* Find the first occurrence of p in s, where s is terminated by t */
static char* strstrc(const char *s, const char *p, const char t)
{
	char *endptr;
	size_t slen, plen;


	// strchr - 문자열에서 임의의 문자가 처음으로 발견된 위치를 구합니다.
	// 문자를 못찾으면 null 반환
	endptr = strchr(s, t);
	if (!endptr)
	{
		return strstr(s, p);
	}

	plen = strlen(p);
	slen = endptr - s;
	while (slen >= plen)
	{
		if (*s == *p && strncmp(s+1, p+1, plen-1) == 0)
		{
			return (char*)s;
		}
		s++;
		slen--;
	}

	return NULL;
}

//URL 문자열 인코딩
char *UrlEncode(char *str, char *encstr){
	//char encstr[128],
	char buf[2+1];
	int i, j;
	unsigned char c;
	if(str == NULL) return NULL;
	//if((encstr = (char *)malloc((strlen(str) * 3) + 1)) == NULL) return NULL;

	for(i = j = 0; str[i]; i++){

		c = (unsigned char)str[i];
		if (c == ' ') encstr[j++] = '+';
		else if ((c >= '0') && (c <= '9')) encstr[j++] = c;
		else if ((c >= 'A') && (c <= 'Z')) encstr[j++] = c;
		else if ((c >= 'a') && (c <= 'z')) encstr[j++] = c;
		else if ((c == '@') || (c == '.')) encstr[j++] = c;
		else {
			sprintf(buf, "%02x", c);
			encstr[j++] = '%';
			encstr[j++] = buf[0];
			encstr[j++] = buf[1];
		}
	}
	encstr[j] = '\0';
	return encstr;
}

//SOAP 처리 결과 전송
static void BuildSendAndCloseSoapResp(struct upnphttp * h, const char * body, int bodylen)
{
	static const char beforebody[] =
		"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n"
		"<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
		"s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
		"<s:Body>";

	static const char afterbody[] =
		"</s:Body>"
		"</s:Envelope>\r\n";

	if (!body || bodylen < 0)
	{
		Send500(h);
		return;
	}

	BuildHeader_upnphttp(h, 200, "OK",  sizeof(beforebody) - 1
		+ sizeof(afterbody) - 1 + bodylen );

	memcpy(h->res_buf + h->res_buflen, beforebody, sizeof(beforebody) - 1);
	h->res_buflen += sizeof(beforebody) - 1;

	memcpy(h->res_buf + h->res_buflen, body, bodylen);
	h->res_buflen += bodylen;

	memcpy(h->res_buf + h->res_buflen, afterbody, sizeof(afterbody) - 1);
	h->res_buflen += sizeof(afterbody) - 1;

	//dlog_print(DLOG_DEBUG, "tdlna", "★SOAP RESPONSE: %s", h->res_buf);
	SendResp_upnphttp(h);
	CloseSocket_upnphttp(h);
}


static void
GetSystemUpdateID(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<Id>%d</Id>"
		"</u:%sResponse>";

	char body[512];
	int bodylen;

	bodylen = snprintf(body, sizeof(body), resp,
		action, "urn:schemas-upnp-org:service:ContentDirectory:1",
		updateID, action);
	BuildSendAndCloseSoapResp(h, body, bodylen);
}


static void
IsAuthorizedValidated(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<Result>%d</Result>"
		"</u:%sResponse>";

	char body[512];
	//struct NameValueParserData data;
	const char * id;

	//ParseNameValue(h->req_buf + h->req_contentoff, h->req_contentlen, &data, 0x01);//XML_STORE_EMPTY_FL);
	//id = GetValueFromNameValueList(&data, "DeviceID");
	id = "1";
	if(id)
	{
		int bodylen;
		bodylen = snprintf(body, sizeof(body), resp,
			action, "urn:microsoft.com:service:X_MS_MediaReceiverRegistrar:1",
			1, action);	
		BuildSendAndCloseSoapResp(h, body, bodylen);
	}
	else
		SoapError(h, 402, "Invalid Args");

	//ClearNameValueList(&data);	
}

// 장치 등록
static void
RegisterDevice(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<RegistrationRespMsg>%s</RegistrationRespMsg>"
		"</u:%sResponse>";

	char body[512];
	int bodylen;

	bodylen = snprintf(body, sizeof(body), resp,
		action, "urn:microsoft.com:service:X_MS_MediaReceiverRegistrar:1",
		uuidvalue, action);
	BuildSendAndCloseSoapResp(h, body, bodylen);
}
/*
static void
GetProtocolInfo(struct upnphttp * h, const char * action)
{

	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<Source>"
		RESOURCE_PROTOCOL_INFO_VALUES
		"</Source>"
		"<Sink></Sink>"
		"</u:%sResponse>";

	char * body;
	int bodylen;

	bodylen = strlen(resp) + strlen(action) + 50;
	body = malloc(bodylen);

	bodylen = sprintf(body, resp, action, "urn:schemas-upnp-org:service:ConnectionManager:1", action);
	BuildSendAndCloseSoapResp(h, body, bodylen);

	dlog_print(DLOG_DEBUG,"tdlna", "겟프로토콜 %s", body);
	free(body);
}
*/
static void
GetSortCapabilities(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<SortCaps>"
/*		  "dc:title,"
		  "dc:date,"
		  "upnp:class,"
		  "upnp:album,"
		  "upnp:originalTrackNumber" */
		"</SortCaps>"
		"</u:%sResponse>";

	char body[512];
	int bodylen;

	bodylen = snprintf(body, sizeof(body), resp,
		action, "urn:schemas-upnp-org:service:ContentDirectory:1",
		action);	
	BuildSendAndCloseSoapResp(h, body, bodylen);
}
/*
static void
GetSearchCapabilities(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:%sResponse xmlns:u=\"%s\">"
		"<SearchCaps>"
		  "dc:creator,"
		  "dc:date,"
		  "dc:title,"
		  "upnp:album,"
		  "upnp:actor,"
		  "upnp:artist,"
		  "upnp:class,"
		  "upnp:genre,"
		  "@id,"
		  "@parentID,"
		  "@refID"
		"</SearchCaps>"
		"</u:%sResponse>";

	char body[512];
	int bodylen;

	bodylen = snprintf(body, sizeof(body), resp,
		action, "urn:schemas-upnp-org:service:ContentDirectory:1",
		action);	
	BuildSendAndCloseSoapResp(h, body, bodylen);
}
*/
static void
GetCurrentConnectionIDs(struct upnphttp * h, const char * action)
{
	///* TODO: Use real data. - JM
	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<ConnectionIDs>0</ConnectionIDs>"
		"</u:%sResponse>";

	char body[512];
	int bodylen;

	bodylen = snprintf(body, sizeof(body), resp,
		action, "urn:schemas-upnp-org:service:ConnectionManager:1",
		action);	
	BuildSendAndCloseSoapResp(h, body, bodylen);
}
 /*
static void
GetCurrentConnectionInfo(struct upnphttp * h, const char * action)
{
	// TODO: Use real data. - JM 
	static const char resp[] =
		"<u:%sResponse "
		"xmlns:u=\"%s\">"
		"<RcsID>-1</RcsID>"
		"<AVTransportID>-1</AVTransportID>"
		"<ProtocolInfo></ProtocolInfo>"
		"<PeerConnectionManager></PeerConnectionManager>"
		"<PeerConnectionID>-1</PeerConnectionID>"
		"<Direction>Output</Direction>"
		"<Status>Unknown</Status>"
		"</u:%sResponse>";

	char body[sizeof(resp)+128];
	struct NameValueParserData data;
	const char *id_str;
	int id;
	char *endptr = NULL;

	ParseNameValue(h->req_buf + h->req_contentoff, h->req_contentlen, &data, XML_STORE_EMPTY_FL);
	id_str = GetValueFromNameValueList(&data, "ConnectionID");
	printf("GetCurrentConnectionInfo(%s)\n", id_str);
	if(id_str)
		id = strtol(id_str, &endptr, 10);
	if (!id_str || endptr == id_str)
	{
		SoapError(h, 402, "Invalid Args");
	}
	else if(id != 0)
	{
		SoapError(h, 701, "No such object error");
	}
	else
	{
		int bodylen;
		bodylen = snprintf(body, sizeof(body), resp,
			action, "urn:schemas-upnp-org:service:ConnectionManager:1",
			action);	
		BuildSendAndCloseSoapResp(h, body, bodylen);
	}
	ClearNameValueList(&data);	
}
*/
/* Standard DLNA/UPnP filter flags */
#define FILTER_CHILDCOUNT                        0x00000001
#define FILTER_DC_CREATOR                        0x00000002
#define FILTER_DC_DATE                           0x00000004
#define FILTER_DC_DESCRIPTION                    0x00000008
#define FILTER_DLNA_NAMESPACE                    0x00000010
#define FILTER_REFID                             0x00000020
#define FILTER_RES                               0x00000040
#define FILTER_RES_BITRATE                       0x00000080
#define FILTER_RES_DURATION                      0x00000100
#define FILTER_RES_NRAUDIOCHANNELS               0x00000200
#define FILTER_RES_RESOLUTION                    0x00000400
#define FILTER_RES_SAMPLEFREQUENCY               0x00000800
#define FILTER_RES_SIZE                          0x00001000
#define FILTER_SEARCHABLE                        0x00002000
#define FILTER_UPNP_ACTOR                        0x00004000
#define FILTER_UPNP_ALBUM                        0x00008000
#define FILTER_UPNP_ALBUMARTURI                  0x00010000
#define FILTER_UPNP_ALBUMARTURI_DLNA_PROFILEID   0x00020000
#define FILTER_UPNP_ARTIST                       0x00040000
#define FILTER_UPNP_GENRE                        0x00080000
#define FILTER_UPNP_ORIGINALTRACKNUMBER          0x00100000
#define FILTER_UPNP_SEARCHCLASS                  0x00200000
#define FILTER_UPNP_STORAGEUSED                  0x00400000
/* Vendor-specific filter flags */
#define FILTER_SEC_CAPTION_INFO_EX               0x01000000
#define FILTER_SEC_DCM_INFO                      0x02000000
#define FILTER_PV_SUBTITLE_FILE_TYPE             0x04000000
#define FILTER_PV_SUBTITLE_FILE_URI              0x08000000
#define FILTER_PV_SUBTITLE                       0x0C000000
#define FILTER_AV_MEDIA_CLASS                    0x10000000

static uint32_t
set_filter_flags(char *filter, struct upnphttp *h)
{
	char *item, *saveptr = NULL;
	uint32_t flags = 0;
	int samsung = h->req_client && (h->req_client->type->flags & FLAG_SAMSUNG);

	if( !filter || (strlen(filter) <= 1) ) {
		// Not the full 32 bits.  Skip vendor-specific stuff by default. 
		flags = 0xFFFFFF;
		if (samsung)
			flags |= FILTER_SEC_CAPTION_INFO_EX | FILTER_SEC_DCM_INFO;
	}
	if (flags)
		return flags;

	if( samsung )
		flags |= FILTER_DLNA_NAMESPACE;
	item = strtok_r(filter, ",", &saveptr);
	while( item != NULL )
	{
		if( saveptr )
			*(item-1) = ',';
		while( isspace(*item) )
			item++;
		if( strcmp(item, "@childCount") == 0 )
		{
			flags |= FILTER_CHILDCOUNT;
		}
		else if( strcmp(item, "@searchable") == 0 )
		{
			flags |= FILTER_SEARCHABLE;
		}
		else if( strcmp(item, "dc:creator") == 0 )
		{
			flags |= FILTER_DC_CREATOR;
		}
		else if( strcmp(item, "dc:date") == 0 )
		{
			flags |= FILTER_DC_DATE;
		}
		else if( strcmp(item, "dc:description") == 0 )
		{
			flags |= FILTER_DC_DESCRIPTION;
		}
		else if( strcmp(item, "dlna") == 0 )
		{
			flags |= FILTER_DLNA_NAMESPACE;
		}
		else if( strcmp(item, "@refID") == 0 )
		{
			flags |= FILTER_REFID;
		}
		else if( strcmp(item, "upnp:album") == 0 )
		{
			flags |= FILTER_UPNP_ALBUM;
		}
		else if( strcmp(item, "upnp:albumArtURI") == 0 )
		{
			flags |= FILTER_UPNP_ALBUMARTURI;
			if( samsung )
				flags |= FILTER_UPNP_ALBUMARTURI_DLNA_PROFILEID;
		}
		else if( strcmp(item, "upnp:albumArtURI@dlna:profileID") == 0 )
		{
			flags |= FILTER_UPNP_ALBUMARTURI;
			flags |= FILTER_UPNP_ALBUMARTURI_DLNA_PROFILEID;
		}
		else if( strcmp(item, "upnp:artist") == 0 )
		{
			flags |= FILTER_UPNP_ARTIST;
		}
		else if( strcmp(item, "upnp:actor") == 0 )
		{
			flags |= FILTER_UPNP_ACTOR;
		}
		else if( strcmp(item, "upnp:genre") == 0 )
		{
			flags |= FILTER_UPNP_GENRE;
		}
		else if( strcmp(item, "upnp:originalTrackNumber") == 0 )
		{
			flags |= FILTER_UPNP_ORIGINALTRACKNUMBER;
		}
		else if( strcmp(item, "upnp:searchClass") == 0 )
		{
			flags |= FILTER_UPNP_SEARCHCLASS;
		}
		else if( strcmp(item, "upnp:storageUsed") == 0 )
		{
			flags |= FILTER_UPNP_STORAGEUSED;
		}
		else if( strcmp(item, "res") == 0 )
		{
			flags |= FILTER_RES;
		}
		else if( (strcmp(item, "res@bitrate") == 0) ||
		         (strcmp(item, "@bitrate") == 0) ||
		         ((strcmp(item, "bitrate") == 0) && (flags & FILTER_RES)) )
		{
			flags |= FILTER_RES;
			flags |= FILTER_RES_BITRATE;
		}
		else if( (strcmp(item, "res@duration") == 0) ||
		         (strcmp(item, "@duration") == 0) ||
		         ((strcmp(item, "duration") == 0) && (flags & FILTER_RES)) )
		{
			flags |= FILTER_RES;
			flags |= FILTER_RES_DURATION;
		}
		else if( (strcmp(item, "res@nrAudioChannels") == 0) ||
		         (strcmp(item, "@nrAudioChannels") == 0) ||
		         ((strcmp(item, "nrAudioChannels") == 0) && (flags & FILTER_RES)) )
		{
			flags |= FILTER_RES;
			flags |= FILTER_RES_NRAUDIOCHANNELS;
		}
		else if( (strcmp(item, "res@resolution") == 0) ||
		         (strcmp(item, "@resolution") == 0) ||
		         ((strcmp(item, "resolution") == 0) && (flags & FILTER_RES)) )
		{
			flags |= FILTER_RES;
			flags |= FILTER_RES_RESOLUTION;
		}
		else if( (strcmp(item, "res@sampleFrequency") == 0) ||
		         (strcmp(item, "@sampleFrequency") == 0) ||
		         ((strcmp(item, "sampleFrequency") == 0) && (flags & FILTER_RES)) )
		{
			flags |= FILTER_RES;
			flags |= FILTER_RES_SAMPLEFREQUENCY;
		}
		else if( (strcmp(item, "res@size") == 0) ||
		         (strcmp(item, "@size") == 0) ||
		         (strcmp(item, "size") == 0) )
		{
			flags |= FILTER_RES;
			flags |= FILTER_RES_SIZE;
		}
		else if( strcmp(item, "sec:CaptionInfoEx") == 0 )
		{
			flags |= FILTER_SEC_CAPTION_INFO_EX;
		}
		else if( strcmp(item, "sec:dcmInfo") == 0 )
		{
			flags |= FILTER_SEC_DCM_INFO;
		}
		else if( strcmp(item, "res@pv:subtitleFileType") == 0 )
		{
			flags |= FILTER_PV_SUBTITLE_FILE_TYPE;
		}
		else if( strcmp(item, "res@pv:subtitleFileUri") == 0 )
		{
			flags |= FILTER_PV_SUBTITLE_FILE_URI;
		}
		else if( strcmp(item, "av:mediaClass") == 0 )
		{
			flags |= FILTER_AV_MEDIA_CLASS;
		}
		item = strtok_r(NULL, ",", &saveptr);
	}

	return flags;
}
/*
char *
parse_sort_criteria(char *sortCriteria, int *error)
{
	char *order = NULL;
	char *item, *saveptr;
	int i, ret, reverse, title_sorted = 0;
	struct string_s str;
	*error = 0;

	if( force_sort_criteria )
		sortCriteria = strdup(force_sort_criteria);
	if( !sortCriteria )
		return NULL;

	if( (item = strtok_r(sortCriteria, ",", &saveptr)) )
	{
		order = malloc(4096);
		str.data = order;
		str.size = 4096;
		str.off = 0;
		strcatf(&str, "order by ");
	}
	for( i = 0; item != NULL; i++ )
	{
		reverse=0;
		if( i )
			strcatf(&str, ", ");
		if( *item == '+' )
		{
			item++;
		}
		else if( *item == '-' )
		{
			reverse = 1;
			item++;
		}
		else
		{
			printf("No order specified [%s]\n", item);
			goto bad_direction;
		}
		if( strcasecmp(item, "upnp:class") == 0 )
		{
			strcatf(&str, "o.CLASS");
		}
		else if( strcasecmp(item, "dc:title") == 0 )
		{
			strcatf(&str, "d.TITLE");
			title_sorted = 1;
		}
		else if( strcasecmp(item, "dc:date") == 0 )
		{
			strcatf(&str, "d.DATE");
		}
		else if( strcasecmp(item, "upnp:originalTrackNumber") == 0 )
		{
			strcatf(&str, "d.DISC, d.TRACK");
		}
		else if( strcasecmp(item, "upnp:album") == 0 )
		{
			strcatf(&str, "d.ALBUM");
		}
		else
		{
			printf("Unhandled SortCriteria [%s]\n", item);
		bad_direction:
			*error = -1;
			if( i )
			{
				ret = strlen(order);
				order[ret-2] = '\0';
			}
			i--;
			goto unhandled_order;
		}

		if( reverse )
			strcatf(&str, " DESC");
		unhandled_order:
		item = strtok_r(NULL, ",", &saveptr);
	}
	if( i <= 0 )
	{
		free(order);
		if( force_sort_criteria )
			free(sortCriteria);
		return NULL;
	}
	// Add a "tiebreaker" sort order 
	if( !title_sorted )
		strcatf(&str, ", TITLE ASC");

	if( force_sort_criteria )
		free(sortCriteria);

	return order;
}

inline static void
add_resized_res(int srcw, int srch, int reqw, int reqh, char *dlna_pn,
                char *detailID, struct Response *args)
{
	int dstw = reqw;
	int dsth = reqh;

	if( args->flags & FLAG_NO_RESIZE )
		return;

	strcatf(args->str, "&lt;res ");
	if( args->filter & FILTER_RES_RESOLUTION )
	{
		dstw = reqw;
		dsth = ((((reqw<<10)/srcw)*srch)>>10);
		if( dsth > reqh ) {
			dsth = reqh;
			dstw = (((reqh<<10)/srch) * srcw>>10);
		}
		strcatf(args->str, "resolution=\"%dx%d\" ", dstw, dsth);
	}
	strcatf(args->str, "protocolInfo=\"http-get:*:image/jpeg:"
	                          "DLNA.ORG_PN=%s;DLNA.ORG_CI=1;DLNA.ORG_FLAGS=%08X%024X\"&gt;"
	                          "http://%s:%d/Resized/%s.jpg?width=%d,height=%d"
	                          "&lt;/res&gt;",
	                          dlna_pn, DLNA_FLAG_DLNA_V1_5|DLNA_FLAG_HTTP_STALLING|DLNA_FLAG_TM_B|DLNA_FLAG_TM_I, 0,
	                          lan_addr[args->iface].str, runtime_vars.port,
	                          detailID, dstw, dsth);
}

inline static void
add_res(char *size, char *duration, char *bitrate, char *sampleFrequency,
        char *nrAudioChannels, char *resolution, char *dlna_pn, char *mime,
        char *detailID, const char *ext, struct Response *args)
{
	strcatf(args->str, "&lt;res ");
	if( size && (args->filter & FILTER_RES_SIZE) ) {
		strcatf(args->str, "size=\"%s\" ", size);
	}
	if( duration && (args->filter & FILTER_RES_DURATION) ) {
		strcatf(args->str, "duration=\"%s\" ", duration);
	}
	if( bitrate && (args->filter & FILTER_RES_BITRATE) ) {
		int br = atoi(bitrate);
		if(args->flags & FLAG_MS_PFS)
			br /= 8;
		strcatf(args->str, "bitrate=\"%d\" ", br);
	}
	if( sampleFrequency && (args->filter & FILTER_RES_SAMPLEFREQUENCY) ) {
		strcatf(args->str, "sampleFrequency=\"%s\" ", sampleFrequency);
	}
	if( nrAudioChannels && (args->filter & FILTER_RES_NRAUDIOCHANNELS) ) {
		strcatf(args->str, "nrAudioChannels=\"%s\" ", nrAudioChannels);
	}
	if( resolution && (args->filter & FILTER_RES_RESOLUTION) ) {
		strcatf(args->str, "resolution=\"%s\" ", resolution);
	}
	if( args->filter & FILTER_PV_SUBTITLE )
	{
		if( args->flags & FLAG_HAS_CAPTIONS )
		{
			if( args->filter & FILTER_PV_SUBTITLE_FILE_TYPE )
				strcatf(args->str, "pv:subtitleFileType=\"SRT\" ");
			if( args->filter & FILTER_PV_SUBTITLE_FILE_URI )
				strcatf(args->str, "pv:subtitleFileUri=\"http://%s:%d/Captions/%s.srt\" ",
			                lan_addr[args->iface].str, runtime_vars.port, detailID);
		}
	}
	strcatf(args->str, "protocolInfo=\"http-get:*:%s:%s\"&gt;"
	                          "http://%s:%d/MediaItems/%s.%s"
	                          "&lt;/res&gt;",
	                          mime, dlna_pn, lan_addr[args->iface].str,
	                          runtime_vars.port, detailID, ext);
}

static int
get_child_count(const char *object, struct magic_container_s *magic)
{
	int ret;

	if (magic && magic->child_count)
		ret = sql_get_int_field(db, "SELECT count(*) from %s", magic->child_count);
	else if (magic && magic->objectid && *(magic->objectid))
		ret = sql_get_int_field(db, "SELECT count(*) from OBJECTS where PARENT_ID = '%s';", *(magic->objectid));
	else
		ret = sql_get_int_field(db, "SELECT count(*) from OBJECTS where PARENT_ID = '%s';", object);

	return (ret > 0) ? ret : 0;
}

static int
object_exists(const char *object)
{
	int ret;
	ret = sql_get_int_field(db, "SELECT count(*) from OBJECTS where OBJECT_ID = '%q'",
				strcmp(object, "*") == 0 ? "0" : object);
	return (ret > 0);
}

#define COLUMNS "o.DETAIL_ID, o.CLASS," \
                " d.SIZE, d.TITLE, d.DURATION, d.BITRATE, d.SAMPLERATE, d.ARTIST," \
                " d.ALBUM, d.GENRE, d.COMMENT, d.CHANNELS, d.TRACK, d.DATE, d.RESOLUTION," \
                " d.THUMBNAIL, d.CREATOR, d.DLNA_PN, d.MIME, d.ALBUM_ART, d.DISC "
#define SELECT_COLUMNS "SELECT o.OBJECT_ID, o.PARENT_ID, o.REF_ID, " COLUMNS

static int
callback(void *args, int argc, char **argv, char **azColName)
{
	struct Response *passed_args = (struct Response *)args;
	char *id = argv[0], *parent = argv[1], *refID = argv[2], *detailID = argv[3], *class = argv[4], *size = argv[5], *title = argv[6],
	     *duration = argv[7], *bitrate = argv[8], *sampleFrequency = argv[9], *artist = argv[10], *album = argv[11],
	     *genre = argv[12], *comment = argv[13], *nrAudioChannels = argv[14], *track = argv[15], *date = argv[16], *resolution = argv[17],
	     *tn = argv[18], *creator = argv[19], *dlna_pn = argv[20], *mime = argv[21], *album_art = argv[22];
	char dlna_buf[128];
	const char *ext;
	struct string_s *str = passed_args->str;
	int ret = 0;

	// Make sure we have at least 8KB left of allocated memory to finish the response. 
	if( str->off > (str->size - 8192) )
	{
#if MAX_RESPONSE_SIZE > 0
		if( (str->size+DEFAULT_RESP_SIZE) <= MAX_RESPONSE_SIZE )
		{
#endif
			str->data = realloc(str->data, (str->size+DEFAULT_RESP_SIZE));
			if( str->data )
			{
				str->size += DEFAULT_RESP_SIZE;
				printf("UPnP SOAP response enlarged to %lu. [%d results so far]\n",
					(unsigned long)str->size, passed_args->returned);
			}
			else
			{
				printf( "UPnP SOAP response was too big, and realloc failed!\n");
				return -1;
			}
#if MAX_RESPONSE_SIZE > 0
		}
		else
		{
			printf("UPnP SOAP response cut short, to not exceed the max response size [%lld]!\n", (long long int)MAX_RESPONSE_SIZE);
			return -1;
		}
#endif
	}
	passed_args->returned++;

	if( strncmp(class, "item", 4) == 0 )
	{
		uint32_t dlna_flags = DLNA_FLAG_DLNA_V1_5|DLNA_FLAG_HTTP_STALLING|DLNA_FLAG_TM_B;
		char *alt_title = NULL;
		// We may need special handling for certain MIME types 
		if( *mime == 'v' )
		{
			dlna_flags |= DLNA_FLAG_TM_S;
			if( passed_args->flags & FLAG_MIME_AVI_DIVX )
			{
				if( strcmp(mime, "video/x-msvideo") == 0 )
				{
					if( creator )
						strcpy(mime+6, "divx");
					else
						strcpy(mime+6, "avi");
				}
			}
			else if( passed_args->flags & FLAG_MIME_AVI_AVI )
			{
				if( strcmp(mime, "video/x-msvideo") == 0 )
				{
					strcpy(mime+6, "avi");
				}
			}
			else if( passed_args->client == EFreeBox && dlna_pn )
			{
				if( strncmp(dlna_pn, "AVC_TS", 6) == 0 ||
				    strncmp(dlna_pn, "MPEG_TS", 7) == 0 )
				{
					strcpy(mime+6, "mp2t");
				}
			}
			if( !(passed_args->flags & FLAG_DLNA) )
			{
				if( strcmp(mime+6, "vnd.dlna.mpeg-tts") == 0 )
				{
					strcpy(mime+6, "mpeg");
				}
			}
			if( (passed_args->flags & FLAG_CAPTION_RES) ||
			    (passed_args->filter & (FILTER_SEC_CAPTION_INFO_EX|FILTER_PV_SUBTITLE)) )
			{
				if( sql_get_int_field(db, "SELECT ID from CAPTIONS where ID = '%s'", detailID) > 0 )
					passed_args->flags |= FLAG_HAS_CAPTIONS;
			}
			// From what I read, Samsung TV's expect a [wrong] MIME type of x-mkv. 
			if( passed_args->flags & FLAG_SAMSUNG )
			{
				if( strcmp(mime+6, "x-matroska") == 0 )
				{
					strcpy(mime+8, "mkv");
				}
			}
			// LG hack: subtitles won't get used unless dc:title contains a dot.
			else if( passed_args->client == ELGDevice && (passed_args->flags & FLAG_HAS_CAPTIONS) )
			{
				ret = asprintf(&alt_title, "%s.", title);
				if( ret > 0 )
					title = alt_title;
				else
					alt_title = NULL;
			}
			// Asus OPlay reboots with titles longer than 23 characters with some file types. 
			else if( passed_args->client == EAsusOPlay && (passed_args->flags & FLAG_HAS_CAPTIONS) )
			{
				if( strlen(title) > 23 )
					title[23] = '\0';
			}
		}
		else if( *mime == 'a' )
		{
			dlna_flags |= DLNA_FLAG_TM_S;
			if( strcmp(mime+6, "x-flac") == 0 )
			{
				if( passed_args->flags & FLAG_MIME_FLAC_FLAC )
				{
					strcpy(mime+6, "flac");
				}
			}
			else if( strcmp(mime+6, "x-wav") == 0 )
			{
				if( passed_args->flags & FLAG_MIME_WAV_WAV )
				{
					strcpy(mime+6, "wav");
				}
			}
		}
		else
			dlna_flags |= DLNA_FLAG_TM_I;

		if( dlna_pn )
			snprintf(dlna_buf, sizeof(dlna_buf), "DLNA.ORG_PN=%s;"
			                                     "DLNA.ORG_OP=01;"
			                                     "DLNA.ORG_CI=0;"
			                                     "DLNA.ORG_FLAGS=%08X%024X",
			                                     dlna_pn, dlna_flags, 0);
		else if( passed_args->flags & FLAG_DLNA )
			snprintf(dlna_buf, sizeof(dlna_buf), "DLNA.ORG_OP=01;"
			                                     "DLNA.ORG_CI=0;"
			                                     "DLNA.ORG_FLAGS=%08X%024X",
			                                     dlna_flags, 0);
		else
			strcpy(dlna_buf, "*");

		ret = strcatf(str, "&lt;item id=\"%s\" parentID=\"%s\" restricted=\"1\"", id, parent);
		if( refID && (passed_args->filter & FILTER_REFID) ) {
			ret = strcatf(str, " refID=\"%s\"", refID);
		}
		ret = strcatf(str, "&gt;"
		                   "&lt;dc:title&gt;%s&lt;/dc:title&gt;"
		                   "&lt;upnp:class&gt;object.%s&lt;/upnp:class&gt;",
		                   title, class);
		if( comment && (passed_args->filter & FILTER_DC_DESCRIPTION) ) {
			ret = strcatf(str, "&lt;dc:description&gt;%.384s&lt;/dc:description&gt;", comment);
		}
		if( creator && (passed_args->filter & FILTER_DC_CREATOR) ) {
			ret = strcatf(str, "&lt;dc:creator&gt;%s&lt;/dc:creator&gt;", creator);
		}
		if( date && (passed_args->filter & FILTER_DC_DATE) ) {
			ret = strcatf(str, "&lt;dc:date&gt;%s&lt;/dc:date&gt;", date);
		}
		if( passed_args->filter & FILTER_SEC_DCM_INFO ) {
			// Get bookmark 
			ret = strcatf(str, "&lt;sec:dcmInfo&gt;CREATIONDATE=0,FOLDER=%s,BM=%d&lt;/sec:dcmInfo&gt;",
			              title, sql_get_int_field(db, "SELECT SEC from BOOKMARKS where ID = '%s'", detailID));
		}
		if( artist ) {
			if( (*mime == 'v') && (passed_args->filter & FILTER_UPNP_ACTOR) ) {
				ret = strcatf(str, "&lt;upnp:actor&gt;%s&lt;/upnp:actor&gt;", artist);
			}
			if( passed_args->filter & FILTER_UPNP_ARTIST ) {
				ret = strcatf(str, "&lt;upnp:artist&gt;%s&lt;/upnp:artist&gt;", artist);
			}
		}
		if( album && (passed_args->filter & FILTER_UPNP_ALBUM) ) {
			ret = strcatf(str, "&lt;upnp:album&gt;%s&lt;/upnp:album&gt;", album);
		}
		if( genre && (passed_args->filter & FILTER_UPNP_GENRE) ) {
			ret = strcatf(str, "&lt;upnp:genre&gt;%s&lt;/upnp:genre&gt;", genre);
		}
		if( strncmp(id, MUSIC_PLIST_ID, strlen(MUSIC_PLIST_ID)) == 0 ) {
			track = strrchr(id, '$')+1;
		}
		if( track && atoi(track) && (passed_args->filter & FILTER_UPNP_ORIGINALTRACKNUMBER) ) {
			ret = strcatf(str, "&lt;upnp:originalTrackNumber&gt;%s&lt;/upnp:originalTrackNumber&gt;", track);
		}
		if( passed_args->filter & FILTER_RES ) {
			ext = mime_to_ext(mime);
			add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
			        resolution, dlna_buf, mime, detailID, ext, passed_args);
			if( *mime == 'i' ) {
				int srcw, srch;
				if( resolution && (sscanf(resolution, "%6dx%6d", &srcw, &srch) == 2) )
				{
					if( srcw > 4096 || srch > 4096 )
						add_resized_res(srcw, srch, 4096, 4096, "JPEG_LRG", detailID, passed_args);
					if( srcw > 1024 || srch > 768 )
						add_resized_res(srcw, srch, 1024, 768, "JPEG_MED", detailID, passed_args);
					if( srcw > 640 || srch > 480 )
						add_resized_res(srcw, srch, 640, 480, "JPEG_SM", detailID, passed_args);
				}
				if( !(passed_args->flags & FLAG_RESIZE_THUMBS) && tn && atoi(tn) ) {
					ret = strcatf(str, "&lt;res protocolInfo=\"http-get:*:%s:%s\"&gt;"
					                   "http://%s:%d/Thumbnails/%s.jpg"
					                   "&lt;/res&gt;",
					                   mime, "DLNA.ORG_PN=JPEG_TN;DLNA.ORG_CI=1", lan_addr[passed_args->iface].str,
					                   runtime_vars.port, detailID);
				}
				else
					add_resized_res(srcw, srch, 160, 160, "JPEG_TN", detailID, passed_args);
			}
			else if( *mime == 'v' ) {
				switch( passed_args->client ) {
				case EToshibaTV:
					if( dlna_pn &&
					    (strncmp(dlna_pn, "MPEG_TS_HD_NA", 13) == 0 ||
					     strncmp(dlna_pn, "MPEG_TS_SD_NA", 13) == 0 ||
					     strncmp(dlna_pn, "AVC_TS_MP_HD_AC3", 16) == 0 ||
					     strncmp(dlna_pn, "AVC_TS_HP_HD_AC3", 16) == 0))
					{
						sprintf(dlna_buf, "DLNA.ORG_PN=%s;DLNA.ORG_OP=01;DLNA.ORG_CI=1", "MPEG_PS_NTSC");
						add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
						        resolution, dlna_buf, mime, detailID, ext, passed_args);
					}
					break;
				case ESonyBDP:
					if( dlna_pn &&
					    (strncmp(dlna_pn, "AVC_TS", 6) == 0 ||
					     strncmp(dlna_pn, "MPEG_TS", 7) == 0) )
					{
						if( strncmp(dlna_pn, "MPEG_TS_SD_NA", 13) != 0 )
						{
							sprintf(dlna_buf, "DLNA.ORG_PN=%s;DLNA.ORG_OP=01;DLNA.ORG_CI=1", "MPEG_TS_SD_NA");
							add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
							        resolution, dlna_buf, mime, detailID, ext, passed_args);
						}
						if( strncmp(dlna_pn, "MPEG_TS_SD_EU", 13) != 0 )
						{
							sprintf(dlna_buf, "DLNA.ORG_PN=%s;DLNA.ORG_OP=01;DLNA.ORG_CI=1", "MPEG_TS_SD_EU");
							add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
							        resolution, dlna_buf, mime, detailID, ext, passed_args);
						}
					}
					else if( (dlna_pn &&
					          (strncmp(dlna_pn, "AVC_MP4", 7) == 0 ||
					           strncmp(dlna_pn, "MPEG4_P2_MP4", 12) == 0)) ||
					         strcmp(mime+6, "x-matroska") == 0 ||
					         strcmp(mime+6, "x-msvideo") == 0 ||
					         strcmp(mime+6, "mpeg") == 0 )
					{
						strcpy(mime+6, "avi");
						if( !dlna_pn || strncmp(dlna_pn, "MPEG_PS_NTSC", 12) != 0 )
						{
							sprintf(dlna_buf, "DLNA.ORG_PN=%s;DLNA.ORG_OP=01;DLNA.ORG_CI=1", "MPEG_PS_NTSC");
							add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
						        	resolution, dlna_buf, mime, detailID, ext, passed_args);
						}
						if( !dlna_pn || strncmp(dlna_pn, "MPEG_PS_PAL", 11) != 0 )
						{
							sprintf(dlna_buf, "DLNA.ORG_PN=%s;DLNA.ORG_OP=01;DLNA.ORG_CI=1", "MPEG_PS_PAL");
							add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
						        	resolution, dlna_buf, mime, detailID, ext, passed_args);
						}
					}
					break;
				case ESonyBravia:
					// BRAVIA KDL-##*X### series TVs do natively support AVC/AC3 in TS, but
					//   require profile to be renamed (applies to _T and _ISO variants also)
					if( dlna_pn &&
					    (strncmp(dlna_pn, "AVC_TS_MP_SD_AC3", 16) == 0 ||
					     strncmp(dlna_pn, "AVC_TS_MP_HD_AC3", 16) == 0 ||
					     strncmp(dlna_pn, "AVC_TS_HP_HD_AC3", 16) == 0))
					{
					        sprintf(dlna_buf, "DLNA.ORG_PN=AVC_TS_HD_50_AC3%s", dlna_pn + 16);
						add_res(size, duration, bitrate, sampleFrequency, nrAudioChannels,
						        resolution, dlna_buf, mime, detailID, ext, passed_args);
					}
					break;
				case ESamsungSeriesCDE:
				case ELGDevice:
				case EAsusOPlay:
				default:
					if( passed_args->flags & FLAG_HAS_CAPTIONS )
					{
						if( passed_args->flags & FLAG_CAPTION_RES )
							ret = strcatf(str, "&lt;res protocolInfo=\"http-get:*:text/srt:*\"&gt;"
									     "http://%s:%d/Captions/%s.srt"
									   "&lt;/res&gt;",
									   lan_addr[passed_args->iface].str, runtime_vars.port, detailID);
						else if( passed_args->filter & FILTER_SEC_CAPTION_INFO_EX )
							ret = strcatf(str, "&lt;sec:CaptionInfoEx sec:type=\"srt\"&gt;"
							                     "http://%s:%d/Captions/%s.srt"
							                   "&lt;/sec:CaptionInfoEx&gt;",
							                   lan_addr[passed_args->iface].str, runtime_vars.port, detailID);
					}
					free(alt_title);
					break;
				}
			}
		}
		if( album_art && atoi(album_art) )
		{
			// Video and audio album art is handled differently 
			if( *mime == 'v' && (passed_args->filter & FILTER_RES) && !(passed_args->flags & FLAG_MS_PFS) ) {
				ret = strcatf(str, "&lt;res protocolInfo=\"http-get:*:image/jpeg:DLNA.ORG_PN=JPEG_TN\"&gt;"
				                   "http://%s:%d/AlbumArt/%s-%s.jpg"
				                   "&lt;/res&gt;",
				                   lan_addr[passed_args->iface].str, runtime_vars.port, album_art, detailID);
			} else if( passed_args->filter & FILTER_UPNP_ALBUMARTURI ) {
				ret = strcatf(str, "&lt;upnp:albumArtURI");
				if( passed_args->filter & FILTER_UPNP_ALBUMARTURI_DLNA_PROFILEID ) {
					ret = strcatf(str, " dlna:profileID=\"JPEG_TN\" xmlns:dlna=\"urn:schemas-dlna-org:metadata-1-0/\"");
				}
				ret = strcatf(str, "&gt;http://%s:%d/AlbumArt/%s-%s.jpg&lt;/upnp:albumArtURI&gt;",
				                   lan_addr[passed_args->iface].str, runtime_vars.port, album_art, detailID);
			}
		}
		if( (passed_args->flags & FLAG_MS_PFS) && *mime == 'i' ) {
			if( passed_args->client == EMediaRoom && !album )
				ret = strcatf(str, "&lt;upnp:album&gt;%s&lt;/upnp:album&gt;", "[No Keywords]");

			// EVA2000 doesn't seem to handle embedded thumbnails
			if( !(passed_args->flags & FLAG_RESIZE_THUMBS) && tn && atoi(tn) ) {
				ret = strcatf(str, "&lt;upnp:albumArtURI&gt;"
				                   "http://%s:%d/Thumbnails/%s.jpg"
				                   "&lt;/upnp:albumArtURI&gt;",
				                   lan_addr[passed_args->iface].str, runtime_vars.port, detailID);
			} else {
				ret = strcatf(str, "&lt;upnp:albumArtURI&gt;"
				                   "http://%s:%d/Resized/%s.jpg?width=160,height=160"
				                   "&lt;/upnp:albumArtURI&gt;",
				                   lan_addr[passed_args->iface].str, runtime_vars.port, detailID);
			}
		}
		ret = strcatf(str, "&lt;/item&gt;");
	}
	else if( strncmp(class, "container", 9) == 0 )
	{
		ret = strcatf(str, "&lt;container id=\"%s\" parentID=\"%s\" restricted=\"1\" ", id, parent);
		if( passed_args->filter & FILTER_SEARCHABLE ) {
			ret = strcatf(str, "searchable=\"%d\" ", check_magic_container(id, passed_args->flags) ? 0 : 1);
		}
		if( passed_args->filter & FILTER_CHILDCOUNT ) {
			ret = strcatf(str, "childCount=\"%d\"", get_child_count(id, check_magic_container(id, passed_args->flags)));
		}
		// If the client calls for BrowseMetadata on root, we have to include our "upnp:searchClass"'s, unless they're filtered out 
		if( passed_args->requested == 1 && strcmp(id, "0") == 0 && (passed_args->filter & FILTER_UPNP_SEARCHCLASS) ) {
			ret = strcatf(str, "&gt;"
			                   "&lt;upnp:searchClass includeDerived=\"1\"&gt;object.item.audioItem&lt;/upnp:searchClass&gt;"
			                   "&lt;upnp:searchClass includeDerived=\"1\"&gt;object.item.imageItem&lt;/upnp:searchClass&gt;"
			                   "&lt;upnp:searchClass includeDerived=\"1\"&gt;object.item.videoItem&lt;/upnp:searchClass");
		}
		ret = strcatf(str, "&gt;"
		                   "&lt;dc:title&gt;%s&lt;/dc:title&gt;"
		                   "&lt;upnp:class&gt;object.%s&lt;/upnp:class&gt;",
		                   title, class);
		if( (passed_args->filter & FILTER_UPNP_STORAGEUSED) || strcmp(class+10, "storageFolder") == 0 ) {
			// TODO: Implement real folder size tracking 
			ret = strcatf(str, "&lt;upnp:storageUsed&gt;%s&lt;/upnp:storageUsed&gt;", (size ? size : "-1"));
		}
		if( creator && (passed_args->filter & FILTER_DC_CREATOR) ) {
			ret = strcatf(str, "&lt;dc:creator&gt;%s&lt;/dc:creator&gt;", creator);
		}
		if( genre && (passed_args->filter & FILTER_UPNP_GENRE) ) {
			ret = strcatf(str, "&lt;upnp:genre&gt;%s&lt;/upnp:genre&gt;", genre);
		}
		if( artist && (passed_args->filter & FILTER_UPNP_ARTIST) ) {
			ret = strcatf(str, "&lt;upnp:artist&gt;%s&lt;/upnp:artist&gt;", artist);
		}
		if( album_art && atoi(album_art) && (passed_args->filter & FILTER_UPNP_ALBUMARTURI) ) {
			ret = strcatf(str, "&lt;upnp:albumArtURI ");
			if( passed_args->filter & FILTER_UPNP_ALBUMARTURI_DLNA_PROFILEID ) {
				ret = strcatf(str, "dlna:profileID=\"JPEG_TN\" xmlns:dlna=\"urn:schemas-dlna-org:metadata-1-0/\"");
			}
			ret = strcatf(str, "&gt;http://%s:%d/AlbumArt/%s-%s.jpg&lt;/upnp:albumArtURI&gt;",
			                   lan_addr[passed_args->iface].str, runtime_vars.port, album_art, detailID);
		}
		if( passed_args->filter & FILTER_AV_MEDIA_CLASS ) {
			char class;
			if( strncmp(id, MUSIC_ID, sizeof(MUSIC_ID)) == 0 )
				class = 'M';
			else if( strncmp(id, VIDEO_ID, sizeof(VIDEO_ID)) == 0 )
				class = 'V';
			else if( strncmp(id, IMAGE_ID, sizeof(IMAGE_ID)) == 0 )
				class = 'P';
			else
				class = 0;
			if( class )
				ret = strcatf(str, "&lt;av:mediaClass xmlns:av=\"urn:schemas-sony-com:av\"&gt;"
				                    "%c&lt;/av:mediaClass&gt;", class);
		}
		ret = strcatf(str, "&lt;/container&gt;");
	}

	return 0;
}

	*/

//파일 확장명 비교
int file_ext_same (char *filename, char *ext)
{

	int i, ext_len, filename_len, cnt=0;

	ext_len = strlen(ext); //확장자 길이
	filename_len = strlen(filename); //주어진 파일명 길이

	//확장명이 파일명보다 길 경우 리턴
	if(ext_len > filename_len)
		return 0;

	//파일명 끝에서 부터 확장명과 비교
	for(i = ext_len-1; i > 0; i--){
		if(ext[i] == filename[--filename_len])
		cnt++;
	}

	if(cnt == ext_len-1)
		return 1;
	else
		return 0;
}

void mstrcat(char* str1, char* str2){
	int i=0, j=0;
	while(str1[i] != '\0') i++;

	while(str2[j] != '\0'){
		str1[i++] = str2[j++];
	}

	dlog_print(DLOG_DEBUG, "tdlna", "mstrcat i=%d j=%d", i, j);
	str1[i] = '\0';
}

static void
BrowseContentDirectory(struct upnphttp * h, const char * action)
{

	static const char resp0[] =
			"<u:BrowseResponse "
			"xmlns:u=\"urn:schemas-upnp-org:service:ContentDirectory:1\">"
			"<Result>"
			"&lt;DIDL-Lite"
			CONTENT_DIRECTORY_SCHEMAS;


	//struct magic_container_s *magic;
	//char *zErrMsg = NULL;
	char* ptr;//char *sql, *ptr
	char temp[4096];

	struct Response args;
	struct string_s str;
	int totalMatches = 0;
	int ret;
	const char *ObjectID, *BrowseFlag;
	char *Filter, *SortCriteria;
	//const char *objectid_sql = "o.OBJECT_ID";
	//const char *parentid_sql = "o.PARENT_ID";
	//const char *refid_sql = "o.REF_ID";
	//char where[256] = "";
	//char *orderBy = NULL;

	struct NameValueParserData data;
	int RequestedCount = 0;
	int StartingIndex = 0;

	//--- dirent -----
	struct dirent* dp;
	DIR* dirp;
	FILE* fp;
	long fileSize = 0;
	char fileFullPath[512];
	char encodedFileName[512];
	//----------------

	dlog_print(DLOG_INFO,"tdlna", "★★★  Browse 액션 처리중 ★★★");

	memset(&args, 0, sizeof(args));
	memset(&str, 0, sizeof(str));

	ParseNameValue(h->req_buf + h->req_contentoff, h->req_contentlen, &data, 0);

	ObjectID = GetValueFromNameValueList(&data, "ObjectID");
	Filter = GetValueFromNameValueList(&data, "Filter");
	BrowseFlag = GetValueFromNameValueList(&data, "BrowseFlag");
	SortCriteria = GetValueFromNameValueList(&data, "SortCriteria");


	if( (ptr = GetValueFromNameValueList(&data, "RequestedCount")) )
		RequestedCount = atoi(ptr);
	if( RequestedCount < 0 )
	{
		SoapError(h, 402, "Invalid Args");
		goto browse_error;
	}
	if( !RequestedCount )
		RequestedCount = -1;
	if( (ptr = GetValueFromNameValueList(&data, "StartingIndex")) )
		StartingIndex = atoi(ptr);
	if( StartingIndex < 0 )
	{
		SoapError(h, 402, "Invalid Args");
		goto browse_error;
	}
	if( !BrowseFlag || (strcmp(BrowseFlag, "BrowseDirectChildren") && strcmp(BrowseFlag, "BrowseMetadata")) )
	{
		SoapError(h, 402, "Invalid Args");
		goto browse_error;
	}
	if( !ObjectID && !(ObjectID = GetValueFromNameValueList(&data, "ContainerID")) )
	{
		SoapError(h, 402, "Invalid Args");
		goto browse_error;
	}

	str.data = malloc(DEFAULT_RESP_SIZE);
	//memset(str.data, '\0', DEFAULT_RESP_SIZE);

	if(str.data == NULL) goto browse_error;
	str.size = DEFAULT_RESP_SIZE;
	str.off = sprintf(str.data, "%s", resp0);

	// See if we need to include DLNA namespace reference 
	args.iface = h->iface;

	args.filter = set_filter_flags(Filter, h);
	if( args.filter & FILTER_DLNA_NAMESPACE )
		ret = strcatf(&str, DLNA_NAMESPACE);
	if( args.filter & FILTER_PV_SUBTITLE ){
		dlog_print(DLOG_DEBUG, "tdlna", "삼성!!기기 연결! PV NameSpase 찍음");
		ret = strcatf(&str, PV_NAMESPACE);
	}

	//strcatf(&str, "&gt;\n"); //>

	args.returned = 0;
	args.requested = RequestedCount;
	args.client = h->req_client ? h->req_client->type->type : 0;
	args.flags = h->req_client ? h->req_client->type->flags : 0;
	args.str = &str;

	dlog_print(DLOG_WARN,"tdlna", " ObjectID: %s", ObjectID);
	dlog_print(DLOG_WARN,"tdlna", " RequestedCount: %d", RequestedCount);
	dlog_print(DLOG_WARN,"tdlna", " StartingIndex: %d", StartingIndex);
	dlog_print(DLOG_WARN,"tdlna", " BrowseFlag: %s", BrowseFlag);
	dlog_print(DLOG_WARN,"tdlna", " Filter: %s", Filter);
	//dlog_print(DLOG_INFO,"tdlna", " SortCriteria: %s", SortCriteria);

	//=========================================== 여기까지는 정상작동할것으로 봄 ==================================

	if(strcmp(ObjectID, "2$8") == 0){ //비디오!!!!!!!!!!!!!!!!!!!!!!!!!!!

		strcat(str.data, "&gt;");

		int itemCount = 0;

		//홈 디렉토리의 파일목록을 구해 확장자가 mp4인것만 추출
		dirp = opendir(HOME_DIR);
		while((dp = readdir(dirp)) != NULL) //디렉토리 안의 내용을 하나씩 가져와 확장자 비교
		{
			//if(itemCount == 1) break;
			if(file_ext_same(dp->d_name, "mp4")){
				sprintf(fileFullPath, "%s/%s", HOME_DIR, dp->d_name); //전체 파일경로
				//strcpy(encodedFileName, dp->d_name);
				UrlEncode(dp->d_name, encodedFileName);

				dlog_print(DLOG_DEBUG, "tdlna", "해당파일 경로: %s 인코딩 파일명 %s", fileFullPath, encodedFileName);

				//파일 사이즈 구하기
				if((fp=fopen(fileFullPath, "rb"))==NULL)
					goto browse_error;
				fseek(fp, 0L, SEEK_END);
				fileSize = ftell(fp);
				fclose(fp);

				dlog_print(DLOG_DEBUG, "tdlna", "해당파일 크기: %ld", fileSize);

				sprintf(temp, BROWSE_VIDEO_ITEM, itemCount++, dp->d_name, fileSize, lan_addr[0].str, runtime_vars.port, encodedFileName);
				dlog_print(DLOG_DEBUG, "tdlna", "temp길이: %d", strlen(temp));

				strcat(str.data, temp); //각 파일에 대한 xml코드 이어붙임

				dlog_print(DLOG_ERROR, "tdlna", "템프%d: %s", itemCount, temp);
				dlog_print(DLOG_ERROR, "tdlna", "데이타: %s",  str.data);

			}
		}

		sprintf(temp, "&lt;/DIDL-Lite&gt;</Result>\n"
				"<NumberReturned>%u</NumberReturned>\n"
				"<TotalMatches>%u</TotalMatches>\n"
				"<UpdateID>%u</UpdateID>"
				"</u:BrowseResponse>", itemCount, itemCount, updateID);

		strcat(str.data, temp); //각 파일에 대한 xml코드 이어붙임

		dlog_print(DLOG_ERROR, "tdlna", "데이타 길이 %d", strlen(str.data));

	}
	else if(strcmp(ObjectID, "2") == 0){

		//비디오의 폴더목록
		char* BrowseRoot;
		BrowseRoot = malloc(2048);

		sprintf(BrowseRoot, SAMSUNG_BROWSE_VIDEO);

		str.off = sprintf(str.data, "%s&gt;\n%s"
				"&lt;/DIDL-Lite&gt;</Result>\n"
				"<NumberReturned>%u</NumberReturned>\n"
				"<TotalMatches>%u</TotalMatches>\n"
				"<UpdateID>%u</UpdateID>"
				"</u:BrowseResponse>", resp0, BrowseRoot, 2, 2, updateID);

		//dlog_print(DLOG_DEBUG, "tdlna", "%s", BrowseRoot);
		dlog_print(DLOG_DEBUG, "tdlna", "삼성용 루트 복사");

		free(BrowseRoot);

	}
	else
	{
		//Root 목록 (동영상/음악/사진)

		char* BrowseRoot;
				BrowseRoot = malloc(1024);

				sprintf(BrowseRoot, BROWSE_ROOT_RESULT, 1,1,1); //ImageNum, AudioNum, VideoNum

				//strcatf(&str, BROWSE_ROOT_RESULT, 0,0,1);
				str.off = sprintf(str.data, "%s&gt;\n%s"
								"&lt;/DIDL-Lite&gt;</Result>\n"
			                    "<NumberReturned>%u</NumberReturned>\n"
			                    "<TotalMatches>%u</TotalMatches>\n"
			                    "<UpdateID>%u</UpdateID>"
			                    "</u:BrowseResponse>", resp0, BrowseRoot, 3, 3, updateID);

				//dlog_print(DLOG_DEBUG, "tdlna", "%s", BrowseRoot);
				dlog_print(DLOG_DEBUG, "tdlna", "브라우즈루트 복사");

				free(BrowseRoot);

				//image audio video 3가지 항목
				args.returned = 3;
				totalMatches = 3;
	}

	/*
	//--------------------------
	 //BrowseDirectChildren or BrowseMetadata
	if( strcmp(BrowseFlag+6, "Metadata") == 0 )
	{
		const char *id = ObjectID;
		args.requested = 1;

		magic = in_magic_container(ObjectID, args.flags, &id);
		if (magic)
		{
			if (magic->objectid_sql && strcmp(id, ObjectID) != 0)
				objectid_sql = magic->objectid_sql;
			if (magic->parentid_sql && strcmp(id, ObjectID) != 0)
				parentid_sql = magic->parentid_sql;
			if (magic->refid_sql)
				refid_sql = magic->refid_sql;
		}
		sql = sqlite3_mprintf("SELECT %s, %s, %s, " COLUMNS
				      "from OBJECTS o left join DETAILS d on (d.ID = o.DETAIL_ID)"
				      " where OBJECT_ID = '%q';",
				      objectid_sql, parentid_sql, refid_sql, id);
		ret = sqlite3_exec(db, sql, callback, (void *) &args, &zErrMsg);

		totalMatches = 0; //args.returned;

	}
	else
	{
		magic = check_magic_container(ObjectID, args.flags);
		if (magic)
		{
			if (magic->objectid && *(magic->objectid))
				ObjectID = *(magic->objectid);
			if (magic->objectid_sql)
				objectid_sql = magic->objectid_sql;
			if (magic->parentid_sql)
				parentid_sql = magic->parentid_sql;
			if (magic->refid_sql)
				refid_sql = magic->refid_sql;
			if (magic->where)
				strncpyt(where, magic->where, sizeof(where));
			if (magic->max_count > 0)
			{
				ret = get_child_count(ObjectID, magic);
				totalMatches = ret > magic->max_count ? magic->max_count : ret;
				if (RequestedCount > magic->max_count || RequestedCount < 0)
					RequestedCount = magic->max_count;
			}
		}
		if (!where[0])
			sqlite3_snprintf(sizeof(where), where, "PARENT_ID = '%q'", ObjectID);

		if (!totalMatches)
			totalMatches = get_child_count(ObjectID, magic);
		ret = 0;
		if( SortCriteria )
		{
			__SORT_LIMIT
			orderBy = parse_sort_criteria(SortCriteria, &ret);
		}
		else if (!orderBy)
		{
			if( strncmp(ObjectID, MUSIC_PLIST_ID, strlen(MUSIC_PLIST_ID)) == 0 )
			{
				if( strcmp(ObjectID, MUSIC_PLIST_ID) == 0 )
					ret = xasprintf(&orderBy, "order by d.TITLE");
				else
					ret = xasprintf(&orderBy, "order by length(OBJECT_ID), OBJECT_ID");
			}
			else if( args.flags & FLAG_FORCE_SORT )
			{
				__SORT_LIMIT
				ret = xasprintf(&orderBy, "order by o.CLASS, d.DISC, d.TRACK, d.TITLE");
			}
			else
				orderBy = parse_sort_criteria(SortCriteria, &ret);
			if( ret == -1 )
			{
				free(orderBy);
				orderBy = NULL;
				ret = 0;
			}
		}
		// If it's a DLNA client, return an error for bad sort criteria 
		if( ret < 0 && ((args.flags & FLAG_DLNA) || GETFLAG(DLNA_STRICT_MASK)) )
		{
			SoapError(h, 709, "Unsupported or invalid sort criteria");
			goto browse_error;
		}

		sql = sqlite3_mprintf("SELECT %s, %s, %s, " COLUMNS
		                      "from OBJECTS o left join DETAILS d on (d.ID = o.DETAIL_ID)"
				      " where %s %s limit %d, %d;",
				      objectid_sql, parentid_sql, refid_sql,
				      where, THISORNUL(orderBy), StartingIndex, RequestedCount);
		printf("Browse SQL: %s\n", sql);
		ret = sqlite3_exec(db, sql, callback, (void *) &args, &zErrMsg);
	}
	if( (ret != SQLITE_OK) && (zErrMsg != NULL) )
	{
		printf("SQL error: %s\nBAD SQL: %s\n", zErrMsg, sql);
		sqlite3_free(zErrMsg);
		SoapError(h, 709, "Unsupported or invalid sort criteria");
		goto browse_error;
	}
	sqlite3_free(sql);
	// Does the object even exist? 
	if( !totalMatches )
	{
		if( !object_exists(ObjectID) )
		{
			SoapError(h, 701, "No such object error");
			goto browse_error;
		}
	}

	//-------------------------- */
/*
	ret = strcatf(&str, "&lt;/DIDL-Lite&gt;</Result>\n"
	                    "<NumberReturned>%u</NumberReturned>\n"
	                    "<TotalMatches>%u</TotalMatches>\n"
	                    "<UpdateID>%u</UpdateID>"
	                    "</u:BrowseResponse>",
	                    args.returned, totalMatches, updateID);
*/

	str.off = strlen(str.data);
	dlog_print(DLOG_DEBUG, "tdlna", "----- 최종 Borwse 응답\n%s\n---------------------------------", str.data);
	dlog_print(DLOG_ERROR, "tdlna", "1300데이타: %s",  str.data + 1000);

	FILE* dfp;
	dfp = fopen("/opt/usr/media/tdlnaDbg.txt", "w+");
	if(dfp == NULL){
		dlog_print(DLOG_ERROR, "tdlna", "디버그파일 실패");
		goto browse_error;
	}
	fprintf(dfp, "%s", str.data);
	fclose(dfp);

	BuildSendAndCloseSoapResp(h, str.data, str.off);
browse_error:
	ClearNameValueList(&data);
	//free(orderBy);
	free(str.data);
}
/*
inline void
charcat(struct string_s *str, char c)
{
	if (str->size <= str->off)
	{
		str->data[str->size-1] = '\0';
		return;
	}
	str->data[str->off] = c;
	str->off += 1;
}

static inline char *
parse_search_criteria(const char *str, char *sep)
{
	struct string_s criteria;
	int len;
	int literal = 0, like = 0;
	const char *s;

	if (!str)
		return strdup("1 = 1");

	len = strlen(str) + 32;
	criteria.data = malloc(len);
	criteria.size = len;
	criteria.off = 0;

	s = str;

	while (isspace(*s))
		s++;

	while (*s)
	{
		if (literal)
		{
			switch (*s) {
			case '&':
				if (strncmp(s, "&quot;", 6) == 0)
					s += 5;
				else if (strncmp(s, "&apos;", 6) == 0)
				{
					strcatf(&criteria, "'");
					s += 6;
					continue;
				}
				else
					break;
			case '"':
				literal = 0;
				if (like)
				{
					charcat(&criteria, '%');
					like--;
				}
				charcat(&criteria, '"');
				break;
			case '\\':
				if (strncmp(s, "\\&quot;", 7) == 0)
				{
					strcatf(&criteria, "&amp;quot;");
					s += 7;
					continue;
				}
				break;
			case 'o':
				if (strncmp(s, "object.", 7) == 0)
					s += 7;
				else if (strncmp(s, "object\"", 7) == 0 ||
				         strncmp(s, "object&quot;", 12) == 0)
				{
					s += 6;
					continue;
				}
			default:
				charcat(&criteria, *s);
				break;
			}
		}
		else
		{
			switch (*s) {
			case '\\':
				if (strncmp(s, "\\&quot;", 7) == 0)
				{
					strcatf(&criteria, "&amp;quot;");
					s += 7;
					continue;
				}
				else
					charcat(&criteria, *s);
				break;
			case '"':
				literal = 1;
				charcat(&criteria, *s);
				if (like == 2)
				{
					charcat(&criteria, '%');
					like--;
				}
				break;
			case '&':
				if (strncmp(s, "&quot;", 6) == 0)
				{
					literal = 1;
					strcatf(&criteria, "\"");
					if (like == 2)
					{
						charcat(&criteria, '%');
						like--;
					}
					s += 5;
				}
				else if (strncmp(s, "&apos;", 6) == 0)
				{
					strcatf(&criteria, "'");
					s += 5;
				}
				else if (strncmp(s, "&lt;", 4) == 0)
				{
					strcatf(&criteria, "<");
					s += 3;
				}
				else if (strncmp(s, "&gt;", 4) == 0)
				{
					strcatf(&criteria, ">");
					s += 3;
				}
				else
					charcat(&criteria, *s);
				break;
			case '@':
				if (strncmp(s, "@refID", 6) == 0)
				{
					strcatf(&criteria, "REF_ID");
					s += 6;
					continue;
				}
				else if (strncmp(s, "@id", 3) == 0)
				{
					strcatf(&criteria, "OBJECT_ID");
					s += 3;
					continue;
				}
				else if (strncmp(s, "@parentID", 9) == 0)
				{
					strcatf(&criteria, "PARENT_ID");
					s += 9;
					strcpy(sep, "*");
					continue;
				}
				else
					charcat(&criteria, *s);
				break;
			case 'c':
				if (strncmp(s, "contains", 8) == 0)
				{
					strcatf(&criteria, "like");
					s += 8;
					like = 2;
					continue;
				}
				else
					charcat(&criteria, *s);
				break;
			case 'd':
				if (strncmp(s, "derivedfrom", 11) == 0)
				{
					strcatf(&criteria, "like");
					s += 11;
					like = 1;
					continue;
				}
				else if (strncmp(s, "dc:date", 7) == 0)
				{
					strcatf(&criteria, "d.DATE");
					s += 7;
					continue;
				}
				else if (strncmp(s, "dc:title", 8) == 0)
				{
					strcatf(&criteria, "d.TITLE");
					s += 8;
					continue;
				}
				else if (strncmp(s, "dc:creator", 10) == 0)
				{
					strcatf(&criteria, "d.CREATOR");
					s += 10;
					continue;
				}
				else
					charcat(&criteria, *s);
				break;
			case 'e':
				if (strncmp(s, "exists", 6) == 0)
				{
					s += 6;
					while (isspace(*s))
						s++;
					if (strncmp(s, "true", 4) == 0)
					{
						strcatf(&criteria, "is not NULL");
						s += 3;
					}
					else if (strncmp(s, "false", 5) == 0)
					{
						strcatf(&criteria, "is NULL");
						s += 4;
					}
				}
				else
					charcat(&criteria, *s);
				break;
			case 'u':
				if (strncmp(s, "upnp:class", 10) == 0)
				{
					strcatf(&criteria, "o.CLASS");
					s += 10;
					continue;
				}
				else if (strncmp(s, "upnp:actor", 10) == 0)
				{
					strcatf(&criteria, "d.ARTIST");
					s += 10;
					continue;
				}
				else if (strncmp(s, "upnp:artist", 11) == 0)
				{
					strcatf(&criteria, "d.ARTIST");
					s += 11;
					continue;
				}
				else if (strncmp(s, "upnp:album", 10) == 0)
				{
					strcatf(&criteria, "d.ALBUM");
					s += 10;
					continue;
				}
				else if (strncmp(s, "upnp:genre", 10) == 0)
				{
					strcatf(&criteria, "d.GENRE");
					s += 10;
					continue;
				}
				else
					charcat(&criteria, *s);
				break;
			case '(':
				if (s > str && !isspace(s[-1]))
					charcat(&criteria, ' ');
				charcat(&criteria, *s);
				break;
			case ')':
				charcat(&criteria, *s);
				if (!isspace(s[1]))
					charcat(&criteria, ' ');
				break;
			default:
				charcat(&criteria, *s);
				break;
			}
		}
		s++;
	}
	charcat(&criteria, '\0');

	return criteria.data;
}

static void
SearchContentDirectory(struct upnphttp * h, const char * action)
{
	static const char resp0[] =
			"<u:SearchResponse "
			"xmlns:u=\"urn:schemas-upnp-org:service:ContentDirectory:1\">"
			"<Result>"
			"&lt;DIDL-Lite"
			CONTENT_DIRECTORY_SCHEMAS;

//	struct magic_container_s *magic;
	char *zErrMsg = NULL;
	char *sql, *ptr;
	struct Response args;
	struct string_s str;
	int totalMatches;
	int ret;
	const char *ContainerID;
	char *Filter, *SearchCriteria, *SortCriteria;
	char *orderBy = NULL, *where = NULL, sep[] = "$*";
	char groupBy[] = "group by DETAIL_ID";
//	struct NameValueParserData data;
	int RequestedCount = 0;
	int StartingIndex = 0;

	memset(&args, 0, sizeof(args));
	memset(&str, 0, sizeof(str));
/*
	ParseNameValue(h->req_buf + h->req_contentoff, h->req_contentlen, &data, 0);

	ContainerID = GetValueFromNameValueList(&data, "ContainerID");
	Filter = GetValueFromNameValueList(&data, "Filter");
	SearchCriteria = GetValueFromNameValueList(&data, "SearchCriteria");
	SortCriteria = GetValueFromNameValueList(&data, "SortCriteria");

	if( (ptr = GetValueFromNameValueList(&data, "RequestedCount")) )
		RequestedCount = atoi(ptr);
	if( !RequestedCount )
		RequestedCount = -1;
	if( (ptr = GetValueFromNameValueList(&data, "StartingIndex")) )
		StartingIndex = atoi(ptr);
	if( !ContainerID )
	{
		if( !(ContainerID = GetValueFromNameValueList(&data, "ObjectID")) )
		{
			SoapError(h, 402, "Invalid Args");
			goto search_error;
		}
	}

	str.data = malloc(DEFAULT_RESP_SIZE);
	str.size = DEFAULT_RESP_SIZE;
	str.off = sprintf(str.data, "%s", resp0);
	// See if we need to include DLNA namespace reference 
	args.iface = h->iface;
	args.filter = set_filter_flags(Filter, h);
	if( args.filter & FILTER_DLNA_NAMESPACE )
	{
		ret = strcatf(&str, DLNA_NAMESPACE);
	}  strcatf(&str, DLNA_NAMESPACE);
	strcatf(&str, "&gt;\n");
//------------------------------------
/*
	args.returned = 0;
	args.requested = RequestedCount;
	args.client = h->req_client ? h->req_client->type->type : 0;
	args.flags = h->req_client ? h->req_client->type->flags : 0;
	args.str = &str;
	printf("Searching ContentDirectory:\n"
	                         " * ObjectID: %s\n"
	                         " * Count: %d\n"
	                         " * StartingIndex: %d\n"
	                         " * SearchCriteria: %s\n"
	                         " * Filter: %s\n"
	                         " * SortCriteria: %s\n",
				ContainerID, RequestedCount, StartingIndex,
	                        SearchCriteria, Filter, SortCriteria);

	magic = check_magic_container(ContainerID, args.flags);
	if (magic && magic->objectid && *(magic->objectid))
		ContainerID = *(magic->objectid);

	if( strcmp(ContainerID, "0") == 0 )
		ContainerID = "*";

	if( strcmp(ContainerID, MUSIC_ALL_ID) == 0 ||
	    GETFLAG(DLNA_STRICT_MASK) )
		groupBy[0] = '\0';

	where = parse_search_criteria(SearchCriteria, sep);
	printf("Translated SearchCriteria: %s\n", where);

	totalMatches = sql_get_int_field(db, "SELECT (select count(distinct DETAIL_ID)"
	                                     " from OBJECTS o left join DETAILS d on (o.DETAIL_ID = d.ID)"
	                                     " where (OBJECT_ID glob '%q%s') and (%s))"
	                                     " + "
	                                     "(select count(*) from OBJECTS o left join DETAILS d on (o.DETAIL_ID = d.ID)"
	                                     " where (OBJECT_ID = '%q') and (%s))",
	                                     ContainerID, sep, where, ContainerID, where);
	if( totalMatches < 0 )
	{
		// Must be invalid SQL, so most likely bad or unhandled search criteria. 
		SoapError(h, 708, "Unsupported or invalid search criteria");
		goto search_error;
	}
	// Does the object even exist? 
	if( !totalMatches )
	{
		if( !object_exists(ContainerID) )
		{
			SoapError(h, 710, "No such container");
			goto search_error;
		}
	}
	ret = 0;
	__SORT_LIMIT
	orderBy = parse_sort_criteria(SortCriteria, &ret);
	// If it's a DLNA client, return an error for bad sort criteria 
	if( ret < 0 && ((args.flags & FLAG_DLNA) || GETFLAG(DLNA_STRICT_MASK)) )
	{
		SoapError(h, 709, "Unsupported or invalid sort criteria");
		goto search_error;
	}

	sql = sqlite3_mprintf( SELECT_COLUMNS
	                      "from OBJECTS o left join DETAILS d on (d.ID = o.DETAIL_ID)"
	                      " where OBJECT_ID glob '%q%s' and (%s) %s "
	                      "%z %s"
	                      " limit %d, %d",
	                      ContainerID, sep, where, groupBy,
	                      (*ContainerID == '*') ? NULL :
	                      sqlite3_mprintf("UNION ALL " SELECT_COLUMNS
	                                      "from OBJECTS o left join DETAILS d on (d.ID = o.DETAIL_ID)"
	                                      " where OBJECT_ID = '%q' and (%s) ", ContainerID, where),
	                      orderBy, StartingIndex, RequestedCount);
	printf( "Search SQL: %s\n", sql);
	ret = sqlite3_exec(db, sql, callback, (void *) &args, &zErrMsg);
	if( (ret != SQLITE_OK) && (zErrMsg != NULL) )
	{
		printf( "SQL error: %s\nBAD SQL: %s\n", zErrMsg, sql);
		sqlite3_free(zErrMsg);
	}
	sqlite3_free(sql);

//------------------------------------

	strcatf(&str, "&lt;item id=\"64$6$0\" parentID=\"64$6\" restricted=\"1\"&gt;&lt;dc:title&gt;720p&lt;/dc:title&gt;&lt;upnp:class&gt;object.item.videoItem&lt;/upnp:class&gt;&lt;dc:date&gt;2015-06-19T18:16:02&lt;/dc:date&gt;&lt;res size=\"175812287\" duration=\"0:08:52.608\" bitrate=\"330096\" sampleFrequency=\"48000\" nrAudioChannels=\"2\" resolution=\"1280x720\" protocolInfo=\"http-get:*:video/mp4:DLNA.ORG_PN=AVC_MP4_HP_HD_AAC;DLNA.ORG_OP=01;DLNA.ORG_CI=0\"&gt;http://192.168.137.2:9090/720p.mp4&lt;/res&gt;&lt;/item&gt;\n");


	ret = strcatf(&str, "&lt;/DIDL-Lite&gt;</Result>\n"
	                    "<NumberReturned>%u</NumberReturned>\n"
	                    "<TotalMatches>%u</TotalMatches>\n"
	                    "<UpdateID>%u</UpdateID>"
	                    "</u:SearchResponse>",
	                    args.returned, totalMatches, updateID);
	BuildSendAndCloseSoapResp(h, str.data, str.off);
search_error:
//	ClearNameValueList(&data);
	free(orderBy);
	free(where);
	free(str.data);
}
*/
/*
If a control point calls QueryStateVariable on a state variable that is not
buffered in memory within (or otherwise available from) the service,
the service must return a SOAP fault with an errorCode of 404 Invalid Var.

QueryStateVariable remains useful as a limited test tool but may not be
part of some future versions of UPnP.
*/ /*
static void
QueryStateVariable(struct upnphttp * h, const char * action)
{
	static const char resp[] =
        "<u:%sResponse "
        "xmlns:u=\"%s\">"
		"<return>%s</return>"
        "</u:%sResponse>";

	char body[512];
	struct NameValueParserData data;
	const char * var_name;

	ParseNameValue(h->req_buf + h->req_contentoff, h->req_contentlen, &data, 0);
	///*var_name = GetValueFromNameValueList(&data, "QueryStateVariable");
	///*var_name = GetValueFromNameValueListIgnoreNS(&data, "varName")
	var_name = GetValueFromNameValueList(&data, "varName");

	printf("QueryStateVariable(%.40s)\n", var_name);

	if(!var_name)
	{
		SoapError(h, 402, "Invalid Args");
	}
	else if(strcmp(var_name, "ConnectionStatus") == 0)
	{	
		int bodylen;
		bodylen = snprintf(body, sizeof(body), resp,
                           action, "urn:schemas-upnp-org:control-1-0",
		                   "Connected", action);
		BuildSendAndCloseSoapResp(h, body, bodylen);
	}
	else
	{
		printf("%s: Unknown: %s\n", action, THISORNUL(var_name));
		SoapError(h, 404, "Invalid Var");
	}

	ClearNameValueList(&data);	
}
*/
static void
SamsungGetFeatureList(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:X_GetFeatureListResponse xmlns:u=\"urn:schemas-upnp-org:service:ContentDirectory:1\">"
		"<FeatureList>"
		"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n"
		"&lt;Features xmlns=\"urn:schemas-upnp-org:av:avs\""
		" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""
		" xsi:schemaLocation=\"urn:schemas-upnp-org:av:avs http://www.upnp.org/schemas/av/avs.xsd\"&gt;"
		"&lt;Feature name=\"samsung.com_BASICVIEW\" version=\"1\"&gt;"
		 "&lt;container id=\"1\" type=\"object.item.audioItem\"/&gt;" //Audio 1
		 "&lt;container id=\"2\" type=\"object.item.videoItem\"/&gt;" //Video 2
		 "&lt;container id=\"3\" type=\"object.item.imageItem\"/&gt;" //Image 3
		"&lt;/Feature&gt;"
		"&lt;/Features&gt;"
		"</FeatureList></u:X_GetFeatureListResponse>";

	if (runtime_vars.root_container)
		return SoapError(h, 401, "Invalid Action");

	BuildSendAndCloseSoapResp(h, resp, sizeof(resp)-1);
}
/*
static void
SamsungSetBookmark(struct upnphttp * h, const char * action)
{
	static const char resp[] =
	    "<u:X_SetBookmarkResponse"
	    " xmlns:u=\"urn:schemas-upnp-org:service:ContentDirectory:1\">"
	    "</u:X_SetBookmarkResponse>";

	struct NameValueParserData data;
	char *ObjectID, *PosSecond;

	ParseNameValue(h->req_buf + h->req_contentoff, h->req_contentlen, &data, 0);
	ObjectID = GetValueFromNameValueList(&data, "ObjectID");
	PosSecond = GetValueFromNameValueList(&data, "PosSecond");
	if( ObjectID && PosSecond )
	{
		int ret;
		ret = sql_exec(db, "INSERT OR REPLACE into BOOKMARKS"
		                   " VALUES "
		                   "((select DETAIL_ID from OBJECTS where OBJECT_ID = '%q'), %q)", ObjectID, PosSecond);
		if( ret != SQLITE_OK )
			printf("Error setting bookmark %s on ObjectID='%s'\n", PosSecond, ObjectID);
		BuildSendAndCloseSoapResp(h, resp, sizeof(resp)-1);
	}
	else
		SoapError(h, 402, "Invalid Args");

	ClearNameValueList(&data);	
}
*/
static const struct 
{
	const char * methodName; 
	void (*methodImpl)(struct upnphttp *, const char *);
}

//Soap 메소드들의 처리를 담당하는 함수포인터
soapMethods[] =
{
	{ "IsAuthorized", IsAuthorizedValidated},
	{ "IsValidated", IsAuthorizedValidated},
	{ "RegisterDevice", RegisterDevice},
	{ "Browse", BrowseContentDirectory},
	//{ "GetProtocolInfo", GetProtocolInfo}, // 현재 프로그램이 멈추는 문제가 있음
	//{ "QueryStateVariable", QueryStateVariable},
	//{ "Search", SearchContentDirectory},
	//{ "GetSearchCapabilities", GetSearchCapabilities},
	{ "GetSortCapabilities", GetSortCapabilities},
	{ "GetSystemUpdateID", GetSystemUpdateID},
	{ "GetCurrentConnectionIDs", GetCurrentConnectionIDs},
	//{ "GetCurrentConnectionInfo", GetCurrentConnectionInfo},
	{ "X_GetFeatureList", SamsungGetFeatureList},
	//{ "X_SetBookmark", SamsungSetBookmark},
	{ 0, 0 }
};

//함수 포인터에 의해 각 soap명령에 해당하는 함수를 수행한다.
void
ExecuteSoapAction(struct upnphttp * h, const char * action, int n)
{
	char * p;

	p = strchr(action, '#'); //Soap 액션은 #뒤에 붙어있으므로 #을기준으로 파싱
	if(p)
	{
		int i = 0;
		int len;
		int methodlen;
		char * p2;
		p++;
		p2 = strchr(p, '"');
		if(p2)
			methodlen = p2 - p;
		else
			methodlen = n - (p - action);
		dlog_print(DLOG_DEBUG,"tdlna", "SoapMethod: %.*s\n", methodlen, p);
		while(soapMethods[i].methodName)
		{
			len = strlen(soapMethods[i].methodName);
			if(strncmp(p, soapMethods[i].methodName, len) == 0)
			{
				
				soapMethods[i].methodImpl(h, soapMethods[i].methodName);
				return;
			}
			i++;
		}

		dlog_print(DLOG_ERROR,"tdlna", "soap [%.*s] 메소드 처리하지 못함\n", methodlen, p);
	}

	SoapError(h, 401, "Invalid Action");
}

/* Standard Errors:
 *
 * errorCode errorDescription Description
 * --------	---------------- -----------
 * 401 		Invalid Action 	No action by that name at this service.
 * 402 		Invalid Args 	Could be any of the following: not enough in args,
 * 							too many in args, no in arg by that name, 
 * 							one or more in args are of the wrong data type.
 * 403 		Out of Sync 	Out of synchronization.
 * 501 		Action Failed 	May be returned in current state of service
 * 							prevents invoking that action.
 * 600-699 	TBD 			Common action errors. Defined by UPnP Forum
 * 							Technical Committee.
 * 700-799 	TBD 			Action-specific errors for standard actions.
 * 							Defined by UPnP Forum working committee.
 * 800-899 	TBD 			Action-specific errors for non-standard actions. 
 * 							Defined by UPnP vendor.
*/
void
SoapError(struct upnphttp * h, int errCode, const char * errDesc)
{
	static const char resp[] = 
		"<s:Envelope "
		"xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" "
		"s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">"
		"<s:Body>"
		"<s:Fault>"
		"<faultcode>s:Client</faultcode>"
		"<faultstring>UPnPError</faultstring>"
		"<detail>"
		"<UPnPError xmlns=\"urn:schemas-upnp-org:control-1-0\">"
		"<errorCode>%d</errorCode>"
		"<errorDescription>%s</errorDescription>"
		"</UPnPError>"
		"</detail>"
		"</s:Fault>"
		"</s:Body>"
		"</s:Envelope>";

	char body[2048];
	int bodylen;

	printf("Returning UPnPError %d: %s\n", errCode, errDesc);
	bodylen = snprintf(body, sizeof(body), resp, errCode, errDesc);
	BuildResp2_upnphttp(h, 500, "Internal Server Error", body, bodylen);
	SendResp_upnphttp(h);
	CloseSocket_upnphttp(h);
}

