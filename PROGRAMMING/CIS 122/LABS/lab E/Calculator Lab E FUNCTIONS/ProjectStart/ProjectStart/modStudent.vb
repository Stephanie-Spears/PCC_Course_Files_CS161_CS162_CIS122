Imports System.IO	'DO NOT DELETE

Module modStudent

    Dim g_sName As String

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

        Call GetName()

        Display("Welcome, " & g_sName & "!" & NL)

        Do
            dFirstNum = GetNumber("Enter first number: ")

            DisplayLine("Add(+)" & NL & "Subtract(-)" & NL & "Multiply(*)" & NL & "Divide(/)" & NL)
            ResetBackgroundColor()

            Display("Enter operation symbol: ")
            sOpSym = ReadChar()


            While (sOpSym <> "+") And (sOpSym <> "-") And (sOpSym <> "/") And (sOpSym <> "*")

                SetBackgroundColor(Color.Red)
                SetFontBold()
                Display(NL)

                DisplayLine("Error: Enter a valid operator")
                ResetBackgroundColor()
                SetFontNormal()
                Display(NL)

                Display("Enter operation symbol: ")
                sOpSym = ReadChar()

            End While


            dSecondNum = GetNumber("Enter second number: ")

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

        Loop While sResponse = "y"

    End Sub

    Public Sub GetName()

        SetForegroundColor(Color.Yellow)
        SetFontFamily("Ariel")
        Display("Enter your name: ")
        g_sName = ReadString()

    End Sub


    Public Function GetNumber(p_sMsg As String) As Double

        Dim dNum As Double

        DisplayLine()
        Display(p_sMsg)
        dNum = ReadDouble()
        SetBackgroundColor(Color.Red)
        DisplayLine()

        Return dNum

    End Function

End Module