Module modStudent

	Public Sub RunProject()

		'Name: Add2Numbers
		'Purpose: Adds 2 numbers and displays the total
		'Author: Michael Passalacqua
		'Date: 

		'Variables
		'>>> Declare variables to hold the first number, second number, and total
		Dim iFirstNumber As Integer
		Dim iSecondNumber As Integer
		Dim iTotal As Integer


		'Begin Code
		SetTitle("Add Two Numbers")

		'>>> Prompt the user for the first number. Uncomment & run.
		Display("Enter the first number: ")
		iFirstNumber = ReadInteger()


		'>>> Prompt the user for the second number. Uncomment & run.
		Display("Enter the second number: ")
		iSecondNumber = ReadInteger()


		'>>> Add the two numbers and store in iTotal. Uncomment.
		SetBackgroundColor(Color.Red)	'change the background color of the text to red
		iTotal = iFirstNumber + iSecondNumber

		'>>> Can you figure out what this line of code is doing?  Uncomment & run.
		DisplayLine(iFirstNumber & " + " & iSecondNumber & " = " & iTotal)


		'>>> Next: Multiplication - Uncomment next section & run.
		iTotal = iFirstNumber * iSecondNumber

		DisplayLine(NL & iFirstNumber & " * " & iSecondNumber & " = " & iTotal)


		'>>> Next: Working with decimal numbers
		'>>> There is a Decimal data type, but for reasons that are too complicated to explain, we will be using VBs Double data type whenever we work with decimal numbers.	 Let's declare a variable to use with decimal numbers.
		'>>> Uncomment the next section & run:
		Dim dPrice As Double

		Display("Enter price: ")
		dPrice = ReadDecimal() '>>> We can use the ReadDecimal or ReadDouble function (either is fine).

		DisplayLine()
		DisplayLine("Price: " & dPrice)


	End Sub

End Module
