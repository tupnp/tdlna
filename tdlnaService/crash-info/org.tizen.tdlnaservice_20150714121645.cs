S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 31602
Date: 2015-07-14 12:16:45+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x66c10000

Register Information
r0   = 0x66c10002, r1   = 0x66c10000
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6f675a3
r6   = 0xb5c83458, r7   = 0x66c10002
r8   = 0x0000001e, r9   = 0xb5c846f0
r10  = 0xb6f67584, fp   = 0xb5c8344c
ip   = 0x00000000, sp   = 0xb5c82ee8
lr   = 0xb6dd25b8, pc   = 0xb6e05d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     27056 KB
Buffers:     23644 KB
Cached:     212200 KB
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
PID = 31602 TID = 4934
31602 31604 4934 

Maps Information
b5486000 b5c85000 rwxp [stack:4934]
b5c86000 b6489000 rwxp [stack:31604]
b6489000 b648c000 r-xp /lib/libgpg-error.so.0.5.0
b6493000 b6494000 rwxp /lib/libgpg-error.so.0.5.0
b6494000 b64ec000 r-xp /usr/lib/libgcrypt.so.11.5.3
b64f3000 b64f6000 rwxp /usr/lib/libgcrypt.so.11.5.3
b64f7000 b6523000 r-xp /usr/lib/libsystemd.so.0.0.1
b652a000 b652b000 r-xp /usr/lib/libsystemd.so.0.0.1
b652b000 b652c000 rwxp /usr/lib/libsystemd.so.0.0.1
b652c000 b652e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6535000 b6536000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b6536000 b6601000 r-xp /usr/lib/libxml2.so.2.7.8
b6609000 b660e000 rwxp /usr/lib/libxml2.so.2.7.8
b660f000 b661f000 r-xp /lib/libresolv-2.13.so
b661f000 b6620000 r-xp /lib/libresolv-2.13.so
b6620000 b6621000 rwxp /lib/libresolv-2.13.so
b6624000 b663a000 r-xp /lib/libz.so.1.2.5
b6641000 b6642000 rwxp /lib/libz.so.1.2.5
b6642000 b6644000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b664b000 b664c000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b664c000 b6651000 r-xp /usr/lib/libffi.so.5.0.10
b6658000 b6659000 rwxp /usr/lib/libffi.so.5.0.10
b6659000 b665a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6661000 b6662000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b6662000 b66c7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b66ce000 b66d1000 rwxp /usr/lib/libsqlite3.so.0.8.6
b66d2000 b66d5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66dc000 b66dd000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b66dd000 b6885000 r-xp /usr/lib/libcrypto.so.1.0.0
b688c000 b68a1000 rwxp /usr/lib/libcrypto.so.1.0.0
b68a5000 b68bb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68c2000 b68c3000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b68c3000 b68f7000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68fe000 b6900000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6900000 b69d4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b69dc000 b69df000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b69e1000 b69e5000 r-xp /usr/lib/libchromium.so.1.0
b69ec000 b69ed000 rwxp /usr/lib/libchromium.so.1.0
b69ed000 b6a56000 r-xp /lib/libm-2.13.so
b6a5d000 b6a5e000 r-xp /lib/libm-2.13.so
b6a5e000 b6a5f000 rwxp /lib/libm-2.13.so
b6a5f000 b6a65000 r-xp /usr/lib/libappsvc.so.0.1.0
b6a6c000 b6a6d000 rwxp /usr/lib/libappsvc.so.0.1.0
b6a6d000 b6a8c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6a93000 b6a94000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6a94000 b6a97000 r-xp /usr/lib/libsmack.so.1.0.0
b6a9e000 b6a9f000 rwxp /usr/lib/libsmack.so.1.0.0
b6a9f000 b6aa4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6aac000 b6aad000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6aad000 b6ad7000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6adf000 b6ae0000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6ae0000 b6af7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6aff000 b6b00000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b00000 b6b94000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b9c000 b6b9f000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b9f000 b6ba1000 rwxp /usr/lib/libstdc++.so.6.0.16
b6ba7000 b6bb2000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6bb9000 b6bba000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6bba000 b6bbf000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6bc7000 b6bc8000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6bc8000 b6c98000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c98000 b6c99000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6c99000 b6cd9000 r-xp /usr/lib/libeina.so.1.7.99
b6ce0000 b6ce1000 rwxp /usr/lib/libeina.so.1.7.99
b6ce2000 b6cf8000 r-xp /usr/lib/libecore.so.1.7.99
b6cff000 b6d00000 rwxp /usr/lib/libecore.so.1.7.99
b6d0e000 b6d15000 r-xp /usr/lib/libvconf.so.0.2.45
b6d1d000 b6d1e000 rwxp /usr/lib/libvconf.so.0.2.45
b6d1e000 b6d23000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d2a000 b6d2b000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6d2b000 b6d36000 r-xp /usr/lib/libaul.so.0.1.0
b6d3e000 b6d3f000 rwxp /usr/lib/libaul.so.0.1.0
b6d40000 b6d48000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d4f000 b6d50000 rwxp /lib/libgcc_s-4.6.4.so.1
b6d50000 b6d52000 r-xp /lib/libdl-2.13.so
b6d59000 b6d5a000 r-xp /lib/libdl-2.13.so
b6d5a000 b6d5b000 rwxp /lib/libdl-2.13.so
b6d5b000 b6d66000 r-xp /lib/libunwind.so.8.0.1
b6d6d000 b6d6e000 rwxp /lib/libunwind.so.8.0.1
b6d93000 b6eae000 r-xp /lib/libc-2.13.so
b6eb6000 b6eb8000 r-xp /lib/libc-2.13.so
b6eb8000 b6eb9000 rwxp /lib/libc-2.13.so
b6ebc000 b6ec2000 r-xp /lib/librt-2.13.so
b6ec9000 b6eca000 r-xp /lib/librt-2.13.so
b6eca000 b6ecb000 rwxp /lib/librt-2.13.so
b6ecb000 b6ecd000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed4000 b6ed5000 rwxp /usr/lib/libdlog.so.0.0.0
b6ed5000 b6ed8000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6edf000 b6ee0000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6ee0000 b6ee3000 r-xp /usr/lib/libbundle.so.0.1.22
b6eea000 b6eeb000 rwxp /usr/lib/libbundle.so.0.1.22
b6eeb000 b6eee000 r-xp /usr/lib/libappcore-agent.so.1.1
b6ef5000 b6ef6000 rwxp /usr/lib/libappcore-agent.so.1.1
b6ef6000 b6f0a000 r-xp /lib/libpthread-2.13.so
b6f11000 b6f12000 r-xp /lib/libpthread-2.13.so
b6f12000 b6f13000 rwxp /lib/libpthread-2.13.so
b6f2a000 b6f2e000 r-xp /usr/lib/libsys-assert.so
b6f36000 b6f37000 rwxp /usr/lib/libsys-assert.so
b6f37000 b6f54000 r-xp /lib/ld-2.13.so
b6f5b000 b6f5c000 r-xp /lib/ld-2.13.so
b6f5c000 b6f5d000 rwxp /lib/ld-2.13.so
b6f5d000 b6f69000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6f71000 b6f73000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7b0f000 b7b54000 rwxp [heap]
bef9c000 befbd000 rwxp [stack]
End of Maps Information

