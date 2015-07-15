S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 3519
Date: 2015-07-13 23:48:51+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x25d00000

Register Information
r0   = 0x25d00002, r1   = 0x25d00000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f564a6
r6   = 0xbea3a7c8, r7   = 0x25d00002
r8   = 0x0000001e, r9   = 0xb64754d0
r10  = 0xb6f56487, fp   = 0xbea3a7bc
ip   = 0x00000000, sp   = 0xbea3a258
lr   = 0xb6dc15b8, pc   = 0xb6df4d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     22104 KB
Buffers:     28188 KB
Cached:     280744 KB
VmPeak:      20672 KB
VmSize:      20668 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4940 KB
VmRSS:        4940 KB
VmData:       9804 KB
VmStk:         136 KB
VmExe:          48 KB
VmLib:        9144 KB
VmPTE:          20 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3519 TID = 3519
3519 3528 

Maps Information
b5c75000 b6478000 rwxp [stack:3528]
b6478000 b647b000 r-xp /lib/libgpg-error.so.0.5.0
b6482000 b6483000 rwxp /lib/libgpg-error.so.0.5.0
b6483000 b64db000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64e2000 b64e5000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64e6000 b6512000 r-xp /usr/lib/libsystemd.so.0.0.1
b6519000 b651a000 r-xp /usr/lib/libsystemd.so.0.0.1
b651a000 b651b000 rwxp /usr/lib/libsystemd.so.0.0.1
b651b000 b651d000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6524000 b6525000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6525000 b65f0000 r-xp /usr/lib/libxml2.so.2.7.8
b65f8000 b65fd000 rwxp /usr/lib/libxml2.so.2.7.8
b65fe000 b660e000 r-xp /lib/libresolv-2.13.so
b660e000 b660f000 r-xp /lib/libresolv-2.13.so
b660f000 b6610000 rwxp /lib/libresolv-2.13.so
b6613000 b6629000 r-xp /lib/libz.so.1.2.5
b6630000 b6631000 rwxp /lib/libz.so.1.2.5
b6631000 b6633000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b663a000 b663b000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b663b000 b6640000 r-xp /usr/lib/libffi.so.5.0.10
b6647000 b6648000 rwxp /usr/lib/libffi.so.5.0.10
b6648000 b6649000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6650000 b6651000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6651000 b66b6000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66bd000 b66c0000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66c1000 b66c4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66cb000 b66cc000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66cc000 b6874000 r-xp /usr/lib/libcrypto.so.1.0.0
b687b000 b6890000 rwxp /usr/lib/libcrypto.so.1.0.0
b6894000 b68aa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68b1000 b68b2000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b68b2000 b68e6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68ed000 b68ef000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68ef000 b69c3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69cb000 b69ce000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69d0000 b69d4000 r-xp /usr/lib/libchromium.so.1.0
b69db000 b69dc000 rwxp /usr/lib/libchromium.so.1.0
b69dc000 b6a45000 r-xp /lib/libm-2.13.so
b6a4c000 b6a4d000 r-xp /lib/libm-2.13.so
b6a4d000 b6a4e000 rwxp /lib/libm-2.13.so
b6a4e000 b6a54000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a5b000 b6a5c000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a5c000 b6a7b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a82000 b6a83000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a83000 b6a86000 r-xp /usr/lib/libsmack.so.1.0.0
b6a8d000 b6a8e000 rwxp /usr/lib/libsmack.so.1.0.0
b6a8e000 b6a93000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a9b000 b6a9c000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a9c000 b6ac6000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6ace000 b6acf000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6acf000 b6ae6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6aee000 b6aef000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6aef000 b6b83000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b8b000 b6b8e000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b8e000 b6b90000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b96000 b6ba1000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6ba8000 b6ba9000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6ba9000 b6bae000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6bb6000 b6bb7000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6bb7000 b6c87000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c87000 b6c88000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c88000 b6cc8000 r-xp /usr/lib/libeina.so.1.7.99
b6ccf000 b6cd0000 rwxp /usr/lib/libeina.so.1.7.99
b6cd1000 b6ce7000 r-xp /usr/lib/libecore.so.1.7.99
b6cee000 b6cef000 rwxp /usr/lib/libecore.so.1.7.99
b6cfd000 b6d04000 r-xp /usr/lib/libvconf.so.0.2.45
b6d0c000 b6d0d000 rwxp /usr/lib/libvconf.so.0.2.45
b6d0d000 b6d12000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d19000 b6d1a000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d1a000 b6d25000 r-xp /usr/lib/libaul.so.0.1.0
b6d2d000 b6d2e000 rwxp /usr/lib/libaul.so.0.1.0
b6d2f000 b6d37000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d3e000 b6d3f000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d3f000 b6d41000 r-xp /lib/libdl-2.13.so
b6d48000 b6d49000 r-xp /lib/libdl-2.13.so
b6d49000 b6d4a000 rwxp /lib/libdl-2.13.so
b6d4a000 b6d55000 r-xp /lib/libunwind.so.8.0.1
b6d5c000 b6d5d000 rwxp /lib/libunwind.so.8.0.1
b6d82000 b6e9d000 r-xp /lib/libc-2.13.so
b6ea5000 b6ea7000 r-xp /lib/libc-2.13.so
b6ea7000 b6ea8000 rwxp /lib/libc-2.13.so
b6eab000 b6eb1000 r-xp /lib/librt-2.13.so
b6eb8000 b6eb9000 r-xp /lib/librt-2.13.so
b6eb9000 b6eba000 rwxp /lib/librt-2.13.so
b6eba000 b6ebc000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec3000 b6ec4000 rwxp /usr/lib/libdlog.so.0.0.0
b6ec4000 b6ec7000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ece000 b6ecf000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ecf000 b6ed2000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed9000 b6eda000 rwxp /usr/lib/libbundle.so.0.1.22
b6eda000 b6edd000 r-xp /usr/lib/libappcore-agent.so.1.1
b6ee4000 b6ee5000 rwxp /usr/lib/libappcore-agent.so.1.1
b6ee5000 b6ef9000 r-xp /lib/libpthread-2.13.so
b6f00000 b6f01000 r-xp /lib/libpthread-2.13.so
b6f01000 b6f02000 rwxp /lib/libpthread-2.13.so
b6f19000 b6f1d000 r-xp /usr/lib/libsys-assert.so
b6f25000 b6f26000 rwxp /usr/lib/libsys-assert.so
b6f26000 b6f43000 r-xp /lib/ld-2.13.so
b6f4a000 b6f4b000 r-xp /lib/ld-2.13.so
b6f4b000 b6f4c000 rwxp /lib/ld-2.13.so
b6f4c000 b6f58000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f60000 b6f62000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b759c000 b75db000 rwxp [heap]
bea1b000 bea3c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3519)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6df4d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6dc15b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e59b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ebb063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3d6 (0xb6f51083) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5083
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
JNI( 1613): sending ACL screen state 'L'
07-13 23:48:00.010+0900 I/PowerManagerService-JNI( 1613): sending ACL screen state 'F'
07-13 23:48:00.010+0900 E/SurfaceFlinger( 1613): redraw failed: empty invalid region
07-13 23:48:00.010+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:48:00.010+0900 I/Tizen::Base::Runtime( 1085): (251) > The timer is not started.
07-13 23:48:00.010+0900 I/Tizen::System( 1085): (85) > Current Epoch is -5265902805681188960.
07-13 23:48:00.010+0900 I/Tizen::System( 1085): (89) > Calendar time is sec:0, min:48, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:48:00.010+0900 I/Tizen::System( 1085): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:48:00.010+0900 I/Tizen::System( 1085): (103) > Original Time is 2015 7/13, 14:48:0:25
07-13 23:48:00.010+0900 I/Tizen::System( 1085): (123) > Current Time is 2015 7/13, 23:48:0
07-13 23:48:00.010+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 43919975 milliseconds from now
07-13 23:48:00.020+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(true)
07-13 23:48:00.020+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:48:00.020+0900 I/Tizen::System( 1085): (85) > Current Epoch is 1436798880.
07-13 23:48:00.020+0900 I/Tizen::System( 1085): (89) > Calendar time is sec:0, min:48, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:48:00.020+0900 I/Tizen::System( 1085): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:48:00.020+0900 I/Tizen::System( 1085): (103) > Original Time is 2015 7/13, 14:48:0:33
07-13 23:48:00.020+0900 I/Tizen::System( 1085): (123) > Current Time is 2015 7/13, 23:48:0
07-13 23:48:00.020+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59967 milliseconds from now
07-13 23:48:00.030+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(false)
07-13 23:48:05.010+0900 W/ProcessStats( 1613): Skipping unknown process pid 3194
07-13 23:48:05.010+0900 W/ProcessStats( 1613): Skipping unknown process pid 3200
07-13 23:48:08.910+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 12
07-13 23:48:09.120+0900 E/PKGMGR_INFO( 3200): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-13 23:48:09.200+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 1
07-13 23:48:09.200+0900 E/AUL_AMD (  446): amd_request.c: __request_handler(618) > no appinfo
07-13 23:48:09.210+0900 I/AUL     (  446): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-13 23:48:09.220+0900 E/AUL_AMD (  446): amd_launch.c: _start_app(1624) > no appinfo
07-13 23:48:09.220+0900 E/AUL_AMD (  446): amd_launch.c: __real_send(761) > send fail to client
07-13 23:48:09.500+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 1
07-13 23:48:09.500+0900 E/AUL_AMD (  446): amd_request.c: __request_handler(618) > no appinfo
07-13 23:48:09.510+0900 I/AUL     (  446): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-13 23:48:09.520+0900 E/AUL_AMD (  446): amd_launch.c: _start_app(1624) > no appinfo
07-13 23:48:09.520+0900 E/AUL_AMD (  446): amd_launch.c: __real_send(761) > send fail to client
07-13 23:48:09.810+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 1
07-13 23:48:09.810+0900 E/AUL_AMD (  446): amd_request.c: __request_handler(618) > no appinfo
07-13 23:48:09.810+0900 I/AUL     (  446): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-13 23:48:09.820+0900 E/AUL_AMD (  446): amd_launch.c: _start_app(1624) > no appinfo
07-13 23:48:09.820+0900 E/AUL_AMD (  446): amd_launch.c: __real_send(761) > send fail to client
07-13 23:48:10.130+0900 E/WRT_PLUGINS/TIZEN( 3200): ApplicationManager.cpp: OnRequestReceived(1094) > returns Not Found error
07-13 23:48:15.800+0900 W/BROWSER_PROVIDER( 1003): browser-provider-requests-manager.c: bp_thread_requests_manager(894) > Expire Idle state. No Client.
07-13 23:48:15.800+0900 W/BROWSER_PROVIDER( 1003): browser-provider-requests-manager.c: bp_thread_requests_manager(903) > terminate main thread ...
07-13 23:48:15.800+0900 W/BROWSER_PROVIDER( 1003): browser-provider-main.c: main(178) > Browser-Provider will be terminated.
07-13 23:48:26.660+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 27
07-13 23:48:26.670+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 22
07-13 23:48:26.670+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(803) > app status : 5
07-13 23:48:26.690+0900 I/APP_CORE(  646): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-13 23:48:26.690+0900 I/CAPI_APPFW_APPLICATION(  646): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-13 23:48:26.810+0900 I/CAPI_NETWORK_CONNECTION(  646): connection.c: connection_destroy(379) > Destroy handle: 0xb8c5d780
07-13 23:48:26.810+0900 I/CAPI_NETWORK_CONNECTION(  646): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-13 23:48:26.830+0900 I/EFL-ASSIST(  646): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8c0f590) is freed
07-13 23:48:26.830+0900 I/EFL-ASSIST(  646): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b8bfed08) is freed
07-13 23:48:26.830+0900 E/TIZEN_N_SYSTEM_SETTINGS(  646): system_settings_vconf.c: system_setting_vconf_unset_changed_cb(278) > [system_setting_vconf_unset_changed_cb] vconf_ignore_key_changed : db/setting/accessibility/font_size --- ret = 0 --- callback ptr : b4cf9dfd
07-13 23:48:26.830+0900 I/CAPI_APPFW_APPLICATION(  646): app_main.c: app_efl_exit(145) > app_efl_exit
07-13 23:48:26.840+0900 E/TBM_BACKEND(  646): tbm_bufmgr_sprd7727.c: tbm_sprd7727_bo_free(671) > [31m[data-provider-slave][libtbm-sprd7727:646] error tbm_sprd7727_bo_free:671
07-13 23:48:26.840+0900 E/TBM_BACKEND(  646): [0m
07-13 23:48:26.870+0900 I/AUL_PAD (  473): sigchild.h: __launchpad_sig_child(142) > dead_pid = 646 pgid = 646
07-13 23:48:26.870+0900 I/AUL_PAD (  473): sigchild.h: __sigchild_action(123) > dead_pid(646)
07-13 23:48:26.870+0900 I/AUL_PAD (  473): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 23:48:26.870+0900 I/AUL_PAD (  473): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 23:48:26.870+0900 I/Tizen::App(  957): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 646.
07-13 23:48:26.870+0900 I/Tizen::App(  988): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 646.
07-13 23:48:26.870+0900 I/AUL_AMD (  446): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 646
07-13 23:48:27.590+0900 D/dalvikvm( 1613): GC_CONCURRENT freed 1348K, 48% free 4236K/8071K, external 2131K/2656K, paused 3ms+3ms
07-13 23:48:28.670+0900 W/AUL_AMD (  446): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-13 23:48:31.220+0900 E/PKGMGR_SERVER( 3440): pkgmgr-server.c: main(1608) > server start
07-13 23:48:31.480+0900 E/rpm-installer( 3441): rpm-appcore-intf.c: main(197) > [/opt/usr/apps/tmp/org.tizen.tdlnaservice-1.0.0-arm.tpk] is tpk package.
07-13 23:48:31.510+0900 E/rpm-installer( 3441): rpm-installer-core.c: _rpm_installer_get_pkgname_info(297) > fisrt installation, pkgid=[org.tizen.tdlnaservice]
07-13 23:48:31.520+0900 I/Tizen::App(  988): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: install
07-13 23:48:31.520+0900 I/Tizen::App(  988): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [install], install = [96]
07-13 23:48:31.520+0900 I/Tizen::App(  957): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: install
07-13 23:48:31.520+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [install], install = [1]
07-13 23:48:31.520+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [install], install = [1]
07-13 23:48:31.530+0900 I/Tizen::App( 1085): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: install
07-13 23:48:31.530+0900 I/Tizen::App( 1085): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [install], install = [1]
07-13 23:48:31.530+0900 I/Tizen::App(  957): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-13 23:48:31.530+0900 I/Tizen::App(  957): (119) > InstallationInProgress [30]
07-13 23:48:31.530+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-13 23:48:31.530+0900 I/Tizen::App(  957): (119) > InstallationInProgress [30]
07-13 23:48:31.530+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-13 23:48:31.530+0900 I/Tizen::App(  988): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-13 23:48:31.530+0900 I/Tizen::App(  988): (119) > InstallationInProgress [30]
07-13 23:48:31.530+0900 I/Tizen::App(  988): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-13 23:48:31.540+0900 I/Tizen::App( 1085): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-13 23:48:31.540+0900 I/Tizen::App( 1085): (119) > InstallationInProgress [30]
07-13 23:48:31.540+0900 I/Tizen::App( 1085): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-13 23:48:32.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-13 23:48:32.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-13 23:48:32.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_task_manager.c: __release_power_lock(671) > [0;35m* Info * power lock is already released![0;m
07-13 23:48:32.310+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_main.c: ___g_destroy_timer_expire_cb(263) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_notification_manager.c: __event_handler(639) > [0;35m* Info * -----------Notification manager exited-----------[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_main.c: _cloud_content_sync_deactivate(250) > [0;35m* Info * exiting cloud-content-sync-server[0;m
07-13 23:48:32.330+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_main.c: __init_cloud_content_sync(429) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
07-13 23:48:32.340+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
07-13 23:48:32.340+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1184): media_content.c: media_content_disconnect(942) > [32m[1184]ref count changed to: 0
07-13 23:48:32.350+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1184): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(515) > [0;35m* Info * wait at join[0;m
07-13 23:48:32.350+0900 I/CLOUD_CONTENT_SYNC_TRANS( 1184): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
07-13 23:48:32.350+0900 I/CAPI_NETWORK_CONNECTION( 1184): connection.c: connection_destroy(379) > Destroy handle: 0xb7647380
07-13 23:48:32.350+0900 I/CAPI_NETWORK_CONNECTION( 1184): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-13 23:48:32.350+0900 I/CAPI_NETWORK_CONNECTION( 1184): connection.c: __connection_set_proxy_changed_callback(331) > Successfully de-registered(0)
07-13 23:48:32.360+0900 I/CAPI_APPFW_APPLICATION( 1184): service_app_main.c: service_app_exit_without_restart(108) > service_app_exit_without_restart
07-13 23:48:32.360+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 22
07-13 23:48:32.360+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(803) > app status : 7
07-13 23:48:32.360+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 22
07-13 23:48:32.360+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(803) > app status : 5
07-13 23:48:32.440+0900 E/PKGMGR_PARSER( 3441): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2397) > Manifest is Valid
07-13 23:48:32.450+0900 E/PKGMGR_PARSER( 3441): pkgmgr_parser_signature.c: __ps_check_mdm_policy(983) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-13 23:48:32.500+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 23
07-13 23:48:32.500+0900 W/AUL_AMD (  446): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-13 23:48:32.500+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 1184
07-13 23:48:32.500+0900 W/AUL_AMD (  446): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-13 23:48:32.510+0900 I/AUL_AMD (  446): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1184
07-13 23:48:32.510+0900 I/Tizen::System(  988): (246) > Terminated app [com.samsung.cloud-content-sync-server]
07-13 23:48:32.510+0900 I/Tizen::Io(  988): (729) > Entry not found
07-13 23:48:32.510+0900 I/Tizen::App(  957): (243) > App[com.samsung.cloud-content-sync-server] pid[1184] terminate event is forwarded
07-13 23:48:32.510+0900 I/Tizen::System(  957): (256) > osp.accessorymanager.service provider is found.
07-13 23:48:32.510+0900 I/Tizen::System(  957): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync-server, 1184, ]
07-13 23:48:32.510+0900 I/Tizen::System(  957): (256) > osp.system.service provider is found.
07-13 23:48:32.510+0900 I/Tizen::App(  957): (506) > TerminatedApp(com.samsung.cloud-content-sync-server)
07-13 23:48:32.510+0900 I/Tizen::App(  957): (512) > Not registered pid(1184)
07-13 23:48:32.510+0900 I/Tizen::App(  957): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 1184.
07-13 23:48:32.510+0900 I/Tizen::System(  988): (157) > change brightness system value.
07-13 23:48:32.510+0900 I/Tizen::App(  988): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 1184.
07-13 23:48:32.510+0900 E/AUL     ( 3454): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
07-13 23:48:32.520+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.530+0900 I/PRIVACY-MANAGER-CLIENT( 3441): SocketClient.cpp: SocketClient(37) > Client created
07-13 23:48:32.550+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.590+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.590+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.590+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.590+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.640+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.640+0900 E/PKGMGR_PLUGIN( 3441): pkgmgr_parser_plugin.c: __process_each_plugin(827) > (plugin_info->lib_handle == NULL) dlopen is failed lib_path
07-13 23:48:32.710+0900 E/AIL     ( 3441): ail_db.c: db_exec(244) > Cannot execute because table app_info already exists
07-13 23:48:32.710+0900 E/AIL     ( 3441): ail_db.c: db_exec(245) > query - CREATE TABLE app_info (package TEXT PRIMARY KEY, exec TEXT DEFAULT 'No Exec', name TEXT DEFAULT 'No Name', type TEXT DEFAULT 'Application', icon TEXT DEFAULT 'No Icon', categories TEXT, version TEXT, mimetype TEXT, x_slp_service TEXT, x_slp_packagetype TEXT, x_slp_packagecategories TEXT, x_slp_packageid TEXT, x_slp_uri TEXT, x_slp_svc TEXT, x_slp_exe_path TEXT, x_slp_appid TEXT, x_slp_pkgid TEXT, x_slp_domain TEXT, x_slp_submodemainid TEXT, x_slp_installedstorage TEXT, x_slp_baselayoutwidth INTEGER DEFAULT 0, x_slp_installedtime INTEGER DEFAULT 0, nodisplay INTEGER DEFAULT 0, x_slp_taskmanage INTEGER DEFAULT 1, x_slp_multiple INTEGER DEFAULT 0, x_slp_removable INTEGER DEFAULT 1, x_slp_ishorizontalscale INTEGER DEFAULT 0, x_slp_enabled INTEGER DEFAULT 1, x_slp_submode INTEGER DEFAULT 0, desktop TEXT UNIQUE NOT NULL);
07-13 23:48:32.710+0900 E/AIL     ( 3441): ail_desktop.c: _create_table(1187) > (ret != AIL_ERROR_OK) -> _create_table() return
07-13 23:48:32.760+0900 I/Tizen::App(  957): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-13 23:48:32.760+0900 I/Tizen::App(  957): (119) > InstallationInProgress [60]
07-13 23:48:32.760+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:48:32.760+0900 I/Tizen::App(  957): (119) > InstallationInProgress [60]
07-13 23:48:32.760+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:48:32.760+0900 I/Tizen::App(  988): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-13 23:48:32.760+0900 I/Tizen::App(  988): (119) > InstallationInProgress [60]
07-13 23:48:32.760+0900 I/Tizen::App(  988): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:48:32.760+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-13 23:48:32.760+0900 I/Tizen::App( 1085): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-13 23:48:32.760+0900 I/Tizen::App( 1085): (119) > InstallationInProgress [60]
07-13 23:48:32.760+0900 I/Tizen::App( 1085): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:48:32.770+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 120
07-13 23:48:32.770+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 120
07-13 23:48:32.770+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
07-13 23:48:32.770+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 33
07-13 23:48:32.770+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 35 33
07-13 23:48:32.770+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
07-13 23:48:32.790+0900 E/PKGMGR_CERT( 3441): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 23:48:32.790+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/res]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.tdlnaservice/shared], errno=[2][No such file or directory]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared/res]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/tizen-manifest.xml]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/author-signature.xml]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/signature1.xml]
07-13 23:48:32.800+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.tdlnaservice.xml]
07-13 23:48:33.120+0900 E/rpm-installer( 3441): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]))
07-13 23:48:33.450+0900 E/PKGMGR_SERVER( 3440): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:48:34.370+0900 W/AUL_AMD (  446): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-13 23:48:35.450+0900 E/PKGMGR_SERVER( 3440): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:48:35.670+0900 W/CAM_APP ( 1141): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 23:48:36.270+0900 I/Tizen::App( 1085): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:48:36.280+0900 I/Tizen::App(  988): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:48:36.280+0900 I/Tizen::App(  988): (119) > InstallationInProgress [100]
07-13 23:48:36.280+0900 I/Tizen::App(  988): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-13 23:48:36.280+0900 I/Tizen::App(  957): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:48:36.280+0900 I/Tizen::App(  957): (119) > InstallationInProgress [100]
07-13 23:48:36.280+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:48:36.280+0900 I/Tizen::App(  957): (119) > InstallationInProgress [100]
07-13 23:48:36.280+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:48:36.290+0900 I/Tizen::App(  988): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:48:36.290+0900 I/Tizen::App(  988): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:48:36.290+0900 I/Tizen::App(  988): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-13 23:48:36.290+0900 I/Tizen::App(  957): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:48:36.290+0900 I/Tizen::App(  957): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:48:36.290+0900 I/Tizen::App(  957): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-13 23:48:36.300+0900 E/cluster-home(  595): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 23:48:36.300+0900 E/cluster-home(  595): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 23:48:36.300+0900 E/cluster-home(  595): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 23:48:36.340+0900 I/Tizen::App(  957): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:48:36.400+0900 I/Tizen::App(  957): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-13 23:48:36.420+0900 E/cluster-home(  595): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-13 23:48:36.420+0900 E/cluster-home(  595): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 23:48:36.420+0900 I/Tizen::App(  957): (416) > appName = [tdlnaservice]
07-13 23:48:36.420+0900 E/cluster-home(  595): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-13 23:48:36.420+0900 I/Tizen::App(  957): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-13 23:48:36.420+0900 E/PKGMGR_INFO(  957): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 23:48:36.420+0900 I/Tizen::App(  957): (675) > Application count(1) in this package
07-13 23:48:36.420+0900 I/Tizen::App(  957): (855) > Enter.
07-13 23:48:36.420+0900 I/Tizen::App( 1085): (119) > InstallationInProgress [100]
07-13 23:48:36.420+0900 I/Tizen::App( 1085): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:48:36.430+0900 I/Tizen::App( 1085): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:48:36.430+0900 I/Tizen::App( 1085): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:48:36.430+0900 I/Tizen::App(  957): (416) > appName = [tdlnaservice]
07-13 23:48:36.430+0900 I/Tizen::App(  957): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-13 23:48:36.430+0900 I/Tizen::App(  957): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-13 23:48:36.430+0900 I/Tizen::App(  957): (131) > Enter
07-13 23:48:36.440+0900 I/Tizen::App(  957): (695) > Exit.
07-13 23:48:36.440+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-13 23:48:36.440+0900 I/Tizen::App(  957): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:48:36.440+0900 I/Tizen::App(  957): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-13 23:48:36.440+0900 I/Tizen::App(  957): (137) > org.tizen.tdlnaservice does not have launch condition
07-13 23:48:36.440+0900 I/Tizen::App(  957): (898) > Exit.
07-13 23:48:36.450+0900 I/Tizen::App( 1085): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:48:36.460+0900 I/Tizen::App( 1085): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-13 23:48:36.460+0900 I/Tizen::App( 1085): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:48:36.460+0900 I/Tizen::App( 1085): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:48:36.630+0900 W/CAM_APP ( 1141): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 23:48:36.640+0900 I/Tizen::System(  988): (280) > The screen has been turned on.
07-13 23:48:36.640+0900 I/Tizen::Io(  988): (729) > Entry not found
07-13 23:48:36.650+0900 I/Tizen::Shell( 1085): (73) > Enter.
07-13 23:48:36.650+0900 I/Tizen::Shell( 1085): (47) > Enter.
07-13 23:48:36.650+0900 I/Tizen::Shell( 1085): (93) > LockManager is constructed.
07-13 23:48:36.650+0900 I/Tizen::System(  988): (157) > change brightness system value.
07-13 23:48:36.650+0900 I/Tizen::Shell( 1085): (58) > Exit.
07-13 23:48:36.650+0900 I/Tizen::Shell( 1085): (81) > Exit.
07-13 23:48:36.650+0900 I/Tizen::Shell( 1085): (95) > Enter.
07-13 23:48:36.660+0900 I/Tizen::App( 1085): (109) > Succeeded in connecting service(osp.shell.ipcserver.lockmanager)
07-13 23:48:36.660+0900 I/Tizen::App(  957): (147) > _LockManagerStub::OnIpcClientConnected (clientId:1085)
07-13 23:48:36.660+0900 I/Tizen::App(  957): (124) > app(ACL111OMWW.AclService), clientId(1085)
07-13 23:48:37.450+0900 E/PKGMGR_SERVER( 3440): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 23:48:37.450+0900 E/PKGMGR_SERVER( 3440): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 23:48:39.560+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 12
07-13 23:48:39.710+0900 E/PKGMGR_INFO( 3200): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-13 23:48:39.740+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 1
07-13 23:48:39.750+0900 I/AUL     (  446): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-13 23:48:39.760+0900 W/AUL_AMD (  446): amd_launch.c: service_start(515) > child process: 3519
07-13 23:48:39.820+0900 W/AUL_AMD (  446): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 3519
07-13 23:48:39.830+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 12
07-13 23:48:39.830+0900 I/Tizen::App(  988): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 3519.
07-13 23:48:39.840+0900 I/Tizen::App(  957): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-13 23:48:39.840+0900 I/Tizen::App(  957): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 3519.
07-13 23:48:39.860+0900 I/tdlna   ( 3519): _on_create_cb 실행
07-13 23:48:39.860+0900 I/tdlna   ( 3519): _app_init 실행
07-13 23:48:39.860+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:48:39.870+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-13 23:48:39.870+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 3519
07-13 23:48:39.920+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:39.930+0900 D/tdlnaservice( 3519): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-13 23:48:39.930+0900 I/tdlna   ( 3519): _on_app_control_callback 실행
07-13 23:48:39.930+0900 I/tdlna   ( 3519): _app_timer_thread_func 실행
07-13 23:48:40.040+0900 E/PKGMGR_INFO( 3200): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-13 23:48:40.310+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:48:40.320+0900 I/AUL     (  386): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-13 23:48:40.320+0900 I/AUL     ( 3200): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-13 23:48:40.330+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-13 23:48:40.330+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 3200
07-13 23:48:40.340+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:48:40.360+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.370+0900 D/tdlnaservice( 3519): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-13 23:48:40.370+0900 I/tdlna   ( 3519): _on_proxy_client_msg_received_cb 실행
07-13 23:48:40.370+0900 I/tdlna   ( 3519): _app_process_received_message 실행
07-13 23:48:40.370+0900 I/tdlna   ( 3519): _app_execute_operation 실행
07-13 23:48:40.370+0900 I/tdlna   ( 3519): _app_send_response 실행
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:48:40.370+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.370+0900 D/tdlnaservice( 3519): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:48:40.410+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.430+0900 D/tdlnaservice( 3519): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-13 23:48:40.430+0900 I/tdlna   ( 3519): _on_proxy_client_msg_received_cb 실행
07-13 23:48:40.430+0900 I/tdlna   ( 3519): _app_process_received_message 실행
07-13 23:48:40.430+0900 I/tdlna   ( 3519): _app_execute_operation 실행
07-13 23:48:40.430+0900 D/tdlnaservice( 3519): main-app.c: _app_execute_operation(288) > Request to start timer
07-13 23:48:40.430+0900 I/tdlna   ( 3519): _app_run_timer 실행
07-13 23:48:40.430+0900 I/tdlna   ( 3519): _app_run_timer 실행
07-13 23:48:40.430+0900 I/tdlna   ( 3519): _app_send_response 실행
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:48:40.430+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.430+0900 D/tdlnaservice( 3519): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:48:40.440+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:40.520+0900 W/AUL_AMD (  446): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 23:48:40.520+0900 I/AUL     (  446): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 23:48:40.530+0900 I/AUL     (  446): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 23:48:40.530+0900 E/AUL_AMD (  446): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 23:48:40.540+0900 W/AUL_AMD (  446): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 0, pid: 3519
07-13 23:48:40.540+0900 I/tdlna   ( 3519): _on_app_control_callback 실행
07-13 23:48:40.550+0900 E/AUL_AMD (  446): amd_launch.c: __real_send(761) > send fail to client
07-13 23:48:40.550+0900 W/AUL_AMD (  446): amd_launch.c: __reply_handler(851) > listen fd(34) , send fd(33), pid(3519), cmd(0)
07-13 23:48:42.880+0900 E/AUL_AMD (  446): amd_main.c: __platform_ready_handler(358) > [Info]__platform_ready_handler
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:48:47.040+0900 I/MESSAGE_PORT(  386): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:48:47.040+0900 D/tdlnaservice( 3519): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-13 23:48:47.040+0900 I/tdlna   ( 3519): _on_proxy_client_msg_received_cb 실행
07-13 23:48:47.040+0900 I/tdlna   ( 3519): _app_process_received_message 실행
07-13 23:48:47.040+0900 I/tdlna   ( 3519): test _ _app_process_received_message
07-13 23:48:47.040+0900 I/tdlna   ( 3519): _app_execute_operation 실행
07-13 23:48:47.040+0900 I/tdlna   ( 3519): test 실행
07-13 23:48:47.040+0900 I/tdlna   ( 3519): ★★★★★ 서비스 가동중 ★★★★★ 1
07-13 23:48:47.040+0900 I/tdlna   ( 3519): Main Start !!! 1
07-13 23:48:47.040+0900 I/tdlna   ( 3519): Service Start !!! 1
07-13 23:48:47.040+0900 I/tdlna   ( 3519): fork 전
07-13 23:48:47.040+0900 I/tdlna   ( 3570): fork child process 1
07-13 23:48:47.040+0900 I/tdlna   ( 3570): ssdp running
07-13 23:48:49.240+0900 I/tdlna   ( 3570): ssdp running
07-13 23:48:51.450+0900 I/tdlna   ( 3570): ssdp running
07-13 23:48:51.840+0900 W/CRASH_MANAGER( 3588): worker.c: worker_job(1236) > 110351974646c143679893
