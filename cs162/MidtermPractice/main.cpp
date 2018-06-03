#include <iostream>
#include <cstring>
#include "array.h"

using namespace std;
const int CAP = 100;


int main()
{
int list[CAP];
int size = 10;
int newInt = 0;
int position = 0;
int even;
build(list, size);

display(list, size);

    //PLEASE PUT YOUR CODE HERE to call the function assigned

even = numOfEven(list, size);
cout << "Amount of even numbers in array: " << even << endl << endl;


cout << "Number to insert: ";
cin >> newInt;
cin.clear();
cin.ignore(100, '\n');
cout << "Position to insert between 0-" << (size) << ":" << endl;
cin >> position;
cin.clear();
cin.ignore(100, '\n');

insert(list, size, newInt, position);

cout << "List after insertion: " << endl << endl;

display(list, size);

return 0;
}
