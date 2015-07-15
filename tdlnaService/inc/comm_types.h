#ifndef __MINIDLNATYPES_H__
#define __MINIDLNATYPES_H__

//#include "clients.h"
#include <time.h>
#include <fcntl.h>

#define MAX_LAN_ADDR 4
/* structure for storing lan addresses
 * with ascii representation and mask */
struct lan_addr_s {
	char str[16];	/* example: 192.168.0.1 */
	struct in_addr addr;	/* ip */
	struct in_addr mask;	/* netmask */
	int snotify;	/* notify socket */
	unsigned int ifindex;	/* interface index */
};

struct runtime_vars_s {
	int port;	/* HTTP Port */
	int notify_interval;	/* seconds between SSDP announces */
	int max_connections;	/* max number of simultaneous conenctions */
	const char *root_container;	/* root ObjectID (instead of "0") */
	const char *ifaces[MAX_LAN_ADDR];	/* list of configured network interfaces */
};

struct string_s {
	char *data; // ptr to start of memory area
	size_t off;
	size_t size;
};

typedef uint8_t media_types;
#define NO_MEDIA     0x00
#define TYPE_AUDIO   0x01
#define TYPE_VIDEO   0x02
#define TYPE_IMAGES  0x04
#define ALL_MEDIA    TYPE_AUDIO|TYPE_VIDEO|TYPE_IMAGES

enum file_types {
	TYPE_UNKNOWN,
	TYPE_DIR,
	TYPE_FILE
};

struct media_dir_s {
 	char *path;             /* base path */
 	media_types types;      /* types of files to scan */
 	struct media_dir_s *next;
};

struct album_art_name_s {
	char *name;             /* base path */
	uint8_t wildcard;
	struct album_art_name_s *next;
};

#endif
