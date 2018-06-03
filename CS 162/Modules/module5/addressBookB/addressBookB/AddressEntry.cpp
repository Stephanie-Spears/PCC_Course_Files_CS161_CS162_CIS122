/* The implementation file for class AddressEntry.

   Written by: Li Liang
   Date: 09/29/2009

   Sources: None
*/

#include "AddressEntry.h"
#include <iostream>
using namespace std;

/* Default constructor. It initializes the name and email to a default value.
*/
AddressEntry::AddressEntry()
{
	strcpy(name, "no name");
	strcpy(email, "no email");
}

/* Constructor. It initializes the name and email with the passed in value.
   in: name and email
*/
AddressEntry::AddressEntry(const char name[], const char email[])
{
	strcpy(this->name, name);	//this->name refers to the instance variable "name"
	strcpy(this->email, email); //this->email refers to the instance variable "email"
}

/* This function returns the name of the entry through the parameter.
   out: name
*/
void AddressEntry::getName(char name[]) const
{
	strcpy(name, this->name);
}

/* This functions returns the email of the entry through the parameter.
   out: email
*/
void AddressEntry::getEmail(char email[]) const
{
	strcpy(email, this->email);
}

/* This function prints the state of the object to stdout.
*/
void AddressEntry::print() const
{
	cout << name << " -> " << email << endl;
}

/* This function sets the name to the passed in value.
   in: name
*/
void AddressEntry::setName(const char name[])
{
	strcpy(this->name, name);
}

/* This function sets the email to the passed in value.
   in: email
*/
void AddressEntry::setEmail(const char email[])
{
	strcpy(this->email, email);
}
