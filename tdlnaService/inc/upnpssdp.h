
#ifndef __MINISSDP_H__
#define __MINISSDP_H__

#include "comm_types.h"

int OpenAndConfSSDPReceiveSocket(void);

//int OpenAndConfSSDPNotifySocket(struct lan_addr_s *iface);
int OpenAndConfSSDPNotifySocket(struct lan_addr_s *iface, sssdpr);

void SendSSDPNotifies(int s, const char *host, unsigned short port, unsigned int lifetime);

void ProcessSSDPRequest(int s, unsigned short port);

int SendSSDPGoodbyes(int s);

int SubmitServicesToMiniSSDPD(const char *host, unsigned short port);

#endif
