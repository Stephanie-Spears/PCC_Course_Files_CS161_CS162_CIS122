#include <iostream>
#include <iomanip>
using namespace std;

void fill(int **p, int rowSize, int columnSize);
void print(int **p, int rowSize, int columnSize);

int main()
{
	int ** table;
	int rows = 10;
	int columns = 9;

	//create the rows of tables	

	table = new int* [rows];

	for (int i = 0; i < rows; i++)
	{
		table[i] = new int[columns];
	}

	//insert elements into table
	fill(table, rows, columns);

	//output the elemnets of table
	print(table, rows, columns);

	for (int i = 0; i < rows; i++)
	{
		delete [] table[i];
	}

	delete [] table;
	return  0;
}

void fill(int **p, int rowSize, int columnSize)
{
	int a = 0;
	for (int i = 0; i < rowSize; i++)
	{
		for (int x = 0; x < a; x++)
		{
			p[i][x] = x;
		}
		a++;
	}
}


void print(int **p, int rowSize, int columnSize)
{
	int a = 0;

	for (int i = 0; i < rowSize; i++)
	{
		for (int x = 0; x < a; x++)
		{
			cout << setw(2) << p[i][x];
		}
		a++;
		cout << endl;
	}
}
