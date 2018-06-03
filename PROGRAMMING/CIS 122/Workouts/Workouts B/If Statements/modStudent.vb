Imports System.IO	'DO NOT DELETE

Module modStudent

	Public Sub RunProject()
		'Name: If Statement
		'Purpose: Demos basic If statements
		'Author: Michael Passalacqua
		'Date: 10/21/14


		'Variables
		Dim iNumber1 As Integer


		'Begin Code
		SetTitle("If Statements")
		iNumber1 = 5

		'>>> Next: Uncomment and run
		If iNumber1 = 5 Then
			DisplayLine("Number is equal to 5")
		End If

		'>>> Comment out previous section, and uncomment this section and run
		iNumber1 = 6
		If iNumber1 = 5 Then
			DisplayLine("Number is equal to 5")
		End If


		'>>> Comment out previous section (except for the variable assignment), and uncomment this section and run
		If iNumber1 >= 5 Then
			DisplayLine("Number is greater than or equal to 5")
		End If

		'Using an Else
		'>>> Comment out previous section, and uncomment this section and run
		If iNumber1 >= 5 Then
			DisplayLine("Number is greater than or equal to 5")
		Else
			DisplayLine("Number is less than 5")
		End If

		'>>> Comment out previous section, and uncomment this section and run
		iNumber1 = 4
		If iNumber1 >= 5 Then
			DisplayLine("Number is greater than or equal to 5")
		Else
			DisplayLine("Number is less than 5")
		End If

	End Sub

End Module