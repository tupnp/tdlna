S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 6616
Date: 2015-07-13 23:28:10+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe8d20000

Register Information
r0   = 0xe8d20002, r1   = 0xe8d20000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6ffa48a
r6   = 0xbe85c840, r7   = 0xe8d20002
r8   = 0x0000001e, r9   = 0xb65194d0
r10  = 0xb6ffa46b, fp   = 0xbe85c834
ip   = 0x00000000, sp   = 0xbe85c2d0
lr   = 0xb6e655b8, pc   = 0xb6e98d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     23448 KB
Buffers:     28440 KB
Cached:     274192 KB
VmPeak:      20696 KB
VmSize:      20692 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4960 KB
VmRSS:        4960 KB
VmData:       9828 KB
VmStk:         136 KB
VmExe:          48 KB
VmLib:        9144 KB
VmPTE:          22 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6616 TID = 6616
6616 6619 

Maps Information
b5d19000 b651c000 rwxp [stack:6619]
b651c000 b651f000 r-xp /lib/libgpg-error.so.0.5.0
b6526000 b6527000 rwxp /lib/libgpg-error.so.0.5.0
b6527000 b657f000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6586000 b6589000 rwxp /usr/lib/libgcrypt.so.11.5.3
b658a000 b65b6000 r-xp /usr/lib/libsystemd.so.0.0.1
b65bd000 b65be000 r-xp /usr/lib/libsystemd.so.0.0.1
b65be000 b65bf000 rwxp /usr/lib/libsystemd.so.0.0.1
b65bf000 b65c1000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65c8000 b65c9000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b65c9000 b6694000 r-xp /usr/lib/libxml2.so.2.7.8
b669c000 b66a1000 rwxp /usr/lib/libxml2.so.2.7.8
b66a2000 b66b2000 r-xp /lib/libresolv-2.13.so
b66b2000 b66b3000 r-xp /lib/libresolv-2.13.so
b66b3000 b66b4000 rwxp /lib/libresolv-2.13.so
b66b7000 b66cd000 r-xp /lib/libz.so.1.2.5
b66d4000 b66d5000 rwxp /lib/libz.so.1.2.5
b66d5000 b66d7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66de000 b66df000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66df000 b66e4000 r-xp /usr/lib/libffi.so.5.0.10
b66eb000 b66ec000 rwxp /usr/lib/libffi.so.5.0.10
b66ec000 b66ed000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66f4000 b66f5000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66f5000 b675a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6761000 b6764000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6765000 b6768000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b676f000 b6770000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6770000 b6918000 r-xp /usr/lib/libcrypto.so.1.0.0
b691f000 b6934000 rwxp /usr/lib/libcrypto.so.1.0.0
b6938000 b694e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6955000 b6956000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6956000 b698a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6991000 b6993000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6993000 b6a67000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a6f000 b6a72000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a74000 b6a78000 r-xp /usr/lib/libchromium.so.1.0
b6a7f000 b6a80000 rwxp /usr/lib/libchromium.so.1.0
b6a80000 b6ae9000 r-xp /lib/libm-2.13.so
b6af0000 b6af1000 r-xp /lib/libm-2.13.so
b6af1000 b6af2000 rwxp /lib/libm-2.13.so
b6af2000 b6af8000 r-xp /usr/lib/libappsvc.so.0.1.0
b6aff000 b6b00000 rwxp /usr/lib/libappsvc.so.0.1.0
b6b00000 b6b1f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b26000 b6b27000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6b27000 b6b2a000 r-xp /usr/lib/libsmack.so.1.0.0
b6b31000 b6b32000 rwxp /usr/lib/libsmack.so.1.0.0
b6b32000 b6b37000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b3f000 b6b40000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b40000 b6b6a000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b72000 b6b73000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b73000 b6b8a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b92000 b6b93000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b93000 b6c27000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c2f000 b6c32000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c32000 b6c34000 rwxp /usr/lib/libstdc++.so.6.0.16
b6c3a000 b6c45000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c4c000 b6c4d000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c4d000 b6c52000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c5a000 b6c5b000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c5b000 b6d2b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d2b000 b6d2c000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6d2c000 b6d6c000 r-xp /usr/lib/libeina.so.1.7.99
b6d73000 b6d74000 rwxp /usr/lib/libeina.so.1.7.99
b6d75000 b6d8b000 r-xp /usr/lib/libecore.so.1.7.99
b6d92000 b6d93000 rwxp /usr/lib/libecore.so.1.7.99
b6da1000 b6da8000 r-xp /usr/lib/libvconf.so.0.2.45
b6db0000 b6db1000 rwxp /usr/lib/libvconf.so.0.2.45
b6db1000 b6db6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6dbd000 b6dbe000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6dbe000 b6dc9000 r-xp /usr/lib/libaul.so.0.1.0
b6dd1000 b6dd2000 rwxp /usr/lib/libaul.so.0.1.0
b6dd3000 b6ddb000 r-xp /lib/libgcc_s-4.6.4.so.1
b6de2000 b6de3000 rwxp /lib/libgcc_s-4.6.4.so.1
b6de3000 b6de5000 r-xp /lib/libdl-2.13.so
b6dec000 b6ded000 r-xp /lib/libdl-2.13.so
b6ded000 b6dee000 rwxp /lib/libdl-2.13.so
b6dee000 b6df9000 r-xp /lib/libunwind.so.8.0.1
b6e00000 b6e01000 rwxp /lib/libunwind.so.8.0.1
b6e26000 b6f41000 r-xp /lib/libc-2.13.so
b6f49000 b6f4b000 r-xp /lib/libc-2.13.so
b6f4b000 b6f4c000 rwxp /lib/libc-2.13.so
b6f4f000 b6f55000 r-xp /lib/librt-2.13.so
b6f5c000 b6f5d000 r-xp /lib/librt-2.13.so
b6f5d000 b6f5e000 rwxp /lib/librt-2.13.so
b6f5e000 b6f60000 r-xp /usr/lib/libdlog.so.0.0.0
b6f67000 b6f68000 rwxp /usr/lib/libdlog.so.0.0.0
b6f68000 b6f6b000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f72000 b6f73000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f73000 b6f76000 r-xp /usr/lib/libbundle.so.0.1.22
b6f7d000 b6f7e000 rwxp /usr/lib/libbundle.so.0.1.22
b6f7e000 b6f81000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f88000 b6f89000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f89000 b6f9d000 r-xp /lib/libpthread-2.13.so
b6fa4000 b6fa5000 r-xp /lib/libpthread-2.13.so
b6fa5000 b6fa6000 rwxp /lib/libpthread-2.13.so
b6fbd000 b6fc1000 r-xp /usr/lib/libsys-assert.so
b6fc9000 b6fca000 rwxp /usr/lib/libsys-assert.so
b6fca000 b6fe7000 r-xp /lib/ld-2.13.so
b6fee000 b6fef000 r-xp /lib/ld-2.13.so
b6fef000 b6ff0000 rwxp /lib/ld-2.13.so
b6ff0000 b6ffc000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7004000 b7006000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7bf6000 b7c3b000 rwxp [heap]
be83d000 be85e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:6616)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e98d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e655b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6efdb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f5f063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3f0 (0xb6ff5091) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5091
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
t(390) > [_state_transit:390:W] state transit:5
07-13 23:24:56.900+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => PAUSE
07-13 23:24:56.910+0900 E/WALLPAPER_SERVICE_COMMON(  572): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 23:24:56.920+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-13 23:24:56.920+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-13 23:24:56.920+0900 W/LOCKSCREEN(  572): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-13 23:24:56.920+0900 W/PROCESSMGR(  417): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=572
07-13 23:24:56.940+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 23:24:56.940+0900 W/AUL_AMD (  454): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 23:24:56.940+0900 W/LOCKSCREEN(  572): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(0)
07-13 23:24:56.940+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-13 23:24:56.940+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-13 23:24:56.940+0900 I/CAPI_APPFW_APPLICATION(  572): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 23:24:56.940+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-13 23:24:56.950+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-13 23:24:56.970+0900 I/MALI    ( 5254): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0x20b2b80] swap changed from sync to async
07-13 23:24:56.980+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:24:57.000+0900 I/indicator(  497): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 572"
07-13 23:24:57.000+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:24:57.010+0900 I/Tizen::System( 1083): (101) > Active App is com.samsung.lockscreen. GetApp id ACL111OMWW.AclService
07-13 23:24:57.030+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [rMfxc1AKe2] 
07-13 23:24:57.030+0900 I/Tizen::Io( 1005): (729) > Entry not found
07-13 23:24:57.040+0900 I/Tizen::System( 1005): (157) > change brightness system value.
07-13 23:24:57.400+0900 W/LOCKSCREEN(  572): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-13 23:25:00.000+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'L'
07-13 23:25:00.010+0900 E/SurfaceFlinger( 1451): redraw failed: empty invalid region
07-13 23:25:00.020+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'F'
07-13 23:25:00.020+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:25:00.020+0900 I/Tizen::Base::Runtime( 1083): (251) > The timer is not started.
07-13 23:25:00.020+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797500.
07-13 23:25:00.020+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:25, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:25:00.020+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:25:00.020+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:25:0:22
07-13 23:25:00.020+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:25:0
07-13 23:25:00.020+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 45299978 milliseconds from now
07-13 23:25:00.020+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(true)
07-13 23:25:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:25:00.030+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797500.
07-13 23:25:00.030+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:25, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:25:00.030+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:25:00.030+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:25:0:30
07-13 23:25:00.030+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:25:0
07-13 23:25:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59970 milliseconds from now
07-13 23:25:00.030+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(false)
07-13 23:25:07.850+0900 D/dalvikvm( 1738): GC_EXPLICIT freed 19K, 50% free 2858K/5639K, external 1962K/2073K, paused 21ms
07-13 23:26:00.000+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:26:00.000+0900 I/Tizen::Base::Runtime( 1083): (251) > The timer is not started.
07-13 23:26:00.000+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797560.
07-13 23:26:00.000+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:26, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:26:00.000+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:26:00.000+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'L'
07-13 23:26:00.000+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:26:0:6
07-13 23:26:00.000+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:26:0
07-13 23:26:00.010+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 45239994 milliseconds from now
07-13 23:26:00.020+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'F'
07-13 23:26:00.020+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(true)
07-13 23:26:00.020+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:26:00.020+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797560.
07-13 23:26:00.020+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:26, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:26:00.030+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:26:00.030+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:26:0:28
07-13 23:26:00.030+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:26:0
07-13 23:26:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59972 milliseconds from now
07-13 23:26:00.030+0900 E/SurfaceFlinger( 1451): redraw failed: empty invalid region
07-13 23:26:00.040+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(false)
07-13 23:26:52.970+0900 D/dalvikvm( 1451): GC_CONCURRENT freed 778K, 46% free 4272K/7815K, external 2127K/2656K, paused 2ms+3ms
07-13 23:27:00.000+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:27:00.010+0900 I/Tizen::Base::Runtime( 1083): (251) > The timer is not started.
07-13 23:27:00.010+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797620.
07-13 23:27:00.010+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:27, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:27:00.010+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:27:00.010+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'L'
07-13 23:27:00.020+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:27:0:10
07-13 23:27:00.020+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:27:0
07-13 23:27:00.020+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 45179990 milliseconds from now
07-13 23:27:00.020+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'F'
07-13 23:27:00.030+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(true)
07-13 23:27:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:27:00.030+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797620.
07-13 23:27:00.030+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:27, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:27:00.030+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:27:00.030+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:27:0:30
07-13 23:27:00.030+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:27:0
07-13 23:27:00.030+0900 E/SurfaceFlinger( 1451): redraw failed: empty invalid region
07-13 23:27:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59970 milliseconds from now
07-13 23:27:00.040+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(false)
07-13 23:27:07.970+0900 D/dalvikvm( 1738): GC_EXPLICIT freed 14K, 50% free 2858K/5639K, external 1962K/2073K, paused 21ms
07-13 23:27:53.850+0900 E/PKGMGR_SERVER( 6420): pkgmgr-server.c: main(1608) > server start
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:27:53.950+0900 E/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-13 23:27:53.950+0900 E/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(5197) are closed. delete client info
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-13 23:27:53.950+0900 E/MESSAGE_PORT(  376): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  5197
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-13 23:27:53.950+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(601) > __request_handler: 23
07-13 23:27:53.950+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-13 23:27:53.950+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 5197
07-13 23:27:53.950+0900 W/AUL_AMD (  454): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-13 23:27:53.950+0900 I/Tizen::System( 1005): (246) > Terminated app [org.tizen.tdlnaservice]
07-13 23:27:53.950+0900 I/Tizen::App(  946): (243) > App[org.tizen.tdlnaservice] pid[5197] terminate event is forwarded
07-13 23:27:53.950+0900 I/Tizen::System(  946): (256) > osp.accessorymanager.service provider is found.
07-13 23:27:53.950+0900 I/Tizen::System(  946): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 5197, ]
07-13 23:27:53.950+0900 I/Tizen::System(  946): (256) > osp.system.service provider is found.
07-13 23:27:53.950+0900 I/Tizen::App(  946): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-13 23:27:53.950+0900 I/Tizen::App(  946): (512) > Not registered pid(5197)
07-13 23:27:53.950+0900 I/Tizen::App(  946): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 5197.
07-13 23:27:53.950+0900 I/Tizen::Io( 1005): (729) > Entry not found
07-13 23:27:53.950+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5197
07-13 23:27:53.960+0900 I/Tizen::System( 1005): (157) > change brightness system value.
07-13 23:27:53.960+0900 I/Tizen::App( 1005): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 5197.
07-13 23:27:55.930+0900 E/PKGMGR_SERVER( 6420): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 23:27:55.930+0900 E/PKGMGR_SERVER( 6420): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 23:27:58.220+0900 E/PKGMGR_SERVER( 6529): pkgmgr-server.c: main(1608) > server start
07-13 23:27:58.280+0900 E/PKGMGR  ( 6529): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.tdlnaservice]
07-13 23:27:58.280+0900 E/PKGMGR_SERVER( 6529): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.tdlnaservice 
07-13 23:27:58.280+0900 E/PKGMGR_SERVER( 6529): [0;m
07-13 23:27:58.450+0900 I/Tizen::App( 1005): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-13 23:27:58.450+0900 I/Tizen::App( 1005): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-13 23:27:58.450+0900 I/Tizen::App(  946): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-13 23:27:58.450+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [96]
07-13 23:27:58.450+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [96]
07-13 23:27:58.470+0900 W/AUL_AMD (  454): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-13 23:27:58.480+0900 I/Tizen::App( 1005): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-13 23:27:58.480+0900 I/Tizen::App( 1005): (119) > InstallationInProgress [30]
07-13 23:27:58.480+0900 I/Tizen::App( 1005): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-13 23:27:58.480+0900 I/Tizen::App(  946): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-13 23:27:58.480+0900 I/Tizen::App(  946): (119) > InstallationInProgress [30]
07-13 23:27:58.480+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-13 23:27:58.480+0900 I/Tizen::App(  946): (119) > InstallationInProgress [30]
07-13 23:27:58.480+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-13 23:27:58.510+0900 W/LOCKSCREEN(  572): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-13 23:27:58.510+0900 W/LOCKSCREEN(  572): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-13 23:27:58.510+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-13 23:27:58.510+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-13 23:27:58.510+0900 W/LOCKSCREEN(  572): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-13 23:27:58.510+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-13 23:27:58.510+0900 E/LOCKSCREEN(  572): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:27:58.520+0900 I/Tizen::App( 1083): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-13 23:27:58.520+0900 I/Tizen::App( 1083): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [96]
07-13 23:27:58.520+0900 W/LOCKSCREEN(  572): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-13 23:27:58.520+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-13 23:27:58.520+0900 W/LOCKSCREEN(  572): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-13 23:27:58.530+0900 I/indicator(  497): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-13 23:27:58.530+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-13 23:27:58.530+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-13 23:27:58.530+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-13 23:27:58.530+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 271 331 5 28 25"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 274 387 5 28 25"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 271 651 5 28 25"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-13 23:27:58.540+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 274 707 5 28 25"
07-13 23:27:58.550+0900 I/Tizen::App( 1083): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 271 331 5 28 25"
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-13 23:27:58.550+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 274 387 5 28 25"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 271 651 5 28 25"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-13 23:27:58.560+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 274 707 5 28 25"
07-13 23:27:58.570+0900 I/Tizen::App( 1083): (119) > InstallationInProgress [30]
07-13 23:27:58.570+0900 I/Tizen::App( 1083): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-13 23:27:59.110+0900 W/CAM_APP ( 1166): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 23:27:59.110+0900 I/Tizen::System( 1005): (280) > The screen has been turned on.
07-13 23:27:59.110+0900 I/Tizen::Io( 1005): (729) > Entry not found
07-13 23:27:59.120+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:27:59.130+0900 I/Tizen::System( 1005): (157) > change brightness system value.
07-13 23:27:59.180+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-13 23:27:59.180+0900 I/Tizen::App( 1083): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-13 23:27:59.180+0900 I/Tizen::App(  946): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-13 23:27:59.180+0900 I/Tizen::App(  946): (119) > InstallationInProgress [60]
07-13 23:27:59.180+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:27:59.180+0900 I/Tizen::App(  946): (119) > InstallationInProgress [60]
07-13 23:27:59.180+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:27:59.190+0900 I/Tizen::App( 1005): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-13 23:27:59.190+0900 I/Tizen::App( 1005): (119) > InstallationInProgress [60]
07-13 23:27:59.190+0900 I/Tizen::App( 1005): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-13 23:27:59.190+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 120
07-13 23:27:59.190+0900 I/Tizen::App( 1083): (119) > InstallationInProgress [60]
07-13 23:27:59.190+0900 I/Tizen::App( 1083): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [96]
07-13 23:27:59.190+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 120
07-13 23:27:59.190+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
07-13 23:27:59.190+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 33
07-13 23:27:59.190+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 35 33
07-13 23:27:59.190+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
07-13 23:27:59.210+0900 E/PKGMGR_CERT( 6532): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/res]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.tdlnaservice/shared], errno=[2][No such file or directory]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared/res]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/tizen-manifest.xml]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/author-signature.xml]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/signature1.xml]
07-13 23:27:59.220+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.tdlnaservice.xml]
07-13 23:27:59.370+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:27:59.460+0900 W/LOCKSCREEN(  572): dbus.c: _dbus_message_recv_cb(167) > [_dbus_message_recv_cb:167:W] rotation changed:0
07-13 23:27:59.460+0900 I/CAPI_APPFW_APPLICATION( 1166): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-13 23:27:59.460+0900 W/LOCKSCREEN(  572): camera.c: _angle_changed_cb(198) > [_angle_changed_cb:198:W] angle:0
07-13 23:27:59.460+0900 W/LOCKSCREEN(  572): camera.c: camera_view_action(157) > [camera_view_action:157:W] rotation:0
07-13 23:27:59.460+0900 I/CAPI_APPFW_APPLICATION(  772): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-13 23:27:59.460+0900 W/CAM_APP ( 1166): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-13 23:27:59.620+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:27:59.800+0900 E/LOCKSCREEN(  572): progress_circle.c: unlock_mouse_up(285) > 
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-13 23:27:59.800+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-13 23:27:59.870+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:28:00.000+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:28:00.000+0900 I/Tizen::Base::Runtime( 1083): (251) > The timer is not started.
07-13 23:28:00.000+0900 I/Tizen::System( 1083): (85) > Current Epoch is -5232859921466012944.
07-13 23:28:00.000+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'L'
07-13 23:28:00.000+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:28, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:28:00.010+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:28:00.010+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:28:0:9
07-13 23:28:00.010+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:28:0
07-13 23:28:00.010+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 45119991 milliseconds from now
07-13 23:28:00.020+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'F'
07-13 23:28:00.020+0900 E/SurfaceFlinger( 1451): redraw failed: empty invalid region
07-13 23:28:00.020+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(true)
07-13 23:28:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:28:00.030+0900 I/Tizen::System( 1083): (85) > Current Epoch is 1436797680.
07-13 23:28:00.030+0900 I/Tizen::System( 1083): (89) > Calendar time is sec:0, min:28, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:28:00.030+0900 I/Tizen::System( 1083): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:28:00.030+0900 I/Tizen::System( 1083): (103) > Original Time is 2015 7/13, 14:28:0:31
07-13 23:28:00.030+0900 I/Tizen::System( 1083): (123) > Current Time is 2015 7/13, 23:28:0
07-13 23:28:00.030+0900 I/AclService( 1083): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59969 milliseconds from now
07-13 23:28:00.030+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(false)
07-13 23:28:00.130+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:28:00.310+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-13 23:28:00.310+0900 W/LOCKSCREEN(  572): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-13 23:28:00.310+0900 W/LOCKSCREEN(  572): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-13 23:28:00.320+0900 E/WALLPAPER_SERVICE_COMMON(  572): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 23:28:00.320+0900 W/PROCESSMGR(  417): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5254
07-13 23:28:00.330+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:28:00.340+0900 I/indicator(  497): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 5254"
07-13 23:28:00.350+0900 E/EFL     ( 5254): ewebkit2<5254> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-13 23:28:00.370+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:28:00.380+0900 I/Tizen::System( 1083): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-13 23:28:00.380+0900 I/Tizen::System( 1005): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-13 23:28:00.380+0900 I/Tizen::Io( 1005): (729) > Entry not found
07-13 23:28:00.390+0900 I/Tizen::System( 1005): (157) > change brightness system value.
07-13 23:28:00.390+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:28:00.410+0900 W/LOCKSCREEN(  572): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(1)
07-13 23:28:00.410+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-13 23:28:00.410+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-13 23:28:00.410+0900 I/CAPI_APPFW_APPLICATION(  572): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 23:28:00.410+0900 E/LOCKSCREEN(  572): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:28:00.410+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-13 23:28:00.410+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-13 23:28:00.410+0900 E/rpm-installer( 6532): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]))
07-13 23:28:00.550+0900 W/LOCKSCREEN(  572): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-13 23:28:00.550+0900 E/LOCKSCREEN(  572): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:28:00.550+0900 W/LOCKSCREEN(  572): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-13 23:28:00.550+0900 W/LOCKSCREEN(  572): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-13 23:28:00.560+0900 E/LOCKSCREEN(  572): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-13 23:28:00.640+0900 I/Tizen::App(  946): (124) > app(ACL111OMWW.AclService), clientId(1083)
07-13 23:28:00.650+0900 D/PowerManagerService( 1451): calling setSysScreenBrightness(brightness = 153)
07-13 23:28:00.650+0900 I/power   ( 1451): *** set_screen_state 1
07-13 23:28:00.650+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'L'
07-13 23:28:00.650+0900 D/SensorService( 1451): actuateSensor
07-13 23:28:00.650+0900 D/AclServiceManager( 1451): -----*******------------ enableSensor  : 0
07-13 23:28:00.650+0900 D/SensorService( 1451): setSensorDelay
07-13 23:28:00.650+0900 D/AclServiceManager( 1451): -----*******------------ setSensorDelay : 0 to 200
07-13 23:28:00.650+0900 D/SensorService( 1451): setSensorDelay
07-13 23:28:00.650+0900 D/AclServiceManager( 1451): -----*******------------ setSensorDelay : 0 to 200
07-13 23:28:00.660+0900 D/ACL     ( 1451): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-13 23:28:00.660+0900 D/ACL     ( 1451): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-13 23:28:00.660+0900 I/AclService( 1083): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-13 23:28:00.660+0900 I/AclService( 1083): void minimize()(280) > Minimizing all vfb clients
07-13 23:28:00.670+0900 I/PowerManagerService-JNI( 1451): sending ACL screen state 'F'
07-13 23:28:00.670+0900 I/AclService( 1083): void minimize()(283) > minimizing {pkg=surfaceflinger fd=102}
07-13 23:28:00.670+0900 I/AclService( 1083): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-13 23:28:00.670+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(true)
07-13 23:28:00.670+0900 E/Tizen::Io( 1083): (133) > [E_INVALID_ARG] The application id is empty.
07-13 23:28:00.670+0900 I/Tizen::Base::Runtime( 1083): (251) > The timer is not started.
07-13 23:28:00.680+0900 I/Tizen::System( 1083): (461) > change cpu power policy: keepAwake(false)
07-13 23:28:00.930+0900 W/LOCKSCREEN(  572): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-13 23:28:00.930+0900 E/PKGMGR_SERVER( 6529): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:28:02.340+0900 I/MALI    ( 5254): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x20b2b80] swap changed from async to sync
07-13 23:28:02.930+0900 E/PKGMGR_SERVER( 6529): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:28:03.040+0900 E/PKGMGR_INFO( 6532): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 23:28:03.040+0900 E/PKGMGR_INSTALLER( 6532): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 23:28:03.070+0900 I/Tizen::App( 1005): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:28:03.070+0900 I/Tizen::App( 1005): (119) > InstallationInProgress [100]
07-13 23:28:03.070+0900 I/Tizen::App( 1005): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-13 23:28:03.070+0900 I/Tizen::App( 1005): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:28:03.070+0900 I/Tizen::App( 1005): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:28:03.070+0900 I/Tizen::App( 1005): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:28:03.070+0900 I/Tizen::App(  946): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:28:03.070+0900 I/Tizen::App(  946): (119) > InstallationInProgress [100]
07-13 23:28:03.070+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:28:03.070+0900 I/Tizen::App(  946): (119) > InstallationInProgress [100]
07-13 23:28:03.070+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:28:03.070+0900 I/Tizen::App(  946): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:28:03.070+0900 I/Tizen::App(  946): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:28:03.070+0900 I/Tizen::App(  946): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-13 23:28:03.070+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 23:28:03.070+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 23:28:03.070+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 23:28:03.080+0900 I/Tizen::App(  946): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:28:03.100+0900 I/Tizen::App(  946): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-13 23:28:03.110+0900 I/Tizen::App(  946): (416) > appName = [tdlnaservice]
07-13 23:28:03.110+0900 I/Tizen::App(  946): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-13 23:28:03.110+0900 E/PKGMGR_INFO(  946): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 23:28:03.110+0900 I/Tizen::App(  946): (675) > Application count(1) in this package
07-13 23:28:03.110+0900 I/Tizen::App(  946): (855) > Enter.
07-13 23:28:03.130+0900 I/Tizen::App(  946): (695) > Exit.
07-13 23:28:03.130+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:28:03.130+0900 I/Tizen::App(  946): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:28:03.130+0900 I/Tizen::App(  946): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:28:03.130+0900 I/Tizen::App(  946): (416) > appName = [tdlnaservice]
07-13 23:28:03.130+0900 I/Tizen::App(  946): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-13 23:28:03.130+0900 I/Tizen::App(  946): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-13 23:28:03.130+0900 I/Tizen::App(  946): (131) > Enter
07-13 23:28:03.130+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-13 23:28:03.130+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 23:28:03.130+0900 E/cluster-home(  603): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-13 23:28:03.130+0900 I/Tizen::App( 1083): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:28:03.140+0900 I/Tizen::App( 1083): (119) > InstallationInProgress [100]
07-13 23:28:03.140+0900 I/Tizen::App( 1083): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-13 23:28:03.140+0900 I/Tizen::App(  946): (137) > org.tizen.tdlnaservice does not have launch condition
07-13 23:28:03.140+0900 I/Tizen::App(  946): (898) > Exit.
07-13 23:28:03.140+0900 I/Tizen::App( 1083): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:28:03.140+0900 I/Tizen::App( 1083): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:28:03.150+0900 I/Tizen::App( 1083): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:28:03.160+0900 I/Tizen::App( 1083): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-13 23:28:03.170+0900 I/Tizen::App( 1083): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:28:03.170+0900 I/Tizen::App( 1083): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:28:04.930+0900 E/PKGMGR_SERVER( 6529): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 23:28:04.930+0900 E/PKGMGR_SERVER( 6529): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 23:28:05.040+0900 W/ProcessStats( 1451): Skipping unknown process pid 6600
07-13 23:28:05.280+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 23:28:05.290+0900 I/AUL     (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 23:28:05.300+0900 I/AUL     (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 23:28:05.300+0900 E/AUL_AMD (  454): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 23:28:05.310+0900 W/AUL_AMD (  454): amd_launch.c: service_start(515) > child process: 6616
07-13 23:28:05.360+0900 W/AUL_AMD (  454): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 6616
07-13 23:28:05.370+0900 E/RESOURCED(  758): proc-process.c: proc_get_oom_score_adj(377) > [proc_get_oom_score_adj,377] fopen /proc/0/oom_score_adj failed
07-13 23:28:05.380+0900 I/Tizen::App(  946): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-13 23:28:05.390+0900 I/Tizen::App(  946): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 6616.
07-13 23:28:05.390+0900 I/Tizen::App( 1005): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 6616.
07-13 23:28:05.400+0900 I/tdlna   ( 6616): _on_create_cb 실행
07-13 23:28:05.400+0900 I/tdlna   ( 6616): _app_init 실행
07-13 23:28:05.400+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 6616
07-13 23:28:05.410+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:28:05.410+0900 D/tdlnaservice( 6616): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-13 23:28:05.440+0900 I/tdlna   ( 6616): _on_app_control_callback 실행
07-13 23:28:05.440+0900 I/tdlna   ( 6616): _app_timer_thread_func 실행
07-13 23:28:06.650+0900 D/PowerManagerService( 1451): calling setSysScreenBrightness(brightness = 153)
07-13 23:28:06.650+0900 I/AclService( 1083): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:28:10.500+0900 I/MESSAGE_PORT(  376): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:28:10.510+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:28:10.510+0900 I/MESSAGE_PORT(  376): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:28:10.510+0900 D/tdlnaservice( 6616): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-13 23:28:10.510+0900 I/tdlna   ( 6616): _on_proxy_client_msg_received_cb 실행
07-13 23:28:10.510+0900 I/tdlna   ( 6616): _app_process_received_message 실행
07-13 23:28:10.510+0900 I/tdlna   ( 6616): test _ _app_process_received_message
07-13 23:28:10.510+0900 I/tdlna   ( 6616): _app_execute_operation 실행
07-13 23:28:10.510+0900 I/tdlna   ( 6616): test 실행
07-13 23:28:10.510+0900 I/tdlna   ( 6616): ★★★★★ 서비스 가동중 ★★★★★ 1
07-13 23:28:10.510+0900 I/tdlna   ( 6616): Main Start !!! 1
07-13 23:28:10.510+0900 I/tdlna   ( 6616): Service Start !!! 1
07-13 23:28:10.510+0900 I/tdlna   ( 6616): fork 전
07-13 23:28:10.510+0900 I/tdlna   ( 6640): fork child process 1
07-13 23:28:10.510+0900 I/tdlna   ( 6640): ssdp running
07-13 23:28:10.940+0900 W/CRASH_MANAGER( 6642): worker.c: worker_job(1236) > 110661674646c143679769
