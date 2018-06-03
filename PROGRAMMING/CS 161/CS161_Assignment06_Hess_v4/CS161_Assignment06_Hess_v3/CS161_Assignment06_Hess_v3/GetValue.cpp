#include <iostream>
#include <iomanip>
#include <string>
#include "GetValue.h"

using namespace std;

int GetValue(string type, int min, int max)
{
	// Declare Variables

	bool retest = true;
	string str_value;
	char first;
	int sign, StringLength, count, position, count2, position2, value, error;

	StringLength = 0;

	while (retest == true)										// Loop A (Get End Value and Test)
	{
		sign = 1;												// Set/reset flags and counters
		StringLength = 0;
		count = 0;
		position = 0;
		value = 0;
		error = 0;

		cout << type << ": ";									// Ask user for appropriate information
		getline(cin, str_value);								// Get user entered value

		if (str_value.empty())									//Loop A1 (If Else)- Check for empty string
			error = 1;											// error 1 flag
		
		else
		{
			first = str_value.at(0);							// Read 1st character of string

			if ((first < 46) && (first > 44))					// Loop A1a (Remove leading '-' sign)
			{
				str_value.erase(0, 1);
				sign = -1;										// Set variable to make final int negative
				first = 0;
			}

			if (str_value.empty())								// Loop A1b Retest shortened string for empty string
				error = 1;
				
			StringLength = (str_value.length());

			while ((count < (StringLength)))					// Loop A1c (Tests each character for numeric content)
			{
				position = str_value.at(count);

				if (isdigit(position))							// Loop A1cI (If Else)
					++count;									// Adds one to count variable; evaluate next character of string

				else
					break;										// Breaks loop A1c when non numeric value is returned (including " ", ".", and "-")
																// Count at exit = number of digits found before invalid character
			}

			if ((count == (StringLength)) && (!(error == 1)))	// Loop A1d (If Else)
			{													// Only enter loop if all characters in string are numeric

				count2 = 0;										// Set/reset counters & variable for conversion
				position2 = 0;

				while ((count2 < (StringLength)))				// Loop A1dI (Convert characters in string to integer)
				{
					position2 = str_value.at(count2);
					value = (value * 10) + (position2 - 48);	// Multiplies previous end by 10 and adds numeric value of ASCII char	 
					++count2;									// Adds one to count, allows next character of string to be read
				}
			}

			else
			{
				error = 2;
				value = 0;
			}

			value = (value * sign);								// Returns trimmed '-' sign from string to int value

			if (error == 0)										// Loop A1e - Enter only if no other error has already been flagged 
			{
				if (value < min)								// Check range, set error flags
					error = 3;

				else if (value > max)
					error = 4;

				else
					retest = (!(true));							// Value in range, set retest to false
			}
		}

		if (error > 0)											// Loop A2 (Prints error statement ande returns to loop A)
		{
			if (error == 1)
				cout << "You have failed to enter a number of " << type << ". Please try again";

			if (error == 2)
				cout << "You have entered an invalid number of " << type << ". Please try again";

			if (error == 3)
				cout << "You have entered an invalid number of " << type << ". \nPlease enter an integer greater than or equal to " << min << ".";

			if (error == 4)
				cout << "You have entered an invalid number of " << type << ". \nPlease enter an integer less than or equal to " << max << ".";

			cout << endl << endl;
		}
	}
		
	return value;

}