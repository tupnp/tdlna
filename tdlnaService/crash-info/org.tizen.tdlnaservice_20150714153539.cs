S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 2758
Date: 2015-07-14 15:35:39+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe3580000

Register Information
r0   = 0xe3580002, r1   = 0xe3580000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f93672
r6   = 0xb5caf448, r7   = 0xe3580002
r8   = 0x0000001e, r9   = 0xb5cb06f0
r10  = 0xb6f93653, fp   = 0xb5caf43c
ip   = 0x00000000, sp   = 0xb5caeed8
lr   = 0xb6dfe5b8, pc   = 0xb6e31d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     20940 KB
Buffers:     27464 KB
Cached:     271976 KB
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
PID = 2758 TID = 3510
2758 2766 3510 

Maps Information
b54b2000 b5cb1000 rwxp [stack:3510]
b5cb2000 b64b5000 rwxp [stack:2766]
b64b5000 b64b8000 r-xp /lib/libgpg-error.so.0.5.0
b64bf000 b64c0000 rwxp /lib/libgpg-error.so.0.5.0
b64c0000 b6518000 r-xp /usr/lib/libgcrypt.so.11.5.3
b651f000 b6522000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6523000 b654f000 r-xp /usr/lib/libsystemd.so.0.0.1
b6556000 b6557000 r-xp /usr/lib/libsystemd.so.0.0.1
b6557000 b6558000 rwxp /usr/lib/libsystemd.so.0.0.1
b6558000 b655a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6561000 b6562000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6562000 b662d000 r-xp /usr/lib/libxml2.so.2.7.8
b6635000 b663a000 rwxp /usr/lib/libxml2.so.2.7.8
b663b000 b664b000 r-xp /lib/libresolv-2.13.so
b664b000 b664c000 r-xp /lib/libresolv-2.13.so
b664c000 b664d000 rwxp /lib/libresolv-2.13.so
b6650000 b6666000 r-xp /lib/libz.so.1.2.5
b666d000 b666e000 rwxp /lib/libz.so.1.2.5
b666e000 b6670000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6677000 b6678000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b6678000 b667d000 r-xp /usr/lib/libffi.so.5.0.10
b6684000 b6685000 rwxp /usr/lib/libffi.so.5.0.10
b6685000 b6686000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b668d000 b668e000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b668e000 b66f3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66fa000 b66fd000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66fe000 b6701000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6708000 b6709000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6709000 b68b1000 r-xp /usr/lib/libcrypto.so.1.0.0
b68b8000 b68cd000 rwxp /usr/lib/libcrypto.so.1.0.0
b68d1000 b68e7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68ee000 b68ef000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b68ef000 b6923000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b692a000 b692c000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b692c000 b6a00000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a08000 b6a0b000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a0d000 b6a11000 r-xp /usr/lib/libchromium.so.1.0
b6a18000 b6a19000 rwxp /usr/lib/libchromium.so.1.0
b6a19000 b6a82000 r-xp /lib/libm-2.13.so
b6a89000 b6a8a000 r-xp /lib/libm-2.13.so
b6a8a000 b6a8b000 rwxp /lib/libm-2.13.so
b6a8b000 b6a91000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a98000 b6a99000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a99000 b6ab8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6abf000 b6ac0000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6ac0000 b6ac3000 r-xp /usr/lib/libsmack.so.1.0.0
b6aca000 b6acb000 rwxp /usr/lib/libsmack.so.1.0.0
b6acb000 b6ad0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ad8000 b6ad9000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6ad9000 b6b03000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b0b000 b6b0c000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b0c000 b6b23000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b2b000 b6b2c000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b2c000 b6bc0000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bc8000 b6bcb000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bcb000 b6bcd000 rwxp /usr/lib/libstdc++.so.6.0.16
b6bd3000 b6bde000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6be5000 b6be6000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6be6000 b6beb000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6bf3000 b6bf4000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6bf4000 b6cc4000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6cc4000 b6cc5000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6cc5000 b6d05000 r-xp /usr/lib/libeina.so.1.7.99
b6d0c000 b6d0d000 rwxp /usr/lib/libeina.so.1.7.99
b6d0e000 b6d24000 r-xp /usr/lib/libecore.so.1.7.99
b6d2b000 b6d2c000 rwxp /usr/lib/libecore.so.1.7.99
b6d3a000 b6d41000 r-xp /usr/lib/libvconf.so.0.2.45
b6d49000 b6d4a000 rwxp /usr/lib/libvconf.so.0.2.45
b6d4a000 b6d4f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d56000 b6d57000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d57000 b6d62000 r-xp /usr/lib/libaul.so.0.1.0
b6d6a000 b6d6b000 rwxp /usr/lib/libaul.so.0.1.0
b6d6c000 b6d74000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d7b000 b6d7c000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d7c000 b6d7e000 r-xp /lib/libdl-2.13.so
b6d85000 b6d86000 r-xp /lib/libdl-2.13.so
b6d86000 b6d87000 rwxp /lib/libdl-2.13.so
b6d87000 b6d92000 r-xp /lib/libunwind.so.8.0.1
b6d99000 b6d9a000 rwxp /lib/libunwind.so.8.0.1
b6dbf000 b6eda000 r-xp /lib/libc-2.13.so
b6ee2000 b6ee4000 r-xp /lib/libc-2.13.so
b6ee4000 b6ee5000 rwxp /lib/libc-2.13.so
b6ee8000 b6eee000 r-xp /lib/librt-2.13.so
b6ef5000 b6ef6000 r-xp /lib/librt-2.13.so
b6ef6000 b6ef7000 rwxp /lib/librt-2.13.so
b6ef7000 b6ef9000 r-xp /usr/lib/libdlog.so.0.0.0
b6f00000 b6f01000 rwxp /usr/lib/libdlog.so.0.0.0
b6f01000 b6f04000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f0b000 b6f0c000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f0c000 b6f0f000 r-xp /usr/lib/libbundle.so.0.1.22
b6f16000 b6f17000 rwxp /usr/lib/libbundle.so.0.1.22
b6f17000 b6f1a000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f21000 b6f22000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f22000 b6f36000 r-xp /lib/libpthread-2.13.so
b6f3d000 b6f3e000 r-xp /lib/libpthread-2.13.so
b6f3e000 b6f3f000 rwxp /lib/libpthread-2.13.so
b6f56000 b6f5a000 r-xp /usr/lib/libsys-assert.so
b6f62000 b6f63000 rwxp /usr/lib/libsys-assert.so
b6f63000 b6f80000 r-xp /lib/ld-2.13.so
b6f87000 b6f88000 r-xp /lib/ld-2.13.so
b6f88000 b6f89000 rwxp /lib/ld-2.13.so
b6f89000 b6f96000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f9d000 b6f9f000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b712d000 b7172000 rwxp [heap]
be934000 be955000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2758)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e31d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6dfe5b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e96b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ef8063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x42c (0xb6f8e119) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5119
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
40+0900 E/VOLUME  (  589): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-14 15:35:17.740+0900 E/VOLUME  (  589): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-14 15:35:17.740+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:0:LKD_EVT_WILL_LOCK
07-14 15:35:17.740+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:0 event_info:0
07-14 15:35:17.740+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:0 event_info:0
07-14 15:35:17.750+0900 E/VOLUME  (  589): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-14 15:35:17.760+0900 I/Tizen::Base::Runtime( 1077): (251) > The timer is not started.
07-14 15:35:17.760+0900 D/PowerManagerService( 1518): calling setSysScreenBrightness(brightness = 153)
07-14 15:35:17.770+0900 I/power   ( 1518): *** set_screen_state 0
07-14 15:35:17.770+0900 I/PowerManagerService-JNI( 1518): sending ACL screen state 'L'
07-14 15:35:17.770+0900 I/AclService( 1077): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:35:17.770+0900 I/Tizen::System( 1077): (461) > change cpu power policy: keepAwake(true)
07-14 15:35:17.770+0900 D/SensorService( 1518): actuateSensor
07-14 15:35:17.770+0900 D/AclServiceManager( 1518): -----*******------------ disableSensor  : 0
07-14 15:35:17.770+0900 I/PowerManagerService-JNI( 1518): sending ACL screen state 'L'
07-14 15:35:17.800+0900 I/Tizen::System( 1077): (461) > change cpu power policy: keepAwake(true)
07-14 15:35:17.810+0900 D/ACL     ( 1518): ************ onActivitySaveInstanceState()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:35:17.820+0900 D/ACL     ( 1518): ************ onActivityPaused()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:35:17.820+0900 D/ACL     ( 1518): Pausing app with base activity ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:35:17.820+0900 I/PowerManagerService-JNI( 1518): sending ACL screen state 'F'
07-14 15:35:17.820+0900 I/Tizen::System( 1077): (461) > change cpu power policy: keepAwake(false)
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): event.c: _lcd_off_source_cb(47) > [_lcd_off_source_cb:47:W] Vconf LCD off
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30002:LCD_OFF
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:30002 event_info:0
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:5
07-14 15:35:17.880+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => PAUSE
07-14 15:35:17.890+0900 E/WALLPAPER_SERVICE_COMMON(  576): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 15:35:17.900+0900 I/CAPI_APPFW_APPLICATION(  597): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:35:17.900+0900 E/cluster-home(  597): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:35:17.900+0900 W/PROCESSMGR(  418): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=576
07-14 15:35:17.940+0900 W/AUL_AMD (  441): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:35:17.940+0900 W/AUL_AMD (  441): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:35:17.950+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-14 15:35:17.950+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-14 15:35:17.950+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-14 15:35:17.950+0900 W/AUL_AMD (  441): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:35:17.950+0900 W/AUL_AMD (  441): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 15:35:17.950+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:35:17.960+0900 I/indicator(  510): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 576"
07-14 15:35:17.970+0900 W/LOCKSCREEN(  576): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(0)
07-14 15:35:17.970+0900 I/MALI    (  597): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xafe24918] swap changed from sync to async
07-14 15:35:17.970+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-14 15:35:17.970+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-14 15:35:17.970+0900 I/CAPI_APPFW_APPLICATION(  576): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 15:35:17.970+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-14 15:35:17.970+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-14 15:35:18.000+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:35:18.010+0900 I/Tizen::System( 1077): (101) > Active App is com.samsung.lockscreen. GetApp id ACL111OMWW.AclService
07-14 15:35:18.020+0900 I/Tizen::System( 1011): (259) > Active app [com.samsun], current [] 
07-14 15:35:18.020+0900 I/Tizen::Io( 1011): (729) > Entry not found
07-14 15:35:18.030+0900 I/Tizen::System( 1011): (157) > change brightness system value.
07-14 15:35:18.380+0900 W/LOCKSCREEN(  576): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-14 15:35:26.140+0900 W/LOCKSCREEN(  576): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-14 15:35:26.140+0900 W/LOCKSCREEN(  576): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-14 15:35:26.140+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-14 15:35:26.140+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-14 15:35:26.140+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 15:35:26.140+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-14 15:35:26.140+0900 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:35:26.150+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 15:35:26.150+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 15:35:26.150+0900 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-14 15:35:26.160+0900 I/indicator(  510): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 307 331 5 28 25"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 15:35:26.160+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 308 387 5 28 25"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 307 651 5 28 25"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 15:35:26.190+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 308 707 5 28 25"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 307 331 5 28 25"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 308 387 5 28 25"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 307 651 5 28 25"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 15:35:26.200+0900 I/indicator(  510): indicator_box_util.c: _update_display(585) > "Noti Icon : 308 707 5 28 25"
07-14 15:35:26.800+0900 W/CAM_APP ( 1141): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 15:35:26.800+0900 I/Tizen::System( 1011): (280) > The screen has been turned on.
07-14 15:35:26.800+0900 I/Tizen::Io( 1011): (729) > Entry not found
07-14 15:35:26.810+0900 I/Tizen::Shell( 1077): (73) > Enter.
07-14 15:35:26.820+0900 I/Tizen::Shell( 1077): (47) > Enter.
07-14 15:35:26.820+0900 I/Tizen::Shell( 1077): (93) > LockManager is constructed.
07-14 15:35:26.820+0900 I/Tizen::Shell( 1077): (58) > Exit.
07-14 15:35:26.820+0900 I/Tizen::Shell( 1077): (81) > Exit.
07-14 15:35:26.820+0900 I/Tizen::Shell( 1077): (95) > Enter.
07-14 15:35:26.820+0900 I/Tizen::System( 1011): (157) > change brightness system value.
07-14 15:35:26.830+0900 I/Tizen::App( 1077): (109) > Succeeded in connecting service(osp.shell.ipcserver.lockmanager)
07-14 15:35:26.830+0900 I/Tizen::App(  954): (147) > _LockManagerStub::OnIpcClientConnected (clientId:1077)
07-14 15:35:26.840+0900 I/Tizen::App(  954): (124) > app(ACL111OMWW.AclService), clientId(1077)
07-14 15:35:27.090+0900 I/Tizen::App(  954): (124) > app(ACL111OMWW.AclService), clientId(1077)
07-14 15:35:27.170+0900 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-14 15:35:27.170+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-14 15:35:27.350+0900 I/Tizen::App(  954): (124) > app(ACL111OMWW.AclService), clientId(1077)
07-14 15:35:27.600+0900 I/Tizen::App(  954): (124) > app(ACL111OMWW.AclService), clientId(1077)
07-14 15:35:27.670+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-14 15:35:27.670+0900 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-14 15:35:27.670+0900 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-14 15:35:27.680+0900 E/WALLPAPER_SERVICE_COMMON(  576): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 15:35:27.690+0900 W/PROCESSMGR(  418): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=597
07-14 15:35:27.700+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:35:27.710+0900 I/indicator(  510): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 597"
07-14 15:35:27.730+0900 I/CAPI_APPFW_APPLICATION(  597): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 15:35:27.730+0900 E/cluster-home(  597): homescreen-main.cpp: app_resume(422) >  app resume
07-14 15:35:27.760+0900 W/LOCKSCREEN(  576): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(1)
07-14 15:35:27.760+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-14 15:35:27.760+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-14 15:35:27.760+0900 I/CAPI_APPFW_APPLICATION(  576): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:35:27.760+0900 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:35:27.760+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-14 15:35:27.760+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-14 15:35:27.780+0900 I/Tizen::System( 1011): (259) > Active app [com.samsun], current [com.samsun] 
07-14 15:35:27.780+0900 I/Tizen::System( 1011): (273) > Current App[com.samsun] is already actived.
07-14 15:35:27.790+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:35:27.800+0900 I/Tizen::System( 1077): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
07-14 15:35:27.850+0900 I/Tizen::App(  954): (124) > app(ACL111OMWW.AclService), clientId(1077)
07-14 15:35:27.860+0900 D/PowerManagerService( 1518): calling setSysScreenBrightness(brightness = 153)
07-14 15:35:27.860+0900 I/power   ( 1518): *** set_screen_state 1
07-14 15:35:27.860+0900 I/PowerManagerService-JNI( 1518): sending ACL screen state 'L'
07-14 15:35:27.860+0900 D/SensorService( 1518): actuateSensor
07-14 15:35:27.860+0900 D/AclServiceManager( 1518): -----*******------------ enableSensor  : 0
07-14 15:35:27.870+0900 D/SensorService( 1518): setSensorDelay
07-14 15:35:27.870+0900 D/AclServiceManager( 1518): -----*******------------ setSensorDelay : 0 to 200
07-14 15:35:27.870+0900 D/SensorService( 1518): setSensorDelay
07-14 15:35:27.870+0900 D/AclServiceManager( 1518): -----*******------------ setSensorDelay : 0 to 200
07-14 15:35:27.880+0900 D/ACL     ( 1518): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 15:35:27.880+0900 D/ACL     ( 1518): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-14 15:35:27.890+0900 I/AclService( 1077): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-14 15:35:27.890+0900 I/AclService( 1077): void minimize()(280) > Minimizing all vfb clients
07-14 15:35:27.890+0900 I/AclService( 1077): void minimize()(283) > minimizing {pkg=surfaceflinger fd=101}
07-14 15:35:27.890+0900 I/AclService( 1077): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:35:27.890+0900 I/PowerManagerService-JNI( 1518): sending ACL screen state 'F'
07-14 15:35:27.910+0900 I/Tizen::System( 1077): (461) > change cpu power policy: keepAwake(true)
07-14 15:35:27.910+0900 E/Tizen::Io( 1077): (133) > [E_INVALID_ARG] The application id is empty.
07-14 15:35:27.910+0900 I/Tizen::Base::Runtime( 1077): (251) > The timer is not started.
07-14 15:35:27.920+0900 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-14 15:35:27.920+0900 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 15:35:27.920+0900 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-14 15:35:27.920+0900 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-14 15:35:27.940+0900 I/Tizen::System( 1077): (461) > change cpu power policy: keepAwake(false)
07-14 15:35:27.940+0900 E/LOCKSCREEN(  576): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-14 15:35:28.320+0900 W/LOCKSCREEN(  576): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 15:35:28.820+0900 W/test-log(  597): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:35:28.820+0900 W/test-log(  597): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:35:28.820+0900 W/test-log(  597): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:35:28.820+0900 W/test-log(  597): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:35:28.820+0900 W/test-log(  597): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:35:29.490+0900 W/BROWSER_PROVIDER(  974): browser-provider-requests-manager.c: bp_thread_requests_manager(894) > Expire Idle state. No Client.
07-14 15:35:29.490+0900 W/BROWSER_PROVIDER(  974): browser-provider-requests-manager.c: bp_thread_requests_manager(903) > terminate main thread ...
07-14 15:35:29.490+0900 W/BROWSER_PROVIDER(  974): browser-provider-main.c: main(178) > Browser-Provider will be terminated.
07-14 15:35:29.620+0900 W/cluster-view(  597): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:35:29.730+0900 I/MALI    (  597): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xafe24918] swap changed from async to sync
07-14 15:35:30.240+0900 W/cluster-view(  597): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:35:30.770+0900 W/cluster-view(  597): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:35:31.260+0900 W/cluster-view(  597): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:35:32.400+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 15:35:32.500+0900 E/RESOURCED(  753): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
07-14 15:35:32.510+0900 I/Tizen::App(  954): (499) > LaunchedApp(rMfxc1AKe2.tdlnaWeb)
07-14 15:35:32.510+0900 I/Tizen::App(  954): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 3456.
07-14 15:35:32.510+0900 E/RESOURCED(  753): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 340
07-14 15:35:32.520+0900 I/Tizen::App( 1011): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 3456.
07-14 15:35:32.610+0900 I/UXT     ( 3460): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:35:32.640+0900 I/EFL-ASSIST( 3460): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e44590) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:35:32.640+0900 I/EFL-ASSIST( 3460): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e44590) is freed
07-14 15:35:32.650+0900 I/EFL-ASSIST( 3460): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e44590) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:35:32.650+0900 I/EFL-ASSIST( 3460): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e44590) is freed
07-14 15:35:32.650+0900 I/UXT     ( 3456): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:35:32.700+0900 E/PKGMGR_INFO( 3456): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 15:35:32.700+0900 I/APP_CORE( 3456): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 15:35:32.700+0900 I/APP_CORE( 3456): appcore-efl.c: __do_app(511) > [APP 3456] Initial Launching, call the resume_cb
07-14 15:35:32.840+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 15:35:32.840+0900 W/AUL_AMD (  441): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 15:35:32.840+0900 W/AUL_AMD (  441): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 15:35:32.890+0900 I/AUL     ( 3460): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:35:32.890+0900 E/EFL     ( 3456): elementary<3456> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x1f3c400 as sub object of 0x1f3c140
07-14 15:35:32.910+0900 W/ProcessStats( 1518): Skipping unknown process pid 3456
07-14 15:35:32.910+0900 W/ProcessStats( 1518): Skipping unknown process pid 3458
07-14 15:35:32.910+0900 E/WEBKIT  ( 3456): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 15:35:32.910+0900 W/ProcessStats( 1518): Skipping unknown process pid 3460
07-14 15:35:32.960+0900 I/CAPI_NETWORK_CONNECTION( 3456): connection.c: connection_create(363) > New handle created[0x1f78f80]
07-14 15:35:32.960+0900 I/CAPI_NETWORK_CONNECTION( 3456): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 15:35:32.960+0900 I/CAPI_NETWORK_CONNECTION( 3456): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 15:35:32.960+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3456): system_settings.c: system_settings_set_changed_cb(541) > b3e732b1
07-14 15:35:32.960+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3456): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3e71d99
07-14 15:35:32.980+0900 I/EFL-ASSIST( 3456): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [1e8e948]
07-14 15:35:32.990+0900 I/EFL-ASSIST( 3456): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e37c18) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:35:32.990+0900 I/EFL-ASSIST( 3456): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e37c18) is freed
07-14 15:35:33.090+0900 E/EFL     ( 3460): edje<3460> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 15:35:33.140+0900 E/EFL     ( 3456): evas_main<3456> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 15:35:33.150+0900 E/EFL     ( 3456): evas_main<3456> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 15:35:33.260+0900 W/PROCESSMGR(  418): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3456
07-14 15:35:33.310+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:35:33.310+0900 W/APP_CORE( 3456): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00003
07-14 15:35:33.310+0900 I/indicator(  510): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 3456"
07-14 15:35:33.330+0900 I/MALI    (  597): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xafe24918] swap changed from sync to async
07-14 15:35:33.360+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:35:33.360+0900 I/Tizen::System( 1077): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:35:33.370+0900 I/Tizen::System( 1011): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 15:35:33.370+0900 I/Tizen::Io( 1011): (729) > Entry not found
07-14 15:35:33.400+0900 I/CAPI_APPFW_APPLICATION(  597): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:35:33.400+0900 E/cluster-home(  597): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:35:33.420+0900 I/Tizen::System( 1011): (157) > change brightness system value.
07-14 15:35:33.630+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.700+0900 I/UXT     ( 3487): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:35:33.710+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.710+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.710+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.730+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.780+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.780+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.780+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.790+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.790+0900 I/EFL-ASSIST( 3487): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e34298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:35:33.790+0900 I/EFL-ASSIST( 3487): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e34298) is freed
07-14 15:35:33.830+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.840+0900 I/EFL-ASSIST( 3487): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e34298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:35:33.840+0900 I/EFL-ASSIST( 3487): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e34298) is freed
07-14 15:35:33.850+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.850+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.860+0900 D/PowerManagerService( 1518): calling setSysScreenBrightness(brightness = 153)
07-14 15:35:33.860+0900 I/AclService( 1077): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 15:35:33.870+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.890+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.890+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.890+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.910+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.920+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.920+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.920+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.940+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.960+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.960+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.960+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.970+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.980+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:33.980+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:33.980+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:33.990+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:34.000+0900 I/AUL     ( 3457): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:35:34.010+0900 E/AUL     ( 3457): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:35:34.010+0900 E/AUL     ( 3457): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:35:34.380+0900 E/WEBKIT  ( 3456): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 15:35:35.320+0900 W/AUL_AMD (  441): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:35:35.540+0900 E/PKGMGR_INFO( 3460): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:35:35.760+0900 I/MALI    ( 3456): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x1ebab60] swap changed from async to sync
07-14 15:35:35.800+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:35:35.800+0900 I/AUL     ( 3460): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:35:35.800+0900 I/AUL     (  375): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:35:35.810+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:35:35.810+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 3460
07-14 15:35:35.820+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:35.830+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:35:35.840+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.850+0900 D/tdlnaservice( 2758): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:35:35.850+0900 I/tdlna   ( 2758): _on_proxy_client_msg_received_cb 실행
07-14 15:35:35.850+0900 I/tdlna   ( 2758): _app_process_received_message 실행
07-14 15:35:35.850+0900 I/tdlna   ( 2758): _app_execute_operation 실행
07-14 15:35:35.850+0900 I/tdlna   ( 2758): _app_send_response 실행
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:35:35.850+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.850+0900 D/tdlnaservice( 2758): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:35.880+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.900+0900 D/tdlnaservice( 2758): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:35:35.900+0900 I/tdlna   ( 2758): _on_proxy_client_msg_received_cb 실행
07-14 15:35:35.900+0900 I/tdlna   ( 2758): _app_process_received_message 실행
07-14 15:35:35.900+0900 I/tdlna   ( 2758): _app_execute_operation 실행
07-14 15:35:35.900+0900 D/tdlnaservice( 2758): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 15:35:35.900+0900 I/tdlna   ( 2758): _app_run_timer 실행
07-14 15:35:35.900+0900 I/tdlna   ( 2758): _app_run_timer 실행
07-14 15:35:35.900+0900 I/tdlna   ( 2758): _app_send_response 실행
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:35:35.900+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:35.900+0900 D/tdlnaservice( 2758): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:35.920+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:39.000+0900 D/tdlnaservice( 2758): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:35:39.000+0900 I/tdlna   ( 2758): _on_proxy_client_msg_received_cb 실행
07-14 15:35:39.000+0900 I/tdlna   ( 2758): _app_process_received_message 실행
07-14 15:35:39.000+0900 I/tdlna   ( 2758): test _ _app_process_received_message
07-14 15:35:39.000+0900 I/tdlna   ( 2758): _app_execute_operation 실행
07-14 15:35:39.000+0900 I/tdlna   ( 2758): test 실행
07-14 15:35:39.000+0900 I/tdlna   ( 2758): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:35:39.000+0900 I/tdlna   ( 2758): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:35:39.000+0900 I/tdlna   ( 2758): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:35:39.000+0900 I/tdlna   ( 2758): _app_send_response 실행
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:35:39.000+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:39.000+0900 D/tdlnaservice( 2758): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:35:39.000+0900 I/tdlna   ( 2758): Main Start !!! 1
07-14 15:35:39.000+0900 I/tdlna   ( 2758): Service Start !!! 1
07-14 15:35:39.000+0900 I/tdlna   ( 2758): fork 전
07-14 15:35:39.000+0900 I/tdlna   ( 2758): Main precess Start !! 3511
07-14 15:35:39.000+0900 I/tdlna   ( 3511): fork child process 1
07-14 15:35:39.000+0900 I/tdlna   ( 3511): ssdp running
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:35:39.020+0900 I/MESSAGE_PORT(  375): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:35:39.450+0900 W/CRASH_MANAGER( 3514): worker.c: worker_job(1236) > 110275874646c143685573
