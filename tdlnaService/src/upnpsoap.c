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
#include "metadata.h"
#include "main-app.h"

static app_data *ServiceAppData;

void SetAppDataSoap(void* data){
	//ServiceAppData = (app_data*)data;
	return;
}

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

///* Find the first occurrence of p in s, where s is terminated by t */
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

//URL 문자열 인코딩
char* mUrlEncode(char *str, char *encstr){
	//char encstr[128],
	char buf[2+1];
	int i, j;
	unsigned char c;
	if(str == NULL) return NULL;
	//if((encstr = (char *)malloc((strlen(str) * 3) + 1)) == NULL) return NULL;

	for(i = j = 0; str[i]; i++){

		c = (unsigned char)str[i];
		if (c == ' ') encstr[j++] = '+';
		else if (c == '/') encstr[j++] = '/';
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

	//dlog_print(DLOG_DEBUG, "tdlna_soap", "★SOAP RESPONSE: %s", h->res_buf);
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
	dlog_print(DLOG_ERROR, "tdlna_soap", "GetProtocolInfo!!!");
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

	bodylen = strlen(resp) + strlen(action) + 100;
	body = malloc(bodylen);
	body[bodylen-1] = '\0';

	bodylen = sprintf(body, resp, action, "urn:schemas-upnp-org:service:ConnectionManager:1", action);
	BuildSendAndCloseSoapResp(h, body, bodylen);

	dlog_print(DLOG_DEBUG,"tdlna_soap", "겟프로토콜 %s", body);
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

static void
GetSearchCapabilities(struct upnphttp * h, const char * action)
{
	static const char resp[] =
		"<u:%sResponse xmlns:u=\"%s\">"
		"<SearchCaps>"
		"</SearchCaps>"
		"</u:%sResponse>";

	char body[512];
	int bodylen;

	bodylen = snprintf(body, sizeof(body), resp,
		action, "urn:schemas-upnp-org:service:ContentDirectory:1",
		action);	
	BuildSendAndCloseSoapResp(h, body, bodylen);
}

static void
GetCurrentConnectionIDs(struct upnphttp * h, const char * action)
{
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

static void
GetCurrentConnectionInfo(struct upnphttp * h, const char * action)
{
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
	dlog_print(DLOG_DEBUG, "tdlna_soap", "GetCurrentConnectionInfo(%s)\n", id_str);
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

////파일 확장명 비교
//static int FileExtCmp (char *filename, char *ext)
//{
//
//	int i, ext_len, filename_len, cnt=0;
//
//	ext_len = strlen(ext); //확장자 길이
//	filename_len = strlen(filename); //주어진 파일명 길이
//
//	//확장명이 파일명보다 길 경우 리턴
//	if(ext_len > filename_len)
//		return 0;
//
//	//파일명 끝에서 부터 확장명과 비교
//	for(i = ext_len-1; i > 0; i--){
//		if(ext[i] == filename[--filename_len])
//		cnt++;
//	}
//
//	if(cnt == ext_len-1)
//		return 1;
//	else
//		return 0;
//}

//xml 특수문자 처리
void ProcessSpecialCharacter(char* str1){
	int i=0, j=0, size;
	char* str2;

	size = strlen(str1);
	if(size < 1) return;
	size *= 10;

	str2 = (char*) malloc(size);
	memset(str2, '\0', size);

	while(str1[i] != '\0'){

		// XML에 허용되지 않는 문자열 예외처리
		if(str1[i] == '&'){
			strcat(&str2[i], "&amp;amp;");
			j += 9;
			i++;
		}
		else if(str1[i] == '<'){
			strcat(&str2[i], "&amp;lt;");
			j += 8;
			i++;
		}
		else if(str1[i] == '>'){
			strcat(&str2[i], "&amp;gt;");
			j += 8;
			i++;
		}
		else if(str1[i] == '\"'){
			strcat(&str2[i], "&amp;quot;");
			j += 10;
			i++;
		}
		str2[j++] = str1[i++];
	}
	str2[j] = '\0';
	strcpy(str1, str2);
	free(str2);
}

char *ReplaceAll(char *s, const char *olds, const char *news) {
	char *result, *sr;
	size_t i, count = 0;
	size_t oldlen = strlen(olds); if (oldlen < 1) return s;
	size_t newlen = strlen(news);

	if (newlen != oldlen) {
		for (i = 0; s[i] != '\0';) {
			if (memcmp(&s[i], olds, oldlen) == 0) count++, i += oldlen;
			else i++;
		}
	} else i = strlen(s);

	result = (char *) malloc(i + 1 + count * (newlen - oldlen));
	if (result == NULL) return NULL;

	sr = result;
	while (*s) {
		if (memcmp(s, olds, oldlen) == 0) {
			memcpy(sr, news, newlen);
			sr += newlen;
			s  += oldlen;
		} else *sr++ = *s++;
	}
	*sr = '\0';

	return result;
}
void DecodeSpecialCharacter(char* str1){
	int size;
	char* str2;

	size = strlen(str1);
	if(size < 1) return;

	str2 = ReplaceAll(str1, "&amp;", "&");
	strcpy(str1, str2);
	free(str2);
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

	char* ptr;
	char timeStr[32];
	char temp[8192];

	struct Response args;
	struct string_s str;
	int i, ret, hur, min, sec, msec;
//	int audioCnt=0, videoCnt=0, imageCnt=0;
	int totalMatches = 0;
	const char *ObjectID, *BrowseFlag;
	char *Filter, *SortCriteria;

	struct NameValueParserData data;
	int RequestedCount = 0;
	int StartingIndex = 0;
	int itemCount = 0;

	char encodedFileName[512];


	dlog_print(DLOG_INFO,"tdlna_soap", "★★★  Browse 액션 처리중 ★★★");

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
		//dlog_print(DLOG_DEBUG, "tdlna_soap", "삼성!!기기 연결! PV NameSpase 찍음");
		ret = strcatf(&str, PV_NAMESPACE);
	}

	args.returned = 0;
	args.requested = RequestedCount;
	args.client = h->req_client ? h->req_client->type->type : 0;
	args.flags = h->req_client ? h->req_client->type->flags : 0;
	args.str = &str;

	dlog_print(DLOG_WARN,"tdlna_soap", " ObjectID: %s", ObjectID);
	dlog_print(DLOG_WARN,"tdlna_soap", " RequestedCount: %d", RequestedCount);
	dlog_print(DLOG_WARN,"tdlna_soap", " StartingIndex: %d", StartingIndex);
	dlog_print(DLOG_WARN,"tdlna_soap", " BrowseFlag: %s", BrowseFlag);
	dlog_print(DLOG_WARN,"tdlna_soap", " Filter: %s", Filter);
	//dlog_print(DLOG_INFO,"tdlna_soap", " SortCriteria: %s", SortCriteria);

	//=========================================== Browse Xml 빌드 ==================================
	strcat(str.data, "&gt;");


	//---- Audio Video Image 각각의 메인 폴더 보여주기 ------------
	if(!strcmp(ObjectID, "1") || !strcmp(ObjectID, "2") || !strcmp(ObjectID, "3")){
		//비디오의 폴더목록
		char* BrowseRoot;
		char split = '\n';
		itemCount = 2;

		if(args.client == EWindowsMediaPlayer){
			split = '\0';
			itemCount = 1;
			dlog_print(DLOG_ERROR, "tdlna", "미디어 플레이어 예외처리");
		}

		BrowseRoot = malloc(2048);
		if(ObjectID[0] == '1') //Audio
			sprintf(BrowseRoot, BROWSE_ROOT_ITEM,
					"1$4", ObjectID[0], "모든 음악", split,
					"1$14", ObjectID[0], "폴더별 음악");
		else if(ObjectID[0] == '2') //Video
			sprintf(BrowseRoot, BROWSE_ROOT_ITEM,
					"2$8", ObjectID[0], "모든 동영상", split,
					"2$15", ObjectID[0], "폴더별 동영상");
		else if(ObjectID[0] == '3') //Image
			sprintf(BrowseRoot, BROWSE_ROOT_ITEM,
					"3$B", ObjectID[0], "모든 사진", split,
					"3$16", ObjectID[0], "폴더별 사진");
		else
			goto browse_error;

		str.off = sprintf(str.data, "%s&gt;%s", resp0, BrowseRoot);
		free(BrowseRoot);
	}
	//폴더별 보기 처리
	else if(!strcmp(ObjectID, "1$14") || !strcmp(ObjectID, "2$15") || !strcmp(ObjectID, "3$16"))
	{
		char* folderList;
		char* fName = NULL;
		int fNameLen = 0;
		int folderCnt = 0;
		int mediaType = 0;
		char* tok;

		mediaType = ObjectID[0] - '0';
//		dlog_print(DLOG_WARN,"tdlna_soap", " 미디어타입: %d", mediaType);
		folderCnt = mediaDirectory_folder(&folderList, mediaType);
		ProcessSpecialCharacter(folderList);

		tok = strtok(folderList, "|");

		for(i=0; i<folderCnt; i++){
			if(tok == NULL) break;

			fNameLen = strlen(tok);
			while(fNameLen--){
				if(tok[fNameLen] == '/'){
					fName = &tok[fNameLen+1]; //폴더 끝자리 자르기(최하위폴더명 가져오기)
					break;
				}
			}

			sprintf(temp, BROWSE_FOLDER_ITEM, ObjectID, tok, ObjectID, fName);
			strcat(str.data, temp);

			tok = strtok(NULL, "|");
		}
		itemCount = i;
		free(folderList);
	}
	//★★★  비디오 아이템
	else if(strncmp(ObjectID, "2$", 2) == 0){

		_META* items;

		if(!strncmp(ObjectID, "2$15$", 5))
		{ //폴더별 보기시
			char fullPathQury[512];
			sprintf(fullPathQury, "%s%%", ObjectID+5);
			DecodeSpecialCharacter(fullPathQury); //&같은 특수문자 폴더의 경우 변환되어있으므로 원래대로 치환후 쿼리
			itemCount = Meta_Get_from_path(ServiceAppData, fullPathQury, 2, &items);
		}
		else //모든 비디오 (2$8)
			itemCount = Meta_Get_from_path(ServiceAppData, "/%", 2, &items); //모든 폴더의 비디오를 구해온다.

		for(i=0; i<itemCount; i++){

			//--- temp문자열에 각 파일의 xml요소 제작 -----
			mUrlEncode(items[i].path, encodedFileName);
			ProcessSpecialCharacter(items[i].title);

			//[duration] 시간 형식 /*재생시간 0:08:52.608*/
			msec = items[i].duration % 1000;
			sec = items[i].duration / 1000;
			min = (sec % 3600) / 60;
			hur = sec / 3600;
			sec= sec % 60;
			sprintf(timeStr, "%d:%02d:%02d.%03d", hur,min,sec,msec);

			sprintf(temp, BROWSE_VIDEO_ITEM,
					ObjectID, i ,ObjectID, items[i].title, items[i].artist,
					items[i].date[0], items[i].date[1], items[i].date[2], items[i].date[3], items[i].date[4], items[i].date[5], /*년월일시분초*/
					items[i].file_size, /*파일크기*/
					timeStr, /*재생시간 0:08:52.608*/
					items[i].bitrate,   /*비트레이트*/
					items[i].samplerate,/*샘플레이트*/
					items[i].channels,  /*오디어 채널수*/
					items[i].width, items[i].height,  /*해상도 가로세로*/
					lan_addr[0].str, runtime_vars.port, encodedFileName, /*동영상주소*/
					lan_addr[0].str, runtime_vars.port, items[i].thumbnail_path, /*썸네일주소*/
					lan_addr[0].str, runtime_vars.port, items[i].thumbnail_path); /*썸네일주소*/

			strcat(str.data, temp); //각 파일에 대한 xml코드 이어붙임

		}//for

		free(items);
	}
	//★★★ Audio
	else if(strncmp(ObjectID, "1$", 2) == 0){

		_META* items;

		if(!strncmp(ObjectID, "1$14$", 5))
		{ //폴더별 보기시
			char fullPathQury[512];
			sprintf(fullPathQury, "%s%%", ObjectID+5);
			DecodeSpecialCharacter(fullPathQury);
			itemCount = Meta_Get_from_path(ServiceAppData, fullPathQury, 1, &items);
		}
		else //모든 음악 (1$4)
			itemCount = Meta_Get_from_path(ServiceAppData, "/%", 1, &items);

		for(i=0; i<itemCount; i++){

			//--- temp문자열에 각 파일의 xml요소 제작 -----
			mUrlEncode(items[i].path, encodedFileName);
			ProcessSpecialCharacter(items[i].title);
			ProcessSpecialCharacter(items[i].artist);
			ProcessSpecialCharacter(items[i].genre);
			ProcessSpecialCharacter(items[i].album_name);

			//[duration] 시간 형식 /*재생시간 0:08:52.608*/
			msec = items[i].duration % 1000;
			sec = items[i].duration / 1000;
			min = (sec % 3600) / 60;
			hur = sec / 3600;
			sec= sec % 60;
			sprintf(timeStr, "%d:%02d:%02d.%03d", hur,min,sec,msec);

			sprintf(temp, BROWSE_AUDIO_ITEM,
					ObjectID, i, ObjectID, items[i].title,items[i].artist, /*아티스트*/
					items[i].date[0], items[i].date[1], items[i].date[2], items[i].date[3], items[i].date[4], items[i].date[5], /*년월일시분초*/
					items[i].genre, /*장르*/
					items[i].album_name, /*앨범명*/
					items[i].file_size, /*파일크기*/
					timeStr, /*재생시간 0:08:52.608*/
					items[i].bitrate,   /*오디오 비트레이트*/
					lan_addr[0].str, runtime_vars.port, encodedFileName, /*미디어주소*/
					lan_addr[0].str, runtime_vars.port, items[i].thumbnail_path,  /*썸네일주소*/
					lan_addr[0].str, runtime_vars.port, items[i].thumbnail_path); /*썸네일주소*/

			strcat(str.data, temp); //각 파일에 대한 xml코드 이어붙임

			//dlog_print(DLOG_ERROR, "tdlna_soap", "오디오 xml제작중...[%d] %s",i, items[i].title);
		}//for

		free(items);
	}
	//★★★ Image
	else if(strncmp(ObjectID, "3$", 2) == 0){

		_META* items;

		if(!strncmp(ObjectID, "3$16$", 5))
		{ //폴더별 보기시
			char fullPathQury[512];
			sprintf(fullPathQury, "%s%%", ObjectID+5);
			DecodeSpecialCharacter(fullPathQury);
			itemCount = Meta_Get_from_path(ServiceAppData, fullPathQury, 3, &items);
		}
		else //모든 사진 (3$B)
			itemCount = Meta_Get_from_path(ServiceAppData, "/%", 3, &items);

		for(i=0; i<itemCount; i++){

			mUrlEncode(items[i].path, encodedFileName);
			ProcessSpecialCharacter(items[i].title);

			sprintf(temp, BROWSE_IMAGE_ITEM,
					ObjectID, i, ObjectID, items[i].title,
					items[i].date[0], items[i].date[1], items[i].date[2], items[i].date[3], items[i].date[4], items[i].date[5], /*년월일시분초*/
					items[i].file_size, /*파일크기*/
					items[i].width, items[i].height,  /*해상도 가로세로*/
					lan_addr[0].str, runtime_vars.port, encodedFileName, /*동영상주소*/
					lan_addr[0].str, runtime_vars.port, items[i].thumbnail_path, /*썸네일주소*/
					lan_addr[0].str, runtime_vars.port, items[i].thumbnail_path); /*썸네일주소*/

			strcat(str.data, temp); //각 파일에 대한 xml코드 이어붙임
		}//for

		free(items);
	}
	else
	{
		//Root 목록 (동영상/음악/사진)

		char* BrowseRoot;
		BrowseRoot = malloc(1024);

		//media_Count(&videoCnt, &imageCnt, &audioCnt, "/%");
		sprintf(BrowseRoot, BROWSE_ROOT_DIR, 2, 2, 2); //동영상,음악,사진의 자식 아이템 갯수

		str.off = sprintf(str.data, "%s&gt;\n%s", resp0, BrowseRoot);

		dlog_print(DLOG_DEBUG, "tdlna_soap", "Borwse Root List");

		free(BrowseRoot);
		//image audio video 3가지 항목
		args.returned = 3;
		totalMatches = 3;
		itemCount = 3;
	}


	sprintf(temp, "&lt;/DIDL-Lite&gt;</Result>\n"
			"<NumberReturned>%u</NumberReturned>\n"
			"<TotalMatches>%u</TotalMatches>\n"
			"<UpdateID>%u</UpdateID>"
			"</u:BrowseResponse>", itemCount, itemCount, updateID);

	strcat(str.data, temp); //각 파일에 대한 xml코드 이어붙임

//			//파일디버깅!!!
//			FILE* dfp;
//			dfp = fopen("/opt/usr/media/tdlnaDbg.txt", "w+");
//			if(dfp == NULL){
//				dlog_print(DLOG_ERROR, "tdlna_soap", "디버그파일 실패");
//				goto browse_error;
//			}
//			fprintf(dfp, "%s", str.data);
//			fclose(dfp);

	str.off = strlen(str.data);
//	dlog_print(DLOG_DEBUG, "tdlna_soap", "----- 최종 Borwse 응답\n%s\n---------------------------------", str.data);

	BuildSendAndCloseSoapResp(h, str.data, str.off);
browse_error:
	ClearNameValueList(&data);
	free(str.data);
}

static void
SearchContentDirectory(struct upnphttp * h, const char * action)
{
	SoapError(h, 800, "Internal error");
}

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
	{ "Search", SearchContentDirectory},
	{ "GetSearchCapabilities", GetSearchCapabilities},
	{ "GetSortCapabilities", GetSortCapabilities},
	{ "GetSystemUpdateID", GetSystemUpdateID},
	{ "GetCurrentConnectionIDs", GetCurrentConnectionIDs},
	{ "GetCurrentConnectionInfo", GetCurrentConnectionInfo},
	{ "X_GetFeatureList", SamsungGetFeatureList},
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
		dlog_print(DLOG_DEBUG,"tdlna_soap", "SoapMethod: %.*s\n", methodlen, p);
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

		dlog_print(DLOG_ERROR,"tdlna_soap", "soap [%.*s] 메소드 처리하지 못함\n", methodlen, p);
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

