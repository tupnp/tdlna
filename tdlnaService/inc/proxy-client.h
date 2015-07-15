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

#ifndef __PROXY_CLIENT_H__
#define __PROXY_CLIENT_H__

#include <bundle.h>

typedef struct _proxy_client proxy_client;

/**
 * @brief Proxy client related message receive callback definition
 */
typedef int (*proxy_client_callback_func)(void *data, bundle *const msg);

/**
 * @brief Create proxy client instance
 * @return Proxy client instance on success, otherwise NULL
 */
proxy_client *proxy_client_create();

/**
 * @brief Destroy proxy client instance
 * @param[in]   proxy_cl    Proxy client instance
 */
void proxy_client_destroy(proxy_client *proxy_cl);

/**
 * @brief Register port for proxy client to receive/send messages
 * @param[in]   proxy_cl    Proxy client instance
 * @param[in]   port_name   Port name to set
 * @return Error code.  SVC_RES_OK if success.
 *                      SVC_RES_FAIL if fails
 */
int proxy_client_register_port(proxy_client *proxy_cl, const char *port_name);

/**
 * @brief Register callback function on proxy client message receive
 * @param[in]   proxy_cl        Proxy client instance
 * @param[in]   callback_func   Callback function
 * @param[in]   data            Data set to callback function
 * @return Error code.  SVC_RES_OK if success.
 *                      SVC_RES_FAIL if fails
 */
int proxy_client_register_msg_receive_callback (proxy_client *proxy_cl,
        proxy_client_callback_func callback_func,
        void *data);

/**
 * @brief Send message by registered port
 * @param[in]   proxy_cl    Proxy client instance
 * @param[in]   msg         Message to send
 * @return Error code.  SVC_RES_OK if success.
 *                      SVC_RES_FAIL if fails
 */
int proxy_client_send_message(proxy_client *proxy_cl, bundle *const msg);

#endif /* __PROXY_CLIENT_H__ */
