Imports System.IO	'DO NOT DELETE

Module modStudent

	'>>> These are GLOBAL variables. They can be seen and accessed from ANYWHERE in this program. At first, we won't be using them.
	Dim g_sFirstName As String
	Dim g_sMiddleName As String
	Dim g_sLastName As String
	Dim g_sName As String


	Public Sub RunProject()

		'Name: Make Full Name - V4
		'Purpose: Use functions to construct a person's full name from their first, middle, and last name
		'Author: Michael Passalacqua
		'Date: 10/21/14


		'Begin Code
		SetTitle("Make Full Name - V4")

		Call DisplayDescription()

		'>>> As I said in the previous version, we 're just warming up.  Here's our previous code.  Take one last look at it and commen it out.
		g_sPrompt = "Enter your first name: "
		Call PromptForName()
		g_sFirstName = g_sName

		g_sPrompt = "Enter your middle name: "
		Call PromptForName()
		g_sMiddleName = g_sName

		g_sPrompt = "Enter your last name: "
		Call PromptForName()
		g_sLastName = g_sName
		'>>> END SECTION

		'>>> Next - Notice that, now, each time we call PromptForName, we have some text inside of the parentheses - the prompt message.  What's going on here?  Well, first of all, re-read the Course Notes on Parameters, because that's what we're doing here. When we call PromptForName, we are passing a parameter to it. We've actually been doing this all term.  For example, when call DisplayLine(), we usually have some text in between the parens.  DisplayLine is a subroutine, and it can take one parameter - the string you want to display.  PromptForName is very similar.  Take a close look at the new and improved PromptForName right now and see how it does that.
		'
		Call PromptForName("Enter your first name: ")
		g_sFirstName = g_sName

		Call PromptForName("Enter your middle name: ")
		g_sMiddleName = g_sName

		Call PromptForName("Enter your last name: ")
		g_sLastName = g_sName
		'>>> END SECTION


		Call MakeFullName()


		ResetColors()
		SetFontNormal()
		ResetFontSize()
		DisplayLine(NL & NL & "Thank you!")

	End Sub


	Public Sub DisplayDescription()

		SetForegroundColor(Color.Yellow)
		SetBackgroundColor(Color.Red)
		SetFontItalic()
		DisplayLine("This program will prompt you to enter your first name, your middle name, and your last name. After doing so, it will display your full name.")
		ResetColors()
		SetFontNormal()
		DisplayLine(NL)

	End Sub


	Public Sub MakeFullName()

		'Uses global variables

		DisplayLine()
		SetForegroundColor(Color.Yellow)
		Display("Your full name is ")
		SetForegroundColor(Color.Red)
		SetFontSize(14)
		Display(g_sFirstName & " " & g_sMiddleName & " " & g_sLastName)

	End Sub


	Public Sub PromptForName(p_sPrompt As String)	'Demonstrates use of parameters

		'This function takes one parameter,  p_sPrompt, which it uses to prompt the user for a first name, middle name, or last name, depending on whatever p_sPrompt is set to.  How does p_sPrompt get set, you ask?  When we call PromptForName in our main sub, we have a string inside of the parenentheses. That string gets assigned to p_sPrompt.


		SetFontSize(13)
		SetFontBold()
		SetForegroundColor(Color.Yellow)

		Display(p_sPrompt)

		ResetFontSize()
		SetFontNormal()
		SetFontItalic()
		SetForegroundColor(Color.LightGreen)

		g_sName = ReadString()

	End Sub

End Module