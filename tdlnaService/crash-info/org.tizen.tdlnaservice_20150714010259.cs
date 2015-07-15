S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 10106
Date: 2015-07-14 01:02:59+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf2c00000

Register Information
r0   = 0xf2c00002, r1   = 0xf2c00000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f855bb
r6   = 0xb5ca1458, r7   = 0xf2c00002
r8   = 0x0000001e, r9   = 0xb5ca26f0
r10  = 0xb6f8559c, fp   = 0xb5ca144c
ip   = 0x00000000, sp   = 0xb5ca0ee8
lr   = 0xb6df05b8, pc   = 0xb6e23d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     19292 KB
Buffers:     21240 KB
Cached:     251348 KB
VmPeak:      28896 KB
VmSize:      28892 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4992 KB
VmRSS:        4992 KB
VmData:      18028 KB
VmStk:         136 KB
VmExe:          48 KB
VmLib:        9144 KB
VmPTE:          22 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10106 TID = 10189
10106 10107 10189 

Maps Information
b54a4000 b5ca3000 rwxp [stack:10189]
b5ca4000 b64a7000 rwxp [stack:10107]
b64a7000 b64aa000 r-xp /lib/libgpg-error.so.0.5.0
b64b1000 b64b2000 rwxp /lib/libgpg-error.so.0.5.0
b64b2000 b650a000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6511000 b6514000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6515000 b6541000 r-xp /usr/lib/libsystemd.so.0.0.1
b6548000 b6549000 r-xp /usr/lib/libsystemd.so.0.0.1
b6549000 b654a000 rwxp /usr/lib/libsystemd.so.0.0.1
b654a000 b654c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6553000 b6554000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6554000 b661f000 r-xp /usr/lib/libxml2.so.2.7.8
b6627000 b662c000 rwxp /usr/lib/libxml2.so.2.7.8
b662d000 b663d000 r-xp /lib/libresolv-2.13.so
b663d000 b663e000 r-xp /lib/libresolv-2.13.so
b663e000 b663f000 rwxp /lib/libresolv-2.13.so
b6642000 b6658000 r-xp /lib/libz.so.1.2.5
b665f000 b6660000 rwxp /lib/libz.so.1.2.5
b6660000 b6662000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6669000 b666a000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b666a000 b666f000 r-xp /usr/lib/libffi.so.5.0.10
b6676000 b6677000 rwxp /usr/lib/libffi.so.5.0.10
b6677000 b6678000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b667f000 b6680000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6680000 b66e5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66ec000 b66ef000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66f0000 b66f3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66fa000 b66fb000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66fb000 b68a3000 r-xp /usr/lib/libcrypto.so.1.0.0
b68aa000 b68bf000 rwxp /usr/lib/libcrypto.so.1.0.0
b68c3000 b68d9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68e0000 b68e1000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b68e1000 b6915000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b691c000 b691e000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b691e000 b69f2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69fa000 b69fd000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69ff000 b6a03000 r-xp /usr/lib/libchromium.so.1.0
b6a0a000 b6a0b000 rwxp /usr/lib/libchromium.so.1.0
b6a0b000 b6a74000 r-xp /lib/libm-2.13.so
b6a7b000 b6a7c000 r-xp /lib/libm-2.13.so
b6a7c000 b6a7d000 rwxp /lib/libm-2.13.so
b6a7d000 b6a83000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a8a000 b6a8b000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a8b000 b6aaa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ab1000 b6ab2000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6ab2000 b6ab5000 r-xp /usr/lib/libsmack.so.1.0.0
b6abc000 b6abd000 rwxp /usr/lib/libsmack.so.1.0.0
b6abd000 b6ac2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6aca000 b6acb000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6acb000 b6af5000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6afd000 b6afe000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6afe000 b6b15000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b1d000 b6b1e000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b1e000 b6bb2000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bba000 b6bbd000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bbd000 b6bbf000 rwxp /usr/lib/libstdc++.so.6.0.16
b6bc5000 b6bd0000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6bd7000 b6bd8000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6bd8000 b6bdd000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6be5000 b6be6000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6be6000 b6cb6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6cb6000 b6cb7000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6cb7000 b6cf7000 r-xp /usr/lib/libeina.so.1.7.99
b6cfe000 b6cff000 rwxp /usr/lib/libeina.so.1.7.99
b6d00000 b6d16000 r-xp /usr/lib/libecore.so.1.7.99
b6d1d000 b6d1e000 rwxp /usr/lib/libecore.so.1.7.99
b6d2c000 b6d33000 r-xp /usr/lib/libvconf.so.0.2.45
b6d3b000 b6d3c000 rwxp /usr/lib/libvconf.so.0.2.45
b6d3c000 b6d41000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d48000 b6d49000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d49000 b6d54000 r-xp /usr/lib/libaul.so.0.1.0
b6d5c000 b6d5d000 rwxp /usr/lib/libaul.so.0.1.0
b6d5e000 b6d66000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d6d000 b6d6e000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d6e000 b6d70000 r-xp /lib/libdl-2.13.so
b6d77000 b6d78000 r-xp /lib/libdl-2.13.so
b6d78000 b6d79000 rwxp /lib/libdl-2.13.so
b6d79000 b6d84000 r-xp /lib/libunwind.so.8.0.1
b6d8b000 b6d8c000 rwxp /lib/libunwind.so.8.0.1
b6db1000 b6ecc000 r-xp /lib/libc-2.13.so
b6ed4000 b6ed6000 r-xp /lib/libc-2.13.so
b6ed6000 b6ed7000 rwxp /lib/libc-2.13.so
b6eda000 b6ee0000 r-xp /lib/librt-2.13.so
b6ee7000 b6ee8000 r-xp /lib/librt-2.13.so
b6ee8000 b6ee9000 rwxp /lib/librt-2.13.so
b6ee9000 b6eeb000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef2000 b6ef3000 rwxp /usr/lib/libdlog.so.0.0.0
b6ef3000 b6ef6000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6efd000 b6efe000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6efe000 b6f01000 r-xp /usr/lib/libbundle.so.0.1.22
b6f08000 b6f09000 rwxp /usr/lib/libbundle.so.0.1.22
b6f09000 b6f0c000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f13000 b6f14000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f14000 b6f28000 r-xp /lib/libpthread-2.13.so
b6f2f000 b6f30000 r-xp /lib/libpthread-2.13.so
b6f30000 b6f31000 rwxp /lib/libpthread-2.13.so
b6f48000 b6f4c000 r-xp /usr/lib/libsys-assert.so
b6f54000 b6f55000 rwxp /usr/lib/libsys-assert.so
b6f55000 b6f72000 r-xp /lib/ld-2.13.so
b6f79000 b6f7a000 r-xp /lib/ld-2.13.so
b6f7a000 b6f7b000 rwxp /lib/ld-2.13.so
b6f7b000 b6f87000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f8f000 b6f91000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b771e000 b7763000 rwxp [heap]
be8f5000 be916000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10106)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e23d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6df05b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e88b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6eea063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3f6 (0xb6f8015f) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x515f
End of Call Stack

