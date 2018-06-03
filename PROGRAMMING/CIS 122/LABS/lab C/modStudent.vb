Imports System.IO	'DO NOT DELETE

Module modStudent

	Public Sub RunProject()
        'Project Header:
        'Name:		DeathByCigarettes
        'Purpose: 	Displays average number of deaths per year by cigarette brand, and calculates a "death tax"
        'Author: 	Stephanie Spears
        'Date: 		4/7/2016

        'Variables
        Dim sBrand1Name As String = "BreatheEasy"
        Dim sBrand2Name As String = "BlackLung"
        Dim sBrand3Name As String = "CancerStix"
        Dim sBrand4Name As String = "TastySmokes"

        Dim sBrand1Deaths As String = "1,000,000"
        Dim sBrand2Deaths As String = "2,000,000"
        Dim sBrand3Deaths As String = "5,000,000"
        Dim sBrand4Deaths As String = "10,000,000"

        Dim sBrand1Tax As String = "1.80"
        Dim sBrand2Tax As String = "4.50"
        Dim sBrand3Tax As String = "10.00"
        Dim sBrand4Tax As String = "20.00"

        Dim sUserBrand As String

        'Begin Code
        SetTitle("Death by Cigarettes")
        DisplayLine("Cigarette Brands" & NL)
        SetBackgroundColor(Color.Red)
        DisplayLine("1-" & sBrand1Name & NL & "2-" & sBrand2Name & NL & "3-" & sBrand3Name & NL & "4-" & sBrand4Name & NL)
        ResetBackgroundColor()
        Display("Enter the number of your brand: ")
        sUserBrand = ReadChar()
        SetBackgroundColor(Color.Red)

        If sUserBrand = "1" Then
            DisplayLine(NL & sBrand1Name & " causes " & sBrand1Deaths & " deaths per year" & NL & "Your death tax is $" & sBrand1Tax)
        ElseIf sUserBrand = "2" Then
            DisplayLine(NL & sBrand2Name & " causes " & sBrand2Deaths & " deaths per year" & NL & "Your death tax is $" & sBrand2Tax)
        ElseIf sUserBrand = "3" Then
            DisplayLine(NL & sBrand3Name & " causes " & sBrand3Deaths & " deaths per year" & NL & "Your death tax is $" & sBrand3Tax)
        ElseIf sUserBrand = "4" Then
            DisplayLine(NL & sBrand4Name & " causes " & sBrand4Deaths & " deaths per year" & NL & "Your death tax is $" & sBrand4Tax)
        Else
            DisplayLine("Error: Enter 1 through 4")
        End If

    End Sub

End Module