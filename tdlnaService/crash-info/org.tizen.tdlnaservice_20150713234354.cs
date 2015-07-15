S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 1513
Date: 2015-07-13 23:43:54+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xceee0000

Register Information
r0   = 0xceee0002, r1   = 0xceee0000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6ff4446
r6   = 0xbefea7d0, r7   = 0xceee0002
r8   = 0x0000001e, r9   = 0xb65134d0
r10  = 0xb6ff4427, fp   = 0xbefea7c4
ip   = 0x00000000, sp   = 0xbefea260
lr   = 0xb6e5f5b8, pc   = 0xb6e92d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     22704 KB
Buffers:     27720 KB
Cached:     275796 KB
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
VmPTE:          20 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1513 TID = 1513
1513 1523 

Maps Information
b5d13000 b6516000 rwxp [stack:1523]
b6516000 b6519000 r-xp /lib/libgpg-error.so.0.5.0
b6520000 b6521000 rwxp /lib/libgpg-error.so.0.5.0
b6521000 b6579000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6580000 b6583000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6584000 b65b0000 r-xp /usr/lib/libsystemd.so.0.0.1
b65b7000 b65b8000 r-xp /usr/lib/libsystemd.so.0.0.1
b65b8000 b65b9000 rwxp /usr/lib/libsystemd.so.0.0.1
b65b9000 b65bb000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65c2000 b65c3000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b65c3000 b668e000 r-xp /usr/lib/libxml2.so.2.7.8
b6696000 b669b000 rwxp /usr/lib/libxml2.so.2.7.8
b669c000 b66ac000 r-xp /lib/libresolv-2.13.so
b66ac000 b66ad000 r-xp /lib/libresolv-2.13.so
b66ad000 b66ae000 rwxp /lib/libresolv-2.13.so
b66b1000 b66c7000 r-xp /lib/libz.so.1.2.5
b66ce000 b66cf000 rwxp /lib/libz.so.1.2.5
b66cf000 b66d1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66d8000 b66d9000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66d9000 b66de000 r-xp /usr/lib/libffi.so.5.0.10
b66e5000 b66e6000 rwxp /usr/lib/libffi.so.5.0.10
b66e6000 b66e7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66ee000 b66ef000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66ef000 b6754000 r-xp /usr/lib/libsqlite3.so.0.8.6
b675b000 b675e000 rwxp /usr/lib/libsqlite3.so.0.8.6
b675f000 b6762000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6769000 b676a000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b676a000 b6912000 r-xp /usr/lib/libcrypto.so.1.0.0
b6919000 b692e000 rwxp /usr/lib/libcrypto.so.1.0.0
b6932000 b6948000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b694f000 b6950000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6950000 b6984000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b698b000 b698d000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b698d000 b6a61000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a69000 b6a6c000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a6e000 b6a72000 r-xp /usr/lib/libchromium.so.1.0
b6a79000 b6a7a000 rwxp /usr/lib/libchromium.so.1.0
b6a7a000 b6ae3000 r-xp /lib/libm-2.13.so
b6aea000 b6aeb000 r-xp /lib/libm-2.13.so
b6aeb000 b6aec000 rwxp /lib/libm-2.13.so
b6aec000 b6af2000 r-xp /usr/lib/libappsvc.so.0.1.0
b6af9000 b6afa000 rwxp /usr/lib/libappsvc.so.0.1.0
b6afa000 b6b19000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b20000 b6b21000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6b21000 b6b24000 r-xp /usr/lib/libsmack.so.1.0.0
b6b2b000 b6b2c000 rwxp /usr/lib/libsmack.so.1.0.0
b6b2c000 b6b31000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b39000 b6b3a000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b3a000 b6b64000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b6c000 b6b6d000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b6d000 b6b84000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b8c000 b6b8d000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b8d000 b6c21000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c29000 b6c2c000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c2c000 b6c2e000 rwxp /usr/lib/libstdc++.so.6.0.16
b6c34000 b6c3f000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c46000 b6c47000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c47000 b6c4c000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c54000 b6c55000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c55000 b6d25000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d25000 b6d26000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6d26000 b6d66000 r-xp /usr/lib/libeina.so.1.7.99
b6d6d000 b6d6e000 rwxp /usr/lib/libeina.so.1.7.99
b6d6f000 b6d85000 r-xp /usr/lib/libecore.so.1.7.99
b6d8c000 b6d8d000 rwxp /usr/lib/libecore.so.1.7.99
b6d9b000 b6da2000 r-xp /usr/lib/libvconf.so.0.2.45
b6daa000 b6dab000 rwxp /usr/lib/libvconf.so.0.2.45
b6dab000 b6db0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6db7000 b6db8000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6db8000 b6dc3000 r-xp /usr/lib/libaul.so.0.1.0
b6dcb000 b6dcc000 rwxp /usr/lib/libaul.so.0.1.0
b6dcd000 b6dd5000 r-xp /lib/libgcc_s-4.6.4.so.1
b6ddc000 b6ddd000 rwxp /lib/libgcc_s-4.6.4.so.1
b6ddd000 b6ddf000 r-xp /lib/libdl-2.13.so
b6de6000 b6de7000 r-xp /lib/libdl-2.13.so
b6de7000 b6de8000 rwxp /lib/libdl-2.13.so
b6de8000 b6df3000 r-xp /lib/libunwind.so.8.0.1
b6dfa000 b6dfb000 rwxp /lib/libunwind.so.8.0.1
b6e20000 b6f3b000 r-xp /lib/libc-2.13.so
b6f43000 b6f45000 r-xp /lib/libc-2.13.so
b6f45000 b6f46000 rwxp /lib/libc-2.13.so
b6f49000 b6f4f000 r-xp /lib/librt-2.13.so
b6f56000 b6f57000 r-xp /lib/librt-2.13.so
b6f57000 b6f58000 rwxp /lib/librt-2.13.so
b6f58000 b6f5a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f61000 b6f62000 rwxp /usr/lib/libdlog.so.0.0.0
b6f62000 b6f65000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f6c000 b6f6d000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f6d000 b6f70000 r-xp /usr/lib/libbundle.so.0.1.22
b6f77000 b6f78000 rwxp /usr/lib/libbundle.so.0.1.22
b6f78000 b6f7b000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f82000 b6f83000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f83000 b6f97000 r-xp /lib/libpthread-2.13.so
b6f9e000 b6f9f000 r-xp /lib/libpthread-2.13.so
b6f9f000 b6fa0000 rwxp /lib/libpthread-2.13.so
b6fb7000 b6fbb000 r-xp /usr/lib/libsys-assert.so
b6fc3000 b6fc4000 rwxp /usr/lib/libsys-assert.so
b6fc4000 b6fe1000 r-xp /lib/ld-2.13.so
b6fe8000 b6fe9000 r-xp /lib/ld-2.13.so
b6fe9000 b6fea000 rwxp /lib/ld-2.13.so
b6fea000 b6ff6000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6ffe000 b7000000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7ccf000 b7d14000 rwxp [heap]
befcb000 befec000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1513)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e92d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6e5f5b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6ef7b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6f59063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3d6 (0xb6fef05b) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x505b
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
bileap-efl)
07-13 23:43:38.120+0900 I/Tizen::App( 1074): (149) > app = [setting-mobileap-efl], package = [ug-setting-mobileap-efl]
07-13 23:43:38.130+0900 I/Tizen::App( 1074): (1360) > package(ug-setting-mobileap-efl), version(2.0.25), type(rpm), displayName(테더링), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(setting-mobileap-efl), storeClient(), appRootPath(/usr/apps/ug-setting-mobileap-efl)
07-13 23:43:38.140+0900 I/Tizen::App( 1074): (1360) > package(com.samsung.taskmgr), version(0.14.25), type(rpm), displayName(작업 전환기), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.taskmgr), storeClient(), appRootPath(/usr/apps/com.samsung.taskmgr)
07-13 23:43:38.140+0900 I/Tizen::App( 1074): (149) > app = [com.samsung.taskmgr], package = [com.samsung.taskmgr]
07-13 23:43:38.150+0900 I/Tizen::App( 1074): (1360) > package(com.samsung.taskmgr), version(0.14.25), type(rpm), displayName(작업 전환기), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.taskmgr), storeClient(), appRootPath(/usr/apps/com.samsung.taskmgr)
07-13 23:43:38.160+0900 I/Tizen::App( 1074): (1360) > package(com.samsung.mdm-syspopup), version(1.0.2), type(rpm), displayName(MDM System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mdm-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.mdm-syspopup)
07-13 23:43:38.170+0900 I/Tizen::App( 1074): (149) > app = [com.samsung.mdm-syspopup], package = [com.samsung.mdm-syspopup]
07-13 23:43:38.180+0900 I/Tizen::App( 1074): (1360) > package(com.samsung.mdm-syspopup), version(1.0.2), type(rpm), displayName(MDM System Popup), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(com.samsung.mdm-syspopup), storeClient(), appRootPath(/usr/apps/com.samsung.mdm-syspopup)
07-13 23:43:38.190+0900 I/Tizen::App( 1074): (1360) > package(sEvhOLMlQ7), version(0.0.15), type(wgt), displayName(Hungama), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sEvhOLMlQ7.hungama), storeClient(), appRootPath(/opt/usr/apps/sEvhOLMlQ7)
07-13 23:43:38.200+0900 I/Tizen::App( 1074): (149) > app = [sEvhOLMlQ7.hungama], package = [sEvhOLMlQ7]
07-13 23:43:38.210+0900 I/Tizen::App( 1074): (1360) > package(sEvhOLMlQ7), version(0.0.15), type(wgt), displayName(Hungama), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sEvhOLMlQ7.hungama), storeClient(), appRootPath(/opt/usr/apps/sEvhOLMlQ7)
07-13 23:43:38.220+0900 I/Tizen::App( 1074): (1360) > package(sjjevolsjk), version(1.0.0), type(tpk), displayName(Native Privileged API Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sjjevolsjk.osp-common-service), storeClient(), appRootPath(/opt/apps/sjjevolsjk)
07-13 23:43:38.230+0900 I/Tizen::App( 1074): (149) > app = [sjjevolsjk.osp-common-service], package = [sjjevolsjk]
07-13 23:43:38.240+0900 I/Tizen::App( 1074): (1360) > package(sjjevolsjk), version(1.0.0), type(tpk), displayName(Native Privileged API Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(sjjevolsjk.osp-common-service), storeClient(), appRootPath(/opt/apps/sjjevolsjk)
07-13 23:43:38.250+0900 I/Tizen::App( 1074): (1360) > package(57r43275q7), version(1.0.0), type(tpk), displayName(Native Network Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(57r43275q7.osp-connectivity-service), storeClient(), appRootPath(/opt/apps/57r43275q7)
07-13 23:43:38.260+0900 I/Tizen::App( 1074): (149) > app = [57r43275q7.osp-connectivity-service], package = [57r43275q7]
07-13 23:43:38.270+0900 I/Tizen::App( 1074): (1360) > package(57r43275q7), version(1.0.0), type(tpk), displayName(Native Network Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(57r43275q7.osp-connectivity-service), storeClient(), appRootPath(/opt/apps/57r43275q7)
07-13 23:43:38.280+0900 I/Tizen::App( 1074): (1360) > package(3qwk86ogmg), version(4.0.016), type(tpk), displayName(Polaris Viewer), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(3qwk86ogmg.PolarisOffice), storeClient(), appRootPath(/opt/apps/3qwk86ogmg)
07-13 23:43:38.290+0900 I/Tizen::App( 1074): (149) > app = [3qwk86ogmg.PolarisOffice], package = [3qwk86ogmg]
07-13 23:43:38.300+0900 I/Tizen::App( 1074): (1360) > package(3qwk86ogmg), version(4.0.016), type(tpk), displayName(Polaris Viewer), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(3qwk86ogmg.PolarisOffice), storeClient(), appRootPath(/opt/apps/3qwk86ogmg)
07-13 23:43:38.310+0900 I/Tizen::App( 1074): (1360) > package(EmbkcJFK7q), version(1.2.28), type(tpk), displayName(McAfee Security), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(EmbkcJFK7q.MMS), storeClient(), appRootPath(/opt/apps/EmbkcJFK7q)
07-13 23:43:38.320+0900 I/Tizen::App( 1074): (149) > app = [EmbkcJFK7q.MMS], package = [EmbkcJFK7q]
07-13 23:43:38.330+0900 I/Tizen::App( 1074): (1360) > package(EmbkcJFK7q), version(1.2.28), type(tpk), displayName(McAfee Security), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(EmbkcJFK7q.MMS), storeClient(), appRootPath(/opt/apps/EmbkcJFK7q)
07-13 23:43:38.340+0900 I/Tizen::App( 1074): (1360) > package(srfxzv8GKR), version(1.0.4), type(wgt), displayName(YouTube), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(srfxzv8GKR.YouTube), storeClient(), appRootPath(/opt/usr/apps/srfxzv8GKR)
07-13 23:43:38.350+0900 I/Tizen::App( 1074): (149) > app = [srfxzv8GKR.YouTube], package = [srfxzv8GKR]
07-13 23:43:38.360+0900 I/Tizen::App( 1074): (1360) > package(srfxzv8GKR), version(1.0.4), type(wgt), displayName(YouTube), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(srfxzv8GKR.YouTube), storeClient(), appRootPath(/opt/usr/apps/srfxzv8GKR)
07-13 23:43:38.370+0900 I/Tizen::App( 1074): (1360) > package(hyCsE05ySM), version(1.0.0), type(tpk), displayName(사용자 인증서), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(hyCsE05ySM.CertificateSelector), storeClient(), appRootPath(/opt/apps/hyCsE05ySM)
07-13 23:43:38.380+0900 I/Tizen::App( 1074): (149) > app = [hyCsE05ySM.CertificateSelector], package = [hyCsE05ySM]
07-13 23:43:38.380+0900 I/Tizen::App( 1074): (1360) > package(hyCsE05ySM), version(1.0.0), type(tpk), displayName(사용자 인증서), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(hyCsE05ySM.CertificateSelector), storeClient(), appRootPath(/opt/apps/hyCsE05ySM)
07-13 23:43:38.400+0900 I/Tizen::App( 1074): (1360) > package(q7097a278m), version(1.0.0), type(tpk), displayName(Native Security Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(q7097a278m.osp-security-service), storeClient(), appRootPath(/opt/apps/q7097a278m)
07-13 23:43:38.410+0900 I/Tizen::App( 1074): (149) > app = [q7097a278m.osp-security-service], package = [q7097a278m]
07-13 23:43:38.410+0900 I/Tizen::App( 1074): (1360) > package(q7097a278m), version(1.0.0), type(tpk), displayName(Native Security Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(q7097a278m.osp-security-service), storeClient(), appRootPath(/opt/apps/q7097a278m)
07-13 23:43:38.430+0900 I/Tizen::App( 1074): (1360) > package(cp7ipabg4k), version(1.0.0), type(tpk), displayName(Channel Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(cp7ipabg4k.osp-channel-service), storeClient(), appRootPath(/opt/apps/cp7ipabg4k)
07-13 23:43:38.440+0900 I/Tizen::App( 1074): (149) > app = [cp7ipabg4k.osp-channel-service], package = [cp7ipabg4k]
07-13 23:43:38.440+0900 I/Tizen::App( 1074): (1360) > package(cp7ipabg4k), version(1.0.0), type(tpk), displayName(Channel Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(cp7ipabg4k.osp-channel-service), storeClient(), appRootPath(/opt/apps/cp7ipabg4k)
07-13 23:43:38.460+0900 I/Tizen::App( 1074): (1360) > package(aospd00043), version(1.0.0), type(tpk), displayName(Native Application Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(aospd00043.osp-app-service), storeClient(), appRootPath(/opt/apps/aospd00043)
07-13 23:43:38.470+0900 I/Tizen::App( 1074): (149) > app = [aospd00043.osp-app-service], package = [aospd00043]
07-13 23:43:38.470+0900 I/Tizen::App( 1074): (1360) > package(aospd00043), version(1.0.0), type(tpk), displayName(Native Application Service), uninstallable(0), downloaded(0), updated(0), preloaded(1)movable(0), externalStorage(0), mainApp(aospd00043.osp-app-service), storeClient(), appRootPath(/opt/apps/aospd00043)
07-13 23:43:38.480+0900 D/ResourceType( 1531): calling getConfigurations
07-13 23:43:38.480+0900 D/ResourceType( 1531): called getConfigurations size=227
07-13 23:43:38.480+0900 I/ActivityManager( 1531): Config changed: { scale=1.0 imsi=0/0 loc=ko_KR touch=3 keys=1/1/2 nav=1/1 orien=1 layout=34 uiMode=17 seq=4}
07-13 23:43:38.490+0900 E/SurfaceFlinger( 1531): redraw failed: empty invalid region
07-13 23:43:38.490+0900 D/StatusBarService( 1798): repositionNavigationBar()
07-13 23:43:38.490+0900 E/AlarmManagerService( 1531): Unable to set kernel timezone to -540: Operation not permitted
07-13 23:43:38.510+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(true)
07-13 23:43:38.530+0900 E/SurfaceFlinger( 1531): redraw failed: empty invalid region
07-13 23:43:38.530+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(false)
07-13 23:43:38.540+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(true)
07-13 23:43:38.550+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(false)
07-13 23:43:38.560+0900 E/AlarmManagerService( 1531): Unable to set kernel timezone to -540: Operation not permitted
07-13 23:43:38.560+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(true)
07-13 23:43:38.570+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(false)
07-13 23:43:38.570+0900 I/AclService( 1074): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:43:38.570+0900 I/Tizen::System( 1074): (85) > Current Epoch is -5268531514644902246.
07-13 23:43:38.570+0900 I/Tizen::System( 1074): (89) > Calendar time is sec:38, min:43, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:43:38.570+0900 E/SurfaceFlinger( 1531): redraw failed: empty invalid region
07-13 23:43:38.570+0900 I/Tizen::System( 1074): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:43:38.580+0900 I/Tizen::System( 1074): (103) > Original Time is 2015 7/13, 14:43:38:584
07-13 23:43:38.580+0900 I/Tizen::System( 1074): (123) > Current Time is 2015 7/13, 23:43:38
07-13 23:43:38.580+0900 I/AclService( 1074): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 79258169 milliseconds from now
07-13 23:43:38.580+0900 I/AclService( 1074): void AclService::BootComplete()(1547) > Setting boot completed to true
07-13 23:43:38.600+0900 D/ACL     ( 1531): Deleted 1 old ringtone db entry
07-13 23:43:38.630+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-13 23:43:38.630+0900 I/Tizen::System( 1009): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-13 23:43:38.650+0900 I/Tizen::System( 1009): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-13 23:43:38.650+0900 I/Tizen::System( 1009): (426) > Result Code is E_SUCCESS.
07-13 23:43:38.650+0900 I/Tizen::System( 1009): (432) > Value is 1.
07-13 23:43:38.650+0900 I/Tizen::System( 1074): (637) > result is 1.
07-13 23:43:38.720+0900 D/ACL     ( 1531): Deleted 1 old ringtone db entry
07-13 23:43:38.770+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-13 23:43:38.770+0900 I/Tizen::Net::Wifi( 1047): (637) > OnGetWifiConnectionState with clientId : 1074, AppPkgId : ACL111OMWW
07-13 23:43:38.790+0900 D/WifiStateTracker( 1531): Tizen getWifiState state = 3
07-13 23:43:38.800+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-13 23:43:38.800+0900 I/Tizen::System( 1009): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-13 23:43:38.820+0900 I/Tizen::System( 1009): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-13 23:43:38.820+0900 I/Tizen::System( 1009): (426) > Result Code is E_SUCCESS.
07-13 23:43:38.820+0900 I/Tizen::System( 1009): (432) > Value is 1.
07-13 23:43:38.820+0900 I/Tizen::System( 1074): (637) > result is 1.
07-13 23:43:38.820+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-13 23:43:38.820+0900 I/Tizen::Net::Wifi( 1047): (637) > OnGetWifiConnectionState with clientId : 1074, AppPkgId : ACL111OMWW
07-13 23:43:38.850+0900 D/WifiStateTracker( 1531): Tizen getWifiState state = 3
07-13 23:43:38.850+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-13 23:43:38.850+0900 I/Tizen::System( 1009): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-13 23:43:38.870+0900 I/Tizen::System( 1009): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-13 23:43:38.870+0900 I/Tizen::System( 1009): (426) > Result Code is E_SUCCESS.
07-13 23:43:38.870+0900 I/Tizen::System( 1009): (432) > Value is 1.
07-13 23:43:38.870+0900 I/Tizen::System( 1074): (637) > result is 1.
07-13 23:43:38.880+0900 I/PowerManagerService-JNI( 1531): sending ACL screen state 'L'
07-13 23:43:38.880+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(true)
07-13 23:43:38.880+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-13 23:43:38.880+0900 I/Tizen::Net::Wifi( 1047): (637) > OnGetWifiConnectionState with clientId : 1074, AppPkgId : ACL111OMWW
07-13 23:43:38.910+0900 D/WifiStateTracker( 1531): Tizen getWifiState state = 3
07-13 23:43:38.910+0900 I/AclService( 1074): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-13 23:43:38.910+0900 I/Tizen::System( 1009): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-13 23:43:38.930+0900 I/Tizen::System( 1009): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-13 23:43:38.930+0900 I/Tizen::System( 1009): (426) > Result Code is E_SUCCESS.
07-13 23:43:38.940+0900 I/Tizen::System( 1009): (432) > Value is 1.
07-13 23:43:38.940+0900 I/Tizen::System( 1074): (637) > result is 1.
07-13 23:43:38.940+0900 I/PowerManagerService-JNI( 1531): sending ACL screen state 'F'
07-13 23:43:38.940+0900 I/Tizen::System( 1074): (461) > change cpu power policy: keepAwake(false)
07-13 23:43:40.280+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:41.610+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:42.490+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:43.550+0900 I/AclService( 1074): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-13 23:43:43.550+0900 I/Tizen::System( 1074): (85) > Current Epoch is 1436798623.
07-13 23:43:43.550+0900 I/Tizen::System( 1074): (89) > Calendar time is sec:43, min:43, hour:14, day:13, mon:6, year:115, wday1, year:193, dst:0
07-13 23:43:43.550+0900 I/Tizen::System( 1074): (99) > Current time zone is Asia/Seoul, 540, 60
07-13 23:43:43.550+0900 I/Tizen::System( 1074): (103) > Original Time is 2015 7/13, 14:43:43:566
07-13 23:43:43.550+0900 I/Tizen::System( 1074): (123) > Current Time is 2015 7/13, 23:43:43
07-13 23:43:43.550+0900 I/AclService( 1074): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 79259988 milliseconds from now
07-13 23:43:43.900+0900 W/ProcessStats( 1531): Skipping unknown process pid 3082
07-13 23:43:44.690+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:45.260+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:46.900+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:48.740+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:49.090+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:49.200+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:49.670+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:50.030+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:50.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:50.590+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:51.300+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:51.680+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 27
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:51.680+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:51.700+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(601) > __request_handler: 22
07-13 23:43:51.700+0900 W/AUL_AMD (  442): amd_request.c: __request_handler(803) > app status : 5
07-13 23:43:51.720+0900 I/APP_CORE(  863): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
07-13 23:43:51.720+0900 I/CAPI_APPFW_APPLICATION(  863): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
07-13 23:43:51.810+0900 I/CAPI_NETWORK_CONNECTION(  863): connection.c: connection_destroy(379) > Destroy handle: 0xb88c30d0
07-13 23:43:51.810+0900 I/CAPI_NETWORK_CONNECTION(  863): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-13 23:43:51.810+0900 I/EFL-ASSIST(  863): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8875a60) is freed
07-13 23:43:51.820+0900 I/EFL-ASSIST(  863): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b8865150) is freed
07-13 23:43:51.820+0900 E/TIZEN_N_SYSTEM_SETTINGS(  863): system_settings_vconf.c: system_setting_vconf_unset_changed_cb(278) > [system_setting_vconf_unset_changed_cb] vconf_ignore_key_changed : db/setting/accessibility/font_size --- ret = 0 --- callback ptr : b4cfddfd
07-13 23:43:51.820+0900 I/CAPI_APPFW_APPLICATION(  863): app_main.c: app_efl_exit(145) > app_efl_exit
07-13 23:43:51.820+0900 E/TBM_BACKEND(  863): tbm_bufmgr_sprd7727.c: tbm_sprd7727_bo_free(671) > [31m[data-provider-slave][libtbm-sprd7727:863] error tbm_sprd7727_bo_free:671
07-13 23:43:51.820+0900 E/TBM_BACKEND(  863): [0m
07-13 23:43:51.850+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(142) > dead_pid = 863 pgid = 863
07-13 23:43:51.850+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(123) > dead_pid(863)
07-13 23:43:51.850+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
07-13 23:43:51.850+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
07-13 23:43:51.850+0900 I/Tizen::App( 1009): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 863.
07-13 23:43:51.850+0900 I/AUL_AMD (  442): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 863
07-13 23:43:51.860+0900 I/Tizen::App(  943): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 863.
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:51.870+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:52.060+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:52.250+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:52.430+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:52.600+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:52.780+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:52.950+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:53.130+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:53.320+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:53.320+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:53.320+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:53.330+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:53.500+0900 I/tdlna   ( 1839): ssdp running
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:53.500+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:53.690+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:53.710+0900 W/AUL_AMD (  442): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:53.860+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:54.040+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-13 23:43:54.220+0900 I/MESSAGE_PORT(  377): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-13 23:43:54.450+0900 W/CRASH_MANAGER( 3265): worker.c: worker_job(1236) > 110151374646c143679863
