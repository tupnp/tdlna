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
var gServiceAppId = 'org.tizen.tdlnaservice',
    gServicePortName = 'SAMPLE_PORT',
    gLocalMessagePortName = 'SAMPLE_PORT_REPLY',
    gLocalMessagePort,
    gRemoteMessagePort,
    gLocalMessagePortWatchId,
    isStarting = false,
    start;

function changeSwitch(state){
	'use strict';
	/*if(state.indexOf("OFF") >= 0){
		$('#btn-test-div-text').text('S_ON');
	}else{
		$('#btn-test-div-text').text('S_OFF');
	}*/
	if(state.indexOf("OFF") >= 0){
		console.log('state: OFF');
		/*$('#serverSwitch').val('off');*/
	}else{
		console.log('state: ON');
		$('.ui-toggle-switch').trigger('click');
	}
}

function addFolder(folder_path){
	//미디어 경로를 화면에 추가한다
	'use strict';
	
//	var str = '<div style="font-size: 15pt; color: #000000; margin: -10px; padding: 5px;">' + folder_path +'</div>';
//	$('#folder_list').append(str).listview('refresh');
	var string = folder_path;
	var strArray = string.split('/');
//	alert(strArray[strArray.length - 1]);
	
	var str = '<li style="overflow: hidden; min-height: 65px;max-height: 75px; max-width: inherit;" onclick="sendShareFolder(\''+folder_path+'\')">'+
		'<a style="max-width: inherit; margin-bottom: -20px; padding-top: 0px; padding-bottom: 0px;">'+strArray[strArray.length - 1]+'</a><br>'+
		'<a style="font-size: 10pt; max-width: inherit; margin-top: -20px; padding-top: 0px; padding-bottom: 0px;">'+folder_path +'</a></li>';
	$('#listParent').append(str).listview('refresh');
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

function sendShareFolder(shareFolder){
	'use strict';
//	alert(shareFolder.text);
//	var folder = shareFolder.text;
	var folder = shareFolder;
	gRemoteMessagePort.sendMessage([{ key: 'shared', value: folder }],
	        gLocalMessagePort);
}

function sendCommand(command) {
    'use strict';

    gRemoteMessagePort.sendMessage([{ key: 'command', value: command }],
        gLocalMessagePort);
//테스트  alert('Sending: ' + command);
}

function onReceive(data) {
    'use strict';
    var message, i , state;
    for (i in data) {
//    	alert('receved:' + data[i].value);
        if (data.hasOwnProperty(i) && data[i].key === 'server') {
			message = data[i].value;
			
			if (data[i].value.indexOf('dlna') >= 0) {
				// alert('receved:' + data[i].value);
			} else if (data[i].value === 'STATE:OFF') {// DLNA : OFF상태
				console.log('DLNA OFF 상태');
				state = 'OFF';
				changeSwitch(state);
			} else if (data[i].value === 'STATE:ON') {// DLNA : OFF상태
				console.log('DLNA ON 상태');
				state = 'ON';
				changeSwitch(state);
			} else if (data[i].value.indexOf('tDlnaName/') >= 0) {
				// alert('DLNA NAME:'+data[i].value);
				var name = data[i].value.split('/');
				// 이름 바꾸기
				$('#diviceName').text(name[1]);
			}
		}
		if (data.hasOwnProperty(i) && data[i].key === 'folder_path') {
			message = data[i].value;
			if (data[i].value.indexOf('folder:') >= 0) {
//				alert("폴더경로 수신!" + data[i].value);
				addFolder(message);
			}
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
    sendCommand('getDeviceId|');//디바이스 아이디 가져오기
    checkFolder();//미디어 폴더 가져오기
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

function serverOn(selectObject){
//	alert(selectObject.value);
	var state = selectObject.value;
	if(state.indexOf('on') >= 0){//전원 On
		console.log("서버켜");
		sendCommand('dlna on');	
	}else{
		console.log("서버꺼");
		sendCommand('dlna off');
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
}
function checkState(){
	console.log("현재 상태 조회");
	sendCommand('server state');
}
function specialCharRemove(obj) {
	var val = obj.value;
//	var pattern = /[^(가-힣ㄱ-ㅎㅏ-ㅣa-zA-Z0-9)]/gi;   // 특수문자 제거
	var pattern = /[^(a-zA-Z0-9)]/gi;   // 특수문자 제거
	 
	//var pattern = /[^(0-9)]/gi;   // 숫자이외는 제거
	if(pattern.test(val)){
	obj.value = val.replace(pattern,"");
	}
}
function checkName(name){
	  // 특수문자 제거
	console.log("1:"+name);
	var val = name;
	var pattern = /[^(a-zA-Z0-9)]/gi; 
	if(pattern.test(name)){
		name = val.replace(pattern,"");
	}
	console.log("2:"+name);
	
	//변경된 이름 전달
	if(name.length == 0){
		sendCommand('getDeviceId|&');//빈값입력시
	} else {
		var str = 'getDeviceId|' + name;
		sendCommand(str);
	}
}
function checkFolder(){
	console.log("미디어 폴더목록 조회");
	sendCommand('media folder');
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
	checkName();
	$('#settingFooter').css("display","none");
}

$(document).delegate('#setting', 'pageinit', function onMainPageInit() {
    'use strict';
    if (gLocalMessagePort) {
        showAlert('Cannot start:<br>already running');
    } else if (isStarting) {
        showAlert('Cannot start:<br>service is starting');
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
                history.back();
            }
        }
    });
});
