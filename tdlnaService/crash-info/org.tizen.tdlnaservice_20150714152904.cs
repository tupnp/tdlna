S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 4168
Date: 2015-07-14 15:29:04+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb4c70000

Register Information
r0   = 0xb4c70002, r1   = 0xb4c70000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6ff36a1
r6   = 0xb5d0f450, r7   = 0xb4c70002
r8   = 0x0000001e, r9   = 0xb5d106f0
r10  = 0xb6ff3682, fp   = 0xb5d0f444
ip   = 0x00000000, sp   = 0xb5d0eee0
lr   = 0xb6e5e5b8, pc   = 0xb6e91d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     21860 KB
Buffers:     28420 KB
Cached:     280556 KB
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
PID = 4168 TID = 4397
4168 4169 4397 

Maps Information
b5512000 b5d11000 rwxp [stack:4397]
b5d12000 b6515000 rwxp [stack:4169]
b6515000 b6518000 r-xp /lib/libgpg-error.so.0.5.0
b651f000 b6520000 rwxp /lib/libgpg-error.so.0.5.0
b6520000 b6578000 r-xp /usr/lib/libgcrypt.so.11.5.3
b657f000 b6582000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6583000 b65af000 r-xp /usr/lib/libsystemd.so.0.0.1
b65b6000 b65b7000 r-xp /usr/lib/libsystemd.so.0.0.1
b65b7000 b65b8000 rwxp /usr/lib/libsystemd.so.0.0.1
b65b8000 b65ba000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65c1000 b65c2000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b65c2000 b668d000 r-xp /usr/lib/libxml2.so.2.7.8
b6695000 b669a000 rwxp /usr/lib/libxml2.so.2.7.8
b669b000 b66ab000 r-xp /lib/libresolv-2.13.so
b66ab000 b66ac000 r-xp /lib/libresolv-2.13.so
b66ac000 b66ad000 rwxp /lib/libresolv-2.13.so
b66b0000 b66c6000 r-xp /lib/libz.so.1.2.5
b66cd000 b66ce000 rwxp /lib/libz.so.1.2.5
b66ce000 b66d0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66d7000 b66d8000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66d8000 b66dd000 r-xp /usr/lib/libffi.so.5.0.10
b66e4000 b66e5000 rwxp /usr/lib/libffi.so.5.0.10
b66e5000 b66e6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66ed000 b66ee000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66ee000 b6753000 r-xp /usr/lib/libsqlite3.so.0.8.6
b675a000 b675d000 rwxp /usr/lib/libsqlite3.so.0.8.6
b675e000 b6761000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6768000 b6769000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6769000 b6911000 r-xp /usr/lib/libcrypto.so.1.0.0
b6918000 b692d000 rwxp /usr/lib/libcrypto.so.1.0.0
b6931000 b6947000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b694e000 b694f000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b694f000 b6983000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b698a000 b698c000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b698c000 b6a60000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a68000 b6a6b000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a6d000 b6a71000 r-xp /usr/lib/libchromium.so.1.0
b6a78000 b6a79000 rwxp /usr/lib/libchromium.so.1.0
b6a79000 b6ae2000 r-xp /lib/libm-2.13.so
b6ae9000 b6aea000 r-xp /lib/libm-2.13.so
b6aea000 b6aeb000 rwxp /lib/libm-2.13.so
b6aeb000 b6af1000 r-xp /usr/lib/libappsvc.so.0.1.0
b6af8000 b6af9000 rwxp /usr/lib/libappsvc.so.0.1.0
b6af9000 b6b18000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b1f000 b6b20000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6b20000 b6b23000 r-xp /usr/lib/libsmack.so.1.0.0
b6b2a000 b6b2b000 rwxp /usr/lib/libsmack.so.1.0.0
b6b2b000 b6b30000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b38000 b6b39000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b39000 b6b63000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b6b000 b6b6c000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b6c000 b6b83000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b8b000 b6b8c000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b8c000 b6c20000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c28000 b6c2b000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c2b000 b6c2d000 rwxp /usr/lib/libstdc++.so.6.0.16
b6c33000 b6c3e000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c45000 b6c46000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c46000 b6c4b000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c53000 b6c54000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c54000 b6d24000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d24000 b6d25000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6d25000 b6d65000 r-xp /usr/lib/libeina.so.1.7.99
b6d6c000 b6d6d000 rwxp /usr/lib/libeina.so.1.7.99
b6d6e000 b6d84000 r-xp /usr/lib/libecore.so.1.7.99
b6d8b000 b6d8c000 rwxp /usr/lib/libecore.so.1.7.99
b6d9a000 b6da1000 r-xp /usr/lib/libvconf.so.0.2.45
b6da9000 b6daa000 rwxp /usr/lib/libvconf.so.0.2.45
b6daa000 b6daf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6db6000 b6db7000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6db7000 b6dc2000 r-xp /usr/lib/libaul.so.0.1.0
b6dca000 b6dcb000 rwxp /usr/lib/libaul.so.0.1.0
b6dcc000 b6dd4000 r-xp /lib/libgcc_s-4.6.4.so.1
b6ddb000 b6ddc000 rwxp /lib/libgcc_s-4.6.4.so.1
b6ddc000 b6dde000 r-xp /lib/libdl-2.13.so
b6de5000 b6de6000 r-xp /lib/libdl-2.13.so
b6de6000 b6de7000 rwxp /lib/libdl-2.13.so
b6de7000 b6df2000 r-xp /lib/libunwind.so.8.0.1
b6df9000 b6dfa000 rwxp /lib/libunwind.so.8.0.1
b6e1f000 b6f3a000 r-xp /lib/libc-2.13.so
b6f42000 b6f44000 r-xp /lib/libc-2.13.so
b6f44000 b6f45000 rwxp /lib/libc-2.13.so
b6f48000 b6f4e000 r-xp /lib/librt-2.13.so
b6f55000 b6f56000 r-xp /lib/librt-2.13.so
b6f56000 b6f57000 rwxp /lib/librt-2.13.so
b6f57000 b6f59000 r-xp /usr/lib/libdlog.so.0.0.0
b6f60000 b6f61000 rwxp /usr/lib/libdlog.so.0.0.0
b6f61000 b6f64000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f6b000 b6f6c000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f6c000 b6f6f000 r-xp /usr/lib/libbundle.so.0.1.22
b6f76000 b6f77000 rwxp /usr/lib/libbundle.so.0.1.22
b6f77000 b6f7a000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f81000 b6f82000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f82000 b6f96000 r-xp /lib/libpthread-2.13.so
b6f9d000 b6f9e000 r-xp /lib/libpthread-2.13.so
b6f9e000 b6f9f000 rwxp /lib/libpthread-2.13.so
b6fb6000 b6fba000 r-xp /usr/lib/libsys-assert.so
b6fc2000 b6fc3000 rwxp /usr/lib/libsys-assert.so
b6fc3000 b6fe0000 r-xp /lib/ld-2.13.so
b6fe7000 b6fe8000 r-xp /lib/ld-2.13.so
b6fe8000 b6fe9000 rwxp /lib/ld-2.13.so
b6fe9000 b6ff6000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6ffd000 b6fff000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b72f6000 b733b000 rwxp [heap]
be836000 be857000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4168)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e91d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e5e5b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6ef6b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f58063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x418 (0xb6fee131) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5131
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
0) > [0;31m* Critical * No records found[0;m
07-14 15:28:44.860+0900 I/CAPI_APPFW_APPLICATION(  596): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:28:44.860+0900 E/cluster-home(  596): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:28:44.860+0900 W/PROCESSMGR(  373): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=576
07-14 15:28:44.870+0900 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:28:44.870+0900 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:28:44.920+0900 I/Tizen::Base::Runtime( 1069): (251) > The timer is not started.
07-14 15:28:44.930+0900 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:28:44.930+0900 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:28:44.930+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-14 15:28:44.930+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-14 15:28:44.930+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-14 15:28:44.950+0900 I/MALI    (  596): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb1e362c0] swap changed from sync to async
07-14 15:28:44.990+0900 I/Tizen::System(  960): (259) > Active app [com.samsun], current [com.samsun] 
07-14 15:28:44.990+0900 I/Tizen::System(  960): (273) > Current App[com.samsun] is already actived.
07-14 15:28:44.990+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:28:45.000+0900 W/LOCKSCREEN(  576): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(0)
07-14 15:28:45.000+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-14 15:28:45.000+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-14 15:28:45.000+0900 I/Tizen::System( 1069): (101) > Active App is com.samsung.lockscreen. GetApp id ACL111OMWW.AclService
07-14 15:28:45.010+0900 I/CAPI_APPFW_APPLICATION(  576): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 15:28:45.010+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-14 15:28:45.010+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-14 15:28:45.020+0900 D/PowerManagerService( 1314): calling setSysScreenBrightness(brightness = 153)
07-14 15:28:45.020+0900 I/power   ( 1314): *** set_screen_state 0
07-14 15:28:45.020+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'L'
07-14 15:28:45.020+0900 D/SensorService( 1314): actuateSensor
07-14 15:28:45.020+0900 D/AclServiceManager( 1314): -----*******------------ disableSensor  : 0
07-14 15:28:45.020+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'L'
07-14 15:28:45.040+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:28:45.040+0900 I/AclService( 1069): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:28:45.050+0900 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 576"
07-14 15:28:45.050+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(true)
07-14 15:28:45.080+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(true)
07-14 15:28:45.080+0900 W/ProcessStats( 1314): Skipping unknown process pid 4168
07-14 15:28:45.090+0900 D/ACL     ( 1314): ************ onActivitySaveInstanceState()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:28:45.090+0900 D/ACL     ( 1314): ************ onActivityPaused()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:28:45.090+0900 D/ACL     ( 1314): Pausing app with base activity ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:28:45.090+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'F'
07-14 15:28:45.100+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(false)
07-14 15:28:45.350+0900 W/LOCKSCREEN(  576): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-14 15:28:49.710+0900 W/LOCKSCREEN(  576): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-14 15:28:49.710+0900 W/LOCKSCREEN(  576): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-14 15:28:49.710+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-14 15:28:49.710+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-14 15:28:49.710+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 15:28:49.710+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-14 15:28:49.710+0900 I/indicator(  501): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-14 15:28:49.710+0900 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:28:49.720+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 15:28:49.720+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 15:28:49.720+0900 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-14 15:28:49.750+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:28:49.750+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:28:49.750+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 304 331 5 28 25"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 305 387 5 28 25"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 304 651 5 28 25"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 15:28:49.760+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 305 707 5 28 25"
07-14 15:28:49.770+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:28:49.770+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:28:49.770+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:28:49.770+0900 I/indicator(  501): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:28:49.770+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 304 331 5 28 25"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 305 387 5 28 25"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 304 651 5 28 25"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 15:28:49.780+0900 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 305 707 5 28 25"
07-14 15:28:50.380+0900 W/CAM_APP ( 1194): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 15:28:50.400+0900 I/Tizen::System(  960): (280) > The screen has been turned on.
07-14 15:28:50.400+0900 I/Tizen::Io(  960): (729) > Entry not found
07-14 15:28:50.420+0900 I/Tizen::System(  960): (157) > change brightness system value.
07-14 15:28:50.440+0900 I/Tizen::App(  933): (124) > app(ACL111OMWW.AclService), clientId(1069)
07-14 15:28:50.690+0900 I/Tizen::App(  933): (124) > app(ACL111OMWW.AclService), clientId(1069)
07-14 15:28:50.790+0900 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-14 15:28:50.790+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-14 15:28:50.940+0900 I/Tizen::App(  933): (124) > app(ACL111OMWW.AclService), clientId(1069)
07-14 15:28:50.970+0900 I/CAPI_APPFW_APPLICATION( 1194): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-14 15:28:50.970+0900 I/CAPI_APPFW_APPLICATION( 4203): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-14 15:28:50.970+0900 I/CAPI_APPFW_APPLICATION( 4174): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
07-14 15:28:50.970+0900 W/CAM_APP ( 1194): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
07-14 15:28:50.980+0900 W/LOCKSCREEN(  576): dbus.c: _dbus_message_recv_cb(167) > [_dbus_message_recv_cb:167:W] rotation changed:0
07-14 15:28:50.980+0900 W/LOCKSCREEN(  576): camera.c: _angle_changed_cb(198) > [_angle_changed_cb:198:W] angle:0
07-14 15:28:50.980+0900 W/LOCKSCREEN(  576): camera.c: camera_view_action(157) > [camera_view_action:157:W] rotation:0
07-14 15:28:51.190+0900 I/Tizen::App(  933): (124) > app(ACL111OMWW.AclService), clientId(1069)
07-14 15:28:51.300+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-14 15:28:51.300+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-14 15:28:51.300+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-14 15:28:51.310+0900 E/WALLPAPER_SERVICE_COMMON(  576): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 15:28:51.330+0900 W/PROCESSMGR(  373): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=596
07-14 15:28:51.330+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:28:51.340+0900 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 596"
07-14 15:28:51.380+0900 I/CAPI_APPFW_APPLICATION(  596): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 15:28:51.380+0900 E/cluster-home(  596): homescreen-main.cpp: app_resume(422) >  app resume
07-14 15:28:51.400+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:28:51.410+0900 I/Tizen::System( 1069): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
07-14 15:28:51.430+0900 W/LOCKSCREEN(  576): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(1)
07-14 15:28:51.430+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-14 15:28:51.430+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-14 15:28:51.430+0900 I/CAPI_APPFW_APPLICATION(  576): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:28:51.430+0900 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:28:51.430+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-14 15:28:51.430+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-14 15:28:51.450+0900 I/Tizen::System(  960): (259) > Active app [com.samsun], current [com.samsun] 
07-14 15:28:51.450+0900 I/Tizen::System(  960): (273) > Current App[com.samsun] is already actived.
07-14 15:28:51.460+0900 I/Tizen::App(  933): (124) > app(ACL111OMWW.AclService), clientId(1069)
07-14 15:28:51.460+0900 D/PowerManagerService( 1314): calling setSysScreenBrightness(brightness = 153)
07-14 15:28:51.460+0900 I/power   ( 1314): *** set_screen_state 1
07-14 15:28:51.460+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'L'
07-14 15:28:51.470+0900 D/SensorService( 1314): actuateSensor
07-14 15:28:51.470+0900 D/AclServiceManager( 1314): -----*******------------ enableSensor  : 0
07-14 15:28:51.480+0900 D/SensorService( 1314): setSensorDelay
07-14 15:28:51.480+0900 D/AclServiceManager( 1314): -----*******------------ setSensorDelay : 0 to 200
07-14 15:28:51.480+0900 D/SensorService( 1314): setSensorDelay
07-14 15:28:51.480+0900 D/AclServiceManager( 1314): -----*******------------ setSensorDelay : 0 to 200
07-14 15:28:51.480+0900 I/AclService( 1069): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:28:51.490+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(true)
07-14 15:28:51.490+0900 D/ACL     ( 1314): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:28:51.500+0900 D/ACL     ( 1314): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-14 15:28:51.500+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'F'
07-14 15:28:51.520+0900 I/AclService( 1069): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-14 15:28:51.520+0900 I/AclService( 1069): void minimize()(280) > Minimizing all vfb clients
07-14 15:28:51.520+0900 I/AclService( 1069): void minimize()(283) > minimizing {pkg=surfaceflinger fd=99}
07-14 15:28:51.530+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(false)
07-14 15:28:51.530+0900 E/Tizen::Io( 1069): (133) > [E_INVALID_ARG] The application id is empty.
07-14 15:28:51.530+0900 I/Tizen::Base::Runtime( 1069): (251) > The timer is not started.
07-14 15:28:51.580+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-14 15:28:51.580+0900 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:28:51.580+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-14 15:28:51.580+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-14 15:28:51.590+0900 E/LOCKSCREEN(  576): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-14 15:28:51.990+0900 W/LOCKSCREEN(  576): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 15:28:52.330+0900 W/test-log(  596): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:28:52.330+0900 W/test-log(  596): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:28:52.330+0900 W/test-log(  596): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:28:52.330+0900 W/test-log(  596): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:28:52.330+0900 W/test-log(  596): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:28:53.140+0900 W/cluster-view(  596): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:28:53.400+0900 I/MALI    (  596): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb1e362c0] swap changed from async to sync
07-14 15:28:53.650+0900 W/cluster-view(  596): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:28:54.120+0900 W/cluster-view(  596): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:28:54.780+0900 W/cluster-view(  596): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:28:56.500+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 15:28:56.590+0900 E/RESOURCED(  757): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
07-14 15:28:56.610+0900 E/RESOURCED(  757): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 352
07-14 15:28:56.620+0900 I/Tizen::App(  933): (499) > LaunchedApp(rMfxc1AKe2.tdlnaWeb)
07-14 15:28:56.630+0900 I/Tizen::App(  960): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 4348.
07-14 15:28:56.630+0900 I/Tizen::App(  933): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 4348.
07-14 15:28:56.710+0900 I/UXT     ( 4350): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:28:56.740+0900 I/EFL-ASSIST( 4350): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1290730) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:28:56.740+0900 I/EFL-ASSIST( 4350): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1290730) is freed
07-14 15:28:56.750+0900 I/UXT     ( 4348): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:28:56.750+0900 I/EFL-ASSIST( 4350): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1290730) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:28:56.750+0900 I/EFL-ASSIST( 4350): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1290730) is freed
07-14 15:28:56.800+0900 E/PKGMGR_INFO( 4348): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 15:28:56.800+0900 I/APP_CORE( 4348): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 15:28:56.800+0900 I/APP_CORE( 4348): appcore-efl.c: __do_app(511) > [APP 4348] Initial Launching, call the resume_cb
07-14 15:28:56.930+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 15:28:56.930+0900 W/AUL_AMD (  455): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 15:28:56.930+0900 W/AUL_AMD (  455): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 15:28:56.980+0900 I/AUL     ( 4350): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:28:56.990+0900 E/EFL     ( 4348): elementary<4348> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x1388580 as sub object of 0x13882c0
07-14 15:28:57.000+0900 E/WEBKIT  ( 4348): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 15:28:57.040+0900 I/CAPI_NETWORK_CONNECTION( 4348): connection.c: connection_create(363) > New handle created[0xb1c06bf8]
07-14 15:28:57.040+0900 I/CAPI_NETWORK_CONNECTION( 4348): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 15:28:57.040+0900 I/CAPI_NETWORK_CONNECTION( 4348): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 15:28:57.040+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4348): system_settings.c: system_settings_set_changed_cb(541) > b3ead2b1
07-14 15:28:57.040+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4348): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3eabd99
07-14 15:28:57.060+0900 I/EFL-ASSIST( 4348): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [12da970]
07-14 15:28:57.070+0900 I/EFL-ASSIST( 4348): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1283d68) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:28:57.070+0900 I/EFL-ASSIST( 4348): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1283d68) is freed
07-14 15:28:57.170+0900 E/EFL     ( 4350): edje<4350> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 15:28:57.220+0900 E/EFL     ( 4348): evas_main<4348> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 15:28:57.230+0900 E/EFL     ( 4348): evas_main<4348> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 15:28:57.330+0900 W/PROCESSMGR(  373): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4348
07-14 15:28:57.370+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:28:57.380+0900 W/APP_CORE( 4348): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00003
07-14 15:28:57.390+0900 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 4348"
07-14 15:28:57.400+0900 I/MALI    (  596): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb1e362c0] swap changed from sync to async
07-14 15:28:57.460+0900 I/Tizen::System(  960): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 15:28:57.460+0900 I/Tizen::Io(  960): (729) > Entry not found
07-14 15:28:57.470+0900 I/Tizen::System(  960): (157) > change brightness system value.
07-14 15:28:57.480+0900 I/CAPI_APPFW_APPLICATION(  596): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:28:57.480+0900 E/cluster-home(  596): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:28:57.500+0900 D/PowerManagerService( 1314): calling setSysScreenBrightness(brightness = 153)
07-14 15:28:57.520+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:28:57.540+0900 I/Tizen::System( 1069): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:28:57.550+0900 I/AclService( 1069): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:28:57.780+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:57.820+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:57.820+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:57.820+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:57.860+0900 I/UXT     ( 4370): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:28:57.860+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:57.900+0900 I/EFL-ASSIST( 4370): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1280350) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:28:57.900+0900 I/EFL-ASSIST( 4370): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1280350) is freed
07-14 15:28:57.910+0900 I/EFL-ASSIST( 4370): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1280350) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:28:57.920+0900 I/EFL-ASSIST( 4370): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1280350) is freed
07-14 15:28:57.940+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:57.940+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:57.940+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:57.970+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:57.980+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:57.980+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:57.980+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:58.000+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.010+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.010+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:58.010+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:58.020+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.030+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.030+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:58.030+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:58.040+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.050+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.050+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:58.050+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:58.060+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.070+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.070+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:58.070+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:58.080+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.090+0900 I/AUL     ( 4349): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:28:58.090+0900 E/AUL     ( 4349): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:28:58.100+0900 E/AUL     ( 4349): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:28:58.530+0900 E/WEBKIT  ( 4348): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 15:28:59.490+0900 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:28:59.640+0900 E/PKGMGR_INFO( 4350): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:28:59.810+0900 I/MALI    ( 4348): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x1306cb8] swap changed from async to sync
07-14 15:28:59.890+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:28:59.900+0900 I/AUL     (  390): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:28:59.900+0900 I/AUL     ( 4350): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 4350
07-14 15:28:59.910+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:28:59.930+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:28:59.940+0900 D/tdlnaservice( 4168): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:28:59.940+0900 I/tdlna   ( 4168): _on_proxy_client_msg_received_cb 실행
07-14 15:28:59.940+0900 I/tdlna   ( 4168): _app_process_received_message 실행
07-14 15:28:59.940+0900 I/tdlna   ( 4168): _app_execute_operation 실행
07-14 15:28:59.940+0900 I/tdlna   ( 4168): _app_send_response 실행
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:28:59.940+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:28:59.940+0900 D/tdlnaservice( 4168): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:28:59.970+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:28:59.990+0900 D/tdlnaservice( 4168): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:28:59.990+0900 I/tdlna   ( 4168): _on_proxy_client_msg_received_cb 실행
07-14 15:28:59.990+0900 I/tdlna   ( 4168): _app_process_received_message 실행
07-14 15:28:59.990+0900 I/tdlna   ( 4168): _app_execute_operation 실행
07-14 15:28:59.990+0900 D/tdlnaservice( 4168): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 15:28:59.990+0900 I/tdlna   ( 4168): _app_run_timer 실행
07-14 15:28:59.990+0900 I/tdlna   ( 4168): _app_run_timer 실행
07-14 15:28:59.990+0900 I/tdlna   ( 4168): _app_send_response 실행
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:28:59.990+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:29:00.000+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:29:00.000+0900 D/tdlnaservice( 4168): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:29:00.000+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'L'
07-14 15:29:00.010+0900 I/AclService( 1069): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:29:00.010+0900 I/Tizen::Base::Runtime( 1069): (251) > The timer is not started.
07-14 15:29:00.010+0900 I/Tizen::System( 1069): (85) > Current Epoch is -5266131504099709908.
07-14 15:29:00.010+0900 I/Tizen::System( 1069): (89) > Calendar time is sec:0, min:29, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:29:00.010+0900 I/Tizen::System( 1069): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:29:00.010+0900 I/Tizen::System( 1069): (103) > Original Time is 2015 7/14, 6:29:0:16
07-14 15:29:00.010+0900 I/Tizen::System( 1069): (123) > Current Time is 2015 7/14, 15:29:0
07-14 15:29:00.010+0900 I/AclService( 1069): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 73859984 milliseconds from now
07-14 15:29:00.020+0900 E/SurfaceFlinger( 1314): redraw failed: empty invalid region
07-14 15:29:00.020+0900 I/PowerManagerService-JNI( 1314): sending ACL screen state 'F'
07-14 15:29:00.020+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(true)
07-14 15:29:00.020+0900 I/AclService( 1069): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:29:00.020+0900 I/Tizen::System( 1069): (85) > Current Epoch is 1436855340.
07-14 15:29:00.020+0900 I/Tizen::System( 1069): (89) > Calendar time is sec:0, min:29, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:29:00.020+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:29:00.020+0900 I/Tizen::System( 1069): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:29:00.020+0900 I/Tizen::System( 1069): (103) > Original Time is 2015 7/14, 6:29:0:29
07-14 15:29:00.020+0900 I/Tizen::System( 1069): (123) > Current Time is 2015 7/14, 15:29:0
07-14 15:29:00.020+0900 I/AclService( 1069): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59971 milliseconds from now
07-14 15:29:00.030+0900 I/Tizen::System( 1069): (461) > change cpu power policy: keepAwake(false)
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:29:04.380+0900 D/tdlnaservice( 4168): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:29:04.380+0900 I/tdlna   ( 4168): _on_proxy_client_msg_received_cb 실행
07-14 15:29:04.380+0900 I/tdlna   ( 4168): _app_process_received_message 실행
07-14 15:29:04.380+0900 I/tdlna   ( 4168): test _ _app_process_received_message
07-14 15:29:04.380+0900 I/tdlna   ( 4168): _app_execute_operation 실행
07-14 15:29:04.380+0900 I/tdlna   ( 4168): test 실행
07-14 15:29:04.380+0900 I/tdlna   ( 4168): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:29:04.380+0900 I/tdlna   ( 4168): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:29:04.380+0900 I/tdlna   ( 4168): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:29:04.380+0900 I/tdlna   ( 4168): _app_send_response 실행
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:29:04.380+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:29:04.390+0900 I/tdlna   ( 4168): Main Start !!! 1
07-14 15:29:04.390+0900 I/tdlna   ( 4168): Service Start !!! 1
07-14 15:29:04.390+0900 I/tdlna   ( 4168): fork 전
07-14 15:29:04.390+0900 I/tdlna   ( 4168): Main precess Start !! 4398
07-14 15:29:04.390+0900 I/tdlna   ( 4398): fork child process 1
07-14 15:29:04.390+0900 I/tdlna   ( 4398): ssdp running
07-14 15:29:04.390+0900 D/tdlnaservice( 4168): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:29:04.410+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:29:04.860+0900 W/CRASH_MANAGER( 4400): worker.c: worker_job(1236) > 110416874646c143685534
