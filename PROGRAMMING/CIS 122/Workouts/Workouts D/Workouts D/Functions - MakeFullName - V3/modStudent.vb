Imports System.IO	'DO NOT DELETE

Module modStudent

	'>>> These are GLOBAL variables. They can be seen and accessed from ANYWHERE in this program. At first, we won't be using them.
	Dim g_sFirstName As String
	Dim g_sMiddleName As String
	Dim g_sLastName As String
	Dim g_sPrompt As String
	Dim g_sName As String


	Public Sub RunProject()

		'Name: Make Full Name - V3
		'Purpose: Use functions to construct a person's full name from their first, middle, and last name
		'Author: Michael Passalacqua
		'Date: 10/21/14


		'Begin Code
		SetTitle("Make Full Name - V3")

		Call DisplayDescription()

		'>>> As I said in the previous version, we 're just warming up.  Here's our previous code.  Comment it out. We no longer need the SetFormatting and ResetFormatting subroutines, so you can comment those out as well, or delete them if you wish.
		Call SetFormatting()
		Display("Enter your first name: ")
		Call ResetFormatting()
		g_sFirstName = ReadString()


		Call SetFormatting()
		Display("Enter your middle name: ")
		Call ResetFormatting()
		g_sMiddleName = ReadString()


		Call SetFormatting()
		Display("Enter your last name: ")
		Call ResetFormatting()
		g_sLastName = ReadString()
		'>>> END SECTION

		'>>> Next - This version makes use of global variables for both the prompt message to the user, and the name variable.  Uncomment this section, study everything, esp the PromptForName sub down below.
		'The first time we call PromptForName, we're setting g_sPrompt to "Enter your first name: ".  PromptForName will make use of g_sPrompt to prompt the user for input. When it gets that input, it will assign it to the global var g_sName. Then, when we return from our call to PromptForName, we simply take g_sName and assign it to g_sFirstName.
		'We go thru a similar process for the middle name and the last name.  Ultimately we're setting things up for MakeFullName - remember, it makes use of the those 3 global variables (g_sFirstName, g_sMiddleName, and g_sLastName) to do its thing.
		'When you feel like you understand what's going on, run the code.

		'g_sPrompt = "Enter your first name: "
		'Call PromptForName()
		'g_sFirstName = g_sName

		'g_sPrompt = "Enter your middle name: "
		'Call PromptForName()
		'g_sMiddleName = g_sName

		'g_sPrompt = "Enter your last name: "
		'Call PromptForName()
		'g_sLastName = g_sName
		'>>> END SECTION

		'>>> As you can see, slowly, but surely, we're cleaning things up.  But we can do better...


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


	Public Sub SetFormatting()

		SetFontSize(13)
		SetFontBold()
		SetForegroundColor(Color.Yellow)

	End Sub


	Public Sub ResetFormatting()

		ResetFontSize()
		SetFontNormal()
		SetFontItalic()
		SetForegroundColor(Color.LightGreen)

	End Sub


	Public Sub PromptForName()

		'>>> This function uses global variables to prompt the user for a first name, middle name, or last name, depending on how g_sPrompt is set in the main sub. It also reads the user's input into the g_sName global var.  And, it handles all formatting.  Note that blank lines are added for readability.

		SetFontSize(13)
		SetFontBold()
		SetForegroundColor(Color.Yellow)

		Display(g_sPrompt)

		ResetFontSize()
		SetFontNormal()
		SetFontItalic()
		SetForegroundColor(Color.LightGreen)

		g_sName = ReadString()

	End Sub


End Module