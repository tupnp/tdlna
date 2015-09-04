#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <glib.h>
#include "main-app.h"
#include "metadata.h"
#include <dlog.h>
#include <time.h>

#define BUFLEN 200

bool gallery_media_item_cb(media_info_h media, void *user_data) {
	media_info_h new_media = NULL;
	media_info_clone(&new_media, media);

	GList **list = (GList**) user_data;
	*list = g_list_append(*list, new_media);
	return true;
}
_META* meta_create() {
	_META* meta = calloc(0, sizeof(_META));
	return meta;
}

void media_Count(int *videoCount,int *imageCount,int *musicCount, char *path){
	filter_h filter = NULL;
	int ret = 0 ;
	char buf[BUFLEN] = { '\0' };
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_filter_create(&filter);
	media_content_connect();

	dlog_print(DLOG_INFO, "tdlna", "폴더: %s", path);
	snprintf(buf, BUFLEN, "%s Like '%s' AND %s = %d",MEDIA_PATH, path, MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO);
//	   snprintf(buf, BUFLEN, "%s Like %s", MEDIA_PATH,"'/opt/usr/media/DCIM/Camera/%'");
	media_filter_set_condition(filter, buf, collate_type);
	ret = media_info_get_media_count_from_db(filter, videoCount);
	check_returnValue(ret);
	dlog_print(DLOG_INFO, "tdlna", "비디오 갯수: %d", *videoCount);

	snprintf(buf, BUFLEN, "%s Like '%s' AND %s = %d",MEDIA_PATH, path, MEDIA_TYPE, MEDIA_CONTENT_TYPE_IMAGE);
	media_filter_set_condition(filter, buf, collate_type);
	ret = media_info_get_media_count_from_db(filter, imageCount);
	//   check_returnValue(ret);
	dlog_print(DLOG_INFO, "tdlna", "이미지 갯수: %d", *imageCount);

	snprintf(buf, BUFLEN, "%s Like '%s' AND %s = %d",MEDIA_PATH, path, MEDIA_TYPE,MEDIA_CONTENT_TYPE_MUSIC);
	media_filter_set_condition(filter, buf, collate_type);
	ret = media_info_get_media_count_from_db(filter, musicCount);
	//   check_returnValue(ret);
	dlog_print(DLOG_INFO, "tdlna", "음악 갯수: %d", *musicCount);

	media_content_disconnect();
	media_filter_destroy(filter);

}

void check_returnValue(int ret){
	switch(ret){
	case MEDIA_CONTENT_ERROR_NONE:
		dlog_print(DLOG_INFO,"tdlna","MEDIA_CONTENT_ERROR_NONE");
		break;
	case MEDIA_CONTENT_ERROR_INVALID_PARAMETER:
		dlog_print(DLOG_INFO,"tdlna","MEDIA_CONTENT_ERROR_INVALID_PARAMETER");
		break;
	case MEDIA_CONTENT_ERROR_DB_FAILED:
		dlog_print(DLOG_INFO,"tdlna","MEDIA_CONTENT_ERROR_DB_FAILED");
		break;
	case MEDIA_CONTENT_ERROR_PERMISSION_DENIED:
		dlog_print(DLOG_INFO,"tdlna","MEDIA_CONTENT_ERROR_PERMISSION_DENIED");
		break;
	default:
		dlog_print(DLOG_INFO,"tdlna","기타 에러");
	}
}

bool _media_type_folder_db(media_folder_h folder,char *retPath){
	dlog_print(DLOG_INFO, "tdlna", "_media_type_folder_db 실행");
	char *folder_path;
	int ret = 0, ii = 0;

	ret = media_folder_get_path(folder,&folder_path);
	check_returnValue(ret);
	dlog_print(DLOG_DEBUG,"tdlna","media Folder_path:%s",folder_path);

	for(ii=0; ii< folder_length; ii++){
		//공유폴더 체크한것만 연결
		if(strcmp(folder_path, sharing_folders[ii]) == 0){
			strcat(retPath, folder_path);
			strcat(retPath, "|");
			break;
		}
	}
	return true;
}

