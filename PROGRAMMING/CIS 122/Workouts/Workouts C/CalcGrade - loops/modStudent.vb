Module modStudent

	Public Sub RunProject()

		'Name: Calc Grade - loop
		'Purpose: Determine a student's letter grade
		'Author: Michael Passalacqua
		'Date: 10/21/12

		'>>> You've seen a variation of this code before.  It determines a student's letter grade by getting the maximum points possible in the class, getting the student's points, calculating the student's percentage, and then using a multiple-choice IF statement to display the student's lettter grade. The difference this time around is that we're giving the user the option to enter the points for another student.  Take a look at the code.

		'Variables
		Dim iStudentPoints As Integer = 0
		Dim iMaxPoints As Integer = 0
		Dim dNumberGrade As Double = 0
		Dim sLetterGrade As String = ""
		Dim sResponse As String = ""


		'Begin Code
		SetTitle("Calc Grade - Loops")

		Display("Enter maximum points: ")
		iMaxPoints = ReadInteger()

		'>>> There's no sense in getting the maximum points repeatedly. That's not going to change.
		'We use the Do... Loop variation because we want the loop to run at least once.
		'Notice that shortly before the end of the loop, we are prompting the user, i.e. asking them if they want to continue. We capture their response, store it in a variable, and convert it to lowercase (in case they entered a capital Y or N).
		'Then, in our loop condition, we test to see if they entered "y". Our loop will repeat AS LONG AS sResponse = "y". If then entered anything else, we pop out of the loop and our program ends.
		'Examine the code, run it, and examine it again to be sure you understand what's going on.

		Do
			Display("Enter student points: ")
			iStudentPoints = ReadInteger()

			dNumberGrade = (iStudentPoints / iMaxPoints) * 100

			DisplayLine()

			DisplayLine("The percentage is " & dNumberGrade)

			If dNumberGrade >= 90 Then
				DisplayLine("The letter grade is A")
			ElseIf dNumberGrade >= 80 Then
				DisplayLine("The letter grade is B")
			ElseIf dNumberGrade >= 70 Then
				DisplayLine("The letter grade is C")
			ElseIf dNumberGrade >= 60 Then
				DisplayLine("The letter grade is D")
			Else
				DisplayLine("The letter grade is F")
			End If

			DisplayLine()
			Display("Another student? (Y/N) ")
			sResponse = ReadChar()
			sResponse = sResponse.ToLower
			DisplayLine(Enter)
		Loop While sResponse = "y"


	End Sub


End Module
