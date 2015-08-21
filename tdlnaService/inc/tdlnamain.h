#ifndef _TDLNAMAIN_
#define _TDLNAMAIN_

static int OpenAndConfHTTPSocket(unsigned short port);
static int getifaddr(const char *ifname, int sssdpr);
static void reload_ifaces(int force_notify, int sssdpr);

int serviceOn(void* data);
int serviceOff(void* data);
void setUUID();
void setDeviceProperty(void* data);
void* tdlnamain(void* data);
void* ssdpAlive(void* data);

#endif