int mediaDirectory_folder(char** path,int mediaType){//타입별 폴더 리턴
	filter_h filter = NULL;

	int ret = 0, mediaCount=0, ii;
	char buf[BUFLEN] = { '\0' };
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_filter_create(&filter);
	media_content_connect();
	mediaCount = mediaDirectory_count(mediaType);

	char* mPath = malloc(mediaCount * 512);

	mPath[0] = '\0';
	*path = mPath;

	switch (mediaType) {
	case 1:
		snprintf(buf, BUFLEN, "%s = %d", MEDIA_TYPE, MEDIA_CONTENT_TYPE_MUSIC);
		media_filter_set_condition(filter, buf, collate_type);
		ret = media_folder_foreach_folder_from_db(filter,(void*)_media_type_folder_db, mPath);//DB 검색후 폴더 콜백 호출
		break;
	case 2:
		snprintf(buf, BUFLEN, "%s = %d", MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO);
		media_filter_set_condition(filter, buf, collate_type);
		ret = media_folder_foreach_folder_from_db(filter,(void*)_media_type_folder_db, mPath);//DB 검색후 폴더 콜백 호출
		break;
	case 3:
		snprintf(buf, BUFLEN, "%s = %d", MEDIA_TYPE, MEDIA_CONTENT_TYPE_IMAGE);
		media_filter_set_condition(filter, buf, collate_type);
		ret = media_folder_foreach_folder_from_db(filter,(void*)_media_type_folder_db ,mPath);//DB 검색후 폴더 콜백 호출
		break;
	default:
		dlog_print(DLOG_ERROR, "tdlna", "media_Directory ERROR!");
		return 0;
		break;
	}

	mediaCount = 0;
	for(ii=0; mPath[ii] != '\0'; ii++){
		if(mPath[ii] == '|') mediaCount++;
	}

	media_content_disconnect();
	media_filter_destroy(filter);
	return mediaCount;
}

int mediaDirectory_count(int mediaType){//미디어 타입 별 폴더 갯수 리턴
	filter_h filter = NULL;
//	media_info_h _media_handle;
//	media_folder_h _media_folder;
	char buf[BUFLEN] = { '\0' };
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_filter_create(&filter);
	media_content_connect();
	int folderCount=0;
	switch (mediaType) {
	case 1:
		snprintf(buf, BUFLEN, "%s = %d", MEDIA_TYPE, MEDIA_CONTENT_TYPE_MUSIC);
		media_filter_set_condition(filter, buf, collate_type);
		break;
	case 2:
		snprintf(buf, BUFLEN, "%s = %d", MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO);
		media_filter_set_condition(filter, buf, collate_type);
		break;
	case 3:
		snprintf(buf, BUFLEN, "%s = %d", MEDIA_TYPE, MEDIA_CONTENT_TYPE_IMAGE);
		media_filter_set_condition(filter, buf, collate_type);
		break;
	default:
		dlog_print(DLOG_ERROR, "tdlna", "media_Directory ERROR!");
		return 0;
		break;
	}
	media_folder_get_folder_count_from_db(filter,&folderCount);
	media_content_disconnect();
	media_filter_destroy(filter);
	return folderCount;
}


bool _media_folder_db(media_folder_h folder,void *data){
	dlog_print(DLOG_INFO, "tdlna", "_media_folder_db 실행");
	char* folder_id;
	char *_folder_path;
	int ret = 0;
	ret = media_folder_get_folder_id(folder, &folder_id);
	check_returnValue(ret);
	dlog_print(DLOG_DEBUG,"tdlna","media_folder ID:%s",folder_id);
	ret = media_folder_get_path(folder,&_folder_path);
	check_returnValue(ret);
	dlog_print(DLOG_DEBUG,"tdlna","media Folder_path:%s",_folder_path);


	char* path = (char*)malloc(strlen(_folder_path)+1);
	strcpy(path,_folder_path);
	sendFolder(data,path);
	free(path);
	return true;
}

