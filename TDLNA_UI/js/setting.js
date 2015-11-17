/*
 * Copyright (c) 2012 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*jslint devel:true*/
/*global $, tizen, window, document, history*/
//X0OmcPEKY7.tdlnaservice 
//org.tizen.tdlnaservice
var gServiceAppId = 'X0OmcPEKY7.tdlnaservice',
    gServicePortName = 'SAMPLE_PORT',
    gLocalMessagePortName = 'SAMPLE_PORT_REPLY',
    gLocalMessagePort,
    gRemoteMessagePort,
    gLocalMessagePortWatchId,
    isStarting = false,
    notificationStarting = false,
    notification,
    start,
    isResume = false,
    deviceName,
    emptyCheck = true;//선택한 폴더가 없음

function postNotification(msg){
	/* Application control */
	var appControl = new tizen.ApplicationControl("http://tizen.org/appcontrol/operation/create_content", null, null, null, null);
	tizen.notification.removeAll();
	if (msg.indexOf("ON") >= 0) {
		notificationStarting = true;
		var contentText = "You can play media at DLNA device.";
		var notificationDict = {
			/* Notification content */
			content : contentText,
			/* Path to the notification icon */
			iconPath : "wgt-package/icon.png",
			/*
			 * Path to the sound file to be played when the notification is
			 * displayed
			 */
			soundPath : "music/Over the horizon.mp3",
			/* Device vibrates when the notification is displayed */
			vibration : true,
			/*
			 * Application control to be launched when the user selects the
			 * notification
			 */
			appControl : appControl,
			detailInfo:"postNotification();"
		};
		notification = new tizen.StatusNotification("ONGOING", msg,
				notificationDict);

		tizen.notification.post(notification);
	} else {
		notificationStarting = false;
		tizen.notification.removeAll();
	}
}

function addFolderContents(count_v,count_i,count_a){
	//폴더내 미디어 갯수를 출력한다 비디오/이미지/오디오
	'use strict';
	var listArray = document.getElementsByName("checkFolderLi"),
	 listIndex = listArray.length - 1,
//	 listID = "contentsID"+listIndex,
	 str;
	$('#'+'contentsID'+listIndex).empty();
	
	str  = '<a class="vedio">v:'+count_v+'</a>'+
	'<a class="image"> i:'+count_i+'</a>'+
	'<a class="audio"> m:'+count_a+'</a>';
	
	$('#'+'contentsID'+listIndex).append(str);
}

function uncheckListOFF(){
	console.log("체크리스트만 남김");
	emptyCheck = true;
	var alllist = document.getElementById("listParent"),
	listArray = document.getElementsByName("checkFolderLi"), listIndex = 0;
	
	console.log(listArray.length + " : 라인 갯수");
	while(true){
		console.log(listIndex + " : listIndex");
		if(listIndex === listArray.length){
			break;
		}
		console.log(alllist.childNodes[listIndex].getElementsByTagName("input")[0].getAttribute("value"));
		if(alllist.childNodes[listIndex].getElementsByTagName("input")[0].getAttribute("value") === "true"){
			emptyCheck = false;
			alllist.childNodes[listIndex].getElementsByTagName("input")[0].setAttribute("disabled", "disabled");
			alllist.childNodes[listIndex].getElementsByTagName("a")[0].setAttribute("onclick", "");
			listIndex++;
		}
		else{
			alllist.removeChild(alllist.childNodes[listIndex]);	
		}
	}
	return emptyCheck;
}

