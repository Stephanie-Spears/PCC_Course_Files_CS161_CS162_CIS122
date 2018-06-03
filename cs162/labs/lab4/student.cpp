#include "student.h"

//implement the required 3 functions here

Student::Student(const char initID[], double initGPA)
{
	strcpy(id, initID);
	gpa = initGPA;
}

void Student::print() const
{
	cout << id << '\t' << gpa << endl;
}

bool Student::isLessThanByID(const Student& aStudent) const
{
	if ((strcmp(aStudent.id, id)) < 0)
	{
		return false;
	}
	else
	{
		return true;
	}
}

bool Student::isLessThanByGpa(const Student& aStudent) const
{
	if (aStudent.gpa < gpa)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}
