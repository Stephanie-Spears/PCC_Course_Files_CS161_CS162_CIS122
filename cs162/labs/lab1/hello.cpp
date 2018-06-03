#include <iostream>
using namespace std;

int main()
{

	int userInput = 0;
	int i = 0;

	cout << "How many greetings do you want?!" << endl;
	cin >> userInput;

	while (cin.fail()) 
	{
		cin.clear();
		cin.ignore();
		cout << "No, silly! 'How many' is a numbers question! Enter a NUMBER!" << endl;
		cin >> userInput;
	}

	for (i = 0; i < userInput; i++)
	{
		cout << "Hello world, from Stephanie x" << i << " !" << endl;
	}

	return 0;
}