Callstack Information (PID:31602)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6e05d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6dd25b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6e6ab88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ecc063) [/usr/lib/libdlog.so.0] + 0x1063
 4: tdlnamain + 0x3f6 (0xb6f62147) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x5147
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
.527+0900 W/ALARM_MANAGER(  392): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 14-7-2015, 03:28:49 (UTC).
07-14 12:04:49.597+0900 W/ALARM_MANAGER(  392): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
07-14 12:04:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:04:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:04:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843100.
07-14 12:04:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:5, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:04:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:05:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:05:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:5:0:8
07-14 12:05:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:5:0
07-14 12:05:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42899992 milliseconds from now
07-14 12:05:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:05:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:05:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 31501614172.
07-14 12:05:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:5, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:05:00.017+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:05:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:5:0:22
07-14 12:05:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:5:0
07-14 12:05:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59978 milliseconds from now
07-14 12:05:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:05:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:05:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:05:37.437+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:05:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:05:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:05:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:05:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843160.
07-14 12:05:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:6, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:06:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:06:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:6:0:8
07-14 12:06:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:6:0
07-14 12:06:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42839992 milliseconds from now
07-14 12:06:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:06:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:06:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:06:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843160.
07-14 12:06:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:6, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:06:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:06:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:06:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:6:0:27
07-14 12:06:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:6:0
07-14 12:06:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59973 milliseconds from now
07-14 12:06:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:06:08.407+0900 D/dalvikvm(30118): GC_EXPLICIT freed 12K, 50% free 2856K/5639K, external 1962K/2073K, paused 20ms
07-14 12:06:37.487+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:06:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:06:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:06:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843220.
07-14 12:07:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:07:00.007+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:7, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:07:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:07:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:7:0:9
07-14 12:07:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:7:0
07-14 12:07:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42779991 milliseconds from now
07-14 12:07:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:07:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:07:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:07:00.027+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843220.
07-14 12:07:00.027+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:7, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:07:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:07:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:7:0:33
07-14 12:07:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:7:0
07-14 12:07:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59967 milliseconds from now
07-14 12:07:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:07:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:07:13.337+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:07:13.337+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:07:13.337+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843233.
07-14 12:07:13.337+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:13, min:7, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:07:13.347+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:07:13.347+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:07:13.347+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:7:13:348
07-14 12:07:13.347+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:7:13
07-14 12:07:13.347+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 993194789 milliseconds from now
07-14 12:07:13.347+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:07:13.357+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:07:13.367+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:07:13.367+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:07:13.367+0900 I/Tizen::System( 1155): (85) > Current Epoch is 911969909985.
07-14 12:07:13.367+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:13, min:7, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:07:13.367+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:07:13.367+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:7:13:374
07-14 12:07:13.367+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:7:13
07-14 12:07:13.367+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 599978 milliseconds from now
07-14 12:07:37.527+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:07:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:07:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:07:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843280.
07-14 12:07:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:8, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:07:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:07:59.997+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:08:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:8:0:5
07-14 12:08:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:8:0
07-14 12:08:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42719995 milliseconds from now
07-14 12:08:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:08:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:08:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:08:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843280.
07-14 12:08:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:8, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:08:00.017+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:08:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:08:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:8:0:26
07-14 12:08:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:8:0
07-14 12:08:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59974 milliseconds from now
07-14 12:08:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:08:05.037+0900 D/dalvikvm(30118): GC_EXPLICIT freed 9K, 50% free 2856K/5639K, external 1962K/2073K, paused 21ms
07-14 12:08:37.587+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:08:53.587+0900 D/dalvikvm( 1413): GC_CONCURRENT freed 866K, 44% free 4335K/7687K, external 2127K/2656K, paused 2ms+3ms
07-14 12:08:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:08:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:08:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843340.
07-14 12:08:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:9, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:08:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:09:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:09:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:9:0:8
07-14 12:09:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:9:0
07-14 12:09:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42659992 milliseconds from now
07-14 12:09:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:09:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:09:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:09:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843340.
07-14 12:09:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:9, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:09:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:09:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:09:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:9:0:29
07-14 12:09:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:9:0
07-14 12:09:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59971 milliseconds from now
07-14 12:09:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:09:37.637+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:09:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:09:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:09:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843400.
07-14 12:09:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:10, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:10:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:10:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:10:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:10:0:8
07-14 12:10:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:10:0
07-14 12:10:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42599992 milliseconds from now
07-14 12:10:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:10:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:10:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:10:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843400.
07-14 12:10:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:10, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:10:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:10:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:10:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:10:0:28
07-14 12:10:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:10:0
07-14 12:10:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59972 milliseconds from now
07-14 12:10:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:10:05.047+0900 D/dalvikvm(30118): GC_EXPLICIT freed 9K, 50% free 2856K/5639K, external 1962K/2073K, paused 20ms
07-14 12:10:37.667+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:10:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:10:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:10:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843460.
07-14 12:11:00.007+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:11, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:11:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:11:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:11:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:11:0:9
07-14 12:11:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:11:0
07-14 12:11:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42539991 milliseconds from now
07-14 12:11:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:11:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:11:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:11:00.027+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843460.
07-14 12:11:00.027+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:11, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:11:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:11:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:11:0:35
07-14 12:11:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:11:0
07-14 12:11:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59965 milliseconds from now
07-14 12:11:00.037+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:11:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:11:37.727+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:11:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:11:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:11:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843520.
07-14 12:11:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:12, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:11:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:11:59.997+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:12:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:12:0:6
07-14 12:12:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:12:0
07-14 12:12:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42479994 milliseconds from now
07-14 12:12:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:12:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:12:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:12:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843520.
07-14 12:12:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:12:00.027+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:12, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:12:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:12:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:12:0:26
07-14 12:12:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:12:0
07-14 12:12:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59974 milliseconds from now
07-14 12:12:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:12:08.767+0900 D/dalvikvm(30118): GC_EXPLICIT freed 10K, 50% free 2856K/5639K, external 1962K/2073K, paused 21ms
07-14 12:12:37.777+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:12:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:13:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:13:00.007+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:13:00.007+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843580.
07-14 12:13:00.007+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:13, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:13:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:13:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:13:0:12
07-14 12:13:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:13:0
07-14 12:13:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42419988 milliseconds from now
07-14 12:13:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:13:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:13:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:13:00.027+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843580.
07-14 12:13:00.027+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:13, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:13:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:13:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:13:0:32
07-14 12:13:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:13:0
07-14 12:13:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59968 milliseconds from now
07-14 12:13:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:13:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:13:37.837+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:13:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:13:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:13:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843640.
07-14 12:13:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:14, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:13:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:13:59.997+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:14:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:14:0:5
07-14 12:14:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:14:0
07-14 12:14:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42359995 milliseconds from now
07-14 12:14:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:14:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:14:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:14:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843640.
07-14 12:14:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:14, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:14:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:14:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:14:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:14:0:26
07-14 12:14:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:14:0
07-14 12:14:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59974 milliseconds from now
07-14 12:14:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:14:08.857+0900 D/dalvikvm(30118): GC_EXPLICIT freed 14K, 50% free 2856K/5639K, external 1962K/2073K, paused 21ms
07-14 12:14:37.897+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:14:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:14:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:15:00.007+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:15:00.007+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843700.
07-14 12:15:00.007+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:15, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:15:00.007+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:15:00.017+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:15:0:11
07-14 12:15:00.017+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:15:0
07-14 12:15:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42299989 milliseconds from now
07-14 12:15:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:15:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:15:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:15:00.027+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843700.
07-14 12:15:00.027+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:15, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:15:00.027+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:15:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:15:0:32
07-14 12:15:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:15:0
07-14 12:15:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59968 milliseconds from now
07-14 12:15:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:15:00.037+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:15:37.957+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:15:59.997+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:15:59.997+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:15:59.997+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843760.
07-14 12:15:59.997+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:16, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:15:59.997+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:15:59.997+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:16:00.007+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:16:0:6
07-14 12:16:00.007+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:16:0
07-14 12:16:00.007+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 42239994 milliseconds from now
07-14 12:16:00.007+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:16:00.017+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:16:00.017+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 12:16:00.017+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436843760.
07-14 12:16:00.017+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:16, hour:3, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 12:16:00.017+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 12:16:00.027+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 12:16:00.027+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 3:16:0:27
07-14 12:16:00.027+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 12:16:0
07-14 12:16:00.027+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59973 milliseconds from now
07-14 12:16:00.027+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:16:08.897+0900 D/dalvikvm(30118): GC_EXPLICIT freed 9K, 50% free 2856K/5639K, external 1962K/2073K, paused 21ms
07-14 12:16:37.987+0900 W/BROWSER_PROVIDER(27001): browser-provider-requests-manager.c: bp_thread_requests_manager(875) > old client[BOOKMARK_CSC:1461485422] slot:2 sock:12
07-14 12:16:42.617+0900 W/LOCKSCREEN(  578): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
07-14 12:16:42.617+0900 W/LOCKSCREEN(  578): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
07-14 12:16:42.617+0900 W/LOCKSCREEN(  578): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
07-14 12:16:42.617+0900 W/LOCKSCREEN(  578): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
07-14 12:16:42.617+0900 W/LOCKSCREEN(  578): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
07-14 12:16:42.617+0900 W/LOCKSCREEN(  578): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
07-14 12:16:42.637+0900 E/LOCKSCREEN(  578): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 12:16:42.647+0900 I/indicator(  511): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
07-14 12:16:42.647+0900 W/LOCKSCREEN(  578): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
07-14 12:16:42.677+0900 W/LOCKSCREEN(  578): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
07-14 12:16:42.677+0900 W/LOCKSCREEN(  578): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 12:16:42.757+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 12:16:42.767+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 12:16:43.287+0900 I/Tizen::System( 1068): (280) > The screen has been turned on.
07-14 12:16:43.287+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 12:16:43.287+0900 I/Internet( 1391): main.cpp: __display_changed_cb(1196) > 3, (nil), 0xbe9afec0
07-14 12:16:43.287+0900 W/CAM_APP ( 1260): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
07-14 12:16:43.297+0900 I/Tizen::App( 1023): (124) > app(ACL111OMWW.AclService), clientId(1155)
07-14 12:16:43.297+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 12:16:43.297+0900 I/Internet( 1391): main.cpp: __display_changed_cb(1213) > DISPLAY_STATE_SCREEN state : [0]
07-14 12:16:43.297+0900 I/Internet( 1391): main.cpp: __display_changed_cb(1225) > paused
07-14 12:16:43.547+0900 I/Tizen::App( 1023): (124) > app(ACL111OMWW.AclService), clientId(1155)
07-14 12:16:43.727+0900 E/LOCKSCREEN(  578): progress_circle.c: unlock_mouse_up(285) > 
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
07-14 12:16:43.727+0900 W/LOCKSCREEN(  578): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
07-14 12:16:43.807+0900 I/Tizen::App( 1023): (124) > app(ACL111OMWW.AclService), clientId(1155)
07-14 12:16:44.057+0900 I/Tizen::App( 1023): (124) > app(ACL111OMWW.AclService), clientId(1155)
07-14 12:16:44.237+0900 W/LOCKSCREEN(  578): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
07-14 12:16:44.237+0900 W/LOCKSCREEN(  578): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
07-14 12:16:44.237+0900 W/LOCKSCREEN(  578): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
07-14 12:16:44.237+0900 E/WALLPAPER_SERVICE_COMMON(  578): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
07-14 12:16:44.237+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29383
07-14 12:16:44.257+0900 E/EFL     (29383): ewebkit2<29383> /home/abuild/rpmbuild/BUILD/webkit2-efl-123997_0.11.36.5/Source/WebKit2/UIProcess/API/efl/ewk_view.cpp:4180 ewk_view_foreground_set() TIZEN_BACKGROUND_DISK_CACHE not enabled!
07-14 12:16:44.297+0900 I/Tizen::System( 1068): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 12:16:44.307+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 12:16:44.307+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 12:16:44.307+0900 W/LOCKSCREEN(  578): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x1E00008] is now visible(1)
07-14 12:16:44.307+0900 W/LOCKSCREEN(  578): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
07-14 12:16:44.307+0900 W/LOCKSCREEN(  578): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
07-14 12:16:44.307+0900 I/CAPI_APPFW_APPLICATION(  578): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 12:16:44.317+0900 E/LOCKSCREEN(  578): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 12:16:44.317+0900 W/LOCKSCREEN(  578): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
07-14 12:16:44.317+0900 W/LOCKSCREEN(  578): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
07-14 12:16:44.317+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 12:16:44.317+0900 I/Tizen::System( 1155): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 12:16:44.327+0900 I/Tizen::App( 1023): (124) > app(ACL111OMWW.AclService), clientId(1155)
07-14 12:16:44.327+0900 D/PowerManagerService( 1413): calling setSysScreenBrightness(brightness = 153)
07-14 12:16:44.327+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 12:16:44.327+0900 I/power   ( 1413): *** set_screen_state 1
07-14 12:16:44.327+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 12:16:44.327+0900 D/SensorService( 1413): actuateSensor
07-14 12:16:44.337+0900 D/AclServiceManager( 1413): -----*******------------ enableSensor  : 0
07-14 12:16:44.337+0900 D/SensorService( 1413): setSensorDelay
07-14 12:16:44.337+0900 D/AclServiceManager( 1413): -----*******------------ setSensorDelay : 0 to 200
07-14 12:16:44.337+0900 D/SensorService( 1413): setSensorDelay
07-14 12:16:44.337+0900 D/AclServiceManager( 1413): -----*******------------ setSensorDelay : 0 to 200
07-14 12:16:44.337+0900 D/ACL     ( 1413): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
07-14 12:16:44.337+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 29383"
07-14 12:16:44.347+0900 D/ACL     ( 1413): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
07-14 12:16:44.347+0900 I/AclService( 1155): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
07-14 12:16:44.357+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 12:16:44.357+0900 I/AclService( 1155): void minimize()(280) > Minimizing all vfb clients
07-14 12:16:44.357+0900 I/AclService( 1155): void minimize()(283) > minimizing {pkg=surfaceflinger fd=99}
07-14 12:16:44.357+0900 I/AclService( 1155): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 12:16:44.357+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 12:16:44.367+0900 E/Tizen::Io( 1155): (133) > [E_INVALID_ARG] The application id is empty.
07-14 12:16:44.367+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 12:16:44.367+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 12:16:44.457+0900 W/LOCKSCREEN(  578): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
07-14 12:16:44.457+0900 E/LOCKSCREEN(  578): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
07-14 12:16:44.457+0900 W/LOCKSCREEN(  578): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
07-14 12:16:44.457+0900 W/LOCKSCREEN(  578): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
07-14 12:16:44.467+0900 E/LOCKSCREEN(  578): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 12:16:45.477+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 12:16:45.477+0900 D/tdlnaservice(31602): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 12:16:45.477+0900 I/tdlna   (31602): _on_proxy_client_msg_received_cb 실행
07-14 12:16:45.477+0900 I/tdlna   (31602): _app_process_received_message 실행
07-14 12:16:45.477+0900 I/tdlna   (31602): test _ _app_process_received_message
07-14 12:16:45.487+0900 I/tdlna   (31602): _app_execute_operation 실행
07-14 12:16:45.487+0900 I/tdlna   (31602): test 실행
07-14 12:16:45.487+0900 I/tdlna   (31602): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 12:16:45.487+0900 I/tdlna   (31602): ★★★★★ 스레드 생성됨 ★★★★★ 1
07-14 12:16:45.487+0900 I/tdlna   (31602): Main Start !!! 1
07-14 12:16:45.487+0900 I/tdlna   (31602): Service Start !!! 1
07-14 12:16:45.487+0900 I/tdlna   (31602): ★★★★★ 버튼 이번트 ★★★★★ 
07-14 12:16:45.487+0900 I/tdlna   (31602): fork 전
07-14 12:16:45.487+0900 I/tdlna   (31602): _app_send_response 실행
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 12:16:45.497+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 12:16:45.497+0900 D/tdlnaservice(31602): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 12:16:45.497+0900 I/tdlna   ( 4935): fork child process 1
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 12:16:45.517+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 12:16:45.527+0900 I/tdlna   ( 4935): ssdp running
07-14 12:16:45.757+0900 W/LOCKSCREEN(  578): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 12:16:45.957+0900 W/CRASH_MANAGER( 4938): worker.c: worker_job(1236) > 113160274646c143684380
