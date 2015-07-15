S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 3394
Date: 2015-07-14 16:26:39+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb7ea0000

Register Information
r0   = 0xb7ea0002, r1   = 0xb7ea0000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f415eb
r6   = 0xbe8bb7b8, r7   = 0xb7ea0002
r8   = 0x0000001e, r9   = 0xb64604d0
r10  = 0xb6f415cc, fp   = 0xbe8bb7ac
ip   = 0x00000000, sp   = 0xbe8bb248
lr   = 0xb6dac5b8, pc   = 0xb6ddfd64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     28280 KB
Buffers:     27592 KB
Cached:     269396 KB
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
VmPTE:          20 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3394 TID = 3394
3394 3400 

Maps Information
b5c60000 b6463000 rwxp [stack:3400]
b6463000 b6466000 r-xp /lib/libgpg-error.so.0.5.0
b646d000 b646e000 rwxp /lib/libgpg-error.so.0.5.0
b646e000 b64c6000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64cd000 b64d0000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64d1000 b64fd000 r-xp /usr/lib/libsystemd.so.0.0.1
b6504000 b6505000 r-xp /usr/lib/libsystemd.so.0.0.1
b6505000 b6506000 rwxp /usr/lib/libsystemd.so.0.0.1
b6506000 b6508000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b650f000 b6510000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6510000 b65db000 r-xp /usr/lib/libxml2.so.2.7.8
b65e3000 b65e8000 rwxp /usr/lib/libxml2.so.2.7.8
b65e9000 b65f9000 r-xp /lib/libresolv-2.13.so
b65f9000 b65fa000 r-xp /lib/libresolv-2.13.so
b65fa000 b65fb000 rwxp /lib/libresolv-2.13.so
b65fe000 b6614000 r-xp /lib/libz.so.1.2.5
b661b000 b661c000 rwxp /lib/libz.so.1.2.5
b661c000 b661e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6625000 b6626000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b6626000 b662b000 r-xp /usr/lib/libffi.so.5.0.10
b6632000 b6633000 rwxp /usr/lib/libffi.so.5.0.10
b6633000 b6634000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b663b000 b663c000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b663c000 b66a1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66a8000 b66ab000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66ac000 b66af000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66b6000 b66b7000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66b7000 b685f000 r-xp /usr/lib/libcrypto.so.1.0.0
b6866000 b687b000 rwxp /usr/lib/libcrypto.so.1.0.0
b687f000 b6895000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b689c000 b689d000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b689d000 b68d1000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68d8000 b68da000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b68da000 b69ae000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69b6000 b69b9000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69bb000 b69bf000 r-xp /usr/lib/libchromium.so.1.0
b69c6000 b69c7000 rwxp /usr/lib/libchromium.so.1.0
b69c7000 b6a30000 r-xp /lib/libm-2.13.so
b6a37000 b6a38000 r-xp /lib/libm-2.13.so
b6a38000 b6a39000 rwxp /lib/libm-2.13.so
b6a39000 b6a3f000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a46000 b6a47000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a47000 b6a66000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a6d000 b6a6e000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a6e000 b6a71000 r-xp /usr/lib/libsmack.so.1.0.0
b6a78000 b6a79000 rwxp /usr/lib/libsmack.so.1.0.0
b6a79000 b6a7e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6a86000 b6a87000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6a87000 b6ab1000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6ab9000 b6aba000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6aba000 b6ad1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6ad9000 b6ada000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6ada000 b6b6e000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b76000 b6b79000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b79000 b6b7b000 rwxp /usr/lib/libstdc++.so.6.0.16
b6b81000 b6b8c000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6b93000 b6b94000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6b94000 b6b99000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6ba1000 b6ba2000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6ba2000 b6c72000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c72000 b6c73000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c73000 b6cb3000 r-xp /usr/lib/libeina.so.1.7.99
b6cba000 b6cbb000 rwxp /usr/lib/libeina.so.1.7.99
b6cbc000 b6cd2000 r-xp /usr/lib/libecore.so.1.7.99
b6cd9000 b6cda000 rwxp /usr/lib/libecore.so.1.7.99
b6ce8000 b6cef000 r-xp /usr/lib/libvconf.so.0.2.45
b6cf7000 b6cf8000 rwxp /usr/lib/libvconf.so.0.2.45
b6cf8000 b6cfd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d04000 b6d05000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d05000 b6d10000 r-xp /usr/lib/libaul.so.0.1.0
b6d18000 b6d19000 rwxp /usr/lib/libaul.so.0.1.0
b6d1a000 b6d22000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d29000 b6d2a000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d2a000 b6d2c000 r-xp /lib/libdl-2.13.so
b6d33000 b6d34000 r-xp /lib/libdl-2.13.so
b6d34000 b6d35000 rwxp /lib/libdl-2.13.so
b6d35000 b6d40000 r-xp /lib/libunwind.so.8.0.1
b6d47000 b6d48000 rwxp /lib/libunwind.so.8.0.1
b6d6d000 b6e88000 r-xp /lib/libc-2.13.so
b6e90000 b6e92000 r-xp /lib/libc-2.13.so
b6e92000 b6e93000 rwxp /lib/libc-2.13.so
b6e96000 b6e9c000 r-xp /lib/librt-2.13.so
b6ea3000 b6ea4000 r-xp /lib/librt-2.13.so
b6ea4000 b6ea5000 rwxp /lib/librt-2.13.so
b6ea5000 b6ea7000 r-xp /usr/lib/libdlog.so.0.0.0
b6eae000 b6eaf000 rwxp /usr/lib/libdlog.so.0.0.0
b6eaf000 b6eb2000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6eb9000 b6eba000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6eba000 b6ebd000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec4000 b6ec5000 rwxp /usr/lib/libbundle.so.0.1.22
b6ec5000 b6ec8000 r-xp /usr/lib/libappcore-agent.so.1.1
b6ecf000 b6ed0000 rwxp /usr/lib/libappcore-agent.so.1.1
b6ed0000 b6ee4000 r-xp /lib/libpthread-2.13.so
b6eeb000 b6eec000 r-xp /lib/libpthread-2.13.so
b6eec000 b6eed000 rwxp /lib/libpthread-2.13.so
b6f04000 b6f08000 r-xp /usr/lib/libsys-assert.so
b6f10000 b6f11000 rwxp /usr/lib/libsys-assert.so
b6f11000 b6f2e000 r-xp /lib/ld-2.13.so
b6f35000 b6f36000 r-xp /lib/ld-2.13.so
b6f36000 b6f37000 rwxp /lib/ld-2.13.so
b6f37000 b6f44000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f4b000 b6f4d000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b8284000 b82c9000 rwxp [heap]
be89c000 be8bd000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3394)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6ddfd64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6dac5b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e44b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ea6063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x43a (0xb6f3c0a3) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x50a3
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
7-14 16:25:55.350+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(false)
07-14 16:25:55.360+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(true)
07-14 16:25:55.370+0900 E/cluster-home(  595): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 16:25:55.370+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(true)
07-14 16:25:55.370+0900 E/cluster-home(  595): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 16:25:55.380+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(false)
07-14 16:25:55.380+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 16:25:55.380+0900 I/Tizen::System( 1134): (85) > Current Epoch is -5268109302179776125.
07-14 16:25:55.380+0900 I/Tizen::System( 1134): (89) > Calendar time is sec:55, min:25, hour:7, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 16:25:55.380+0900 I/Tizen::System( 1134): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 16:25:55.380+0900 I/Tizen::System( 1134): (103) > Original Time is 2015 7/14, 7:25:55:385
07-14 16:25:55.380+0900 I/Tizen::System( 1134): (123) > Current Time is 2015 7/14, 16:25:55
07-14 16:25:55.380+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 79255773 milliseconds from now
07-14 16:25:55.380+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 16:25:55.380+0900 I/Tizen::System( 1063): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 16:25:55.390+0900 E/cluster-home(  595): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 16:25:55.400+0900 I/Tizen::System( 1063): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 16:25:55.400+0900 I/Tizen::System( 1063): (426) > Result Code is E_SUCCESS.
07-14 16:25:55.400+0900 I/Tizen::System( 1063): (432) > Value is 1.
07-14 16:25:55.400+0900 I/Tizen::System( 1134): (637) > result is 1.
07-14 16:25:55.400+0900 I/AclService( 1134): void AclService::BootComplete()(1547) > Setting boot completed to true
07-14 16:25:55.410+0900 I/Tizen::Shell( 1134): (73) > Enter.
07-14 16:25:55.410+0900 I/Tizen::Shell( 1134): (47) > Enter.
07-14 16:25:55.410+0900 I/Tizen::Shell( 1134): (93) > LockManager is constructed.
07-14 16:25:55.410+0900 E/cluster-home(  595): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 16:25:55.410+0900 I/Tizen::Shell( 1134): (58) > Exit.
07-14 16:25:55.410+0900 I/Tizen::Shell( 1134): (81) > Exit.
07-14 16:25:55.410+0900 I/Tizen::Shell( 1134): (95) > Enter.
07-14 16:25:55.410+0900 I/Tizen::App( 1134): (109) > Succeeded in connecting service(osp.shell.ipcserver.lockmanager)
07-14 16:25:55.420+0900 I/Tizen::App( 1022): (147) > _LockManagerStub::OnIpcClientConnected (clientId:1134)
07-14 16:25:55.420+0900 I/Tizen::App( 1022): (124) > app(ACL111OMWW.AclService), clientId(1134)
07-14 16:25:55.420+0900 E/cluster-home(  595): cluster-data-list.cpp: GetDBoxID(1096) >  found id[2]
07-14 16:25:55.460+0900 D/ACL     ( 1419): Deleted 1 old ringtone db entry
07-14 16:25:55.500+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-14 16:25:55.500+0900 I/Tizen::Net::Wifi( 1092): (637) > OnGetWifiConnectionState with clientId : 1134, AppPkgId : ACL111OMWW
07-14 16:25:55.540+0900 D/WifiStateTracker( 1419): Tizen getWifiState state = 3
07-14 16:25:55.540+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 16:25:55.540+0900 I/Tizen::System( 1063): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 16:25:55.560+0900 I/Tizen::System( 1063): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 16:25:55.560+0900 I/Tizen::System( 1063): (426) > Result Code is E_SUCCESS.
07-14 16:25:55.560+0900 I/Tizen::System( 1063): (432) > Value is 1.
07-14 16:25:55.560+0900 I/Tizen::System( 1134): (637) > result is 1.
07-14 16:25:55.570+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-14 16:25:55.570+0900 I/Tizen::Net::Wifi( 1092): (637) > OnGetWifiConnectionState with clientId : 1134, AppPkgId : ACL111OMWW
07-14 16:25:55.600+0900 D/WifiStateTracker( 1419): Tizen getWifiState state = 3
07-14 16:25:55.600+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 16:25:55.600+0900 I/Tizen::System( 1063): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 16:25:55.630+0900 I/Tizen::System( 1063): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 16:25:55.630+0900 I/Tizen::System( 1063): (426) > Result Code is E_SUCCESS.
07-14 16:25:55.630+0900 I/Tizen::System( 1063): (432) > Value is 1.
07-14 16:25:55.630+0900 I/Tizen::System( 1134): (637) > result is 1.
07-14 16:25:55.630+0900 I/PowerManagerService-JNI( 1419): sending ACL screen state 'L'
07-14 16:25:55.630+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(true)
07-14 16:25:55.630+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001c (28)
07-14 16:25:55.640+0900 I/Tizen::Net::Wifi( 1092): (637) > OnGetWifiConnectionState with clientId : 1134, AppPkgId : ACL111OMWW
07-14 16:25:55.670+0900 D/WifiStateTracker( 1419): Tizen getWifiState state = 3
07-14 16:25:55.670+0900 I/AclService( 1134): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x7001a (26)
07-14 16:25:55.670+0900 I/Tizen::System( 1063): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
07-14 16:25:55.700+0900 I/Tizen::System( 1063): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
07-14 16:25:55.700+0900 I/Tizen::System( 1063): (426) > Result Code is E_SUCCESS.
07-14 16:25:55.700+0900 I/Tizen::System( 1063): (432) > Value is 1.
07-14 16:25:55.700+0900 I/Tizen::System( 1134): (637) > result is 1.
07-14 16:25:55.700+0900 I/PowerManagerService-JNI( 1419): sending ACL screen state 'F'
07-14 16:25:55.700+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(false)
07-14 16:26:00.000+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 16:26:00.000+0900 I/Tizen::Base::Runtime( 1134): (251) > The timer is not started.
07-14 16:26:00.000+0900 I/Tizen::System( 1134): (85) > Current Epoch is 1436858760.
07-14 16:26:00.000+0900 I/PowerManagerService-JNI( 1419): sending ACL screen state 'L'
07-14 16:26:00.000+0900 I/Tizen::System( 1134): (89) > Calendar time is sec:0, min:26, hour:7, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 16:26:00.000+0900 I/Tizen::System( 1134): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 16:26:00.000+0900 I/Tizen::System( 1134): (103) > Original Time is 2015 7/14, 7:26:0:7
07-14 16:26:00.000+0900 I/Tizen::System( 1134): (123) > Current Time is 2015 7/14, 16:26:0
07-14 16:26:00.000+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 70439993 milliseconds from now
07-14 16:26:00.000+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(true)
07-14 16:26:00.010+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 16:26:00.010+0900 I/Tizen::System( 1134): (85) > Current Epoch is 1436858760.
07-14 16:26:00.010+0900 I/Tizen::System( 1134): (89) > Calendar time is sec:0, min:26, hour:7, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 16:26:00.010+0900 I/Tizen::System( 1134): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 16:26:00.010+0900 I/Tizen::System( 1134): (103) > Original Time is 2015 7/14, 7:26:0:11
07-14 16:26:00.010+0900 I/Tizen::System( 1134): (123) > Current Time is 2015 7/14, 16:26:0
07-14 16:26:00.010+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59989 milliseconds from now
07-14 16:26:00.020+0900 I/PowerManagerService-JNI( 1419): sending ACL screen state 'F'
07-14 16:26:00.020+0900 I/Tizen::System( 1134): (461) > change cpu power policy: keepAwake(false)
07-14 16:26:00.030+0900 E/SurfaceFlinger( 1419): redraw failed: empty invalid region
07-14 16:26:00.380+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 16:26:00.380+0900 I/Tizen::System( 1134): (85) > Current Epoch is 1436858760.
07-14 16:26:00.380+0900 I/Tizen::System( 1134): (89) > Calendar time is sec:0, min:26, hour:7, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 16:26:00.380+0900 I/Tizen::System( 1134): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 16:26:00.380+0900 I/Tizen::System( 1134): (103) > Original Time is 2015 7/14, 7:26:0:384
07-14 16:26:00.380+0900 I/Tizen::System( 1134): (123) > Current Time is 2015 7/14, 16:26:0
07-14 16:26:00.380+0900 I/AclService( 1134): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 79259987 milliseconds from now
07-14 16:26:00.640+0900 W/ProcessStats( 1419): Skipping unknown process pid 2914
07-14 16:26:08.700+0900 W/cluster-view(  595): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 16:26:09.280+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 16:26:09.370+0900 E/RESOURCED(  751): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
07-14 16:26:09.370+0900 I/Tizen::App( 1063): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 3350.
07-14 16:26:09.380+0900 I/Tizen::App( 1022): (499) > LaunchedApp(rMfxc1AKe2.tdlnaWeb)
07-14 16:26:09.380+0900 I/Tizen::App( 1022): (733) > Finished invoking application event listener for rMfxc1AKe2.tdlnaWeb, 3350.
07-14 16:26:09.390+0900 E/RESOURCED(  751): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 344
07-14 16:26:09.480+0900 I/UXT     ( 3354): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 16:26:09.510+0900 I/EFL-ASSIST( 3354): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (f79590) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:26:09.510+0900 I/EFL-ASSIST( 3354): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (f79590) is freed
07-14 16:26:09.520+0900 I/EFL-ASSIST( 3354): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (f79590) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:26:09.520+0900 I/EFL-ASSIST( 3354): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (f79590) is freed
07-14 16:26:09.520+0900 I/UXT     ( 3350): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 16:26:09.570+0900 E/PKGMGR_INFO( 3350): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 16:26:09.570+0900 I/APP_CORE( 3350): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 16:26:09.570+0900 I/APP_CORE( 3350): appcore-efl.c: __do_app(511) > [APP 3350] Initial Launching, call the resume_cb
07-14 16:26:09.690+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 16:26:09.690+0900 W/AUL_AMD (  465): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 16:26:09.690+0900 W/AUL_AMD (  465): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 16:26:09.740+0900 I/AUL     ( 3354): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:26:09.740+0900 E/EFL     ( 3350): elementary<3350> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0x1071390 as sub object of 0x10710d0
07-14 16:26:09.760+0900 E/WEBKIT  ( 3350): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 16:26:09.790+0900 I/CAPI_NETWORK_CONNECTION( 3350): connection.c: connection_create(363) > New handle created[0x10ae9a8]
07-14 16:26:09.790+0900 I/CAPI_NETWORK_CONNECTION( 3350): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 16:26:09.790+0900 I/CAPI_NETWORK_CONNECTION( 3350): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 16:26:09.790+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3350): system_settings.c: system_settings_set_changed_cb(541) > b3e732b1
07-14 16:26:09.790+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3350): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3e71d99
07-14 16:26:09.820+0900 I/EFL-ASSIST( 3350): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [fc3838]
07-14 16:26:09.820+0900 I/EFL-ASSIST( 3350): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (f6cc18) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:26:09.830+0900 I/EFL-ASSIST( 3350): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (f6cc18) is freed
07-14 16:26:09.920+0900 E/EFL     ( 3354): edje<3354> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 16:26:09.980+0900 E/EFL     ( 3350): evas_main<3350> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 16:26:09.990+0900 E/EFL     ( 3350): evas_main<3350> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 16:26:10.090+0900 W/PROCESSMGR(  375): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3350
07-14 16:26:10.130+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 16:26:10.140+0900 W/APP_CORE( 3350): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6e00003
07-14 16:26:10.150+0900 I/indicator(  495): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 3350"
07-14 16:26:10.160+0900 I/MALI    (  595): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb1f35988] swap changed from sync to async
07-14 16:26:10.170+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 16:26:10.180+0900 I/Tizen::System( 1134): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 16:26:10.190+0900 I/Tizen::System( 1063): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 16:26:10.190+0900 I/Tizen::Io( 1063): (729) > Entry not found
07-14 16:26:10.200+0900 I/Tizen::System( 1063): (157) > change brightness system value.
07-14 16:26:10.240+0900 I/CAPI_APPFW_APPLICATION(  595): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 16:26:10.240+0900 E/cluster-home(  595): homescreen-main.cpp: app_pause(355) >  app pause
07-14 16:26:10.490+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.520+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.520+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.520+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.530+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.540+0900 I/UXT     ( 3377): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 16:26:10.560+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.560+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.560+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.570+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.600+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.600+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.600+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.610+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.630+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.630+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.630+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.640+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.660+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.660+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.660+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.690+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.700+0900 I/EFL-ASSIST( 3377): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (f69298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:26:10.700+0900 I/EFL-ASSIST( 3377): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (f69298) is freed
07-14 16:26:10.710+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.710+0900 I/EFL-ASSIST( 3377): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (f69298) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 16:26:10.710+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.710+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.720+0900 I/EFL-ASSIST( 3377): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (f69298) is freed
07-14 16:26:10.730+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.750+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.750+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.750+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:10.760+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.770+0900 I/AUL     ( 3351): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 16:26:10.780+0900 E/AUL     ( 3351): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 16:26:10.780+0900 E/AUL     ( 3351): aul_path.c: __get_path(170) > root_path is NULL!
07-14 16:26:11.230+0900 E/WEBKIT  ( 3350): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 16:26:12.600+0900 I/MALI    ( 3350): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xfefaf0] swap changed from async to sync
07-14 16:26:12.930+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 16:26:13.120+0900 E/PKGMGR_INFO( 3354): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 16:26:13.230+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 16:26:13.240+0900 I/AUL     (  465): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:26:13.260+0900 W/AUL_AMD (  465): amd_launch.c: service_start(515) > child process: 3394
07-14 16:26:13.310+0900 W/AUL_AMD (  465): amd_launch.c: __send_app_launch_signal(357) > send launch signal done: 3394
07-14 16:26:13.330+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 16:26:13.340+0900 I/Tizen::App( 1063): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 3394.
07-14 16:26:13.340+0900 I/Tizen::App( 1022): (499) > LaunchedApp(org.tizen.tdlnaservice)
07-14 16:26:13.340+0900 I/Tizen::App( 1022): (733) > Finished invoking application event listener for org.tizen.tdlnaservice, 3394.
07-14 16:26:13.360+0900 I/tdlna   ( 3394): _on_create_cb 실행
07-14 16:26:13.360+0900 I/tdlna   ( 3394): _app_init 실행
07-14 16:26:13.360+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 16:26:13.380+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 16:26:13.380+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 3394
07-14 16:26:13.420+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.450+0900 D/tdlnaservice( 3394): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
07-14 16:26:13.450+0900 I/tdlna   ( 3394): _on_app_control_callback 실행
07-14 16:26:13.450+0900 I/tdlna   ( 3394): _app_timer_thread_func 실행
07-14 16:26:13.530+0900 E/PKGMGR_INFO( 3354): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 16:26:13.830+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 16:26:13.830+0900 I/AUL     (  392): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:26:13.830+0900 I/AUL     ( 3354): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 16:26:13.840+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 16:26:13.840+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 3354
07-14 16:26:13.850+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:13.860+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.870+0900 D/tdlnaservice( 3394): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 16:26:13.870+0900 I/tdlna   ( 3394): _on_proxy_client_msg_received_cb 실행
07-14 16:26:13.870+0900 I/tdlna   ( 3394): _app_process_received_message 실행
07-14 16:26:13.870+0900 I/tdlna   ( 3394): _app_execute_operation 실행
07-14 16:26:13.870+0900 I/tdlna   ( 3394): _app_send_response 실행
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:26:13.870+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.870+0900 D/tdlnaservice( 3394): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:13.910+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.930+0900 D/tdlnaservice( 3394): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 16:26:13.930+0900 I/tdlna   ( 3394): _on_proxy_client_msg_received_cb 실행
07-14 16:26:13.930+0900 I/tdlna   ( 3394): _app_process_received_message 실행
07-14 16:26:13.930+0900 I/tdlna   ( 3394): _app_execute_operation 실행
07-14 16:26:13.930+0900 D/tdlnaservice( 3394): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 16:26:13.930+0900 I/tdlna   ( 3394): _app_run_timer 실행
07-14 16:26:13.930+0900 I/tdlna   ( 3394): _app_run_timer 실행
07-14 16:26:13.930+0900 I/tdlna   ( 3394): _app_send_response 실행
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:26:13.930+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:13.930+0900 D/tdlnaservice( 3394): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:13.960+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:16.490+0900 W/BROWSER_PROVIDER(  982): browser-provider-requests-manager.c: bp_thread_requests_manager(894) > Expire Idle state. No Client.
07-14 16:26:16.490+0900 W/BROWSER_PROVIDER(  982): browser-provider-requests-manager.c: bp_thread_requests_manager(903) > terminate main thread ...
07-14 16:26:16.490+0900 W/BROWSER_PROVIDER(  982): browser-provider-main.c: main(178) > Browser-Provider will be terminated.
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:26:24.440+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:24.440+0900 D/tdlnaservice( 3394): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 16:26:24.440+0900 I/tdlna   ( 3394): _on_proxy_client_msg_received_cb 실행
07-14 16:26:24.440+0900 I/tdlna   ( 3394): _app_process_received_message 실행
07-14 16:26:24.440+0900 I/tdlna   ( 3394): test _ _app_process_received_message
07-14 16:26:24.440+0900 I/tdlna   ( 3394): _app_execute_operation 실행
07-14 16:26:24.440+0900 I/tdlna   ( 3394): test 실행
07-14 16:26:24.440+0900 I/tdlna   ( 3394): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 16:26:24.440+0900 I/tdlna   ( 3394): Main Start !!! 1
07-14 16:26:24.440+0900 I/tdlna   ( 3394): Service Start !!! 1
07-14 16:26:24.440+0900 I/tdlna   ( 3394): shttpl - 17
07-14 16:26:24.440+0900 I/tdlna   ( 3394): fork 전
07-14 16:26:24.440+0900 I/tdlna   ( 3394): Main precess Start !! 1
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 16:26:24.830+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 16:26:33.980+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_task_manager.c: _service_task_manager_is_no_task_ongoing(720) > [0;35m* Info * Lets check ongoing request....[0;m
07-14 16:26:33.980+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_task_manager.c: __release_power_lock(669) > [0;35m* Info * No Ongoing Task[0;m
07-14 16:26:33.980+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_task_manager.c: __release_power_lock(671) > [0;35m* Info * power lock is already released![0;m
07-14 16:26:33.980+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_main.c: ___g_destroy_timer_expire_cb(263) > [0;35m* Info * Destory Cloud content sync as there is no task ongoing....[0;m
07-14 16:26:33.990+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 1 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 2 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_account_manager.c: _server_account_manager_get_first_sync_failed(609) > [0;35m* Info * content_type : 64 _server_account_manager_get_first_sync_failed - 0[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_notification_manager.c: __event_handler(639) > [0;35m* Info * -----------Notification manager exited-----------[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_main.c: _cloud_content_sync_deactivate(250) > [0;35m* Info * exiting cloud-content-sync-server[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_main.c: __init_cloud_content_sync(429) > [0;35m* Info * -------------------- Exit cloud server ------------------[0;m
07-14 16:26:34.000+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_task_manager.c: __event_handler(324) > [0;35m* Info * Dummy Request - break from loop [0;m
07-14 16:26:34.000+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 1290): media_content.c: media_content_disconnect(942) > [32m[1290]ref count changed to: 0
07-14 16:26:34.010+0900 I/CLOUD_CONTENT_SYNC_SERVER( 1290): cs_server_dispatch_manager.c: _server_dispatch_manager_deinit(515) > [0;35m* Info * wait at join[0;m
07-14 16:26:34.010+0900 I/CLOUD_CONTENT_SYNC_TRANS( 1290): cs_transport_async_req_handler.c: __event_handler(112) > [0;35m* Info * Dummy Request - break from loop [0;m
07-14 16:26:34.010+0900 I/CAPI_NETWORK_CONNECTION( 1290): connection.c: connection_destroy(379) > Destroy handle: 0xb7224fa0
07-14 16:26:34.010+0900 I/CAPI_NETWORK_CONNECTION( 1290): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
07-14 16:26:34.010+0900 I/CAPI_NETWORK_CONNECTION( 1290): connection.c: __connection_set_proxy_changed_callback(331) > Successfully de-registered(0)
07-14 16:26:34.020+0900 I/CAPI_APPFW_APPLICATION( 1290): service_app_main.c: service_app_exit_without_restart(108) > service_app_exit_without_restart
07-14 16:26:34.030+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 16:26:34.030+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(803) > app status : 7
07-14 16:26:34.030+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 22
07-14 16:26:34.030+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(803) > app status : 5
07-14 16:26:34.170+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 16:26:34.170+0900 W/AUL_AMD (  465): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
07-14 16:26:34.170+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 1290
07-14 16:26:34.170+0900 W/AUL_AMD (  465): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 16:26:34.170+0900 I/AUL_AMD (  465): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 1290
07-14 16:26:34.170+0900 I/Tizen::System( 1063): (246) > Terminated app [com.samsung.cloud-content-sync-server]
07-14 16:26:34.170+0900 I/Tizen::Io( 1063): (729) > Entry not found
07-14 16:26:34.170+0900 I/Tizen::App( 1022): (243) > App[com.samsung.cloud-content-sync-server] pid[1290] terminate event is forwarded
07-14 16:26:34.170+0900 I/Tizen::System( 1022): (256) > osp.accessorymanager.service provider is found.
07-14 16:26:34.170+0900 I/Tizen::System( 1022): (196) > Accessory Owner is removed [com.samsung.cloud-content-sync-server, 1290, ]
07-14 16:26:34.170+0900 I/Tizen::System( 1022): (256) > osp.system.service provider is found.
07-14 16:26:34.170+0900 I/Tizen::App( 1022): (506) > TerminatedApp(com.samsung.cloud-content-sync-server)
07-14 16:26:34.170+0900 I/Tizen::App( 1022): (512) > Not registered pid(1290)
07-14 16:26:34.170+0900 I/Tizen::App( 1022): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 1290.
07-14 16:26:34.180+0900 I/Tizen::System( 1063): (157) > change brightness system value.
07-14 16:26:34.180+0900 I/Tizen::App( 1063): (782) > Finished invoking application event listener for com.samsung.cloud-content-sync-server, 1290.
07-14 16:26:34.190+0900 E/AUL     ( 3483): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
07-14 16:26:36.030+0900 W/AUL_AMD (  465): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 16:26:39.690+0900 E/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 16:26:39.690+0900 E/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(3394) are closed. delete client info
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 16:26:39.690+0900 E/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  3394
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.690+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 16:26:39.710+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 16:26:39.710+0900 W/AUL_AMD (  465): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 16:26:39.710+0900 W/AUL_AMD (  465): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 3394
07-14 16:26:39.710+0900 W/AUL_AMD (  465): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 16:26:39.710+0900 I/AUL_AMD (  465): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 3394
07-14 16:26:39.710+0900 I/Tizen::System( 1063): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 16:26:39.710+0900 I/Tizen::Io( 1063): (729) > Entry not found
07-14 16:26:39.720+0900 I/Tizen::App( 1022): (243) > App[org.tizen.tdlnaservice] pid[3394] terminate event is forwarded
07-14 16:26:39.720+0900 I/Tizen::System( 1022): (256) > osp.accessorymanager.service provider is found.
07-14 16:26:39.720+0900 I/Tizen::System( 1022): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 3394, ]
07-14 16:26:39.720+0900 I/Tizen::System( 1022): (256) > osp.system.service provider is found.
07-14 16:26:39.720+0900 I/Tizen::App( 1022): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 16:26:39.720+0900 I/Tizen::App( 1022): (512) > Not registered pid(3394)
07-14 16:26:39.720+0900 I/Tizen::App( 1022): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 3394.
07-14 16:26:39.720+0900 I/Tizen::System( 1063): (157) > change brightness system value.
07-14 16:26:39.720+0900 I/Tizen::App( 1063): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 3394.
07-14 16:26:39.770+0900 W/CRASH_MANAGER( 3507): worker.c: worker_job(1236) > 110339474646c143685879
