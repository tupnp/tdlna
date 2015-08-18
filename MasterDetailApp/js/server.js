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
	if(state.indexOf("OFF") >= 0){
		$('#btn-test-div-text').text('S_ON');
	}else{
		$('#btn-test-div-text').text('S_OFF');
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
    gRemoteMessagePort.sendMessage([{ key: 'command', value: command }],
        gLocalMessagePort);
    writeToScreen('Sending: ' + command);
}

function onReceive(data) {
    'use strict';
    var message, i;

    for (i in data) {
        if (data.hasOwnProperty(i) && data[i].key === 'server') {
            message = data[i].value;
            if(data[i].value.indexOf('dlna') >= 0 ){
            	var state = $('#btn-test-div-text').text();
            	changeSwitch(state);//OnOff 버튼 변경
            }
        }
        else if(data.hasOwnProperty(i) && data[i].key === 'directory'){
        	message = data[i].value;
        	 if(data[i].value.indexOf('folder:') >= 0 ){
             	alert("폴더경로 수신!"+data[i].value);
             }
        }
    }
   
    writeToScreen('Received : ' + message);

    if (message === 'WELCOME') {
        sendCommand('start');
    } else if (message === 'stopped') {
        sendCommand('exit');
    } else if (message === 'exit') {
        if (gRemoteMessagePort) {
            gRemoteMessagePort = null;
        }
        if (gLocalMessagePort) {
            gLocalMessagePort
                .removeMessagePortListener(gLocalMessagePortWatchId);
            gLocalMessagePort = null;
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
}

function onGetAppsContextError(err) {
    'use strict';
    console.error('getAppsContext exc', err);
}
function start() {
	console.log('1');
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

	$( document ).ready(function() {
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
    $('#btn-test').on('tap', function onTestBtnTap() {
    	var state = $('#btn-test-div-text').text();
    	if(state.indexOf('OFF') >= 0){//OFF 상태라면 ON 전달
    		sendCommand('dlna on');	
    	}else{
    		sendCommand('dlna off');
    	}
        
        return false;
    });
    $('#btn-state').on('tap',function onStateBtnTap(){
    	sendCommand('server state');
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
