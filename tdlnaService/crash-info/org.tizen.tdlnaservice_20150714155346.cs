S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 3279
Date: 2015-07-14 15:53:46+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x65a80000

Register Information
r0   = 0x65a80002, r1   = 0x65a80000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6fd16a6
r6   = 0xb5ced438, r7   = 0x65a80002
r8   = 0x0000001e, r9   = 0xb5cee6f0
r10  = 0xb6fd1687, fp   = 0xb5ced42c
ip   = 0x00000000, sp   = 0xb5cecec8
lr   = 0xb6e3c5b8, pc   = 0xb6e6fd64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     22248 KB
Buffers:     27604 KB
Cached:     273188 KB
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
VmPTE:          20 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3279 TID = 3306
3279 3285 3306 

Maps Information
b54f0000 b5cef000 rwxp [stack:3306]
b5cf0000 b64f3000 rwxp [stack:3285]
b64f3000 b64f6000 r-xp /lib/libgpg-error.so.0.5.0
b64fd000 b64fe000 rwxp /lib/libgpg-error.so.0.5.0
b64fe000 b6556000 r-xp /usr/lib/libgcrypt.so.11.5.3
b655d000 b6560000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6561000 b658d000 r-xp /usr/lib/libsystemd.so.0.0.1
b6594000 b6595000 r-xp /usr/lib/libsystemd.so.0.0.1
b6595000 b6596000 rwxp /usr/lib/libsystemd.so.0.0.1
b6596000 b6598000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b659f000 b65a0000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b65a0000 b666b000 r-xp /usr/lib/libxml2.so.2.7.8
b6673000 b6678000 rwxp /usr/lib/libxml2.so.2.7.8
b6679000 b6689000 r-xp /lib/libresolv-2.13.so
b6689000 b668a000 r-xp /lib/libresolv-2.13.so
b668a000 b668b000 rwxp /lib/libresolv-2.13.so
b668e000 b66a4000 r-xp /lib/libz.so.1.2.5
b66ab000 b66ac000 rwxp /lib/libz.so.1.2.5
b66ac000 b66ae000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66b5000 b66b6000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66b6000 b66bb000 r-xp /usr/lib/libffi.so.5.0.10
b66c2000 b66c3000 rwxp /usr/lib/libffi.so.5.0.10
b66c3000 b66c4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66cb000 b66cc000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66cc000 b6731000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6738000 b673b000 rwxp /usr/lib/libsqlite3.so.0.8.6
b673c000 b673f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6746000 b6747000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6747000 b68ef000 r-xp /usr/lib/libcrypto.so.1.0.0
b68f6000 b690b000 rwxp /usr/lib/libcrypto.so.1.0.0
b690f000 b6925000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b692c000 b692d000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b692d000 b6961000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6968000 b696a000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b696a000 b6a3e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a46000 b6a49000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a4b000 b6a4f000 r-xp /usr/lib/libchromium.so.1.0
b6a56000 b6a57000 rwxp /usr/lib/libchromium.so.1.0
b6a57000 b6ac0000 r-xp /lib/libm-2.13.so
b6ac7000 b6ac8000 r-xp /lib/libm-2.13.so
b6ac8000 b6ac9000 rwxp /lib/libm-2.13.so
b6ac9000 b6acf000 r-xp /usr/lib/libappsvc.so.0.1.0
b6ad6000 b6ad7000 rwxp /usr/lib/libappsvc.so.0.1.0
b6ad7000 b6af6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6afd000 b6afe000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6afe000 b6b01000 r-xp /usr/lib/libsmack.so.1.0.0
b6b08000 b6b09000 rwxp /usr/lib/libsmack.so.1.0.0
b6b09000 b6b0e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b16000 b6b17000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b17000 b6b41000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b49000 b6b4a000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b4a000 b6b61000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b69000 b6b6a000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b6a000 b6bfe000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c06000 b6c09000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c09000 b6c0b000 rwxp /usr/lib/libstdc++.so.6.0.16
b6c11000 b6c1c000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c23000 b6c24000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c24000 b6c29000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c31000 b6c32000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c32000 b6d02000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d02000 b6d03000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6d03000 b6d43000 r-xp /usr/lib/libeina.so.1.7.99
b6d4a000 b6d4b000 rwxp /usr/lib/libeina.so.1.7.99
b6d4c000 b6d62000 r-xp /usr/lib/libecore.so.1.7.99
b6d69000 b6d6a000 rwxp /usr/lib/libecore.so.1.7.99
b6d78000 b6d7f000 r-xp /usr/lib/libvconf.so.0.2.45
b6d87000 b6d88000 rwxp /usr/lib/libvconf.so.0.2.45
b6d88000 b6d8d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d94000 b6d95000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d95000 b6da0000 r-xp /usr/lib/libaul.so.0.1.0
b6da8000 b6da9000 rwxp /usr/lib/libaul.so.0.1.0
b6daa000 b6db2000 r-xp /lib/libgcc_s-4.6.4.so.1
b6db9000 b6dba000 rwxp /lib/libgcc_s-4.6.4.so.1
b6dba000 b6dbc000 r-xp /lib/libdl-2.13.so
b6dc3000 b6dc4000 r-xp /lib/libdl-2.13.so
b6dc4000 b6dc5000 rwxp /lib/libdl-2.13.so
b6dc5000 b6dd0000 r-xp /lib/libunwind.so.8.0.1
b6dd7000 b6dd8000 rwxp /lib/libunwind.so.8.0.1
b6dfd000 b6f18000 r-xp /lib/libc-2.13.so
b6f20000 b6f22000 r-xp /lib/libc-2.13.so
b6f22000 b6f23000 rwxp /lib/libc-2.13.so
b6f26000 b6f2c000 r-xp /lib/librt-2.13.so
b6f33000 b6f34000 r-xp /lib/librt-2.13.so
b6f34000 b6f35000 rwxp /lib/librt-2.13.so
b6f35000 b6f37000 r-xp /usr/lib/libdlog.so.0.0.0
b6f3e000 b6f3f000 rwxp /usr/lib/libdlog.so.0.0.0
b6f3f000 b6f42000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f49000 b6f4a000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f4a000 b6f4d000 r-xp /usr/lib/libbundle.so.0.1.22
b6f54000 b6f55000 rwxp /usr/lib/libbundle.so.0.1.22
b6f55000 b6f58000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f5f000 b6f60000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f60000 b6f74000 r-xp /lib/libpthread-2.13.so
b6f7b000 b6f7c000 r-xp /lib/libpthread-2.13.so
b6f7c000 b6f7d000 rwxp /lib/libpthread-2.13.so
b6f94000 b6f98000 r-xp /usr/lib/libsys-assert.so
b6fa0000 b6fa1000 rwxp /usr/lib/libsys-assert.so
b6fa1000 b6fbe000 r-xp /lib/ld-2.13.so
b6fc5000 b6fc6000 r-xp /lib/ld-2.13.so
b6fc6000 b6fc7000 rwxp /lib/ld-2.13.so
b6fc7000 b6fd4000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fdb000 b6fdd000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7acf000 b7b14000 rwxp [heap]
be8bb000 be8dc000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3279)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e6fd64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e3c5b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6ed4b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f36063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x43c (0xb6fcc129) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5129
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

