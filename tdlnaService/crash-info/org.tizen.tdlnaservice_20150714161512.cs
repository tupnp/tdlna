S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 7497
Date: 2015-07-14 16:15:12+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x29e90000

Register Information
r0   = 0x29e90002, r1   = 0x29e90000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6fca5eb
r6   = 0xbeab7818, r7   = 0x29e90002
r8   = 0x0000001e, r9   = 0xb64e94d0
r10  = 0xb6fca5cc, fp   = 0xbeab780c
ip   = 0x00000000, sp   = 0xbeab72a8
lr   = 0xb6e355b8, pc   = 0xb6e68d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     31848 KB
Buffers:     29000 KB
Cached:     264892 KB
VmPeak:      20700 KB
VmSize:      20696 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4952 KB
VmRSS:        4952 KB
VmData:       9828 KB
VmStk:         136 KB
VmExe:          52 KB
VmLib:        9144 KB
VmPTE:          18 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7497 TID = 7497
7497 7502 

Maps Information
b5ce9000 b64ec000 rwxp [stack:7502]
b64ec000 b64ef000 r-xp /lib/libgpg-error.so.0.5.0
b64f6000 b64f7000 rwxp /lib/libgpg-error.so.0.5.0
b64f7000 b654f000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6556000 b6559000 rwxp /usr/lib/libgcrypt.so.11.5.3
b655a000 b6586000 r-xp /usr/lib/libsystemd.so.0.0.1
b658d000 b658e000 r-xp /usr/lib/libsystemd.so.0.0.1
b658e000 b658f000 rwxp /usr/lib/libsystemd.so.0.0.1
b658f000 b6591000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6598000 b6599000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6599000 b6664000 r-xp /usr/lib/libxml2.so.2.7.8
b666c000 b6671000 rwxp /usr/lib/libxml2.so.2.7.8
b6672000 b6682000 r-xp /lib/libresolv-2.13.so
b6682000 b6683000 r-xp /lib/libresolv-2.13.so
b6683000 b6684000 rwxp /lib/libresolv-2.13.so
b6687000 b669d000 r-xp /lib/libz.so.1.2.5
b66a4000 b66a5000 rwxp /lib/libz.so.1.2.5
b66a5000 b66a7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66ae000 b66af000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66af000 b66b4000 r-xp /usr/lib/libffi.so.5.0.10
b66bb000 b66bc000 rwxp /usr/lib/libffi.so.5.0.10
b66bc000 b66bd000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66c4000 b66c5000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66c5000 b672a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6731000 b6734000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6735000 b6738000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b673f000 b6740000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6740000 b68e8000 r-xp /usr/lib/libcrypto.so.1.0.0
b68ef000 b6904000 rwxp /usr/lib/libcrypto.so.1.0.0
b6908000 b691e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6925000 b6926000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6926000 b695a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6961000 b6963000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6963000 b6a37000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a3f000 b6a42000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a44000 b6a48000 r-xp /usr/lib/libchromium.so.1.0
b6a4f000 b6a50000 rwxp /usr/lib/libchromium.so.1.0
b6a50000 b6ab9000 r-xp /lib/libm-2.13.so
b6ac0000 b6ac1000 r-xp /lib/libm-2.13.so
b6ac1000 b6ac2000 rwxp /lib/libm-2.13.so
b6ac2000 b6ac8000 r-xp /usr/lib/libappsvc.so.0.1.0
b6acf000 b6ad0000 rwxp /usr/lib/libappsvc.so.0.1.0
b6ad0000 b6aef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6af6000 b6af7000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6af7000 b6afa000 r-xp /usr/lib/libsmack.so.1.0.0
b6b01000 b6b02000 rwxp /usr/lib/libsmack.so.1.0.0
b6b02000 b6b07000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b0f000 b6b10000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b10000 b6b3a000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b42000 b6b43000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b43000 b6b5a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b62000 b6b63000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b63000 b6bf7000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bff000 b6c02000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c02000 b6c04000 rwxp /usr/lib/libstdc++.so.6.0.16
b6c0a000 b6c15000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c1c000 b6c1d000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c1d000 b6c22000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c2a000 b6c2b000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c2b000 b6cfb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6cfb000 b6cfc000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6cfc000 b6d3c000 r-xp /usr/lib/libeina.so.1.7.99
b6d43000 b6d44000 rwxp /usr/lib/libeina.so.1.7.99
b6d45000 b6d5b000 r-xp /usr/lib/libecore.so.1.7.99
b6d62000 b6d63000 rwxp /usr/lib/libecore.so.1.7.99
b6d71000 b6d78000 r-xp /usr/lib/libvconf.so.0.2.45
b6d80000 b6d81000 rwxp /usr/lib/libvconf.so.0.2.45
b6d81000 b6d86000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d8d000 b6d8e000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d8e000 b6d99000 r-xp /usr/lib/libaul.so.0.1.0
b6da1000 b6da2000 rwxp /usr/lib/libaul.so.0.1.0
b6da3000 b6dab000 r-xp /lib/libgcc_s-4.6.4.so.1
b6db2000 b6db3000 rwxp /lib/libgcc_s-4.6.4.so.1
b6db3000 b6db5000 r-xp /lib/libdl-2.13.so
b6dbc000 b6dbd000 r-xp /lib/libdl-2.13.so
b6dbd000 b6dbe000 rwxp /lib/libdl-2.13.so
b6dbe000 b6dc9000 r-xp /lib/libunwind.so.8.0.1
b6dd0000 b6dd1000 rwxp /lib/libunwind.so.8.0.1
b6df6000 b6f11000 r-xp /lib/libc-2.13.so
b6f19000 b6f1b000 r-xp /lib/libc-2.13.so
b6f1b000 b6f1c000 rwxp /lib/libc-2.13.so
b6f1f000 b6f25000 r-xp /lib/librt-2.13.so
b6f2c000 b6f2d000 r-xp /lib/librt-2.13.so
b6f2d000 b6f2e000 rwxp /lib/librt-2.13.so
b6f2e000 b6f30000 r-xp /usr/lib/libdlog.so.0.0.0
b6f37000 b6f38000 rwxp /usr/lib/libdlog.so.0.0.0
b6f38000 b6f3b000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f42000 b6f43000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f43000 b6f46000 r-xp /usr/lib/libbundle.so.0.1.22
b6f4d000 b6f4e000 rwxp /usr/lib/libbundle.so.0.1.22
b6f4e000 b6f51000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f58000 b6f59000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f59000 b6f6d000 r-xp /lib/libpthread-2.13.so
b6f74000 b6f75000 r-xp /lib/libpthread-2.13.so
b6f75000 b6f76000 rwxp /lib/libpthread-2.13.so
b6f8d000 b6f91000 r-xp /usr/lib/libsys-assert.so
b6f99000 b6f9a000 rwxp /usr/lib/libsys-assert.so
b6f9a000 b6fb7000 r-xp /lib/ld-2.13.so
b6fbe000 b6fbf000 r-xp /lib/ld-2.13.so
b6fbf000 b6fc0000 rwxp /lib/ld-2.13.so
b6fc0000 b6fcd000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fd4000 b6fd6000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b8306000 b834b000 rwxp [heap]
bea98000 beab9000 rwxp [stack]
End of Maps Information

