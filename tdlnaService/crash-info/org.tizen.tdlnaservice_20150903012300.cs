S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: tdlnaservice
PID: 32278
Date: 2015-09-03 01:23:00+0900
Executable File Path: /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2c

Register Information
r0   = 0x0000002f, r1   = 0x0000002c
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xb6fd80d7
r6   = 0xbe8524b0, r7   = 0x0000002f
r8   = 0x00000008, r9   = 0xb4b6c4e0
r10  = 0xb6fd80ce, fp   = 0xbe8524a4
ip   = 0x00000000, sp   = 0xbe851f40
lr   = 0xb6d385b8, pc   = 0xb6d6bd64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     98732 KB
Buffers:     41456 KB
Cached:     254508 KB
VmPeak:      49640 KB
VmSize:      49636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       10616 KB
VmRSS:       10616 KB
VmData:      12068 KB
VmStk:         136 KB
VmExe:         100 KB
VmLib:       32536 KB
VmPTE:          38 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 32278 TID = 32278
32278 32619 

Maps Information
b4291000 b4a90000 rwxp [stack:32619]
b4a90000 b4b5a000 r-xp /usr/lib/libCOREGL.so.4.0
b4b61000 b4b63000 rwxp /usr/lib/libCOREGL.so.4.0
b4b71000 b4b74000 r-xp /lib/libgpg-error.so.0.5.0
b4b7b000 b4b7c000 rwxp /lib/libgpg-error.so.0.5.0
b4b7c000 b4bd4000 r-xp /usr/lib/libgcrypt.so.11.5.3
b4bdb000 b4bde000 rwxp /usr/lib/libgcrypt.so.11.5.3
b4bdf000 b4be3000 r-xp /usr/lib/libogg.so.0.7.1
b4bea000 b4beb000 rwxp /usr/lib/libogg.so.0.7.1
b4beb000 b4c0d000 r-xp /usr/lib/libvorbis.so.0.4.3
b4c14000 b4c15000 rwxp /usr/lib/libvorbis.so.0.4.3
b4c15000 b4cf9000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4d01000 b4d0d000 rwxp /usr/lib/libvorbisenc.so.2.0.6
b4d0d000 b4d3e000 r-xp /usr/lib/libFLAC.so.8.2.0
b4d46000 b4d47000 rwxp /usr/lib/libFLAC.so.8.2.0
b4d47000 b4d4c000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4d53000 b4d54000 rwxp /usr/lib/libcapi-media-tool.so.0.1.3
b4d55000 b4d57000 r-xp /usr/lib/libiniparser.so.0
b4d5f000 b4d60000 rwxp /usr/lib/libiniparser.so.0
b4d61000 b4d8d000 r-xp /usr/lib/libsystemd.so.0.0.1
b4d94000 b4d95000 r-xp /usr/lib/libsystemd.so.0.0.1
b4d95000 b4d96000 rwxp /usr/lib/libsystemd.so.0.0.1
b4d96000 b4da0000 r-xp /usr/lib/libspdy.so.0.0.0
b4da8000 b4da9000 rwxp /usr/lib/libspdy.so.0.0.0
b4da9000 b4df5000 r-xp /usr/lib/libssl.so.1.0.0
b4dfd000 b4e02000 rwxp /usr/lib/libssl.so.1.0.0
b4e02000 b4e30000 r-xp /usr/lib/libidn.so.11.5.44
b4e37000 b4e38000 rwxp /usr/lib/libidn.so.11.5.44
b4e39000 b4e43000 r-xp /usr/lib/libcares.so.2.1.0
b4e4a000 b4e4b000 rwxp /usr/lib/libcares.so.2.1.0
b4e4b000 b4e90000 r-xp /usr/lib/libsndfile.so.1.0.25
b4e98000 b4e9a000 rwxp /usr/lib/libsndfile.so.1.0.25
b4e9e000 b4ea0000 r-xp /usr/lib/libXau.so.6.0.0
b4ea7000 b4ea8000 rwxp /usr/lib/libXau.so.6.0.0
b4ea8000 b4eb8000 r-xp /lib/libresolv-2.13.so
b4eb8000 b4eb9000 r-xp /lib/libresolv-2.13.so
b4eb9000 b4eba000 rwxp /lib/libresolv-2.13.so
b4ebd000 b4ebf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4ec6000 b4ec7000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b4ec7000 b4ecc000 r-xp /usr/lib/libffi.so.5.0.10
b4ed3000 b4ed4000 rwxp /usr/lib/libffi.so.5.0.10
b4ed4000 b4ed5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4edc000 b4edd000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b4edd000 b4edf000 r-xp /usr/lib/libdri2.so.0.0.0
b4ee6000 b4ee7000 rwxp /usr/lib/libdri2.so.0.0.0
b4ee7000 b4eee000 r-xp /usr/lib/libtbm.so.1.0.0
b4ef5000 b4ef6000 rwxp /usr/lib/libtbm.so.1.0.0
b4ef7000 b4efe000 r-xp /usr/lib/libdrm.so.2.4.0
b4f06000 b4f07000 rwxp /usr/lib/libdrm.so.2.4.0
b4f07000 b4f0f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4f16000 b4f17000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b4f17000 b4f1c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4f23000 b4f24000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
b4f24000 b4f29000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4f31000 b4f32000 rwxp /usr/lib/libxcb-render.so.0.0.0
b4f32000 b4f33000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4f3b000 b4f3c000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b4f3d000 b4f55000 r-xp /usr/lib/libpng12.so.0.50.0
b4f5c000 b4f5d000 rwxp /usr/lib/libpng12.so.0.50.0
b4f5d000 b4f60000 r-xp /usr/lib/libEGL.so.1.4
b4f67000 b4f68000 rwxp /usr/lib/libEGL.so.1.4
b4f68000 b4f76000 r-xp /usr/lib/libGLESv2.so.2.0
b4f7e000 b4f7f000 rwxp /usr/lib/libGLESv2.so.2.0
b4f7f000 b4f83000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4f8b000 b4f8c000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b4f8c000 b4f8e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b4f95000 b4f96000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b4f97000 b4fcb000 r-xp /usr/lib/libicule.so.51.1
b4fd2000 b4fd4000 rwxp /usr/lib/libicule.so.51.1
b4fd4000 b5011000 r-xp /usr/lib/libcurl.so.4.3.0
b5018000 b501a000 rwxp /usr/lib/libcurl.so.4.3.0
b501a000 b5023000 r-xp /usr/lib/libethumb.so.1.7.99
b502b000 b502c000 rwxp /usr/lib/libethumb.so.1.7.99
b502c000 b502e000 r-xp /usr/lib/libctxdata.so.0.0.0
b5035000 b5036000 rwxp /usr/lib/libctxdata.so.0.0.0
b5036000 b5043000 r-xp /usr/lib/libremix.so.0.0.0
b504a000 b504b000 rwxp /usr/lib/libremix.so.0.0.0
b504c000 b504d000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5054000 b5055000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5055000 b506c000 r-xp /usr/lib/liblua-5.1.so
b5074000 b5075000 rwxp /usr/lib/liblua-5.1.so
b5075000 b507c000 r-xp /usr/lib/libembryo.so.1.7.99
b5083000 b5084000 rwxp /usr/lib/libembryo.so.1.7.99
b5084000 b50a7000 r-xp /usr/lib/libjpeg.so.8.0.2
b50ae000 b50af000 rwxp /usr/lib/libjpeg.so.8.0.2
b50bf000 b50d2000 r-xp /usr/lib/libxcb.so.1.1.0
b50d9000 b50da000 rwxp /usr/lib/libxcb.so.1.1.0
b50db000 b5a64000 r-xp /usr/lib/libicudata.so.51.1
b5a6b000 b5a6c000 rwxp /usr/lib/libicudata.so.51.1
b5a6c000 b5a72000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b5a7a000 b5a7b000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b5a7b000 b5a8c000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b5a93000 b5a94000 rwxp /usr/lib/libmmfile_utils.so.0.0.0
b5a94000 b5ac8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b5acf000 b5ad1000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b5ad2000 b5ba6000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b5bae000 b5bb1000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b5bb2000 b5bba000 r-xp /usr/lib/libui-extension.so.0.1.0
b5bba000 b5bbb000 rwxp /usr/lib/libui-extension.so.0.1.0
b5bbb000 b5bbe000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b5bc5000 b5bc6000 rwxp /usr/lib/libnative-buffer.so.0.1.0
b5bc6000 b5bc9000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b5bd0000 b5bd1000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.22
b5bd1000 b5c87000 r-xp /usr/lib/libcairo.so.2.11200.14
b5c8f000 b5c92000 rwxp /usr/lib/libcairo.so.2.11200.14
b5c93000 b5ca5000 r-xp /usr/lib/libtts.so
b5cac000 b5cad000 rwxp /usr/lib/libtts.so
b5cad000 b5e55000 r-xp /usr/lib/libcrypto.so.1.0.0
b5e5c000 b5e71000 rwxp /usr/lib/libcrypto.so.1.0.0
b5e75000 b5e8b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5e92000 b5e93000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b5e93000 b5ea9000 r-xp /lib/libz.so.1.2.5
b5eb0000 b5eb1000 rwxp /lib/libz.so.1.2.5
b5eb1000 b5ec7000 r-xp /lib/libexpat.so.1.5.2
b5ece000 b5ed0000 rwxp /lib/libexpat.so.1.5.2
b5ed1000 b5ed4000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5edb000 b5edc000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b5edc000 b5ee0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5ee7000 b5ee8000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b5ee8000 b5eed000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5ef4000 b5ef6000 rwxp /usr/lib/libecore_fb.so.1.7.99
b5ef6000 b5f4c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5f54000 b5f59000 rwxp /usr/lib/libpixman-1.so.0.28.2
b5f59000 b5fac000 r-xp /usr/lib/libfreetype.so.6.8.1
b5fb3000 b5fb7000 rwxp /usr/lib/libfreetype.so.6.8.1
b5fb8000 b5ffe000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b6006000 b6007000 rwxp /usr/lib/libharfbuzz.so.0.907.0
b6007000 b601a000 r-xp /usr/lib/libfribidi.so.0.3.1
b6021000 b6022000 rwxp /usr/lib/libfribidi.so.0.3.1
b6022000 b603b000 r-xp /usr/lib/libecore_con.so.1.7.99
b6043000 b6044000 rwxp /usr/lib/libecore_con.so.1.7.99
b6045000 b604b000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6052000 b6053000 rwxp /usr/lib/libecore_imf.so.1.7.99
b6053000 b605b000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6062000 b6063000 rwxp /usr/lib/libethumb_client.so.1.7.99
b6064000 b606d000 r-xp /usr/lib/libedbus.so.1.7.99
b6074000 b6075000 rwxp /usr/lib/libedbus.so.1.7.99
b6075000 b60d2000 r-xp /usr/lib/libedje.so.1.7.99
b60d9000 b60db000 rwxp /usr/lib/libedje.so.1.7.99
b60db000 b60e0000 r-xp /usr/lib/libecore_file.so.1.7.99
b60e7000 b60e8000 rwxp /usr/lib/libecore_file.so.1.7.99
b60e8000 b6101000 r-xp /usr/lib/libeet.so.1.7.99
b6109000 b610a000 rwxp /usr/lib/libeet.so.1.7.99
b6112000 b6123000 r-xp /usr/lib/libecore_input.so.1.7.99
b612a000 b612b000 rwxp /usr/lib/libecore_input.so.1.7.99
b612c000 b6136000 r-xp /usr/lib/libXext.so.6.4.0
b613d000 b613e000 rwxp /usr/lib/libXext.so.6.4.0
b613e000 b621f000 r-xp /usr/lib/libX11.so.6.3.0
b6226000 b622a000 rwxp /usr/lib/libX11.so.6.3.0
b622a000 b622d000 r-xp /usr/lib/libXtst.so.6.1.0
b6234000 b6235000 rwxp /usr/lib/libXtst.so.6.1.0
b6235000 b623b000 r-xp /usr/lib/libXrender.so.1.3.0
b6242000 b6243000 rwxp /usr/lib/libXrender.so.1.3.0
b6243000 b6248000 r-xp /usr/lib/libXrandr.so.2.2.0
b624f000 b6250000 rwxp /usr/lib/libXrandr.so.2.2.0
b6250000 b6251000 r-xp /usr/lib/libXinerama.so.1.0.0
b6259000 b625a000 rwxp /usr/lib/libXinerama.so.1.0.0
b625b000 b6263000 r-xp /usr/lib/libXi.so.6.1.0
b6263000 b6264000 rwxp /usr/lib/libXi.so.6.1.0
b6264000 b6267000 r-xp /usr/lib/libXfixes.so.3.1.0
b626e000 b626f000 rwxp /usr/lib/libXfixes.so.3.1.0
b626f000 b6271000 r-xp /usr/lib/libXgesture.so.7.0.0
b6278000 b6279000 rwxp /usr/lib/libXgesture.so.7.0.0
b6279000 b627b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6282000 b6283000 rwxp /usr/lib/libXcomposite.so.1.0.0
b6283000 b6284000 r-xp /usr/lib/libXdamage.so.1.1.0
b628c000 b628d000 rwxp /usr/lib/libXdamage.so.1.1.0
b628d000 b6293000 r-xp /usr/lib/libXcursor.so.1.0.2
b629b000 b629c000 rwxp /usr/lib/libXcursor.so.1.0.2
b629d000 b62a1000 r-xp /usr/lib/libchromium.so.1.0
b62a8000 b62a9000 rwxp /usr/lib/libchromium.so.1.0
b62a9000 b62ab000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b62b2000 b62b3000 rwxp /usr/lib/libmedia-svc-hash.so.1.0.0
b62b3000 b62b6000 r-xp /usr/lib/libuuid.so.1.3.0
b62bd000 b62be000 rwxp /usr/lib/libuuid.so.1.3.0
b62be000 b63a3000 r-xp /usr/lib/libicuuc.so.51.1
b63aa000 b63b3000 rwxp /usr/lib/libicuuc.so.51.1
b63b8000 b64f7000 r-xp /usr/lib/libicui18n.so.51.1
b64ff000 b6507000 rwxp /usr/lib/libicui18n.so.51.1
b6508000 b650b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6512000 b6513000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6513000 b6517000 r-xp /usr/lib/libmmffile.so.0.0.0
b651f000 b6520000 rwxp /usr/lib/libmmffile.so.0.0.0
b6520000 b6541000 r-xp /usr/lib/libexif.so.12.3.3
b6548000 b6554000 rwxp /usr/lib/libexif.so.12.3.3
b6554000 b65bd000 r-xp /lib/libm-2.13.so
b65c4000 b65c5000 r-xp /lib/libm-2.13.so
b65c5000 b65c6000 rwxp /lib/libm-2.13.so
b65c6000 b65cc000 r-xp /usr/lib/libappsvc.so.0.1.0
b65d3000 b65d4000 rwxp /usr/lib/libappsvc.so.0.1.0
b65d5000 b65d8000 r-xp /usr/lib/libsmack.so.1.0.0
b65df000 b65e0000 rwxp /usr/lib/libsmack.so.1.0.0
b65e0000 b65e5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ed000 b65ee000 rwxp /usr/lib/libxdgmime.so.1.1.0
b65ee000 b6618000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6620000 b6621000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6621000 b6638000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6640000 b6641000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b6641000 b6647000 r-xp /lib/librt-2.13.so
b664e000 b664f000 r-xp /lib/librt-2.13.so
b664f000 b6650000 rwxp /lib/librt-2.13.so
b6650000 b6666000 r-xp /usr/lib/libefl-assist.so.0.1.0
b666d000 b666e000 rwxp /usr/lib/libefl-assist.so.0.1.0
b666f000 b668e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6695000 b6696000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6696000 b6761000 r-xp /usr/lib/libxml2.so.2.7.8
b6769000 b676e000 rwxp /usr/lib/libxml2.so.2.7.8
b676f000 b6797000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6797000 b6798000 rwxp /usr/lib/libfontconfig.so.1.8.0
b6798000 b67b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67c0000 b67c2000 rwxp /usr/lib/libecore_evas.so.1.7.99
b67c2000 b6889000 r-xp /usr/lib/libevas.so.1.7.99
b6891000 b689b000 rwxp /usr/lib/libevas.so.1.7.99
b68af000 b69e6000 r-xp /usr/lib/libelementary.so.1.7.99
b69ed000 b69f5000 rwxp /usr/lib/libelementary.so.1.7.99
b69fc000 b6a2b000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a33000 b6a35000 rwxp /usr/lib/libecore_x.so.1.7.99
b6a35000 b6ac9000 r-xp /usr/lib/libstdc++.so.6.0.16
b6ad1000 b6ad4000 r-xp /usr/lib/libstdc++.so.6.0.16
b6ad4000 b6ad6000 rwxp /usr/lib/libstdc++.so.6.0.16
b6adc000 b6ae7000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b6aee000 b6aef000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b6aef000 b6af6000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b6afd000 b6afe000 rwxp /usr/lib/libmedia-utils.so.0.0.0
b6afe000 b6b02000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b6b09000 b6b0a000 rwxp /usr/lib/libmedia-thumbnail.so.1.0.0
b6b0a000 b6b6f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b76000 b6b79000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6b79000 b6bc6000 r-xp /usr/lib/libmedia-service.so.1.0.0
b6bce000 b6bf1000 rwxp /usr/lib/libmedia-service.so.1.0.0
b6bf1000 b6bf6000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6bfe000 b6bff000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b6bff000 b6c3f000 r-xp /usr/lib/libeina.so.1.7.99
b6c46000 b6c47000 rwxp /usr/lib/libeina.so.1.7.99
b6c48000 b6c5e000 r-xp /usr/lib/libecore.so.1.7.99
b6c65000 b6c66000 rwxp /usr/lib/libecore.so.1.7.99
b6c74000 b6c7b000 r-xp /usr/lib/libvconf.so.0.2.45
b6c83000 b6c84000 rwxp /usr/lib/libvconf.so.0.2.45
b6c84000 b6c89000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6c90000 b6c91000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6c91000 b6c9c000 r-xp /usr/lib/libaul.so.0.1.0
b6ca4000 b6ca5000 rwxp /usr/lib/libaul.so.0.1.0
b6ca6000 b6cae000 r-xp /lib/libgcc_s-4.6.4.so.1
b6cb5000 b6cb6000 rwxp /lib/libgcc_s-4.6.4.so.1
b6cb6000 b6cb8000 r-xp /lib/libdl-2.13.so
b6cbf000 b6cc0000 r-xp /lib/libdl-2.13.so
b6cc0000 b6cc1000 rwxp /lib/libdl-2.13.so
b6cc1000 b6ccc000 r-xp /lib/libunwind.so.8.0.1
b6cd3000 b6cd4000 rwxp /lib/libunwind.so.8.0.1
b6cf9000 b6e14000 r-xp /lib/libc-2.13.so
b6e1c000 b6e1e000 r-xp /lib/libc-2.13.so
b6e1e000 b6e1f000 rwxp /lib/libc-2.13.so
b6e22000 b6ef2000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6ef2000 b6ef3000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6ef3000 b6ef5000 r-xp /usr/lib/libdlog.so.0.0.0
b6efc000 b6efd000 rwxp /usr/lib/libdlog.so.0.0.0
b6efd000 b6f04000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b6f0c000 b6f0d000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.4
b6f0d000 b6f10000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f17000 b6f18000 rwxp /usr/lib/libcapi-message-port.so.1.2.2.1
b6f18000 b6f42000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.139
b6f49000 b6f4a000 rwxp /usr/lib/libcapi-content-media-content.so.0.2.139
b6f4a000 b6f4d000 r-xp /usr/lib/libbundle.so.0.1.22
b6f54000 b6f55000 rwxp /usr/lib/libbundle.so.0.1.22
b6f55000 b6f58000 r-xp /usr/lib/libappcore-agent.so.1.1
b6f5f000 b6f60000 rwxp /usr/lib/libappcore-agent.so.1.1
b6f60000 b6f74000 r-xp /lib/libpthread-2.13.so
b6f7b000 b6f7c000 r-xp /lib/libpthread-2.13.so
b6f7c000 b6f7d000 rwxp /lib/libpthread-2.13.so
b6f94000 b6f98000 r-xp /usr/lib/libsys-assert.so
b6fa0000 b6fa1000 rwxp /usr/lib/libsys-assert.so
b6fa1000 b6fbe000 r-xp /lib/ld-2.13.so
b6fc5000 b6fc6000 r-xp /lib/ld-2.13.so
b6fc6000 b6fc7000 rwxp /lib/ld-2.13.so
b6fc7000 b6fe0000 r-xp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b6fe8000 b6fea000 rwxp /opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice
b7caf000 b7d0f000 rwxp [heap]
be834000 be855000 rwxp [stack]
End of Maps Information

