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
/*global $, document*/

$(document).on('mobileinit', function onMobileInit() {
    'use strict';
    $.mobile.loadingMessageTextVisible = false;
    $.mobile.defaultPageTransition = 'none';
    // Disable context menu
    $(document).bind('contextmenu', function onContextMenu(e) {
        return false;
    });
    // Disable text selection
    $(document).on('[data-role="page"]', 'pageinit', function onPageInit(e) {
        $.mobile.tizen.disableSelection($(e.target));
    });
});
