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

#ifndef __TYPES_APP_H__
#define __TYPES_APP_H__

typedef enum
{
    SVC_RES_OK = 0,
    SVC_RES_FAIL = -1,
} svc_result;

typedef enum
{
    REQ_OPER_NONE = 0,
    REQ_OPER_EXIT_APP,
    REQ_OPER_TEST_APP,
    REQ_OPER_META_GET_APP
} req_operation;

#endif /* __TYPES_APP_H__ */