07-14 15:53:34.250+0900 D/PowerManagerService( 1502): calling setSysScreenBrightness(brightness = 153)
07-14 15:53:34.260+0900 I/power   ( 1502): *** set_screen_state 0
07-14 15:53:34.260+0900 I/AclService( 1084): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:53:34.260+0900 I/PowerManagerService-JNI( 1502): sending ACL screen state 'L'
07-14 15:53:34.260+0900 D/SensorService( 1502): actuateSensor
07-14 15:53:34.260+0900 D/AclServiceManager( 1502): -----*******------------ disableSensor  : 0
07-14 15:53:34.260+0900 I/PowerManagerService-JNI( 1502): sending ACL screen state 'L'
07-14 15:53:34.260+0900 I/Tizen::System( 1084): (461) > change cpu power policy: keepAwake(true)
07-14 15:53:34.270+0900 I/Tizen::System( 1084): (461) > change cpu power policy: keepAwake(true)
07-14 15:53:34.280+0900 D/ACL     ( 1502): ************ onActivitySaveInstanceState()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:53:34.290+0900 D/ACL     ( 1502): ************ onActivityPaused()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:53:34.290+0900 D/ACL     ( 1502): Pausing app with base activity ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:53:34.290+0900 I/PowerManagerService-JNI( 1502): sending ACL screen state 'F'
07-14 15:53:34.300+0900 I/Tizen::System( 1084): (461) > change cpu power policy: keepAwake(false)
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): event.c: _lcd_off_source_cb(47) > [_lcd_off_source_cb:47:W] Vconf LCD off
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30002:LCD_OFF
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:30002 event_info:0
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:5
07-14 15:53:34.380+0900 W/LOCKSCREEN(  563): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => PAUSE
07-14 15:53:34.390+0900 E/WALLPAPER_SERVICE_COMMON(  563): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 15:53:34.400+0900 I/CAPI_APPFW_APPLICATION(  589): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:53:34.400+0900 E/cluster-home(  589): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:53:34.400+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-14 15:53:34.400+0900 W/PROCESSMGR(  374): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=563
07-14 15:53:34.400+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-14 15:53:34.400+0900 W/LOCKSCREEN(  563): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-14 15:53:34.420+0900 W/LOCKSCREEN(  563): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(0)
07-14 15:53:34.420+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-14 15:53:34.420+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-14 15:53:34.430+0900 I/CAPI_APPFW_APPLICATION(  563): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 15:53:34.430+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-14 15:53:34.430+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-14 15:53:34.450+0900 W/AUL_AMD (  459): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:53:34.450+0900 W/AUL_AMD (  459): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:53:34.450+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:53:34.460+0900 I/indicator(  496): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 563"
07-14 15:53:34.470+0900 W/AUL_AMD (  459): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:53:34.470+0900 W/AUL_AMD (  459): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:53:34.480+0900 I/MALI    (  589): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb786d7f8] swap changed from sync to async
07-14 15:53:34.500+0900 I/Tizen::System(  978): (259) > Active app [com.samsun], current [] 
07-14 15:53:34.500+0900 I/Tizen::Io(  978): (729) > Entry not found
07-14 15:53:34.500+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:53:34.520+0900 I/Tizen::System(  978): (157) > change brightness system value.
07-14 15:53:34.530+0900 I/Tizen::System( 1084): (101) > Active App is com.samsung.lockscreen. GetApp id ACL111OMWW.AclService
07-14 15:53:34.880+0900 W/LOCKSCREEN(  563): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-14 15:53:35.510+0900 I/indicator(  496): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-14 15:53:35.510+0900 W/LOCKSCREEN(  563): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-14 15:53:35.510+0900 W/LOCKSCREEN(  563): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-14 15:53:35.510+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-14 15:53:35.510+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-14 15:53:35.510+0900 W/LOCKSCREEN(  563): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 15:53:35.520+0900 W/LOCKSCREEN(  563): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-14 15:53:35.520+0900 E/LOCKSCREEN(  563): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:53:35.530+0900 W/LOCKSCREEN(  563): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 15:53:35.540+0900 W/LOCKSCREEN(  563): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 15:53:35.540+0900 W/LOCKSCREEN(  563): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 320 359 5 28 25"
07-14 15:53:35.550+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 321 387 5 28 25"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 320 679 5 28 25"
07-14 15:53:35.560+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 321 707 5 28 25"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 320 359 5 28 25"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 321 387 5 28 25"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 320 679 5 28 25"
07-14 15:53:35.570+0900 I/indicator(  496): indicator_box_util.c: _update_display(585) > "Noti Icon : 321 707 5 28 25"
07-14 15:53:36.150+0900 W/CAM_APP ( 1147): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 15:53:36.170+0900 I/Tizen::System(  978): (280) > The screen has been turned on.
07-14 15:53:36.170+0900 I/Tizen::Io(  978): (729) > Entry not found
07-14 15:53:36.190+0900 I/Tizen::System(  978): (157) > change brightness system value.
07-14 15:53:36.210+0900 I/Tizen::Shell( 1084): (73) > Enter.
07-14 15:53:36.220+0900 I/Tizen::Shell( 1084): (47) > Enter.
07-14 15:53:36.220+0900 I/Tizen::Shell( 1084): (93) > LockManager is constructed.
07-14 15:53:36.220+0900 I/Tizen::Shell( 1084): (58) > Exit.
07-14 15:53:36.220+0900 I/Tizen::Shell( 1084): (81) > Exit.
07-14 15:53:36.220+0900 I/Tizen::Shell( 1084): (95) > Enter.
07-14 15:53:36.240+0900 I/Tizen::App(  949): (147) > _LockManagerStub::OnIpcClientConnected (clientId:1084)
07-14 15:53:36.250+0900 I/Tizen::App( 1084): (109) > Succeeded in connecting service(osp.shell.ipcserver.lockmanager)
07-14 15:53:36.250+0900 I/Tizen::App(  949): (124) > app(ACL111OMWW.AclService), clientId(1084)
07-14 15:53:36.510+0900 I/Tizen::App(  949): (124) > app(ACL111OMWW.AclService), clientId(1084)
07-14 15:53:36.510+0900 E/LOCKSCREEN(  563): progress_circle.c: unlock_mouse_up(285) > 
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-14 15:53:36.510+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-14 15:53:36.760+0900 I/Tizen::App(  949): (124) > app(ACL111OMWW.AclService), clientId(1084)
07-14 15:53:37.010+0900 I/Tizen::App(  949): (124) > app(ACL111OMWW.AclService), clientId(1084)
07-14 15:53:37.020+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-14 15:53:37.020+0900 W/LOCKSCREEN(  563): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-14 15:53:37.020+0900 W/LOCKSCREEN(  563): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-14 15:53:37.030+0900 E/WALLPAPER_SERVICE_COMMON(  563): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 15:53:37.050+0900 W/PROCESSMGR(  374): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=589
07-14 15:53:37.060+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:53:37.070+0900 I/indicator(  496): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 589"
07-14 15:53:37.080+0900 I/CAPI_APPFW_APPLICATION(  589): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 15:53:37.080+0900 E/cluster-home(  589): homescreen-main.cpp: app_resume(422) >  app resume
07-14 15:53:37.120+0900 W/LOCKSCREEN(  563): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(1)
07-14 15:53:37.120+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-14 15:53:37.120+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-14 15:53:37.130+0900 I/CAPI_APPFW_APPLICATION(  563): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:53:37.130+0900 E/LOCKSCREEN(  563): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:53:37.130+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-14 15:53:37.130+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-14 15:53:37.130+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:53:37.140+0900 I/Tizen::System(  978): (259) > Active app [com.samsun], current [com.samsun] 
07-14 15:53:37.140+0900 I/Tizen::System(  978): (273) > Current App[com.samsun] is already actived.
07-14 15:53:37.140+0900 I/Tizen::System( 1084): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
07-14 15:53:37.260+0900 I/Tizen::App(  949): (124) > app(ACL111OMWW.AclService), clientId(1084)
07-14 15:53:37.270+0900 D/PowerManagerService( 1502): calling setSysScreenBrightness(brightness = 153)
07-14 15:53:37.270+0900 I/power   ( 1502): *** set_screen_state 1
07-14 15:53:37.270+0900 I/PowerManagerService-JNI( 1502): sending ACL screen state 'L'
07-14 15:53:37.270+0900 W/LOCKSCREEN(  563): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-14 15:53:37.270+0900 E/LOCKSCREEN(  563): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:53:37.270+0900 W/LOCKSCREEN(  563): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-14 15:53:37.270+0900 W/LOCKSCREEN(  563): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-14 15:53:37.280+0900 D/SensorService( 1502): actuateSensor
07-14 15:53:37.280+0900 D/AclServiceManager( 1502): -----*******------------ enableSensor  : 0
07-14 15:53:37.290+0900 D/SensorService( 1502): setSensorDelay
07-14 15:53:37.290+0900 D/AclServiceManager( 1502): -----*******------------ setSensorDelay : 0 to 200
07-14 15:53:37.290+0900 D/SensorService( 1502): setSensorDelay
07-14 15:53:37.300+0900 D/AclServiceManager( 1502): -----*******------------ setSensorDelay : 0 to 200
07-14 15:53:37.300+0900 E/LOCKSCREEN(  563): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-14 15:53:37.300+0900 D/ACL     ( 1502): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:53:37.310+0900 D/ACL     ( 1502): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-14 15:53:37.310+0900 I/PowerManagerService-JNI( 1502): sending ACL screen state 'F'
07-14 15:53:37.310+0900 I/AclService( 1084): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:53:37.320+0900 I/Tizen::System( 1084): (461) > change cpu power policy: keepAwake(true)
07-14 15:53:37.320+0900 I/AclService( 1084): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-14 15:53:37.320+0900 I/AclService( 1084): void minimize()(280) > Minimizing all vfb clients
07-14 15:53:37.320+0900 I/AclService( 1084): void minimize()(283) > minimizing {pkg=surfaceflinger fd=62}
07-14 15:53:37.340+0900 I/Tizen::System( 1084): (461) > change cpu power policy: keepAwake(false)
07-14 15:53:37.350+0900 E/Tizen::Io( 1084): (133) > [E_INVALID_ARG] The application id is empty.
07-14 15:53:37.350+0900 I/Tizen::Base::Runtime( 1084): (251) > The timer is not started.
07-14 15:53:37.620+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 15:53:37.740+0900 W/LOCKSCREEN(  563): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 15:53:37.760+0900 E/RESOURCED(  748): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
07-14 15:53:37.790+0900 E/RESOURCED(  748): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 346
07-14 15:53:37.800+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 3236.
07-14 15:53:37.810+0900 I/Tizen::App(  949): (499) > LaunchedApp(rMfxc1AKe2.tdlnaWeb)
07-14 15:53:37.810+0900 I/Tizen::App(  949): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 3236.
07-14 15:53:37.930+0900 I/UXT     ( 3238): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:53:37.980+0900 I/UXT     ( 3236): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:53:37.980+0900 I/EFL-ASSIST( 3238): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1965730) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:53:37.990+0900 I/EFL-ASSIST( 3238): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1965730) is freed
07-14 15:53:38.000+0900 I/EFL-ASSIST( 3238): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1965730) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:53:38.000+0900 I/EFL-ASSIST( 3238): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1965730) is freed
07-14 15:53:38.060+0900 E/PKGMGR_INFO( 3236): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 15:53:38.060+0900 I/APP_CORE( 3236): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 15:53:38.060+0900 I/APP_CORE( 3236): appcore-efl.c: __do_app(511) > [APP 3236] Initial Launching, call the resume_cb
07-14 15:53:38.210+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 15:53:38.210+0900 W/AUL_AMD (  459): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 15:53:38.210+0900 W/AUL_AMD (  459): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 15:53:38.260+0900 I/AUL     ( 3238): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:53:38.260+0900 E/EFL     ( 3236): elementary<3236> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x1a278e8 as sub object of 0x1a27628
07-14 15:53:38.280+0900 E/WEBKIT  ( 3236): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 15:53:38.310+0900 I/CAPI_NETWORK_CONNECTION( 3236): connection.c: connection_create(363) > New handle created[0xb1c00848]
07-14 15:53:38.310+0900 I/CAPI_NETWORK_CONNECTION( 3236): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 15:53:38.310+0900 I/CAPI_NETWORK_CONNECTION( 3236): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 15:53:38.310+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3236): system_settings.c: system_settings_set_changed_cb(541) > b3eb42b1
07-14 15:53:38.310+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3236): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3eb2d99
07-14 15:53:38.340+0900 I/EFL-ASSIST( 3236): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [1979aa8]
07-14 15:53:38.340+0900 I/EFL-ASSIST( 3236): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b1c175c8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:53:38.340+0900 I/EFL-ASSIST( 3236): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b1c175c8) is freed
07-14 15:53:38.440+0900 E/EFL     ( 3238): edje<3238> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 15:53:38.490+0900 E/EFL     ( 3236): evas_main<3236> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 15:53:38.510+0900 E/EFL     ( 3236): evas_main<3236> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 15:53:38.610+0900 W/PROCESSMGR(  374): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3236
07-14 15:53:38.620+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:53:38.630+0900 I/indicator(  496): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 3236"
07-14 15:53:38.630+0900 W/APP_CORE( 3236): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00003
07-14 15:53:38.650+0900 I/Tizen::System(  978): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 15:53:38.650+0900 I/Tizen::Io(  978): (729) > Entry not found
07-14 15:53:38.670+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:53:38.680+0900 I/Tizen::System(  978): (157) > change brightness system value.
07-14 15:53:38.690+0900 I/Tizen::System( 1084): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:53:38.710+0900 I/CAPI_APPFW_APPLICATION(  589): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:53:38.710+0900 E/cluster-home(  589): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:53:38.770+0900 W/AUL_AMD (  459): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:53:38.770+0900 W/AUL_AMD (  459): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:53:38.910+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:38.920+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:38.930+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:38.930+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:38.970+0900 I/UXT     ( 3259): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:53:38.970+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:38.990+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.000+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.000+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.010+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.030+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.040+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.040+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.040+0900 I/EFL-ASSIST( 3259): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1955350) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:53:39.050+0900 I/EFL-ASSIST( 3259): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1955350) is freed
07-14 15:53:39.050+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.070+0900 I/EFL-ASSIST( 3259): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1955350) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:53:39.070+0900 I/EFL-ASSIST( 3259): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1955350) is freed
07-14 15:53:39.080+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.080+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.080+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.090+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.100+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.100+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.100+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.110+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.120+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.120+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.120+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.130+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.140+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.140+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.140+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.150+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.160+0900 I/AUL     ( 3239): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:53:39.160+0900 E/AUL     ( 3239): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:53:39.160+0900 E/AUL     ( 3239): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:53:39.820+0900 E/WEBKIT  ( 3236): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 15:53:41.070+0900 I/MALI    ( 3236): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x19a5db8] swap changed from async to sync
07-14 15:53:41.250+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:53:41.460+0900 E/PKGMGR_INFO( 3238): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:53:41.540+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 15:53:41.550+0900 I/AUL     (  459): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:53:41.570+0900 W/AUL_AMD (  459): amd_launch.c: service_start(515) > child process: 3279
07-14 15:53:41.620+0900 W/AUL_AMD (  459): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 3279
07-14 15:53:41.630+0900 W/AUL_AMD (  459): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:53:41.640+0900 I/Tizen::App(  978): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 3279.
07-14 15:53:41.660+0900 I/Tizen::App(  949): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 15:53:41.660+0900 I/Tizen::App(  949): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 3279.
07-14 15:53:41.710+0900 I/tdlna   ( 3279): _on_create_cb 실행
07-14 15:53:41.710+0900 I/tdlna   ( 3279): _app_init 실행
07-14 15:53:41.710+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:53:41.730+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:53:41.730+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 3279
07-14 15:53:41.750+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:41.750+0900 D/tdlnaservice( 3279): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 15:53:41.750+0900 I/tdlna   ( 3279): _on_app_control_callback 실행
07-14 15:53:41.760+0900 I/tdlna   ( 3279): _app_timer_thread_func 실행
07-14 15:53:41.870+0900 E/PKGMGR_INFO( 3238): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:53:42.140+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:53:42.150+0900 I/AUL     ( 3238): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:53:42.150+0900 I/AUL     (  388): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 3238
07-14 15:53:42.160+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:42.170+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.180+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.190+0900 D/tdlnaservice( 3279): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:53:42.190+0900 I/tdlna   ( 3279): _on_proxy_client_msg_received_cb 실행
07-14 15:53:42.190+0900 I/tdlna   ( 3279): _app_process_received_message 실행
07-14 15:53:42.190+0900 I/tdlna   ( 3279): _app_execute_operation 실행
07-14 15:53:42.190+0900 I/tdlna   ( 3279): _app_send_response 실행
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:53:42.190+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.190+0900 D/tdlnaservice( 3279): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:42.230+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.250+0900 D/tdlnaservice( 3279): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:53:42.250+0900 I/tdlna   ( 3279): _on_proxy_client_msg_received_cb 실행
07-14 15:53:42.250+0900 I/tdlna   ( 3279): _app_process_received_message 실행
07-14 15:53:42.250+0900 I/tdlna   ( 3279): _app_execute_operation 실행
07-14 15:53:42.250+0900 D/tdlnaservice( 3279): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 15:53:42.250+0900 I/tdlna   ( 3279): _app_run_timer 실행
07-14 15:53:42.250+0900 I/tdlna   ( 3279): _app_run_timer 실행
07-14 15:53:42.250+0900 I/tdlna   ( 3279): _app_send_response 실행
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:53:42.250+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:42.250+0900 D/tdlnaservice( 3279): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:42.280+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:43.270+0900 D/PowerManagerService( 1502): calling setSysScreenBrightness(brightness = 153)
07-14 15:53:43.270+0900 I/AclService( 1084): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:46.530+0900 D/tdlnaservice( 3279): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:53:46.530+0900 I/tdlna   ( 3279): _on_proxy_client_msg_received_cb 실행
07-14 15:53:46.530+0900 I/tdlna   ( 3279): _app_process_received_message 실행
07-14 15:53:46.530+0900 I/tdlna   ( 3279): test _ _app_process_received_message
07-14 15:53:46.530+0900 I/tdlna   ( 3279): _app_execute_operation 실행
07-14 15:53:46.530+0900 I/tdlna   ( 3279): test 실행
07-14 15:53:46.530+0900 I/tdlna   ( 3279): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:53:46.530+0900 I/tdlna   ( 3279): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:53:46.530+0900 I/tdlna   ( 3279): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:53:46.530+0900 I/tdlna   ( 3279): _app_send_response 실행
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:53:46.530+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:46.530+0900 I/tdlna   ( 3279): Main Start !!! 1
07-14 15:53:46.530+0900 I/tdlna   ( 3279): Service Start !!! 1
07-14 15:53:46.530+0900 I/tdlna   ( 3279): shttpl - 18
07-14 15:53:46.530+0900 I/tdlna   ( 3279): fork 전
07-14 15:53:46.540+0900 D/tdlnaservice( 3279): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:53:46.540+0900 I/tdlna   ( 3279): Main precess Start !! 3307
07-14 15:53:46.540+0900 I/tdlna   ( 3307): fork child process 1
07-14 15:53:46.540+0900 I/tdlna   ( 3307): ssdp running
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:53:46.570+0900 I/MESSAGE_PORT(  388): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:53:46.870+0900 W/CRASH_MANAGER( 3309): worker.c: worker_job(1236) > 110327974646c143685682
