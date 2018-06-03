#include <iostream>

using namespace std;

void doAverage(int x, int y)
{
	int sum = x + y;
	int average = sum / 2;

	cout << "Average of " << x << " and " << y << " is " << average << endl;

}

void doGCD(int x, int y)
{
	while (x != y)
	{
		if (x > y)
		{
			x -= y;
		}
		else
		{
			y -= x;
		}
	}

	cout << "GCD = " << x << endl;

}


void doLCM(int x, int y)
{
	int max;
	max = (x > y) ? x: y;

		do
		{
			if (max%x == 0 && max%y == 0)
			{
				cout << "LCM = " << max << endl;
				break;
			}
			else
			{
				++max;
			}
		}
		while (true);

}

void doFactorial(int x, int y)
{
	int i;
	if (x && y > 0)
	{
		cout << "Factors of " << x << " are: " << endl;
		{
			for (i = 1; i <= x; ++i)
				if (x%i == 0)
				{
					cout << i << " ";
				}
			cout << endl;
		}
		cout << "Factors of " << y << " are: " << endl;
		{
			for (i = 1; i <= y; ++i)
				if (y%i == 0)
				{
					cout << i << " ";
				}
			cout << endl;
		}
		//is this how factors work? Below?
		if (x%y == 0)
		{
			cout << y << " is a factor of " << x << endl;
		}
		else
		{
			cout << y << " is not a factor of " << x << endl;
		}
	}
	else
	{
		cout << "Enter positive integers only, please try again." << endl;
	}
}

void doAddition(int x, int y)
{
	int sum = x + y;
	cout << x << " + " << y << " = " << sum << endl;

}
