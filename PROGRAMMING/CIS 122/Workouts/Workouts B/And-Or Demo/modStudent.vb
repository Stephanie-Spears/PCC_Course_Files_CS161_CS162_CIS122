Module modStudent

	Public Sub RunProject()

		'Name: And-Or Demo
		'Purpose: Demo use of And and Or in If statements
		'Author: Michael Passalacqua
		'Date: 1/27/15

		'Variables
		Dim sDay As String



		'Begin Code
		SetTitle("And-Or Demo")

        'Working with "Or"
        '>>> Get the day of the week from the user.  Uncomment next section and run. First, enter "sunday". Then try it with "monday".  Then, enter "Sunday" (capital S).
        Display("Enter day of week: ")
        sDay = ReadString()
        sDay = sDay.ToLower

        If sDay = "sunday" Or sDay = "saturday" Then
            DisplayLine("It's a weekend")
        Else
            DisplayLine("It's a weekday")
        End If
        '>>> It doesn't work properly when you enter "Sunday". Programming languages are very exact, i.e. "Sunday" does not equal "sunday". If we want our program to behave as if they are equal, then we need to convert the input to lowercase.  So, uncomment the following line of code and move it before the If statement. Then run it again


        '>>> Next: Now, try entering "frogday" and see what happens.  No good. Let's fix that:

        '>>> Next: comment out previous If statement and uncomment this one.
        If sDay = "saturday" Or sDay = "sunday" Then
            DisplayLine("It's a weekend")
        ElseIf sDay = "monday" Or sDay = "tuesday" Or sDay = "wednesday" Or sDay = "thursday" Then
            DisplayLine("It's a weekday")
        ElseIf sDay = "friday" Then
            DisplayLine("Happy Friday!")
        Else
            DisplayLine("Invalid day")
        End If
        '>>> Now, it handles everything correctly.
        '>>> Notice how the "Or" operator works. Remember to read the Course Notes.



        'Working with "And"
        '>>> Next: Comment out all previous code, except for setting the title.

        'Guess the combination
        'We have 3 randomly generated numbers between 1 and 10. If the user guesses all three of these numbers correctly, they win.

        '>>> Uncomment the section  below. Technically, the variable declarations should be declared in the Variables section above, but we can leave them here for now.
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iNumber3 As Integer
        Dim iUsersNumber1 As Integer
        Dim iUsersNumber2 As Integer
        Dim iUsersNumber3 As Integer


        '>>> We are assigning random numbers to our integer variables.  Look up the GetRandomNumber function in the Reference Guide
        '>>> Uncomment the next section of code
        iNumber1 = GetRandomNumber(10)
        iNumber2 = GetRandomNumber(10)
        iNumber3 = GetRandomNumber(10)

        '>>> For debugging purposes, let's display those random numbers. Uncomment the run.
        DisplayLine("iNumber1 = " & iNumber1)
        DisplayLine("iNumber2 = " & iNumber2)
        DisplayLine("iNumber3 = " & iNumber3)


        '>>> Next: Uncomment next section.  
        SetFontSize(20)
        SetForegroundColor(Color.Cornsilk)
        DisplayLine("Guess the combination!" & NL)
        ResetFontSize()
        ResetForegroundColor()

        Display("Enter a number between 1 and 10: ")
        iUsersNumber1 = ReadInteger()

        Display("Enter a second number between 1 and 10: ")
        iUsersNumber2 = ReadInteger()

        Display("Enter a third number between 1 and 10: ")
        iUsersNumber3 = ReadInteger()


        '>>> Next: Uncomment and run
        'If iUsersNumber1 = iNumber1 And iUsersNumber2 = iNumber2 And iUsersNumber3 = iNumber3 Then
        '	DisplayLine("You guessed it!")
        'Else
        '	DisplayLine("Sorry, try again.")
        'End If
        '>>> In this case, ALL THREE numbers must match for the user to win. So we have to use the "And" operator. What would change if we used "Or" instead?


        '>>> Next: Comment previous section and uncoment this section, and run. This time, just enter ONE of the correct numbers, and see what happens.
        'If iUsersNumber1 = iNumber1 Or iUsersNumber2 = iNumber2 Or iUsersNumber3 = iNumber3 Then
        '	DisplayLine("You win a trip to Detroit!")
        'Else
        '	DisplayLine("Sorry, try again.")
        'End If

    End Sub

End Module
