/*
 * Copyright 2014 Samsung Electronics Co., Ltd All Rights Reserved
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

#include "main-app.h"
#include "defines-app.h"
#include "types-app.h"
#include "logger.h"
#include "proxy-client.h"
#include "tdlnamain.h"

#include <service_app.h>
#include <stdlib.h>
#include <dlog.h>

#include <metadata_extractor.h>

// app event callbacks
static bool _on_create_cb(void *user_data);
static void _on_terminate_cb(void *user_data);
static void _on_app_control_callback(app_control_h app_control, void *user_data);

static int _app_init(app_data *app);
static int _app_send_response(app_data *app, bundle *const msg);
static int _app_execute_operation(app_data *appdata, req_operation operation_type);
static int _app_process_received_message(bundle *rec_msg, bundle *resp_msg, req_operation *req_oper);
static int _on_proxy_client_msg_received_cb(void *data, bundle *const rec_msg);

static bool _vedioMetadataGet(app_data* data);//meta정보 get

app_data *app_create()
{
    app_data *app = calloc(1, sizeof(app_data));
    return app;
}

void app_destroy(app_data *app)
{
    free(app);
    dlog_print(DLOG_INFO ,"tdlna", "app_destroy TDLNA앱이 종료됨!");
}

int app_run(app_data *app, int argc, char **argv)
{
    RETVM_IF(!app, -1, "Application data is NULL");

    service_app_lifecycle_callback_s cbs =
    {
        .create = _on_create_cb,
        .terminate = _on_terminate_cb,
        .app_control = _on_app_control_callback
    };

    return service_app_main(argc, argv, &cbs, app);
}

static bool _on_create_cb(void *user_data)
{
	dlog_print(DLOG_INFO ,"tdlna", "_on_create_cb 실행");
    RETVM_IF(!user_data, false, "User_data is NULL");
    RETVM_IF(_app_init(user_data) != SVC_RES_OK, false, "Failed to initialise application data");
    return true;
}

static void _on_terminate_cb(void *user_data)
{
	dlog_print(DLOG_INFO ,"tdlna", "_on_terminate_cb 실행");
    if (user_data)
    {
        app_data *app = user_data;

        proxy_client_destroy(app->proxy_client);
    }
}

void _on_app_control_callback(app_control_h app_control, void *user_data)
{
	dlog_print(DLOG_INFO ,"tdlna", "_on_app_control_callback 실행");
}

static int _on_proxy_client_msg_received_cb(void *data, bundle *const rec_msg)
{
	dlog_print(DLOG_INFO ,"tdlna", "_on_proxy_client_msg_received_cb 실행");
    int result = SVC_RES_FAIL;
    RETVM_IF(!data, result, "Data is NULL");

    app_data *app = data;
    req_operation req_operation = REQ_OPER_NONE;

    bundle *resp_msg = bundle_create();
    RETVM_IF(!resp_msg, result, "Failed to create bundle");

    result = _app_process_received_message(rec_msg, resp_msg, &req_operation);
    if (result != SVC_RES_OK)
    {

        ERR("Failed to generate response bundle");
        bundle_free(resp_msg);
        return result;
    }

    result = _app_execute_operation(app, req_operation);
    if(result == SVC_RES_OK)
    {
        result = _app_send_response(app, resp_msg);
        if (result != SVC_RES_OK)
        {
            ERR("Failed to send message to remote application");
        }
    }
    else
    {
        ERR("Failed to execute operation");
    }
    bundle_free(resp_msg);

    return result;
}

//앱 구동에 필요한 각종 appdata를 초기화
static int _app_init(app_data *app)
{
	dlog_print(DLOG_INFO ,"tdlna", "_app_init 실행");
    int result = SVC_RES_FAIL;
    RETVM_IF(!app, result, "Application data is NULL");

    app->proxy_client = proxy_client_create();
    RETVM_IF(!app->proxy_client, result, "Failed to create proxy client");

    result = proxy_client_register_port(app->proxy_client, LOCAL_MESSAGE_PORT_NAME);
    if (result != SVC_RES_OK)
    {
        ERR("Failed to register proxy client port");
        proxy_client_destroy(app->proxy_client);
        app->proxy_client = NULL;
        return result;
    }

    result = proxy_client_register_msg_receive_callback(app->proxy_client, _on_proxy_client_msg_received_cb, app);
    if (result != SVC_RES_OK)
    {
        ERR("Failed to register proxy client on message receive callback");
        proxy_client_destroy(app->proxy_client);
        app->proxy_client = NULL;
        return result;
    }


    result = pthread_mutex_init(&app->proxy_locker, NULL);
    if(result != 0)
    {
        ERR("Failed to init message response mutex ");
        proxy_client_destroy(app->proxy_client);
        app->proxy_client = NULL;
        return SVC_RES_FAIL;
    }

    //tldna 서비스 appdata초기화
    app->run_tdlna = false;
    app->tdlna_td = NULL;

    return SVC_RES_OK;
}

static int _app_process_received_message(bundle *rec_msg,
        bundle *resp_msg,
        req_operation *req_oper)
{
	dlog_print(DLOG_INFO ,"tdlna", "_app_process_received_message 실행");
    RETVM_IF(!rec_msg, SVC_RES_FAIL,"Received message is NULL");
    RETVM_IF(!resp_msg, SVC_RES_FAIL,"Response message is NULL");

    const char *resp_key_val = NULL;
    char *rec_key_val = NULL;
    int res = bundle_get_str(rec_msg, "command", &rec_key_val);
    RETVM_IF(res != BUNDLE_ERROR_NONE, SVC_RES_FAIL, "Failed to get string from bundle");

    if (strcmp(rec_key_val,"meta") == 0)
    {
        resp_key_val = "metaget";
        *req_oper = REQ_OPER_META_GET_APP;
    }
    else if (strcmp(rec_key_val,"dlna on") == 0)//서비스 ON 요청
    {
    	dlog_print(DLOG_INFO ,"tdlna", "서비스 ON 요청 app_process_received_message");
        resp_key_val = "(dlna 실행)수신..";
        *req_oper = REQ_OPER_DLNA_APP;
        //*req_oper = REQ_OPER_EXIT_APP;
    }
    else if (strcmp(rec_key_val,"dlna off") == 0)//서비스 ON 요청
    {
    	dlog_print(DLOG_INFO ,"tdlna", "서비스 OFF 요청 app_process_received_message");
        resp_key_val = "(dlna 종료)수신..";
        *req_oper = REQ_OPER_DLNA_APP_OFF;
        //*req_oper = REQ_OPER_EXIT_APP;
    }
    else
    {
        resp_key_val = "unsupported";
        *req_oper = REQ_OPER_NONE;
    }

    RETVM_IF(bundle_add_str(resp_msg, "server", resp_key_val) != 0, SVC_RES_FAIL, "Failed to add data by key to bundle");

    return SVC_RES_OK;
}

static int _app_execute_operation(app_data *appdata, req_operation operation_type)
{
	dlog_print(DLOG_INFO ,"tdlna", "_app_execute_operation 실행");
	bundle *resp_msg = bundle_create();

    RETVM_IF(!appdata, SVC_RES_FAIL, "Application data is NULL");

    char *resp_key_val = NULL;

    switch (operation_type)
    {
        case REQ_OPER_META_GET_APP:
        	dlog_print(DLOG_INFO,"tdlna","메타정보 가져오기 실행 ");
        	_vedioMetadataGet(appdata);
        	break;
        case REQ_OPER_DLNA_APP://실행 요청시
        	dlog_print(DLOG_INFO,"tdlna","dlna on 처리");

        	if(!(appdata->run_tdlna)){
        		// 서비스가 꺼져있는 상태라면
        		if(serviceOn(appdata)){
            		dlog_print(DLOG_INFO,"tdlna","★ 서비스 ON ★ %d", appdata->run_tdlna);
            		resp_key_val = "실행 성공!";
        		}else{
            		dlog_print(DLOG_INFO,"tdlna","★ 이미 실행중 ★ %d", appdata->run_tdlna);
            		resp_key_val = "이미 실행중!";
        		}
        	}
        	else{
        		resp_key_val = "이미 실행중!";
        		dlog_print(DLOG_INFO,"tdlna","★ 이미 실행중 ★ %d", appdata->run_tdlna);
        	}
        	break;

        case REQ_OPER_DLNA_APP_OFF://종료 요청시
		if (!(appdata->run_tdlna)) {// 서비스가 꺼져있는 상태라면
			resp_key_val = "종료 되어있음!";
			dlog_print(DLOG_INFO, "tdlna", "★ 이미 종료상태★ %d",appdata->run_tdlna);
		} else {
			serviceOff(appdata);
			resp_key_val = "종료 성공!";
			dlog_print(DLOG_INFO, "tdlna", "★ 서비스 OFF ★ %d",appdata->run_tdlna);
		}
			break;
        default:
            DBG("Unknown request id");
            return SVC_RES_FAIL;
            break;
    }
    RETVM_IF(bundle_add_str(resp_msg, "server", resp_key_val) != 0, SVC_RES_FAIL, "Failed to add data by key to bundle");
    _app_send_response(appdata, resp_msg);
    bundle_free(resp_msg);
    return SVC_RES_OK;
}

static bool _vedioMetadataGet(app_data* data){
   dlog_print(DLOG_INFO,"tdlna","_vedioMetadataGet() 실행 ");

   metadata_extractor_h g_metadata_h;

   int ret = metadata_extractor_create(&g_metadata_h);
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_create %d",ret);
   ret = metadata_extractor_set_path(g_metadata_h, "/opt/usr/media/DCIM/Camera/test.mp4");
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_set_path %d",ret);

   char *value = NULL;

//   ======================================================================================================
   ret = metadata_extractor_get_metadata(g_metadata_h, METADATA_DURATION, &value);
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_get_metadata %d",ret);
   dlog_print(DLOG_DEBUG, "tdlna", "METADATA_DURATION: %s\n", value);
   if (value != NULL)
   {
      free(value);
      value = NULL;
   }

//   ======================================================================================================
   int artwork_size = 0;
   void *artwork = NULL;
   char *artwork_mime = NULL;

   ret = metadata_extractor_get_artwork(g_metadata_h, &artwork, &artwork_size, &artwork_mime);
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_get_artwork %d",ret);
   dlog_print(DLOG_DEBUG, "tdlna", "Artwork: size: %d, mime type: %s\n", artwork_size, artwork_mime);
   if (artwork != NULL)
   {
      free(artwork);
      artwork = NULL;
   }

   if (artwork_mime != NULL)
   {
      free(artwork_mime);
      artwork_mime = NULL;
   }
//   ======================================================================================================
   unsigned long time_info = 0;
   char *lyrics = NULL;

   ret = metadata_extractor_get_synclyrics(g_metadata_h, 1, &time_info, &lyrics);
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_get_synclyrics %d",ret);
   if (lyrics != NULL)
   {
      dlog_print(DLOG_DEBUG, "tdlna", "Synclyrics: time_info: %d, lyrics: %s\n", time_info, lyrics);
      free(lyrics);
      lyrics = NULL;
   }
//   ======================================================================================================
   // Use metadata_extractor_get_frame()
   int frame_size = 0;
   void *frame = NULL;

   ret = metadata_extractor_get_frame(g_metadata_h, &frame, &frame_size);
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_get_frame %d",ret);
   dlog_print(DLOG_DEBUG, "tdlna", "Frame: size: %d\n", frame_size);
   if (frame != NULL)
   {
      free(frame);
      frame = NULL;
   }

   // Use metadata_extractor_get_frame_at_time()
   unsigned long timestamp = 500;

   ret = metadata_extractor_get_frame_at_time(g_metadata_h, timestamp, true, &frame, &frame_size);
   dlog_print(DLOG_INFO,"tdlna","metadata_extractor_get_frame_at_time %d",ret);
   dlog_print(DLOG_DEBUG, "tdlna", "Frame at %d: size: %d\n", timestamp, frame_size);
   if (frame != NULL)
   {
      free(frame);
      frame = NULL;
   }
//   ======================================================================================================
   metadata_extractor_destroy(g_metadata_h);

   return 1;
}

static int _app_send_response(app_data *app, bundle *const msg)
{
	dlog_print(DLOG_INFO ,"tdlna", "_app_send_response 실행");
    int res = SVC_RES_FAIL;

    pthread_mutex_lock(&app->proxy_locker);
    res = proxy_client_send_message(app->proxy_client, msg);
    pthread_mutex_unlock(&app->proxy_locker);

    return res;
}
