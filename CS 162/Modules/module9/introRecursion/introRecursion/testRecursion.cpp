/* This program demonstrates the concept of recursion.

   Written by: Li Liang
   Date: 09/29/2009

   Sources: None
*/

#include <iostream>                 
#include "InputTools.h"

using namespace std;    

int factLoop(int n);
int factRecursion(int n);

int main()
{
	int number = readInt("Please enter a number: ");
	int result1 = factLoop(number);
	int result2 = factRecursion(number);

	cout << endl << "factLoop(" << number << ") = " << result1 << endl;
	cout << endl << "factRecursion(" << number << ") = " << result2 << endl;

	return 0;
}

/* This function uses iteration to calculate n!.
   in: n where n >= 0
   return: n!
*/
int factLoop(int n)
{
	int result = 1;
	while (n > 1)
	{
		result *= n;
		n--;
	}
	return result;
}

/* This function uses recursion to calculate n!.
   in: n where n >= 0
   return: n!
*/
int factRecursion(int n)
{
	if(n == 0 || n == 1)
		return 1;
	else
		return n * factRecursion(n-1);
}