S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 31101
Date: 2015-07-14 15:21:01+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1ddf0000

Register Information
r0   = 0x1ddf0002, r1   = 0x1ddf0000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f14638
r6   = 0xb5c30458, r7   = 0x1ddf0002
r8   = 0x0000001e, r9   = 0xb5c316f0
r10  = 0xb6f14619, fp   = 0xb5c3044c
ip   = 0x00000000, sp   = 0xb5c2fee8
lr   = 0xb6d7f5b8, pc   = 0xb6db2d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     30804 KB
Buffers:     32972 KB
Cached:     268036 KB
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
PID = 31101 TID = 31310
31101 31102 31310 

Maps Information
b5433000 b5c32000 rwxp [stack:31310]
b5c33000 b6436000 rwxp [stack:31102]
b6436000 b6439000 r-xp /lib/libgpg-error.so.0.5.0
b6440000 b6441000 rwxp /lib/libgpg-error.so.0.5.0
b6441000 b6499000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64a0000 b64a3000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64a4000 b64d0000 r-xp /usr/lib/libsystemd.so.0.0.1
b64d7000 b64d8000 r-xp /usr/lib/libsystemd.so.0.0.1
b64d8000 b64d9000 rwxp /usr/lib/libsystemd.so.0.0.1
b64d9000 b64db000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b64e2000 b64e3000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b64e3000 b65ae000 r-xp /usr/lib/libxml2.so.2.7.8
b65b6000 b65bb000 rwxp /usr/lib/libxml2.so.2.7.8
b65bc000 b65cc000 r-xp /lib/libresolv-2.13.so
b65cc000 b65cd000 r-xp /lib/libresolv-2.13.so
b65cd000 b65ce000 rwxp /lib/libresolv-2.13.so
b65d1000 b65e7000 r-xp /lib/libz.so.1.2.5
b65ee000 b65ef000 rwxp /lib/libz.so.1.2.5
b65ef000 b65f1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b65f8000 b65f9000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b65f9000 b65fe000 r-xp /usr/lib/libffi.so.5.0.10
b6605000 b6606000 rwxp /usr/lib/libffi.so.5.0.10
b6606000 b6607000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b660e000 b660f000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b660f000 b6674000 r-xp /usr/lib/libsqlite3.so.0.8.6
b667b000 b667e000 rwxp /usr/lib/libsqlite3.so.0.8.6
b667f000 b6682000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6689000 b668a000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b668a000 b6832000 r-xp /usr/lib/libcrypto.so.1.0.0
b6839000 b684e000 rwxp /usr/lib/libcrypto.so.1.0.0
b6852000 b6868000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b686f000 b6870000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6870000 b68a4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68ab000 b68ad000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68ad000 b6981000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6989000 b698c000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b698e000 b6992000 r-xp /usr/lib/libchromium.so.1.0
b6999000 b699a000 rwxp /usr/lib/libchromium.so.1.0
b699a000 b6a03000 r-xp /lib/libm-2.13.so
b6a0a000 b6a0b000 r-xp /lib/libm-2.13.so
b6a0b000 b6a0c000 rwxp /lib/libm-2.13.so
b6a0c000 b6a12000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a19000 b6a1a000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a1a000 b6a39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a40000 b6a41000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a41000 b6a44000 r-xp /usr/lib/libsmack.so.1.0.0
b6a4b000 b6a4c000 rwxp /usr/lib/libsmack.so.1.0.0
b6a4c000 b6a51000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a59000 b6a5a000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a5a000 b6a84000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6a8c000 b6a8d000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6a8d000 b6aa4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6aac000 b6aad000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6aad000 b6b41000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b49000 b6b4c000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b4c000 b6b4e000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b54000 b6b5f000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6b66000 b6b67000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6b67000 b6b6c000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b74000 b6b75000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6b75000 b6c45000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c45000 b6c46000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c46000 b6c86000 r-xp /usr/lib/libeina.so.1.7.99
b6c8d000 b6c8e000 rwxp /usr/lib/libeina.so.1.7.99
b6c8f000 b6ca5000 r-xp /usr/lib/libecore.so.1.7.99
b6cac000 b6cad000 rwxp /usr/lib/libecore.so.1.7.99
b6cbb000 b6cc2000 r-xp /usr/lib/libvconf.so.0.2.45
b6cca000 b6ccb000 rwxp /usr/lib/libvconf.so.0.2.45
b6ccb000 b6cd0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cd7000 b6cd8000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cd8000 b6ce3000 r-xp /usr/lib/libaul.so.0.1.0
b6ceb000 b6cec000 rwxp /usr/lib/libaul.so.0.1.0
b6ced000 b6cf5000 r-xp /lib/libgcc_s-4.6.4.so.1
b6cfc000 b6cfd000 rwxp /lib/libgcc_s-4.6.4.so.1
b6cfd000 b6cff000 r-xp /lib/libdl-2.13.so
b6d06000 b6d07000 r-xp /lib/libdl-2.13.so
b6d07000 b6d08000 rwxp /lib/libdl-2.13.so
b6d08000 b6d13000 r-xp /lib/libunwind.so.8.0.1
b6d1a000 b6d1b000 rwxp /lib/libunwind.so.8.0.1
b6d40000 b6e5b000 r-xp /lib/libc-2.13.so
b6e63000 b6e65000 r-xp /lib/libc-2.13.so
b6e65000 b6e66000 rwxp /lib/libc-2.13.so
b6e69000 b6e6f000 r-xp /lib/librt-2.13.so
b6e76000 b6e77000 r-xp /lib/librt-2.13.so
b6e77000 b6e78000 rwxp /lib/librt-2.13.so
b6e78000 b6e7a000 r-xp /usr/lib/libdlog.so.0.0.0
b6e81000 b6e82000 rwxp /usr/lib/libdlog.so.0.0.0
b6e82000 b6e85000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6e8c000 b6e8d000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6e8d000 b6e90000 r-xp /usr/lib/libbundle.so.0.1.22
b6e97000 b6e98000 rwxp /usr/lib/libbundle.so.0.1.22
b6e98000 b6e9b000 r-xp /usr/lib/libappcore-agent.so.1.1
b6ea2000 b6ea3000 rwxp /usr/lib/libappcore-agent.so.1.1
b6ea3000 b6eb7000 r-xp /lib/libpthread-2.13.so
b6ebe000 b6ebf000 r-xp /lib/libpthread-2.13.so
b6ebf000 b6ec0000 rwxp /lib/libpthread-2.13.so
b6ed7000 b6edb000 r-xp /usr/lib/libsys-assert.so
b6ee3000 b6ee4000 rwxp /usr/lib/libsys-assert.so
b6ee4000 b6f01000 r-xp /lib/ld-2.13.so
b6f08000 b6f09000 r-xp /lib/ld-2.13.so
b6f09000 b6f0a000 rwxp /lib/ld-2.13.so
b6f0a000 b6f17000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f1e000 b6f20000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b8e25000 b8e6a000 rwxp [heap]
beae8000 beb09000 rwxp [stack]
End of Maps Information

