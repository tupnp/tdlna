S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 29082
Date: 2015-07-14 11:50:07+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x00000000
r6   = 0xb5cbbd60, r7   = 0xb5cbc454
r8   = 0xb5cbc220, r9   = 0xb6f4013c
r10  = 0xb64be4c0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbea0bef8
lr   = 0x00000000, pc   = 0xb6f35424
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     30568 KB
Buffers:     22456 KB
Cached:     212924 KB
VmPeak:      28892 KB
VmSize:      28888 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4904 KB
VmRSS:        4904 KB
VmData:      18024 KB
VmStk:         136 KB
VmExe:          48 KB
VmLib:        9144 KB
VmPTE:          24 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 29082 TID = 29082
29082 29087 

Maps Information
b5cbe000 b64c1000 rwxp [stack:29087]
b64c1000 b64c4000 r-xp /lib/libgpg-error.so.0.5.0
b64cb000 b64cc000 rwxp /lib/libgpg-error.so.0.5.0
b64cc000 b6524000 r-xp /usr/lib/libgcrypt.so.11.5.3
b652b000 b652e000 rwxp /usr/lib/libgcrypt.so.11.5.3
b652f000 b655b000 r-xp /usr/lib/libsystemd.so.0.0.1
b6562000 b6563000 r-xp /usr/lib/libsystemd.so.0.0.1
b6563000 b6564000 rwxp /usr/lib/libsystemd.so.0.0.1
b6564000 b6566000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b656d000 b656e000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b656e000 b6639000 r-xp /usr/lib/libxml2.so.2.7.8
b6641000 b6646000 rwxp /usr/lib/libxml2.so.2.7.8
b6647000 b6657000 r-xp /lib/libresolv-2.13.so
b6657000 b6658000 r-xp /lib/libresolv-2.13.so
b6658000 b6659000 rwxp /lib/libresolv-2.13.so
b665c000 b6672000 r-xp /lib/libz.so.1.2.5
b6679000 b667a000 rwxp /lib/libz.so.1.2.5
b667a000 b667c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6683000 b6684000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b6684000 b6689000 r-xp /usr/lib/libffi.so.5.0.10
b6690000 b6691000 rwxp /usr/lib/libffi.so.5.0.10
b6691000 b6692000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6699000 b669a000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b669a000 b66ff000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6706000 b6709000 rwxp /usr/lib/libsqlite3.so.0.8.6
b670a000 b670d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6714000 b6715000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6715000 b68bd000 r-xp /usr/lib/libcrypto.so.1.0.0
b68c4000 b68d9000 rwxp /usr/lib/libcrypto.so.1.0.0
b68dd000 b68f3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68fa000 b68fb000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b68fb000 b692f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6936000 b6938000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6938000 b6a0c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a14000 b6a17000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a19000 b6a1d000 r-xp /usr/lib/libchromium.so.1.0
b6a24000 b6a25000 rwxp /usr/lib/libchromium.so.1.0
b6a25000 b6a8e000 r-xp /lib/libm-2.13.so
b6a95000 b6a96000 r-xp /lib/libm-2.13.so
b6a96000 b6a97000 rwxp /lib/libm-2.13.so
b6a97000 b6a9d000 r-xp /usr/lib/libappsvc.so.0.1.0
b6aa4000 b6aa5000 rwxp /usr/lib/libappsvc.so.0.1.0
b6aa5000 b6ac4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6acb000 b6acc000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6acc000 b6acf000 r-xp /usr/lib/libsmack.so.1.0.0
b6ad6000 b6ad7000 rwxp /usr/lib/libsmack.so.1.0.0
b6ad7000 b6adc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ae4000 b6ae5000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6ae5000 b6b0f000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b17000 b6b18000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b18000 b6b2f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b37000 b6b38000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b38000 b6bcc000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bd4000 b6bd7000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bd7000 b6bd9000 rwxp /usr/lib/libstdc++.so.6.0.16
b6bdf000 b6bea000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6bf1000 b6bf2000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6bf2000 b6bf7000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6bff000 b6c00000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c00000 b6cd0000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6cd0000 b6cd1000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6cd1000 b6d11000 r-xp /usr/lib/libeina.so.1.7.99
b6d18000 b6d19000 rwxp /usr/lib/libeina.so.1.7.99
b6d1a000 b6d30000 r-xp /usr/lib/libecore.so.1.7.99
b6d37000 b6d38000 rwxp /usr/lib/libecore.so.1.7.99
b6d46000 b6d4d000 r-xp /usr/lib/libvconf.so.0.2.45
b6d55000 b6d56000 rwxp /usr/lib/libvconf.so.0.2.45
b6d56000 b6d5b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d62000 b6d63000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d63000 b6d6e000 r-xp /usr/lib/libaul.so.0.1.0
b6d76000 b6d77000 rwxp /usr/lib/libaul.so.0.1.0
b6d78000 b6d80000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d87000 b6d88000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d88000 b6d8a000 r-xp /lib/libdl-2.13.so
b6d91000 b6d92000 r-xp /lib/libdl-2.13.so
b6d92000 b6d93000 rwxp /lib/libdl-2.13.so
b6d93000 b6d9e000 r-xp /lib/libunwind.so.8.0.1
b6da5000 b6da6000 rwxp /lib/libunwind.so.8.0.1
b6dcb000 b6ee6000 r-xp /lib/libc-2.13.so
b6eee000 b6ef0000 r-xp /lib/libc-2.13.so
b6ef0000 b6ef1000 rwxp /lib/libc-2.13.so
b6ef4000 b6efa000 r-xp /lib/librt-2.13.so
b6f01000 b6f02000 r-xp /lib/librt-2.13.so
b6f02000 b6f03000 rwxp /lib/librt-2.13.so
b6f03000 b6f05000 r-xp /usr/lib/libdlog.so.0.0.0
b6f0c000 b6f0d000 rwxp /usr/lib/libdlog.so.0.0.0
b6f0d000 b6f10000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f17000 b6f18000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f18000 b6f1b000 r-xp /usr/lib/libbundle.so.0.1.22
b6f22000 b6f23000 rwxp /usr/lib/libbundle.so.0.1.22
b6f23000 b6f26000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f2d000 b6f2e000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f2e000 b6f42000 r-xp /lib/libpthread-2.13.so
b6f49000 b6f4a000 r-xp /lib/libpthread-2.13.so
b6f4a000 b6f4b000 rwxp /lib/libpthread-2.13.so
b6f62000 b6f66000 r-xp /usr/lib/libsys-assert.so
b6f6e000 b6f6f000 rwxp /usr/lib/libsys-assert.so
b6f6f000 b6f8c000 r-xp /lib/ld-2.13.so
b6f93000 b6f94000 r-xp /lib/ld-2.13.so
b6f94000 b6f95000 rwxp /lib/ld-2.13.so
b6f95000 b6fa1000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fa9000 b6fab000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b8414000 b8459000 rwxp [heap]
be9ec000 bea0d000 rwxp [stack]
End of Maps Information