void media_Directory(void* data){
	//미디어 파일이 존재하는 폴더 검색
	filter_h filter = NULL;
//	media_info_h _media_handle;
//	media_folder_h _media_folder;
	int ret = 0 ;
	char buf[BUFLEN] = { '\0' };
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_filter_create(&filter);
	media_content_connect();

	snprintf(buf, BUFLEN, "%s = %d OR %s = %d OR %s = %d", MEDIA_TYPE,
			MEDIA_CONTENT_TYPE_IMAGE, MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO,MEDIA_TYPE,MEDIA_CONTENT_TYPE_MUSIC);
	//이미지,비디오,음악 파일의 미디어만 검색
	media_filter_set_condition(filter, buf, collate_type);

	ret = media_folder_foreach_folder_from_db(filter,_media_folder_db,data);//DB 검색후 폴더 콜백 호출
	check_returnValue(ret);
	media_content_disconnect();
	media_filter_destroy(filter);
}


int Meta_Get_from_path(void *appData, char *folderPath, int mediaType, _META** result) {// data : app_data, folderPath : 폴더경로,
	// 오디오(1), 비디오(2), 사진(3)
	dlog_print(DLOG_INFO, "tdlna", "Meta_Get_from_path(%s) mediaType:%d",folderPath,mediaType);
	//   app_data *appdata = appData;

	GList *all_item_list = NULL; // Include glib.h
	media_content_type_e media_type;
	media_info_h media_handle = NULL;
	char *media_id = NULL;
	char *media_name = NULL;
	char *media_path = NULL,*thumbnail_path=NULL;
	char buf[BUFLEN] = { '\0' };
	int ret = MEDIA_CONTENT_ERROR_NONE;
	int media_count = 0;
	int media_count2 = 0;
	unsigned long long media_size = 0;

	//meta type list
	int width, height, duration;
	char *title, *artist;
	char *album, *genre, *datetaken;
	int samplerate, bitrate, channels;
	char *Temp;

	time_t timer;
	struct tm *t;

	//폴더경로에서 /갯수 카운트
	int sCount1, sCount2, sIdx;

	timer = time(NULL); // 현재 시각을 초 단위로 얻기
	t = localtime(&timer); // 초 단위의 시간을 분리하여 구조체에 넣기

	_META* metaList = NULL;
	filter_h filter = NULL;
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_content_order_e order_type = MEDIA_CONTENT_ORDER_DESC;

	media_filter_create(&filter);

	switch(mediaType){
	case 1://오디오
		snprintf(buf, BUFLEN, "%s Like '%s' AND  %s = %d", MEDIA_PATH, folderPath, MEDIA_TYPE, MEDIA_CONTENT_TYPE_MUSIC);
		break;
	case 2://비디오
		snprintf(buf, BUFLEN, "%s Like '%s' AND  %s = %d", MEDIA_PATH, folderPath, MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO);
		break;
	case 3://사진
		snprintf(buf, BUFLEN, "%s Like '%s' AND  %s = %d", MEDIA_PATH, folderPath, MEDIA_TYPE, MEDIA_CONTENT_TYPE_IMAGE);
		break;
	default:
		dlog_print(DLOG_ERROR, "tdlna", "default");
		return 0;
		break;
	}
	//   ret = media_filter_set_offset(filter, 0, 20);
	ret = media_filter_set_condition(filter, buf, collate_type);
	if (ret != MEDIA_CONTENT_ERROR_NONE) {
		media_filter_destroy(filter);
		dlog_print(DLOG_INFO, "tdlna", "Failed to set condition");
	}
	ret = media_filter_set_order(filter, order_type, MEDIA_DISPLAY_NAME,
			collate_type);
	if (ret != MEDIA_CONTENT_ERROR_NONE) {
		media_filter_destroy(filter);
		dlog_print(DLOG_INFO, "tdlna", "Failed to set order");
	}

	media_content_connect();
	ret = media_info_foreach_media_from_db(filter, gallery_media_item_cb,
			&all_item_list);
	if (ret != MEDIA_CONTENT_ERROR_NONE) {
		dlog_print(DLOG_INFO, "tdlna","media_info_foreach_media_from_db failed: %d", ret);
		media_filter_destroy(filter);
	} else {//-------------------------------------------------------------------------------------
		int i, j, k;
		media_count =g_list_length(all_item_list);
		dlog_print(DLOG_INFO, "tdlna","media_count: %d", media_count);

		metaList = (_META*)malloc(sizeof(_META)*media_count);//tdlna로 전달하는 리스트
		memset(metaList, '\0' , sizeof(_META)*media_count);

		for (i = 0; i < media_count; i++)
		{
			_META metaData;
			memset(&metaData, '\0' , sizeof(_META));

			media_handle = (media_info_h) g_list_nth_data(all_item_list, i);
			media_info_get_media_id(media_handle, &media_id);
			media_info_get_media_type(media_handle, &media_type);

			ret = media_info_get_file_path(media_handle, &media_path); //미디어 경로를 구해온다.
			if(ret == MEDIA_CONTENT_ERROR_NONE){
				strcpy(metaData.path,media_path);
			}

			//체크박스 선택한 폴더만 통과시킴
			sIdx = 0;
			for(k=0; k < folder_length; k++){
				//체크박스에 체크한 경로들과 미디어 아이템의 부분 경로를 비교한다
				if(strncmp(media_path, sharing_folders[k], strlen(sharing_folders[k])) == 0){
					//체크한 경로가 포함되는 경우 나머지 경로에 /가 1개 이상 나오는지 체크 (하위폴더 미포함)
					if( strchr( (char*) media_path+strlen(sharing_folders[k]) + 1  , '/') == NULL ){
						sIdx = 1;
						break;
					}
				}
			}
			if(sIdx == 0) {
				free(media_path);
				continue;
			}

			//경로에서 /갯수를 카운트하여 비교 (하위폴더 미포함하기위함)
			sCount1 = sCount2 = sIdx = 0;
			while(folderPath[sIdx]) if(folderPath[sIdx++]=='/') sCount1++; //원래 설정한 경로
			sIdx = 0;
			while(media_path[sIdx]) if(media_path[sIdx++]=='/') sCount2++; //미디어 경로

			sCount1++;
//			dlog_print(DLOG_DEBUG, "tdlna", " 슬래시 카운트 %d == %d 아이템 경로: %s", sCount1, sCount2, media_path);

			if(sCount1 < sCount2 && sCount1 != 2) {
				// 슬래시 /갯수가 다르면 표시하지 않음
				free(media_path);
				continue;
			}

			ret = media_info_get_display_name(media_handle, &media_name);
			if(ret == MEDIA_CONTENT_ERROR_NONE){
				strcpy(metaData.title,media_name);
			}

			ret = media_info_get_thumbnail_path(media_handle,&thumbnail_path);
			if(ret == MEDIA_CONTENT_ERROR_NONE && thumbnail_path != NULL){
				strcpy(metaData.thumbnail_path, thumbnail_path);
			}
			ret = media_info_get_size(media_handle,&media_size);
			if(ret == MEDIA_CONTENT_ERROR_NONE){
				metaData.file_size = media_size;
			}

			sprintf(metaData.date[0], "%04d", t->tm_year + 1900);
			sprintf(metaData.date[1], "%02d", t->tm_mon + 1);
			sprintf(metaData.date[2], "%02d", t->tm_mday);
			sprintf(metaData.date[3], "%02d", t->tm_hour);
			sprintf(metaData.date[4], "%02d", t->tm_min);
			sprintf(metaData.date[5], "%02d", t->tm_sec);
			sprintf(metaData.date[6], "%02d", 0);

			title = artist = NULL;
			album = genre = datetaken = NULL;
			width = height = duration = 0;
			samplerate = bitrate = channels = 0;
			Temp = NULL;

			if (media_type == MEDIA_CONTENT_TYPE_IMAGE)
			{
				metaData.type = 3;      // 오디오(1), 비디오(2), 사진(3)
				image_meta_h image_handle;

				ret = media_info_get_image(media_handle, &image_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna",   "MEDIA_CONTENT_ERROR! imageMeta");
				} else {

					ret = image_meta_get_width(image_handle, &width);         //넓이
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.width = width;
					}

					ret = image_meta_get_height(image_handle, &height);         //높이
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.height = height;
					}

					ret = image_meta_get_date_taken(image_handle, &datetaken);   //만든날짜
					if(ret==MEDIA_CONTENT_ERROR_NONE && datetaken!=NULL){
						char* date = strtok(datetaken, ": ");
						strcpy(metaData.date[0], date);
						j = 1;
						while ((Temp = strtok(NULL, ": ")) != NULL) {
							strcpy(metaData.date[j++], Temp);
						}
					}
				}
				image_meta_destroy(image_handle);
				media_content_disconnect();
			}//END image
			else if (media_type == MEDIA_CONTENT_TYPE_VIDEO)
			{
				metaData.type = 2;
				video_meta_h video_handle;

				ret = media_info_get_video(media_handle, &video_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna",
							"MEDIA_CONTENT_ERROR! videoMeta");
				} else {
					ret = video_meta_get_width(video_handle,&width);
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.width = width;
					}

					ret = video_meta_get_height(video_handle,&height);
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.height = height;
					}

					ret = video_meta_get_duration(video_handle, &duration);
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.duration = duration;
					}

					ret = video_meta_get_artist(video_handle, &artist);
					if(ret==MEDIA_CONTENT_ERROR_NONE && artist != NULL){
						strcpy(metaData.artist, artist);
					}

					ret = video_meta_get_recorded_date(video_handle,&datetaken);
					if(ret==MEDIA_CONTENT_ERROR_NONE && datetaken!=NULL){
						char* date = strtok(datetaken, ": ");
						strcpy(metaData.date[0], date);
						j = 1;
						while ((Temp = strtok(NULL, ": ")) != NULL) {
							strcpy(metaData.date[j++], Temp);
						}
					}
				}

				video_meta_destroy(video_handle);
				media_content_disconnect();
			}// END video
			else if (media_type == MEDIA_CONTENT_TYPE_MUSIC)
			{
				// 오디오(1), 비디오(2), 사진(3)
				metaData.type = 1;
				audio_meta_h audio_handle;

				ret = media_info_get_audio(media_handle, &audio_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna","MEDIA_CONTENT_ERROR! audioMeta");
				} else {
					ret = audio_meta_get_artist(audio_handle,&artist);         //아티스트
					if(ret==MEDIA_CONTENT_ERROR_NONE && artist!=NULL){
						strcpy(metaData.artist, artist);
					}

					ret = audio_meta_get_album(audio_handle, &album);         //앨범
					if(ret==MEDIA_CONTENT_ERROR_NONE && album!=NULL){
						strcpy(metaData.album_name, album);
					}

					ret = audio_meta_get_genre(audio_handle, &genre);         //장르
					if(ret==MEDIA_CONTENT_ERROR_NONE && genre!=NULL){
						strcpy(metaData.genre, genre);
					}

					ret = audio_meta_get_duration(audio_handle, &duration);      //재생시간
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.duration = duration;
					}

					ret = audio_meta_get_bit_rate(audio_handle, &bitrate);      //비트레이트
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.bitrate = bitrate;
					}

					ret = audio_meta_get_sample_rate(audio_handle, &samplerate);   //샘플레이트
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.samplerate = samplerate;
					}

					ret = audio_meta_get_channel(audio_handle, &channels);         //채널
					if(ret==MEDIA_CONTENT_ERROR_NONE){
						metaData.channels = channels;
					}

					ret = audio_meta_get_recorded_date(audio_handle, &datetaken);
					if(ret==MEDIA_CONTENT_ERROR_NONE && datetaken!=NULL){
						char* date = strtok(datetaken, ": ");
						strcpy(metaData.date[0], date);
						j = 1;
						while ((Temp = strtok(NULL, ": ")) != NULL) {
							strcpy(metaData.date[j++], Temp);
						}
					}

				}
			}// END audio

			if(title) free(title);
			if(artist) free(artist);
			if(album) free(album);
			if(genre) free(genre);
			if(datetaken) free(datetaken);
			if(media_path) free(media_path);
			if(thumbnail_path) free(thumbnail_path);

			memcpy(&metaList[media_count2++], &metaData,sizeof(_META)); //값 복사
		}// END i for

		*result = metaList;
	}

	dlog_print(DLOG_DEBUG, "tdlna", " 미디어 아이템 갯수 %d", media_count2);
	return media_count2;
}
