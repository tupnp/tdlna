#ifndef __METADATA_H__
#define __METADATA_H__
#include <media_content.h>
#include <metadata_extractor.h>

typedef struct meta_struct{
	int    type;            // 오디오(1), 비디오(2), 사진(3)
	char   title[128];         // 제목
	char   extension[10];      // 확장자
	char    artist[64];         // 아티스트
	char    path[512];         // 경로
	char    thumbnail_path[512];// 경로
	char    album_name[64];      // 앨범 이름
	char    genre[64];         // 장르
	char   date[7][5];         // 날짜 년/월/일/시/분/초
	unsigned int duration;      // 재생 시간
	unsigned int width;         // 넓이
	unsigned int height;      // 높이
	unsigned int bitrate;      // 품질 ex)오디오 비트레이트(192Kbps, 128Kbps..)
	unsigned int channels;      // 채널
	unsigned int samplerate;   // 오디오 샘플 빈도수(44.1KHz, 22KHz ..)
	unsigned long long file_size;//파일크기
}_META;

_META* meta_create();

void media_Count(int *videoCount,int *imageCount,int *musicCount,char *path);
// 오디오(1), 비디오(2), 사진(3)
void check_returnValue(int ret);
void media_Directory(void *data);
int mediaDirectory_folder(char** path,int mediaType);//타입별 폴더 찾기
int mediaDirectory_count(int mediaType);//타입별 폴더 갯수 리턴
bool _media_type_folder_db(media_folder_h folder,char *retPath);//타입별 폴더 경로 리턴
bool _media_folder_db(media_folder_h folder,void *data);
int Meta_Get_from_path(void *data,char *folder_path,int mediaType,_META **metaList);

#endif
