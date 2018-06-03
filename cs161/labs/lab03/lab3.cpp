#include <iostream>
#include <cmath>


using namespace std;

int main()
{

	int P;
	int R;
	int T;
	double A;
	int i;

	cout << "Enter starting balance: ";
	cin >> P;

	while (cin.fail())
	{
		cout << "Please enter an integer value." << '\n' << "Enter starting balance: ";
		cin.clear();
		cin.ignore(200, '\n');
		cin >> P;
	}

	cin.clear();
	cin.ignore(200, '\n');

	cout << "Enter interest rate: ";
	cin >> R;

	while (cin.fail())
	{
		cout << "Please enter an integer value." << '\n' << "Enter interest rate: ";
		cin.clear();
		cin.ignore(200, '\n');
		cin >> R;
	}

	cin.clear();
	cin.ignore(200, '\n');

	cout << "Enter number of years: ";
	cin >> T;

	while (cin.fail())
	{
		cout << "Please enter an integer value." << '\n' << "Enter number of years: ";
		cin.clear();
		cin.ignore(200, '\n');
		cin >> T;
	}

	cin.clear();
	cin.ignore(200, '\n');
	cout << '\n';

	for (i = 1; i <= T; i++)
	{
		A = P*(pow(((R / 100.00) + 1.00), i));
		cout << '\n' << "Year " << i << " " << "$" << A;
	}
	cout << endl;

	return(0);
}
