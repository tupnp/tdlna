S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 3093
Date: 2015-07-14 15:41:03+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xbfc70000

Register Information
r0   = 0xbfc70002, r1   = 0xbfc70000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6fbc682
r6   = 0xb5cd8448, r7   = 0xbfc70002
r8   = 0x0000001e, r9   = 0xb5cd96f0
r10  = 0xb6fbc663, fp   = 0xb5cd843c
ip   = 0x00000000, sp   = 0xb5cd7ed8
lr   = 0xb6e275b8, pc   = 0xb6e5ad64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     27680 KB
Buffers:     27572 KB
Cached:     270884 KB
VmPeak:      28900 KB
VmSize:      28896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4992 KB
VmRSS:        4992 KB
VmData:      18028 KB
VmStk:         136 KB
VmExe:          52 KB
VmLib:        9144 KB
VmPTE:          22 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3093 TID = 3887
3093 3103 3887 

Maps Information
b54db000 b5cda000 rwxp [stack:3887]
b5cdb000 b64de000 rwxp [stack:3103]
b64de000 b64e1000 r-xp /lib/libgpg-error.so.0.5.0
b64e8000 b64e9000 rwxp /lib/libgpg-error.so.0.5.0
b64e9000 b6541000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6548000 b654b000 rwxp /usr/lib/libgcrypt.so.11.5.3
b654c000 b6578000 r-xp /usr/lib/libsystemd.so.0.0.1
b657f000 b6580000 r-xp /usr/lib/libsystemd.so.0.0.1
b6580000 b6581000 rwxp /usr/lib/libsystemd.so.0.0.1
b6581000 b6583000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b658a000 b658b000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b658b000 b6656000 r-xp /usr/lib/libxml2.so.2.7.8
b665e000 b6663000 rwxp /usr/lib/libxml2.so.2.7.8
b6664000 b6674000 r-xp /lib/libresolv-2.13.so
b6674000 b6675000 r-xp /lib/libresolv-2.13.so
b6675000 b6676000 rwxp /lib/libresolv-2.13.so
b6679000 b668f000 r-xp /lib/libz.so.1.2.5
b6696000 b6697000 rwxp /lib/libz.so.1.2.5
b6697000 b6699000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66a0000 b66a1000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66a1000 b66a6000 r-xp /usr/lib/libffi.so.5.0.10
b66ad000 b66ae000 rwxp /usr/lib/libffi.so.5.0.10
b66ae000 b66af000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66b6000 b66b7000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66b7000 b671c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6723000 b6726000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6727000 b672a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6731000 b6732000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6732000 b68da000 r-xp /usr/lib/libcrypto.so.1.0.0
b68e1000 b68f6000 rwxp /usr/lib/libcrypto.so.1.0.0
b68fa000 b6910000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6917000 b6918000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6918000 b694c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6953000 b6955000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6955000 b6a29000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a31000 b6a34000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a36000 b6a3a000 r-xp /usr/lib/libchromium.so.1.0
b6a41000 b6a42000 rwxp /usr/lib/libchromium.so.1.0
b6a42000 b6aab000 r-xp /lib/libm-2.13.so
b6ab2000 b6ab3000 r-xp /lib/libm-2.13.so
b6ab3000 b6ab4000 rwxp /lib/libm-2.13.so
b6ab4000 b6aba000 r-xp /usr/lib/libappsvc.so.0.1.0
b6ac1000 b6ac2000 rwxp /usr/lib/libappsvc.so.0.1.0
b6ac2000 b6ae1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ae8000 b6ae9000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6ae9000 b6aec000 r-xp /usr/lib/libsmack.so.1.0.0
b6af3000 b6af4000 rwxp /usr/lib/libsmack.so.1.0.0
b6af4000 b6af9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b01000 b6b02000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b02000 b6b2c000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b34000 b6b35000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b35000 b6b4c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b54000 b6b55000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b55000 b6be9000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bf1000 b6bf4000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bf4000 b6bf6000 rwxp /usr/lib/libstdc++.so.6.0.16
b6bfc000 b6c07000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c0e000 b6c0f000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c0f000 b6c14000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c1c000 b6c1d000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c1d000 b6ced000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6ced000 b6cee000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6cee000 b6d2e000 r-xp /usr/lib/libeina.so.1.7.99
b6d35000 b6d36000 rwxp /usr/lib/libeina.so.1.7.99
b6d37000 b6d4d000 r-xp /usr/lib/libecore.so.1.7.99
b6d54000 b6d55000 rwxp /usr/lib/libecore.so.1.7.99
b6d63000 b6d6a000 r-xp /usr/lib/libvconf.so.0.2.45
b6d72000 b6d73000 rwxp /usr/lib/libvconf.so.0.2.45
b6d73000 b6d78000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d7f000 b6d80000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d80000 b6d8b000 r-xp /usr/lib/libaul.so.0.1.0
b6d93000 b6d94000 rwxp /usr/lib/libaul.so.0.1.0
b6d95000 b6d9d000 r-xp /lib/libgcc_s-4.6.4.so.1
b6da4000 b6da5000 rwxp /lib/libgcc_s-4.6.4.so.1
b6da5000 b6da7000 r-xp /lib/libdl-2.13.so
b6dae000 b6daf000 r-xp /lib/libdl-2.13.so
b6daf000 b6db0000 rwxp /lib/libdl-2.13.so
b6db0000 b6dbb000 r-xp /lib/libunwind.so.8.0.1
b6dc2000 b6dc3000 rwxp /lib/libunwind.so.8.0.1
b6de8000 b6f03000 r-xp /lib/libc-2.13.so
b6f0b000 b6f0d000 r-xp /lib/libc-2.13.so
b6f0d000 b6f0e000 rwxp /lib/libc-2.13.so
b6f11000 b6f17000 r-xp /lib/librt-2.13.so
b6f1e000 b6f1f000 r-xp /lib/librt-2.13.so
b6f1f000 b6f20000 rwxp /lib/librt-2.13.so
b6f20000 b6f22000 r-xp /usr/lib/libdlog.so.0.0.0
b6f29000 b6f2a000 rwxp /usr/lib/libdlog.so.0.0.0
b6f2a000 b6f2d000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f34000 b6f35000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f35000 b6f38000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3f000 b6f40000 rwxp /usr/lib/libbundle.so.0.1.22
b6f40000 b6f43000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f4a000 b6f4b000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f4b000 b6f5f000 r-xp /lib/libpthread-2.13.so
b6f66000 b6f67000 r-xp /lib/libpthread-2.13.so
b6f67000 b6f68000 rwxp /lib/libpthread-2.13.so
b6f7f000 b6f83000 r-xp /usr/lib/libsys-assert.so
b6f8b000 b6f8c000 rwxp /usr/lib/libsys-assert.so
b6f8c000 b6fa9000 r-xp /lib/ld-2.13.so
b6fb0000 b6fb1000 r-xp /lib/ld-2.13.so
b6fb1000 b6fb2000 rwxp /lib/ld-2.13.so
b6fb2000 b6fbf000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fc6000 b6fc8000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7f1e000 b7f63000 rwxp [heap]
bef18000 bef39000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3093)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e5ad64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e275b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6ebfb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f21063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x43a (0xb6fb7127) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5127
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
_request.c: __request_handler(601) > __request_handler: 15
07-14 15:40:17.760+0900 I/Tizen::System( 1437): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:40:17.770+0900 I/Tizen::System( 1219): (157) > change brightness system value.
07-14 15:40:17.810+0900 I/CAPI_APPFW_APPLICATION(  590): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:40:17.810+0900 E/cluster-home(  590): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:40:18.050+0900 I/UXT     ( 3637): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:40:18.110+0900 I/EFL-ASSIST( 3637): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (164c298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:40:18.110+0900 I/EFL-ASSIST( 3637): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (164c298) is freed
07-14 15:40:18.120+0900 I/EFL-ASSIST( 3637): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (164c298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:40:18.120+0900 I/EFL-ASSIST( 3637): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (164c298) is freed
07-14 15:40:18.190+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.200+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.200+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.200+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.210+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.220+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.220+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.220+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.230+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.240+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.240+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.240+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.250+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.250+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.250+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.250+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.260+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.280+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.280+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.280+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.290+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.300+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.300+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.300+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.310+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.320+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.320+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.320+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.320+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.330+0900 I/AUL     ( 3616): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:40:18.330+0900 E/AUL     ( 3616): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:40:18.330+0900 E/AUL     ( 3616): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:40:18.780+0900 E/WEBKIT  ( 3615): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 15:40:20.000+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:40:20.170+0900 I/MALI    ( 3615): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x169cba0] swap changed from async to sync
07-14 15:40:20.220+0900 E/PKGMGR_INFO( 3619): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:40:20.470+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:40:20.480+0900 I/AUL     ( 3619): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:40:20.480+0900 I/AUL     (  387): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 3619
07-14 15:40:20.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:40:20.500+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:40:20.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.510+0900 D/tdlnaservice( 3093): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:40:20.510+0900 I/tdlna   ( 3093): _on_proxy_client_msg_received_cb 실행
07-14 15:40:20.510+0900 I/tdlna   ( 3093): _app_process_received_message 실행
07-14 15:40:20.510+0900 I/tdlna   ( 3093): _app_execute_operation 실행
07-14 15:40:20.510+0900 I/tdlna   ( 3093): _app_send_response 실행
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:40:20.520+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.520+0900 D/tdlnaservice( 3093): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:40:20.540+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.550+0900 D/tdlnaservice( 3093): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:40:20.550+0900 I/tdlna   ( 3093): _on_proxy_client_msg_received_cb 실행
07-14 15:40:20.550+0900 I/tdlna   ( 3093): _app_process_received_message 실행
07-14 15:40:20.550+0900 I/tdlna   ( 3093): _app_execute_operation 실행
07-14 15:40:20.550+0900 D/tdlnaservice( 3093): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 15:40:20.550+0900 I/tdlna   ( 3093): _app_run_timer 실행
07-14 15:40:20.550+0900 I/tdlna   ( 3093): _app_run_timer 실행
07-14 15:40:20.550+0900 I/tdlna   ( 3093): _app_send_response 실행
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:40:20.550+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:20.550+0900 D/tdlnaservice( 3093): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:40:20.580+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:40:26.180+0900 E/DOWNLOAD_PROVIDER(  654): download-provider-db.c: dp_db_get_ids(437) > check connection handle
07-14 15:40:26.190+0900 I/AUL     (  654): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/download-provider, ret : 0
07-14 15:40:26.200+0900 I/AUL     (  654): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/download-provider, ret : 0
07-14 15:40:26.200+0900 I/DOWNLOAD_PROVIDER(  654): download-provider-client-manager.c: dp_client_manager(732) > client-manager's working is done
07-14 15:40:26.200+0900 E/WIFI_DIRECT(  654): wifi-direct-client-proxy.c: __wfd_client_check_socket(530) > Error! POLLHUP from socket[8]
07-14 15:40:26.200+0900 E/WIFI_DIRECT(  654): wifi-direct-client-proxy.c: __wfd_client_read_socket(590) > Socket error
07-14 15:40:26.200+0900 E/WIFI_DIRECT(  654): wifi-direct-client-proxy.c: __wfd_client_send_request(639) > Failed to read socket [-29753342]
07-14 15:40:26.200+0900 I/CAPI_NETWORK_CONNECTION(  654): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-14 15:40:26.200+0900 I/CAPI_NETWORK_CONNECTION(  654): connection.c: __connection_set_ip_changed_callback(244) > Successfully de-registered(0)
07-14 15:40:26.200+0900 I/CAPI_NETWORK_CONNECTION(  654): connection.c: connection_destroy(379) > Destroy handle: 0x1d89470
07-14 15:40:26.210+0900 I/DOWNLOAD_PROVIDER(  654): download-provider-main.c: main(64) > download-provider's working is done
07-14 15:40:41.840+0900 E/QUICKPANEL(  657): noti_led.c: _led_list_find_by_priv_id(118) > [_led_list_find_by_priv_id : 118] invalid parameter
07-14 15:40:41.840+0900 E/VCONF   (  657): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/blockingmode/led_indicator) step(-21) failed(2 / No such file or directory)
07-14 15:40:41.840+0900 E/VCONF   (  657): vconf.c: _vconf_get_key(2111) > db/setting/blockingmode/led_indicator : read buf error(-21). break
07-14 15:40:41.840+0900 E/VCONF   (  657): vconf.c: vconf_get_bool(2417) > vconf_get_bool(657) : db/setting/blockingmode/led_indicator error
07-14 15:40:41.840+0900 E/QUICKPANEL(  657): noti_led.c: _noti_led_off(231) > [_noti_led_off : 231] try to turn off LED
07-14 15:40:41.840+0900 E/QUICKPANEL(  657): noti_led.c: _noti_led_off(236) > [_noti_led_off : 236] failed led_set_mode:-1
07-14 15:40:41.840+0900 I/QUICKPANEL(  657): vi_manager.c: _vi_freeze_start(67) > [_vi_freeze_start : 67] VIM freezing
07-14 15:40:41.840+0900 I/QUICKPANEL(  657): noti.c: quickpanel_noti_set_clear_all_status(1457) > [quickpanel_noti_set_clear_all_status : 1457] NOTI SECTION CLEAR ALL HIDE
07-14 15:40:41.840+0900 E/QUICKPANEL(  657): noti_list_item.c: _get_noti_node(97) > [_get_noti_node : 97] invalid parameter
07-14 15:40:41.840+0900 E/QUICKPANEL(  657): vi_manager.c: _vi_list_count(128) > [_vi_list_count : 128] list null
07-14 15:40:41.840+0900 I/QUICKPANEL(  657): vi_manager.c: _vi_freeze_stop(79) > [_vi_freeze_stop : 79] VIM unfreezing
07-14 15:40:41.960+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:40:41.960+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:40:41.960+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:40:41.960+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:40:41.960+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 359 5 28 25"
07-14 15:40:41.970+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1131): media_content.c: media_content_disconnect(942) > [32m[1131]ref count changed to: 0
07-14 15:40:41.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:40:41.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:40:41.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:40:41.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:40:41.980+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 679 5 28 25"
07-14 15:40:42.100+0900 W/LOCKSCREEN(  573): property.c: _vconf_cb(210) > [_vconf_cb:210:W] property 400 is changed to 0
07-14 15:40:42.100+0900 W/LOCKSCREEN(  573): daemon.c: lockd_event(904) > [lockd_event:904:W] event:40000:CONF_CHANGED
07-14 15:40:42.100+0900 W/LOCKSCREEN(  573): daemon.c: _event_route(723) > [_event_route:723:W] event:40000 event_info:400
07-14 15:40:42.100+0900 W/LOCKSCREEN(  573): view-mgr.c: _event_route(108) > [_event_route:108:W] event:40000 event_info:400
07-14 15:40:42.110+0900 I/RESOURCED(  765): logging.c: broadcast_logging_data_updated_signal(714) > [broadcast_logging_data_updated_signal,714] broadcast logging_data updated signal!
07-14 15:40:42.110+0900 W/LOCKSCREEN(  573): property.c: _vconf_cb(210) > [_vconf_cb:210:W] property 100 is changed to 0
07-14 15:40:42.110+0900 W/LOCKSCREEN(  573): daemon.c: lockd_event(904) > [lockd_event:904:W] event:40000:CONF_CHANGED
07-14 15:40:42.110+0900 W/LOCKSCREEN(  573): daemon.c: _event_route(723) > [_event_route:723:W] event:40000 event_info:100
07-14 15:40:42.110+0900 W/LOCKSCREEN(  573): view-mgr.c: _event_route(108) > [_event_route:108:W] event:40000 event_info:100
07-14 15:40:42.120+0900 W/BatteryStatsImpl( 2102): Couldn't get kernel wake lock stats
07-14 15:40:42.150+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:40:42.150+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:40:42.150+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:40:42.150+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:40:42.150+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 387 5 28 25"
07-14 15:40:42.160+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:40:42.160+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:40:42.160+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:40:42.160+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:40:42.160+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 707 5 28 25"
07-14 15:40:42.230+0900 W/ProcessStats( 2102): Skipping unknown process pid 3615
07-14 15:40:42.230+0900 W/ProcessStats( 2102): Skipping unknown process pid 3619
07-14 15:40:44.050+0900 E/VCONF   (  406): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/usb_connection_mode) step(-21) failed(2 / No such file or directory)
07-14 15:40:44.050+0900 E/VCONF   (  406): vconf.c: _vconf_get_key(2111) > db/setting/usb_connection_mode : read buf error(-21). break
07-14 15:40:44.050+0900 E/VCONF   (  406): vconf.c: vconf_get_int(2379) > vconf_get_int(406) : db/setting/usb_connection_mode error
07-14 15:40:44.120+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-14 15:40:44.120+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-14 15:40:44.120+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_task_manager.c: __release_power_lock(671) > [0;35m* Info * power lock is already released![0;m
07-14 15:40:44.120+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_main.c: ___g_destroy_timer_expire_cb(263) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
07-14 15:40:44.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 15:40:44.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 15:40:44.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 15:40:44.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 15:40:44.130+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_notification_manager.c: __event_handler(639) > [0;35m* Info * -----------Notification manager exited-----------[0;m
07-14 15:40:44.140+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_main.c: _cloud_content_sync_deactivate(250) > [0;35m* Info * exiting cloud-content-sync-server[0;m
07-14 15:40:44.140+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_main.c: __init_cloud_content_sync(429) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
07-14 15:40:44.140+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
07-14 15:40:44.160+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1810): media_content.c: media_content_disconnect(942) > [32m[1810]ref count changed to: 0
07-14 15:40:44.200+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1810): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(515) > [0;35m* Info * wait at join[0;m
07-14 15:40:44.200+0900 I/CLOUD_CONTENT_SYNC_TRANS( 1810): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
07-14 15:40:44.210+0900 I/CAPI_NETWORK_CONNECTION( 1810): connection.c: connection_destroy(379) > Destroy handle: 0xb893ddf0
07-14 15:40:44.220+0900 I/CAPI_NETWORK_CONNECTION( 1810): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-14 15:40:44.220+0900 I/CAPI_NETWORK_CONNECTION( 1810): connection.c: __connection_set_proxy_changed_callback(331) > Successfully de-registered(0)
07-14 15:40:44.240+0900 I/CAPI_APPFW_APPLICATION( 1810): service_app_main.c: service_app_exit_without_restart(108) > service_app_exit_without_restart
07-14 15:40:44.240+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 15:40:44.240+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(803) > app status : 7
07-14 15:40:44.240+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 15:40:44.240+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(803) > app status : 5
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: indicator_is_enable_to_insert_in_non_fixed_list(1697) > "[CAN_ADD_WITHOUT_DEL]"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] usb 0!"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: icon_box_pack(772) > "Pack to NOTI list : usb"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 387 5 28 25"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
07-14 15:40:44.340+0900 I/EFL-ASSIST(  490): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 116b9b0 (elm_image), color code: AO004, color [255, 255, 255, 255]
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 0 0 0 0"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: indicator_is_enable_to_insert_in_non_fixed_list(1711) > "[CAN_ADD_WITHOUT_DEL]"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] usb 1!"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: icon_box_pack(772) > "Pack to NOTI list : usb"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 707 5 28 25"
07-14 15:40:44.340+0900 I/indicator(  490): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
07-14 15:40:44.340+0900 I/EFL-ASSIST(  490): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 116c090 (elm_image), color code: AO004, color [255, 255, 255, 255]
07-14 15:40:44.340+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 0 0 0 0"
07-14 15:40:44.350+0900 I/AUL     ( 3751): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/popup-launcher, ret : 0
07-14 15:40:44.370+0900 I/AUL     ( 3751): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/dbus-daemon, ret : 0
07-14 15:40:44.390+0900 I/AUL     (  513): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
07-14 15:40:44.410+0900 I/AUL     (  513): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
07-14 15:40:44.470+0900 E/QUICKPANEL(  657): noti_led.c: _led_list_find_by_priv_id(118) > [_led_list_find_by_priv_id : 118] invalid parameter
07-14 15:40:44.470+0900 E/VCONF   (  657): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/blockingmode/led_indicator) step(-21) failed(2 / No such file or directory)
07-14 15:40:44.470+0900 E/VCONF   (  657): vconf.c: _vconf_get_key(2111) > db/setting/blockingmode/led_indicator : read buf error(-21). break
07-14 15:40:44.470+0900 E/VCONF   (  657): vconf.c: vconf_get_bool(2417) > vconf_get_bool(657) : db/setting/blockingmode/led_indicator error
07-14 15:40:44.470+0900 E/QUICKPANEL(  657): noti_led.c: _noti_led_off(231) > [_noti_led_off : 231] try to turn off LED
07-14 15:40:44.470+0900 E/QUICKPANEL(  657): noti_led.c: _noti_led_off(236) > [_noti_led_off : 236] failed led_set_mode:-1
07-14 15:40:44.470+0900 I/EFL-ASSIST(  657): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: b7c75f08 (elm_image), color code: W0661, color [0, 72, 163, 204]
07-14 15:40:44.470+0900 I/QUICKPANEL(  657): vi_manager.c: _vi_freeze_start(67) > [_vi_freeze_start : 67] VIM freezing
07-14 15:40:44.470+0900 I/QUICKPANEL(  657): noti.c: quickpanel_noti_set_clear_all_status(1457) > [quickpanel_noti_set_clear_all_status : 1457] NOTI SECTION CLEAR ALL HIDE
07-14 15:40:44.500+0900 E/VCONF   (  657): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/blockingmode/notifications) step(-21) failed(2 / No such file or directory)
07-14 15:40:44.500+0900 E/VCONF   (  657): vconf.c: _vconf_get_key(2111) > db/setting/blockingmode/notifications : read buf error(-21). break
07-14 15:40:44.500+0900 E/VCONF   (  657): vconf.c: vconf_get_bool(2417) > vconf_get_bool(657) : db/setting/blockingmode/notifications error
07-14 15:40:44.500+0900 E/QUICKPANEL(  657): ticker.c: _quickpanel_noti_media_feedback_sound(1191) > [_quickpanel_noti_media_feedback_sound : 1191] None type: No sound
07-14 15:40:44.500+0900 E/QUICKPANEL(  657): vi_manager.c: _vi_list_count(128) > [_vi_list_count : 128] list null
07-14 15:40:44.500+0900 I/QUICKPANEL(  657): vi_manager.c: _vi_freeze_stop(79) > [_vi_freeze_stop : 79] VIM unfreezing
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): property.c: _vconf_cb(210) > [_vconf_cb:210:W] property 400 is changed to 1
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): daemon.c: lockd_event(904) > [lockd_event:904:W] event:40000:CONF_CHANGED
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): daemon.c: _event_route(723) > [_event_route:723:W] event:40000 event_info:400
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): view-mgr.c: _event_route(108) > [_event_route:108:W] event:40000 event_info:400
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): property.c: _vconf_cb(210) > [_vconf_cb:210:W] property 100 is changed to 1
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): daemon.c: lockd_event(904) > [lockd_event:904:W] event:40000:CONF_CHANGED
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): daemon.c: _event_route(723) > [_event_route:723:W] event:40000 event_info:100
07-14 15:40:44.610+0900 W/LOCKSCREEN(  573): view-mgr.c: _event_route(108) > [_event_route:108:W] event:40000 event_info:100
07-14 15:40:44.660+0900 W/BatteryStatsImpl( 2102): Couldn't get kernel wake lock stats
07-14 15:40:44.670+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 15:40:44.670+0900 W/AUL_AMD (  455): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-14 15:40:44.670+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 1810
07-14 15:40:44.670+0900 W/AUL_AMD (  455): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 15:40:44.670+0900 I/Tizen::System( 1219): (246) > Terminated app [com.samsung.cloud-content-sync-server]
07-14 15:40:44.670+0900 I/Tizen::App( 1200): (243) > App[com.samsung.cloud-content-sync-server] pid[1810] terminate event is forwarded
07-14 15:40:44.670+0900 I/Tizen::System( 1200): (256) > osp.accessorymanager.service provider is found.
07-14 15:40:44.670+0900 I/Tizen::System( 1200): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync-server, 1810, ]
07-14 15:40:44.670+0900 I/Tizen::System( 1200): (256) > osp.system.service provider is found.
07-14 15:40:44.670+0900 I/Tizen::App( 1200): (506) > TerminatedApp(com.samsung.cloud-content-sync-server)
07-14 15:40:44.670+0900 I/Tizen::App( 1200): (512) > Not registered pid(1810)
07-14 15:40:44.670+0900 I/Tizen::App( 1200): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 1810.
07-14 15:40:44.670+0900 I/Tizen::Io( 1219): (729) > Entry not found
07-14 15:40:44.670+0900 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1810
07-14 15:40:44.680+0900 I/Tizen::System( 1219): (157) > change brightness system value.
07-14 15:40:44.680+0900 I/Tizen::App( 1219): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 1810.
07-14 15:40:44.690+0900 E/AUL     ( 3786): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
07-14 15:40:44.870+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3772): media_content.c: media_content_connect(854) > [32m[3772]ref count : 0
07-14 15:40:44.870+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3772): media_content.c: media_content_connect(886) > [32m[3772]ref count changed to: 1
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 359 5 28 25"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 311 679 5 28 25"
07-14 15:40:45.290+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
07-14 15:40:46.240+0900 W/AUL_AMD (  455): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 15:40:47.850+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 27
07-14 15:40:47.870+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 15:40:47.870+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(803) > app status : 5
07-14 15:40:47.870+0900 I/APP_CORE(  656): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-14 15:40:47.870+0900 I/CAPI_APPFW_APPLICATION(  656): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-14 15:40:47.970+0900 I/CAPI_NETWORK_CONNECTION(  656): connection.c: connection_destroy(379) > Destroy handle: 0xb7aae6f8
07-14 15:40:47.970+0900 I/CAPI_NETWORK_CONNECTION(  656): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-14 15:40:47.990+0900 I/EFL-ASSIST(  656): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b7a60488) is freed
07-14 15:40:47.990+0900 I/EFL-ASSIST(  656): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b7a4fc00) is freed
07-14 15:40:47.990+0900 E/TIZEN_N_SYSTEM_SETTINGS(  656): system_settings_vconf.c: system_setting_vconf_unset_changed_cb(278) > [system_setting_vconf_unset_changed_cb] vconf_ignore_key_changed : db/setting/accessibility/font_size --- ret = 0 --- callback ptr : b4cfddfd
07-14 15:40:47.990+0900 I/CAPI_APPFW_APPLICATION(  656): app_main.c: app_efl_exit(145) > app_efl_exit
07-14 15:40:48.000+0900 E/TBM_BACKEND(  656): tbm_bufmgr_sprd7727.c: tbm_sprd7727_bo_free(671) > [31m[data-provider-slave][libtbm-sprd7727:656] error tbm_sprd7727_bo_free:671
07-14 15:40:48.000+0900 E/TBM_BACKEND(  656): [0m
07-14 15:40:48.010+0900 I/AUL_PAD (  489): sigchild.h: __launchpad_sig_child(142) > dead_pid = 656 pgid = 656
07-14 15:40:48.010+0900 I/AUL_PAD (  489): sigchild.h: __sigchild_action(123) > dead_pid(656)
07-14 15:40:48.020+0900 I/AUL_PAD (  489): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-14 15:40:48.020+0900 I/AUL_PAD (  489): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-14 15:40:48.030+0900 I/Tizen::App( 1219): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 656.
07-14 15:40:48.030+0900 I/Tizen::App( 1200): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 656.
07-14 15:40:48.030+0900 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 656
07-14 15:40:49.870+0900 W/AUL_AMD (  455): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 15:40:57.340+0900 E/AUL_AMD (  455): amd_main.c: __platform_ready_handler(358) > [Info]__platform_ready_handler
07-14 15:40:59.990+0900 I/PowerManagerService-JNI( 2102): sending ACL screen state 'L'
07-14 15:41:00.010+0900 E/SurfaceFlinger( 2102): redraw failed: empty invalid region
07-14 15:41:00.010+0900 I/PowerManagerService-JNI( 2102): sending ACL screen state 'F'
07-14 15:41:00.010+0900 I/AclService( 1437): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:41:00.010+0900 I/Tizen::Base::Runtime( 1437): (251) > The timer is not started.
07-14 15:41:00.010+0900 I/Tizen::System( 1437): (85) > Current Epoch is -5265093565123088644.
07-14 15:41:00.010+0900 I/Tizen::System( 1437): (89) > Calendar time is sec:0, min:41, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:41:00.010+0900 I/Tizen::System( 1437): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:41:00.010+0900 I/Tizen::System( 1437): (103) > Original Time is 2015 7/14, 6:41:0:21
07-14 15:41:00.010+0900 I/Tizen::System( 1437): (123) > Current Time is 2015 7/14, 15:41:0
07-14 15:41:00.010+0900 I/AclService( 1437): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 73139979 milliseconds from now
07-14 15:41:00.020+0900 I/Tizen::System( 1437): (461) > change cpu power policy: keepAwake(true)
07-14 15:41:00.020+0900 I/AclService( 1437): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:41:00.020+0900 I/Tizen::System( 1437): (85) > Current Epoch is 1436856060.
07-14 15:41:00.020+0900 I/Tizen::System( 1437): (89) > Calendar time is sec:0, min:41, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:41:00.020+0900 I/Tizen::System( 1437): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:41:00.020+0900 I/Tizen::System( 1437): (103) > Original Time is 2015 7/14, 6:41:0:31
07-14 15:41:00.020+0900 I/Tizen::System( 1437): (123) > Current Time is 2015 7/14, 15:41:0
07-14 15:41:00.020+0900 I/AclService( 1437): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59969 milliseconds from now
07-14 15:41:00.030+0900 I/Tizen::System( 1437): (461) > change cpu power policy: keepAwake(false)
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:41:02.690+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:41:02.690+0900 D/tdlnaservice( 3093): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:41:02.700+0900 I/tdlna   ( 3093): _on_proxy_client_msg_received_cb 실행
07-14 15:41:02.700+0900 I/tdlna   ( 3093): _app_process_received_message 실행
07-14 15:41:02.700+0900 I/tdlna   ( 3093): test _ _app_process_received_message
07-14 15:41:02.700+0900 I/tdlna   ( 3093): _app_execute_operation 실행
07-14 15:41:02.700+0900 I/tdlna   ( 3093): test 실행
07-14 15:41:02.700+0900 I/tdlna   ( 3093): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:41:02.700+0900 I/tdlna   ( 3093): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:41:02.700+0900 I/tdlna   ( 3093): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:41:02.700+0900 I/tdlna   ( 3093): _app_send_response 실행
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:41:02.700+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:41:02.700+0900 D/tdlnaservice( 3093): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:41:02.700+0900 I/tdlna   ( 3093): Main Start !!! 1
07-14 15:41:02.700+0900 I/tdlna   ( 3093): Service Start !!! 1
07-14 15:41:02.700+0900 I/tdlna   ( 3093): shttpl - 17
07-14 15:41:02.700+0900 I/tdlna   ( 3093): fork 전
07-14 15:41:02.700+0900 I/tdlna   ( 3093): Main precess Start !! 3888
07-14 15:41:02.700+0900 I/tdlna   ( 3888): fork child process 1
07-14 15:41:02.700+0900 I/tdlna   ( 3888): ssdp running
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:41:02.750+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:41:03.140+0900 W/CRASH_MANAGER( 3890): worker.c: worker_job(1236) > 110309374646c143685606
