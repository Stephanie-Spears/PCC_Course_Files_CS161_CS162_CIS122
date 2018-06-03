#include "array.h"
using namespace std;

const int CAP = 100;
int main()
{
	int list[CAP];
	int size = 10;
	int sum;
	int target;
    build(list, size);
    display(list, size);

    //PLEASE PUT YOUR CODE HERE to call the function assigned
sum = sumOfArray(list, size);
cout << "sum of array is: " << sum << endl << endl;

cout << "enter a target number to delete: ";
cin >> target;


remove(list, size, target);
cout << "after remove function: " << endl << endl;

    display(list, size);
    
    return 0;
}