function addFolder(folder_path){
	//미디어 경로를 화면에 추가한다
	'use strict';

	var string = folder_path,
	 	strArray = string.split('/'),
	 	listArray = document.getElementsByName("checkFolderLi"),
	 	listIndex = listArray.length,
	 	imageVal = "false",
//	 	imageSRC = "./lib/tau/mobile/theme/default/images/controls/core_check_bg.png";
	 	imageSRC = "./check_empty.png";
	
	if(string[0] === "*"){//공유중인것
		folder_path = string.substring(string.length,1);
//		imageSRC = "./lib/tau/mobile/theme/default/images/controls/core_check_icon.png";
		imageSRC = "./check_checked.png";
		imageVal = "true";
	}
	$('#'+'contentsID'+listIndex).empty();
	$('#'+'checkInputbox'+listIndex).trigger('click');
	var str = 
		'<li id="folderLine'+listIndex+'" name="folderLi" style="overflow: hidden; min-height: 65px;max-height: 75px; max-width: inherit; padding:5pt;"> '+
		'<input id="checkInputbox'+listIndex+'" type="image" value="'+imageVal+'" src="'+imageSRC+'" class="checkFolder" name="checkFolderLi" onclick="sendShareFolder(this,\''+folder_path+'\')" style="width:20px; padding-right:5px;">'+
		'<span class="folderTittle" >'+
		'<a style="max-width: inherit; margin: 0px; padding-top: -10px; padding-bottom: -10px;" onclick="$('+'\'#'+'checkInputbox'+listIndex+'\').trigger('+'\'click\''+')">'+strArray[strArray.length - 1]+'</a></span>'+
		'<br><span class="folderDescribe" style="display:inline-block; text-overflow: ellipsis; width: 340px;	white-space: nowrap; overflow: hidden;">'+
		'<a style="font-size: 10pt; max-width:310px; max-hight:24px; margin: 0px; padding-bottom: 10px; padding-left: 20px;">'+folder_path +'</a>'+
		'</span></span></li>';
	$('#listParent').append(str).listview('refresh');
}


function sendShareFolder(chkbox,shareFolder){
	'use strict';
	var folder = shareFolder;
	var check = chkbox.value;
	if(check=="false"){
		gRemoteMessagePort.sendMessage([{ key: 'shared', value: folder }],gLocalMessagePort);
		chkbox.setAttribute( "src", "./check_checked.png" );
		chkbox.setAttribute( "value", "true" );
	}else{
		gRemoteMessagePort.sendMessage([{ key: 'unshared', value: folder }],gLocalMessagePort);
		chkbox.setAttribute( "src", "./check_empty.png" );
		chkbox.setAttribute( "value", "false" );
	}
}

function writeToScreen(message) {
    'use strict';
    var today = new Date(),
        time = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' +
            today.getDate() + ' ' + today.getHours() + ':' +
            today.getMinutes() + ':' + today.getSeconds() + '.' +
            today.getMilliseconds(),
        str = '<li class="ui-li-has-multiline ui-li-text-ellipsis">' +
            message +
            '<span class="ui-li-text-sub">' +
            time +
            '</span></li>';

    $('#logs').append(str).listview('refresh');
    document.getElementById('logs').scrollIntoView(false);
}

function sendCommand(command) {
    'use strict';
    if(command !== 'undefined'){
    gRemoteMessagePort.sendMessage([{ key: 'command', value: command }],
        gLocalMessagePort);
    }
//테스트  alert('Sending: ' + command);
}

function checkFolder(){
	 $('#listParent').empty().listview('refresh');//기존 폴더 삭제 
	console.log("기존 목록 삭제 / 미디어 폴더목록 조회요청");
	sendCommand('media folder');
}

function failedStart(){
	alert("Service start failed!\nPlease check network.");
	$('.ui-toggle-switch').trigger('click');
}


function showAlert(message) {
    'use strict';
    var alertPopup = $('#alert-popup');
    alertPopup.find('#message').html(message);
    alertPopup.popup('open', {positionTo: 'window'});
}

function launchServiceApp() {
    'use strict';
    function onSuccess() {
        console.log('Service App launched successfully!');
        console.log('Restart...');
        start();
    }

    function onError(err) {
        console.error('Service Applaunch failed', err);
        isStarting = false;
        showAlert('Failed to launch HybridServiceApp!');
    }

    try {
        console.log('Launching [' + gServiceAppId + '] ...');
        tizen.application.launch(gServiceAppId, onSuccess, onError);
    } catch (exc) {
        console.error('Exception while launching HybridServiceApp: ' +
            exc.message);
        showAlert('Exception while launching HybridServiceApp:<br>' +
            exc.message);
    }
}



function serverOn(selectObject){
	var state = selectObject.value;
	if(state.indexOf('on') >= 0){//전원 On
		console.log("서버켜");
		sendCommand('dlna on');	
	}else{
		console.log("서버꺼");
		sendCommand('dlna off');
		//removeFolder();//폴더목록 삭제
//		postNotification("T-DLNA OFF");
//		checkFolder();//폴더 새로 생성
	}
		
}
function changeName(){
	//device이름 input 태그 표시
	var name = $('#diviceName').text();
	$('#diviceName').text('');
	$('#parent').append('<input id="diviceNameInput" style="font-size: 25pt; color: black; background-color: rgba(255,0,0,0);border:0px;" type="text" value="'
			+name+'">');
	$('#diviceNameInput').focus();
	$('#diviceNameInput').val($('#diviceNameInput').val());
	$('#settingFooter').show();
	deviceName = name;
}
function checkState(){
	console.log("현재 상태 조회");
	sendCommand('server state');
}

