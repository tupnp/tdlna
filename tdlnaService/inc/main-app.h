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

#ifndef __MAIN_APP_H__
#define __MAIN_APP_H__

#include <pthread.h>
#include <stdbool.h>
#include "metadata.h"
// Forward declaration:
struct _proxy_client;

/**
 * @brief Application data
 */
typedef struct _app_data
{
    struct _proxy_client *proxy_client;     /**< proxy client structure pointer */
    pthread_mutex_t proxy_locker;           /**< mutex for locking sending messages process by proxy client*/
    bool run_svc;                           /**< service run state condition */
    bool run_tdlna;
//    pthread_mutex_t tdlna_mutex;
    pthread_t tdlna_td;
    _META *meta;//media metadata
    char deviceName[33];//장치 이름
} app_data;
int sendFolder(void *data, char* dir);

/**
 * @brief Create application instance
 * @return Application instance on success, otherwise NULL
 */
app_data *app_create();

/**
 * @brief Destroy application instance
 * @param[in]   app     Application instance
 */
void app_destroy(app_data *app);

/**
 * @brief Run Tizen application
 * @param[in]   app     Application instance
 * @param[in]   argc    argc paremeter received in main
 * @param[in]   argv    argv parameter received in main
 */
int app_run(app_data *app, int argc, char **argv);

#endif /* __MAIN_APP_H__ */

