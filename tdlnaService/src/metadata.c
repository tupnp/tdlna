#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <glib.h>
#include "main-app.h"
#include "metadata.h"
#include <dlog.h>

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

	snprintf(buf, BUFLEN, "%s Like '%s' AND %s = %d",MEDIA_PATH, path, MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO);
//	snprintf(buf, BUFLEN, "%s Like %s", MEDIA_PATH,"'/opt/usr/media/DCIM/Camera/%'");
	media_filter_set_condition(filter, buf, collate_type);
	ret = media_info_get_media_count_from_db(filter, &videoCount);
	check_returnValue(ret);
	dlog_print(DLOG_INFO, "tdlna", "비디오 갯수: %d",videoCount);

	snprintf(buf, BUFLEN, "%s Like '%s' AND %s = %d",MEDIA_PATH, path, MEDIA_TYPE, MEDIA_CONTENT_TYPE_IMAGE);
	media_filter_set_condition(filter, buf, collate_type);
	ret = media_info_get_media_count_from_db(filter,&imageCount);
//	check_returnValue(ret);
	dlog_print(DLOG_INFO, "tdlna", "이미지 갯수: %d",imageCount);

	snprintf(buf, BUFLEN, "%s Like '%s' AND %s = %d",MEDIA_PATH, path, MEDIA_TYPE,MEDIA_CONTENT_TYPE_MUSIC);
	media_filter_set_condition(filter, buf, collate_type);
	ret = media_info_get_media_count_from_db(filter,&musicCount);
//	check_returnValue(ret);
	dlog_print(DLOG_INFO, "tdlna", "음악 갯수: %d",musicCount);

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
bool _media_folder_db(media_folder_h folder,void *data){
	dlog_print(DLOG_INFO, "tdlna", "_media_folder_db 실행");
	char* folder_id;
	char *_folder_path;
	int ret = 0;
	ret = media_folder_get_folder_id(folder, folder_id);
	check_returnValue(ret);
	dlog_print(DLOG_DEBUG,"tdlna","media_folder ID:%d",folder_id);
	ret = media_folder_get_path(folder,&_folder_path);
	check_returnValue(ret);
	dlog_print(DLOG_DEBUG,"tdlna","media Folder_path:%s",_folder_path);


	char* path = (char*)malloc(strlen(_folder_path)+1);
	strcpy(path,_folder_path);
	sendFolder(data,path);
}

