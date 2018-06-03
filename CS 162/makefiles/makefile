OBJS = supplied.o main.o array.o
CC = g++
DEBUG = -g
CPPFLAGS = -Wall -std=c++11 $(DEBUG)

proj:	$(OBJS)
	$(CC) $(CPPFLAGS) $(OBJS) -o proj

supplied.o:	array.h

main.o:	array.h


.PHONY:	clean
clean:
	$(info -- cleaning the directory --)
	rm -f *.o
	rm -f proj

.PHONY: tar
tar:
	$(info-- making a tar file --)
	tar cfv proj.tar main.cpp array.cpp array.h


