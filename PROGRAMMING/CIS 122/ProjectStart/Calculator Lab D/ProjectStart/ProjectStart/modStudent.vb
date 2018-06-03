Imports System.IO	'DO NOT DELETE

Module modStudent

	Public Sub RunProject()
        'Project Header:
        'Name:		Calculator
        'Purpose: 	Calculator that can do simple functions
        'Author: 	Stephanie Spears
        'Date: 		5/8/2016

        'Variables
        Dim dFirstNum As Double
        Dim dSecondNum As Double
        Dim sOpSym As String
        Dim sResponse As String
        Dim dResult As Double

        'Begin Code
        SetTitle("Calculator")
        SetForegroundColor(color.yellow)

        Do
            Display("Enter first number: ")
            dFirstNum = ReadDouble()

            SetBackgroundColor(Color.Red)
            DisplayLine(NL & "Add(+)" & NL & "Subtract(-)" & NL & "Multiply(*)" & NL & "Divide(/)" & NL)
            ResetBackgroundColor()

            Display("Enter operation symbol: ")
            sOpSym = ReadChar()

            DisplayLine()
            Display("Enter second number: ")
            dSecondNum = ReadDouble()

            DisplayLine()
            SetBackgroundColor(Color.Red)

            If sOpSym = "+" Then
                dResult = dFirstNum + dSecondNum
            ElseIf sOpSym = "-" Then
                dResult = dFirstNum - dSecondNum
            ElseIf sOpSym = "*" Then
                dResult = dFirstNum * dSecondNum
            ElseIf sOpSym = "/" Then
                dResult = dFirstNum / dSecondNum
            Else
                DisplayLine()
            End If

            DisplayLine((dFirstNum & " " & sOpSym & " " & dSecondNum & " = ") & (FormatNumber(dResult)) & NL)
            ResetBackgroundColor()

            Display("Continue? (Y/N) ")
            sResponse = ReadChar()
            sResponse = sResponse.ToLower
            DisplayLine()

        Loop While sResponse = "y"

    End Sub

End Module