Callstack Information (PID:29082)
Call Stack Count: 1
 0: pthread_create + 0x38c (0xb6f35424) [/lib/libpthread.so.0] + 0x7424
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
  428): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 29283
07-14 11:49:52.997+0900 I/Tizen::System( 1068): (246) > Terminated app [rMfxc1AKe2.tdlnaWeb]
07-14 11:49:52.997+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:49:53.017+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:49:53.017+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 29283.
07-14 11:49:53.047+0900 I/CAPI_APPFW_APPLICATION( 1391): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 11:49:53.047+0900 I/Internet( 1391): main.cpp: __br_app_resume(731) > 
07-14 11:49:53.047+0900 E/Internet( 1391): mdm-manager.cpp: register_policy(220) > mdm_get_service() is failed [0xfffffffb]
07-14 11:49:53.047+0900 I/PRIVACY-MANAGER-CLIENT( 1391): SocketClient.cpp: SocketClient(37) > Client created
07-14 11:49:53.047+0900 I/PRIVACY-MANAGER-SERVER(  374): SocketService.cpp: mainloop(206) > Got incoming connection
07-14 11:49:53.047+0900 I/PRIVACY-MANAGER-CLIENT( 1391): SocketClient.cpp: connect(62) > Client connected
07-14 11:49:53.057+0900 I/PRIVACY-MANAGER-CLIENT( 1391): SocketClient.cpp: disconnect(72) > Client disconnected
07-14 11:49:53.057+0900 E/Internet( 1391): most-visited-manager.cpp: view_resize_need(306) > Most_visited_view is NULL
07-14 11:49:53.057+0900 I/Internet( 1391): main-view.cpp: show_url_bar(421) > 0
07-14 11:49:53.057+0900 W/UI_GADGET( 1391): manager.c: ugman_resume(1045) > [34mugman_resume failed: no root[0m
07-14 11:49:53.107+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:49:53.187+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:49:53.227+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:49:53.237+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:49:54.717+0900 W/AUL_AMD (  428): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 11:49:55.027+0900 I/MALI    ( 1391): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8c7e2a0] swap changed from async to sync
07-14 11:49:55.047+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:49:57.027+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:49:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 11:50:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 11:50:00.007+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:50:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 11:50:00.007+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 11:50:00.007+0900 I/Tizen::System( 1155): (85) > Current Epoch is -5265128749495191336.
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:50, hour:2, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 2:50:0:19
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 11:50:0
07-14 11:50:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 43799981 milliseconds from now
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 11:50:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436842200.
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:50, hour:2, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 11:50:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 2:50:0:27
07-14 11:50:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 11:50:0
07-14 11:50:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59973 milliseconds from now
07-14 11:50:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 11:50:00.447+0900 W/STARTER (  536): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
07-14 11:50:00.457+0900 W/STARTER (  536): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
07-14 11:50:00.777+0900 I/SYSPOPUP(  589): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-14 11:50:00.777+0900 I/SYSPOPUP(  589): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-14 11:50:00.777+0900 E/VOLUME  (  589): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-14 11:50:00.777+0900 E/VOLUME  (  589): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-14 11:50:00.787+0900 E/VOLUME  (  589): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-14 11:50:00.887+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 11:50:00.897+0900 I/AUL     (  428): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
07-14 11:50:00.897+0900 E/AUL_AMD (  428): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 11:50:01.027+0900 E/RESOURCED(  757): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
07-14 11:50:01.057+0900 E/RESOURCED(  757): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 268
07-14 11:50:01.077+0900 I/Tizen::App( 1068): (733) > Finished invoking application event listener for com.samsung.task-mgr, 29367.
07-14 11:50:01.077+0900 I/Tizen::App( 1023): (499) > LaunchedApp(com.samsung.task-mgr)
07-14 11:50:01.077+0900 I/Tizen::App( 1023): (733) > Finished invoking application event listener for com.samsung.task-mgr, 29367.
07-14 11:50:01.107+0900 I/UXT     (29367): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 11:50:01.367+0900 I/EFL-ASSIST(29367): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b81364b0]
07-14 11:50:01.377+0900 I/EFL-ASSIST(29367): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8265060) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:50:01.377+0900 I/EFL-ASSIST(29367): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8265060) is freed
07-14 11:50:01.457+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.maps-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.m-setting) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.videos-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.browser) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.browser_multi) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.clock-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.contacts) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.phone) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.calendar-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.voicerecorder-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.calculator) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.memo) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.message-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.email) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.video-player-lite) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.image-viewer) is found
07-14 11:50:01.467+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.music-player-lite) is found
07-14 11:50:01.477+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.fm-radio-lite) is found
07-14 11:50:01.477+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.myfile-lite) is found
07-14 11:50:01.477+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.gallery-lite) is found
07-14 11:50:01.477+0900 E/PKGMGR_INFO(29367): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.setting) is found
07-14 11:50:01.487+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:01.487+0900 E/RUA     (29367): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
07-14 11:50:01.487+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.497+0900 E/TASK_MGR_LITE(29367): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:01.557+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:01.557+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:01.567+0900 I/APP_CORE(29367): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 11:50:01.567+0900 I/APP_CORE(29367): appcore-efl.c: __do_app(511) > [APP 29367] Initial Launching, call the resume_cb
07-14 11:50:01.587+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29367
07-14 11:50:01.617+0900 I/MALI    ( 1391): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8c7e2a0] swap changed from sync to async
07-14 11:50:01.617+0900 W/APP_CORE(29367): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7e00008
07-14 11:50:01.627+0900 E/EFL     (29367): evas_main<29367> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 11:50:01.637+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:01.647+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.task-mgr, pid = 29367"
07-14 11:50:01.647+0900 E/EFL     (29367): evas_main<29367> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 11:50:01.667+0900 I/Tizen::System( 1068): (259) > Active app [com.samsun], current [com.samsun] 
07-14 11:50:01.667+0900 I/Tizen::System( 1068): (273) > Current App[com.samsun] is already actived.
07-14 11:50:01.697+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:01.707+0900 I/Tizen::System( 1155): (101) > Active App is com.samsung.task-mgr. GetApp id ACL111OMWW.AclService
07-14 11:50:01.717+0900 W/AUL_AMD (  428): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 11:50:01.717+0900 W/AUL_AMD (  428): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 11:50:01.757+0900 E/TASK_MGR_LITE(29367): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:01.767+0900 E/TASK_MGR_LITE(29367): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:02.087+0900 W/STARTER (  536): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
07-14 11:50:02.107+0900 I/SYSPOPUP(  589): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-14 11:50:02.107+0900 I/SYSPOPUP(  589): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-14 11:50:02.107+0900 E/VOLUME  (  589): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-14 11:50:02.107+0900 E/VOLUME  (  589): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-14 11:50:02.117+0900 E/VOLUME  (  589): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-14 11:50:02.557+0900 E/TASK_MGR_LITE(29367): genlist_item.c: _icon_mouse_up(624) > Mouse up
07-14 11:50:02.557+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 14
07-14 11:50:02.567+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-14 11:50:02.567+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 11:50:02.587+0900 E/TASK_MGR_LITE(29367): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:02.587+0900 E/TASK_MGR_LITE(29367): genlist_item.c: on_icon_clicked(530) > Running / Recent on_icon_clicked 0 -1
07-14 11:50:02.597+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 11:50:02.597+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(803) > app status : 5
07-14 11:50:02.597+0900 I/APP_CORE(29367): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-14 11:50:02.597+0900 I/APP_CORE(29367): appcore-efl.c: __after_loop(1059) > [APP 29367] PAUSE before termination
07-14 11:50:02.597+0900 E/TASK_MGR_LITE(29367): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:02.607+0900 E/RESOURCED(  757): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 264
07-14 11:50:02.607+0900 I/AUL     ( 1068): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:02.607+0900 I/AUL     ( 1023): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:02.627+0900 I/AUL     ( 1068): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:02.627+0900 I/AUL     ( 1023): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:02.627+0900 E/Tizen::App( 1023): (703) > Cannot acquire app for 29287.
07-14 11:50:02.627+0900 E/Tizen::App( 1068): (703) > Cannot acquire app for 29287.
07-14 11:50:02.637+0900 E/APP_CORE(29367): appcore.c: appcore_flush_memory(631) > Appcore not initialized
07-14 11:50:02.657+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=1391
07-14 11:50:02.697+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:02.707+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:02.717+0900 I/Tizen::System( 1155): (101) > Active App is com.samsung.browser. GetApp id ACL111OMWW.AclService
07-14 11:50:02.727+0900 I/UXT     (29287): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 11:50:02.747+0900 I/Tizen::System( 1068): (259) > Active app [com.samsun], current [com.samsun] 
07-14 11:50:02.747+0900 I/Tizen::System( 1068): (273) > Current App[com.samsun] is already actived.
07-14 11:50:02.757+0900 I/MALI    (29367): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-14 11:50:02.757+0900 I/MALI    (29367): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=29367   close drm_fd=21 
07-14 11:50:02.757+0900 I/MALI    (29367): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-14 11:50:02.767+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.browser, pid = 1391"
07-14 11:50:02.857+0900 I/UXT     (29367): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-14 11:50:02.947+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 11:50:02.947+0900 W/AUL_AMD (  428): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 11:50:02.947+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 11:50:02.997+0900 I/AUL_PAD (  462): sigchild.h: __launchpad_sig_child(142) > dead_pid = 29367 pgid = 29367
07-14 11:50:02.997+0900 I/AUL_PAD (  462): sigchild.h: __sigchild_action(123) > dead_pid(29367)
07-14 11:50:02.997+0900 I/AUL_PAD (  462): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-14 11:50:02.997+0900 I/AUL_PAD (  462): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-14 11:50:02.997+0900 I/AUL_AMD (  428): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 29367
07-14 11:50:02.997+0900 I/Tizen::System( 1068): (246) > Terminated app [com.samsung.task-mgr]
07-14 11:50:02.997+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:02.997+0900 I/Tizen::App( 1023): (243) > App[com.samsung.task-mgr] pid[29367] terminate event is forwarded
07-14 11:50:02.997+0900 I/Tizen::System( 1023): (256) > osp.accessorymanager.service provider is found.
07-14 11:50:02.997+0900 I/Tizen::System( 1023): (196) > Accessory Owner is removed [com.samsung.task-mgr, 29367, ]
07-14 11:50:02.997+0900 I/Tizen::System( 1023): (256) > osp.system.service provider is found.
07-14 11:50:02.997+0900 I/Tizen::App( 1023): (506) > TerminatedApp(com.samsung.task-mgr)
07-14 11:50:02.997+0900 I/Tizen::App( 1023): (512) > Not registered pid(29367)
07-14 11:50:02.997+0900 I/Tizen::App( 1023): (782) > Finished invoking application event listener for com.samsung.task-mgr, 29367.
07-14 11:50:03.007+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:03.007+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for com.samsung.task-mgr, 29367.
07-14 11:50:03.027+0900 I/EFL-ASSIST(29287): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [16cb2e8]
07-14 11:50:03.037+0900 I/EFL-ASSIST(29287): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1714308) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:50:03.037+0900 I/EFL-ASSIST(29287): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1714308) is freed
07-14 11:50:03.167+0900 E/EFL     (29287): evas_main<29287> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 11:50:03.177+0900 E/EFL     (29287): evas_main<29287> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 11:50:03.227+0900 E/PKGMGR_INFO(29287): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 11:50:03.227+0900 I/APP_CORE(29287): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 11:50:03.227+0900 I/APP_CORE(29287): appcore-efl.c: __do_app(511) > [APP 29287] Initial Launching, call the resume_cb
07-14 11:50:03.247+0900 E/EFL     (29287): elementary<29287> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0xb0704be0 as sub object of 0x18b47c0
07-14 11:50:03.257+0900 I/AUL     (29314): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 11:50:03.267+0900 E/WEBKIT  (29287): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 11:50:03.307+0900 I/CAPI_NETWORK_CONNECTION(29287): connection.c: connection_create(363) > New handle created[0x1964a00]
07-14 11:50:03.307+0900 I/CAPI_NETWORK_CONNECTION(29287): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 11:50:03.307+0900 I/CAPI_NETWORK_CONNECTION(29287): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 11:50:03.307+0900 E/TIZEN_N_SYSTEM_SETTINGS(29287): system_settings.c: system_settings_set_changed_cb(541) > b3e5e2b1
07-14 11:50:03.307+0900 E/TIZEN_N_SYSTEM_SETTINGS(29287): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3e5cd99
07-14 11:50:03.367+0900 E/EFL     (29314): edje<29314> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 11:50:03.407+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29287
07-14 11:50:03.437+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:03.437+0900 W/APP_CORE(29287): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8400003
07-14 11:50:03.447+0900 I/Tizen::System( 1155): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 11:50:03.447+0900 I/Tizen::System( 1068): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 11:50:03.447+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:03.457+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:03.487+0900 I/CAPI_APPFW_APPLICATION( 1391): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 11:50:03.487+0900 I/Internet( 1391): main.cpp: __br_app_pause(703) > 
07-14 11:50:03.497+0900 E/Internet( 1391): mdm-manager.cpp: deregister_policy(236) > mdm_deregister_policy_receiver() is failed [0xffffffff]
07-14 11:50:03.497+0900 E/Internet( 1391): mdm-manager.cpp: deregister_policy(240) > mdm_release_service failed
07-14 11:50:03.497+0900 W/UI_GADGET( 1391): manager.c: ugman_pause(1070) > [34mugman_pause failed: no root[0m
07-14 11:50:03.667+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:03.677+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 29287"
07-14 11:50:03.787+0900 I/UXT     (29395): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 11:50:03.827+0900 I/EFL-ASSIST(29395): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1723530) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:50:03.827+0900 I/EFL-ASSIST(29395): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1723530) is freed
07-14 11:50:03.837+0900 I/EFL-ASSIST(29395): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1723530) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:50:03.837+0900 I/EFL-ASSIST(29395): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1723530) is freed
07-14 11:50:03.927+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.007+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.007+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.007+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.017+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.027+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.027+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.027+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.037+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.047+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.047+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.047+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.057+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.067+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.067+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.067+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.077+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.087+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.087+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.087+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.117+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.117+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.127+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.127+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.137+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.137+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.137+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.147+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.157+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.167+0900 I/AUL     (29383): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:50:04.167+0900 E/AUL     (29383): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:50:04.167+0900 E/AUL     (29383): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:50:04.337+0900 I/RESOURCED(  757): swap.c: swap_send_signal(316) > [swap_send_signal,316] send signal to swap thread
07-14 11:50:04.337+0900 I/RESOURCED(  757): swap.c: swap_thread_main(281) > [swap_thread_main,281] swap thread conditional signal received
07-14 11:50:04.527+0900 E/WEBKIT  (29287): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 11:50:04.597+0900 W/AUL_AMD (  428): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 11:50:05.017+0900 W/ProcessStats( 1413): Skipping unknown process pid 29082
07-14 11:50:05.027+0900 W/ProcessStats( 1413): Skipping unknown process pid 29287
07-14 11:50:05.037+0900 W/ProcessStats( 1413): Skipping unknown process pid 29305
07-14 11:50:05.037+0900 W/ProcessStats( 1413): Skipping unknown process pid 29314
07-14 11:50:05.907+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:06.077+0900 E/PKGMGR_INFO(29314): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 11:50:06.117+0900 E/PKGMGR_INFO(29314): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.browser) is found
07-14 11:50:06.367+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 11:50:06.367+0900 I/AUL     (  373): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 11:50:06.367+0900 I/AUL     (29314): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 11:50:06.377+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 11:50:06.377+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 11:50:06.377+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.377+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.387+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.387+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 11:50:06.387+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 11:50:06.387+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.387+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 29314
07-14 11:50:06.387+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:50:06.397+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:50:06.407+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.407+0900 D/tdlnaservice(29082): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:50:06.407+0900 I/tdlna   (29082): _on_proxy_client_msg_received_cb 실행
07-14 11:50:06.407+0900 I/tdlna   (29082): _app_process_received_message 실행
07-14 11:50:06.407+0900 I/tdlna   (29082): _app_execute_operation 실행
07-14 11:50:06.407+0900 I/tdlna   (29082): _app_send_response 실행
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:50:06.417+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.417+0900 D/tdlnaservice(29082): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:50:06.447+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.467+0900 D/tdlnaservice(29082): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:50:06.467+0900 I/tdlna   (29082): _on_proxy_client_msg_received_cb 실행
07-14 11:50:06.467+0900 I/tdlna   (29082): _app_process_received_message 실행
07-14 11:50:06.467+0900 I/tdlna   (29082): _app_execute_operation 실행
07-14 11:50:06.467+0900 D/tdlnaservice(29082): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 11:50:06.467+0900 I/tdlna   (29082): _app_run_timer 실행
07-14 11:50:06.467+0900 I/tdlna   (29082): _app_run_timer 실행
07-14 11:50:06.467+0900 I/tdlna   (29082): _app_send_response 실행
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:50:06.467+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.467+0900 D/tdlnaservice(29082): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:50:06.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:06.847+0900 I/MALI    (29287): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x1752610] swap changed from async to sync
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:50:07.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:50:07.947+0900 D/tdlnaservice(29082): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:50:07.947+0900 I/tdlna   (29082): _on_proxy_client_msg_received_cb 실행
07-14 11:50:07.947+0900 I/tdlna   (29082): _app_process_received_message 실행
07-14 11:50:07.947+0900 I/tdlna   (29082): test _ _app_process_received_message
07-14 11:50:07.947+0900 I/tdlna   (29082): _app_execute_operation 실행
07-14 11:50:07.947+0900 I/tdlna   (29082): test 실행
07-14 11:50:07.947+0900 I/tdlna   (29082): ★★★★★ 서비스 가동중 ★★★★★ 0
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:50:08.057+0900 E/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 11:50:08.057+0900 E/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(29082) are closed. delete client info
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 11:50:08.057+0900 E/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  29082
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.057+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:50:08.077+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 11:50:08.077+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 11:50:08.077+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 29082
07-14 11:50:08.077+0900 W/AUL_AMD (  428): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 11:50:08.077+0900 I/AUL_AMD (  428): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 29082
07-14 11:50:08.077+0900 I/Tizen::System( 1068): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 11:50:08.077+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:08.077+0900 I/Tizen::App( 1023): (243) > App[org.tizen.tdlnaservice] pid[29082] terminate event is forwarded
07-14 11:50:08.077+0900 I/Tizen::System( 1023): (256) > osp.accessorymanager.service provider is found.
07-14 11:50:08.077+0900 I/Tizen::System( 1023): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 29082, ]
07-14 11:50:08.077+0900 I/Tizen::System( 1023): (256) > osp.system.service provider is found.
07-14 11:50:08.077+0900 I/Tizen::App( 1023): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 11:50:08.077+0900 I/Tizen::App( 1023): (512) > Not registered pid(29082)
07-14 11:50:08.077+0900 I/Tizen::App( 1023): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 29082.
07-14 11:50:08.087+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:08.087+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 29082.
07-14 11:50:08.127+0900 W/CRASH_MANAGER(29424): worker.c: worker_job(1236) > 112908274646c143684220
