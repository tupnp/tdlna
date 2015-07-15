S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 27022
Date: 2015-07-13 23:07:57+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x5cf00000

Register Information
r0   = 0x5cf00002, r1   = 0x5cf00000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6fb9406
r6   = 0xbef5e840, r7   = 0x5cf00002
r8   = 0x00000017, r9   = 0xb64d84d0
r10  = 0xb6fb93ee, fp   = 0xbef5e834
ip   = 0x00000000, sp   = 0xbef5e2d0
lr   = 0xb6e245b8, pc   = 0xb6e57d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     23612 KB
Buffers:     21304 KB
Cached:     183632 KB
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
PID = 27022 TID = 27022
27022 27025 

Maps Information
b5cd8000 b64db000 rwxp [stack:27025]
b64db000 b64de000 r-xp /lib/libgpg-error.so.0.5.0
b64e5000 b64e6000 rwxp /lib/libgpg-error.so.0.5.0
b64e6000 b653e000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6545000 b6548000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6549000 b6575000 r-xp /usr/lib/libsystemd.so.0.0.1
b657c000 b657d000 r-xp /usr/lib/libsystemd.so.0.0.1
b657d000 b657e000 rwxp /usr/lib/libsystemd.so.0.0.1
b657e000 b6580000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6587000 b6588000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6588000 b6653000 r-xp /usr/lib/libxml2.so.2.7.8
b665b000 b6660000 rwxp /usr/lib/libxml2.so.2.7.8
b6661000 b6671000 r-xp /lib/libresolv-2.13.so
b6671000 b6672000 r-xp /lib/libresolv-2.13.so
b6672000 b6673000 rwxp /lib/libresolv-2.13.so
b6676000 b668c000 r-xp /lib/libz.so.1.2.5
b6693000 b6694000 rwxp /lib/libz.so.1.2.5
b6694000 b6696000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b669d000 b669e000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b669e000 b66a3000 r-xp /usr/lib/libffi.so.5.0.10
b66aa000 b66ab000 rwxp /usr/lib/libffi.so.5.0.10
b66ab000 b66ac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66b3000 b66b4000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66b4000 b6719000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6720000 b6723000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6724000 b6727000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b672e000 b672f000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b672f000 b68d7000 r-xp /usr/lib/libcrypto.so.1.0.0
b68de000 b68f3000 rwxp /usr/lib/libcrypto.so.1.0.0
b68f7000 b690d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6914000 b6915000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6915000 b6949000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6950000 b6952000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6952000 b6a26000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a2e000 b6a31000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a33000 b6a37000 r-xp /usr/lib/libchromium.so.1.0
b6a3e000 b6a3f000 rwxp /usr/lib/libchromium.so.1.0
b6a3f000 b6aa8000 r-xp /lib/libm-2.13.so
b6aaf000 b6ab0000 r-xp /lib/libm-2.13.so
b6ab0000 b6ab1000 rwxp /lib/libm-2.13.so
b6ab1000 b6ab7000 r-xp /usr/lib/libappsvc.so.0.1.0
b6abe000 b6abf000 rwxp /usr/lib/libappsvc.so.0.1.0
b6abf000 b6ade000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ae5000 b6ae6000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6ae6000 b6ae9000 r-xp /usr/lib/libsmack.so.1.0.0
b6af0000 b6af1000 rwxp /usr/lib/libsmack.so.1.0.0
b6af1000 b6af6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6afe000 b6aff000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6aff000 b6b29000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b31000 b6b32000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b32000 b6b49000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b51000 b6b52000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b52000 b6be6000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bee000 b6bf1000 r-xp /usr/lib/libstdc++.so.6.0.16
b6bf1000 b6bf3000 rwxp /usr/lib/libstdc++.so.6.0.16
b6bf9000 b6c04000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c0b000 b6c0c000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c0c000 b6c11000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c19000 b6c1a000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c1a000 b6cea000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6cea000 b6ceb000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6ceb000 b6d2b000 r-xp /usr/lib/libeina.so.1.7.99
b6d32000 b6d33000 rwxp /usr/lib/libeina.so.1.7.99
b6d34000 b6d4a000 r-xp /usr/lib/libecore.so.1.7.99
b6d51000 b6d52000 rwxp /usr/lib/libecore.so.1.7.99
b6d60000 b6d67000 r-xp /usr/lib/libvconf.so.0.2.45
b6d6f000 b6d70000 rwxp /usr/lib/libvconf.so.0.2.45
b6d70000 b6d75000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d7c000 b6d7d000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d7d000 b6d88000 r-xp /usr/lib/libaul.so.0.1.0
b6d90000 b6d91000 rwxp /usr/lib/libaul.so.0.1.0
b6d92000 b6d9a000 r-xp /lib/libgcc_s-4.6.4.so.1
b6da1000 b6da2000 rwxp /lib/libgcc_s-4.6.4.so.1
b6da2000 b6da4000 r-xp /lib/libdl-2.13.so
b6dab000 b6dac000 r-xp /lib/libdl-2.13.so
b6dac000 b6dad000 rwxp /lib/libdl-2.13.so
b6dad000 b6db8000 r-xp /lib/libunwind.so.8.0.1
b6dbf000 b6dc0000 rwxp /lib/libunwind.so.8.0.1
b6de5000 b6f00000 r-xp /lib/libc-2.13.so
b6f08000 b6f0a000 r-xp /lib/libc-2.13.so
b6f0a000 b6f0b000 rwxp /lib/libc-2.13.so
b6f0e000 b6f14000 r-xp /lib/librt-2.13.so
b6f1b000 b6f1c000 r-xp /lib/librt-2.13.so
b6f1c000 b6f1d000 rwxp /lib/librt-2.13.so
b6f1d000 b6f1f000 r-xp /usr/lib/libdlog.so.0.0.0
b6f26000 b6f27000 rwxp /usr/lib/libdlog.so.0.0.0
b6f27000 b6f2a000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f31000 b6f32000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f32000 b6f35000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3c000 b6f3d000 rwxp /usr/lib/libbundle.so.0.1.22
b6f3d000 b6f40000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f47000 b6f48000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f48000 b6f5c000 r-xp /lib/libpthread-2.13.so
b6f63000 b6f64000 r-xp /lib/libpthread-2.13.so
b6f64000 b6f65000 rwxp /lib/libpthread-2.13.so
b6f7c000 b6f80000 r-xp /usr/lib/libsys-assert.so
b6f88000 b6f89000 rwxp /usr/lib/libsys-assert.so
b6f89000 b6fa6000 r-xp /lib/ld-2.13.so
b6fad000 b6fae000 r-xp /lib/ld-2.13.so
b6fae000 b6faf000 rwxp /lib/ld-2.13.so
b6faf000 b6fbb000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fc3000 b6fc5000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b75f6000 b763b000 rwxp [heap]
bef3f000 bef60000 rwxp [stack]
End of Maps Information