void media_Directory(void* data){
	//미디어 파일이 존재하는 폴더 검색
	filter_h filter = NULL;
	media_info_h _media_handle;
	media_folder_h _media_folder;
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

void Meta_Get(app_data *appdata) {
	GList *all_item_list = NULL; // Include glib.h
	media_content_type_e media_type;
	media_info_h media_handle = NULL;
	char *media_id = NULL;
	char *media_name = NULL;
	char *media_path = NULL;
	char buf[BUFLEN] = { '\0' };
	int ret = MEDIA_CONTENT_ERROR_NONE;
	filter_h filter = NULL;
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_content_order_e order_type = MEDIA_CONTENT_ORDER_DESC;

	media_filter_create(&filter);

	// Set the condition
	snprintf(buf, BUFLEN, "%s = %d OR %s = %d OR %s = %d", MEDIA_TYPE,
					MEDIA_CONTENT_TYPE_IMAGE, MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO,MEDIA_TYPE,MEDIA_CONTENT_TYPE_MUSIC);
	//snprintf(buf, BUFLEN, "%s = %d", FOLDER_STORAGE_TYPE, MEDIA_CONTENT_STORAGE_EXTERNAL);
	//snprintf(buf, BUFLEN, "%s = 'Tizen'", MEDIA_ARTIST);
	//snprintf(buf, sizeof(buf), "MEDIA_PATH=\'%s\'", "/opt/usr/media/DCIM/Camera/");
	ret = media_filter_set_offset(filter, 0, 20);
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

//		appdata->metaIndex = 0;
	media_content_connect();
	ret = media_info_foreach_media_from_db(filter, gallery_media_item_cb,
			&all_item_list);
	if (ret != MEDIA_CONTENT_ERROR_NONE) {
		dlog_print(DLOG_INFO, "tdlna",
				"media_info_foreach_media_from_db failed: %d", ret);
		media_filter_destroy(filter);
	} else {

		int i;
		for (i = 0; i < g_list_length(all_item_list); i++) {
			//-------------------------------------------미디어 검색
			_META metaData;		// = meta_create();
			media_handle = (media_info_h) g_list_nth_data(all_item_list, i);
			media_info_get_media_id(media_handle, &media_id);
			media_info_get_media_type(media_handle, &media_type);
			media_info_get_display_name(media_handle, &media_name);
			media_info_get_file_path(media_handle, &media_path);

			if (media_type == MEDIA_CONTENT_TYPE_IMAGE) {
				metaData.type = 3;		// 비디오(1), 오디오(2), 사진(3)
				image_meta_h image_handle;
				media_content_orientation_e orientation = 0;
				int width = 0, height = 0;
				char *datetaken = NULL;
				char *burst_id = NULL;

				ret = media_info_get_image(media_handle, &image_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna",
							"MEDIA_CONTENT_ERROR! imageMeta");
				} else {
					image_meta_get_width(image_handle, &width);

					image_meta_get_height(image_handle, &height);

					image_meta_get_orientation(image_handle, &orientation);

					image_meta_get_date_taken(image_handle, &datetaken);

					image_meta_get_burst_id(image_handle, &burst_id);

					dlog_print(DLOG_INFO, "tdlna", "----I M E A G E-----");
					dlog_print(DLOG_INFO, "tdlna",
							"Width : %d, Height : %d, Orientation : %d, Date taken : %s",
							width, height, orientation, datetaken);
					if (datetaken != NULL) {
						char* date;
						date = strtok(datetaken, ": ");
						//dlog_print(DLOG_INFO, "tdlna", "date[%d]: %s", 0, date);
						strcpy(metaData.date[0], date);
						int i = 1;
						while ((date = strtok(NULL, ": ")) != NULL) {
							//dlog_print(DLOG_INFO, "tdlna", "date[%d]: %s", i, date);
							strcpy(metaData.date[i++], date);
							//i++;
						}
					}


						metaData.width = width;
						metaData.height = height;
						//strcpy(metaData.date,datetaken);
						strcpy(metaData.title,media_name);
						strcpy(metaData.path,media_path);

						appdata->meta = (_META*)malloc(sizeof(_META));
						memcpy(appdata->meta, &metaData, sizeof(_META));
				}
				dlog_print(DLOG_INFO,"tdlna","appdata meta: %s",appdata->meta->title);
				if (datetaken)
					free(datetaken);
				if (burst_id)
					free(burst_id);
				image_meta_destroy(image_handle);
			} else if (media_type == MEDIA_CONTENT_TYPE_VIDEO) {
//					metaData->type = 1;
				video_meta_h video_handle;
				char *title = NULL, *artist = NULL, *album = NULL,
						*album_artist = NULL;
				int duration = 0;
				time_t time_played = 0;

				ret = media_info_get_video(media_handle, &video_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna",
							"MEDIA_CONTENT_ERROR! videoMeta");
				} else {
					video_meta_get_artist(video_handle, &artist);

					video_meta_get_album(video_handle, &album);

					video_meta_get_album_artist(video_handle, &album_artist);

					video_meta_get_duration(video_handle, &duration);

					video_meta_get_played_time(video_handle, &time_played);

					dlog_print(DLOG_INFO, "tdlna", "-----V I D E O----");
					dlog_print(DLOG_INFO, "tdlna",
							"Title: %s, Album: %s, Artist: %s, Album_artist: %s \n Duration: %d, Played time: %d",
							title, album, artist, album_artist, duration,
							time_played);
				}

				free(artist);
				free(album);
				free(album_artist);
				media_content_disconnect();
				video_meta_destroy(video_handle);
			} else if (media_type == MEDIA_CONTENT_TYPE_MUSIC) {
//					metaData->type = 2;
				dlog_print(DLOG_INFO, "tdlna", "-----M U S I C----");

			}
			dlog_print(DLOG_INFO, "tdlna", "media_id [%d] : %s", i, media_id);
			dlog_print(DLOG_INFO, "tdlna", "media_name [%d] : %s", i,
					media_name);
			dlog_print(DLOG_INFO, "tdlna", "media_path [%d] : %s", i,
					media_path);

			free(media_id);
			free(media_name);
			free(media_path);
			//free(title);
		}
	}
}

