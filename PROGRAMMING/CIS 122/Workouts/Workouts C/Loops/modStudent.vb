Module modStudent

	Public Sub RunProject()

		'Name: Loops
		'Purpose: Demonstrates the basics of using loops
		'Author: Michael Passalacqua
		'Date: 10/17/14

		'>>> Be sure you have read the assigned Course Notes before doing this or any other workout

		'Variables
		Dim iFirstNumber As Integer
		Dim iLastNumber As Integer


		'Begin Code
		SetTitle("Loops")

        '>>> Next - display numbers 1 thru 10. Run the program.


        '>>> Next - is there a better way to do this?  what if we had to do 1 to 100, or 1000?
        'Comment out the above code that displays the numbers. Uncomment the following section:
        '  Dim i As Integer 'remember that the variable i should really be declared up above with the other variables.
        'The following code accomplishes the same results as the previous code, but much more efficiently.
        ' Comment out the previous section, uncomment this one, and run the program:
        ' i = 1
        ' While i <= 10
        ' DisplayLine(i)
        ' i = i + 1
        '  End While


        '>>> Next - same as before, but use a variable for the ending number. Comment out the previous section, uncomment this one, and run the program:
        '  i = 1
        ' iLastNumber = 10
        ' While i <= iLastNumber
        '  DisplayLine(i)
        '  i = i + 1
        ' End While


        '>>> Next - now let's get the ending number from the user.  Comment out the previous section, uncomment this one, and run the program:
        ' i = 1
        '   Display("Enter last number: ")
        '  iLastNumber = ReadInteger()
        '  While i <= iLastNumber
        '  DisplayLine(i)
        '  i = i + 1
        '  End While


        '>>> Next - The standard While loop has its condition at the very *beginning*, at the top of the loop.  Sometimes, however, you want to be sure that the loop runs at least once before possibly quitting. Here's where the Do... Loop variation comes in. It works exactly the same as the standard While loop except that the condition is at the *end* (the bottom) of the loop.  Comment out the previous section, uncomment this one, and run the program:
        '  i = 1
        '   iLastNumber = 10
        '  Do
        ' DisplayLine(i)
        '      i = i + 1
        ' Loop While i <= iLastNumber


        '>>> Next - The For loop is a fairly different animal. This example is displaying the numbers 1 thru 10, just like our initial example with the While loop.  But there are a couple of differences. I'll defer to the Course Notes for a full explanation. Comment out the previous section, uncomment this one, and run the program:
        '  DisplayLine("For Loop")
        '  For i As Integer = 1 To 10
        ' DisplayLine(i)
        '  Next


        '>>> Next - Let's use a variable for the final number. Comment out the previous section, uncomment this one, and run the program:
        ' iLastNumber = 10
        '  For i As Integer = 1 To iLastNumber
        ' DisplayLine(i)
        ' Next


        '>>> Next - get both the first and last number from the user. Comment out the previous section, uncomment this one, and run the program:
        Display("Enter first number: ")
        iFirstNumber = ReadInteger()

        Display("Enter last number: ")
        iLastNumber = ReadInteger()

        For i As Integer = iFirstNumber To iLastNumber
            DisplayLine(i)
        Next

    End Sub

End Module
