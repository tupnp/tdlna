/*
 *  UPnP DMS 서비스에 필요한 전역 값들
 */

#include <sys/types.h>
#include <netinet/in.h>
#include <sys/param.h>
#include <limits.h>
#include "upnpglobalvars.h"

//time_t startup_time = 0; //interval 관련 초기값

struct runtime_vars_s runtime_vars;
uint32_t runtime_flags = INOTIFY_MASK;

char uuidvalue[] = "uuid:12345678-0000-0000-0000-00000000abcd";
char modelname[MODELNAME_MAX_LEN] = "Samsung Z1";
char modelnumber[MODELNUMBER_MAX_LEN] = MINIDLNA_VERSION;
char serialnumber[SERIALNUMBER_MAX_LEN] = "12345678";
#if PNPX
char pnpx_hwid[] = "VEN_0000&amp;DEV_0000&amp;REV_01 VEN_0033&amp;DEV_0001&amp;REV_01";
#endif

/* presentation url : (xml)
 * http://nnn.nnn.nnn.nnn:ppppp/ */
char presentationurl[PRESENTATIONURL_MAX_LEN];

int n_lan_addr = 0;
struct lan_addr_s lan_addr[MAX_LAN_ADDR];
int sssdp = -1;

//-- UPnP-A/V [DLNA] --/
//sqlite3 *db;
char friendly_name[FRIENDLYNAME_MAX_LEN];
char db_path[PATH_MAX] = {'\0'};
char log_path[PATH_MAX] = {'\0'};
struct media_dir_s * media_dirs = NULL;
struct album_art_name_s * album_art_names = NULL;
short int scanning = 0;
volatile short int quitting = 0;
volatile uint32_t updateID = 0;
const char *force_sort_criteria = NULL;
