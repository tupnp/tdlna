S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 30858
Date: 2015-07-14 11:54:12+0900
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
r6   = 0xb5cfed60, r7   = 0xb5cff454
r8   = 0xb5cff220, r9   = 0xb6f8313c
r10  = 0xb65014c0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbee63ef8
lr   = 0x00000000, pc   = 0xb6f78424
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     31084 KB
Buffers:     23064 KB
Cached:     211364 KB
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
PID = 30858 TID = 30858
30858 30859 

Maps Information
b5d01000 b6504000 rwxp [stack:30859]
b6504000 b6507000 r-xp /lib/libgpg-error.so.0.5.0
b650e000 b650f000 rwxp /lib/libgpg-error.so.0.5.0
b650f000 b6567000 r-xp /usr/lib/libgcrypt.so.11.5.3
b656e000 b6571000 rwxp /usr/lib/libgcrypt.so.11.5.3
b6572000 b659e000 r-xp /usr/lib/libsystemd.so.0.0.1
b65a5000 b65a6000 r-xp /usr/lib/libsystemd.so.0.0.1
b65a6000 b65a7000 rwxp /usr/lib/libsystemd.so.0.0.1
b65a7000 b65a9000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65b0000 b65b1000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b65b1000 b667c000 r-xp /usr/lib/libxml2.so.2.7.8
b6684000 b6689000 rwxp /usr/lib/libxml2.so.2.7.8
b668a000 b669a000 r-xp /lib/libresolv-2.13.so
b669a000 b669b000 r-xp /lib/libresolv-2.13.so
b669b000 b669c000 rwxp /lib/libresolv-2.13.so
b669f000 b66b5000 r-xp /lib/libz.so.1.2.5
b66bc000 b66bd000 rwxp /lib/libz.so.1.2.5
b66bd000 b66bf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66c6000 b66c7000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b66c7000 b66cc000 r-xp /usr/lib/libffi.so.5.0.10
b66d3000 b66d4000 rwxp /usr/lib/libffi.so.5.0.10
b66d4000 b66d5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66dc000 b66dd000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b66dd000 b6742000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6749000 b674c000 rwxp /usr/lib/libsqlite3.so.0.8.6
b674d000 b6750000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6757000 b6758000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6758000 b6900000 r-xp /usr/lib/libcrypto.so.1.0.0
b6907000 b691c000 rwxp /usr/lib/libcrypto.so.1.0.0
b6920000 b6936000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b693d000 b693e000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b693e000 b6972000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6979000 b697b000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b697b000 b6a4f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a57000 b6a5a000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6a5c000 b6a60000 r-xp /usr/lib/libchromium.so.1.0
b6a67000 b6a68000 rwxp /usr/lib/libchromium.so.1.0
b6a68000 b6ad1000 r-xp /lib/libm-2.13.so
b6ad8000 b6ad9000 r-xp /lib/libm-2.13.so
b6ad9000 b6ada000 rwxp /lib/libm-2.13.so
b6ada000 b6ae0000 r-xp /usr/lib/libappsvc.so.0.1.0
b6ae7000 b6ae8000 rwxp /usr/lib/libappsvc.so.0.1.0
b6ae8000 b6b07000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b0e000 b6b0f000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6b0f000 b6b12000 r-xp /usr/lib/libsmack.so.1.0.0
b6b19000 b6b1a000 rwxp /usr/lib/libsmack.so.1.0.0
b6b1a000 b6b1f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b27000 b6b28000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6b28000 b6b52000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6b5a000 b6b5b000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6b5b000 b6b72000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b7a000 b6b7b000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6b7b000 b6c0f000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c17000 b6c1a000 r-xp /usr/lib/libstdc++.so.6.0.16
b6c1a000 b6c1c000 rwxp /usr/lib/libstdc++.so.6.0.16
b6c22000 b6c2d000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6c34000 b6c35000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6c35000 b6c3a000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6c42000 b6c43000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6c43000 b6d13000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d13000 b6d14000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6d14000 b6d54000 r-xp /usr/lib/libeina.so.1.7.99
b6d5b000 b6d5c000 rwxp /usr/lib/libeina.so.1.7.99
b6d5d000 b6d73000 r-xp /usr/lib/libecore.so.1.7.99
b6d7a000 b6d7b000 rwxp /usr/lib/libecore.so.1.7.99
b6d89000 b6d90000 r-xp /usr/lib/libvconf.so.0.2.45
b6d98000 b6d99000 rwxp /usr/lib/libvconf.so.0.2.45
b6d99000 b6d9e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6da5000 b6da6000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6da6000 b6db1000 r-xp /usr/lib/libaul.so.0.1.0
b6db9000 b6dba000 rwxp /usr/lib/libaul.so.0.1.0
b6dbb000 b6dc3000 r-xp /lib/libgcc_s-4.6.4.so.1
b6dca000 b6dcb000 rwxp /lib/libgcc_s-4.6.4.so.1
b6dcb000 b6dcd000 r-xp /lib/libdl-2.13.so
b6dd4000 b6dd5000 r-xp /lib/libdl-2.13.so
b6dd5000 b6dd6000 rwxp /lib/libdl-2.13.so
b6dd6000 b6de1000 r-xp /lib/libunwind.so.8.0.1
b6de8000 b6de9000 rwxp /lib/libunwind.so.8.0.1
b6e0e000 b6f29000 r-xp /lib/libc-2.13.so
b6f31000 b6f33000 r-xp /lib/libc-2.13.so
b6f33000 b6f34000 rwxp /lib/libc-2.13.so
b6f37000 b6f3d000 r-xp /lib/librt-2.13.so
b6f44000 b6f45000 r-xp /lib/librt-2.13.so
b6f45000 b6f46000 rwxp /lib/librt-2.13.so
b6f46000 b6f48000 r-xp /usr/lib/libdlog.so.0.0.0
b6f4f000 b6f50000 rwxp /usr/lib/libdlog.so.0.0.0
b6f50000 b6f53000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f5a000 b6f5b000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f5b000 b6f5e000 r-xp /usr/lib/libbundle.so.0.1.22
b6f65000 b6f66000 rwxp /usr/lib/libbundle.so.0.1.22
b6f66000 b6f69000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f70000 b6f71000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f71000 b6f85000 r-xp /lib/libpthread-2.13.so
b6f8c000 b6f8d000 r-xp /lib/libpthread-2.13.so
b6f8d000 b6f8e000 rwxp /lib/libpthread-2.13.so
b6fa5000 b6fa9000 r-xp /usr/lib/libsys-assert.so
b6fb1000 b6fb2000 rwxp /usr/lib/libsys-assert.so
b6fb2000 b6fcf000 r-xp /lib/ld-2.13.so
b6fd6000 b6fd7000 r-xp /lib/ld-2.13.so
b6fd7000 b6fd8000 rwxp /lib/ld-2.13.so
b6fd8000 b6fe4000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fec000 b6fee000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b89d2000 b8a17000 rwxp [heap]
bee44000 bee65000 rwxp [stack]
End of Maps Information

