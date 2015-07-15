#ifndef _TDLNAMAIN_
#define _TDLNAMAIN_

static int OpenAndConfHTTPSocket(unsigned short port);
static int getifaddr(const char *ifname);
void reload_ifaces(int force_notify);

int serviceOn(void* data);
int serviceOff(void* data);
void* tdlnamain(void* data);
void* ssdpAlive(void* data);

#endif
