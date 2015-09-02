#ifndef _TDLNAMAIN_
#define _TDLNAMAIN_

int serviceOn(void* data);
int serviceOff(void* data);
void setUUID();
void setDeviceProperty(void* data);
void* tdlnamain(void* data);
void* ssdpAlive(void* data);

#endif
