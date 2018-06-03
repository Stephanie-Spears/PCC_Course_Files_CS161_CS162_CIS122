//array.cpp 

#include "array.h"

//put the implementations of your assigned functions her

int sumOfArray(int list[], int size)
{
	int sum = 0;
	for (int i = 0; i < size; i++)
	{
		sum += list[i];
		
	}

return sum;
}

int remove(int list[], int& size, int target)
{
int position; 
	
	for (int i = 0; i < size; i++)
	{
		if (list[i] == target)
		{
			position = i;
			size--;
		}
	}

	for (int i = position; i < size; i++)
	{
		list[i] = list[i+1];
		//list[size-1] = 0;
	}
return 0;
}
