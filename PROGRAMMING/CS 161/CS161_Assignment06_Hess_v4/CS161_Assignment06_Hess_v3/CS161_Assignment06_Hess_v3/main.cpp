// *************************************************************************************************
// * Author: Kristine Hess                                                                         *
// * Assignment 06                                                                                 *
// *                                                                                               *
// * This program uses user defined functions and a user defined header function to get a start    *
// * and an end time from the user, validate the input is the correct data type and within the     *
// * appropriate range, calculate the difference between the times, and print the difference in    *
// * the format HH:MM.                                                                             *
// *************************************************************************************************

#include <iostream>
#include <iomanip>
#include <string>
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include "GetValue.h"

using namespace std;

void getTime(string type2, int& hours, int& minutes);
int diffTime(int startHours, int startMinutes, int endHours, int endMinutes);
void displayTime(int diff);

// Main Body of program, uses user defined functions to get startTime and endTime, calculate diffTime, 
// and display in the format HH:MM.

int main()
{

	// Define Variables

	int startHours, startMinutes, endHours, endMinutes;
	int diff;
	string type2;

	// Use getTime to get start and end times in hours and minutes

	cout << "\nCalculating the Difference Between Two Times" << endl;
	cout << "(Using the 24 Hour Clock)" << endl << endl << endl;
	type2 = "start time";
	cout << "Enter the starting time...\n" << endl;
	getTime(type2, startHours, startMinutes);
	cout << endl;
	type2 = "end time";
	cout << "Enter the ending time...\n" << endl;
	getTime(type2, endHours, endMinutes);

	// Use diffTime to calculate difference between start and ends times

	diff = diffTime(startHours, startMinutes, endHours, endMinutes);

	// Use displayTime to print time in HH:MM format

	system("CLS");											// Clear Screen

	cout << endl << endl << endl;
	cout << "The difference between ";
	printf("%02d:%02d", startHours, startMinutes);
	cout << " and ";
	printf("%02d:%02d", endHours, endMinutes);
	cout << " is: ";
	displayTime(diff);
	cout << endl << endl;
	
	return(0);
}

// user Defined Function to use header file "GetValue.h" to input hours and minutes and validate for input type and value

void getTime(string type2, int& hours, int& minutes)
{
	string type;

	type = "hours";
	hours = GetValue(type, 0, 23);

	type = "minutes";
	minutes = GetValue(type, 0, 59);

	cout.precision(2);
	cout << "Your " << type2 << " is: ";
	printf("%02d:%02d", hours, minutes);

	Sleep(1000);

}

// User Defined Function to calculate the difference in minutes between startTime and endTime

int diffTime(int startHours, int startMinutes, int endHours, int endMinutes)
{
	int startTime, endTime, diff;

	startTime = ((startHours * 60) + startMinutes);
	endTime = ((endHours * 60) + endMinutes);

	if (startTime <= endTime)									// Loop (if else) - Calculates time diff
		diff = (endTime - startTime);

	else
		diff = ((endTime + 1440) - startTime);					// endTime occurs before startTime; add 24 hours to account for day change

	return diff;
}

// User Defined Function to print time diff in format HH:MM

void displayTime(int diff)
{
	int hh, mm;

	cout.precision(2);											// Set to print 2 significant digits, including leading zeros
	hh = (diff / 60);
	mm = (diff % 60);

	printf("%02d:%02d", hh, mm);
}