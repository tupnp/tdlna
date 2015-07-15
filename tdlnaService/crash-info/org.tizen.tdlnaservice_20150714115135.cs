S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 30071
Date: 2015-07-14 11:51:35+0900
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
r6   = 0xb5c23d60, r7   = 0xb5c24454
r8   = 0xb5c24220, r9   = 0xb6ea813c
r10  = 0xb64264c0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe93bef8
lr   = 0x00000000, pc   = 0xb6e9d424
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     19996 KB
Buffers:     22740 KB
Cached:     218788 KB
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
VmPTE:          22 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30071 TID = 30071
30071 30085 

Maps Information
b5c26000 b6429000 rwxp [stack:30085]
b6429000 b642c000 r-xp /lib/libgpg-error.so.0.5.0
b6433000 b6434000 rwxp /lib/libgpg-error.so.0.5.0
b6434000 b648c000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6493000 b6496000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6497000 b64c3000 r-xp /usr/lib/libsystemd.so.0.0.1
b64ca000 b64cb000 r-xp /usr/lib/libsystemd.so.0.0.1
b64cb000 b64cc000 rwxp /usr/lib/libsystemd.so.0.0.1
b64cc000 b64ce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b64d5000 b64d6000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b64d6000 b65a1000 r-xp /usr/lib/libxml2.so.2.7.8
b65a9000 b65ae000 rwxp /usr/lib/libxml2.so.2.7.8
b65af000 b65bf000 r-xp /lib/libresolv-2.13.so
b65bf000 b65c0000 r-xp /lib/libresolv-2.13.so
b65c0000 b65c1000 rwxp /lib/libresolv-2.13.so
b65c4000 b65da000 r-xp /lib/libz.so.1.2.5
b65e1000 b65e2000 rwxp /lib/libz.so.1.2.5
b65e2000 b65e4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b65eb000 b65ec000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b65ec000 b65f1000 r-xp /usr/lib/libffi.so.5.0.10
b65f8000 b65f9000 rwxp /usr/lib/libffi.so.5.0.10
b65f9000 b65fa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6601000 b6602000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6602000 b6667000 r-xp /usr/lib/libsqlite3.so.0.8.6
b666e000 b6671000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6672000 b6675000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b667c000 b667d000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b667d000 b6825000 r-xp /usr/lib/libcrypto.so.1.0.0
b682c000 b6841000 rwxp /usr/lib/libcrypto.so.1.0.0
b6845000 b685b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6862000 b6863000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6863000 b6897000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b689e000 b68a0000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68a0000 b6974000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b697c000 b697f000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6981000 b6985000 r-xp /usr/lib/libchromium.so.1.0
b698c000 b698d000 rwxp /usr/lib/libchromium.so.1.0
b698d000 b69f6000 r-xp /lib/libm-2.13.so
b69fd000 b69fe000 r-xp /lib/libm-2.13.so
b69fe000 b69ff000 rwxp /lib/libm-2.13.so
b69ff000 b6a05000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a0c000 b6a0d000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a0d000 b6a2c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a33000 b6a34000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a34000 b6a37000 r-xp /usr/lib/libsmack.so.1.0.0
b6a3e000 b6a3f000 rwxp /usr/lib/libsmack.so.1.0.0
b6a3f000 b6a44000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a4c000 b6a4d000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a4d000 b6a77000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6a7f000 b6a80000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6a80000 b6a97000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6a9f000 b6aa0000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6aa0000 b6b34000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b3c000 b6b3f000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b3f000 b6b41000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b47000 b6b52000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6b59000 b6b5a000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6b5a000 b6b5f000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b67000 b6b68000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6b68000 b6c38000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c38000 b6c39000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c39000 b6c79000 r-xp /usr/lib/libeina.so.1.7.99
b6c80000 b6c81000 rwxp /usr/lib/libeina.so.1.7.99
b6c82000 b6c98000 r-xp /usr/lib/libecore.so.1.7.99
b6c9f000 b6ca0000 rwxp /usr/lib/libecore.so.1.7.99
b6cae000 b6cb5000 r-xp /usr/lib/libvconf.so.0.2.45
b6cbd000 b6cbe000 rwxp /usr/lib/libvconf.so.0.2.45
b6cbe000 b6cc3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cca000 b6ccb000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6ccb000 b6cd6000 r-xp /usr/lib/libaul.so.0.1.0
b6cde000 b6cdf000 rwxp /usr/lib/libaul.so.0.1.0
b6ce0000 b6ce8000 r-xp /lib/libgcc_s-4.6.4.so.1
b6cef000 b6cf0000 rwxp /lib/libgcc_s-4.6.4.so.1
b6cf0000 b6cf2000 r-xp /lib/libdl-2.13.so
b6cf9000 b6cfa000 r-xp /lib/libdl-2.13.so
b6cfa000 b6cfb000 rwxp /lib/libdl-2.13.so
b6cfb000 b6d06000 r-xp /lib/libunwind.so.8.0.1
b6d0d000 b6d0e000 rwxp /lib/libunwind.so.8.0.1
b6d33000 b6e4e000 r-xp /lib/libc-2.13.so
b6e56000 b6e58000 r-xp /lib/libc-2.13.so
b6e58000 b6e59000 rwxp /lib/libc-2.13.so
b6e5c000 b6e62000 r-xp /lib/librt-2.13.so
b6e69000 b6e6a000 r-xp /lib/librt-2.13.so
b6e6a000 b6e6b000 rwxp /lib/librt-2.13.so
b6e6b000 b6e6d000 r-xp /usr/lib/libdlog.so.0.0.0
b6e74000 b6e75000 rwxp /usr/lib/libdlog.so.0.0.0
b6e75000 b6e78000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6e7f000 b6e80000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6e80000 b6e83000 r-xp /usr/lib/libbundle.so.0.1.22
b6e8a000 b6e8b000 rwxp /usr/lib/libbundle.so.0.1.22
b6e8b000 b6e8e000 r-xp /usr/lib/libappcore-agent.so.1.1
b6e95000 b6e96000 rwxp /usr/lib/libappcore-agent.so.1.1
b6e96000 b6eaa000 r-xp /lib/libpthread-2.13.so
b6eb1000 b6eb2000 r-xp /lib/libpthread-2.13.so
b6eb2000 b6eb3000 rwxp /lib/libpthread-2.13.so
b6eca000 b6ece000 r-xp /usr/lib/libsys-assert.so
b6ed6000 b6ed7000 rwxp /usr/lib/libsys-assert.so
b6ed7000 b6ef4000 r-xp /lib/ld-2.13.so
b6efb000 b6efc000 r-xp /lib/ld-2.13.so
b6efc000 b6efd000 rwxp /lib/ld-2.13.so
b6efd000 b6f09000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f11000 b6f13000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b83a1000 b83e6000 rwxp [heap]
be91c000 be93d000 rwxp [stack]
End of Maps Information