int Meta_Get_from_path(void *_data, char *folder_path, _META** result) {

	dlog_print(DLOG_INFO, "tdlna", "Meta_Get_from_path(%s)",folder_path);
//	app_data *appdata = _data;

	GList *all_item_list = NULL; // Include glib.h
	media_content_type_e media_type;
	media_info_h media_handle = NULL;
	char *media_id = NULL;
	char *media_name = NULL;
	char *media_path = NULL,*thumbnail_path=NULL;
	char buf[BUFLEN] = { '\0' };
	int ret = MEDIA_CONTENT_ERROR_NONE;
	int media_count = 0;
	unsigned long long media_size = 0;
	_META* metaList = NULL;
	filter_h filter = NULL;
	media_content_collation_e collate_type = MEDIA_CONTENT_COLLATE_NOCASE;
	media_content_order_e order_type = MEDIA_CONTENT_ORDER_DESC;

	media_filter_create(&filter);
	// Set the condition
//	snprintf(buf, BUFLEN, "%s Like '%s'",MEDIA_PATH, folder_path);//!!!

	snprintf(buf, BUFLEN, "%s Like '%s' AND  (%s = %d OR %s = %d  OR %s = %d)", MEDIA_PATH, folder_path, MEDIA_TYPE,
					MEDIA_CONTENT_TYPE_IMAGE, MEDIA_TYPE, MEDIA_CONTENT_TYPE_VIDEO,MEDIA_TYPE,MEDIA_CONTENT_TYPE_MUSIC);

//	ret = media_filter_set_offset(filter, 0, 20);
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
		int i;
		media_count =g_list_length(all_item_list);

		metaList = (_META*)malloc(sizeof(_META)*media_count);//tdlna로 전달하는 리스트
		for (i = 0; i < media_count; i++) {
			//-------------------------------------------미디어 검색
			_META metaData;		// = meta_create();
			media_handle = (media_info_h) g_list_nth_data(all_item_list, i);
			media_info_get_media_id(media_handle, &media_id);
			media_info_get_media_type(media_handle, &media_type);
			media_info_get_display_name(media_handle, &media_name);
			media_info_get_file_path(media_handle, &media_path);
			media_info_get_thumbnail_path(media_handle,&thumbnail_path);
			media_info_get_size(media_handle,&media_size);

			strcpy(metaData.title,media_name);
			strcpy(metaData.path,media_path);
			metaData.file_size = media_size;

			if (media_type == MEDIA_CONTENT_TYPE_IMAGE) {
				dlog_print(DLOG_ERROR, "tdlna",	"MEDIA_CONTENT_TYPE_IMAGE~~~");
				metaData.type = 3;		// 오디오(1), 비디오(2), 사진(3)
				image_meta_h image_handle;
				media_content_orientation_e orientation = 0;
				int width = 0, height = 0;
				char *datetaken = NULL;
				char *burst_id = NULL;

				ret = media_info_get_image(media_handle, &image_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna",	"MEDIA_CONTENT_ERROR! imageMeta");
				} else {
					image_meta_get_width(image_handle, &width);

					image_meta_get_height(image_handle, &height);

					image_meta_get_orientation(image_handle, &orientation);

					image_meta_get_date_taken(image_handle, &datetaken);

					image_meta_get_burst_id(image_handle, &burst_id);

					dlog_print(DLOG_INFO, "tdlna", "----I M E A G E-----");
					dlog_print(DLOG_INFO, "tdlna","Width : %d, Height : %d, Orientation : %d, Date taken : %s",
							width, height, orientation, datetaken);
					if (datetaken != NULL) {
						char* date;
						date = strtok(datetaken, ": ");
						strcpy(metaData.date[0], date);
						dlog_print(DLOG_INFO, "tdlna", "date[%d]: %s", 0, date);
						int i = 1;
						while ((date = strtok(NULL, ": ")) != NULL) {
							strcpy(metaData.date[i++], date);
							dlog_print(DLOG_INFO, "tdlna", "date[%d]: %s", i, date);
						}
					}
						metaData.width = width;
						metaData.height = height;
				}
				if (datetaken)
					free(datetaken);
				if (burst_id)
					free(burst_id);
				image_meta_destroy(image_handle);
			} else if (media_type == MEDIA_CONTENT_TYPE_VIDEO) {
				metaData.type = 2;
				video_meta_h video_handle;
				char *title = NULL, *artist = NULL, *album = NULL,*album_artist = NULL,*datetoken=NULL;
				int duration = 0,width=0,height=0;
				time_t time_played = 0;

				ret = media_info_get_video(media_handle, &video_handle);
				if (ret != MEDIA_CONTENT_ERROR_NONE) {
					// Error handling
					dlog_print(DLOG_ERROR, "tdlna",
							"MEDIA_CONTENT_ERROR! videoMeta");
				} else {
					video_meta_get_artist(video_handle, &artist);

					video_meta_get_album(video_handle, &album);

					video_meta_get_album_artist(video_handle, &album_artist);

					video_meta_get_duration(video_handle, &duration);

					video_meta_get_played_time(video_handle, &time_played);

					video_meta_get_width(video_handle,&width);

					video_meta_get_height(video_handle,&height);

					video_meta_get_recorded_date(video_handle,&datetoken);


					dlog_print(DLOG_INFO, "tdlna", "-----V I D E O----");
					dlog_print(DLOG_INFO, "tdlna","Title: %s, Album: %s, Artist: %s, Album_artist: %s \n Duration: %d, Played time: %d",
							title, album, artist, album_artist, duration,
							time_played);
					if (datetoken != NULL) {
						char* date;
						date = strtok(datetoken, ": ");
						dlog_print(DLOG_INFO, "tdlna", "date[%d]: %s", 0, date);
						strcpy(metaData.date[0], date);
						int i = 1;
						while ((date = strtok(NULL, ": ")) != NULL) {
							dlog_print(DLOG_INFO, "tdlna", "date[%d]: %s", i, date);
							strcpy(metaData.date[i++], date);
							//i++;
						}
					}
					strcpy(metaData.thumbnail_path, thumbnail_path);
					metaData.width = width;
					metaData.height = height;
					//strcpy(metaData.date,datetoken);
				}

				free(artist);
				free(album);
				free(album_artist);
				media_content_disconnect();
				video_meta_destroy(video_handle);
			} else if (media_type == MEDIA_CONTENT_TYPE_MUSIC) {
				// 오디오(1), 비디오(2), 사진(3)
				metaData.type = 1;
				dlog_print(DLOG_INFO, "tdlna", "-----M U S I C----");
			}

			dlog_print(DLOG_INFO, "tdlna", "media_id [%d] : %s", i, media_id);
			dlog_print(DLOG_INFO, "tdlna", "media_name [%d] : %s", i, media_name);
			dlog_print(DLOG_INFO, "tdlna", "media_path [%d] : %s", i, media_path);
			dlog_print(DLOG_INFO, "tdlna", "thumbnail_path:%s",thumbnail_path);
			dlog_print(DLOG_INFO, "tdlna", "file_size [%d] : %d", i, metaData.file_size);

			free(media_id);
			free(media_name);
			free(media_path);
			//free(title);
			memcpy(&metaList[i],&metaData,sizeof(_META));
			dlog_print(DLOG_INFO, "tdlna", "리스트 metaList 1 :%s",metaList[1].path);
		}//------------------end for ---------------
	}

	*result = metaList;
	return media_count;
}

void Meta_Get_Video(char *path, _META *meta) {

}
void Meta_Get_Image(char *path, _META *meta) {
	image_meta_h head;
}
void Meta_Get_Audio(char *path, _META *meta) {
	audio_meta_h head;
}