Callstack Information (PID:32278)
Call Stack Count: 5
 0: strlen + 0x4 (0xb6d6bd64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0x26f4 (0xb6d385b8) [/lib/libc.so.6] + 0x3f5b8
 2: __vsnprintf_chk + 0xa0 (0xb6dd0b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ef4063) [/usr/lib/libdlog.so.0] + 0x1063
 4: media_Count + 0x7c (0xb6fcb7f5) [/opt/usr/apps/org.tizen.tdlnaservice/bin/tdlnaservice] + 0x47f5
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
  (32278): _app_init 실행
09-03 01:21:52.180+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
09-03 01:21:52.190+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientConnected(166) > MessagePort Ipc connected
09-03 01:21:52.190+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnConnectionRequest(400) > _MessagePortIpcServer::OnConnectionRequest
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: RegisterMessagePort(78) > _MessagePortService::RegisterMessagePort
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: RegisterMessagePort(88) > Register a message port: [org.tizen.tdlnaservice:SAMPLE_PORT], client = 32278
09-03 01:21:52.200+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:21:52.200+0900 D/tdlnaservice(32278): proxy-client.c: proxy_client_register_port(82) > Message port SAMPLE_PORT registered with id: 1
09-03 01:21:52.200+0900 I/tdlna   (32278): 0
09-03 01:21:52.200+0900 I/tdlna   (32278): Samsung Z1
09-03 01:21:52.200+0900 I/tdlna   (32278): _on_app_control_callback 실행
09-03 01:21:57.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-03 01:21:57.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-03 01:21:57.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-03 01:21:57.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 390 5 28 25"
09-03 01:21:57.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
09-03 01:21:57.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-03 01:21:57.020+0900 I/Tizen::Net::Wifi(  998): (1072) > _WifiService is not registered.
09-03 01:21:57.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-03 01:21:57.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-03 01:21:57.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 710 5 28 25"
09-03 01:21:57.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 390 5 28 25"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 710 5 28 25"
09-03 01:22:14.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
09-03 01:22:14.030+0900 I/Tizen::Net::Wifi(  998): (1072) > _WifiService is not registered.
09-03 01:22:47.030+0900 I/Tizen::Net::Wifi(  998): (1072) > _WifiService is not registered.
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 390 5 28 25"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-03 01:22:47.030+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-03 01:22:47.040+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 710 5 28 25"
09-03 01:22:47.040+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
09-03 01:22:50.010+0900 I/Tizen::Net::Wifi(  998): (1072) > _WifiService is not registered.
09-03 01:22:50.010+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-03 01:22:50.010+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-03 01:22:50.010+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-03 01:22:50.010+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 390 5 28 25"
09-03 01:22:50.010+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
09-03 01:22:50.010+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-03 01:22:50.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-03 01:22:50.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-03 01:22:50.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 710 5 28 25"
09-03 01:22:50.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
09-03 01:22:59.020+0900 I/Tizen::Net::Wifi(  998): (1072) > _WifiService is not registered.
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 390 5 28 25"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 710 5 28 25"
09-03 01:22:59.020+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [org.tizen.tdlnaservice:SAMPLE_PORT]
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
09-03 01:23:00.310+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.320+0900 D/tdlnaservice(32278): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
09-03 01:23:00.320+0900 I/tdlna   (32278): _on_proxy_client_msg_received_cb 실행
09-03 01:23:00.320+0900 I/tdlna   (32278): _app_process_received_message 실행
09-03 01:23:00.320+0900 I/tdlna   (32278): 웹앱으로 부터 서비스 수신:dlna on
09-03 01:23:00.320+0900 I/tdlna   (32278): 서비스 ON 요청 app_process_received_message
09-03 01:23:00.320+0900 I/tdlna   (32278): _app_execute_operation 실행
09-03 01:23:00.320+0900 I/tdlna   (32278): dlna on 처리
09-03 01:23:00.320+0900 I/tdlna   (32278): ◆ 서비스 스레드 생성: 0
09-03 01:23:00.320+0900 I/tdlna   (32278): ★ 서비스 ON ★ 1
09-03 01:23:00.320+0900 I/tdlna   (32278): _app_send_response 실행
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [X0OmcPEKY7.TDLNA:SAMPLE_PORT_REPLY]
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.320+0900 D/tdlnaservice(32278): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: X0OmcPEKY7.TDLNA:SAMPLE_PORT_REPLY
09-03 01:23:00.320+0900 I/tdlna   (32278): _app_send_response 실행
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [X0OmcPEKY7.TDLNA:SAMPLE_PORT_REPLY]
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
09-03 01:23:00.320+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.320+0900 D/tdlnaservice(32278): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: X0OmcPEKY7.TDLNA:SAMPLE_PORT_REPLY
09-03 01:23:00.320+0900 D/tdlnaservice(32278): proxy-client.c: _on_message_received_cb(204) > Received message from port 1
09-03 01:23:00.320+0900 I/tdlna   (32278): _on_proxy_client_msg_received_cb 실행
09-03 01:23:00.320+0900 I/tdlna   (32278): _app_process_received_message 실행
09-03 01:23:00.320+0900 I/tdlna   (32278): 웹앱으로 부터 서비스 수신:media folder
09-03 01:23:00.320+0900 I/tdlna   (32278): 서비스 상태확인요청
09-03 01:23:00.320+0900 I/tdlna   (32278): _app_execute_operation 실행
09-03 01:23:00.320+0900 I/tdlna   (32278): 미디어 정보 얻기
09-03 01:23:00.320+0900 I/CAPI_CONTENT_MEDIA_CONTENT(32278): media_content.c: media_content_connect(854) > [32m[32278]ref count : 0
09-03 01:23:00.320+0900 I/WRT_PLUGINS/TIZEN(28303): JSNotificationManager.cpp: removeAll(262) > remove All
09-03 01:23:00.320+0900 I/CAPI_CONTENT_MEDIA_CONTENT(32278): media_content.c: media_content_connect(886) > [32m[32278]ref count changed to: 1
09-03 01:23:00.330+0900 I/tdlna   (32278): tdlna Server Main Start!!!
09-03 01:23:00.330+0900 I/tdlna   (32278): MAC[wlan0]: b8:5a:73:48:70:3a
09-03 01:23:00.330+0900 I/tdlna   (32278): uuid설정: uuid:3d696e69-444c-164e-9d41-b85a7348703a
09-03 01:23:00.330+0900 I/tdlna   (32278): shttpl: 18
09-03 01:23:00.330+0900 D/tdlna   (32278): sssdp (Recivce): 19
09-03 01:23:00.340+0900 I/AUL     (28303): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
09-03 01:23:00.340+0900 D/tdlna   (32278): Enabling interface 192.168.0.62/255.255.255.0
09-03 01:23:00.350+0900 E/CAPI_CONTENT_MEDIA_CONTENT(32278): media_db.c: _media_db_get_folder(505) > [31m[32278]condition_query ( m.storage_type = 0 OR m.storage_type = 1 ) AND ( m.media_type = 0 OR m.media_type = 1 OR m.media_type = 3 ) COLLATE NOCASE 
09-03 01:23:00.360+0900 E/CAPI_CONTENT_MEDIA_CONTENT(32278): media_db.c: _media_db_get_folder(506) > [31m[32278]condition_query  LIMIT -1, -1
09-03 01:23:00.360+0900 I/tdlna   (32278): _media_folder_db 실행
09-03 01:23:00.360+0900 I/tdlna   (32278): MEDIA_CONTENT_ERROR_NONE
09-03 01:23:00.360+0900 D/tdlna   (32278): media_folder ID:70ee9af2-6000-4421-a669-a1504172da6f
09-03 01:23:00.360+0900 I/tdlna   (32278): MEDIA_CONTENT_ERROR_NONE
09-03 01:23:00.360+0900 D/tdlna   (32278): media Folder_path:/opt/usr/media/Images/Screenshots
09-03 01:23:00.360+0900 I/tdlna   (32278): sendFolder(폴더):/opt/usr/media/Images/Screenshots
09-03 01:23:00.360+0900 I/tdlna   (32278): _app_send_response 실행
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnSendMessage(114) > MessagePort OnSendMessage
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(218) > _MessagePortService::SendMessage
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: SendMessage(225) > Sends a message to a remote message port [X0OmcPEKY7.TDLNA:SAMPLE_PORT_REPLY]
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: SendMessage(126) > MessagePort SendMessage
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: SendResponse(873) > _MessagePortIpcServer::SendResponse
09-03 01:23:00.360+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.370+0900 I/AUL     (28303): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
09-03 01:23:00.370+0900 D/tdlnaservice(32278): proxy-client.c: proxy_client_send_message(107) > Message successfully send to: X0OmcPEKY7.TDLNA:SAMPLE_PORT_REPLY
09-03 01:23:00.370+0900 I/tdlna   (32278): 컨텐츠용 sendFolder:/opt/usr/media/Images/Screenshots/%
09-03 01:23:00.370+0900 I/CAPI_CONTENT_MEDIA_CONTENT(32278): media_content.c: media_content_connect(854) > [32m[32278]ref count : 1
09-03 01:23:00.370+0900 I/CAPI_CONTENT_MEDIA_CONTENT(32278): media_content.c: media_content_connect(886) > [32m[32278]ref count changed to: 2
09-03 01:23:00.380+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: constructor(321) > Notification Type : ONGOING
09-03 01:23:00.380+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: StatusNotification(89) > statusType =2
09-03 01:23:00.380+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: StatusNotification(110) > Notification Type : 1
09-03 01:23:00.390+0900 I/AUL     (28303): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/WebProcess, ret : 0
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: StatusNotification(115) > noti =0xaeec7ce0
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setNotificationHandle(1507) > handle = 0xaeec7ce0 m_notiHandle = 0
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: StatusNotification(120) > ongoing type
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(491) > Title : T-DLNA ON
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(494) > get Title : 
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: constructor(342) > Set Notification Init Dictionary
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setContent(540) > Content : You can play media at DLNA device.
09-03 01:23:00.400+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getContent(519) > get Content handle: 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getIconPath(567) > m_notiHandle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setIconPath(590) > icon path = /opt/usr/apps/X0OmcPEKY7/res/wgt/icon.png
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(614) > Handle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(626) >  soudn type=-1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setSoundPath(648) > sound path = /opt/usr/media/Music/Over the horizon.mp3
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(702) > vibration = 1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(706) > old vibration = 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(717) > type vibration type= 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(825) > Entered m_service : 0 control : 0xaf3eed48
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(840) > getOperation : http://tizen.org/appcontrol/operation/create_content
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(852) > getUri : 
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(862) > getMime : image/png
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(871) > Category : 
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(883) >  App Control Datas Count : 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: constructor(418) > Light :undefined
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setProgressType(1078) >  NotificationProgressType = 1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDetailInfos(1744) > DetailInfos = 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getPostedTime(447) > get m_notiHandle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getPostedTime(459) > posted Time =Thu Jan  1 09:00:00 1970
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(99) > property =title
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(158) > 	title = T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(491) > Title : T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(494) > get Title : T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(507) >  title = T-DLNA ON getTitle = T-DLNA ON
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getContent(519) > get Content handle: 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getContent(519) > get Content handle: 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getIconPath(567) > m_notiHandle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getIconPath(567) > m_notiHandle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSubIconPath(1112) > Handle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getStrNumber(1442) > Handle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getBackground(1364) >  Handle : 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getThumbnails(1228) >  thumbnail Size : 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setPrivateObject(907) > Thumbnail Size : 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(614) > Handle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(626) >  soudn type=1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(628) > soundPath = /opt/usr/media/Music/Over the horizon.mp3
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(614) > Handle = 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(626) >  soudn type=1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(628) > soundPath = /opt/usr/media/Music/Over the horizon.mp3
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(99) > property =vibration
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(152) > 	vibration = 1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(702) > vibration = 1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(706) > old vibration = 1
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLight(1529) > get Light handle: 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1620) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1630) > onTime 0
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(99) > property =ledOnPeriod
09-03 01:23:00.410+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(140) > 	LEDonPeriod = 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOnTime(1642) > set Light on Time handle: 0xaeec7ce0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOnTime(1643) > itme = 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1663) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1673) > offTime 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1663) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1673) > offTime 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(99) > property =ledOffPeriod
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setProperty(146) > 	LEDoffPeriod = 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOffTime(1686) > set Light off Time handle: 0xaeec7ce0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOffTime(1687) > time = 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1620) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1630) > onTime 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: setPrivateObject(963) > detail Info Size : 0
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): JSNotificationManager.cpp: post(121) > priv=0xd3a8f8
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: getProperty(198) > property =title
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(491) > Title : T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(494) > get Title : T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getTitle(478) >  get title : T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setTitle(507) >  title = T-DLNA ON getTitle = T-DLNA ON
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setContent(540) > Content : You can play media at DLNA device.
09-03 01:23:00.420+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getContent(519) > get Content handle: 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getIconPath(567) > m_notiHandle = 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setIconPath(590) > icon path = /opt/usr/apps/X0OmcPEKY7/res/wgt/icon.png
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setIconPath(592) > origin icon path = /opt/usr/apps/X0OmcPEKY7/res/wgt/icon.png
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSubIconPath(1112) > Handle = 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setNumber(1468) > Number = 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getNumber(1413) > Handle = 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getNumber(1427) > Number Is NULL
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getNumber(1429) > number = 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDetailInfos(1744) > DetailInfos = 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getBackground(1364) >  Handle : 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setThumbnails(1296) > set thumbnails
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(614) > Handle = 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(626) >  soudn type=1
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getSoundPath(628) > soundPath = /opt/usr/media/Music/Over the horizon.mp3
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setSoundPath(648) > sound path = /opt/usr/media/Music/Over the horizon.mp3
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setSoundPath(650) > origin sound path = /opt/usr/media/Music/Over the horizon.mp3
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: getProperty(198) > property =vibration
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(702) > vibration = 1
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setDefaultVibration(706) > old vibration = 1
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getDefaultVibration(673) > getDefaultVibration
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(825) > Entered m_service : 0xb1b16bc0 control : 0xae0925b0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(840) > getOperation : http://tizen.org/appcontrol/operation/create_content
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(852) > getUri : 
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(862) > getMime : image/png
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(871) > Category : 
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setApplicationControl(883) >  App Control Datas Count : 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLight(1578) > set Light handle: 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLight(1579) > led Color : #000000
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLight(1591) > LedColor = ff000000
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLight(1593) > LedColor = 4278190080
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: getProperty(198) > property =ledOnPeriod
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1620) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1630) > onTime 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOnTime(1642) > set Light on Time handle: 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOnTime(1643) > itme = 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1663) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1673) > offTime 0
09-03 01:23:00.430+0900 I/WRT_PLUGINS/TIZEN(28303): JSStatusNotification.cpp: getProperty(198) > property =ledOffPeriod
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1663) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOffTime(1673) > offTime 0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOffTime(1686) > set Light off Time handle: 0xaeec7ce0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: setLightOffTime(1687) > time = 0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1620) > get Light on Time handle: 0xaeec7ce0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getLightOnTime(1630) > onTime 0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): NotificationManager.cpp: post(113) >  notification id = -1
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): NotificationManager.cpp: post(116) > notification hanel :0xaeec7ce0
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): NotificationManager.cpp: post(126) > Service :0xb1b16bc0 Flag :1
09-03 01:23:00.440+0900 I/WRT_PLUGINS/TIZEN(28303): NotificationManager.cpp: post(136) > Notification Launch Flag True
09-03 01:23:00.450+0900 I/AUL     (  548): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
09-03 01:23:00.460+0900 I/AUL     (  548): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
09-03 01:23:00.490+0900 I/WRT_PLUGINS/TIZEN(28303): JSNotificationManager.cpp: post(142) > posted notification id : 509
09-03 01:23:00.490+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getPostedTime(447) > get m_notiHandle = 0xaeec7ce0
09-03 01:23:00.490+0900 I/WRT_PLUGINS/TIZEN(28303): StatusNotification.cpp: getPostedTime(459) > posted Time =Thu Sep  3 01:23:00 2015
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
09-03 01:23:00.490+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.500+0900 E/QUICKPANEL(  697): noti_led.c: _led_list_find_by_priv_id(118) > [_led_list_find_by_priv_id : 118] invalid parameter
09-03 01:23:00.500+0900 E/VCONF   (  697): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/blockingmode/led_indicator) step(-21) failed(2 / No such file or directory)
09-03 01:23:00.500+0900 E/VCONF   (  697): vconf.c: _vconf_get_key(2111) > db/setting/blockingmode/led_indicator : read buf error(-21). break
09-03 01:23:00.500+0900 E/VCONF   (  697): vconf.c: vconf_get_bool(2417) > vconf_get_bool(697) : db/setting/blockingmode/led_indicator error
09-03 01:23:00.500+0900 E/QUICKPANEL(  697): noti_led.c: _noti_led_on(217) > [_noti_led_on : 217] failed led_set_mode:-1
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcRequestReceived(142) > MessagePort message received
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnCheckRemotePort(103) > _MessagePortStub::OnCheckRemotePort.
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(137) > _MessagePortService::CheckRemotePort
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: GetKey(275) > _MessagePortService::GetKey
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: CheckRemotePort(150) > Check a remote message port: [org.tizen.tdlnaservice:SAMPLE_PORT]
09-03 01:23:00.510+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: Send(836) > _MessagePortIpcServer::Stop
09-03 01:23:00.520+0900 I/QUICKPANEL(  697): vi_manager.c: _vi_freeze_start(67) > [_vi_freeze_start : 67] VIM freezing
09-03 01:23:00.520+0900 I/QUICKPANEL(  697): noti.c: quickpanel_noti_set_clear_all_status(1457) > [quickpanel_noti_set_clear_all_status : 1457] NOTI SECTION CLEAR ALL HIDE
09-03 01:23:00.520+0900 E/VCONF   (  697): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/blockingmode/notifications) step(-21) failed(2 / No such file or directory)
09-03 01:23:00.520+0900 E/VCONF   (  697): vconf.c: _vconf_get_key(2111) > db/setting/blockingmode/notifications : read buf error(-21). break
09-03 01:23:00.520+0900 E/VCONF   (  697): vconf.c: vconf_get_bool(2417) > vconf_get_bool(697) : db/setting/blockingmode/notifications error
09-03 01:23:00.530+0900 E/QUICKPANEL(  697): media.c: quickpanel_media_playable_check(402) > [quickpanel_media_playable_check : 402] /opt/usr/media/Music/Over the horizon.mp3 file does not exist
09-03 01:23:00.530+0900 E/QUICKPANEL(  697): ticker.c: _quickpanel_noti_media_feedback_sound(1159) > [_quickpanel_noti_media_feedback_sound : 1159] playable false, So unlock tone
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: OnReadMessage(728) > _MessagePortIpcServer::OnReadMessage
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(567) > _MessagePortIpcServer::HandleReceivedMessage
09-03 01:23:00.540+0900 E/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(577) > Connection closed
09-03 01:23:00.540+0900 E/MESSAGE_PORT(  392): MessagePortIpcServer.cpp: HandleReceivedMessage(599) > All connections of client(32278) are closed. delete client info
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientDisconnected(172) > MessagePort Ipc disconnected
09-03 01:23:00.540+0900 E/MESSAGE_PORT(  392): MessagePortStub.cpp: OnIpcClientDisconnected(175) > Unregister - client =  32278
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: UnregisterMessagePort(207) > _MessagePortService::UnregisterMessagePort
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.540+0900 I/MESSAGE_PORT(  392): MessagePortService.cpp: unregistermessageport(190) > unregistermessageport
09-03 01:23:00.560+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(601) > __request_handler: 23
09-03 01:23:00.560+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 0
09-03 01:23:00.560+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(831) > pkg_status: installed, dead pid: 32278
09-03 01:23:00.560+0900 W/AUL_AMD (  479): amd_request.c: __send_app_termination_signal(472) > send dead signal done
09-03 01:23:00.560+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 32278
09-03 01:23:00.560+0900 I/Tizen::System(  968): (246) > Terminated app [org.tizen.tdlnaservice]
09-03 01:23:00.560+0900 I/Tizen::Io(  968): (729) > Entry not found
09-03 01:23:00.560+0900 I/Tizen::App(  942): (243) > App[org.tizen.tdlnaservice] pid[32278] terminate event is forwarded
09-03 01:23:00.560+0900 I/Tizen::System(  942): (256) > osp.accessorymanager.service provider is found.
09-03 01:23:00.560+0900 I/Tizen::System(  942): (196) > Accessory Owner is removed [org.tizen.tdlnaservice, 32278, ]
09-03 01:23:00.560+0900 I/Tizen::System(  942): (256) > osp.system.service provider is found.
09-03 01:23:00.560+0900 I/Tizen::App(  942): (506) > TerminatedApp(org.tizen.tdlnaservice)
09-03 01:23:00.560+0900 I/Tizen::App(  942): (512) > Not registered pid(32278)
09-03 01:23:00.560+0900 I/Tizen::App(  942): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 32278.
09-03 01:23:00.570+0900 I/Tizen::System(  968): (157) > change brightness system value.
09-03 01:23:00.570+0900 I/Tizen::App(  968): (782) > Finished invoking application event listener for org.tizen.tdlnaservice, 32278.
09-03 01:23:00.580+0900 E/QUICKPANEL(  697): vi_manager.c: _vi_list_count(128) > [_vi_list_count : 128] list null
09-03 01:23:00.580+0900 I/QUICKPANEL(  697): vi_manager.c: _vi_freeze_stop(79) > [_vi_freeze_stop : 79] VIM unfreezing
09-03 01:23:00.590+0900 I/indicator(  519): indicator_box_util.c: indicator_is_enable_to_insert_in_non_fixed_list(1697) > "[CAN_ADD_WITHOUT_DEL]"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] 509 0!"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: icon_box_pack(772) > "Pack to NOTI list : 509"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 390 5 28 25"
09-03 01:23:00.600+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
09-03 01:23:00.610+0900 I/EFL-ASSIST(  519): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 7800a8 (elm_image), color code: AO004, color [255, 255, 255, 255]
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 509 0 0 0 0"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: indicator_is_enable_to_insert_in_non_fixed_list(1711) > "[CAN_ADD_WITHOUT_DEL]"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] 509 1!"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: icon_box_pack(772) > "Pack to NOTI list : 509"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 473 710 5 28 25"
09-03 01:23:00.610+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
09-03 01:23:00.620+0900 I/indicator(  519): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
09-03 01:23:00.620+0900 I/EFL-ASSIST(  519): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 78fff8 (elm_image), color code: AO004, color [255, 255, 255, 255]
09-03 01:23:00.620+0900 I/indicator(  519): indicator_box_util.c: _update_display(585) > "Noti Icon : 509 0 0 0 0"
09-03 01:23:00.640+0900 W/CRASH_MANAGER(32624): worker.c: worker_job(1236) > 113227874646c144121098
