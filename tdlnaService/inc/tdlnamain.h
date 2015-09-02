#ifndef _TDLNAMAIN_
#define _TDLNAMAIN_

int serviceOn(void* data);
int serviceOff(void* data);
void setUUID();
void setDeviceProperty(void* data);
void* tdlnamain(void* data);
void* ssdpAlive(void* data);

static int OpenAndConfHTTPSocket(unsigned short port);
static void reload_ifaces(int force_notify, int sssdpr);

#endif
