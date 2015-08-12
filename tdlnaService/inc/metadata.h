#ifndef __METADATA_H__
#define __METADATA_H__

typedef struct meta_struct{
	int 	type;			// 비디오(1), 오디오(2), 사진(3)
	char	title[64];			// 제목
	char	extension[8];		// 확장자
	char 	artist[64];		// 아티스트
	char 	path[512];			// 경로
	unsigned int duration;		// 재생 시간
	unsigned int width;			// 넓이
	unsigned int height;		// 높이
	unsigned int bitrate;		// 품질 ex)오디오 비트레이트(192Kbps, 128Kbps..)
	unsigned int channels;		// 채널
	unsigned int samplerate;	// 오디오 샘플 빈도수(44.1KHz, 22KHz ..)
	char date[7][5];//날짜
}_META;

_META* meta_create();

void media_Count(int *videoCount,int *imageCount,int *musicCount);
void check_returnValue(int ret);
void Meta_Get();
void Meta_Get_Video(char *path, _META *meta);
void Meta_Get_Image(char *path, _META *meta);
void Meta_Get_Audio(char *path, _META *meta);

#endif
