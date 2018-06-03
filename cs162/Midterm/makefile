OBJS = main.o array.o supplied.o
CC = g++
DEBUG = -g
CFLAGS = -Wall -c $(DEBUG)
LFLAGS = -Wall $(DEBUG)
CPPFLAGS = -Wall -g -std=c++11

main:	 main.o array.o supplied.o

main.o:	 array.h

supplied.o:	array.h

.PHONY: clean
clean:
	$(info -- cleaning the directory --)

	$(info -- should say rm -f *.o if i want to remove .o files --)
	$(info -- but this lab has a .o file given from the teacher--)
	$(info -- that I dont know if i should mess with --)

	rm -f main