Package Information
Package Name: org.tizen.tdlnaservice
Package ID : org.tizen.tdlnaservice
Version: 1.0.0
Package Type: rpm
App Name: tdlnaservice
App ID: org.tizen.tdlnaservice
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
4 01:02:00.020+0900 I/AclService( 1118): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59972 milliseconds from now
07-14 01:02:00.020+0900 I/Tizen::System( 1118): (461) > change cpu power policy: keepAwake(false)
07-14 01:02:01.470+0900 D/dalvikvm( 1380): GC_CONCURRENT freed 799K, 46% free 4326K/7943K, external 2127K/2656K, paused 3ms+3ms
07-14 01:02:25.170+0900 E/PKGMGR_SERVER( 9931): pkgmgr-server.c: main(1608) > server start
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 01:02:25.270+0900 E/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 01:02:25.270+0900 E/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(9552) are closed. delete client info
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 01:02:25.270+0900 E/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  9552
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.270+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 01:02:25.280+0900 W/AUL_AMD (  458): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 01:02:25.280+0900 W/AUL_AMD (  458): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 01:02:25.280+0900 W/AUL_AMD (  458): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 9552
07-14 01:02:25.280+0900 W/AUL_AMD (  458): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 01:02:25.290+0900 I/AUL_AMD (  458): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9552
07-14 01:02:25.290+0900 I/Tizen::System( 1058): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 01:02:25.290+0900 I/Tizen::Io( 1058): (729) > Entry not found
07-14 01:02:25.290+0900 I/Tizen::App(  982): (243) > App[org.tizen.tdlnaservice] pid[9552] terminate event is forwarded
07-14 01:02:25.290+0900 I/Tizen::System(  982): (256) > osp.accessorymanager.service provider is found.
07-14 01:02:25.290+0900 I/Tizen::System(  982): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 9552, ]
07-14 01:02:25.290+0900 I/Tizen::System(  982): (256) > osp.system.service provider is found.
07-14 01:02:25.290+0900 I/Tizen::App(  982): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 01:02:25.290+0900 I/Tizen::App(  982): (512) > Not registered pid(9552)
07-14 01:02:25.290+0900 I/Tizen::App(  982): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 9552.
07-14 01:02:25.290+0900 I/Tizen::System( 1058): (157) > change brightness system value.
07-14 01:02:25.290+0900 I/Tizen::App( 1058): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 9552.
07-14 01:02:27.970+0900 E/PKGMGR_SERVER( 9931): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 01:02:27.970+0900 E/PKGMGR_SERVER( 9931): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 01:02:29.310+0900 E/PKGMGR_SERVER(10030): pkgmgr-server.c: main(1608) > server start
07-14 01:02:29.360+0900 E/PKGMGR  (10030): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.tdlnaservice]
07-14 01:02:29.360+0900 E/PKGMGR_SERVER(10030): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.tdlnaservice 
07-14 01:02:29.360+0900 E/PKGMGR_SERVER(10030): [0;m
07-14 01:02:29.530+0900 I/Tizen::App( 1058): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 01:02:29.530+0900 I/Tizen::App( 1058): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 01:02:29.530+0900 I/Tizen::App(  982): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 01:02:29.530+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 01:02:29.530+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 01:02:29.540+0900 W/AUL_AMD (  458): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-14 01:02:29.550+0900 I/Tizen::App( 1058): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 01:02:29.550+0900 I/Tizen::App( 1058): (119) > InstallationInProgress [30]
07-14 01:02:29.550+0900 I/Tizen::App( 1058): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 01:02:29.550+0900 I/Tizen::App(  982): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 01:02:29.550+0900 I/Tizen::App(  982): (119) > InstallationInProgress [30]
07-14 01:02:29.550+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 01:02:29.550+0900 I/Tizen::App(  982): (119) > InstallationInProgress [30]
07-14 01:02:29.550+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 01:02:29.560+0900 I/Tizen::App( 1118): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 01:02:29.560+0900 I/Tizen::App( 1118): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 01:02:29.560+0900 I/Tizen::App( 1118): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 01:02:29.560+0900 I/Tizen::App( 1118): (119) > InstallationInProgress [30]
07-14 01:02:29.560+0900 I/Tizen::App( 1118): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 01:02:30.210+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-14 01:02:30.210+0900 I/Tizen::App( 1058): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 01:02:30.210+0900 I/Tizen::App( 1058): (119) > InstallationInProgress [60]
07-14 01:02:30.210+0900 I/Tizen::App( 1058): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 01:02:30.210+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 120
07-14 01:02:30.210+0900 I/Tizen::App(  982): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 01:02:30.210+0900 I/Tizen::App(  982): (119) > InstallationInProgress [60]
07-14 01:02:30.220+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 01:02:30.220+0900 I/Tizen::App(  982): (119) > InstallationInProgress [60]
07-14 01:02:30.220+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 01:02:30.220+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 120
07-14 01:02:30.220+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
07-14 01:02:30.220+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 33
07-14 01:02:30.220+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 35 33
07-14 01:02:30.220+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
07-14 01:02:30.220+0900 I/Tizen::App( 1118): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 01:02:30.220+0900 I/Tizen::App( 1118): (119) > InstallationInProgress [60]
07-14 01:02:30.220+0900 I/Tizen::App( 1118): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 01:02:30.930+0900 E/PKGMGR_CERT(10031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-14 01:02:30.930+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/res]
07-14 01:02:30.930+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.tdlnaservice/shared], errno=[2][No such file or directory]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared/res]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/tizen-manifest.xml]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/author-signature.xml]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/signature1.xml]
07-14 01:02:30.940+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.tdlnaservice.xml]
07-14 01:02:31.460+0900 E/rpm-installer(10031): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]))
07-14 01:02:31.970+0900 E/PKGMGR_SERVER(10030): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-14 01:02:33.970+0900 E/PKGMGR_SERVER(10030): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-14 01:02:34.180+0900 I/Tizen::App( 1058): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 01:02:34.180+0900 I/Tizen::App( 1058): (119) > InstallationInProgress [100]
07-14 01:02:34.180+0900 I/Tizen::App( 1058): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 01:02:34.180+0900 I/Tizen::App(  982): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 01:02:34.180+0900 I/Tizen::App(  982): (119) > InstallationInProgress [100]
07-14 01:02:34.180+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 01:02:34.180+0900 I/Tizen::App(  982): (119) > InstallationInProgress [100]
07-14 01:02:34.180+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 01:02:34.190+0900 I/Tizen::App( 1058): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 01:02:34.190+0900 I/Tizen::App( 1058): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 01:02:34.190+0900 I/Tizen::App( 1058): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-14 01:02:34.190+0900 I/Tizen::App(  982): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 01:02:34.190+0900 I/Tizen::App(  982): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 01:02:34.190+0900 I/Tizen::App(  982): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-14 01:02:34.200+0900 I/Tizen::App(  982): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 01:02:34.210+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-14 01:02:34.210+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-14 01:02:34.210+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-14 01:02:34.240+0900 E/PKGMGR_INFO(10031): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-14 01:02:34.240+0900 E/PKGMGR_INSTALLER(10031): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-14 01:02:34.270+0900 I/Tizen::App( 1118): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 01:02:34.270+0900 I/Tizen::App( 1118): (119) > InstallationInProgress [100]
07-14 01:02:34.270+0900 I/Tizen::App( 1118): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 01:02:34.270+0900 I/Tizen::App( 1118): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 01:02:34.270+0900 I/Tizen::App( 1118): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 01:02:34.290+0900 I/Tizen::App( 1118): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 01:02:34.300+0900 I/Tizen::App( 1118): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-14 01:02:34.310+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-14 01:02:34.310+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-14 01:02:34.310+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-14 01:02:34.310+0900 I/Tizen::App(  982): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-14 01:02:34.320+0900 I/Tizen::App( 1118): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 01:02:34.320+0900 I/Tizen::App( 1118): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-14 01:02:34.330+0900 I/Tizen::App(  982): (416) > appName = [tdlnaservice]
07-14 01:02:34.330+0900 I/Tizen::App(  982): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 01:02:34.330+0900 E/PKGMGR_INFO(  982): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-14 01:02:34.330+0900 I/Tizen::App(  982): (675) > Application count(1) in this package
07-14 01:02:34.330+0900 I/Tizen::App(  982): (855) > Enter.
07-14 01:02:34.340+0900 I/Tizen::App(  982): (695) > Exit.
07-14 01:02:34.340+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 01:02:34.340+0900 I/Tizen::App(  982): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 01:02:34.340+0900 I/Tizen::App(  982): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 01:02:34.340+0900 I/Tizen::App(  982): (416) > appName = [tdlnaservice]
07-14 01:02:34.340+0900 I/Tizen::App(  982): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 01:02:34.340+0900 I/Tizen::App(  982): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-14 01:02:34.340+0900 I/Tizen::App(  982): (131) > Enter
07-14 01:02:34.350+0900 I/Tizen::App(  982): (137) > org.tizen.tdlnaservice does not have launch condition
07-14 01:02:34.350+0900 I/Tizen::App(  982): (898) > Exit.
07-14 01:02:35.980+0900 E/PKGMGR_SERVER(10030): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 01:02:35.980+0900 E/PKGMGR_SERVER(10030): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 01:02:36.610+0900 W/AUL_AMD (  458): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 01:02:36.620+0900 I/AUL     (  458): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-14 01:02:36.630+0900 I/AUL     (  458): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-14 01:02:36.630+0900 E/AUL_AMD (  458): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 01:02:36.640+0900 W/AUL_AMD (  458): amd_launch.c: service_start(515) > child process: 10106
07-14 01:02:36.690+0900 W/AUL_AMD (  458): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 10106
07-14 01:02:36.690+0900 E/RESOURCED(  774): proc-process.c: proc_get_oom_score_adj(377) > [proc_get_oom_score_adj,377] fopen /proc/0/oom_score_adj failed
07-14 01:02:36.710+0900 I/Tizen::App(  982): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 01:02:36.710+0900 I/Tizen::App(  982): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 10106.
07-14 01:02:36.710+0900 I/Tizen::App( 1058): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 10106.
07-14 01:02:36.730+0900 I/tdlna   (10106): _on_create_cb 실행
07-14 01:02:36.730+0900 I/tdlna   (10106): _app_init 실행
07-14 01:02:36.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 10106
07-14 01:02:36.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 01:02:36.740+0900 D/tdlnaservice(10106): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 01:02:36.740+0900 I/tdlna   (10106): _on_app_control_callback 실행
07-14 01:02:36.740+0900 I/tdlna   (10106): _app_timer_thread_func 실행
07-14 01:02:55.910+0900 W/LOCKSCREEN(  572): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-14 01:02:55.910+0900 W/LOCKSCREEN(  572): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-14 01:02:55.910+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-14 01:02:55.910+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-14 01:02:55.910+0900 W/LOCKSCREEN(  572): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 01:02:55.910+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-14 01:02:55.920+0900 I/indicator(  490): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-14 01:02:55.920+0900 E/LOCKSCREEN(  572): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 01:02:55.930+0900 W/LOCKSCREEN(  572): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 01:02:55.940+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 01:02:55.940+0900 W/LOCKSCREEN(  572): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 288 331 5 28 25"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 289 387 5 28 25"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 288 651 5 28 25"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 01:02:55.970+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 289 707 5 28 25"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 288 331 5 28 25"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 01:02:55.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 289 387 5 28 25"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 288 651 5 28 25"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 01:02:55.990+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 289 707 5 28 25"
07-14 01:02:56.580+0900 I/Tizen::System( 1058): (280) > The screen has been turned on.
07-14 01:02:56.580+0900 I/Tizen::Io( 1058): (729) > Entry not found
07-14 01:02:56.590+0900 W/AUL_AMD (  458): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 01:02:56.600+0900 I/AUL     (  458): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
07-14 01:02:56.600+0900 I/AUL     (  458): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
07-14 01:02:56.600+0900 E/AUL_AMD (  458): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 01:02:56.610+0900 I/Tizen::App(  982): (124) > app(ACL111OMWW.AclService), clientId(1118)
07-14 01:02:56.630+0900 I/Tizen::System( 1058): (157) > change brightness system value.
07-14 01:02:56.690+0900 I/CAPI_APPFW_APPLICATION(10171): app_main.c: ui_app_main(699) > app_efl_main
07-14 01:02:56.720+0900 I/UXT     (10171): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 01:02:56.740+0900 E/RESOURCED(  774): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 289
07-14 01:02:56.750+0900 I/Tizen::App( 1058): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 10171.
07-14 01:02:56.750+0900 I/Tizen::App(  982): (499) > LaunchedApp(com.samsung.data-provider-slave)
07-14 01:02:56.760+0900 I/Tizen::App(  982): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 10171.
07-14 01:02:56.800+0900 I/CAPI_APPFW_APPLICATION(10171): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-14 01:02:56.840+0900 I/EFL-ASSIST(10171): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b7a46c68) from (/usr/share/themes/FontInfoTable.xml) is created
07-14 01:02:56.840+0900 E/TIZEN_N_SYSTEM_SETTINGS(10171): system_settings.c: system_settings_set_changed_cb(541) > b4cfd1fd
07-14 01:02:56.840+0900 E/TIZEN_N_SYSTEM_SETTINGS(10171): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_size --- callback ptr : b4cfbdfd
07-14 01:02:56.840+0900 E/EFL     (10171): evas_main<10171> evas_font_dir.c:1515 evas_font_reinit() ENTER:: evas_font_reinit
07-14 01:02:56.860+0900 E/EFL     (10171): evas_main<10171> evas_font_dir.c:1526 evas_font_reinit() DONE:: evas_font_reinit
07-14 01:02:56.870+0900 I/Tizen::App(  982): (124) > app(ACL111OMWW.AclService), clientId(1118)
07-14 01:02:56.880+0900 I/EFL-ASSIST(10171): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7a574f0) from (/opt/usr/share/data-provider-slave/theme/color/com.samsung.data-provider-slave_ChangeableColorInfo.xml) is created
07-14 01:02:56.890+0900 E/EFL-ASSIST(10171): efl_assist_theme_color.cpp: ea_theme_colors_set(868) > cannot get color table data
07-14 01:02:56.900+0900 I/CAPI_APPFW_APPLICATION(10171): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-14 01:02:56.910+0900 E/LOCKSCREEN(  572): progress_circle.c: unlock_mouse_up(285) > 
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-14 01:02:56.910+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-14 01:02:56.920+0900 I/APP_CORE(10171): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 01:02:56.920+0900 I/APP_CORE(10171): appcore-efl.c: __do_app(511) > [APP 10171] Initial Launching, call the resume_cb
07-14 01:02:56.920+0900 I/CAPI_APPFW_APPLICATION(10171): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-14 01:02:57.120+0900 I/Tizen::App(  982): (124) > app(ACL111OMWW.AclService), clientId(1118)
07-14 01:02:57.130+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_create(363) > New handle created[0xb29008f0]
07-14 01:02:57.130+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: __connection_set_type_changed_callback(146) > Successfully registered(1)
07-14 01:02:57.130+0900 E/weather-common(10171): dbf-engine-db.c: dbf_engine_db_initialize(66) > [0;40;31mp_db_handle is NULL[0;m
07-14 01:02:57.160+0900 E/cluster-home(  603): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
07-14 01:02:57.160+0900 E/cluster-home(  603): cluster-data-list.cpp: UpdateCustomDBox(1485) >  Invalid box size: 65535
07-14 01:02:57.160+0900 W/cluster-home(  603): cluster-data-provider.cpp: DBoxEventUpdated(1657) >  Can not update dynamicbox
07-14 01:02:57.170+0900 E/weather-live(10171): main.c: dynamicbox_resize(1813) > [0;40;31minfo->first_create : 0[0;m
07-14 01:02:57.200+0900 E/EFL     (10171): evas_main<10171> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 01:02:57.200+0900 E/EFL     (10171): evas_main<10171> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 01:02:57.230+0900 E/weather-live(10171): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 01:02:57.370+0900 I/Tizen::App(  982): (124) > app(ACL111OMWW.AclService), clientId(1118)
07-14 01:02:57.380+0900 E/weather-live(10171): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
07-14 01:02:57.380+0900 E/weather-live(10171): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
07-14 01:02:57.410+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-14 01:02:57.410+0900 W/LOCKSCREEN(  572): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-14 01:02:57.410+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-14 01:02:57.420+0900 E/WALLPAPER_SERVICE_COMMON(  572): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 01:02:57.420+0900 W/PROCESSMGR(  375): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9572
07-14 01:02:57.430+0900 W/AUL_AMD (  458): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 01:02:57.440+0900 I/indicator(  490): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 9572"
07-14 01:02:57.440+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_create(363) > New handle created[0xb26785e8]
07-14 01:02:57.450+0900 E/EFL     ( 9572): ewebkit2<9572> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 01:02:57.470+0900 W/LOCKSCREEN(  572): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(1)
07-14 01:02:57.470+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-14 01:02:57.470+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-14 01:02:57.470+0900 I/CAPI_APPFW_APPLICATION(  572): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 01:02:57.470+0900 E/LOCKSCREEN(  572): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 01:02:57.470+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-14 01:02:57.470+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-14 01:02:57.490+0900 I/Tizen::System( 1058): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 01:02:57.490+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_get_type(412) > Connected Network = 2
07-14 01:02:57.490+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_destroy(379) > Destroy handle: 0xb26785e8
07-14 01:02:57.500+0900 I/Tizen::Io( 1058): (729) > Entry not found
07-14 01:02:57.500+0900 W/AUL_AMD (  458): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 01:02:57.510+0900 I/Tizen::System( 1118): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 01:02:57.520+0900 I/Tizen::System( 1058): (157) > change brightness system value.
07-14 01:02:57.520+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
07-14 01:02:57.590+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
07-14 01:02:57.620+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
07-14 01:02:57.620+0900 W/LOCKSCREEN(  572): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-14 01:02:57.620+0900 E/LOCKSCREEN(  572): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 01:02:57.620+0900 I/Tizen::App(  982): (124) > app(ACL111OMWW.AclService), clientId(1118)
07-14 01:02:57.630+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-14 01:02:57.630+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-14 01:02:57.640+0900 E/LOCKSCREEN(  572): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-14 01:02:57.640+0900 D/PowerManagerService( 1380): calling setSysScreenBrightness(brightness = 153)
07-14 01:02:57.640+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
07-14 01:02:57.640+0900 I/power   ( 1380): *** set_screen_state 1
07-14 01:02:57.640+0900 I/PowerManagerService-JNI( 1380): sending ACL screen state 'L'
07-14 01:02:57.640+0900 D/SensorService( 1380): actuateSensor
07-14 01:02:57.640+0900 D/AclServiceManager( 1380): -----*******------------ enableSensor  : 0
07-14 01:02:57.640+0900 D/SensorService( 1380): setSensorDelay
07-14 01:02:57.640+0900 D/AclServiceManager( 1380): -----*******------------ setSensorDelay : 0 to 200
07-14 01:02:57.640+0900 D/SensorService( 1380): setSensorDelay
07-14 01:02:57.640+0900 D/AclServiceManager( 1380): -----*******------------ setSensorDelay : 0 to 200
07-14 01:02:57.640+0900 I/AclService( 1118): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 01:02:57.640+0900 D/ACL     ( 1380): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 01:02:57.640+0900 D/ACL     ( 1380): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-14 01:02:57.650+0900 I/PowerManagerService-JNI( 1380): sending ACL screen state 'F'
07-14 01:02:57.650+0900 I/Tizen::System( 1118): (461) > change cpu power policy: keepAwake(true)
07-14 01:02:57.650+0900 I/Tizen::System( 1118): (461) > change cpu power policy: keepAwake(false)
07-14 01:02:57.660+0900 I/AclService( 1118): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-14 01:02:57.660+0900 I/AclService( 1118): void minimize()(280) > Minimizing all vfb clients
07-14 01:02:57.660+0900 I/AclService( 1118): void minimize()(283) > minimizing {pkg=surfaceflinger fd=101}
07-14 01:02:57.660+0900 E/Tizen::Io( 1118): (133) > [E_INVALID_ARG] The application id is empty.
07-14 01:02:57.660+0900 I/Tizen::Base::Runtime( 1118): (251) > The timer is not started.
07-14 01:02:57.680+0900 E/weather-live(10171): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 01:02:57.690+0900 E/weather-live(10171): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
07-14 01:02:57.690+0900 E/weather-live(10171): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
07-14 01:02:57.720+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_create(363) > New handle created[0xb295c930]
07-14 01:02:57.720+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_get_type(412) > Connected Network = 2
07-14 01:02:57.720+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_destroy(379) > Destroy handle: 0xb295c930
07-14 01:02:57.720+0900 W/AUL_AMD (  458): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 01:02:57.720+0900 W/AUL_AMD (  458): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-14 01:02:57.730+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
07-14 01:02:57.750+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
07-14 01:02:57.770+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
07-14 01:02:57.790+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
07-14 01:02:57.810+0900 E/weather-live(10171): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 01:02:57.830+0900 E/weather-live(10171): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
07-14 01:02:57.830+0900 E/weather-live(10171): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
07-14 01:02:57.850+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_create(363) > New handle created[0xb26fe3e0]
07-14 01:02:57.850+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_get_type(412) > Connected Network = 2
07-14 01:02:57.850+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_destroy(379) > Destroy handle: 0xb26fe3e0
07-14 01:02:57.860+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
07-14 01:02:57.890+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
07-14 01:02:57.920+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
07-14 01:02:57.940+0900 E/weather-common(10171): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
07-14 01:02:58.050+0900 W/LOCKSCREEN(  572): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 01:02:58.060+0900 E/cluster-home(  603): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
07-14 01:02:58.070+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_create(363) > New handle created[0xb26785d8]
07-14 01:02:58.070+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_get_type(412) > Connected Network = 2
07-14 01:02:58.070+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_destroy(379) > Destroy handle: 0xb26785d8
07-14 01:02:58.070+0900 E/weather-live(10171): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
07-14 01:02:58.070+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_create(363) > New handle created[0xb2974e80]
07-14 01:02:58.070+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_get_type(412) > Connected Network = 2
07-14 01:02:58.070+0900 I/CAPI_NETWORK_CONNECTION(10171): connection.c: connection_destroy(379) > Destroy handle: 0xb2974e80
07-14 01:02:58.070+0900 E/weather-live(10171): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 01:02:58.080+0900 E/cluster-home(  603): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
07-14 01:02:58.080+0900 E/cluster-home(  603): cluster-data-provider.cpp: EventPixmapAcquired(2075) >  Release depreacted pixmap [27262980]
07-14 01:02:58.090+0900 E/weather-live(10171): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 01:02:58.110+0900 E/weather-live(10171): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 01:02:58.120+0900 E/weather-common(10171): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
07-14 01:02:58.120+0900 E/weather-common(10171): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 01:02:58.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 01:02:58.730+0900 D/tdlnaservice(10106): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 01:02:58.730+0900 I/tdlna   (10106): _on_proxy_client_msg_received_cb 실행
07-14 01:02:58.730+0900 I/tdlna   (10106): _app_process_received_message 실행
07-14 01:02:58.730+0900 I/tdlna   (10106): test _ _app_process_received_message
07-14 01:02:58.730+0900 I/tdlna   (10106): _app_execute_operation 실행
07-14 01:02:58.730+0900 I/tdlna   (10106): test 실행
07-14 01:02:58.730+0900 I/tdlna   (10106): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 01:02:58.740+0900 I/tdlna   (10106): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 01:02:58.740+0900 I/tdlna   (10106): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 01:02:58.740+0900 I/tdlna   (10106): _app_send_response 실행
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 01:02:58.740+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 01:02:58.750+0900 D/tdlnaservice(10106): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 01:02:58.780+0900 I/tdlna   (10106): Main Start !!! 1
07-14 01:02:58.780+0900 I/tdlna   (10106): Service Start !!! 1
07-14 01:02:58.790+0900 I/tdlna   (10106): fork 전
07-14 01:02:58.810+0900 I/tdlna   (10190): fork child process 1
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 01:02:58.830+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 01:02:58.880+0900 I/tdlna   (10190): ssdp running
07-14 01:02:59.360+0900 W/CRASH_MANAGER(10191): worker.c: worker_job(1236) > 111010674646c143680337
