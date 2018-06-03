// Get user input (string) and check that it contains only numerals, convert string value to double, and test that  
// double value is greater than or equal to zero. Print error statement and get new user input if invalid.

double GetValue(string Question, int min)
{
	// Declare Variables

	string str_value;
	int retest, StringLength, position, position2, count, count2;
	double value;

	cout.precision(10);

	retest = 0;												// Reset Counters
	StringLength = 0;

	while (retest == 0)										// Loop A (Get End Value and Test)
	{
		cout << Question;									// Ask user for appropriate information
		cin >> str_value;									// Get user entered value and determine string length
		cout << endl;
		StringLength = (str_value.length());

		count = 0;											// Set/reset count and position for validity test
		position = 0;

		while ((count < (StringLength)))					// Loop A1 (Tests each character for numeric content)
		{
			position = str_value.at(count);

			if (isdigit(position))							// Loop A1a (If Else)
				++count;									// Adds one to count variable; evaluate next character of string

			else
				break;										// Breaks loop B1 when non numeric value is returned (including " ", ".", and "-"
			// Count at exit = number of digits found before invalid character
		}

		if (count == (StringLength))						// Loop A2 (If Else)
		{													// Only enter loop if all characters in string are numeric

			count2 = 0;										// Set/reset counters & variable for conversion
			position2 = 0;
			value = 0;

			while ((count2 < (StringLength)))				// Loop A2a (Convert characters in string to integer)
			{
				position2 = str_value.at(count2);
				value = (value * 10) + (position2 - 48);	// Multiplies previous end by 10 and adds numeric value of ASCII char	 
				++count2;									// Adds one to count , allows next character of string to be read
			}
		}

		else
			value = 0;

		if (value >= min)									// Loop A3 (Checks for valid numeric value)											
			retest = 1;

		if (retest == 0)									// Loop A4 (Prints error statement ande returns to loop A
		{
			cout << "You have entered an invalid value. Please enter an integer greater than zero.";
			cout << endl << endl;
			cin.clear();									// Reset cin for new user input in loop A
			cin.ignore(1000, '\n');
		}

	}
	return value;
}
