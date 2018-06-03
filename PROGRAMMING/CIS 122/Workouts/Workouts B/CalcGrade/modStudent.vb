Module modStudent

	Public Sub RunProject()

		'Name: Calc Grade
		'Purpose: Determine a student's letter grade
		'Author: Michael Passalacqua
		'Date: 10/21/14

		'>>> This program accepts the total number of points a student received in a class, along with the maximum points possible.
		'The student 's percentage in the class is calculated (between 0 and 100), and we use an IF statement to display the student's letter grade, where greater than or equal to 90 is an A, etc.

		'Variables
		Dim iStudentPoints As Integer	'>>> used to hold the student's points
		Dim iMaxPoints As Integer '>>> the maximum points possible
		Dim dNumberGrade As Double	'>>> the student's percentage (between 0 and 100) - this is a decimal. We will be using VBs Double data type for all decimal variables in this class.


		'Begin Code
		SetTitle("Calculate Grade")

        'Get the student's points
        '>>> Uncomment this section & run
        Display("Enter student's points: ")
        iStudentPoints = ReadInteger()

        'Get maximum points
        '>>> Next: Uncomment & run
        Display("Enter maximum points: ")
        iMaxPoints = ReadInteger()

        'Calculate the student's percentage
        '>>> Next: Uncomment & run
        dNumberGrade = (iStudentPoints / iMaxPoints) * 100

        '>>> Next: First version - in this version, we are using FOUR SEPARATE IF statements to determine the student's letter grade. Uncomment the section & run.
        'Enter 650 for the student's points and 1000 for the max points. Student should get a D.
        'Run it again, but enter 950 for the student's points. Notice what happens.  Why?

        '>>> All 4 IF statements are running, so even if student gets over 90, their grade is also over 80, over 70, and over 60.  NO GOOD!


        '>>> Next: Correct version - using the ElseIf.
        'What we have below is ONE SINGLE IF statement instead of four. I like call this the "multiple-choice If statement". VB starts at the top of the IF and looks for a matching condition.  As soon as it finds one, it runs the actions inside that "branch" of the If statement and jumps to the End If.  No other branches of the If statement are even looked at.  See the Course Notes for more info.  You are reading them, right???
        'Uncomment & run using various input
        If dNumberGrade >= 90 Then
            DisplayLine("The letter grade is A")
        ElseIf dNumberGrade >= 80 Then
            DisplayLine("The letter grade is B")
        ElseIf dNumberGrade >= 70 Then
            DisplayLine("The letter grade is C")
        ElseIf dNumberGrade >= 60 Then
            DisplayLine("The letter grade is D")
        Else 'next add the Else
            DisplayLine("The letter grade is F")
        End If

        '>>> Notice that the Else at the bottom handles the situation where the student gets less than 60 - an F.  

    End Sub

End Module