Callstack Information (PID:31101)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6db2d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6d7f5b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e17b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6e79063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3f6 (0xb6f0f10f) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x510f
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
_candidate, ret : 0
07-14 15:20:12.386+0900 E/AUL     (30923): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:20:12.386+0900 E/AUL     (30923): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:20:12.406+0900 I/AUL     (30923): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:20:12.416+0900 I/AUL     (30923): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:20:12.416+0900 E/AUL     (30923): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:20:12.416+0900 E/AUL     (30923): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:20:12.426+0900 I/AUL     (30923): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:20:12.436+0900 I/AUL     (30923): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:20:12.436+0900 E/AUL     (30923): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:20:12.436+0900 E/AUL     (30923): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:20:12.446+0900 I/AUL     (30923): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:20:12.456+0900 I/AUL     (30923): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:20:12.456+0900 E/AUL     (30923): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:20:12.456+0900 E/AUL     (30923): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:20:12.976+0900 E/WEBKIT  (27232): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 15:20:13.796+0900 E/PKGMGR_SERVER(31017): pkgmgr-server.c: main(1608) > server start
07-14 15:20:13.856+0900 E/PKGMGR  (31017): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.tdlnaservice]
07-14 15:20:13.856+0900 E/PKGMGR_SERVER(31017): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.tdlnaservice 
07-14 15:20:13.856+0900 E/PKGMGR_SERVER(31017): [0;m
07-14 15:20:14.026+0900 I/Tizen::App(  928): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 15:20:14.026+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 15:20:14.026+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 15:20:14.026+0900 I/Tizen::App(  969): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 15:20:14.026+0900 I/Tizen::App(  969): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 15:20:14.036+0900 W/AUL_AMD (  452): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-14 15:20:14.036+0900 I/Tizen::App( 1065): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 15:20:14.036+0900 I/Tizen::App( 1065): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [96]
07-14 15:20:14.046+0900 I/Tizen::App(  969): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 15:20:14.046+0900 I/Tizen::App(  969): (119) > InstallationInProgress [30]
07-14 15:20:14.046+0900 I/Tizen::App(  969): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 15:20:14.046+0900 I/Tizen::App(  928): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 15:20:14.046+0900 I/Tizen::App(  928): (119) > InstallationInProgress [30]
07-14 15:20:14.046+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 15:20:14.046+0900 I/Tizen::App(  928): (119) > InstallationInProgress [30]
07-14 15:20:14.046+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 15:20:14.046+0900 I/Tizen::App( 1065): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 15:20:14.046+0900 I/Tizen::App( 1065): (119) > InstallationInProgress [30]
07-14 15:20:14.046+0900 I/Tizen::App( 1065): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-14 15:20:14.276+0900 I/MALI    (27232): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xa75720] swap changed from async to sync
07-14 15:20:14.736+0900 I/Tizen::App(  969): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 15:20:14.736+0900 I/Tizen::App(  969): (119) > InstallationInProgress [60]
07-14 15:20:14.736+0900 I/Tizen::App(  969): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [96]
07-14 15:20:14.736+0900 I/Tizen::App(  928): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 15:20:14.736+0900 I/Tizen::App(  928): (119) > InstallationInProgress [60]
07-14 15:20:14.736+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 15:20:14.736+0900 I/Tizen::App(  928): (119) > InstallationInProgress [60]
07-14 15:20:14.736+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-14 15:20:14.746+0900 I/Tizen::App( 1065): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 15:20:14.746+0900 I/Tizen::App( 1065): (119) > InstallationInProgress [60]
07-14 15:20:14.746+0900 I/Tizen::App( 1065): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [96]
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 120
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 120
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 33
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 35 33
07-14 15:20:14.746+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
07-14 15:20:14.766+0900 E/PKGMGR_CERT(31018): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/res]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.tdlnaservice/shared], errno=[2][No such file or directory]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared/res]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/tizen-manifest.xml]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/author-signature.xml]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/signature1.xml]
07-14 15:20:14.776+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.tdlnaservice.xml]
07-14 15:20:16.036+0900 E/rpm-installer(31018): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]))
07-14 15:20:16.536+0900 E/PKGMGR_SERVER(31017): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-14 15:20:17.086+0900 W/CAM_APP ( 1291): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 15:20:17.596+0900 E/PKGMGR_INFO(31018): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-14 15:20:17.596+0900 E/PKGMGR_INSTALLER(31018): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-14 15:20:17.606+0900 E/cluster-home(  593): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-14 15:20:17.606+0900 E/cluster-home(  593): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-14 15:20:17.606+0900 E/cluster-home(  593): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-14 15:20:17.626+0900 I/Tizen::App(  969): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 15:20:17.626+0900 I/Tizen::App(  969): (119) > InstallationInProgress [100]
07-14 15:20:17.626+0900 I/Tizen::App(  969): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 15:20:17.626+0900 I/Tizen::App(  969): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 15:20:17.626+0900 I/Tizen::App(  969): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:20:17.626+0900 I/Tizen::App(  969): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 15:20:17.626+0900 I/Tizen::App(  928): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 15:20:17.626+0900 I/Tizen::App(  928): (119) > InstallationInProgress [100]
07-14 15:20:17.626+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 15:20:17.626+0900 I/Tizen::App(  928): (119) > InstallationInProgress [100]
07-14 15:20:17.626+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 15:20:17.626+0900 I/Tizen::App(  928): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 15:20:17.626+0900 I/Tizen::App(  928): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:20:17.626+0900 I/Tizen::App(  928): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-14 15:20:17.636+0900 I/Tizen::App(  928): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 15:20:17.666+0900 E/cluster-home(  593): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-14 15:20:17.666+0900 E/cluster-home(  593): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-14 15:20:17.666+0900 E/cluster-home(  593): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-14 15:20:17.666+0900 I/Tizen::App(  928): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-14 15:20:17.676+0900 I/Tizen::App( 1065): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 15:20:17.676+0900 I/Tizen::App( 1065): (119) > InstallationInProgress [100]
07-14 15:20:17.676+0900 I/Tizen::App( 1065): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-14 15:20:17.676+0900 I/Tizen::App( 1065): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 15:20:17.686+0900 I/Tizen::App( 1065): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:20:17.686+0900 I/Tizen::App(  928): (416) > appName = [tdlnaservice]
07-14 15:20:17.686+0900 I/Tizen::App(  928): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 15:20:17.686+0900 E/PKGMGR_INFO(  928): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-14 15:20:17.686+0900 I/Tizen::App(  928): (675) > Application count(1) in this package
07-14 15:20:17.686+0900 I/Tizen::App(  928): (855) > Enter.
07-14 15:20:17.696+0900 I/Tizen::App(  928): (695) > Exit.
07-14 15:20:17.696+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-14 15:20:17.696+0900 I/Tizen::App(  928): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:20:17.696+0900 I/Tizen::App(  928): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 15:20:17.696+0900 I/Tizen::App(  928): (416) > appName = [tdlnaservice]
07-14 15:20:17.696+0900 I/Tizen::App(  928): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 15:20:17.696+0900 I/Tizen::App(  928): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-14 15:20:17.696+0900 I/Tizen::App(  928): (131) > Enter
07-14 15:20:17.706+0900 I/Tizen::App(  928): (137) > org.tizen.tdlnaservice does not have launch condition
07-14 15:20:17.706+0900 I/Tizen::App(  928): (898) > Exit.
07-14 15:20:17.706+0900 I/Tizen::App( 1065): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 15:20:17.716+0900 I/Tizen::App( 1065): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-14 15:20:17.726+0900 I/Tizen::App( 1065): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 15:20:17.726+0900 I/Tizen::App( 1065): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 15:20:18.536+0900 E/PKGMGR_SERVER(31017): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 15:20:18.536+0900 E/PKGMGR_SERVER(31017): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 15:20:19.616+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 15:20:19.626+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-14 15:20:19.636+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-14 15:20:19.636+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 15:20:19.646+0900 W/AUL_AMD (  452): amd_launch.c: service_start(515) > child process: 31101
07-14 15:20:19.696+0900 W/AUL_AMD (  452): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 31101
07-14 15:20:19.726+0900 I/tdlna   (31101): _on_create_cb 실행
07-14 15:20:19.726+0900 I/Tizen::App(  969): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 31101.
07-14 15:20:19.726+0900 I/Tizen::App(  928): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 15:20:19.736+0900 I/tdlna   (31101): _app_init 실행
07-14 15:20:19.736+0900 I/Tizen::App(  928): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 31101.
07-14 15:20:19.736+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 31101
07-14 15:20:19.746+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:19.746+0900 D/tdlnaservice(31101): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 15:20:19.766+0900 I/tdlna   (31101): _on_app_control_callback 실행
07-14 15:20:19.766+0900 I/tdlna   (31101): _app_timer_thread_func 실행
07-14 15:20:23.846+0900 I/Tizen::System(  969): (280) > The screen has been turned on.
07-14 15:20:23.846+0900 I/Tizen::Io(  969): (729) > Entry not found
07-14 15:20:23.846+0900 W/CAM_APP ( 1291): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 15:20:23.846+0900 W/STARTER (  513): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
07-14 15:20:23.846+0900 W/STARTER (  513): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
07-14 15:20:23.856+0900 I/Tizen::System(  969): (157) > change brightness system value.
07-14 15:20:23.866+0900 I/Tizen::App(  928): (124) > app(ACL111OMWW.AclService), clientId(1065)
07-14 15:20:23.956+0900 W/STARTER (  513): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
07-14 15:20:23.976+0900 I/SYSPOPUP(  584): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-14 15:20:23.986+0900 I/SYSPOPUP(  584): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-14 15:20:23.986+0900 E/VOLUME  (  584): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-14 15:20:23.986+0900 E/VOLUME  (  584): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-14 15:20:23.986+0900 E/VOLUME  (  584): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-14 15:20:24.206+0900 W/STARTER (  513): hw_key.c: _homekey_timer_cb(404) > [_homekey_timer_cb:404] _homekey_timer_cb, homekey count[1], lock state[0]
07-14 15:20:24.226+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 15:20:24.226+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
07-14 15:20:24.226+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 15:20:24.246+0900 W/AUL_AMD (  452): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 0, pid: 593
07-14 15:20:24.256+0900 W/AUL_AMD (  452): amd_request.c: __send_home_launch_signal(441) > send a home launch signal
07-14 15:20:24.256+0900 I/CAPI_APPFW_APPLICATION(  593): app_main.c: app_appcore_reset(245) > app_appcore_reset
07-14 15:20:24.256+0900 I/APP_CORE(  593): appcore-efl.c: __do_app(516) > Legacy lifecycle: 1
07-14 15:20:24.276+0900 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(33) , send fd(32), pid(593), cmd(0)
07-14 15:20:24.276+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:20:24.276+0900 W/AUL_AMD (  452): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:20:24.296+0900 E/STARTER (  513): dbus-util.c: starter_dbus_home_raise_signal_send(168) > [starter_dbus_home_raise_signal_send:168] Sending HOME RAISE signal, result:0
07-14 15:20:24.316+0900 I/MALI    (27232): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xa75720] swap changed from sync to async
07-14 15:20:24.326+0900 W/PROCESSMGR(  361): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=593
07-14 15:20:24.336+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:20:24.346+0900 I/indicator(  498): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 593"
07-14 15:20:24.386+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:20:24.386+0900 I/Tizen::System(  969): (259) > Active app [com.samsun], current [rMfxc1AKe2] 
07-14 15:20:24.386+0900 I/Tizen::Io(  969): (729) > Entry not found
07-14 15:20:24.396+0900 I/Tizen::System( 1065): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
07-14 15:20:24.406+0900 I/Tizen::System(  969): (157) > change brightness system value.
07-14 15:20:24.446+0900 E/EFL     (27232): ewebkit2<27232> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 15:20:26.706+0900 I/MALI    (  593): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8307d10] swap changed from async to sync
07-14 15:20:27.276+0900 W/test-log(  593): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:20:27.276+0900 W/test-log(  593): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:20:27.276+0900 W/test-log(  593): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:20:27.276+0900 W/test-log(  593): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:20:27.276+0900 W/test-log(  593): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:20:28.886+0900 W/cluster-view(  593): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:20:29.736+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 15:20:29.756+0900 W/AUL_AMD (  452): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 1, pid: 27232
07-14 15:20:29.756+0900 W/AUL_AMD (  452): amd_launch.c: _resume_app(728) > resume done
07-14 15:20:29.806+0900 W/AUL_AMD (  452): amd_launch.c: __reply_handler(851) > listen fd(33) , send fd(32), pid(27232), cmd(3)
07-14 15:20:29.856+0900 W/PROCESSMGR(  361): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=27232
07-14 15:20:29.866+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:20:29.876+0900 I/indicator(  498): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 27232"
07-14 15:20:29.926+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:20:29.936+0900 I/Tizen::System( 1065): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:20:29.936+0900 I/MALI    (  593): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8307d10] swap changed from sync to async
07-14 15:20:29.956+0900 I/Tizen::System(  969): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 15:20:29.966+0900 I/CAPI_APPFW_APPLICATION(  593): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:20:29.966+0900 E/cluster-home(  593): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:20:29.976+0900 E/EFL     (27232): ewebkit2<27232> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 15:20:30.006+0900 I/Tizen::Io(  969): (729) > Entry not found
07-14 15:20:30.016+0900 I/Tizen::System(  969): (157) > change brightness system value.
07-14 15:20:32.306+0900 I/MALI    (27232): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xa75720] swap changed from async to sync
07-14 15:20:36.456+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:20:36.646+0900 E/PKGMGR_INFO(27282): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:20:36.896+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:20:36.896+0900 I/AUL     (27282): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:20:36.896+0900 I/AUL     (  388): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:20:36.906+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:20:36.906+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 27282
07-14 15:20:36.916+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:20:36.926+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.936+0900 D/tdlnaservice(31101): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:20:36.936+0900 I/tdlna   (31101): _on_proxy_client_msg_received_cb 실행
07-14 15:20:36.936+0900 I/tdlna   (31101): _app_process_received_message 실행
07-14 15:20:36.936+0900 I/tdlna   (31101): _app_execute_operation 실행
07-14 15:20:36.936+0900 I/tdlna   (31101): _app_send_response 실행
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:20:36.936+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.936+0900 D/tdlnaservice(31101): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:20:36.966+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.986+0900 D/tdlnaservice(31101): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:20:36.986+0900 I/tdlna   (31101): _on_proxy_client_msg_received_cb 실행
07-14 15:20:36.986+0900 I/tdlna   (31101): _app_process_received_message 실행
07-14 15:20:36.986+0900 I/tdlna   (31101): _app_execute_operation 실행
07-14 15:20:36.986+0900 D/tdlnaservice(31101): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 15:20:36.986+0900 I/tdlna   (31101): _app_run_timer 실행
07-14 15:20:36.986+0900 I/tdlna   (31101): _app_run_timer 실행
07-14 15:20:36.986+0900 I/tdlna   (31101): _app_send_response 실행
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:20:36.986+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:36.986+0900 D/tdlnaservice(31101): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:20:37.006+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:20:59.996+0900 I/PowerManagerService-JNI( 1307): sending ACL screen state 'L'
07-14 15:21:00.006+0900 E/SurfaceFlinger( 1307): redraw failed: empty invalid region
07-14 15:21:00.006+0900 I/PowerManagerService-JNI( 1307): sending ACL screen state 'F'
07-14 15:21:00.006+0900 I/AclService( 1065): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:21:00.006+0900 I/Tizen::Base::Runtime( 1065): (251) > The timer is not started.
07-14 15:21:00.016+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 27
07-14 15:21:00.016+0900 I/Tizen::System( 1065): (85) > Current Epoch is -5266272241588065716.
07-14 15:21:00.016+0900 I/Tizen::System( 1065): (89) > Calendar time is sec:0, min:21, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:21:00.016+0900 I/Tizen::System( 1065): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:21:00.026+0900 I/Tizen::System( 1065): (103) > Original Time is 2015 7/14, 6:21:0:22
07-14 15:21:00.026+0900 I/Tizen::System( 1065): (123) > Current Time is 2015 7/14, 15:21:0
07-14 15:21:00.026+0900 I/AclService( 1065): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 74339978 milliseconds from now
07-14 15:21:00.046+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 15:21:00.046+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(803) > app status : 5
07-14 15:21:00.046+0900 I/Tizen::System( 1065): (461) > change cpu power policy: keepAwake(true)
07-14 15:21:00.046+0900 I/AclService( 1065): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:21:00.046+0900 I/Tizen::System( 1065): (85) > Current Epoch is 1436854860.
07-14 15:21:00.046+0900 I/Tizen::System( 1065): (89) > Calendar time is sec:0, min:21, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:21:00.066+0900 I/Tizen::System( 1065): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:21:00.066+0900 I/Tizen::System( 1065): (103) > Original Time is 2015 7/14, 6:21:0:55
07-14 15:21:00.066+0900 I/APP_CORE(11022): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-14 15:21:00.066+0900 I/Tizen::System( 1065): (123) > Current Time is 2015 7/14, 15:21:0
07-14 15:21:00.066+0900 I/AclService( 1065): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59945 milliseconds from now
07-14 15:21:00.066+0900 I/CAPI_APPFW_APPLICATION(11022): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-14 15:21:00.076+0900 I/Tizen::System( 1065): (461) > change cpu power policy: keepAwake(false)
07-14 15:21:00.136+0900 I/CAPI_NETWORK_CONNECTION(11022): connection.c: connection_destroy(379) > Destroy handle: 0xb8299470
07-14 15:21:00.136+0900 I/CAPI_NETWORK_CONNECTION(11022): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-14 15:21:00.156+0900 I/EFL-ASSIST(11022): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b824f0f0) is freed
07-14 15:21:00.156+0900 I/EFL-ASSIST(11022): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b823e868) is freed
07-14 15:21:00.156+0900 E/TIZEN_N_SYSTEM_SETTINGS(11022): system_settings_vconf.c: system_setting_vconf_unset_changed_cb(278) > [system_setting_vconf_unset_changed_cb] vconf_ignore_key_changed : db/setting/accessibility/font_size --- ret = 0 --- callback ptr : b4d0ddfd
07-14 15:21:00.156+0900 I/CAPI_APPFW_APPLICATION(11022): app_main.c: app_efl_exit(145) > app_efl_exit
07-14 15:21:00.156+0900 E/TBM_BACKEND(11022): tbm_bufmgr_sprd7727.c: tbm_sprd7727_bo_free(671) > [31m[data-provider-slave][libtbm-sprd7727:11022] error tbm_sprd7727_bo_free:671
07-14 15:21:00.156+0900 E/TBM_BACKEND(11022): [0m
07-14 15:21:00.186+0900 I/AUL_PAD (  497): sigchild.h: __launchpad_sig_child(142) > dead_pid = 11022 pgid = 11022
07-14 15:21:00.186+0900 I/AUL_PAD (  497): sigchild.h: __sigchild_action(123) > dead_pid(11022)
07-14 15:21:00.186+0900 I/AUL_PAD (  497): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-14 15:21:00.186+0900 I/AUL_PAD (  497): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-14 15:21:00.196+0900 I/Tizen::App(  928): (243) > App[com.samsung.data-provider-slave] pid[11022] terminate event is forwarded
07-14 15:21:00.196+0900 I/Tizen::System(  969): (246) > Terminated app [com.samsung.data-provider-slave]
07-14 15:21:00.196+0900 I/Tizen::System(  928): (256) > osp.accessorymanager.service provider is found.
07-14 15:21:00.196+0900 I/Tizen::System(  928): (196) > Accessory Owner is removed [com.samsung.data-provider-slave, 11022, ]
07-14 15:21:00.196+0900 I/Tizen::System(  928): (256) > osp.system.service provider is found.
07-14 15:21:00.196+0900 I/Tizen::App(  928): (506) > TerminatedApp(com.samsung.data-provider-slave)
07-14 15:21:00.196+0900 I/Tizen::App(  928): (512) > Not registered pid(11022)
07-14 15:21:00.196+0900 I/Tizen::App(  928): (782) > Finished invoking application event listener for com.samsung.data-provider-slave, 11022.
07-14 15:21:00.196+0900 I/Tizen::Io(  969): (729) > Entry not found
07-14 15:21:00.196+0900 I/AUL_AMD (  452): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 11022
07-14 15:21:00.206+0900 I/Tizen::System(  969): (157) > change brightness system value.
07-14 15:21:00.206+0900 I/Tizen::App(  969): (782) > Finished invoking application event listener for com.samsung.data-provider-slave, 11022.
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:21:00.866+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:21:00.866+0900 D/tdlnaservice(31101): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:21:00.866+0900 I/tdlna   (31101): _on_proxy_client_msg_received_cb 실행
07-14 15:21:00.866+0900 I/tdlna   (31101): _app_process_received_message 실행
07-14 15:21:00.866+0900 I/tdlna   (31101): test _ _app_process_received_message
07-14 15:21:00.866+0900 I/tdlna   (31101): _app_execute_operation 실행
07-14 15:21:00.866+0900 I/tdlna   (31101): test 실행
07-14 15:21:00.866+0900 I/tdlna   (31101): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:21:00.876+0900 I/tdlna   (31101): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:21:00.876+0900 I/tdlna   (31101): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:21:00.876+0900 I/tdlna   (31101): _app_send_response 실행
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:21:00.876+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:21:00.876+0900 D/tdlnaservice(31101): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:21:00.876+0900 I/tdlna   (31101): Main Start !!! 1
07-14 15:21:00.876+0900 I/tdlna   (31101): Service Start !!! 1
07-14 15:21:00.876+0900 I/tdlna   (31101): fork 전
07-14 15:21:00.876+0900 I/tdlna   (31311): fork child process 1
07-14 15:21:00.876+0900 I/tdlna   (31311): ssdp running
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:21:00.906+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:21:01.476+0900 W/CRASH_MANAGER(31316): worker.c: worker_job(1236) > 113110174646c143685486
