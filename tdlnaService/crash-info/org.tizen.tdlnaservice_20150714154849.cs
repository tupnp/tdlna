S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 4258
Date: 2015-07-14 15:48:49+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xd7d90000

Register Information
r0   = 0xd7d90002, r1   = 0xd7d90000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f576a6
r6   = 0xb5c73438, r7   = 0xd7d90002
r8   = 0x0000001e, r9   = 0xb5c746f0
r10  = 0xb6f57687, fp   = 0xb5c7342c
ip   = 0x00000000, sp   = 0xb5c72ec8
lr   = 0xb6dc25b8, pc   = 0xb6df5d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     19704 KB
Buffers:     28744 KB
Cached:     281844 KB
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
PID = 4258 TID = 4355
4258 4263 4355 

Maps Information
b5476000 b5c75000 rwxp [stack:4355]
b5c76000 b6479000 rwxp [stack:4263]
b6479000 b647c000 r-xp /lib/libgpg-error.so.0.5.0
b6483000 b6484000 rwxp /lib/libgpg-error.so.0.5.0
b6484000 b64dc000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64e3000 b64e6000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64e7000 b6513000 r-xp /usr/lib/libsystemd.so.0.0.1
b651a000 b651b000 r-xp /usr/lib/libsystemd.so.0.0.1
b651b000 b651c000 rwxp /usr/lib/libsystemd.so.0.0.1
b651c000 b651e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6525000 b6526000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6526000 b65f1000 r-xp /usr/lib/libxml2.so.2.7.8
b65f9000 b65fe000 rwxp /usr/lib/libxml2.so.2.7.8
b65ff000 b660f000 r-xp /lib/libresolv-2.13.so
b660f000 b6610000 r-xp /lib/libresolv-2.13.so
b6610000 b6611000 rwxp /lib/libresolv-2.13.so
b6614000 b662a000 r-xp /lib/libz.so.1.2.5
b6631000 b6632000 rwxp /lib/libz.so.1.2.5
b6632000 b6634000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b663b000 b663c000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b663c000 b6641000 r-xp /usr/lib/libffi.so.5.0.10
b6648000 b6649000 rwxp /usr/lib/libffi.so.5.0.10
b6649000 b664a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6651000 b6652000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6652000 b66b7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66be000 b66c1000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66c2000 b66c5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66cc000 b66cd000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66cd000 b6875000 r-xp /usr/lib/libcrypto.so.1.0.0
b687c000 b6891000 rwxp /usr/lib/libcrypto.so.1.0.0
b6895000 b68ab000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68b2000 b68b3000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b68b3000 b68e7000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68ee000 b68f0000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68f0000 b69c4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69cc000 b69cf000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69d1000 b69d5000 r-xp /usr/lib/libchromium.so.1.0
b69dc000 b69dd000 rwxp /usr/lib/libchromium.so.1.0
b69dd000 b6a46000 r-xp /lib/libm-2.13.so
b6a4d000 b6a4e000 r-xp /lib/libm-2.13.so
b6a4e000 b6a4f000 rwxp /lib/libm-2.13.so
b6a4f000 b6a55000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a5c000 b6a5d000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a5d000 b6a7c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a83000 b6a84000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a84000 b6a87000 r-xp /usr/lib/libsmack.so.1.0.0
b6a8e000 b6a8f000 rwxp /usr/lib/libsmack.so.1.0.0
b6a8f000 b6a94000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a9c000 b6a9d000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a9d000 b6ac7000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6acf000 b6ad0000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6ad0000 b6ae7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6aef000 b6af0000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6af0000 b6b84000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b8c000 b6b8f000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b8f000 b6b91000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b97000 b6ba2000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6ba9000 b6baa000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6baa000 b6baf000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6bb7000 b6bb8000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6bb8000 b6c88000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c88000 b6c89000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c89000 b6cc9000 r-xp /usr/lib/libeina.so.1.7.99
b6cd0000 b6cd1000 rwxp /usr/lib/libeina.so.1.7.99
b6cd2000 b6ce8000 r-xp /usr/lib/libecore.so.1.7.99
b6cef000 b6cf0000 rwxp /usr/lib/libecore.so.1.7.99
b6cfe000 b6d05000 r-xp /usr/lib/libvconf.so.0.2.45
b6d0d000 b6d0e000 rwxp /usr/lib/libvconf.so.0.2.45
b6d0e000 b6d13000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d1a000 b6d1b000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d1b000 b6d26000 r-xp /usr/lib/libaul.so.0.1.0
b6d2e000 b6d2f000 rwxp /usr/lib/libaul.so.0.1.0
b6d30000 b6d38000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d3f000 b6d40000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d40000 b6d42000 r-xp /lib/libdl-2.13.so
b6d49000 b6d4a000 r-xp /lib/libdl-2.13.so
b6d4a000 b6d4b000 rwxp /lib/libdl-2.13.so
b6d4b000 b6d56000 r-xp /lib/libunwind.so.8.0.1
b6d5d000 b6d5e000 rwxp /lib/libunwind.so.8.0.1
b6d83000 b6e9e000 r-xp /lib/libc-2.13.so
b6ea6000 b6ea8000 r-xp /lib/libc-2.13.so
b6ea8000 b6ea9000 rwxp /lib/libc-2.13.so
b6eac000 b6eb2000 r-xp /lib/librt-2.13.so
b6eb9000 b6eba000 r-xp /lib/librt-2.13.so
b6eba000 b6ebb000 rwxp /lib/librt-2.13.so
b6ebb000 b6ebd000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec4000 b6ec5000 rwxp /usr/lib/libdlog.so.0.0.0
b6ec5000 b6ec8000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ecf000 b6ed0000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ed0000 b6ed3000 r-xp /usr/lib/libbundle.so.0.1.22
b6eda000 b6edb000 rwxp /usr/lib/libbundle.so.0.1.22
b6edb000 b6ede000 r-xp /usr/lib/libappcore-agent.so.1.1
b6ee5000 b6ee6000 rwxp /usr/lib/libappcore-agent.so.1.1
b6ee6000 b6efa000 r-xp /lib/libpthread-2.13.so
b6f01000 b6f02000 r-xp /lib/libpthread-2.13.so
b6f02000 b6f03000 rwxp /lib/libpthread-2.13.so
b6f1a000 b6f1e000 r-xp /usr/lib/libsys-assert.so
b6f26000 b6f27000 rwxp /usr/lib/libsys-assert.so
b6f27000 b6f44000 r-xp /lib/ld-2.13.so
b6f4b000 b6f4c000 r-xp /lib/ld-2.13.so
b6f4c000 b6f4d000 rwxp /lib/ld-2.13.so
b6f4d000 b6f5a000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f61000 b6f63000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7ec6000 b7f0b000 rwxp [heap]
becbd000 becde000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4258)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6df5d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6dc25b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e5ab88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ebc063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x43c (0xb6f52129) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5129
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
) > InstallationInProgress [100]
07-14 15:48:26.260+0900 I/Tizen::App( 1049): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-14 15:48:26.260+0900 I/Tizen::App( 1049): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 15:48:26.260+0900 I/Tizen::App( 1049): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:48:26.270+0900 I/Tizen::App(  938): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 15:48:26.270+0900 I/Tizen::App(  938): (119) > InstallationInProgress [100]
07-14 15:48:26.270+0900 I/Tizen::App(  938): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-14 15:48:26.270+0900 I/Tizen::App(  938): (119) > InstallationInProgress [100]
07-14 15:48:26.270+0900 I/Tizen::App(  938): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-14 15:48:26.270+0900 I/Tizen::App(  938): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 15:48:26.270+0900 I/Tizen::App(  938): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:48:26.270+0900 I/Tizen::App(  938): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-14 15:48:26.270+0900 E/PKGMGR_INFO( 4166): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-14 15:48:26.270+0900 E/PKGMGR_INSTALLER( 4166): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-14 15:48:26.280+0900 I/Tizen::App(  965): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-14 15:48:26.280+0900 I/Tizen::App(  965): (119) > InstallationInProgress [100]
07-14 15:48:26.280+0900 I/Tizen::App(  965): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-14 15:48:26.280+0900 I/Tizen::App(  965): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-14 15:48:26.280+0900 I/Tizen::App(  965): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:48:26.280+0900 I/Tizen::App(  965): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 15:48:26.280+0900 I/Tizen::App(  938): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 15:48:26.290+0900 E/cluster-home(  600): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-14 15:48:26.290+0900 E/cluster-home(  600): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-14 15:48:26.290+0900 E/cluster-home(  600): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-14 15:48:26.300+0900 I/Tizen::App( 1049): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 15:48:26.320+0900 I/Tizen::App( 1049): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-14 15:48:26.330+0900 I/Tizen::App( 1049): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-14 15:48:26.330+0900 I/Tizen::App( 1049): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 15:48:26.340+0900 I/Tizen::App(  938): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-14 15:48:26.350+0900 I/Tizen::App(  938): (416) > appName = [tdlnaservice]
07-14 15:48:26.350+0900 I/Tizen::App(  938): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 15:48:26.350+0900 E/PKGMGR_INFO(  938): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-14 15:48:26.350+0900 I/Tizen::App(  938): (675) > Application count(1) in this package
07-14 15:48:26.350+0900 I/Tizen::App(  938): (855) > Enter.
07-14 15:48:26.360+0900 I/Tizen::App(  938): (695) > Exit.
07-14 15:48:26.360+0900 I/Tizen::App(  938): (416) > appName = [tdlnaservice]
07-14 15:48:26.360+0900 I/Tizen::App(  938): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-14 15:48:26.370+0900 I/Tizen::App(  938): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-14 15:48:26.370+0900 I/Tizen::App(  938): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-14 15:48:26.370+0900 I/Tizen::App(  938): (131) > Enter
07-14 15:48:26.370+0900 I/Tizen::App(  938): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-14 15:48:26.370+0900 I/Tizen::App(  938): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-14 15:48:26.370+0900 I/Tizen::App(  938): (137) > org.tizen.tdlnaservice does not have launch condition
07-14 15:48:26.370+0900 I/Tizen::App(  938): (898) > Exit.
07-14 15:48:26.860+0900 W/AUL_AMD (  452): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-14 15:48:26.860+0900 W/AUL_AMD (  452): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
07-14 15:48:26.940+0900 I/CAPI_APPFW_APPLICATION( 4175): app_main.c: ui_app_main(699) > app_efl_main
07-14 15:48:26.990+0900 I/UXT     ( 4175): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:48:27.030+0900 I/CAPI_APPFW_APPLICATION( 4175): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
07-14 15:48:27.060+0900 I/EFL-ASSIST( 4175): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b78a58c8) from (/usr/share/themes/FontInfoTable.xml) is created
07-14 15:48:27.060+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4175): system_settings.c: system_settings_set_changed_cb(541) > b4cc31fd
07-14 15:48:27.060+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4175): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_size --- callback ptr : b4cc1dfd
07-14 15:48:27.060+0900 E/EFL     ( 4175): evas_main<4175> evas_font_dir.c:1515 evas_font_reinit() ENTER:: evas_font_reinit
07-14 15:48:27.080+0900 E/EFL     ( 4175): evas_main<4175> evas_font_dir.c:1526 evas_font_reinit() DONE:: evas_font_reinit
07-14 15:48:27.100+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b78b61d8) from (/opt/usr/share/data-provider-slave/theme/color/com.samsung.data-provider-slave_ChangeableColorInfo.xml) is created
07-14 15:48:27.100+0900 E/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_colors_set(868) > cannot get color table data
07-14 15:48:27.100+0900 I/CAPI_APPFW_APPLICATION( 4175): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
07-14 15:48:27.120+0900 I/APP_CORE( 4175): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 15:48:27.120+0900 I/APP_CORE( 4175): appcore-efl.c: __do_app(511) > [APP 4175] Initial Launching, call the resume_cb
07-14 15:48:27.120+0900 I/CAPI_APPFW_APPLICATION( 4175): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
07-14 15:48:27.290+0900 W/LIVE-GALLERY( 4175): glb-main.c: dynamicbox_resize(1485) > [32mw: 470, h: 470[0m
07-14 15:48:27.300+0900 W/LIVE-GALLERY( 4175): glb-main.c: dynamicbox_need_to_update(1005) > [32mperiod: 10;  content_type: default:1:29; new_content : default:1:29; update_now 0 [0m
07-14 15:48:27.300+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_connect(854) > [32m[4175]ref count : 0
07-14 15:48:27.300+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_connect(886) > [32m[4175]ref count changed to: 1
07-14 15:48:27.310+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[3]
07-14 15:48:27.310+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[3]
07-14 15:48:27.330+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[3]
07-14 15:48:27.340+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_disconnect(942) > [32m[4175]ref count changed to: 0
07-14 15:48:27.340+0900 W/LIVE-GALLERY( 4175): glb-main.c: dynamicbox_update_content(1189) > [32mType: default, position: 1, need_update: 1, need_resize: 1[0m
07-14 15:48:27.340+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_connect(854) > [32m[4175]ref count : 0
07-14 15:48:27.340+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_connect(886) > [32m[4175]ref count changed to: 1
07-14 15:48:27.340+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[3]
07-14 15:48:27.340+0900 E/cluster-home(  600): cluster-data-provider.cpp: EventPixmapAcquired(2075) >  Release depreacted pixmap [23068680]
07-14 15:48:27.370+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_disconnect(942) > [32m[4175]ref count changed to: 0
07-14 15:48:27.370+0900 E/LIVE-GALLERY( 4175): glb-main.c: __dynamicbox_create_item_layout_default(445) > [31mb_selecte_img 0[0m
07-14 15:48:27.370+0900 E/LIVE-GALLERY( 4175): glb-main.c: __dynamicbox_create_item_layout_default(472) > [31mlayout_media_count: 3, media count: 5, layout id: 1[0m
07-14 15:48:27.370+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_connect(854) > [32m[4175]ref count : 0
07-14 15:48:27.370+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_connect(886) > [32m[4175]ref count changed to: 1
07-14 15:48:27.410+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 4175): media_content.c: media_content_disconnect(942) > [32m[4175]ref count changed to: 0
07-14 15:48:27.410+0900 W/LIVE-GALLERY( 4175): glb-ui-util.c: _glb_ui_util_create_card_layout(275) > [32mGroup = [card_1][0m
07-14 15:48:27.410+0900 W/LIVE-GALLERY( 4175): glb-ui-util.c: _glb_ui_util_create_card_layout(276) > [32mwidth height = [470 470][0m
07-14 15:48:27.450+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b78b6340) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.450+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b78b6340) is freed
07-14 15:48:27.460+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b78b63a0) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.470+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b78b63a0) is freed
07-14 15:48:27.470+0900 I/EFL-ASSIST( 4175): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b78f2158]
07-14 15:48:27.480+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b78b63b8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.480+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b78b63b8) is freed
07-14 15:48:27.490+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b78b63b8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.490+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b78b63b8) is freed
07-14 15:48:27.490+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b78b63a0) from (/usr/apps/com.samsung.gallery-lite/res/script/tables/com.samsung.gallery-lite.dbox_ChangeableColorInfo.xml) is created
07-14 15:48:27.500+0900 I/EFL-ASSIST( 4175): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b7920600) from (/usr/apps/com.samsung.gallery-lite/res/script/tables/com.samsung.gallery-lite.dbox_ChangeableFontInfo.xml) is created
07-14 15:48:27.520+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7920360) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.520+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b7920360) is freed
07-14 15:48:27.550+0900 E/EFL     ( 4175): evas_main<4175> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 15:48:27.550+0900 E/EFL     ( 4175): evas_main<4175> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 15:48:27.570+0900 E/EFL     ( 4175): edje<4175> edje_util.c:3618 edje_object_size_min_restricted_calc() group card_1 has a non-fixed part 'setting_btn'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 15:48:27.570+0900 E/EFL     ( 4175): edje<4175> edje_util.c:3618 edje_object_size_min_restricted_calc() group card_1 has a non-fixed part 'setting_btn'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 15:48:27.630+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[3]
07-14 15:48:27.680+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b793e5f0) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.690+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b793e5f0) is freed
07-14 15:48:27.700+0900 E/PKGMGR_SERVER( 4164): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-14 15:48:27.700+0900 E/PKGMGR_SERVER( 4164): pkgmgr-server.c: main(1704) > package manager server terminated.
07-14 15:48:27.700+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b793db58) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:27.700+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b793db58) is freed
07-14 15:48:27.730+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b793e5f0) from (/usr/apps/com.samsung.browser/shared/res/tables/com.samsung.browser_dbox_changeable_color.xml) is created
07-14 15:48:27.770+0900 I/EFL-ASSIST( 4175): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b79b5230) from (/usr/apps/com.samsung.browser/shared/res/tables/com.samsung.browser_dbox_changeable_font.xml) is created
07-14 15:48:27.980+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_object_color_replace(1463) > obj: b79748a8 (elm_gengrid), color code replace: (B018 -> AO007), new color [0, 0, 0, 12]
07-14 15:48:27.980+0900 I/EFL-ASSIST( 4175): efl_assist_theme_color.cpp: ea_theme_object_color_replace(1463) > obj: b79748a8 (elm_gengrid), color code replace: (B071 -> AO011), new color [255, 255, 255, 76]
07-14 15:48:28.160+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:28.190+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:28.200+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:28.810+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 0
07-14 15:48:28.820+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-14 15:48:28.820+0900 I/AUL     (  452): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-14 15:48:28.820+0900 E/AUL_AMD (  452): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-14 15:48:28.840+0900 W/AUL_AMD (  452): amd_launch.c: service_start(515) > child process: 4258
07-14 15:48:28.950+0900 W/AUL_AMD (  452): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 4258
07-14 15:48:28.970+0900 I/Tizen::App(  938): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 15:48:28.970+0900 I/Tizen::App(  938): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 4258.
07-14 15:48:28.970+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 4258.
07-14 15:48:29.030+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.040+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.070+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.080+0900 I/tdlna   ( 4258): _on_create_cb 실행
07-14 15:48:29.080+0900 I/tdlna   ( 4258): _app_init 실행
07-14 15:48:29.080+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.080+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:48:29.090+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.100+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:48:29.100+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:48:29.110+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 4258
07-14 15:48:29.120+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:29.120+0900 D/tdlnaservice( 4258): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 15:48:29.120+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.130+0900 I/tdlna   ( 4258): _on_app_control_callback 실행
07-14 15:48:29.130+0900 I/tdlna   ( 4258): _app_timer_thread_func 실행
07-14 15:48:29.140+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.160+0900 W/test-log(  600): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:48:29.160+0900 W/test-log(  600): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:48:29.160+0900 W/test-log(  600): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:48:29.160+0900 W/test-log(  600): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:48:29.160+0900 W/test-log(  600): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
07-14 15:48:29.170+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.190+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.190+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.200+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.220+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:29.240+0900 E/cluster-home(  600): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 15:48:30.050+0900 W/cluster-view(  600): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 15:48:30.980+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 15:48:31.070+0900 E/RESOURCED(  755): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
07-14 15:48:31.070+0900 E/RESOURCED(  755): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 352
07-14 15:48:31.080+0900 I/Tizen::App(  938): (499) > LaunchedApp(rMfxc1AKe2.tdlnaWeb)
07-14 15:48:31.080+0900 I/Tizen::App(  938): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 4268.
07-14 15:48:31.090+0900 I/Tizen::App(  965): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 4268.
07-14 15:48:31.190+0900 I/UXT     ( 4274): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:48:31.220+0900 I/EFL-ASSIST( 4274): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e78590) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:31.220+0900 I/EFL-ASSIST( 4274): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e78590) is freed
07-14 15:48:31.230+0900 I/EFL-ASSIST( 4274): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e78590) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:31.230+0900 I/EFL-ASSIST( 4274): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e78590) is freed
07-14 15:48:31.250+0900 I/UXT     ( 4268): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:48:31.290+0900 E/PKGMGR_INFO( 4268): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 15:48:31.290+0900 I/APP_CORE( 4268): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 15:48:31.290+0900 I/APP_CORE( 4268): appcore-efl.c: __do_app(511) > [APP 4268] Initial Launching, call the resume_cb
07-14 15:48:31.420+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 15:48:31.420+0900 W/AUL_AMD (  452): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 15:48:31.420+0900 W/AUL_AMD (  452): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 15:48:31.480+0900 I/AUL     ( 4274): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:48:31.490+0900 E/EFL     ( 4268): elementary<4268> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x1f70450 as sub object of 0x1f70190
07-14 15:48:31.510+0900 E/WEBKIT  ( 4268): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 15:48:31.550+0900 I/CAPI_NETWORK_CONNECTION( 4268): connection.c: connection_create(363) > New handle created[0xb090e188]
07-14 15:48:31.550+0900 I/CAPI_NETWORK_CONNECTION( 4268): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 15:48:31.550+0900 I/CAPI_NETWORK_CONNECTION( 4268): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 15:48:31.550+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4268): system_settings.c: system_settings_set_changed_cb(541) > b3e842b1
07-14 15:48:31.550+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4268): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3e82d99
07-14 15:48:31.570+0900 I/EFL-ASSIST( 4268): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [1ec2860]
07-14 15:48:31.580+0900 I/EFL-ASSIST( 4268): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e6bc18) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:31.580+0900 I/EFL-ASSIST( 4268): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e6bc18) is freed
07-14 15:48:31.670+0900 E/EFL     ( 4274): edje<4274> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 15:48:31.730+0900 E/EFL     ( 4268): evas_main<4268> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 15:48:31.750+0900 E/EFL     ( 4268): evas_main<4268> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 15:48:31.850+0900 W/PROCESSMGR(  374): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4268
07-14 15:48:31.890+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:48:31.900+0900 W/APP_CORE( 4268): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00003
07-14 15:48:31.920+0900 I/MALI    (  600): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb7972918] swap changed from sync to async
07-14 15:48:31.930+0900 I/indicator(  482): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 4268"
07-14 15:48:31.950+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:48:31.970+0900 I/Tizen::System( 1049): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:48:31.970+0900 I/Tizen::System(  965): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 15:48:31.970+0900 I/Tizen::Io(  965): (729) > Entry not found
07-14 15:48:31.990+0900 I/Tizen::System(  965): (157) > change brightness system value.
07-14 15:48:32.000+0900 I/CAPI_APPFW_APPLICATION(  600): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 15:48:32.000+0900 E/cluster-home(  600): homescreen-main.cpp: app_pause(355) >  app pause
07-14 15:48:32.190+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.200+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.200+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.200+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.210+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.220+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.220+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.220+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.230+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.240+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.240+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.240+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.250+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.260+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.260+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.260+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.270+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.280+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.280+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.280+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.290+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.300+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.300+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.300+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.310+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.320+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.320+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.320+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.330+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.340+0900 I/AUL     ( 4271): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 15:48:32.340+0900 E/AUL     ( 4271): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 15:48:32.340+0900 E/AUL     ( 4271): aul_path.c: __get_path(170) > root_path is NULL!
07-14 15:48:32.400+0900 I/UXT     ( 4295): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 15:48:32.440+0900 I/EFL-ASSIST( 4295): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e68298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:32.440+0900 I/EFL-ASSIST( 4295): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e68298) is freed
07-14 15:48:32.450+0900 I/EFL-ASSIST( 4295): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1e68298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 15:48:32.450+0900 I/EFL-ASSIST( 4295): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1e68298) is freed
07-14 15:48:33.070+0900 E/WEBKIT  ( 4268): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 15:48:34.370+0900 I/MALI    ( 4268): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x1eeeb98] swap changed from async to sync
07-14 15:48:37.980+0900 W/AUL_AMD (  452): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 15:48:38.140+0900 E/PKGMGR_INFO( 4274): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 15:48:38.410+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:48:38.420+0900 I/AUL     ( 4274): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:48:38.420+0900 I/AUL     (  387): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 4274
07-14 15:48:38.430+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:38.450+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.460+0900 D/tdlnaservice( 4258): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:48:38.460+0900 I/tdlna   ( 4258): _on_proxy_client_msg_received_cb 실행
07-14 15:48:38.460+0900 I/tdlna   ( 4258): _app_process_received_message 실행
07-14 15:48:38.460+0900 I/tdlna   ( 4258): _app_execute_operation 실행
07-14 15:48:38.460+0900 I/tdlna   ( 4258): _app_send_response 실행
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:48:38.460+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.460+0900 D/tdlnaservice( 4258): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:38.490+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.510+0900 D/tdlnaservice( 4258): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:48:38.510+0900 I/tdlna   ( 4258): _on_proxy_client_msg_received_cb 실행
07-14 15:48:38.510+0900 I/tdlna   ( 4258): _app_process_received_message 실행
07-14 15:48:38.510+0900 I/tdlna   ( 4258): _app_execute_operation 실행
07-14 15:48:38.510+0900 D/tdlnaservice( 4258): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 15:48:38.510+0900 I/tdlna   ( 4258): _app_run_timer 실행
07-14 15:48:38.510+0900 I/tdlna   ( 4258): _app_run_timer 실행
07-14 15:48:38.510+0900 I/tdlna   ( 4258): _app_send_response 실행
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:48:38.510+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:38.510+0900 D/tdlnaservice( 4258): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:38.530+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:49.320+0900 D/tdlnaservice( 4258): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:48:49.320+0900 I/tdlna   ( 4258): _on_proxy_client_msg_received_cb 실행
07-14 15:48:49.320+0900 I/tdlna   ( 4258): _app_process_received_message 실행
07-14 15:48:49.320+0900 I/tdlna   ( 4258): test _ _app_process_received_message
07-14 15:48:49.320+0900 I/tdlna   ( 4258): _app_execute_operation 실행
07-14 15:48:49.320+0900 I/tdlna   ( 4258): test 실행
07-14 15:48:49.320+0900 I/tdlna   ( 4258): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:48:49.320+0900 I/tdlna   ( 4258): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:48:49.320+0900 I/tdlna   ( 4258): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:48:49.320+0900 I/tdlna   ( 4258): _app_send_response 실행
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:48:49.320+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:49.330+0900 I/tdlna   ( 4258): Main Start !!! 1
07-14 15:48:49.330+0900 I/tdlna   ( 4258): Service Start !!! 1
07-14 15:48:49.330+0900 I/tdlna   ( 4258): shttpl - 18
07-14 15:48:49.330+0900 I/tdlna   ( 4258): fork 전
07-14 15:48:49.330+0900 I/tdlna   ( 4258): Main precess Start !! 4356
07-14 15:48:49.330+0900 I/tdlna   ( 4356): fork child process 1
07-14 15:48:49.330+0900 I/tdlna   ( 4356): ssdp running
07-14 15:48:49.330+0900 D/tdlnaservice( 4258): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:48:49.350+0900 I/MESSAGE_PORT(  387): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:48:49.890+0900 W/CRASH_MANAGER( 4358): worker.c: worker_job(1236) > 110425874646c143685652