Callstack Information (PID:30071)
Call Stack Count: 1
 0: pthread_create + 0x38c (0xb6e9d424) [/lib/libpthread.so.0] + 0x7424
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
und
07-14 11:50:50.957+0900 E/PKGMGR_INFO(29707): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.myfile-lite) is found
07-14 11:50:50.957+0900 E/PKGMGR_INFO(29707): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.gallery-lite) is found
07-14 11:50:50.957+0900 E/PKGMGR_INFO(29707): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.setting) is found
07-14 11:50:50.977+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:50.977+0900 E/RUA     (29707): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:50.977+0900 E/TASK_MGR_LITE(29707): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
07-14 11:50:51.027+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:51.027+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:50:51.037+0900 I/APP_CORE(29707): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 11:50:51.037+0900 I/APP_CORE(29707): appcore-efl.c: __do_app(511) > [APP 29707] Initial Launching, call the resume_cb
07-14 11:50:51.047+0900 W/APP_CORE(29707): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8e00008
07-14 11:50:51.047+0900 E/EFL     (29707): evas_main<29707> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 11:50:51.057+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29707
07-14 11:50:51.067+0900 E/EFL     (29707): evas_main<29707> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 11:50:51.077+0900 I/Tizen::System( 1068): (259) > Active app [com.samsun], current [rMfxc1AKe2] 
07-14 11:50:51.077+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:51.087+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:51.097+0900 I/Tizen::System( 1155): (101) > Active App is com.samsung.task-mgr. GetApp id ACL111OMWW.AclService
07-14 11:50:51.107+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:51.107+0900 I/MALI    (29287): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0x1752610] swap changed from sync to async
07-14 11:50:51.147+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:51.167+0900 W/AUL_AMD (  428): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 11:50:51.167+0900 W/AUL_AMD (  428): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 11:50:51.177+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.task-mgr, pid = 29707"
07-14 11:50:51.177+0900 E/TASK_MGR_LITE(29707): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:51.177+0900 E/TASK_MGR_LITE(29707): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:51.467+0900 W/STARTER (  536): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
07-14 11:50:51.487+0900 I/SYSPOPUP(  589): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
07-14 11:50:51.497+0900 I/SYSPOPUP(  589): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
07-14 11:50:51.497+0900 E/VOLUME  (  589): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-14 11:50:51.497+0900 E/VOLUME  (  589): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-14 11:50:51.507+0900 E/VOLUME  (  589): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-14 11:50:52.177+0900 E/TASK_MGR_LITE(29707): genlist_item.c: _icon_mouse_up(624) > Mouse up
07-14 11:50:52.177+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 14
07-14 11:50:52.177+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 1391
07-14 11:50:52.187+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 11:50:52.207+0900 W/AUL_AMD (  428): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 1, pid: 1391
07-14 11:50:52.207+0900 W/AUL_AMD (  428): amd_launch.c: _resume_app(728) > resume done
07-14 11:50:52.267+0900 W/AUL_AMD (  428): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(1391), cmd(3)
07-14 11:50:52.267+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 11:50:52.267+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(803) > app status : 5
07-14 11:50:52.267+0900 I/APP_CORE(29707): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-14 11:50:52.267+0900 I/APP_CORE(29707): appcore-efl.c: __after_loop(1059) > [APP 29707] PAUSE before termination
07-14 11:50:52.277+0900 E/TASK_MGR_LITE(29707): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:52.277+0900 E/TASK_MGR_LITE(29707): genlist_item.c: del_cb(758) > Deleted
07-14 11:50:52.287+0900 E/APP_CORE(29707): appcore.c: appcore_flush_memory(631) > Appcore not initialized
07-14 11:50:52.307+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29287
07-14 11:50:52.317+0900 I/MALI    (29707): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-14 11:50:52.317+0900 I/MALI    (29707): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=29707   close drm_fd=21 
07-14 11:50:52.317+0900 I/MALI    (29707): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-14 11:50:52.347+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:52.357+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 29287"
07-14 11:50:52.387+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=1391
07-14 11:50:52.397+0900 I/UXT     (29707): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-14 11:50:52.397+0900 I/Tizen::System( 1068): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 11:50:52.407+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:52.407+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:52.427+0900 I/Tizen::System( 1155): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 11:50:52.447+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:52.447+0900 I/CAPI_APPFW_APPLICATION( 1391): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-14 11:50:52.447+0900 I/Internet( 1391): main.cpp: __br_app_resume(731) > 
07-14 11:50:52.447+0900 E/Internet( 1391): mdm-manager.cpp: register_policy(220) > mdm_get_service() is failed [0xfffffffb]
07-14 11:50:52.447+0900 I/PRIVACY-MANAGER-CLIENT( 1391): SocketClient.cpp: SocketClient(37) > Client created
07-14 11:50:52.447+0900 I/PRIVACY-MANAGER-SERVER(  374): SocketService.cpp: mainloop(206) > Got incoming connection
07-14 11:50:52.447+0900 I/PRIVACY-MANAGER-CLIENT( 1391): SocketClient.cpp: connect(62) > Client connected
07-14 11:50:52.447+0900 E/EFL     (29287): ewebkit2<29287> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 11:50:52.487+0900 I/PRIVACY-MANAGER-CLIENT( 1391): SocketClient.cpp: disconnect(72) > Client disconnected
07-14 11:50:52.487+0900 E/Internet( 1391): most-visited-manager.cpp: view_resize_need(306) > Most_visited_view is NULL
07-14 11:50:52.487+0900 I/Internet( 1391): main-view.cpp: show_url_bar(421) > 0
07-14 11:50:52.487+0900 W/UI_GADGET( 1391): manager.c: ugman_resume(1045) > [34mugman_resume failed: no root[0m
07-14 11:50:52.507+0900 I/Tizen::System( 1068): (259) > Active app [com.samsun], current [rMfxc1AKe2] 
07-14 11:50:52.507+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:52.517+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:52.537+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:52.547+0900 I/Tizen::System( 1155): (101) > Active App is com.samsung.browser. GetApp id ACL111OMWW.AclService
07-14 11:50:52.557+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:50:52.627+0900 I/AUL_PAD (  462): sigchild.h: __launchpad_sig_child(142) > dead_pid = 29707 pgid = 29707
07-14 11:50:52.627+0900 I/AUL_PAD (  462): sigchild.h: __sigchild_action(123) > dead_pid(29707)
07-14 11:50:52.627+0900 I/AUL_PAD (  462): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-14 11:50:52.627+0900 I/AUL_PAD (  462): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-14 11:50:52.627+0900 I/AUL_AMD (  428): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 29707
07-14 11:50:52.627+0900 I/Tizen::System( 1068): (246) > Terminated app [com.samsung.task-mgr]
07-14 11:50:52.627+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:50:52.627+0900 I/Tizen::App( 1023): (243) > App[com.samsung.task-mgr] pid[29707] terminate event is forwarded
07-14 11:50:52.627+0900 I/Tizen::System( 1023): (256) > osp.accessorymanager.service provider is found.
07-14 11:50:52.627+0900 I/Tizen::System( 1023): (196) > Accessory Owner is removed [com.samsung.task-mgr, 29707, ]
07-14 11:50:52.627+0900 I/Tizen::System( 1023): (256) > osp.system.service provider is found.
07-14 11:50:52.627+0900 I/Tizen::App( 1023): (506) > TerminatedApp(com.samsung.task-mgr)
07-14 11:50:52.627+0900 I/Tizen::App( 1023): (512) > Not registered pid(29707)
07-14 11:50:52.627+0900 I/Tizen::App( 1023): (782) > Finished invoking application event listener for com.samsung.task-mgr, 29707.
07-14 11:50:52.637+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:50:52.637+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for com.samsung.task-mgr, 29707.
07-14 11:50:52.717+0900 I/RESOURCED(  757): vmpressure-lowmem-handler.c: lowmem_swap_memory(1099) > [lowmem_swap_memory,1099] swap cgroup entered : pid : 1863
07-14 11:50:52.737+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:50:52.757+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:50:52.767+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.browser, pid = 1391"
07-14 11:50:53.567+0900 I/RESOURCED(  757): swap.c: swap_send_signal(316) > [swap_send_signal,316] send signal to swap thread
07-14 11:50:53.567+0900 I/RESOURCED(  757): swap.c: swap_thread_main(281) > [swap_thread_main,281] swap thread conditional signal received
07-14 11:50:54.267+0900 W/AUL_AMD (  428): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 11:50:54.497+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:50:54.637+0900 I/MALI    ( 1391): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8c7e2a0] swap changed from async to sync
07-14 11:50:58.527+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:50:59.607+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:50:59.727+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 11:51:00.017+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 11:51:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is -5265128749495191276.
07-14 11:51:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:51, hour:2, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 11:51:00.017+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 11:51:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 2:51:0:23
07-14 11:51:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 11:51:0
07-14 11:51:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 43739977 milliseconds from now
07-14 11:51:00.037+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 11:51:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 11:51:00.067+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 11:51:00.067+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436842260.
07-14 11:51:00.067+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:51, hour:2, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 11:51:00.067+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 11:51:00.067+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 2:51:0:75
07-14 11:51:00.067+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 11:51:0
07-14 11:51:00.067+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59925 milliseconds from now
07-14 11:51:00.187+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 11:51:00.187+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 11:51:00.237+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:04.947+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:05.347+0900 D/dalvikvm( 1659): GC_EXPLICIT freed 20K, 50% free 2857K/5639K, external 1962K/2073K, paused 163ms
07-14 11:51:07.127+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:07.187+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:10.597+0900 E/PKGMGR_SERVER(29855): pkgmgr-server.c: main(1608) > server start
07-14 11:51:12.737+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:13.277+0900 E/PKGMGR_SERVER(29855): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 11:51:13.277+0900 E/PKGMGR_SERVER(29855): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 11:51:14.107+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:15.237+0900 E/PKGMGR_SERVER(29966): pkgmgr-server.c: main(1608) > server start
07-14 11:51:16.287+0900 I/Internet( 1391): webview.cpp: __frame_rendered_cb(3411) > 
07-14 11:51:17.027+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 11:51:17.037+0900 I/AUL     (  428): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt-launcher, ret : 0
07-14 11:51:17.037+0900 I/AUL     (  428): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt-launcher, ret : 0
07-14 11:51:17.037+0900 E/AUL_AMD (  428): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 11:51:17.057+0900 W/AUL_AMD (  428): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 0, pid: 29287
07-14 11:51:17.117+0900 W/AUL_AMD (  428): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(29287), cmd(0)
07-14 11:51:17.137+0900 E/EFL     (29287): elementary<29287> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x1a17c40 as sub object of 0x1a17f00
07-14 11:51:17.137+0900 E/WEBKIT  (29287): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 11:51:17.157+0900 E/EFL     (29314): edje<29314> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 11:51:17.167+0900 E/VCONF   (29287): vconf-kdb.c: _vconf_kdb_add_notify(313) > _vconf_kdb_add_notify : key(memory/sysman/low_memory) has same callback(0xb67b5c75)
07-14 11:51:17.167+0900 I/APP_CORE(29287): appcore-efl.c: __do_app(516) > Legacy lifecycle: 0
07-14 11:51:17.167+0900 I/APP_CORE(29287): appcore-efl.c: __do_app(518) > [APP 29287] App already running, raise the window
07-14 11:51:17.187+0900 W/AUL_AMD (  428): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 11:51:17.187+0900 W/AUL_AMD (  428): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-14 11:51:17.197+0900 I/APP_CORE(29287): appcore-efl.c: __do_app(522) > [APP 29287] Call the resume_cb
07-14 11:51:17.207+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 11:51:17.217+0900 I/AUL     (  428): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-14 11:51:17.227+0900 I/AUL     (  428): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-14 11:51:17.227+0900 E/AUL_AMD (  428): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 11:51:17.227+0900 W/AUL_AMD (  428): amd_launch.c: service_start(515) > child process: 30071
07-14 11:51:17.237+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29287
07-14 11:51:17.277+0900 E/PKGMGR_SERVER(29966): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 11:51:17.277+0900 E/PKGMGR_SERVER(29966): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 11:51:17.277+0900 I/MALI    ( 1391): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8c7e2a0] swap changed from sync to async
07-14 11:51:17.337+0900 I/Tizen::System( 1068): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 11:51:17.337+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:51:17.377+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:51:17.407+0900 I/CAPI_APPFW_APPLICATION( 1391): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 11:51:17.407+0900 I/Internet( 1391): main.cpp: __br_app_pause(703) > 
07-14 11:51:17.437+0900 W/AUL_AMD (  428): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 30071
07-14 11:51:17.437+0900 E/Internet( 1391): mdm-manager.cpp: deregister_policy(236) > mdm_deregister_policy_receiver() is failed [0xffffffff]
07-14 11:51:17.447+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:51:17.447+0900 E/Internet( 1391): mdm-manager.cpp: deregister_policy(240) > mdm_release_service failed
07-14 11:51:17.467+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:51:17.477+0900 I/Tizen::System( 1155): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 11:51:17.487+0900 I/Tizen::App( 1068): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 30071.
07-14 11:51:17.487+0900 W/UI_GADGET( 1391): manager.c: ugman_pause(1070) > [34mugman_pause failed: no root[0m
07-14 11:51:17.487+0900 E/RESOURCED(  757): proc-process.c: proc_get_oom_score_adj(377) > [proc_get_oom_score_adj,377] fopen /proc/0/oom_score_adj failed
07-14 11:51:17.507+0900 I/Tizen::App( 1023): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 11:51:17.507+0900 I/Tizen::App( 1023): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 30071.
07-14 11:51:17.507+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 29287"
07-14 11:51:17.717+0900 I/RESOURCED(  757): vmpressure-lowmem-handler.c: lowmem_swap_memory(1099) > [lowmem_swap_memory,1099] swap cgroup entered : pid : 1883
07-14 11:51:17.857+0900 I/tdlna   (30071): _on_create_cb 실행
07-14 11:51:17.857+0900 I/tdlna   (30071): _app_init 실행
07-14 11:51:17.857+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 11:51:17.867+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 11:51:17.867+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 30071
07-14 11:51:17.887+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:17.887+0900 D/tdlnaservice(30071): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 11:51:17.887+0900 I/tdlna   (30071): _on_app_control_callback 실행
07-14 11:51:17.887+0900 I/tdlna   (30071): _app_timer_thread_func 실행
07-14 11:51:18.097+0900 E/WEBKIT  (29287): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 11:51:18.587+0900 I/RESOURCED(  757): swap.c: swap_send_signal(316) > [swap_send_signal,316] send signal to swap thread
07-14 11:51:18.587+0900 I/RESOURCED(  757): swap.c: swap_thread_main(281) > [swap_thread_main,281] swap thread conditional signal received
07-14 11:51:18.607+0900 E/RESOURCED(  757): swap.c: swap_thread_do(219) > [swap_thread_do,219] we killed 1659 (app_runner)
07-14 11:51:18.627+0900 E/InputDispatcher( 1413): channel '40c6be38 StatusBar (server)' ~ Consumer closed input channel or an error occurred.  events=0x8
07-14 11:51:18.627+0900 E/InputDispatcher( 1413): channel '40c6be38 StatusBar (server)' ~ Channel is unrecoverably broken and will be disposed!
07-14 11:51:18.627+0900 I/WindowManager( 1413): WINDOW DIED Window{40c6be38 StatusBar paused=false}
07-14 11:51:18.637+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:18.637+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:18.637+0900 I/ActivityManager( 1413): Process com.android.systemui (pid 1659) has died.
07-14 11:51:18.657+0900 E/InputDispatcher( 1413): channel '40c6d058 TrackingView (server)' ~ Consumer closed input channel or an error occurred.  events=0x8
07-14 11:51:18.657+0900 E/InputDispatcher( 1413): channel '40c6d058 TrackingView (server)' ~ Channel is unrecoverably broken and will be disposed!
07-14 11:51:18.667+0900 W/ActivityManager( 1413): Scheduling restart of crashed service com.android.systemui/.statusbar.StatusBarService in 5000ms
07-14 11:51:18.667+0900 E/Tizen::Io( 1155): (133) > [E_INVALID_ARG] The application id is empty.
07-14 11:51:18.677+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:18.697+0900 W/WindowManager( 1413): Failed looking up window
07-14 11:51:18.697+0900 W/WindowManager( 1413): java.lang.IllegalArgumentException: Requested window android.os.BinderProxy@40b438f8 does not exist
07-14 11:51:18.697+0900 W/WindowManager( 1413): 	at com.android.server.WindowManagerService.windowForClientLocked(WindowManagerService.java:8179)
07-14 11:51:18.697+0900 W/WindowManager( 1413): 	at com.android.server.WindowManagerService.windowForClientLocked(WindowManagerService.java:8170)
07-14 11:51:18.697+0900 W/WindowManager( 1413): 	at com.android.server.WindowManagerService$WindowState$DeathRecipient.binderDied(WindowManagerService.java:7026)
07-14 11:51:18.697+0900 W/WindowManager( 1413): 	at android.os.BinderProxy.sendDeathNotice(Binder.java:381)
07-14 11:51:18.697+0900 W/WindowManager( 1413): 	at dalvik.system.NativeStart.run(Native Method)
07-14 11:51:18.697+0900 I/WindowManager( 1413): WIN DEATH: null
07-14 11:51:18.697+0900 I/WindowManager( 1413): WIN DEATH: Window{40c6d058 TrackingView paused=false}
07-14 11:51:18.697+0900 D/ACL     ( 1413): ************ onWindowDeath()  title = TrackingView
07-14 11:51:18.697+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:18.697+0900 I/WindowManager( 1413): WIN DEATH: Window{40ca77a0 StatusBarExpanded paused=false}
07-14 11:51:18.697+0900 D/ACL     ( 1413): ************ onWindowDeath()  title = StatusBarExpanded
07-14 11:51:18.707+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:18.717+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:18.717+0900 E/InputDispatcher( 1413): Received spurious receive callback for unknown input channel.  fd=214, events=0x8
07-14 11:51:18.747+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:19.657+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:51:19.687+0900 I/MALI    (29287): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x1752610] swap changed from async to sync
07-14 11:51:19.857+0900 E/PKGMGR_INFO(29314): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 11:51:19.897+0900 E/PKGMGR_INFO(29314): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.browser) is found
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:19.937+0900 D/tdlnaservice(30071): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:51:19.937+0900 I/tdlna   (30071): _on_proxy_client_msg_received_cb 실행
07-14 11:51:19.937+0900 I/tdlna   (30071): _app_process_received_message 실행
07-14 11:51:19.937+0900 I/tdlna   (30071): _app_execute_operation 실행
07-14 11:51:19.937+0900 I/tdlna   (30071): _app_send_response 실행
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:51:19.937+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:19.937+0900 D/tdlnaservice(30071): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:51:19.977+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:19.987+0900 D/tdlnaservice(30071): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:51:19.987+0900 I/tdlna   (30071): _on_proxy_client_msg_received_cb 실행
07-14 11:51:19.987+0900 I/tdlna   (30071): _app_process_received_message 실행
07-14 11:51:19.987+0900 I/tdlna   (30071): _app_execute_operation 실행
07-14 11:51:19.987+0900 D/tdlnaservice(30071): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 11:51:19.987+0900 I/tdlna   (30071): _app_run_timer 실행
07-14 11:51:19.987+0900 I/tdlna   (30071): _app_run_timer 실행
07-14 11:51:19.987+0900 I/tdlna   (30071): _app_send_response 실행
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:51:19.987+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:19.987+0900 D/tdlnaservice(30071): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:51:20.007+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:23.687+0900 I/ActivityManager( 1413): Start proc com.android.systemui for service com.android.systemui/.statusbar.StatusBarService: pid=30118 uid=1000 gids={3003}
07-14 11:51:23.697+0900 I/dalvikvm(30118): setgroupsIntarray short-circuit
07-14 11:51:23.697+0900 I/dalvikvm(30118): setrlimitsFromArray short-circuit
07-14 11:51:23.697+0900 E/dalvikvm(30118): cannot setgid(1000): Operation not permitted
07-14 11:51:23.697+0900 E/dalvikvm(30118): cannot setuid(1000): Operation not permitted
07-14 11:51:23.697+0900 I/dalvikvm(30118): setCapabilities short-circuit
07-14 11:51:23.707+0900 E/dalvikvm(30118): could not disable core file generation for pid 30118: Operation not permitted
07-14 11:51:23.747+0900 D/dalvikvm( 1336): GC_EXPLICIT freed 10K, 50% free 2708K/5379K, external 1527K/1559K, paused 59ms
07-14 11:51:23.787+0900 D/dalvikvm( 1336): GC_EXPLICIT freed <1K, 50% free 2708K/5379K, external 1527K/1559K, paused 43ms
07-14 11:51:23.837+0900 D/dalvikvm( 1336): GC_EXPLICIT freed <1K, 50% free 2708K/5379K, external 1527K/1559K, paused 47ms
07-14 11:51:23.897+0900 D/dalvikvm(30118): GC_CONCURRENT freed 408K, 51% free 2788K/5639K, external 1527K/1559K, paused 2ms+2ms
07-14 11:51:23.897+0900 D/ACL     ( 1413): ************ onApplicationCreated()  application = ApplicationInfo{40d2e728 com.android.systemui}
07-14 11:51:23.897+0900 D/ACL     ( 1413): >>>>>>>>  send : cmd=CMD_CREATE  pkg= com.android.systemui  taskid=0 status=-1
07-14 11:51:23.897+0900 I/AclService( 1155): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=1(CMD_CREATE) taskid=0  pkg='com.android.systemui' status='-1' app=''
07-14 11:51:23.977+0900 D/dalvikvm(30118): GC_EXTERNAL_ALLOC freed 17K, 51% free 2800K/5639K, external 1543K/1559K, paused 20ms
07-14 11:51:24.027+0900 I/StatusBarManagerService( 1413): registerStatusBar bar=com.android.internal.statusbar.IStatusBar$Stub$Proxy@40b94c30
07-14 11:51:24.047+0900 D/StatusBarService(30118): addNavigationBar()
07-14 11:51:24.057+0900 D/VoldCmdListener( 1333): share status ums
07-14 11:51:24.067+0900 D/StorageNotification(30118): Startup with UMS connection false (media state mounted)
07-14 11:51:24.067+0900 I/StorageNotification(30118): UMS connection changed to false (media state mounted)
07-14 11:51:24.107+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:24.107+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:24.107+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:24.107+0900 E/Tizen::Io( 1155): (133) > [E_INVALID_ARG] The application id is empty.
07-14 11:51:24.137+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:24.137+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:24.167+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:24.167+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:24.177+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:24.187+0900 D/WindowManager( 1413): beginLayoutLw : displayWidth=480  displayHeight=800
07-14 11:51:24.237+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:51:34.767+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK:2064142451] slot:0 sock:7
07-14 11:51:34.767+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[HISTORY:1864756738] slot:1 sock:10
07-14 11:51:34.767+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 11:51:34.767+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[TABS:1899847238] slot:3 sock:16
07-14 11:51:34.767+0900 E/BOOKMARK_ADAPTOR( 1391): common-adaptor.c: bp_common_adaptor_event_manager(848) > closed by provider :3
07-14 11:51:34.767+0900 E/HISTORY_ADAPTOR( 1391): common-adaptor.c: bp_common_adaptor_event_manager(848) > closed by provider :3
07-14 11:51:34.767+0900 E/TAB_ADAPTOR( 1391): common-adaptor.c: bp_common_adaptor_event_manager(848) > closed by provider :3
07-14 11:51:34.767+0900 E/BROWSER_PROVIDER(27001): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:16
07-14 11:51:34.767+0900 E/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: client_thread_idle(467) > disconnect client:TABS/1899847238 sock:16
07-14 11:51:34.767+0900 E/BROWSER_PROVIDER(27001): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:10
07-14 11:51:34.767+0900 E/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: client_thread_idle(467) > disconnect client:HISTORY/1864756738 sock:10
07-14 11:51:34.767+0900 E/BROWSER_PROVIDER(27001): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:7
07-14 11:51:34.767+0900 E/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: client_thread_idle(467) > disconnect client:BOOKMARK/2064142451 sock:7
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:51:35.507+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:51:35.507+0900 D/tdlnaservice(30071): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:51:35.507+0900 I/tdlna   (30071): _on_proxy_client_msg_received_cb 실행
07-14 11:51:35.507+0900 I/tdlna   (30071): _app_process_received_message 실행
07-14 11:51:35.507+0900 I/tdlna   (30071): test _ _app_process_received_message
07-14 11:51:35.507+0900 I/tdlna   (30071): _app_execute_operation 실행
07-14 11:51:35.507+0900 I/tdlna   (30071): test 실행
07-14 11:51:35.507+0900 I/tdlna   (30071): ★★★★★ 서비스 가동중 ★★★★★ 0
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:51:35.627+0900 E/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 11:51:35.627+0900 E/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(30071) are closed. delete client info
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 11:51:35.627+0900 E/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  30071
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.627+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:51:35.637+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 11:51:35.637+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 11:51:35.637+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 30071
07-14 11:51:35.637+0900 W/AUL_AMD (  428): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 11:51:35.637+0900 I/AUL_AMD (  428): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 30071
07-14 11:51:35.637+0900 I/Tizen::System( 1068): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 11:51:35.637+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:51:35.637+0900 I/Tizen::App( 1023): (243) > App[org.tizen.tdlnaservice] pid[30071] terminate event is forwarded
07-14 11:51:35.637+0900 I/Tizen::System( 1023): (256) > osp.accessorymanager.service provider is found.
07-14 11:51:35.637+0900 I/Tizen::System( 1023): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 30071, ]
07-14 11:51:35.637+0900 I/Tizen::System( 1023): (256) > osp.system.service provider is found.
07-14 11:51:35.637+0900 I/Tizen::App( 1023): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 11:51:35.637+0900 I/Tizen::App( 1023): (512) > Not registered pid(30071)
07-14 11:51:35.637+0900 I/Tizen::App( 1023): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 30071.
07-14 11:51:35.647+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:51:35.647+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 30071.
07-14 11:51:35.687+0900 W/CRASH_MANAGER(30188): worker.c: worker_job(1236) > 113007174646c143684229
