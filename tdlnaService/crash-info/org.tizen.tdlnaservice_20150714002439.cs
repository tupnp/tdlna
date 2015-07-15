S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 4972
Date: 2015-07-14 00:24:39+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8d850000

Register Information
r0   = 0x8d850002, r1   = 0x8d850000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f2c558
r6   = 0xb5c48460, r7   = 0x8d850002
r8   = 0x0000001e, r9   = 0xb5c496f0
r10  = 0xb6f2c539, fp   = 0xb5c48454
ip   = 0x00000000, sp   = 0xb5c47ef0
lr   = 0xb6d975b8, pc   = 0xb6dcad64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     22072 KB
Buffers:     28396 KB
Cached:     271900 KB
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
PID = 4972 TID = 5040
4972 4975 5040 

Maps Information
b544b000 b5c4a000 rwxp [stack:5040]
b5c4b000 b644e000 rwxp [stack:4975]
b644e000 b6451000 r-xp /lib/libgpg-error.so.0.5.0
b6458000 b6459000 rwxp /lib/libgpg-error.so.0.5.0
b6459000 b64b1000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64b8000 b64bb000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64bc000 b64e8000 r-xp /usr/lib/libsystemd.so.0.0.1
b64ef000 b64f0000 r-xp /usr/lib/libsystemd.so.0.0.1
b64f0000 b64f1000 rwxp /usr/lib/libsystemd.so.0.0.1
b64f1000 b64f3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b64fa000 b64fb000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b64fb000 b65c6000 r-xp /usr/lib/libxml2.so.2.7.8
b65ce000 b65d3000 rwxp /usr/lib/libxml2.so.2.7.8
b65d4000 b65e4000 r-xp /lib/libresolv-2.13.so
b65e4000 b65e5000 r-xp /lib/libresolv-2.13.so
b65e5000 b65e6000 rwxp /lib/libresolv-2.13.so
b65e9000 b65ff000 r-xp /lib/libz.so.1.2.5
b6606000 b6607000 rwxp /lib/libz.so.1.2.5
b6607000 b6609000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6610000 b6611000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b6611000 b6616000 r-xp /usr/lib/libffi.so.5.0.10
b661d000 b661e000 rwxp /usr/lib/libffi.so.5.0.10
b661e000 b661f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6626000 b6627000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6627000 b668c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6693000 b6696000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6697000 b669a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66a1000 b66a2000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66a2000 b684a000 r-xp /usr/lib/libcrypto.so.1.0.0
b6851000 b6866000 rwxp /usr/lib/libcrypto.so.1.0.0
b686a000 b6880000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6887000 b6888000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6888000 b68bc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68c3000 b68c5000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68c5000 b6999000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69a1000 b69a4000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69a6000 b69aa000 r-xp /usr/lib/libchromium.so.1.0
b69b1000 b69b2000 rwxp /usr/lib/libchromium.so.1.0
b69b2000 b6a1b000 r-xp /lib/libm-2.13.so
b6a22000 b6a23000 r-xp /lib/libm-2.13.so
b6a23000 b6a24000 rwxp /lib/libm-2.13.so
b6a24000 b6a2a000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a31000 b6a32000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a32000 b6a51000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a58000 b6a59000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a59000 b6a5c000 r-xp /usr/lib/libsmack.so.1.0.0
b6a63000 b6a64000 rwxp /usr/lib/libsmack.so.1.0.0
b6a64000 b6a69000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a71000 b6a72000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a72000 b6a9c000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6aa4000 b6aa5000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6aa5000 b6abc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6ac4000 b6ac5000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6ac5000 b6b59000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b61000 b6b64000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b64000 b6b66000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b6c000 b6b77000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6b7e000 b6b7f000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6b7f000 b6b84000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b8c000 b6b8d000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6b8d000 b6c5d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c5d000 b6c5e000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c5e000 b6c9e000 r-xp /usr/lib/libeina.so.1.7.99
b6ca5000 b6ca6000 rwxp /usr/lib/libeina.so.1.7.99
b6ca7000 b6cbd000 r-xp /usr/lib/libecore.so.1.7.99
b6cc4000 b6cc5000 rwxp /usr/lib/libecore.so.1.7.99
b6cd3000 b6cda000 r-xp /usr/lib/libvconf.so.0.2.45
b6ce2000 b6ce3000 rwxp /usr/lib/libvconf.so.0.2.45
b6ce3000 b6ce8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cef000 b6cf0000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cf0000 b6cfb000 r-xp /usr/lib/libaul.so.0.1.0
b6d03000 b6d04000 rwxp /usr/lib/libaul.so.0.1.0
b6d05000 b6d0d000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d14000 b6d15000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d15000 b6d17000 r-xp /lib/libdl-2.13.so
b6d1e000 b6d1f000 r-xp /lib/libdl-2.13.so
b6d1f000 b6d20000 rwxp /lib/libdl-2.13.so
b6d20000 b6d2b000 r-xp /lib/libunwind.so.8.0.1
b6d32000 b6d33000 rwxp /lib/libunwind.so.8.0.1
b6d58000 b6e73000 r-xp /lib/libc-2.13.so
b6e7b000 b6e7d000 r-xp /lib/libc-2.13.so
b6e7d000 b6e7e000 rwxp /lib/libc-2.13.so
b6e81000 b6e87000 r-xp /lib/librt-2.13.so
b6e8e000 b6e8f000 r-xp /lib/librt-2.13.so
b6e8f000 b6e90000 rwxp /lib/librt-2.13.so
b6e90000 b6e92000 r-xp /usr/lib/libdlog.so.0.0.0
b6e99000 b6e9a000 rwxp /usr/lib/libdlog.so.0.0.0
b6e9a000 b6e9d000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ea4000 b6ea5000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ea5000 b6ea8000 r-xp /usr/lib/libbundle.so.0.1.22
b6eaf000 b6eb0000 rwxp /usr/lib/libbundle.so.0.1.22
b6eb0000 b6eb3000 r-xp /usr/lib/libappcore-agent.so.1.1
b6eba000 b6ebb000 rwxp /usr/lib/libappcore-agent.so.1.1
b6ebb000 b6ecf000 r-xp /lib/libpthread-2.13.so
b6ed6000 b6ed7000 r-xp /lib/libpthread-2.13.so
b6ed7000 b6ed8000 rwxp /lib/libpthread-2.13.so
b6eef000 b6ef3000 r-xp /usr/lib/libsys-assert.so
b6efb000 b6efc000 rwxp /usr/lib/libsys-assert.so
b6efc000 b6f19000 r-xp /lib/ld-2.13.so
b6f20000 b6f21000 r-xp /lib/ld-2.13.so
b6f21000 b6f22000 rwxp /lib/ld-2.13.so
b6f22000 b6f2e000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f36000 b6f38000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b86d2000 b8717000 rwxp [heap]
bee74000 bee95000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4972)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6dcad64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6d975b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e2fb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6e91063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3f0 (0xb6f2712d) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x512d
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
23:00.025+0900 I/Tizen::System( 1032): (85) > Current Epoch is 1436800980.
07-14 00:23:00.025+0900 I/Tizen::System( 1032): (89) > Calendar time is sec:0, min:23, hour:15, day:13, mon:6, year:115, wday1, year:193, dst:0
07-14 00:23:00.025+0900 I/Tizen::System( 1032): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 00:23:00.025+0900 I/Tizen::System( 1032): (103) > Original Time is 2015 7/13, 15:23:0:32
07-14 00:23:00.025+0900 I/Tizen::System( 1032): (123) > Current Time is 2015 7/14, 0:23:0
07-14 00:23:00.025+0900 I/AclService( 1032): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59968 milliseconds from now
07-14 00:23:00.035+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(false)
07-14 00:23:03.175+0900 W/LOCKSCREEN(  603): dbus.c: _dbus_message_recv_cb(141) > [_dbus_message_recv_cb:141:W] LCD off
07-14 00:23:03.175+0900 W/LOCKSCREEN(  603): event.c: _lcd_off_cb(61) > [_lcd_off_cb:61:W] Dbus LCD off:timeout
07-14 00:23:03.175+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30000:LCD_WILL_OFF
07-14 00:23:03.175+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:30000 event_info:b1f01938
07-14 00:23:03.175+0900 W/LOCKSCREEN(  603): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 00:23:03.175+0900 W/LOCKSCREEN(  603): daemon.c: _state_enter(329) > [_state_enter:329:W] HIDE => WILL RESUME
07-14 00:23:03.175+0900 E/LOCKSCREEN(  603): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 00:23:03.785+0900 W/CAM_APP ( 1144): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 00:23:03.785+0900 E/VOLUME  (  614): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-14 00:23:03.785+0900 E/VOLUME  (  614): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-14 00:23:03.795+0900 E/EFL     ( 3520): ewebkit2<3520> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 00:23:03.825+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:0:LKD_EVT_WILL_LOCK
07-14 00:23:03.825+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:0 event_info:0
07-14 00:23:03.825+0900 W/LOCKSCREEN(  603): view-mgr.c: _event_route(108) > [_event_route:108:W] event:0 event_info:0
07-14 00:23:03.825+0900 E/VOLUME  (  614): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-14 00:23:03.835+0900 I/Tizen::Base::Runtime( 1032): (251) > The timer is not started.
07-14 00:23:03.845+0900 D/PowerManagerService( 1277): calling setSysScreenBrightness(brightness = 153)
07-14 00:23:03.845+0900 I/power   ( 1277): *** set_screen_state 0
07-14 00:23:03.845+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'L'
07-14 00:23:03.855+0900 D/SensorService( 1277): actuateSensor
07-14 00:23:03.855+0900 D/AclServiceManager( 1277): -----*******------------ disableSensor  : 0
07-14 00:23:03.855+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'L'
07-14 00:23:03.885+0900 I/AclService( 1032): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 00:23:03.885+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(true)
07-14 00:23:03.895+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(true)
07-14 00:23:03.895+0900 D/ACL     ( 1277): ************ onActivitySaveInstanceState()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 00:23:03.905+0900 D/ACL     ( 1277): ************ onActivityPaused()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 00:23:03.905+0900 D/ACL     ( 1277): Pausing app with base activity ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 00:23:03.915+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'F'
07-14 00:23:03.935+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(false)
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): event.c: _lcd_off_source_cb(47) > [_lcd_off_source_cb:47:W] Vconf LCD off
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30002:LCD_OFF
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:30002 event_info:0
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:5
07-14 00:23:03.955+0900 W/LOCKSCREEN(  603): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => PAUSE
07-14 00:23:03.965+0900 E/WALLPAPER_SERVICE_COMMON(  603): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 00:23:03.975+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-14 00:23:03.975+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-14 00:23:03.975+0900 W/LOCKSCREEN(  603): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-14 00:23:03.975+0900 W/PROCESSMGR(  379): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=603
07-14 00:23:03.985+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 00:23:03.995+0900 W/AUL_AMD (  442): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 00:23:03.995+0900 I/indicator(  484): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 603"
07-14 00:23:03.995+0900 W/AUL_AMD (  442): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 00:23:04.025+0900 I/MALI    ( 3520): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xcb2b60] swap changed from sync to async
07-14 00:23:04.065+0900 I/Tizen::System(  966): (259) > Active app [com.samsun], current [rMfxc1AKe2] 
07-14 00:23:04.075+0900 I/Tizen::Io(  966): (729) > Entry not found
07-14 00:23:04.075+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 00:23:04.085+0900 I/Tizen::System( 1032): (101) > Active App is com.samsung.lockscreen. GetApp id ACL111OMWW.AclService
07-14 00:23:04.085+0900 W/LOCKSCREEN(  603): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(0)
07-14 00:23:04.085+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-14 00:23:04.085+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-14 00:23:04.085+0900 I/CAPI_APPFW_APPLICATION(  603): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 00:23:04.085+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-14 00:23:04.085+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-14 00:23:04.105+0900 I/Tizen::System(  966): (157) > change brightness system value.
07-14 00:23:04.465+0900 W/LOCKSCREEN(  603): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-14 00:23:08.935+0900 D/dalvikvm( 1417): GC_EXPLICIT freed 25K, 50% free 2857K/5639K, external 1962K/2073K, paused 20ms
07-14 00:23:59.995+0900 I/dalvikvm( 1277): Total arena pages for JIT: 11
07-14 00:24:00.005+0900 I/AclService( 1032): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 00:24:00.005+0900 I/Tizen::Base::Runtime( 1032): (251) > The timer is not started.
07-14 00:24:00.005+0900 I/Tizen::System( 1032): (85) > Current Epoch is 1436801040.
07-14 00:24:00.005+0900 I/Tizen::System( 1032): (89) > Calendar time is sec:0, min:24, hour:15, day:13, mon:6, year:115, wday1, year:193, dst:0
07-14 00:24:00.005+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'L'
07-14 00:24:00.005+0900 I/Tizen::System( 1032): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 00:24:00.005+0900 I/Tizen::System( 1032): (103) > Original Time is 2015 7/13, 15:24:0:8
07-14 00:24:00.005+0900 I/Tizen::System( 1032): (123) > Current Time is 2015 7/14, 0:24:0
07-14 00:24:00.005+0900 I/AclService( 1032): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 84959992 milliseconds from now
07-14 00:24:00.015+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'F'
07-14 00:24:00.025+0900 E/SurfaceFlinger( 1277): redraw failed: empty invalid region
07-14 00:24:00.025+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(true)
07-14 00:24:00.025+0900 I/AclService( 1032): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 00:24:00.025+0900 I/Tizen::System( 1032): (85) > Current Epoch is 1436801040.
07-14 00:24:00.025+0900 I/Tizen::System( 1032): (89) > Calendar time is sec:0, min:24, hour:15, day:13, mon:6, year:115, wday1, year:193, dst:0
07-14 00:24:00.025+0900 I/Tizen::System( 1032): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 00:24:00.025+0900 I/Tizen::System( 1032): (103) > Original Time is 2015 7/13, 15:24:0:33
07-14 00:24:00.025+0900 I/Tizen::System( 1032): (123) > Current Time is 2015 7/14, 0:24:0
07-14 00:24:00.025+0900 I/AclService( 1032): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59967 milliseconds from now
07-14 00:24:00.035+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(false)
07-14 00:24:15.425+0900 E/PKGMGR_SERVER( 4772): pkgmgr-server.c: main(1608) > server start
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 00:24:15.535+0900 E/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 00:24:15.535+0900 E/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(3827) are closed. delete client info
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 00:24:15.535+0900 E/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  3827
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 00:24:15.535+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 00:24:15.535+0900 W/AUL_AMD (  442): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 00:24:15.535+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 3827
07-14 00:24:15.535+0900 W/AUL_AMD (  442): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 00:24:15.545+0900 I/Tizen::System(  966): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 00:24:15.545+0900 I/Tizen::Io(  966): (729) > Entry not found
07-14 00:24:15.545+0900 I/Tizen::App(  934): (243) > App[org.tizen.tdlnaservice] pid[3827] terminate event is forwarded
07-14 00:24:15.545+0900 I/Tizen::System(  934): (256) > osp.accessorymanager.service provider is found.
07-14 00:24:15.545+0900 I/Tizen::System(  934): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 3827, ]
07-14 00:24:15.545+0900 I/Tizen::System(  934): (256) > osp.system.service provider is found.
07-14 00:24:15.545+0900 I/Tizen::App(  934): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 00:24:15.545+0900 I/Tizen::App(  934): (512) > Not registered pid(3827)
07-14 00:24:15.545+0900 I/Tizen::App(  934): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 3827.
07-14 00:24:15.545+0900 I/AUL_AMD (  442): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 3827
07-14 00:24:15.545+0900 I/Tizen::System(  966): (157) > change brightness system value.
07-14 00:24:15.545+0900 I/Tizen::App(  966): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 3827.
07-14 00:24:17.575+0900 E/PKGMGR_SERVER( 4772): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 00:24:17.575+0900 E/PKGMGR_SERVER( 4772): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 00:24:19.545+0900 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: main(1608) > server start
07-14 00:24:19.595+0900 E/PKGMGR  ( 4883): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.tdlnaservice]
07-14 00:24:19.595+0900 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.tdlnaservice 
07-14 00:24:19.595+0900 E/PKGMGR_SERVER( 4883): [0;m
07-14 00:24:19.775+0900 I/Tizen::App(  966): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 00:24:19.775+0900 I/Tizen::App(  966): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 00:24:19.775+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 00:24:19.775+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 00:24:19.775+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 00:24:19.785+0900 W/AUL_AMD (  442): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
07-14 00:24:19.795+0900 I/Tizen::App(  966): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 00:24:19.795+0900 I/Tizen::App(  966): (119) > InstallationInProgress [30]
07-14 00:24:19.795+0900 I/Tizen::App(  966): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 00:24:19.795+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 00:24:19.795+0900 I/Tizen::App(  934): (119) > InstallationInProgress [30]
07-14 00:24:19.795+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-14 00:24:19.795+0900 I/Tizen::App(  934): (119) > InstallationInProgress [30]
07-14 00:24:19.795+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [96]
07-14 00:24:19.805+0900 I/Tizen::App( 1032): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: start, val: update
07-14 00:24:19.805+0900 I/Tizen::App( 1032): (1584) > Package = [org.tizen.tdlnaservice], Key = [start], Value = [update], install = [1]
07-14 00:24:19.805+0900 I/Tizen::App( 1032): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 30
07-14 00:24:19.805+0900 I/Tizen::App( 1032): (119) > InstallationInProgress [30]
07-14 00:24:19.805+0900 I/Tizen::App( 1032): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [30], install = [1]
07-14 00:24:20.425+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 00:24:20.425+0900 I/Tizen::App(  934): (119) > InstallationInProgress [60]
07-14 00:24:20.425+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [96]
07-14 00:24:20.425+0900 I/Tizen::App(  934): (119) > InstallationInProgress [60]
07-14 00:24:20.425+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [96]
07-14 00:24:20.425+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
07-14 00:24:20.425+0900 I/Tizen::App(  966): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 00:24:20.425+0900 I/Tizen::App(  966): (119) > InstallationInProgress [60]
07-14 00:24:20.425+0900 I/Tizen::App(  966): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 00:24:20.425+0900 I/Tizen::App( 1032): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 60
07-14 00:24:20.425+0900 I/Tizen::App( 1032): (119) > InstallationInProgress [60]
07-14 00:24:20.425+0900 I/Tizen::App( 1032): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [60], install = [1]
07-14 00:24:20.425+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 120
07-14 00:24:20.435+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 120
07-14 00:24:20.435+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
07-14 00:24:20.435+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 34 33
07-14 00:24:20.435+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 35 33
07-14 00:24:20.435+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
07-14 00:24:20.445+0900 W/LOCKSCREEN(  603): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-14 00:24:20.445+0900 W/LOCKSCREEN(  603): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-14 00:24:20.445+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-14 00:24:20.445+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-14 00:24:20.445+0900 W/LOCKSCREEN(  603): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 00:24:20.445+0900 W/LOCKSCREEN(  603): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-14 00:24:20.455+0900 I/indicator(  484): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-14 00:24:20.455+0900 E/LOCKSCREEN(  603): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 285 331 5 28 25"
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 00:24:20.455+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 286 387 5 28 25"
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 00:24:20.465+0900 E/PKGMGR_CERT( 4888): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 285 651 5 28 25"
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 00:24:20.465+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 286 707 5 28 25"
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/res]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.tdlnaservice/shared], errno=[2][No such file or directory]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.tdlnaservice/shared/res]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/tizen-manifest.xml]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/author-signature.xml]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.tdlnaservice/signature1.xml]
07-14 00:24:20.465+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.tdlnaservice.xml]
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 285 331 5 28 25"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 286 387 5 28 25"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 00:24:20.475+0900 W/LOCKSCREEN(  603): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 285 651 5 28 25"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 00:24:20.475+0900 I/indicator(  484): indicator_box_util.c: _update_display(585) > "Noti Icon : 286 707 5 28 25"
07-14 00:24:20.475+0900 W/LOCKSCREEN(  603): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 00:24:20.475+0900 W/LOCKSCREEN(  603): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-14 00:24:20.985+0900 E/rpm-installer( 4888): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]))
07-14 00:24:21.045+0900 I/Tizen::System(  966): (280) > The screen has been turned on.
07-14 00:24:21.045+0900 I/Tizen::Io(  966): (729) > Entry not found
07-14 00:24:21.045+0900 W/CAM_APP ( 1144): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 00:24:21.055+0900 I/Tizen::App(  934): (124) > app(ACL111OMWW.AclService), clientId(1032)
07-14 00:24:21.065+0900 I/Tizen::System(  966): (157) > change brightness system value.
07-14 00:24:21.305+0900 E/LOCKSCREEN(  603): progress_circle.c: unlock_mouse_up(285) > 
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-14 00:24:21.305+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-14 00:24:21.315+0900 I/Tizen::App(  934): (124) > app(ACL111OMWW.AclService), clientId(1032)
07-14 00:24:21.565+0900 I/Tizen::App(  934): (124) > app(ACL111OMWW.AclService), clientId(1032)
07-14 00:24:21.575+0900 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-14 00:24:21.815+0900 I/Tizen::App(  934): (124) > app(ACL111OMWW.AclService), clientId(1032)
07-14 00:24:21.815+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-14 00:24:21.815+0900 W/LOCKSCREEN(  603): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-14 00:24:21.815+0900 W/LOCKSCREEN(  603): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-14 00:24:21.825+0900 E/WALLPAPER_SERVICE_COMMON(  603): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 00:24:21.825+0900 W/PROCESSMGR(  379): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3520
07-14 00:24:21.835+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 00:24:21.845+0900 I/indicator(  484): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 3520"
07-14 00:24:21.845+0900 E/EFL     ( 3520): ewebkit2<3520> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 00:24:21.865+0900 W/LOCKSCREEN(  603): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(1)
07-14 00:24:21.865+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-14 00:24:21.865+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-14 00:24:21.865+0900 I/CAPI_APPFW_APPLICATION(  603): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 00:24:21.865+0900 E/LOCKSCREEN(  603): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 00:24:21.865+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-14 00:24:21.865+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-14 00:24:21.875+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 00:24:21.885+0900 I/Tizen::System( 1032): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 00:24:21.895+0900 I/Tizen::System(  966): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 00:24:21.895+0900 I/Tizen::Io(  966): (729) > Entry not found
07-14 00:24:21.905+0900 I/Tizen::System(  966): (157) > change brightness system value.
07-14 00:24:22.015+0900 W/LOCKSCREEN(  603): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-14 00:24:22.015+0900 E/LOCKSCREEN(  603): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 00:24:22.015+0900 W/LOCKSCREEN(  603): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-14 00:24:22.015+0900 W/LOCKSCREEN(  603): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-14 00:24:22.025+0900 E/LOCKSCREEN(  603): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-14 00:24:22.065+0900 I/Tizen::App(  934): (124) > app(ACL111OMWW.AclService), clientId(1032)
07-14 00:24:22.065+0900 D/PowerManagerService( 1277): calling setSysScreenBrightness(brightness = 153)
07-14 00:24:22.065+0900 I/power   ( 1277): *** set_screen_state 1
07-14 00:24:22.075+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'L'
07-14 00:24:22.075+0900 I/AclService( 1032): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 00:24:22.075+0900 D/SensorService( 1277): actuateSensor
07-14 00:24:22.075+0900 D/AclServiceManager( 1277): -----*******------------ enableSensor  : 0
07-14 00:24:22.075+0900 D/SensorService( 1277): setSensorDelay
07-14 00:24:22.075+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(true)
07-14 00:24:22.075+0900 D/AclServiceManager( 1277): -----*******------------ setSensorDelay : 0 to 200
07-14 00:24:22.075+0900 D/SensorService( 1277): setSensorDelay
07-14 00:24:22.075+0900 D/AclServiceManager( 1277): -----*******------------ setSensorDelay : 0 to 200
07-14 00:24:22.085+0900 D/ACL     ( 1277): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 00:24:22.085+0900 D/ACL     ( 1277): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-14 00:24:22.085+0900 I/PowerManagerService-JNI( 1277): sending ACL screen state 'F'
07-14 00:24:22.085+0900 I/AclService( 1032): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-14 00:24:22.085+0900 I/Tizen::System( 1032): (461) > change cpu power policy: keepAwake(false)
07-14 00:24:22.095+0900 I/AclService( 1032): void minimize()(280) > Minimizing all vfb clients
07-14 00:24:22.095+0900 I/AclService( 1032): void minimize()(283) > minimizing {pkg=surfaceflinger fd=99}
07-14 00:24:22.095+0900 E/Tizen::Io( 1032): (133) > [E_INVALID_ARG] The application id is empty.
07-14 00:24:22.095+0900 I/Tizen::Base::Runtime( 1032): (251) > The timer is not started.
07-14 00:24:22.535+0900 W/LOCKSCREEN(  603): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 00:24:23.575+0900 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-14 00:24:23.845+0900 I/MALI    ( 3520): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xcb2b60] swap changed from async to sync
07-14 00:24:23.885+0900 I/Tizen::App(  966): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 00:24:23.885+0900 I/Tizen::App(  966): (119) > InstallationInProgress [100]
07-14 00:24:23.885+0900 I/Tizen::App(  966): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 00:24:23.885+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 00:24:23.885+0900 I/Tizen::App(  934): (119) > InstallationInProgress [100]
07-14 00:24:23.885+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 00:24:23.885+0900 I/Tizen::App(  934): (119) > InstallationInProgress [100]
07-14 00:24:23.885+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 00:24:23.895+0900 I/Tizen::App(  966): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 00:24:23.895+0900 I/Tizen::App(  966): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 00:24:23.895+0900 I/Tizen::App(  966): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 00:24:23.895+0900 I/Tizen::App(  934): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 00:24:23.895+0900 I/Tizen::App(  934): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 00:24:23.895+0900 I/Tizen::App(  934): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-14 00:24:23.915+0900 E/cluster-home(  628): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-14 00:24:23.915+0900 E/cluster-home(  628): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-14 00:24:23.915+0900 E/cluster-home(  628): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-14 00:24:23.945+0900 E/PKGMGR_INFO( 4888): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-14 00:24:23.945+0900 E/PKGMGR_INSTALLER( 4888): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-14 00:24:23.965+0900 I/Tizen::App(  934): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 00:24:23.985+0900 E/cluster-home(  628): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-14 00:24:24.025+0900 E/cluster-home(  628): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-14 00:24:24.025+0900 E/cluster-home(  628): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-14 00:24:24.025+0900 I/Tizen::App( 1032): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 00:24:24.025+0900 I/Tizen::App( 1032): (119) > InstallationInProgress [100]
07-14 00:24:24.025+0900 I/Tizen::App( 1032): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 00:24:24.025+0900 I/Tizen::App( 1032): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 00:24:24.025+0900 I/Tizen::App( 1032): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 00:24:24.035+0900 I/Tizen::App(  934): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-14 00:24:24.045+0900 I/Tizen::App( 1032): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 00:24:24.045+0900 I/Tizen::App(  934): (416) > appName = [tdlnaservice]
07-14 00:24:24.045+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 00:24:24.045+0900 E/PKGMGR_INFO(  934): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-14 00:24:24.045+0900 I/Tizen::App(  934): (675) > Application count(1) in this package
07-14 00:24:24.045+0900 I/Tizen::App(  934): (855) > Enter.
07-14 00:24:24.055+0900 I/Tizen::App(  934): (695) > Exit.
07-14 00:24:24.055+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 00:24:24.055+0900 I/Tizen::App(  934): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 00:24:24.055+0900 I/Tizen::App(  934): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 00:24:24.055+0900 I/Tizen::App( 1032): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-14 00:24:24.055+0900 I/Tizen::App(  934): (416) > appName = [tdlnaservice]
07-14 00:24:24.055+0900 I/Tizen::App(  934): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 00:24:24.055+0900 I/Tizen::App(  934): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-14 00:24:24.055+0900 I/Tizen::App(  934): (131) > Enter
07-14 00:24:24.055+0900 I/Tizen::App(  934): (137) > org.tizen.tdlnaservice does not have launch condition
07-14 00:24:24.055+0900 I/Tizen::App(  934): (898) > Exit.
07-14 00:24:24.065+0900 I/Tizen::App( 1032): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 00:24:24.065+0900 I/Tizen::App( 1032): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-14 00:24:25.575+0900 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 00:24:25.575+0900 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 00:24:25.825+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 00:24:25.835+0900 I/AUL     (  442): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-14 00:24:25.845+0900 I/AUL     (  442): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-14 00:24:25.845+0900 E/AUL_AMD (  442): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 00:24:25.855+0900 W/AUL_AMD (  442): amd_launch.c: service_start(515) > child process: 4972
07-14 00:24:25.905+0900 W/AUL_AMD (  442): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 4972
07-14 00:24:25.915+0900 E/RESOURCED(  744): proc-process.c: proc_get_oom_score_adj(377) > [proc_get_oom_score_adj,377] fopen /proc/0/oom_score_adj failed
07-14 00:24:25.925+0900 I/Tizen::App(  966): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 4972.
07-14 00:24:25.935+0900 I/tdlna   ( 4972): _on_create_cb 실행
07-14 00:24:25.935+0900 I/tdlna   ( 4972): _app_init 실행
07-14 00:24:25.935+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 00:24:25.945+0900 I/Tizen::App(  934): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 00:24:25.945+0900 I/Tizen::App(  934): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 4972.
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 4972
07-14 00:24:25.955+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 00:24:25.955+0900 D/tdlnaservice( 4972): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 00:24:25.975+0900 I/tdlna   ( 4972): _on_app_control_callback 실행
07-14 00:24:25.975+0900 I/tdlna   ( 4972): _app_timer_thread_func 실행
07-14 00:24:27.085+0900 W/ProcessStats( 1277): Skipping unknown process pid 4972
07-14 00:24:28.075+0900 D/PowerManagerService( 1277): calling setSysScreenBrightness(brightness = 153)
07-14 00:24:28.075+0900 I/AclService( 1032): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 00:24:38.985+0900 D/tdlnaservice( 4972): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 00:24:38.985+0900 I/tdlna   ( 4972): _on_proxy_client_msg_received_cb 실행
07-14 00:24:38.985+0900 I/tdlna   ( 4972): _app_process_received_message 실행
07-14 00:24:38.985+0900 I/tdlna   ( 4972): test _ _app_process_received_message
07-14 00:24:38.985+0900 I/tdlna   ( 4972): _app_execute_operation 실행
07-14 00:24:38.985+0900 I/tdlna   ( 4972): test 실행
07-14 00:24:38.985+0900 I/tdlna   ( 4972): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 00:24:38.985+0900 I/tdlna   ( 4972): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 00:24:38.985+0900 I/tdlna   ( 4972): _app_send_response 실행
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 00:24:38.985+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 00:24:38.985+0900 I/tdlna   ( 4972): Main Start !!! 1
07-14 00:24:38.985+0900 I/tdlna   ( 4972): Service Start !!! 1
07-14 00:24:38.985+0900 I/tdlna   ( 4972): fork 전
07-14 00:24:38.995+0900 I/tdlna   ( 5041): fork child process 1
07-14 00:24:38.995+0900 I/tdlna   ( 5041): ssdp running
07-14 00:24:38.995+0900 D/tdlnaservice( 4972): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 00:24:39.025+0900 I/MESSAGE_PORT(  390): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 00:24:39.435+0900 W/CRASH_MANAGER( 5044): worker.c: worker_job(1236) > 110497274646c143680107
