S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 2221
Date: 2015-07-14 15:56:36+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x77e70000

Register Information
r0   = 0x77e70002, r1   = 0x77e70000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f3b6a6
r6   = 0xb5c57438, r7   = 0x77e70002
r8   = 0x0000001e, r9   = 0xb5c586f0
r10  = 0xb6f3b687, fp   = 0xb5c5742c
ip   = 0x00000000, sp   = 0xb5c56ec8
lr   = 0xb6da65b8, pc   = 0xb6dd9d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     19500 KB
Buffers:     28240 KB
Cached:     276336 KB
VmPeak:      28900 KB
VmSize:      28896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        4988 KB
VmRSS:        4988 KB
VmData:      18028 KB
VmStk:         136 KB
VmExe:          52 KB
VmLib:        9144 KB
VmPTE:          22 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2221 TID = 2694
2221 2238 2694 

Maps Information
b545a000 b5c59000 rwxp [stack:2694]
b5c5a000 b645d000 rwxp [stack:2238]
b645d000 b6460000 r-xp /lib/libgpg-error.so.0.5.0
b6467000 b6468000 rwxp /lib/libgpg-error.so.0.5.0
b6468000 b64c0000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64c7000 b64ca000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64cb000 b64f7000 r-xp /usr/lib/libsystemd.so.0.0.1
b64fe000 b64ff000 r-xp /usr/lib/libsystemd.so.0.0.1
b64ff000 b6500000 rwxp /usr/lib/libsystemd.so.0.0.1
b6500000 b6502000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6509000 b650a000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b650a000 b65d5000 r-xp /usr/lib/libxml2.so.2.7.8
b65dd000 b65e2000 rwxp /usr/lib/libxml2.so.2.7.8
b65e3000 b65f3000 r-xp /lib/libresolv-2.13.so
b65f3000 b65f4000 r-xp /lib/libresolv-2.13.so
b65f4000 b65f5000 rwxp /lib/libresolv-2.13.so
b65f8000 b660e000 r-xp /lib/libz.so.1.2.5
b6615000 b6616000 rwxp /lib/libz.so.1.2.5
b6616000 b6618000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b661f000 b6620000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b6620000 b6625000 r-xp /usr/lib/libffi.so.5.0.10
b662c000 b662d000 rwxp /usr/lib/libffi.so.5.0.10
b662d000 b662e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6635000 b6636000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6636000 b669b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66a2000 b66a5000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66a6000 b66a9000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66b0000 b66b1000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66b1000 b6859000 r-xp /usr/lib/libcrypto.so.1.0.0
b6860000 b6875000 rwxp /usr/lib/libcrypto.so.1.0.0
b6879000 b688f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6896000 b6897000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6897000 b68cb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68d2000 b68d4000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68d4000 b69a8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69b0000 b69b3000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69b5000 b69b9000 r-xp /usr/lib/libchromium.so.1.0
b69c0000 b69c1000 rwxp /usr/lib/libchromium.so.1.0
b69c1000 b6a2a000 r-xp /lib/libm-2.13.so
b6a31000 b6a32000 r-xp /lib/libm-2.13.so
b6a32000 b6a33000 rwxp /lib/libm-2.13.so
b6a33000 b6a39000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a40000 b6a41000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a41000 b6a60000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a67000 b6a68000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a68000 b6a6b000 r-xp /usr/lib/libsmack.so.1.0.0
b6a72000 b6a73000 rwxp /usr/lib/libsmack.so.1.0.0
b6a73000 b6a78000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a80000 b6a81000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a81000 b6aab000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6ab3000 b6ab4000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6ab4000 b6acb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6ad3000 b6ad4000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6ad4000 b6b68000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b70000 b6b73000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b73000 b6b75000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b7b000 b6b86000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6b8d000 b6b8e000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6b8e000 b6b93000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b9b000 b6b9c000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6b9c000 b6c6c000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c6c000 b6c6d000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c6d000 b6cad000 r-xp /usr/lib/libeina.so.1.7.99
b6cb4000 b6cb5000 rwxp /usr/lib/libeina.so.1.7.99
b6cb6000 b6ccc000 r-xp /usr/lib/libecore.so.1.7.99
b6cd3000 b6cd4000 rwxp /usr/lib/libecore.so.1.7.99
b6ce2000 b6ce9000 r-xp /usr/lib/libvconf.so.0.2.45
b6cf1000 b6cf2000 rwxp /usr/lib/libvconf.so.0.2.45
b6cf2000 b6cf7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cfe000 b6cff000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6cff000 b6d0a000 r-xp /usr/lib/libaul.so.0.1.0
b6d12000 b6d13000 rwxp /usr/lib/libaul.so.0.1.0
b6d14000 b6d1c000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d23000 b6d24000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d24000 b6d26000 r-xp /lib/libdl-2.13.so
b6d2d000 b6d2e000 r-xp /lib/libdl-2.13.so
b6d2e000 b6d2f000 rwxp /lib/libdl-2.13.so
b6d2f000 b6d3a000 r-xp /lib/libunwind.so.8.0.1
b6d41000 b6d42000 rwxp /lib/libunwind.so.8.0.1
b6d67000 b6e82000 r-xp /lib/libc-2.13.so
b6e8a000 b6e8c000 r-xp /lib/libc-2.13.so
b6e8c000 b6e8d000 rwxp /lib/libc-2.13.so
b6e90000 b6e96000 r-xp /lib/librt-2.13.so
b6e9d000 b6e9e000 r-xp /lib/librt-2.13.so
b6e9e000 b6e9f000 rwxp /lib/librt-2.13.so
b6e9f000 b6ea1000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea8000 b6ea9000 rwxp /usr/lib/libdlog.so.0.0.0
b6ea9000 b6eac000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6eb3000 b6eb4000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6eb4000 b6eb7000 r-xp /usr/lib/libbundle.so.0.1.22
b6ebe000 b6ebf000 rwxp /usr/lib/libbundle.so.0.1.22
b6ebf000 b6ec2000 r-xp /usr/lib/libappcore-agent.so.1.1
b6ec9000 b6eca000 rwxp /usr/lib/libappcore-agent.so.1.1
b6eca000 b6ede000 r-xp /lib/libpthread-2.13.so
b6ee5000 b6ee6000 r-xp /lib/libpthread-2.13.so
b6ee6000 b6ee7000 rwxp /lib/libpthread-2.13.so
b6efe000 b6f02000 r-xp /usr/lib/libsys-assert.so
b6f0a000 b6f0b000 rwxp /usr/lib/libsys-assert.so
b6f0b000 b6f28000 r-xp /lib/ld-2.13.so
b6f2f000 b6f30000 r-xp /lib/ld-2.13.so
b6f30000 b6f31000 rwxp /lib/ld-2.13.so
b6f31000 b6f3e000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f45000 b6f47000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b813b000 b8180000 rwxp [heap]
befc6000 befe7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2221)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6dd9d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6da65b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e3eb88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ea0063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x43a (0xb6f36127) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5127
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
gle-service-account-lite)
07-14 15:56:27.050+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.google-service-account-lite], package = [com.samsung.google-service-account-lite]
07-14 15:56:27.060+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.google-service-account-lite), version(0.0.1), type(rpm), displayName(Google service account), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.google-service-account-lite), storeClient(), appRootPath(/usr/apps/com.samsung.google-service-account-lite)
07-14 15:56:27.070+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.safetyvolume-syspopup), version(0.1.0), type(rpm), displayName(Safetyvolume Syspopup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.safetyvolume-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.safetyvolume-syspopup)
07-14 15:56:27.080+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.safetyvolume-syspopup], package = [com.samsung.safetyvolume-syspopup]
07-14 15:56:27.080+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.safetyvolume-syspopup), version(0.1.0), type(rpm), displayName(Safetyvolume Syspopup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.safetyvolume-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.safetyvolume-syspopup)
07-14 15:56:27.090+0900 I/Tizen::App( 1085): (1360) > package(wrt-setting), version(0.0.1), type(rpm), displayName(wrt-setting), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(wrt-setting.webapp-detail-efl), storeClient(), appRootPath(/usr/apps/wrt-setting)
07-14 15:56:27.100+0900 I/Tizen::App( 1085): (149) > app = [wrt-setting.webapp-detail-efl], package = [wrt-setting]
07-14 15:56:27.110+0900 I/Tizen::App( 1085): (1360) > package(wrt-setting), version(0.0.1), type(rpm), displayName(wrt-setting), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(wrt-setting.webapp-detail-efl), storeClient(), appRootPath(/usr/apps/wrt-setting)
07-14 15:56:27.120+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.wallpaper-service), version(1.0.4), type(rpm), displayName(Wallpaper Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.wallpaper-service), storeClient(), appRootPath(/usr/apps/com.samsung.wallpaper-service)
07-14 15:56:27.130+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.wallpaper-service], package = [com.samsung.wallpaper-service]
07-14 15:56:27.140+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.wallpaper-service), version(1.0.4), type(rpm), displayName(Wallpaper Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.wallpaper-service), storeClient(), appRootPath(/usr/apps/com.samsung.wallpaper-service)
07-14 15:56:27.150+0900 I/Tizen::App( 1085): (1360) > package(ug-lockscreen-options), version(0.1.108), type(rpm), displayName(Lockscreen options), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(wallpaper-viewer-efl), storeClient(), appRootPath(/usr/apps/ug-lockscreen-options)
07-14 15:56:27.160+0900 I/Tizen::App( 1085): (149) > app = [wallpaper-viewer-efl], package = [ug-lockscreen-options]
07-14 15:56:27.170+0900 I/Tizen::App( 1085): (1360) > package(ug-lockscreen-options), version(0.1.108), type(rpm), displayName(Lockscreen options), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(wallpaper-viewer-efl), storeClient(), appRootPath(/usr/apps/ug-lockscreen-options)
07-14 15:56:27.180+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.quickpanel), version(0.6.22), type(rpm), displayName(Quickpanel), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.quickpanel), storeClient(), appRootPath(/usr/apps/com.samsung.quickpanel)
07-14 15:56:27.190+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.quickpanel], package = [com.samsung.quickpanel]
07-14 15:56:27.200+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.quickpanel), version(0.6.22), type(rpm), displayName(Quickpanel), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.quickpanel), storeClient(), appRootPath(/usr/apps/com.samsung.quickpanel)
07-14 15:56:27.210+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.admin-data), version(1.1.0), type(rpm), displayName(admin-data), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.admin-data), storeClient(), appRootPath(/usr/apps/com.samsung.admin-data)
07-14 15:56:27.220+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.admin-data], package = [com.samsung.admin-data]
07-14 15:56:27.220+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.admin-data), version(1.1.0), type(rpm), displayName(admin-data), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.admin-data), storeClient(), appRootPath(/usr/apps/com.samsung.admin-data)
07-14 15:56:27.240+0900 E/PKGMGR_INFO( 1085): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.maps-lite) is found
07-14 15:56:27.240+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.maps-lite), version(0.1.80), type(rpm), displayName(지도), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.maps-lite), storeClient(), appRootPath(/usr/apps/com.samsung.maps-lite)
07-14 15:56:27.250+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.maps-lite], package = [com.samsung.maps-lite]
07-14 15:56:27.250+0900 E/PKGMGR_INFO( 1085): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.maps-lite) is found
07-14 15:56:27.250+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.maps-lite), version(0.1.80), type(rpm), displayName(지도), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.maps-lite), storeClient(), appRootPath(/usr/apps/com.samsung.maps-lite)
07-14 15:56:27.260+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.telephony-syspopup), version(0.0.1), type(rpm), displayName(Telephony System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.telephony-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.telephony-syspopup)
07-14 15:56:27.270+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.telephony-syspopup], package = [com.samsung.telephony-syspopup]
07-14 15:56:27.280+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.telephony-syspopup), version(0.0.1), type(rpm), displayName(Telephony System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.telephony-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.telephony-syspopup)
07-14 15:56:27.290+0900 I/Tizen::App( 1085): (1360) > package(worldclock-efl), version(0.1), type(rpm), displayName(World clock Appcontrol), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(worldclock-efl), storeClient(), appRootPath(/usr/apps/worldclock-efl)
07-14 15:56:27.300+0900 I/Tizen::App( 1085): (149) > app = [worldclock-efl], package = [worldclock-efl]
07-14 15:56:27.310+0900 I/Tizen::App( 1085): (1360) > package(worldclock-efl), version(0.1), type(rpm), displayName(World clock Appcontrol), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(worldclock-efl), storeClient(), appRootPath(/usr/apps/worldclock-efl)
07-14 15:56:27.320+0900 E/PKGMGR_INFO( 1085): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.setting-syspopup) is found
07-14 15:56:27.320+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.setting-syspopup), version(0.0.1), type(rpm), displayName(Setting System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.setting-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.setting-syspopup)
07-14 15:56:27.330+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.setting-syspopup], package = [com.samsung.setting-syspopup]
07-14 15:56:27.340+0900 E/PKGMGR_INFO( 1085): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_icon(896) > (ret == PMINFO_R_OK) theme_ico(com.samsung.setting-syspopup) is found
07-14 15:56:27.340+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.setting-syspopup), version(0.0.1), type(rpm), displayName(Setting System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.setting-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.setting-syspopup)
07-14 15:56:27.350+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.task-mgr), version(0.1.0), type(rpm), displayName(작업관리자), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.task-mgr), storeClient(), appRootPath(/usr/apps/com.samsung.task-mgr)
07-14 15:56:27.360+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.task-mgr], package = [com.samsung.task-mgr]
07-14 15:56:27.360+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.task-mgr), version(0.1.0), type(rpm), displayName(작업관리자), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.task-mgr), storeClient(), appRootPath(/usr/apps/com.samsung.task-mgr)
07-14 15:56:27.380+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.crash-popup), version(0.1.7), type(rpm), displayName(Crash popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.crash-popup), storeClient(), appRootPath(/usr/apps/com.samsung.crash-popup)
07-14 15:56:27.380+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.crash-popup], package = [com.samsung.crash-popup]
07-14 15:56:27.390+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.crash-popup), version(0.1.7), type(rpm), displayName(Crash popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.crash-popup), storeClient(), appRootPath(/usr/apps/com.samsung.crash-popup)
07-14 15:56:27.400+0900 I/Tizen::App( 1085): (1360) > package(eas-ui), version(0.0.3), type(rpm), displayName(EAS Application), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(eas-ui), storeClient(), appRootPath(/usr/apps/eas-ui)
07-14 15:56:27.410+0900 I/Tizen::App( 1085): (149) > app = [eas-ui], package = [eas-ui]
07-14 15:56:27.420+0900 I/Tizen::App( 1085): (1360) > package(eas-ui), version(0.0.3), type(rpm), displayName(EAS Application), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(eas-ui), storeClient(), appRootPath(/usr/apps/eas-ui)
07-14 15:56:27.430+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.lockscreen), version(0.1.0), type(rpm), displayName(잠금화면), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.lockscreen), storeClient(), appRootPath(/usr/apps/com.samsung.lockscreen)
07-14 15:56:27.440+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.lockscreen], package = [com.samsung.lockscreen]
07-14 15:56:27.450+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.lockscreen), version(0.1.0), type(rpm), displayName(잠금화면), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.lockscreen), storeClient(), appRootPath(/usr/apps/com.samsung.lockscreen)
07-14 15:56:27.460+0900 I/Tizen::App( 1085): (1360) > package(cert-svc-ui), version(0.1), type(rpm), displayName(cert-svc-ui ug), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(setting-manage-certificates-efl), storeClient(), appRootPath(/usr/apps/cert-svc-ui)
07-14 15:56:27.470+0900 I/Tizen::App( 1085): (149) > app = [setting-manage-certificates-efl], package = [cert-svc-ui]
07-14 15:56:27.480+0900 I/Tizen::App( 1085): (1360) > package(cert-svc-ui), version(0.1), type(rpm), displayName(cert-svc-ui ug), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(setting-manage-certificates-efl), storeClient(), appRootPath(/usr/apps/cert-svc-ui)
07-14 15:56:27.490+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.pwlock-lite), version(0.4.2), type(rpm), displayName(Pwlock), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.pwlock-lite), storeClient(), appRootPath(/usr/apps/com.samsung.pwlock-lite)
07-14 15:56:27.500+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.pwlock-lite], package = [com.samsung.pwlock-lite]
07-14 15:56:27.500+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.pwlock-lite), version(0.4.2), type(rpm), displayName(Pwlock), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.pwlock-lite), storeClient(), appRootPath(/usr/apps/com.samsung.pwlock-lite)
07-14 15:56:27.510+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.mdm-ode-app), version(1.0.2), type(rpm), displayName(MDM Device Encryption), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mdm-ode-app), storeClient(), appRootPath(/usr/apps/com.samsung.mdm-ode-app)
07-14 15:56:27.520+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.mdm-ode-app], package = [com.samsung.mdm-ode-app]
07-14 15:56:27.530+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.mdm-ode-app), version(1.0.2), type(rpm), displayName(MDM Device Encryption), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mdm-ode-app), storeClient(), appRootPath(/usr/apps/com.samsung.mdm-ode-app)
07-14 15:56:27.540+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.home-popup), version(0.0.1-1), type(rpm), displayName(home-popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.home-popup), storeClient(), appRootPath(/usr/apps/com.samsung.home-popup)
07-14 15:56:27.550+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.home-popup], package = [com.samsung.home-popup]
07-14 15:56:27.560+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.home-popup), version(0.0.1-1), type(rpm), displayName(home-popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.home-popup), storeClient(), appRootPath(/usr/apps/com.samsung.home-popup)
07-14 15:56:27.570+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.mmc-syspopup), version(0.1.7), type(rpm), displayName(Mmc system popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mmc-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.mmc-syspopup)
07-14 15:56:27.580+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.mmc-syspopup], package = [com.samsung.mmc-syspopup]
07-14 15:56:27.590+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.mmc-syspopup), version(0.1.7), type(rpm), displayName(Mmc system popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mmc-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.mmc-syspopup)
07-14 15:56:27.600+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.crash-viewer), version(0.1.0), type(rpm), displayName(Crash viewer), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.crash-viewer), storeClient(), appRootPath(/usr/apps/com.samsung.crash-viewer)
07-14 15:56:27.610+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.crash-viewer], package = [com.samsung.crash-viewer]
07-14 15:56:27.610+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.crash-viewer), version(0.1.0), type(rpm), displayName(Crash viewer), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.crash-viewer), storeClient(), appRootPath(/usr/apps/com.samsung.crash-viewer)
07-14 15:56:27.630+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.bluetooth-share-ui), version(0.0.14), type(rpm), displayName(Bluetooth Share UI), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.bluetooth-share-ui), storeClient(), appRootPath(/usr/apps/com.samsung.bluetooth-share-ui)
07-14 15:56:27.630+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.bluetooth-share-ui], package = [com.samsung.bluetooth-share-ui]
07-14 15:56:27.640+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.bluetooth-share-ui), version(0.0.14), type(rpm), displayName(Bluetooth Share UI), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.bluetooth-share-ui), storeClient(), appRootPath(/usr/apps/com.samsung.bluetooth-share-ui)
07-14 15:56:27.650+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.system-syspopup), version(0.1.7), type(rpm), displayName(System popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.system-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.system-syspopup)
07-14 15:56:27.660+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.system-syspopup], package = [com.samsung.system-syspopup]
07-14 15:56:27.670+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.system-syspopup), version(0.1.7), type(rpm), displayName(System popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.system-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.system-syspopup)
07-14 15:56:27.680+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.update-service), version(0.1.0), type(rpm), displayName(update-service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.update-service), storeClient(), appRootPath(/usr/apps/com.samsung.update-service)
07-14 15:56:27.690+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.update-service], package = [com.samsung.update-service]
07-14 15:56:27.700+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.update-service), version(0.1.0), type(rpm), displayName(update-service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.update-service), storeClient(), appRootPath(/usr/apps/com.samsung.update-service)
07-14 15:56:27.710+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.admin-lbs), version(0.0.1), type(rpm), displayName(admin-lbs), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.admin-lbs), storeClient(), appRootPath(/usr/apps/com.samsung.admin-lbs)
07-14 15:56:27.720+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.admin-lbs], package = [com.samsung.admin-lbs]
07-14 15:56:27.730+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.admin-lbs), version(0.0.1), type(rpm), displayName(admin-lbs), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.admin-lbs), storeClient(), appRootPath(/usr/apps/com.samsung.admin-lbs)
07-14 15:56:27.740+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.wallpaper-ui-service), version(0.0.1-1), type(rpm), displayName(배경화면), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.wallpaper-ui-service), storeClient(), appRootPath(/usr/apps/com.samsung.wallpaper-ui-service)
07-14 15:56:27.750+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.wallpaper-ui-service], package = [com.samsung.wallpaper-ui-service]
07-14 15:56:27.750+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.wallpaper-ui-service), version(0.0.1-1), type(rpm), displayName(배경화면), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.wallpaper-ui-service), storeClient(), appRootPath(/usr/apps/com.samsung.wallpaper-ui-service)
07-14 15:56:27.760+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.dispcpuinfo), version(0.1.0), type(rpm), displayName(Dispcpuinfo), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.dispcpuinfo), storeClient(), appRootPath(/usr/apps/com.samsung.dispcpuinfo)
07-14 15:56:27.770+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.dispcpuinfo], package = [com.samsung.dispcpuinfo]
07-14 15:56:27.780+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.dispcpuinfo), version(0.1.0), type(rpm), displayName(Dispcpuinfo), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.dispcpuinfo), storeClient(), appRootPath(/usr/apps/com.samsung.dispcpuinfo)
07-14 15:56:27.790+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.host-devices), version(0.0.1), type(rpm), displayName(USB host device list application), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.host-devices), storeClient(), appRootPath(/usr/apps/com.samsung.host-devices)
07-14 15:56:27.800+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.host-devices], package = [com.samsung.host-devices]
07-14 15:56:27.810+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.host-devices), version(0.0.1), type(rpm), displayName(USB host device list application), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.host-devices), storeClient(), appRootPath(/usr/apps/com.samsung.host-devices)
07-14 15:56:27.820+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.fileshare-efl), version(0.2.1), type(rpm), displayName(Wi-Fi Direct), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.fileshare-efl), storeClient(), appRootPath(/usr/apps/com.samsung.fileshare-efl)
07-14 15:56:27.830+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.fileshare-efl], package = [com.samsung.fileshare-efl]
07-14 15:56:27.840+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.fileshare-efl), version(0.2.1), type(rpm), displayName(Wi-Fi Direct), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.fileshare-efl), storeClient(), appRootPath(/usr/apps/com.samsung.fileshare-efl)
07-14 15:56:27.850+0900 I/Tizen::App( 1085): (1360) > package(ug-setting-mobileap-efl), version(2.0.25), type(rpm), displayName(테더링), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(setting-mobileap-efl), storeClient(), appRootPath(/usr/apps/ug-setting-mobileap-efl)
07-14 15:56:27.860+0900 I/Tizen::App( 1085): (149) > app = [setting-mobileap-efl], package = [ug-setting-mobileap-efl]
07-14 15:56:27.870+0900 I/Tizen::App( 1085): (1360) > package(ug-setting-mobileap-efl), version(2.0.25), type(rpm), displayName(테더링), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(setting-mobileap-efl), storeClient(), appRootPath(/usr/apps/ug-setting-mobileap-efl)
07-14 15:56:27.880+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.taskmgr), version(0.14.25), type(rpm), displayName(작업 전환기), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.taskmgr), storeClient(), appRootPath(/usr/apps/com.samsung.taskmgr)
07-14 15:56:27.890+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.taskmgr], package = [com.samsung.taskmgr]
07-14 15:56:27.890+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.taskmgr), version(0.14.25), type(rpm), displayName(작업 전환기), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.taskmgr), storeClient(), appRootPath(/usr/apps/com.samsung.taskmgr)
07-14 15:56:27.910+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.mdm-syspopup), version(1.0.2), type(rpm), displayName(MDM System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mdm-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.mdm-syspopup)
07-14 15:56:27.910+0900 I/Tizen::App( 1085): (149) > app = [com.samsung.mdm-syspopup], package = [com.samsung.mdm-syspopup]
07-14 15:56:27.920+0900 I/Tizen::App( 1085): (1360) > package(com.samsung.mdm-syspopup), version(1.0.2), type(rpm), displayName(MDM System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mdm-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.mdm-syspopup)
07-14 15:56:27.930+0900 I/Tizen::App( 1085): (1360) > package(sEvhOLMlQ7), version(0.0.15), type(wgt), displayName(Hungama), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sEvhOLMlQ7.hungama), storeClient(), appRootPath(/opt/usr/apps/sEvhOLMlQ7)
07-14 15:56:27.940+0900 I/Tizen::App( 1085): (149) > app = [sEvhOLMlQ7.hungama], package = [sEvhOLMlQ7]
07-14 15:56:27.950+0900 I/Tizen::App( 1085): (1360) > package(sEvhOLMlQ7), version(0.0.15), type(wgt), displayName(Hungama), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sEvhOLMlQ7.hungama), storeClient(), appRootPath(/opt/usr/apps/sEvhOLMlQ7)
07-14 15:56:27.960+0900 I/Tizen::App( 1085): (1360) > package(sjjevolsjk), version(1.0.0), type(tpk), displayName(Native Privileged API Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sjjevolsjk.osp-common-service), storeClient(), appRootPath(/opt/apps/sjjevolsjk)
07-14 15:56:27.970+0900 I/Tizen::App( 1085): (149) > app = [sjjevolsjk.osp-common-service], package = [sjjevolsjk]
07-14 15:56:27.980+0900 I/Tizen::App( 1085): (1360) > package(sjjevolsjk), version(1.0.0), type(tpk), displayName(Native Privileged API Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sjjevolsjk.osp-common-service), storeClient(), appRootPath(/opt/apps/sjjevolsjk)
07-14 15:56:27.990+0900 I/Tizen::App( 1085): (1360) > package(57r43275q7), version(1.0.0), type(tpk), displayName(Native Network Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(57r43275q7.osp-connectivity-service), storeClient(), appRootPath(/opt/apps/57r43275q7)
07-14 15:56:28.000+0900 I/Tizen::App( 1085): (149) > app = [57r43275q7.osp-connectivity-service], package = [57r43275q7]
07-14 15:56:28.010+0900 I/Tizen::App( 1085): (1360) > package(57r43275q7), version(1.0.0), type(tpk), displayName(Native Network Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(57r43275q7.osp-connectivity-service), storeClient(), appRootPath(/opt/apps/57r43275q7)
07-14 15:56:28.020+0900 I/Tizen::App( 1085): (1360) > package(3qwk86ogmg), version(4.0.016), type(tpk), displayName(Polaris Viewer), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(3qwk86ogmg.PolarisOffice), storeClient(), appRootPath(/opt/apps/3qwk86ogmg)
07-14 15:56:28.030+0900 I/Tizen::App( 1085): (149) > app = [3qwk86ogmg.PolarisOffice], package = [3qwk86ogmg]
07-14 15:56:28.040+0900 I/Tizen::App( 1085): (1360) > package(3qwk86ogmg), version(4.0.016), type(tpk), displayName(Polaris Viewer), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(3qwk86ogmg.PolarisOffice), storeClient(), appRootPath(/opt/apps/3qwk86ogmg)
07-14 15:56:28.050+0900 I/Tizen::App( 1085): (1360) > package(EmbkcJFK7q), version(1.2.28), type(tpk), displayName(McAfee Security), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(EmbkcJFK7q.MMS), storeClient(), appRootPath(/opt/apps/EmbkcJFK7q)
07-14 15:56:28.060+0900 I/Tizen::App( 1085): (149) > app = [EmbkcJFK7q.MMS], package = [EmbkcJFK7q]
07-14 15:56:28.070+0900 I/Tizen::App( 1085): (1360) > package(EmbkcJFK7q), version(1.2.28), type(tpk), displayName(McAfee Security), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(EmbkcJFK7q.MMS), storeClient(), appRootPath(/opt/apps/EmbkcJFK7q)
07-14 15:56:28.080+0900 I/Tizen::App( 1085): (1360) > package(srfxzv8GKR), version(1.0.4), type(wgt), displayName(YouTube), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(srfxzv8GKR.YouTube), storeClient(), appRootPath(/opt/usr/apps/srfxzv8GKR)
07-14 15:56:28.090+0900 I/Tizen::App( 1085): (149) > app = [srfxzv8GKR.YouTube], package = [srfxzv8GKR]
07-14 15:56:28.100+0900 I/Tizen::App( 1085): (1360) > package(srfxzv8GKR), version(1.0.4), type(wgt), displayName(YouTube), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(srfxzv8GKR.YouTube), storeClient(), appRootPath(/opt/usr/apps/srfxzv8GKR)
07-14 15:56:28.110+0900 I/Tizen::App( 1085): (1360) > package(hyCsE05ySM), version(1.0.0), type(tpk), displayName(사용자 인증서), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(hyCsE05ySM.CertificateSelector), storeClient(), appRootPath(/opt/apps/hyCsE05ySM)
07-14 15:56:28.120+0900 I/Tizen::App( 1085): (149) > app = [hyCsE05ySM.CertificateSelector], package = [hyCsE05ySM]
07-14 15:56:28.130+0900 I/Tizen::App( 1085): (1360) > package(hyCsE05ySM), version(1.0.0), type(tpk), displayName(사용자 인증서), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(hyCsE05ySM.CertificateSelector), storeClient(), appRootPath(/opt/apps/hyCsE05ySM)
07-14 15:56:28.140+0900 I/Tizen::App( 1085): (1360) > package(q7097a278m), version(1.0.0), type(tpk), displayName(Native Security Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(q7097a278m.osp-security-service), storeClient(), appRootPath(/opt/apps/q7097a278m)
07-14 15:56:28.150+0900 I/Tizen::App( 1085): (149) > app = [q7097a278m.osp-security-service], package = [q7097a278m]
07-14 15:56:28.160+0900 I/Tizen::App( 1085): (1360) > package(q7097a278m), version(1.0.0), type(tpk), displayName(Native Security Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(q7097a278m.osp-security-service), storeClient(), appRootPath(/opt/apps/q7097a278m)
07-14 15:56:28.170+0900 I/Tizen::App( 1085): (1360) > package(cp7ipabg4k), version(1.0.0), type(tpk), displayName(Channel Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(cp7ipabg4k.osp-channel-service), storeClient(), appRootPath(/opt/apps/cp7ipabg4k)
07-14 15:56:28.180+0900 I/Tizen::App( 1085): (149) > app = [cp7ipabg4k.osp-channel-service], package = [cp7ipabg4k]
07-14 15:56:28.190+0900 I/Tizen::App( 1085): (1360) > package(cp7ipabg4k), version(1.0.0), type(tpk), displayName(Channel Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(cp7ipabg4k.osp-channel-service), storeClient(), appRootPath(/opt/apps/cp7ipabg4k)
07-14 15:56:28.200+0900 I/Tizen::App( 1085): (1360) > package(aospd00043), version(1.0.0), type(tpk), displayName(Native Application Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(aospd00043.osp-app-service), storeClient(), appRootPath(/opt/apps/aospd00043)
07-14 15:56:28.210+0900 I/Tizen::App( 1085): (149) > app = [aospd00043.osp-app-service], package = [aospd00043]
07-14 15:56:28.220+0900 I/Tizen::App( 1085): (1360) > package(aospd00043), version(1.0.0), type(tpk), displayName(Native Application Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(aospd00043.osp-app-service), storeClient(), appRootPath(/opt/apps/aospd00043)
07-14 15:56:28.220+0900 D/ResourceType( 1520): calling getConfigurations
07-14 15:56:28.220+0900 D/ResourceType( 1520): called getConfigurations size=227
07-14 15:56:28.220+0900 I/ActivityManager( 1520): Config changed: { scale=1.0 imsi=0/0 loc=ko_KR touch=3 keys=1/1/2 nav=1/1 orien=1 layout=34 uiMode=17 seq=4}
07-14 15:56:28.230+0900 E/SurfaceFlinger( 1520): redraw failed: empty invalid region
07-14 15:56:28.230+0900 E/AlarmManagerService( 1520): Unable to set kernel timezone to -540: Operation not permitted
07-14 15:56:28.240+0900 D/StatusBarService( 1789): repositionNavigationBar()
07-14 15:56:28.240+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 15:56:28.250+0900 I/Tizen::System( 1085): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 15:56:28.260+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(true)
07-14 15:56:28.260+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(false)
07-14 15:56:28.270+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(true)
07-14 15:56:28.270+0900 E/SurfaceFlinger( 1520): redraw failed: empty invalid region
07-14 15:56:28.270+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(true)
07-14 15:56:28.280+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(false)
07-14 15:56:28.280+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:56:28.280+0900 I/Tizen::System( 1085): (85) > Current Epoch is -5266297307017203044.
07-14 15:56:28.280+0900 I/Tizen::System( 1085): (89) > Calendar time is sec:28, min:56, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:56:28.280+0900 I/Tizen::System( 1085): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:56:28.280+0900 I/Tizen::System( 1085): (103) > Original Time is 2015 7/14, 6:56:28:290
07-14 15:56:28.280+0900 I/Tizen::System( 1085): (123) > Current Time is 2015 7/14, 15:56:28
07-14 15:56:28.280+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 79256058 milliseconds from now
07-14 15:56:28.280+0900 I/AclService( 1085): void AclService::BootComplete()(1547) > Setting boot completed to true
07-14 15:56:28.290+0900 E/AlarmManagerService( 1520): Unable to set kernel timezone to -540: Operation not permitted
07-14 15:56:28.310+0900 E/SurfaceFlinger( 1520): redraw failed: empty invalid region
07-14 15:56:28.310+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 15:56:28.310+0900 I/Tizen::System(  989): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 15:56:28.330+0900 D/ACL     ( 1520): Deleted 1 old ringtone db entry
07-14 15:56:28.330+0900 I/Tizen::System(  989): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 15:56:28.330+0900 I/Tizen::System(  989): (426) > Result Code is E_SUCCESS.
07-14 15:56:28.330+0900 I/Tizen::System(  989): (432) > Value is 1.
07-14 15:56:28.330+0900 I/Tizen::System( 1085): (637) > result is 1.
07-14 15:56:28.350+0900 E/SurfaceFlinger( 1520): redraw failed: empty invalid region
07-14 15:56:28.430+0900 D/ACL     ( 1520): Deleted 1 old ringtone db entry
07-14 15:56:28.480+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-14 15:56:28.480+0900 I/Tizen::Net::Wifi( 1035): (637) > OnGetWifiConnectionState with clientId : 1085, AppPkgId : ACL111OMWW
07-14 15:56:28.510+0900 D/WifiStateTracker( 1520): Tizen getWifiState state = 3
07-14 15:56:28.510+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 15:56:28.510+0900 I/Tizen::System(  989): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 15:56:28.530+0900 I/Tizen::System(  989): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 15:56:28.530+0900 I/Tizen::System(  989): (426) > Result Code is E_SUCCESS.
07-14 15:56:28.530+0900 I/Tizen::System(  989): (432) > Value is 1.
07-14 15:56:28.530+0900 I/Tizen::System( 1085): (637) > result is 1.
07-14 15:56:28.530+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-14 15:56:28.530+0900 I/Tizen::Net::Wifi( 1035): (637) > OnGetWifiConnectionState with clientId : 1085, AppPkgId : ACL111OMWW
07-14 15:56:28.560+0900 D/WifiStateTracker( 1520): Tizen getWifiState state = 3
07-14 15:56:28.560+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 15:56:28.560+0900 I/Tizen::System(  989): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 15:56:28.580+0900 I/Tizen::System(  989): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 15:56:28.580+0900 I/Tizen::System(  989): (426) > Result Code is E_SUCCESS.
07-14 15:56:28.580+0900 I/Tizen::System(  989): (432) > Value is 1.
07-14 15:56:28.580+0900 I/Tizen::System( 1085): (637) > result is 1.
07-14 15:56:28.590+0900 I/PowerManagerService-JNI( 1520): sending ACL screen state 'L'
07-14 15:56:28.590+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(true)
07-14 15:56:28.590+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-14 15:56:28.590+0900 I/Tizen::Net::Wifi( 1035): (637) > OnGetWifiConnectionState with clientId : 1085, AppPkgId : ACL111OMWW
07-14 15:56:28.620+0900 D/WifiStateTracker( 1520): Tizen getWifiState state = 3
07-14 15:56:28.620+0900 I/AclService( 1085): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 15:56:28.620+0900 I/Tizen::System(  989): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 15:56:28.640+0900 I/Tizen::System(  989): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 15:56:28.640+0900 I/Tizen::System(  989): (426) > Result Code is E_SUCCESS.
07-14 15:56:28.640+0900 I/Tizen::System(  989): (432) > Value is 1.
07-14 15:56:28.640+0900 I/Tizen::System( 1085): (637) > result is 1.
07-14 15:56:28.650+0900 I/PowerManagerService-JNI( 1520): sending ACL screen state 'F'
07-14 15:56:28.650+0900 I/Tizen::System( 1085): (461) > change cpu power policy: keepAwake(false)
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:56:29.230+0900 D/tdlnaservice( 2221): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 15:56:29.230+0900 I/tdlna   ( 2221): _on_proxy_client_msg_received_cb 실행
07-14 15:56:29.230+0900 I/tdlna   ( 2221): _app_process_received_message 실행
07-14 15:56:29.230+0900 I/tdlna   ( 2221): test _ _app_process_received_message
07-14 15:56:29.230+0900 I/tdlna   ( 2221): _app_execute_operation 실행
07-14 15:56:29.230+0900 I/tdlna   ( 2221): test 실행
07-14 15:56:29.230+0900 I/tdlna   ( 2221): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 15:56:29.230+0900 I/tdlna   ( 2221): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 15:56:29.230+0900 I/tdlna   ( 2221): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 15:56:29.230+0900 I/tdlna   ( 2221): _app_send_response 실행
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 15:56:29.230+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:56:29.230+0900 D/tdlnaservice( 2221): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 15:56:29.230+0900 I/tdlna   ( 2221): Main Start !!! 1
07-14 15:56:29.230+0900 I/tdlna   ( 2221): Service Start !!! 1
07-14 15:56:29.230+0900 I/tdlna   ( 2221): shttpl - 17
07-14 15:56:29.230+0900 I/tdlna   ( 2221): fork 전
07-14 15:56:29.230+0900 I/tdlna   ( 2221): Main precess Start !! 1
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 15:56:29.250+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 15:56:33.320+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 15:56:33.320+0900 I/Tizen::System( 1085): (85) > Current Epoch is 1436856993.
07-14 15:56:33.320+0900 I/Tizen::System( 1085): (89) > Calendar time is sec:33, min:56, hour:6, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 15:56:33.320+0900 I/Tizen::System( 1085): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 15:56:33.320+0900 I/Tizen::System( 1085): (103) > Original Time is 2015 7/14, 6:56:33:326
07-14 15:56:33.320+0900 I/Tizen::System( 1085): (123) > Current Time is 2015 7/14, 15:56:33
07-14 15:56:33.320+0900 I/AclService( 1085): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 79259984 milliseconds from now
07-14 15:56:33.600+0900 W/ProcessStats( 1520): Skipping unknown process pid 3089
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 15:56:36.290+0900 E/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 15:56:36.290+0900 E/MESSAGE_PORT(  374): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(2221) are closed. delete client info
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 15:56:36.290+0900 E/MESSAGE_PORT(  374): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  2221
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.290+0900 I/MESSAGE_PORT(  374): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 15:56:36.320+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 15:56:36.320+0900 W/AUL_AMD (  451): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 15:56:36.320+0900 W/AUL_AMD (  451): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 2221
07-14 15:56:36.320+0900 W/AUL_AMD (  451): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 15:56:36.320+0900 I/AUL_AMD (  451): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 2221
07-14 15:56:36.320+0900 I/Tizen::System(  989): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 15:56:36.320+0900 I/Tizen::Io(  989): (729) > Entry not found
07-14 15:56:36.320+0900 I/Tizen::App(  964): (243) > App[org.tizen.tdlnaservice] pid[2221] terminate event is forwarded
07-14 15:56:36.320+0900 I/Tizen::System(  964): (256) > osp.accessorymanager.service provider is found.
07-14 15:56:36.320+0900 I/Tizen::System(  964): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 2221, ]
07-14 15:56:36.320+0900 I/Tizen::System(  964): (256) > osp.system.service provider is found.
07-14 15:56:36.320+0900 I/Tizen::App(  964): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 15:56:36.320+0900 I/Tizen::App(  964): (512) > Not registered pid(2221)
07-14 15:56:36.320+0900 I/Tizen::App(  964): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 2221.
07-14 15:56:36.330+0900 I/Tizen::System(  989): (157) > change brightness system value.
07-14 15:56:36.330+0900 I/Tizen::App(  989): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 2221.
07-14 15:56:36.380+0900 W/CRASH_MANAGER( 3245): worker.c: worker_job(1236) > 110222174646c143685699
