Module modStudent

	Public Sub RunProject()

		'Name: Add2Numbers - loop
		'Purpose: Adds 2 numbers and displays the total. Allow user to quit when they want.
		'Author: Michael Passalacqua
		'Date:

		'Variables
		Dim dFirstNumber As Double
		Dim dSecondNumber As Double
		Dim dTotal As Double
		Dim sResponse As String


		'Begin Code
		SetTitle("Add Two Numbers - Loop")

        '>>> You've seen this code before.  It requests two numbers from the user, adds them together and displays the output. The difference, this time, is 
        ' that it gives the user the option of continuing to do it repeatedly.
        'It's using the Do... Loop variation of the While loop, where the condition is at the *bottom* of the loop. We definitely want to run thru the code at
        'least once, so we use the variation.
        'Notice that shortly before the end of the loop, we are prompting the user, i.e. asking them if they want to continue. We capture their response, store
        'it in a variable, And Convert it to lowercase (in case they entered a capital Y or N).
        'Then, in our loop condition, we test to see if they entered "y". Our loop will repeat AS LONG AS sResponse = "y". If then entered anything else, we pop out
        'of the loop and our program ends.
        'Examine the code, run it, and examine it again to be sure you understand what's going on.

        Do
			Display("Enter the first number: ")
			dFirstNumber = ReadDouble()

			Display("Enter the second number: ")
			dSecondNumber = ReadDouble()

			SetBackgroundColor(Color.Red)

			dTotal = dFirstNumber + dSecondNumber

			DisplayLine(dFirstNumber & " + " & dSecondNumber & " = " & dTotal)

			ResetBackgroundColor()

			DisplayLine(Enter)

			Display("Do you want to continue? (Y/N) ")
			sResponse = ReadChar()
			sResponse = sResponse.ToLower

			DisplayLine()
		Loop While sResponse = "y"

	End Sub

End Module