Callstack Information (PID:30858)
Call Stack Count: 1
 0: pthread_create + 0x38c (0xb6f78424) [/lib/libpthread.so.0] + 0x7424
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
zen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 11:53:59.777+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
07-14 11:53:59.817+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 11:53:59.877+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
07-14 11:53:59.927+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
07-14 11:54:00.017+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:00.017+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'L'
07-14 11:54:00.077+0900 E/weather-live(31012): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
07-14 11:54:00.087+0900 E/weather-live(31012): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
07-14 11:54:00.127+0900 W/LOCKSCREEN(  578): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
07-14 11:54:00.177+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_create(363) > New handle created[0xb83b93b0]
07-14 11:54:00.177+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_get_type(412) > Connected Network = 2
07-14 11:54:00.177+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_destroy(379) > Destroy handle: 0xb83b93b0
07-14 11:54:00.197+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Wed[0;m
07-14 11:54:00.237+0900 I/PowerManagerService-JNI( 1413): sending ACL screen state 'F'
07-14 11:54:00.317+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Thu[0;m
07-14 11:54:00.327+0900 E/SurfaceFlinger( 1413): redraw failed: empty invalid region
07-14 11:54:00.347+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 11:54:00.357+0900 I/Tizen::Base::Runtime( 1155): (251) > The timer is not started.
07-14 11:54:00.367+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436842440.
07-14 11:54:00.377+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:54, hour:2, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 11:54:00.387+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 11:54:00.397+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 2:54:0:377
07-14 11:54:00.397+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 11:54:0
07-14 11:54:00.397+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 43559623 milliseconds from now
07-14 11:54:00.417+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Fri[0;m
07-14 11:54:00.417+0900 I/Tizen::Net::Wifi( 1091): (211) > Enter: [Rssi Level 4]
07-14 11:54:00.417+0900 I/Tizen::Net::Wifi( 1091): (231) > Exit: [Rssi dbm -55]
07-14 11:54:00.417+0900 I/Tizen::Net::Wifi( 1091): (1077) > Fire event [WIFI_EVENT_RSSI_LEVEL_CHANGED]
07-14 11:54:00.417+0900 I/Tizen::Net::Wifi( 1091): (195) > SendWifiRssiChanged with clientId : 1155
07-14 11:54:00.427+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(true)
07-14 11:54:00.437+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
07-14 11:54:00.437+0900 I/Tizen::System( 1155): (85) > Current Epoch is 1436842440.
07-14 11:54:00.437+0900 I/Tizen::System( 1155): (89) > Calendar time is sec:0, min:54, hour:2, day:14, mon:6, year:115, wday2, year:194, dst:0
07-14 11:54:00.437+0900 I/Tizen::System( 1155): (99) > Current time zone is Asia/Seoul, 540, 60
07-14 11:54:00.437+0900 I/Tizen::System( 1155): (103) > Original Time is 2015 7/14, 2:54:0:441
07-14 11:54:00.437+0900 I/Tizen::System( 1155): (123) > Current Time is 2015 7/14, 11:54:0
07-14 11:54:00.437+0900 I/AclService( 1155): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59559 milliseconds from now
07-14 11:54:00.447+0900 E/weather-common(31012): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
07-14 11:54:00.467+0900 I/Tizen::System( 1155): (461) > change cpu power policy: keepAwake(false)
07-14 11:54:00.487+0900 I/Tizen::Net::Wifi( 1155): (541) > Fire event [WIFI_EVENT_RSSI]
07-14 11:54:00.487+0900 I/Tizen::Net::Wifi( 1155): (695) > Enter, [CurrentState:__WIFI_MANAGER_CONNECTED], [Scan State: __WIFI_SCAN_IDLE]
07-14 11:54:00.487+0900 I/Tizen::Net::Wifi( 1155): (90) > Firing Wi-Fi Manager Event (Type: _WIFI_EVENT_RSSI_CHANGED)
07-14 11:54:00.787+0900 E/cluster-home(  619): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
07-14 11:54:00.787+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_create(363) > New handle created[0xb839c488]
07-14 11:54:00.797+0900 E/cluster-home(  619): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
07-14 11:54:00.797+0900 E/cluster-home(  619): cluster-data-provider.cpp: EventPixmapAcquired(2075) >  Release depreacted pixmap [25165828]
07-14 11:54:00.797+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_get_type(412) > Connected Network = 2
07-14 11:54:00.797+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_destroy(379) > Destroy handle: 0xb839c488
07-14 11:54:00.807+0900 E/weather-live(31012): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
07-14 11:54:00.807+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_create(363) > New handle created[0xb8331108]
07-14 11:54:00.807+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_get_type(412) > Connected Network = 2
07-14 11:54:00.807+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_destroy(379) > Destroy handle: 0xb8331108
07-14 11:54:00.827+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:00.847+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:00.857+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:00.917+0900 E/weather-common(31012): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
07-14 11:54:00.927+0900 E/weather-common(31012): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
07-14 11:54:00.947+0900 W/cluster-view(  619): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2041) >  booster timer is still running on apps-view, Stop boost timer!!!
07-14 11:54:00.967+0900 E/cluster-home(  619): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
07-14 11:54:00.997+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_create(363) > New handle created[0xb83943a0]
07-14 11:54:00.997+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_get_type(412) > Connected Network = 2
07-14 11:54:00.997+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_destroy(379) > Destroy handle: 0xb83943a0
07-14 11:54:01.007+0900 E/weather-live(31012): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
07-14 11:54:01.007+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_create(363) > New handle created[0xb8392078]
07-14 11:54:01.007+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_get_type(412) > Connected Network = 2
07-14 11:54:01.017+0900 I/CAPI_NETWORK_CONNECTION(31012): connection.c: connection_destroy(379) > Destroy handle: 0xb8392078
07-14 11:54:01.027+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:01.057+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:01.067+0900 E/weather-live(31012): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
07-14 11:54:01.087+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 11:54:01.087+0900 E/weather-common(31012): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
07-14 11:54:01.087+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 11:54:01.087+0900 E/weather-common(31012): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
07-14 11:54:01.087+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 11:54:01.087+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 11:54:01.087+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 11:54:01.097+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1091): (211) > Enter: [Rssi Level 3]
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1091): (231) > Exit: [Rssi dbm -70]
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1091): (1077) > Fire event [WIFI_EVENT_RSSI_LEVEL_CHANGED]
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1091): (195) > SendWifiRssiChanged with clientId : 1155
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1155): (541) > Fire event [WIFI_EVENT_RSSI]
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1155): (695) > Enter, [CurrentState:__WIFI_MANAGER_CONNECTED], [Scan State: __WIFI_SCAN_IDLE]
07-14 11:54:01.287+0900 I/Tizen::Net::Wifi( 1155): (90) > Firing Wi-Fi Manager Event (Type: _WIFI_EVENT_RSSI_CHANGED)
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 11:54:01.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 11:54:01.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 11:54:01.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 11:54:01.357+0900 I/MALI    (  619): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8221778] swap changed from async to sync
07-14 11:54:02.077+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 1
07-14 11:54:02.107+0900 E/RESOURCED(  757): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 270
07-14 11:54:02.117+0900 I/AUL     ( 1068): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:02.127+0900 I/AUL     ( 1023): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:02.137+0900 I/AUL     ( 1068): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:02.137+0900 E/Tizen::App( 1068): (703) > Cannot acquire app for 29383.
07-14 11:54:02.137+0900 I/AUL     ( 1023): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:02.137+0900 E/Tizen::App( 1023): (703) > Cannot acquire app for 29383.
07-14 11:54:02.197+0900 I/UXT     (29383): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 11:54:02.277+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 30
07-14 11:54:02.277+0900 W/AUL_AMD (  428): amd_request.c: __send_set_process_group_signal_signal(504) > send set_process_group signal done
07-14 11:54:02.277+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1091): (211) > Enter: [Rssi Level 4]
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1091): (231) > Exit: [Rssi dbm -55]
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1091): (1077) > Fire event [WIFI_EVENT_RSSI_LEVEL_CHANGED]
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1091): (195) > SendWifiRssiChanged with clientId : 1155
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1155): (541) > Fire event [WIFI_EVENT_RSSI]
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1155): (695) > Enter, [CurrentState:__WIFI_MANAGER_CONNECTED], [Scan State: __WIFI_SCAN_IDLE]
07-14 11:54:02.307+0900 I/Tizen::Net::Wifi( 1155): (90) > Firing Wi-Fi Manager Event (Type: _WIFI_EVENT_RSSI_CHANGED)
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 11:54:02.317+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 11:54:02.377+0900 I/EFL-ASSIST(29383): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [16cb4c8]
07-14 11:54:02.387+0900 I/EFL-ASSIST(29383): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1734278) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:54:02.387+0900 I/EFL-ASSIST(29383): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1734278) is freed
07-14 11:54:02.517+0900 E/EFL     (29383): evas_main<29383> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
07-14 11:54:02.537+0900 E/EFL     (29383): evas_main<29383> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
07-14 11:54:02.587+0900 E/PKGMGR_INFO(29383): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
07-14 11:54:02.587+0900 I/APP_CORE(29383): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
07-14 11:54:02.587+0900 I/APP_CORE(29383): appcore-efl.c: __do_app(511) > [APP 29383] Initial Launching, call the resume_cb
07-14 11:54:02.607+0900 E/EFL     (29383): elementary<29383> elm_gesture_layer.c:3865 elm_gesture_layer_add() could not add 0xb0704be0 as sub object of 0x18c4b08
07-14 11:54:02.607+0900 I/AUL     (29395): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 11:54:02.627+0900 E/WEBKIT  (29383): void WebKit::PageClientEvasGL::setTargetSurface()(2349) > ERROR: failed: Invalid evas Object Geometry
07-14 11:54:02.677+0900 I/CAPI_NETWORK_CONNECTION(29383): connection.c: connection_create(363) > New handle created[0x1974000]
07-14 11:54:02.677+0900 I/CAPI_NETWORK_CONNECTION(29383): connection.c: __connection_set_ip_changed_callback(233) > Successfully registered(1)
07-14 11:54:02.677+0900 I/CAPI_NETWORK_CONNECTION(29383): connection.c: __connection_set_proxy_changed_callback(320) > Successfully registered(1)
07-14 11:54:02.677+0900 E/TIZEN_N_SYSTEM_SETTINGS(29383): system_settings.c: system_settings_set_changed_cb(541) > b3e5e2b1
07-14 11:54:02.677+0900 E/TIZEN_N_SYSTEM_SETTINGS(29383): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_name --- callback ptr : b3e5cd99
07-14 11:54:02.727+0900 E/EFL     (29395): edje<29395> edje_util.c:3618 edje_object_size_min_restricted_calc() group webkit/widget/spinner has a non-fixed part 'down_bt'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-14 11:54:02.767+0900 W/PROCESSMGR(  405): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=29383
07-14 11:54:02.797+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:54:02.817+0900 I/indicator(  511): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = rMfxc1AKe2.tdlnaWeb, pid = 29383"
07-14 11:54:02.827+0900 W/APP_CORE(29383): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7e00003
07-14 11:54:02.827+0900 I/MALI    (  619): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8221778] swap changed from sync to async
07-14 11:54:02.867+0900 I/Tizen::System( 1068): (259) > Active app [rMfxc1AKe2], current [com.samsun] 
07-14 11:54:02.877+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 15
07-14 11:54:02.877+0900 I/Tizen::System( 1155): (101) > Active App is rMfxc1AKe2.tdlnaWeb. GetApp id ACL111OMWW.AclService
07-14 11:54:02.887+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:54:02.897+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:54:02.927+0900 I/CAPI_APPFW_APPLICATION(  619): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-14 11:54:02.927+0900 E/cluster-home(  619): homescreen-main.cpp: app_pause(355) >  app pause
07-14 11:54:03.267+0900 I/UXT     (31048): uxt_object_manager.cpp: on_initialized(287) > Initialized.
07-14 11:54:03.317+0900 I/EFL-ASSIST(31048): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1723530) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:54:03.317+0900 I/EFL-ASSIST(31048): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1723530) is freed
07-14 11:54:03.327+0900 I/EFL-ASSIST(31048): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (1723530) from (/usr/share/themes/ChangeableColorTable1.xml) is created
07-14 11:54:03.327+0900 I/EFL-ASSIST(31048): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (1723530) is freed
07-14 11:54:03.337+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.357+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.357+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.357+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.377+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.397+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.397+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.397+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.417+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.437+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.437+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.437+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.457+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.467+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.467+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.467+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.477+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.487+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.487+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.487+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.497+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.507+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.507+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.507+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.517+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.527+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.527+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.527+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.537+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.547+0900 I/AUL     (31035): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-14 11:54:03.547+0900 E/AUL     (31035): aul_path.c: __get_pkgid(82) > Failed to get appid. (err:-1)
07-14 11:54:03.547+0900 E/AUL     (31035): aul_path.c: __get_path(170) > root_path is NULL!
07-14 11:54:03.817+0900 E/WEBKIT  (29383): bool WebKit::FormDatabase::getPasswordFormDataForURL(const WTF::String&, int&, WTF::String&, WTF::String&, bool&, WTF::String&)(251) > ERROR: Error on selecting formdata from database
07-14 11:54:04.507+0900 W/ProcessStats( 1413): Skipping unknown process pid 30858
07-14 11:54:05.297+0900 I/MALI    (29383): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0x17628b0] swap changed from async to sync
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1091): (211) > Enter: [Rssi Level 3]
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1091): (231) > Exit: [Rssi dbm -70]
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1091): (1077) > Fire event [WIFI_EVENT_RSSI_LEVEL_CHANGED]
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1091): (195) > SendWifiRssiChanged with clientId : 1155
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1155): (541) > Fire event [WIFI_EVENT_RSSI]
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1155): (695) > Enter, [CurrentState:__WIFI_MANAGER_CONNECTED], [Scan State: __WIFI_SCAN_IDLE]
07-14 11:54:05.317+0900 I/Tizen::Net::Wifi( 1155): (90) > Firing Wi-Fi Manager Event (Type: _WIFI_EVENT_RSSI_CHANGED)
07-14 11:54:05.327+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 11:54:05.347+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 11:54:05.357+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 11:54:05.357+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 11:54:05.477+0900 D/PowerManagerService( 1413): calling setSysScreenBrightness(brightness = 153)
07-14 11:54:05.477+0900 I/AclService( 1155): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
07-14 11:54:05.657+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 12
07-14 11:54:05.807+0900 E/PKGMGR_INFO(29395): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.camera-app-lite) is found
07-14 11:54:05.837+0900 E/PKGMGR_INFO(29395): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_icon(1542) > (ret == PMINFO_R_OK) theme_ico(com.samsung.browser) is found
07-14 11:54:06.077+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 11:54:06.087+0900 I/AUL     (  373): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 11:54:06.087+0900 I/AUL     (29395): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY], client = 29395
07-14 11:54:06.097+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:54:06.107+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:54:06.117+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.127+0900 D/tdlnaservice(30858): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:54:06.127+0900 I/tdlna   (30858): _on_proxy_client_msg_received_cb 실행
07-14 11:54:06.127+0900 I/tdlna   (30858): _app_process_received_message 실행
07-14 11:54:06.127+0900 I/tdlna   (30858): _app_execute_operation 실행
07-14 11:54:06.127+0900 I/tdlna   (30858): _app_send_response 실행
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:54:06.127+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.127+0900 D/tdlnaservice(30858): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:54:06.147+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.167+0900 D/tdlnaservice(30858): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:54:06.167+0900 I/tdlna   (30858): _on_proxy_client_msg_received_cb 실행
07-14 11:54:06.167+0900 I/tdlna   (30858): _app_process_received_message 실행
07-14 11:54:06.167+0900 I/tdlna   (30858): _app_execute_operation 실행
07-14 11:54:06.167+0900 D/tdlnaservice(30858): main-app.c: _app_execute_operation(290) > Request to start timer
07-14 11:54:06.167+0900 I/tdlna   (30858): _app_run_timer 실행
07-14 11:54:06.167+0900 I/tdlna   (30858): _app_run_timer 실행
07-14 11:54:06.167+0900 I/tdlna   (30858): _app_send_response 실행
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY]
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:54:06.167+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:06.167+0900 D/tdlnaservice(30858): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: rMfxc1AKe2.tdlnaWeb:SAMPLE_PORT_REPLY
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:54:06.187+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:07.687+0900 D/dalvikvm(30118): GC_EXPLICIT freed 20K, 50% free 2856K/5639K, external 1962K/2073K, paused 21ms
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1091): (211) > Enter: [Rssi Level 4]
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1091): (231) > Exit: [Rssi dbm -55]
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1091): (1077) > Fire event [WIFI_EVENT_RSSI_LEVEL_CHANGED]
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1091): (195) > SendWifiRssiChanged with clientId : 1155
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1155): (541) > Fire event [WIFI_EVENT_RSSI]
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1155): (695) > Enter, [CurrentState:__WIFI_MANAGER_CONNECTED], [Scan State: __WIFI_SCAN_IDLE]
07-14 11:54:09.287+0900 I/Tizen::Net::Wifi( 1155): (90) > Firing Wi-Fi Manager Event (Type: _WIFI_EVENT_RSSI_CHANGED)
07-14 11:54:09.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
07-14 11:54:09.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
07-14 11:54:09.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
07-14 11:54:09.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
07-14 11:54:09.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 331 5 28 25"
07-14 11:54:09.287+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 387 5 28 25"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 292 651 5 28 25"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
07-14 11:54:09.297+0900 I/indicator(  511): indicator_box_util.c: _update_display(585) > "Noti Icon : 296 707 5 28 25"
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
07-14 11:54:12.267+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
07-14 11:54:12.267+0900 D/tdlnaservice(30858): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
07-14 11:54:12.267+0900 I/tdlna   (30858): _on_proxy_client_msg_received_cb 실행
07-14 11:54:12.267+0900 I/tdlna   (30858): _app_process_received_message 실행
07-14 11:54:12.267+0900 I/tdlna   (30858): test _ _app_process_received_message
07-14 11:54:12.267+0900 I/tdlna   (30858): _app_execute_operation 실행
07-14 11:54:12.267+0900 I/tdlna   (30858): test 실행
07-14 11:54:12.267+0900 I/tdlna   (30858): ★★★★★ 서비스 가동중 ★★★★★ 1
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
07-14 11:54:12.327+0900 E/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
07-14 11:54:12.327+0900 E/MESSAGE_PORT(  373): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(30858) are closed. delete client info
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
07-14 11:54:12.327+0900 E/MESSAGE_PORT(  373): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  30858
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.327+0900 I/MESSAGE_PORT(  373): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
07-14 11:54:12.347+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(601) > __request_handler: 23
07-14 11:54:12.347+0900 W/AUL_AMD (  428): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
07-14 11:54:12.347+0900 W/AUL_AMD (  428): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 30858
07-14 11:54:12.347+0900 W/AUL_AMD (  428): amd_request.c: __send_app_termination_signal(472) > send dead signal done
07-14 11:54:12.347+0900 I/AUL_AMD (  428): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 30858
07-14 11:54:12.347+0900 I/Tizen::System( 1068): (246) > Terminated app [org.tizen.tdlnaservice]
07-14 11:54:12.347+0900 I/Tizen::Io( 1068): (729) > Entry not found
07-14 11:54:12.347+0900 I/Tizen::App( 1023): (243) > App[org.tizen.tdlnaservice] pid[30858] terminate event is forwarded
07-14 11:54:12.347+0900 I/Tizen::System( 1023): (256) > osp.accessorymanager.service provider is found.
07-14 11:54:12.347+0900 I/Tizen::System( 1023): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 30858, ]
07-14 11:54:12.347+0900 I/Tizen::System( 1023): (256) > osp.system.service provider is found.
07-14 11:54:12.347+0900 I/Tizen::App( 1023): (506) > TerminatedApp(org.tizen.tdlnaservice)
07-14 11:54:12.347+0900 I/Tizen::App( 1023): (512) > Not registered pid(30858)
07-14 11:54:12.347+0900 I/Tizen::App( 1023): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 30858.
07-14 11:54:12.357+0900 I/Tizen::System( 1068): (157) > change brightness system value.
07-14 11:54:12.357+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 30858.
07-14 11:54:12.407+0900 W/CRASH_MANAGER(31096): worker.c: worker_job(1236) > 113085874646c143684245