Callstack Information (PID:27022)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e57d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e245b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6ebcb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f1e063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3ca (0xb6fb405f) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x505f
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
licy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.tdlnaservice.xml]
07-13 23:06:31.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:06:31.970+0900 E/rpm-installer(26909): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.tdlnaservice/shared/data]))
07-13 23:06:32.600+0900 E/PKGMGR_SERVER(26907): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:06:34.270+0900 I/Tizen::App( 1103): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:06:34.270+0900 I/Tizen::App( 1103): (119) > InstallationInProgress [100]
07-13 23:06:34.270+0900 I/Tizen::App( 1103): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:06:34.270+0900 I/Tizen::App( 1033): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:06:34.270+0900 I/Tizen::App( 1033): (119) > InstallationInProgress [100]
07-13 23:06:34.270+0900 I/Tizen::App( 1033): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-13 23:06:34.270+0900 I/Tizen::App( 1033): (119) > InstallationInProgress [100]
07-13 23:06:34.270+0900 I/Tizen::App( 1033): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [96]
07-13 23:06:34.280+0900 I/Tizen::App( 1103): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:06:34.280+0900 I/Tizen::App( 1103): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:06:34.280+0900 I/Tizen::App( 1103): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-13 23:06:34.280+0900 I/Tizen::App( 1033): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:06:34.280+0900 I/Tizen::App( 1033): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:06:34.280+0900 I/Tizen::App( 1033): (663) > Enter. package(org.tizen.tdlnaservice), installationResult(0)
07-13 23:06:34.290+0900 E/cluster-home(  602): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
07-13 23:06:34.290+0900 E/cluster-home(  602): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
07-13 23:06:34.290+0900 E/cluster-home(  602): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
07-13 23:06:34.300+0900 E/PKGMGR_INFO(26909): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
07-13 23:06:34.320+0900 E/PKGMGR_INSTALLER(26909): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
07-13 23:06:34.350+0900 I/Tizen::App( 1033): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:06:34.360+0900 I/Tizen::App( 1033): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.tdlnaservice]
07-13 23:06:34.370+0900 W/MYFILES ( 7394): mf-download-apps-view.c: mf_download_app_pkgmgr_changed_cb(200) > [31m[ mf_download_app_pkgmgr_changed_cb : 200]   ap->mf_Status.view_type is [1][0m
07-13 23:06:34.370+0900 W/MYFILES ( 7394): mf-download-apps-view.c: mf_download_app_pkgmgr_changed_cb(200) > [31m[ mf_download_app_pkgmgr_changed_cb : 200]   ap->mf_Status.view_type is [1][0m
07-13 23:06:34.390+0900 E/cluster-home(  602): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(241) >  this package is no display
07-13 23:06:34.390+0900 E/cluster-home(  602): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
07-13 23:06:34.390+0900 E/cluster-home(  602): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[0]
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (416) > appName = [tdlnaservice]
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-13 23:06:34.420+0900 E/PKGMGR_INFO( 1033): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (675) > Application count(1) in this package
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (855) > Enter.
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (695) > Exit.
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:06:34.420+0900 I/Tizen::App( 1033): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [96]
07-13 23:06:34.430+0900 I/Tizen::App( 1151): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: install_percent, val: 100
07-13 23:06:34.430+0900 I/Tizen::App( 1151): (119) > InstallationInProgress [100]
07-13 23:06:34.430+0900 I/Tizen::App( 1151): (1584) > Package = [org.tizen.tdlnaservice], Key = [install_percent], Value = [100], install = [1]
07-13 23:06:34.430+0900 I/Tizen::App( 1151): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.tdlnaservice, key: end, val: ok
07-13 23:06:34.430+0900 I/Tizen::App( 1151): (78) > Installation is Completed. [Package = org.tizen.tdlnaservice]
07-13 23:06:34.440+0900 I/Tizen::App( 1033): (416) > appName = [tdlnaservice]
07-13 23:06:34.440+0900 I/Tizen::App( 1033): (509) > exe = [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice], displayName = [tdlnaservice], mainApp = [1], menuIconVisible = [1], serviceApp = [1]
07-13 23:06:34.440+0900 I/Tizen::App( 1033): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.tdlnaservice.info]
07-13 23:06:34.440+0900 I/Tizen::App( 1033): (131) > Enter
07-13 23:06:34.440+0900 I/Tizen::App( 1033): (137) > org.tizen.tdlnaservice does not have launch condition
07-13 23:06:34.440+0900 I/Tizen::App( 1033): (898) > Exit.
07-13 23:06:34.450+0900 I/Tizen::App( 1151): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:06:34.460+0900 I/Tizen::App( 1151): (149) > app = [org.tizen.tdlnaservice], package = [org.tizen.tdlnaservice]
07-13 23:06:34.520+0900 I/Tizen::App( 1151): (1360) > package(org.tizen.tdlnaservice), version(1.0.0), type(rpm), displayName(tdlnaservice), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(0), externalStorage(0), mainApp(org.tizen.tdlnaservice), storeClient(), appRootPath(/opt/usr/apps/org.tizen.tdlnaservice)
07-13 23:06:34.520+0900 I/Tizen::App( 1151): (1584) > Package = [org.tizen.tdlnaservice], Key = [end], Value = [ok], install = [1]
07-13 23:06:34.540+0900 E/PKGMGR_GETSIZE(26928): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.tdlnaservice_984919180
07-13 23:06:34.600+0900 E/PKGMGR_SERVER(26907): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:06:34.630+0900 E/PKGMGR_GETSIZE(26932): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.tizenstore_984945940
07-13 23:06:34.740+0900 E/PKGMGR_GETSIZE(26934): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/rMfxc1AKe2_985056724
07-13 23:06:34.840+0900 E/PKGMGR_GETSIZE(26936): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/AeZIW4LxWM_985084601
07-13 23:06:34.920+0900 E/PKGMGR_GETSIZE(26937): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.hybridsampleservice_985156699
07-13 23:06:35.020+0900 E/PKGMGR_GETSIZE(26941): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.hybridsample_985252512
07-13 23:06:35.110+0900 E/PKGMGR_GETSIZE(26945): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/A6zBsLkZYG_985435447
07-13 23:06:35.210+0900 E/PKGMGR_GETSIZE(26947): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/cZuRmVoDFm_985492461
07-13 23:06:35.310+0900 E/PKGMGR_GETSIZE(26948): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.hybridservice_985571224
07-13 23:06:35.410+0900 E/PKGMGR_GETSIZE(26949): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/B4V8145r3u_985631503
07-13 23:06:35.490+0900 E/PKGMGR_GETSIZE(26953): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/S1wiLDLm2A_985727099
07-13 23:06:35.590+0900 E/PKGMGR_GETSIZE(26958): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/PxxjwcAeTk.hybridnative_985852102
07-13 23:06:35.700+0900 E/PKGMGR_GETSIZE(26960): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/gppzPjPr5R_986000689
07-13 23:06:35.820+0900 E/PKGMGR_GETSIZE(26962): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/GpnbizoGPQ_986103966
07-13 23:06:35.910+0900 E/PKGMGR_GETSIZE(26966): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/UM0E2qggaf_986119572
07-13 23:06:36.020+0900 E/PKGMGR_GETSIZE(26967): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/8joIgfDeyk_986219473
07-13 23:06:36.150+0900 E/PKGMGR_GETSIZE(26968): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/yCm9wnZEFq_986337382
07-13 23:06:36.270+0900 E/PKGMGR_GETSIZE(26973): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.elementaryproject_986429116
07-13 23:06:36.380+0900 E/PKGMGR_GETSIZE(26977): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.gogogogogogogog_986535912
07-13 23:06:36.490+0900 E/PKGMGR_GETSIZE(26981): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.audiostreamtest_986664476
07-13 23:06:36.610+0900 E/PKGMGR_GETSIZE(26986): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.playertutorial_986784453
07-13 23:06:36.620+0900 E/PKGMGR_SERVER(26907): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
07-13 23:06:36.710+0900 E/PKGMGR_GETSIZE(26991): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.playsertest_986899128
07-13 23:06:36.810+0900 E/PKGMGR_GETSIZE(26993): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.mediasampleplayer_987043661
07-13 23:06:36.910+0900 E/PKGMGR_GETSIZE(26994): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.playertest_987138079
07-13 23:06:37.010+0900 E/PKGMGR_GETSIZE(26998): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.nativefilemanager_987225328
07-13 23:06:37.090+0900 E/PKGMGR_GETSIZE(26999): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.nativefile_987315328
07-13 23:06:37.180+0900 E/PKGMGR_GETSIZE(27000): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.nativealarm_987461262
07-13 23:06:37.280+0900 E/PKGMGR_GETSIZE(27002): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.test1_987543711
07-13 23:06:37.370+0900 E/PKGMGR_GETSIZE(27006): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.nativebasicuiapp_987609242
07-13 23:06:37.470+0900 E/PKGMGR_GETSIZE(27010): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.nativefilemanater_987696491
07-13 23:06:37.570+0900 W/AUL_AMD (  437): amd_request.c: __request_handler(601) > __request_handler: 0
07-13 23:06:37.580+0900 I/AUL     (  437): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
07-13 23:06:37.580+0900 E/PKGMGR_GETSIZE(27016): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/68Ce7FFrRR_987903724
07-13 23:06:37.580+0900 I/AUL     (  437): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
07-13 23:06:37.580+0900 E/AUL_AMD (  437): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
07-13 23:06:37.590+0900 W/AUL_AMD (  437): amd_launch.c: service_start(515) > child process: 27022
07-13 23:06:37.640+0900 W/AUL_AMD (  437): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 27022
07-13 23:06:37.640+0900 E/RESOURCED(  766): proc-process.c: proc_get_oom_score_adj(377) > [proc_get_oom_score_adj,377] fopen /proc/0/oom_score_adj failed
07-13 23:06:37.660+0900 I/Tizen::App( 1103): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 27022.
07-13 23:06:37.680+0900 I/Tizen::App( 1033): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-13 23:06:37.680+0900 I/Tizen::App( 1033): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 27022.
07-13 23:06:37.700+0900 I/tdlna   (27022): _on_create_cb 실행
07-13 23:06:37.700+0900 I/tdlna   (27022): _app_init 실행
07-13 23:06:37.700+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:06:37.710+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-13 23:06:37.720+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 27022
07-13 23:06:37.730+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:06:37.730+0900 D/tdlnaservice(27022): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-13 23:06:37.730+0900 I/tdlna   (27022): _on_app_control_callback 실행
07-13 23:06:37.730+0900 I/tdlna   (27022): _app_timer_thread_func 실행
07-13 23:06:37.740+0900 E/PKGMGR_GETSIZE(27023): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/yu651rQPjT_988015311
07-13 23:06:37.840+0900 E/PKGMGR_GETSIZE(27026): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/LwrmBhkJJl_988107878
07-13 23:06:37.940+0900 E/PKGMGR_GETSIZE(27027): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.uibuilderappsample_988251685
07-13 23:06:38.030+0900 E/PKGMGR_GETSIZE(27028): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/org.tizen.media_sample_988291499
07-13 23:06:38.110+0900 E/PKGMGR_GETSIZE(27029): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/com.opera.mini_988365013
07-13 23:06:38.210+0900 E/PKGMGR_GETSIZE(27030): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/awzdrHBOn3_988446556
07-13 23:06:38.290+0900 E/PKGMGR_GETSIZE(27032): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/t6hLafhAie_988592539
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.call) is found
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.setting) is found
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.gallery-lite) is found
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.myfile-lite) is found
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.fm-radio-lite) is found
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.music-player-lite) is found
07-13 23:06:38.340+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.image-viewer) is found
07-13 23:06:38.350+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.video-player-lite) is found
07-13 23:06:38.350+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.email) is found
07-13 23:06:38.350+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.ciss) is found
07-13 23:06:38.350+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.message-lite) is found
07-13 23:06:38.350+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-13 23:06:38.350+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.memo) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.calculator) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.voicerecorder-lite) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.calendar-lite) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.vtmain) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.contacts) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.clock-lite) is found
07-13 23:06:38.360+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(setting-call-efl) is found
07-13 23:06:38.370+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.browser) is found
07-13 23:06:38.370+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.videos-lite) is found
07-13 23:06:38.370+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.m-setting) is found
07-13 23:06:38.380+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.call-notification) is found
07-13 23:06:38.420+0900 E/PKGMGR_GETSIZE(27033): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/ACL111OMWW_988713835
07-13 23:06:38.440+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.maps-lite) is found
07-13 23:06:38.460+0900 E/PKGMGR_INFO( 7394): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.setting-syspopup) is found
07-13 23:06:38.500+0900 E/PKGMGR_GETSIZE(27034): pkg_getsize.c: __make_size_info_file(800) > File path = /tmp/HYHNQ5SzZQ_988743596
07-13 23:06:38.600+0900 E/PKGMGR_SERVER(26907): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
07-13 23:06:38.600+0900 E/PKGMGR_SERVER(26907): pkgmgr-server.c: main(1704) > package manager server terminated.
07-13 23:06:41.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:06:50.130+0900 W/LOCKSCREEN(  565): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-13 23:06:50.130+0900 W/LOCKSCREEN(  565): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-13 23:06:50.130+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-13 23:06:50.130+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-13 23:06:50.130+0900 W/LOCKSCREEN(  565): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-13 23:06:50.130+0900 W/LOCKSCREEN(  565): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-13 23:06:50.130+0900 I/indicator(  492): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-13 23:06:50.140+0900 E/LOCKSCREEN(  565): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:06:50.150+0900 W/LOCKSCREEN(  565): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-13 23:06:50.150+0900 W/LOCKSCREEN(  565): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-13 23:06:50.150+0900 W/LOCKSCREEN(  565): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-13 23:06:50.170+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-13 23:06:50.170+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 266 359 5 28 25"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 267 387 5 28 25"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 266 679 5 28 25"
07-13 23:06:50.180+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 267 707 5 28 25"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 266 359 5 28 25"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 267 387 5 28 25"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 266 679 5 28 25"
07-13 23:06:50.190+0900 I/indicator(  492): indicator_box_util.c: _update_display(585) > "Noti Icon : 267 707 5 28 25"
07-13 23:06:50.770+0900 W/CAM_APP ( 1196): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 23:06:50.780+0900 I/Tizen::System( 1103): (280) > The screen has been turned on.
07-13 23:06:50.780+0900 I/Tizen::Io( 1103): (729) > Entry not found
07-13 23:06:50.790+0900 I/Tizen::System( 1103): (157) > change brightness system value.
07-13 23:06:50.790+0900 I/Tizen::App( 1033): (124) > app(ACL111OMWW.AclService), clientId(1151)
07-13 23:06:50.840+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1196) > 3, (nil), 0xbead9ec0
07-13 23:06:50.840+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1213) > DISPLAY_STATE_SCREEN state : [0]
07-13 23:06:50.840+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1225) > paused
07-13 23:06:51.050+0900 I/Tizen::App( 1033): (124) > app(ACL111OMWW.AclService), clientId(1151)
07-13 23:06:51.270+0900 E/LOCKSCREEN(  565): progress_circle.c: unlock_mouse_up(285) > 
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-13 23:06:51.270+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-13 23:06:51.300+0900 I/Tizen::App( 1033): (124) > app(ACL111OMWW.AclService), clientId(1151)
07-13 23:06:51.550+0900 I/Tizen::App( 1033): (124) > app(ACL111OMWW.AclService), clientId(1151)
07-13 23:06:51.780+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-13 23:06:51.780+0900 W/LOCKSCREEN(  565): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-13 23:06:51.780+0900 W/LOCKSCREEN(  565): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-13 23:06:51.780+0900 E/WALLPAPER_SERVICE_COMMON(  565): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 23:06:51.790+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=23681
07-13 23:06:51.800+0900 I/Tizen::App( 1033): (124) > app(ACL111OMWW.AclService), clientId(1151)
07-13 23:06:51.800+0900 W/AUL_AMD (  437): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:06:51.810+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 23681"
07-13 23:06:51.820+0900 E/EFL     (23681): ewebkit2<23681> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-13 23:06:51.820+0900 W/LOCKSCREEN(  565): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(1)
07-13 23:06:51.820+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-13 23:06:51.820+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-13 23:06:51.830+0900 I/CAPI_APPFW_APPLICATION(  565): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 23:06:51.830+0900 E/LOCKSCREEN(  565): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:06:51.830+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-13 23:06:51.830+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-13 23:06:51.880+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:06:51.880+0900 I/Tizen::System( 1103): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-13 23:06:51.880+0900 I/Tizen::Io( 1103): (729) > Entry not found
07-13 23:06:51.890+0900 W/AUL_AMD (  437): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:06:51.900+0900 I/Tizen::System( 1151): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-13 23:06:51.910+0900 I/Tizen::System( 1103): (157) > change brightness system value.
07-13 23:06:51.980+0900 W/LOCKSCREEN(  565): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-13 23:06:51.980+0900 E/LOCKSCREEN(  565): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:06:51.980+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-13 23:06:51.980+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-13 23:06:51.990+0900 E/LOCKSCREEN(  565): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-13 23:06:52.050+0900 I/Tizen::App( 1033): (124) > app(ACL111OMWW.AclService), clientId(1151)
07-13 23:06:52.050+0900 D/PowerManagerService( 1660): calling setSysScreenBrightness(brightness = 153)
07-13 23:06:52.050+0900 I/power   ( 1660): *** set_screen_state 1
07-13 23:06:52.060+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'L'
07-13 23:06:52.060+0900 D/SensorService( 1660): actuateSensor
07-13 23:06:52.060+0900 D/AclServiceManager( 1660): -----*******------------ enableSensor  : 0
07-13 23:06:52.060+0900 D/SensorService( 1660): setSensorDelay
07-13 23:06:52.060+0900 D/AclServiceManager( 1660): -----*******------------ setSensorDelay : 0 to 200
07-13 23:06:52.060+0900 D/SensorService( 1660): setSensorDelay
07-13 23:06:52.060+0900 D/AclServiceManager( 1660): -----*******------------ setSensorDelay : 0 to 200
07-13 23:06:52.060+0900 I/AclService( 1151): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-13 23:06:52.060+0900 D/ACL     ( 1660): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-13 23:06:52.060+0900 D/ACL     ( 1660): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-13 23:06:52.070+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(true)
07-13 23:06:52.070+0900 I/AclService( 1151): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-13 23:06:52.070+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'F'
07-13 23:06:52.070+0900 I/AclService( 1151): void minimize()(280) > Minimizing all vfb clients
07-13 23:06:52.070+0900 I/AclService( 1151): void minimize()(283) > minimizing {pkg=surfaceflinger fd=99}
07-13 23:06:52.070+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(false)
07-13 23:06:52.070+0900 E/Tizen::Io( 1151): (133) > [E_INVALID_ARG] The application id is empty.
07-13 23:06:52.070+0900 I/Tizen::Base::Runtime( 1151): (251) > The timer is not started.
07-13 23:06:52.440+0900 W/LOCKSCREEN(  565): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-13 23:06:53.810+0900 I/MALI    (23681): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x17a8cb8] swap changed from async to sync
07-13 23:06:57.070+0900 W/ProcessStats( 1660): Skipping unknown process pid 27022
07-13 23:06:58.060+0900 D/PowerManagerService( 1660): calling setSysScreenBrightness(brightness = 153)
07-13 23:06:58.060+0900 I/AclService( 1151): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-13 23:07:00.000+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'L'
07-13 23:07:00.010+0900 E/SurfaceFlinger( 1660): redraw failed: empty invalid region
07-13 23:07:00.010+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'F'
07-13 23:07:00.010+0900 I/AclService( 1151): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:07:00.010+0900 I/Tizen::Base::Runtime( 1151): (251) > The timer is not started.
07-13 23:07:00.010+0900 I/Tizen::System( 1151): (85) > Current Epoch is 1436796420.
07-13 23:07:00.010+0900 I/Tizen::System( 1151): (89) > Calendar time is sec:0, min:7, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (103) > Original Time is 2015 7/13, 14:7:0:20
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (123) > Current Time is 2015 7/13, 23:7:0
07-13 23:07:00.020+0900 I/AclService( 1151): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 46379980 milliseconds from now
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(true)
07-13 23:07:00.020+0900 I/AclService( 1151): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (85) > Current Epoch is 1436796420.
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (89) > Calendar time is sec:0, min:7, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:07:00.020+0900 I/Tizen::System( 1151): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:07:00.030+0900 I/Tizen::System( 1151): (103) > Original Time is 2015 7/13, 14:7:0:29
07-13 23:07:00.030+0900 I/Tizen::System( 1151): (123) > Current Time is 2015 7/13, 23:7:0
07-13 23:07:00.030+0900 I/AclService( 1151): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59971 milliseconds from now
07-13 23:07:00.030+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(false)
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:07:00.150+0900 I/MESSAGE_PORT(  385): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:07:00.150+0900 D/tdlnaservice(27022): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-13 23:07:00.150+0900 I/tdlna   (27022): _on_proxy_client_msg_received_cb 실행
07-13 23:07:00.150+0900 I/tdlna   (27022): _app_process_received_message 실행
07-13 23:07:00.150+0900 I/tdlna   (27022): test _ _app_process_received_message
07-13 23:07:00.150+0900 I/tdlna   (27022): _app_execute_operation 실행
07-13 23:07:00.150+0900 I/tdlna   (27022): test 실행
07-13 23:07:00.150+0900 I/tdlna   (27022): ★★★★★ 서비스 가동중 ★★★★★ 1
07-13 23:07:00.150+0900 I/tdlna   (27022): Main Start !!! 1
07-13 23:07:00.150+0900 I/tdlna   (27022): Main Start !!! 1
07-13 23:07:00.150+0900 I/tdlna   (27022): fork 전
07-13 23:07:00.150+0900 I/tdlna   (27127): fork child process 1
07-13 23:07:00.150+0900 I/tdlna   (27127): ssdp running
07-13 23:07:01.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:07:02.350+0900 I/tdlna   (27127): ssdp running
07-13 23:07:04.560+0900 I/tdlna   (27127): ssdp running
07-13 23:07:05.020+0900 W/ProcessStats( 1660): Skipping unknown process pid 27127
07-13 23:07:05.040+0900 D/dalvikvm(16056): GC_EXPLICIT freed 19K, 50% free 2856K/5639K, external 1962K/2073K, paused 22ms
07-13 23:07:06.760+0900 I/tdlna   (27127): ssdp running
07-13 23:07:08.960+0900 I/tdlna   (27127): ssdp running
07-13 23:07:10.360+0900 W/BROWSER_PROVIDER( 3506): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:2140128558] slot:3 sock:16
07-13 23:07:11.160+0900 I/tdlna   (27127): ssdp running
07-13 23:07:11.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:07:13.370+0900 I/tdlna   (27127): ssdp running
07-13 23:07:15.570+0900 I/tdlna   (27127): ssdp running
07-13 23:07:17.770+0900 I/tdlna   (27127): ssdp running
07-13 23:07:19.970+0900 I/tdlna   (27127): ssdp running
07-13 23:07:21.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:07:22.170+0900 I/tdlna   (27127): ssdp running
07-13 23:07:23.040+0900 W/CAM_APP ( 1196): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 23:07:23.050+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1196) > 3, 0x1, 0xbead9ec0
07-13 23:07:23.060+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1213) > DISPLAY_STATE_SCREEN state : [1]
07-13 23:07:24.380+0900 I/tdlna   (27127): ssdp running
07-13 23:07:26.580+0900 I/tdlna   (27127): ssdp running
07-13 23:07:28.780+0900 I/tdlna   (27127): ssdp running
07-13 23:07:30.130+0900 W/LOCKSCREEN(  565): dbus.c: _dbus_message_recv_cb(141) > [_dbus_message_recv_cb:141:W] LCD off
07-13 23:07:30.130+0900 W/LOCKSCREEN(  565): event.c: _lcd_off_cb(61) > [_lcd_off_cb:61:W] Dbus LCD off:timeout
07-13 23:07:30.130+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30000:LCD_WILL_OFF
07-13 23:07:30.130+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:30000 event_info:1979360
07-13 23:07:30.130+0900 W/LOCKSCREEN(  565): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-13 23:07:30.130+0900 W/LOCKSCREEN(  565): daemon.c: _state_enter(329) > [_state_enter:329:W] HIDE => WILL RESUME
07-13 23:07:30.130+0900 E/LOCKSCREEN(  565): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-13 23:07:30.780+0900 W/CAM_APP ( 1196): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-13 23:07:30.780+0900 E/VOLUME  (  586): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
07-13 23:07:30.780+0900 E/VOLUME  (  586): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
07-13 23:07:30.790+0900 E/EFL     (23681): ewebkit2<23681> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-13 23:07:30.800+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:0:LKD_EVT_WILL_LOCK
07-13 23:07:30.800+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:0 event_info:0
07-13 23:07:30.800+0900 W/LOCKSCREEN(  565): view-mgr.c: _event_route(108) > [_event_route:108:W] event:0 event_info:0
07-13 23:07:30.810+0900 E/VOLUME  (  586): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
07-13 23:07:30.810+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1196) > 3, 0x2, 0xbead9ec0
07-13 23:07:30.810+0900 I/Internet( 3444): main.cpp: __display_changed_cb(1213) > DISPLAY_STATE_SCREEN state : [2]
07-13 23:07:30.810+0900 E/Internet( 3444): mdm-manager.cpp: deregister_policy(236) > mdm_deregister_policy_receiver() is failed [0xffffffff]
07-13 23:07:30.810+0900 E/Internet( 3444): mdm-manager.cpp: deregister_policy(240) > mdm_release_service failed
07-13 23:07:30.810+0900 W/UI_GADGET( 3444): manager.c: ugman_pause(1070) > [34mugman_pause failed: no root[0m
07-13 23:07:30.820+0900 I/Tizen::Base::Runtime( 1151): (251) > The timer is not started.
07-13 23:07:30.850+0900 D/PowerManagerService( 1660): calling setSysScreenBrightness(brightness = 153)
07-13 23:07:30.850+0900 I/power   ( 1660): *** set_screen_state 0
07-13 23:07:30.850+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'L'
07-13 23:07:30.850+0900 D/SensorService( 1660): actuateSensor
07-13 23:07:30.850+0900 D/AclServiceManager( 1660): -----*******------------ disableSensor  : 0
07-13 23:07:30.860+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'L'
07-13 23:07:30.870+0900 I/AclService( 1151): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-13 23:07:30.880+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(true)
07-13 23:07:30.880+0900 D/ACL     ( 1660): ************ onActivitySaveInstanceState()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-13 23:07:30.890+0900 D/ACL     ( 1660): ************ onActivityPaused()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-13 23:07:30.890+0900 D/ACL     ( 1660): Pausing app with base activity ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-13 23:07:30.890+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(true)
07-13 23:07:30.890+0900 I/PowerManagerService-JNI( 1660): sending ACL screen state 'F'
07-13 23:07:30.900+0900 I/Tizen::System( 1151): (461) > change cpu power policy: keepAwake(false)
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): event.c: _lcd_off_source_cb(47) > [_lcd_off_source_cb:47:W] Vconf LCD off
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30002:LCD_OFF
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:30002 event_info:0
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:5
07-13 23:07:30.940+0900 W/LOCKSCREEN(  565): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => PAUSE
07-13 23:07:30.940+0900 E/WALLPAPER_SERVICE_COMMON(  565): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-13 23:07:30.950+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:1:LOCK
07-13 23:07:30.950+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:1 event_info:0
07-13 23:07:30.950+0900 W/LOCKSCREEN(  565): view-mgr.c: _event_route(108) > [_event_route:108:W] event:1 event_info:0
07-13 23:07:30.960+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=565
07-13 23:07:30.970+0900 W/LOCKSCREEN(  565): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1C00008] is now visible(0)
07-13 23:07:30.970+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10001:WIN_BECOME_VISIBLE
07-13 23:07:30.970+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:10001 event_info:0
07-13 23:07:30.980+0900 I/CAPI_APPFW_APPLICATION(  565): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-13 23:07:30.980+0900 W/LOCKSCREEN(  565): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20004:APP_RESUME
07-13 23:07:30.980+0900 W/LOCKSCREEN(  565): daemon.c: _event_route(723) > [_event_route:723:W] event:20004 event_info:0
07-13 23:07:30.980+0900 I/tdlna   (27127): ssdp running
07-13 23:07:31.000+0900 I/MALI    (23681): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0x17a8cb8] swap changed from sync to async
07-13 23:07:31.010+0900 W/AUL_AMD (  437): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
07-13 23:07:31.010+0900 W/AUL_AMD (  437): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
07-13 23:07:31.020+0900 W/AUL_AMD (  437): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:07:31.030+0900 I/indicator(  492): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.lockscreen, pid = 565"
07-13 23:07:31.050+0900 W/AUL_AMD (  437): amd_request.c: __request_handler(601) > __request_handler: 15
07-13 23:07:31.060+0900 I/Tizen::System( 1151): (101) > Active App is com.samsung.lockscreen. GetApp id ACL111OMWW.AclService
07-13 23:07:31.090+0900 I/Tizen::System( 1103): (259) > Active app [com.samsun], current [rMfxc1AKe2] 
07-13 23:07:31.090+0900 I/Tizen::Io( 1103): (729) > Entry not found
07-13 23:07:31.100+0900 I/Tizen::System( 1103): (157) > change brightness system value.
07-13 23:07:31.440+0900 W/LOCKSCREEN(  565): util-daemon.c: _ckmc_lock_timer_cb(183) > [_ckmc_lock_timer_cb:183:W] key manager lock:0
07-13 23:07:31.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:07:33.190+0900 I/tdlna   (27127): ssdp running
07-13 23:07:35.390+0900 I/tdlna   (27127): ssdp running
07-13 23:07:37.590+0900 I/tdlna   (27127): ssdp running
07-13 23:07:39.790+0900 I/tdlna   (27127): ssdp running
07-13 23:07:41.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:07:42.000+0900 I/tdlna   (27127): ssdp running
07-13 23:07:44.200+0900 I/tdlna   (27127): ssdp running
07-13 23:07:46.400+0900 I/tdlna   (27127): ssdp running
07-13 23:07:48.600+0900 I/tdlna   (27127): ssdp running
07-13 23:07:50.800+0900 I/tdlna   (27127): ssdp running
07-13 23:07:51.850+0900 I/tizenstore( 7308): engine.c: EngineEcoreIdlerCb(317) > Delay CHECK CACHE SPACE
07-13 23:07:53.010+0900 I/tdlna   (27127): ssdp running
07-13 23:07:55.210+0900 I/tdlna   (27127): ssdp running
07-13 23:07:57.410+0900 I/tdlna   (27127): ssdp running
07-13 23:07:57.490+0900 W/CRASH_MANAGER(27352): worker.c: worker_job(1236) > 112702274646c143679647
