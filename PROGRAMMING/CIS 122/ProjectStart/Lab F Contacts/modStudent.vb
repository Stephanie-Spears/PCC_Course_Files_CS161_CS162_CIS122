Imports System.IO	'DO NOT DELETE

Module modStudent

    Public Sub RunProject()
        'Project Header:
        'Name: Contacts
        'Purpose: 	Reads a file that contains a list of contact information
        'Author: 	Stephanie Spears
        'Date: 		5/18/2016

        'Constants
        Const c_sFilePath As String = "Contacts.txt"
        Const c_sLineBreak As String = "----------------------------------------------------------------------------"

        'Variables
        Dim FileInput As StreamReader
        Dim sName As String
        Dim sAddress As String
        Dim sPhone As String
        Dim sEmail As String


        'Begin Code
        SetTitle("Contacts")

        FileInput = File.OpenText(c_sFilePath)


        While FileInput.Peek <> -1
            GetLine("Name ")
            sName = FileInput.ReadLine
            DisplayLine(sName & NL)

            GetLine("Address ")
            sAddress = FileInput.ReadLine & NL & FileInput.ReadLine & ", " & FileInput.ReadLine & " " & FileInput.ReadLine
            DisplayLine(sAddress & NL)

            GetLine("Phone ")
            sPhone = FileInput.ReadLine
            DisplayLine(sPhone & NL)

            GetLine("Email ")
            sEmail = FileInput.ReadLine
            DisplayLine(sEmail)

            GetLine(c_sLineBreak & NL & NL)

        End While


        FileInput.Close()


    End Sub

    Public Sub GetLine(p_sMsg As String)

        SetForegroundColor(Color.Gold)
        SetFontBold()
        DisplayLine(p_sMsg)
        SetFontNormal()
        SetForegroundColor(Color.Goldenrod)

    End Sub

End Module