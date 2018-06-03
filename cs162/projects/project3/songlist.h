#ifndef SONGLIST_H
#define SONGLIST_H

#include <iostream>
#include <cstring>
#include <fstream>
#include "song.h"

class SongList
{
public:
	void addSong(Song);
	void removeSong(int);

	void loadSongs();
	void saveSongs();

	int length();

	void printSong(int);

	void searchAlbum(char[]);
	void searchArtist(char[]);

private:
	Song list[100];
	int index = 0;
};

#endif