Callstack Information (PID:7497)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e68d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e355b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6ecdb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f2f063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x43a (0xb6fc50a3) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x50a3
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
ntrol_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-14 16:14:19.900+0900 W/CAM_APP ( 7600): cam_app.c: cam_handle_init(1524) > [33mmode : 1 [0m
07-14 16:14:19.900+0900 W/CAM_APP ( 7600): cam_mm.c: cam_mm_create(1641) > [33mSTART[0m
07-14 16:14:19.900+0900 W/CAM_APP ( 7600): cam_sound_session_manager.c: cam_sound_session_create(49) > [33mcreate sound session[0m
07-14 16:14:19.900+0900 I/TIZEN_N_SOUND_MANAGER( 7600): sound_manager_product.c: sound_manager_multi_session_create(585) > >> enter : type=2, session=0xb34a0370
07-14 16:14:19.910+0900 I/TIZEN_N_SOUND_MANAGER( 7600): sound_manager_product.c: sound_manager_multi_session_create(637) > << leave : type=2, session=0xb34a0370
07-14 16:14:19.910+0900 W/TIZEN_N_CAMERA( 7600): camera.c: camera_create(764) > [camera_create]device name = [0]
07-14 16:14:19.920+0900 W/TIZEN_N_CAMERA( 7600): camera.c: camera_create(824) > camera handle 0xb80b0460
07-14 16:14:19.920+0900 W/TIZEN_N_RECORDER( 7600): recorder.c: recorder_create_videorecorder(422) > permission check done
07-14 16:14:19.920+0900 W/CAM_APP ( 7600): cam_mm.c: cam_mm_create(1696) > [33mEND[0m
07-14 16:14:19.930+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_start(684) > [33m############# cam_app_start - START #############[0m
07-14 16:14:19.930+0900 E/TIZEN_N_RECORDER( 7600): recorder.c: __convert_recorder_error_code(192) > [recorder_set_video_resolution] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-14 16:14:19.930+0900 E/TIZEN_N_RECORDER( 7600): recorder.c: __convert_recorder_error_code(192) > [recorder_attr_set_recording_flip] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
07-14 16:14:19.930+0900 E/TIZEN_N_CAMERA( 7600): camera.c: camera_attr_enable_anti_shake(3351) > NOT SUPPORTED
07-14 16:14:19.940+0900 E/CAM_APP ( 7600): cam_mm.c: cam_mm_set_anti_hand_shake(329) > [31mcamera_attr_enable_anti_shake failed - code[c0000002][0m
07-14 16:14:19.940+0900 I/TIZEN_N_CAMERA( 7600): camera.c: camera_get_recommended_preview_resolution(1968) > recommend resolution 640x480, type 0
07-14 16:14:19.940+0900 E/CAM_APP ( 7600): cam_app.c: cam_app_start(701) > [31mcam_app_init_attribute failed[0m
07-14 16:14:19.940+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_start(711) > [33mapp state is CAM_APP_PRELAUNCH_STATE. so do not start preview[0m
07-14 16:14:19.940+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_start(729) > [33m############# cam_app_start - END #############[0m
07-14 16:14:20.040+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_create_main_view(1257) > [33mSTART:[0][0m
07-14 16:14:20.040+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_destroy_main_view(1309) > [33mSTART:[0][0m
07-14 16:14:20.040+0900 W/CAM_APP ( 7600): cam_standby_view.c: cam_standby_view_destroy(2398) > [33mstandby_view is NULL[0m
07-14 16:14:20.040+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_destroy_main_view(1334) > [33mEND[0m
07-14 16:14:20.060+0900 E/PHONE   ( 1325): CtSimMgr.cpp: __updateSimId(300) > [0;31m* Critical * tel_get_sim_imsi() is failed[0;m
07-14 16:14:20.090+0900 I/UXT     ( 2025): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-14 16:14:20.140+0900 I/AUL_AMD (  451): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 2021
07-14 16:14:20.140+0900 I/Tizen::App(  964): (243) > App[rMfxc1AKe2.tdlnaWeb] pid[2021] terminate event is forwarded
07-14 16:14:20.140+0900 I/Tizen::System(  964): (256) > osp.accessorymanager.service provider is found.
07-14 16:14:20.140+0900 I/Tizen::System(  964): (196) > Accessory Owner is removed [rMfxc1AKe2.tdlnaWeb, 2021, ]
07-14 16:14:20.140+0900 I/Tizen::System(  964): (256) > osp.system.service provider is found.
07-14 16:14:20.140+0900 I/Tizen::App(  964): (506) > TerminatedApp(rMfxc1AKe2.tdlnaWeb)
07-14 16:14:20.140+0900 I/Tizen::App(  964): (512) > Not registered pid(2021)
07-14 16:14:20.140+0900 I/Tizen::App(  964): (782) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 2021.
07-14 16:14:20.140+0900 I/Tizen::System(  989): (246) > Terminated app [rMfxc1AKe2.tdlnaWeb]
07-14 16:14:20.140+0900 I/Tizen::Io(  989): (729) > Entry not found
07-14 16:14:20.150+0900 E/EFL     ( 7600): evas_main<7600> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 16:14:20.150+0900 I/Tizen::System(  989): (157) > change brightness system value.
07-14 16:14:20.150+0900 I/Tizen::App(  989): (782) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 2021.
07-14 16:14:20.170+0900 I/TIZEN_N_CAMERA( 7600): camera_product.c: camera_preload_framework(814) > done load plugin
07-14 16:14:20.170+0900 W/CAM_APP ( 7600): cam.c: __cam_preloading_thread_run(842) > [33mEND[0m
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:20.180+0900 E/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 16:14:20.180+0900 E/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(2025) are closed. delete client info
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 16:14:20.180+0900 E/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  2025
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:14:20.180+0900 E/EFL     ( 7600): evas_main<7600> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 16:14:20.310+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_create_main_view(1303) > [33mEND[0m
07-14 16:14:20.310+0900 W/CAM_APP ( 7600): cam.c: cam_service(594) > [33mapp state is CAM_APP_PRELAUNCH_STATE. so do not show window[0m
07-14 16:14:20.320+0900 W/CAM_APP ( 7600): cam.c: cam_service(730) > [33m############## cam_service END ##############[0m
07-14 16:14:20.330+0900 I/APP_CORE( 7600): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 16:14:20.330+0900 I/APP_CORE( 7600): appcore-efl.c: __do_app(511) > [APP 7600] Initial Launching, call the resume_cb
07-14 16:14:20.330+0900 I/CAPI_APPFW_APPLICATION( 7600): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-14 16:14:20.330+0900 W/CAM_APP ( 7600): cam.c: cam_resume(345) > [33m############## cam_resume START ##############[0m
07-14 16:14:20.330+0900 W/CAM_APP ( 7600): cam.c: cam_resume(356) > [33mapp state is CAM_APP_PRELAUNCH_STATE[0m
07-14 16:14:20.330+0900 I/Tizen::App(  989): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 7600.
07-14 16:14:20.340+0900 W/CAM_APP ( 7600): cam.c: __app_init_idler(926) > [33mSTART[0m
07-14 16:14:20.340+0900 W/CAM_APP ( 7600): cam_shot.c: cam_shot_create(254) > [33mstart[0m
07-14 16:14:20.340+0900 W/CAM_APP ( 7600): cam_shot.c: cam_shot_create(270) > [33mend[0m
07-14 16:14:20.340+0900 I/Tizen::App(  964): (499) > LaunchedApp(com.samsung.camera-app-lite)
07-14 16:14:20.350+0900 I/Tizen::App(  964): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 7600.
07-14 16:14:20.350+0900 W/CAM_APP ( 7600): cam_lbs.c: cam_lbs_init(190) > [33mstart[0m
07-14 16:14:20.360+0900 I/EAS_COMMON( 1325): eas-svc.cpp: eas_service_init(56) > <<-- Entering func
07-14 16:14:20.360+0900 W/LOCATION( 7600): module-internal.c: module_is_supported(282) > module name(gps) is found
07-14 16:14:20.360+0900 I/EAS_COMMON( 1325): eas-svc.cpp: eas_service_init(73) > -->> Leaving func
07-14 16:14:20.360+0900 I/EAS_COMMON( 1325): eas-svc.cpp: eas_service_deinit(79) > <<-- Entering func
07-14 16:14:20.360+0900 I/EAS_COMMON( 1325): eas-svc.cpp: eas_service_deinit(115) > -->> Leaving func
07-14 16:14:20.380+0900 I/PRIVACY-MANAGER-CLIENT( 7600): PrivacyChecker.cpp: initialize(174) > Got lock. Starting initialize
07-14 16:14:20.380+0900 I/PRIVACY-MANAGER-CLIENT( 7600): PrivacyChecker.cpp: runSignalListenerThread(204) > Running g main loop for signal
07-14 16:14:20.380+0900 I/PRIVACY-MANAGER-CLIENT( 7600): PrivacyChecker.cpp: initializeDbus(230) > Starting initialize
07-14 16:14:20.400+0900 I/PRIVACY-MANAGER-CLIENT( 7600): PrivacyChecker.cpp: initializeDbus(245) > Initialized
07-14 16:14:20.400+0900 I/PRIVACY-MANAGER-CLIENT( 7600): PrivacyChecker.cpp: initialize(192) > Initialized
07-14 16:14:20.420+0900 W/LOCATION( 7600): module-internal.c: module_is_supported(282) > module name(gps) is found
07-14 16:14:20.440+0900 W/LOCATION( 7600): module-internal.c: module_new(253) > module (gps) open success
07-14 16:14:20.460+0900 W/LOCATION( 7600): module-internal.c: module_is_supported(282) > module name(wps) is found
07-14 16:14:20.470+0900 W/LOCATION( 7600): module-internal.c: module_new(253) > module (wps) open success
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam_lbs.c: cam_lbs_init(228) > [33mend[0m
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(32) > [33mSTART[0m
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(49) > [33mg_key_file_load_from_file failed: No such file or directory[0m
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_camera_control_thread_run(8494) > [33mstart[0m
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(55) > [33mload default data for dreamshot[0m
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam_dream_shot_template_info.c: cam_dream_shot_template_info_init(67) > [33mEND[0m
07-14 16:14:20.490+0900 W/CAM_APP ( 7600): cam.c: __app_init_idler(961) > [33mEND[0m
07-14 16:14:20.520+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_join_thread_async_cb(5880) > [33mjoin thread [0][0m
07-14 16:14:20.520+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_join_thread(8195) > [33mpthread_join 0[0m
07-14 16:14:20.520+0900 W/CAM_APP ( 7600): cam_app.c: cam_app_join_thread(8198) > [33mpthread_join end 0[0m
07-14 16:14:20.530+0900 I/MALI    ( 1325): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
07-14 16:14:20.530+0900 I/MALI    ( 1325): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=1325   close drm_fd=21 
07-14 16:14:20.530+0900 I/MALI    ( 1325): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
07-14 16:14:20.660+0900 I/UXT     ( 1325): uxt_object_manager.cpp: on_terminating(301) > Terminating.
07-14 16:14:20.770+0900 I/CAPI_APPFW_APPLICATION( 1325): app_main.c: ui_app_remove_event_handler(764) > handler list is not initialized
07-14 16:14:20.800+0900 I/AUL_PAD ( 1096): sigchild.h: __launchpad_sig_child(142) > dead_pid = 1325 pgid = 1325
07-14 16:14:20.800+0900 I/AUL_PAD ( 1096): sigchild.h: __sigchild_action(123) > dead_pid(1325)
07-14 16:14:20.800+0900 I/AUL_PAD ( 1096): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-14 16:14:20.800+0900 I/AUL_PAD ( 1096): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-14 16:14:20.800+0900 I/Tizen::System(  989): (246) > Terminated app [com.samsung.phone]
07-14 16:14:20.800+0900 I/Tizen::Io(  989): (729) > Entry not found
07-14 16:14:20.810+0900 I/Tizen::App(  964): (243) > App[com.samsung.phone] pid[1325] terminate event is forwarded
07-14 16:14:20.810+0900 I/Tizen::System(  964): (256) > osp.accessorymanager.service provider is found.
07-14 16:14:20.810+0900 I/Tizen::System(  964): (196) > Accessory Owner is removed [com.samsung.phone, 1325, ]
07-14 16:14:20.810+0900 I/Tizen::System(  964): (256) > osp.system.service provider is found.
07-14 16:14:20.810+0900 I/Tizen::App(  964): (506) > TerminatedApp(com.samsung.phone)
07-14 16:14:20.810+0900 I/Tizen::App(  964): (512) > Not registered pid(1325)
07-14 16:14:20.810+0900 I/Tizen::App(  964): (782) > Finished invoking application event listener for com.samsung.phone, 1325.
07-14 16:14:20.810+0900 I/AUL_AMD (  451): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1325
07-14 16:14:20.820+0900 I/Tizen::System(  989): (157) > change brightness system value.
07-14 16:14:20.820+0900 I/Tizen::App(  989): (782) > Finished invoking application event listener for com.samsung.phone, 1325.
07-14 16:14:20.820+0900 W/AUL_AMD (  451): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 16:14:20.820+0900 W/AUL_AMD (  451): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-14 16:14:21.160+0900 W/AUL_AMD (  451): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 16:14:21.200+0900 W/AUL_AMD (  451): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 16:14:21.300+0900 W/AUL_AMD (  451): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 16:14:21.360+0900 W/AUL_AMD (  451): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 16:14:21.390+0900 I/UXT     ( 7650): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 16:14:21.820+0900 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8ecb138] swap changed from async to sync
07-14 16:14:26.560+0900 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 16:14:26.560+0900 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 16:14:26.560+0900 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 16:14:26.560+0900 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 16:14:26.560+0900 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 16:14:27.320+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 16:14:27.350+0900 I/AUL     (  964): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:27.360+0900 E/RESOURCED(  766): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 333
07-14 16:14:27.360+0900 I/AUL     (  989): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:27.380+0900 I/AUL     (  964): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:27.380+0900 E/Tizen::App(  964): (703) > Cannot acquire app for 2026.
07-14 16:14:27.390+0900 I/AUL     (  989): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:27.390+0900 E/Tizen::App(  989): (703) > Cannot acquire app for 2026.
07-14 16:14:27.430+0900 I/UXT     ( 2026): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 16:14:27.500+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 16:14:27.500+0900 W/AUL_AMD (  451): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 16:14:27.510+0900 W/AUL_AMD (  451): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 16:14:27.600+0900 I/EFL-ASSIST( 2026): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [1eaa288]
07-14 16:14:27.600+0900 I/EFL-ASSIST( 2026): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1ec4a18) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:14:27.610+0900 I/EFL-ASSIST( 2026): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1ec4a18) is freed
07-14 16:14:27.740+0900 E/EFL     ( 2026): evas_main<2026> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 16:14:27.750+0900 E/EFL     ( 2026): evas_main<2026> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 16:14:27.800+0900 E/PKGMGR_INFO( 2026): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 16:14:27.800+0900 I/APP_CORE( 2026): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 16:14:27.800+0900 I/APP_CORE( 2026): appcore-efl.c: __do_app(511) > [APP 2026] Initial Launching, call the resume_cb
07-14 16:14:27.820+0900 E/EFL     ( 2026): elementary<2026> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x20d3978 as sub object of 0x204ff38
07-14 16:14:27.830+0900 I/AUL     ( 2077): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:14:27.840+0900 E/WEBKIT  ( 2026): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 16:14:27.870+0900 I/CAPI_NETWORK_CONNECTION( 2026): connection.c: connection_create(363) > New handle created[0x20fdbe0]
07-14 16:14:27.870+0900 I/CAPI_NETWORK_CONNECTION( 2026): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 16:14:27.870+0900 I/CAPI_NETWORK_CONNECTION( 2026): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 16:14:27.870+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2026): system_settings.c: system_settings_set_changed_cb(541) > b3e972b1
07-14 16:14:27.870+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2026): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3e95d99
07-14 16:14:27.950+0900 E/EFL     ( 2077): edje<2077> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 16:14:27.970+0900 W/PROCESSMGR(  418): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2026
07-14 16:14:27.990+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 16:14:28.000+0900 I/indicator(  478): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 2026"
07-14 16:14:28.020+0900 W/APP_CORE( 2026): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200003
07-14 16:14:28.030+0900 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8ecb138] swap changed from sync to async
07-14 16:14:28.070+0900 I/Tizen::System(  989): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 16:14:28.070+0900 I/Tizen::Io(  989): (729) > Entry not found
07-14 16:14:28.070+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 16:14:28.080+0900 I/Tizen::System( 1085): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 16:14:28.080+0900 I/Tizen::System(  989): (157) > change brightness system value.
07-14 16:14:28.120+0900 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 16:14:28.120+0900 E/cluster-home(  604): homescreen-main.cpp: app_pause(355) >  app pause
07-14 16:14:28.500+0900 I/UXT     ( 7695): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 16:14:28.530+0900 I/EFL-ASSIST( 7695): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1ebe530) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:14:28.530+0900 I/EFL-ASSIST( 7695): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1ebe530) is freed
07-14 16:14:28.550+0900 I/EFL-ASSIST( 7695): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1ebe530) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:14:28.550+0900 I/EFL-ASSIST( 7695): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1ebe530) is freed
07-14 16:14:28.620+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.630+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.630+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.640+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.650+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.650+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.660+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.660+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.670+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.670+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.670+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.670+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.690+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.700+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.700+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.700+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.710+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.720+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.720+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.720+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.730+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.740+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.740+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.740+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.750+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.760+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.760+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.760+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.770+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.780+0900 I/AUL     ( 7683): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:14:28.780+0900 E/AUL     ( 7683): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:14:28.780+0900 E/AUL     ( 7683): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:14:28.970+0900 E/WEBKIT  ( 2026): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 16:14:30.500+0900 I/MALI    ( 2026): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x1eeda20] swap changed from async to sync
07-14 16:14:37.380+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 16:14:37.810+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 16:14:37.820+0900 I/AUL     ( 2077): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:14:37.820+0900 I/AUL     (  374): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 2077
07-14 16:14:37.830+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.850+0900 D/tdlnaservice( 7497): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 16:14:37.850+0900 I/tdlna   ( 7497): _on_proxy_client_msg_received_cb 실행
07-14 16:14:37.850+0900 I/tdlna   ( 7497): _app_process_received_message 실행
07-14 16:14:37.850+0900 I/tdlna   ( 7497): _app_execute_operation 실행
07-14 16:14:37.850+0900 I/tdlna   ( 7497): _app_send_response 실행
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.850+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:14:37.860+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.860+0900 D/tdlnaservice( 7497): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:14:37.890+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.910+0900 D/tdlnaservice( 7497): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 16:14:37.910+0900 I/tdlna   ( 7497): _on_proxy_client_msg_received_cb 실행
07-14 16:14:37.910+0900 I/tdlna   ( 7497): _app_process_received_message 실행
07-14 16:14:37.910+0900 I/tdlna   ( 7497): _app_execute_operation 실행
07-14 16:14:37.910+0900 D/tdlnaservice( 7497): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 16:14:37.910+0900 I/tdlna   ( 7497): _app_run_timer 실행
07-14 16:14:37.910+0900 I/tdlna   ( 7497): _app_run_timer 실행
07-14 16:14:37.910+0900 I/tdlna   ( 7497): _app_send_response 실행
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:14:37.910+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:37.910+0900 D/tdlnaservice( 7497): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:14:37.940+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:14:42.770+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:14:42.770+0900 D/tdlnaservice( 7497): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 16:14:42.770+0900 I/tdlna   ( 7497): _on_proxy_client_msg_received_cb 실행
07-14 16:14:42.770+0900 I/tdlna   ( 7497): _app_process_received_message 실행
07-14 16:14:42.770+0900 I/tdlna   ( 7497): test _ _app_process_received_message
07-14 16:14:42.770+0900 I/tdlna   ( 7497): _app_execute_operation 실행
07-14 16:14:42.770+0900 I/tdlna   ( 7497): test 실행
07-14 16:14:42.770+0900 I/tdlna   ( 7497): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 16:14:42.780+0900 I/tdlna   ( 7497): Main Start !!! 1
07-14 16:14:42.780+0900 I/tdlna   ( 7497): Service Start !!! 1
07-14 16:14:42.780+0900 I/tdlna   ( 7497): shttpl - 18
07-14 16:14:42.780+0900 I/tdlna   ( 7497): fork 전
07-14 16:14:42.780+0900 I/tdlna   ( 7497): Main precess Start !! 1
07-14 16:14:58.160+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 27
07-14 16:14:58.180+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 16:14:58.180+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(803) > app status : 5
07-14 16:14:58.190+0900 I/APP_CORE( 5737): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-14 16:14:58.190+0900 I/CAPI_APPFW_APPLICATION( 5737): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-14 16:14:58.260+0900 I/CAPI_NETWORK_CONNECTION( 5737): connection.c: connection_destroy(379) > Destroy handle: 0xb8e4e3d0
07-14 16:14:58.260+0900 I/CAPI_NETWORK_CONNECTION( 5737): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-14 16:14:58.270+0900 I/EFL-ASSIST( 5737): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8e022c0) is freed
07-14 16:14:58.270+0900 I/EFL-ASSIST( 5737): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b8df1a38) is freed
07-14 16:14:58.280+0900 E/TIZEN_N_SYSTEM_SETTINGS( 5737): system_settings_vconf.c: system_setting_vconf_unset_changed_cb(278) > [system_setting_vconf_unset_changed_cb] vconf_ignore_key_changed : db/setting/accessibility/font_size --- ret = 0 --- callback ptr : b4d29dfd
07-14 16:14:58.280+0900 I/CAPI_APPFW_APPLICATION( 5737): app_main.c: app_efl_exit(145) > app_efl_exit
07-14 16:14:58.280+0900 E/TBM_BACKEND( 5737): tbm_bufmgr_sprd7727.c: tbm_sprd7727_bo_free(671) > [31m[data-provider-slave][libtbm-sprd7727:5737] error tbm_sprd7727_bo_free:671
07-14 16:14:58.280+0900 E/TBM_BACKEND( 5737): [0m
07-14 16:14:58.320+0900 I/AUL_PAD (  466): sigchild.h: __launchpad_sig_child(142) > dead_pid = 5737 pgid = 5737
07-14 16:14:58.320+0900 I/AUL_PAD (  466): sigchild.h: __sigchild_action(123) > dead_pid(5737)
07-14 16:14:58.320+0900 I/AUL_PAD (  466): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-14 16:14:58.320+0900 I/AUL_PAD (  466): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-14 16:14:58.330+0900 I/AUL_AMD (  451): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 5737
07-14 16:14:58.330+0900 I/Tizen::System(  989): (246) > Terminated app [com.samsung.data-provider-slave]
07-14 16:14:58.330+0900 I/Tizen::Io(  989): (729) > Entry not found
07-14 16:14:58.330+0900 I/Tizen::App(  964): (243) > App[com.samsung.data-provider-slave] pid[5737] terminate event is forwarded
07-14 16:14:58.330+0900 I/Tizen::System(  964): (256) > osp.accessorymanager.service provider is found.
07-14 16:14:58.330+0900 I/Tizen::System(  964): (196) > Accessory Owner is removed [com.samsung.data-provider-slave, 5737, ]
07-14 16:14:58.330+0900 I/Tizen::System(  964): (256) > osp.system.service provider is found.
07-14 16:14:58.330+0900 I/Tizen::App(  964): (506) > TerminatedApp(com.samsung.data-provider-slave)
07-14 16:14:58.330+0900 I/Tizen::App(  964): (512) > Not registered pid(5737)
07-14 16:14:58.330+0900 I/Tizen::App(  964): (782) > Finished invoking application event listener for com.samsung.data-provider-slave, 5737.
07-14 16:14:58.340+0900 I/Tizen::System(  989): (157) > change brightness system value.
07-14 16:14:58.340+0900 I/Tizen::App(  989): (782) > Finished invoking application event listener for com.samsung.data-provider-slave, 5737.
07-14 16:14:59.990+0900 I/PowerManagerService-JNI( 1520): sending ACL screen state 'L'
07-14 16:15:00.000+0900 I/PowerManagerService-JNI( 1520): sending ACL screen state 'F'
07-14 16:15:00.010+0900 E/SurfaceFlinger( 1520): redraw failed: empty invalid region
07-14 16:15:00.010+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 16:15:00.010+0900 I/Tizen::Base::Runtime( 1085): (251) > The timer is not started.
07-14 16:15:00.010+0900 I/Tizen::System( 1085): (85) > Current Epoch is -5263563044937222412.
07-14 16:15:00.010+0900 I/Tizen::System( 1085): (89) > Calendar time is sec:0, min:15, hour:7, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 16:15:00.010+0900 I/Tizen::System( 1085): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 16:15:00.010+0900 I/Tizen::System( 1085): (103) > Original Time is 2015 7/14, 7:15:0:20
07-14 16:15:00.010+0900 I/Tizen::System( 1085): (123) > Current Time is 2015 7/14, 16:15:0
07-14 16:15:00.010+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 71099980 milliseconds from now
07-14 16:15:00.020+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(true)
07-14 16:15:00.020+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 16:15:00.020+0900 I/Tizen::System( 1085): (85) > Current Epoch is 1436858100.
07-14 16:15:00.020+0900 I/Tizen::System( 1085): (89) > Calendar time is sec:0, min:15, hour:7, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 16:15:00.020+0900 I/Tizen::System( 1085): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 16:15:00.020+0900 I/Tizen::System( 1085): (103) > Original Time is 2015 7/14, 7:15:0:29
07-14 16:15:00.020+0900 I/Tizen::System( 1085): (123) > Current Time is 2015 7/14, 16:15:0
07-14 16:15:00.020+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59971 milliseconds from now
07-14 16:15:00.030+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(false)
07-14 16:15:00.180+0900 W/AUL_AMD (  451): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 16:15:05.020+0900 W/ProcessStats( 1520): Skipping unknown process pid 7600
07-14 16:15:05.020+0900 W/ProcessStats( 1520): Skipping unknown process pid 7650
07-14 16:15:05.700+0900 W/CAM_APP ( 7600): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:15:12.250+0900 E/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 16:15:12.250+0900 E/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(7497) are closed. delete client info
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 16:15:12.250+0900 E/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  7497
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:15:12.250+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 16:15:12.260+0900 W/AUL_AMD (  451): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 16:15:12.260+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 7497
07-14 16:15:12.260+0900 W/AUL_AMD (  451): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 16:15:12.260+0900 I/AUL_AMD (  451): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 7497
07-14 16:15:12.260+0900 I/Tizen::System(  989): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 16:15:12.260+0900 I/Tizen::Io(  989): (729) > Entry not found
07-14 16:15:12.260+0900 I/Tizen::App(  964): (243) > App[org.tizen.tdlnaservice] pid[7497] terminate event is forwarded
07-14 16:15:12.260+0900 I/Tizen::System(  964): (256) > osp.accessorymanager.service provider is found.
07-14 16:15:12.260+0900 I/Tizen::System(  964): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 7497, ]
07-14 16:15:12.260+0900 I/Tizen::System(  964): (256) > osp.system.service provider is found.
07-14 16:15:12.260+0900 I/Tizen::App(  964): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 16:15:12.260+0900 I/Tizen::App(  964): (512) > Not registered pid(7497)
07-14 16:15:12.260+0900 I/Tizen::App(  964): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 7497.
07-14 16:15:12.280+0900 I/Tizen::System(  989): (157) > change brightness system value.
07-14 16:15:12.280+0900 I/Tizen::App(  989): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 7497.
07-14 16:15:12.330+0900 W/CRASH_MANAGER( 7923): worker.c: worker_job(1236) > 110749774646c143685811
