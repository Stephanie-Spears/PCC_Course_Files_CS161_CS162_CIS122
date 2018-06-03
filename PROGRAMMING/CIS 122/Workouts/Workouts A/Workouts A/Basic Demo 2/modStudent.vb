Module modStudent

	Public Sub RunProject()

		'Name: CIS 122 Basic Demo 2
		'Purpose: This program asks the user to enter a number between 1 and 100. If it matches our "winning number", they win a million dollars.
		'Author: Michael Passalacqua
		'Date:

		'Variables
		'>>> Our winning number and the user's number:
		Dim iWinningNumber As Integer = 16
		Dim iUsersNumber As Integer = 0


		'Begin Code
		SetTitle("CIS 122 Basic Demo 2")

		SetForegroundColor(Color.Yellow)

		'>>> A basic IF statement in VB.  Uncomment & run
		'If 10 > 2 Then
		'DisplayLine("10 is greater than 2")
		'End If

		'>>> Comment out the previous section, and uncomment the following section. Run.
		Display("Enter a number between 1 and 100: ")
		iUsersNumber = ReadInteger()

		'>>> Now let's uncomment the code that tests if the user entered in the winning number. Run it.
		If iUsersNumber = iWinningNumber Then
			DisplayLine("Congratulations! You win a million dollars!!!")
		Else
			SetBackgroundColor(Color.Red)
			DisplayLine("You suck!")
			ResetBackgroundColor()
		End If

		'>>> Try re-running the code using both the winning number and any non-winning number

		'>>> Make it more sophisticated. The winning number is hard-coded as 16, but our Reference Guide describes a random number function (GetRandomNumber) that can be used to make the winning number different every time the program runs. 

	End Sub

End Module