function checkName(name){
	//변경된 이름 전달
	if(name.length === 0){
		sendCommand('getDeviceId|&');//빈값입력시
		return;
	} else {
		// 특수문자 제거
		console.log("1:"+name);
		var val = name,str,pattern = /[^(a-zA-Z0-9ㄱ-ㅎㅏ-ㅣ가-힣\s)]/gi;
		if(pattern.test(name)){
			name = val.replace(pattern,"");
		}
		console.log("2:"+name);
		str = 'getDeviceId|' + name;
		sendCommand(str);
	}
}

function btn_ok(){
	//device이름 input 태그 표시
	var name = $('#diviceNameInput').val();
	$('#diviceNameInput').remove();
    checkName(name);//디바이스 아이디 가져오기
	$('#settingFooter').css("display","none");
}
function btn_cancel(){
//	alert('취소');
	$('#diviceNameInput').remove();
	$('#diviceName').text(deviceName);
	$('#settingFooter').css("display","none");
}

function changeSwitch(state){
	'use strict';
	if(state.indexOf("OFF") >= 0){
		console.log('state: OFF');
	}else{
		console.log('state: ON');
		$('.ui-toggle-switch').trigger('click');
	}
}

function onReceive(data) {
    'use strict';
    var message, i , state, contents, index_path, path, name, isEmpty = false;
    for (i in data) {
    	console.log('receved:' + data[i].value);
        if (data.hasOwnProperty(i) && data[i].key === 'server') {
			message = data[i].value;
//			alert('receved:' + data[i].value);
			/*if (data[i].value.indexOf('dlna') >= 0) {
//				 alert('receved:' + data[i].value);
			} else */
			if (data[i].value === 'STATE:OFF') {// DLNA가 꺼진 상태
				console.log('STATE OFF 상태');
				sendCommand('getDeviceId|');//디바이스 아이디 가져오기
			    checkFolder();
			    isResume = true;
			} else if (data[i].value === 'STATE:ON') {//  DLNA가 ON 상태
				console.log('STATE ON 상태');
				state = 'ON';
				changeSwitch(state);
				sendCommand('getDeviceId|');
			}else if (data[i].value === 'DLNA:ON') {// DLNA : ON 상태로 상태 바뀜
				console.log('DLNA ON 성공');
				isEmpty = uncheckListOFF();//현재 선택한 폴더가 없다면
				if(isEmpty){
					console.log('체크한 폴더 없음');
					changeSwitch('');
					sendCommand('dlna off');
					$('#popDiaLog').click();
					$('#toast').notification('open');					
//					confirm("공유중인 폴더가 없습니다.\n폴더를 선택해주세요.");		
				}else{
					postNotification("T-DLNA ON");
				}
			}else if (data[i].value === 'DLNA:OFF') {// DLNA : OFF 로 상태 바뀜
				console.log('DLNA OFF 성공');
				postNotification("T-DLNA OFF");
				checkFolder();
				isResume = true;
			}else if (data[i].value.indexOf('tDlnaName/') >= 0) {
				// alert('DLNA NAME:'+data[i].value);
				name = data[i].value.split('/');
				// 이름 바꾸기
				$('#diviceName').text(name[1]);
				deviceName = name[1];
			}
			else if(data[i].value.indexOf('DLNA:Failed') >= 0){
				failedStart();
			}else if (data[i].value === 'DLNA:RUNNING') {// 이전부터 실행중
				console.log('이미 실행중');
				checkFolder();
			}
		}
        else if (data.hasOwnProperty(i) && data[i].key === 'folder_path') {
        	console.log("폴더수신 : "+data[i].value);
        	path = data[i].value.split('|');
        	console.log("폴더갯수 : "+path.length);
			for(index_path = 0 ; index_path < path.length - 1 ; index_path++){
//				alert("폴더경로 수신!" + data[i].value);
				addFolder(path[index_path]);
			}
			//폴더가 다 만든상태
			if(!isResume){//버튼 클릭이 아님
				uncheckListOFF();
			}
		}
//        else if (data.hasOwnProperty(i) && data[i].key === 'folder_contents') {
//			contents = data[i].value.split('|');
//			//addFolderContents(contents[0], contents[1], contents[2]); -- 폴더별 컨텐츠 갯수 (사용안함)
//		}
        else{
        	alert('hybrid ERROR! : Please retry');
        }
    }
   
}

function startMessagePort() {
    'use strict';
    try {
        gLocalMessagePort = tizen.messageport
            .requestLocalMessagePort(gLocalMessagePortName);
        gLocalMessagePortWatchId = gLocalMessagePort
            .addMessagePortListener(function onDataReceive(data, remote) {
                onReceive(data, remote);
            });
    } catch (e) {
        gLocalMessagePort = null;
        writeToScreen(e.name);
    }

    try {
        gRemoteMessagePort = tizen.messageport
            .requestRemoteMessagePort(gServiceAppId, gServicePortName);
    } catch (er) {
        gRemoteMessagePort = null;
        writeToScreen(er.name);
    }

    isStarting = false;

    sendCommand('connect');
}

function onGetAppsContextSuccess(contexts) {
    'use strict';
    var i, appInfo;
    for (i = 0; i < contexts.length; i = i + 1) {
        try {
            appInfo = tizen.application.getAppInfo(contexts[i].appId);
        } catch (exc) {
            console.log('Exception while getting application info: ' +
                exc.message);
            showAlert('Exception while getting application info:<br>' +
                exc.message);
        }

        if (appInfo.id === gServiceAppId) {
            console.log('Running Service App found');
            break;
        }
    }

    if (i >= contexts.length) {
        console.log('Running Service App not found. Trying to launch it');
        launchServiceApp();
    } else {
        startMessagePort();
    }
    checkState();//현재 on/off 상태 가져오기
//    sendCommand('getDeviceId|');//디바이스 아이디 가져오기
//    checkFolder();
}

function onGetAppsContextError(err) {
    'use strict';
    console.error('getAppsContext exc', err);
}
function start() {
    'use strict';
    try {
        tizen.application.getAppsContext(onGetAppsContextSuccess,
            onGetAppsContextError);
    } catch (exc) {
        writeToScreen('Get AppContext Error');
    }
}

function getAppsInfoSuccessCB(apps) {
    'use strict';
    var i;
    for (i = 0; i < apps.length; i = i + 1) {
        if (apps[i].id === gServiceAppId) {
            console.log('Found installed Service App');
            break;
        }
    }
    if (i >= apps.length) {
        writeToScreen('Service App not installed');
        isStarting = false;
        return;
    }
    launchServiceApp();
}

function getAppsInfoErrorCB(err) {
    'use strict';
    console.error('getAppsInfo failed', err);
    isStarting = false;
}

function listInstalledApps() {
    'use strict';
    try {
        tizen.application.getAppsInfo(getAppsInfoSuccessCB, getAppsInfoErrorCB);
    } catch (exc) {
        writeToScreen('Get Installed App Info Error');
    }
}

$(document).delegate('#setting', 'pageinit', function onMainPageInit() {
    'use strict';
    if (gLocalMessagePort) {
        alert('Cannot start:<br>already running');
    } else if (isStarting) {
        alert('Cannot start:<br>service is starting');
    } else {
        isStarting = true;
        start();
    }
    $('#btn-meta').on('tap', function onStartBtnTap() {
    	 if (isStarting) {
             showAlert('Cannot stop:<br>service is starting');
         } else if (gRemoteMessagePort) {
             sendCommand('meta');
         } else {
             showAlert('Cannot stop:<br>not running');
         }
        return false;
    });
    $('#serverSwitch').on('tap', function onTestBtnTap() {
    	var state = $('#serverSwitch').valueOf();
    	if(state.indexOf('off') >= 0){//OFF 상태라면 ON 전달
//    		alert("서버켜");
    		sendCommand('dlna on');	
    	}else{
//    		alert("서버꺼");
    		sendCommand('dlna off');
    	}
        
        return false;
    });

    $(window).on('tizenhwkey', function onTizenHWKey(e) {
        if (e.originalEvent.keyName === 'back') {
            if ($.mobile.activePage.attr('id') === 'main') {
                try {
                    tizen.application.getCurrentApplication().exit();
                } catch (exc) {
                    console.error('Error: ', exc.message);
                }
            } else {
//                history.back();
            	location.href = "index.html";

            }
        }
    });
});
