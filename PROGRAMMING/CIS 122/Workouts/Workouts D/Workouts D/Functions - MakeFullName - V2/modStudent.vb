Imports System.IO	'DO NOT DELETE

Module modStudent

	'>>> These are GLOBAL variables. They can be seen and accessed from ANYWHERE in this program. At first, we won't be using them.
	Dim g_sFirstName As String
	Dim g_sMiddleName As String
	Dim g_sLastName As String


	Public Sub RunProject()

		'Name: Make Full Name - V2
		'Purpose: Use functions to construct a person's full name from their first, middle, and last name
		'Author: Michael Passalacqua
		'Date: 10/21/14


		'Begin Code
		SetTitle("Make Full Name - V2")

		Call DisplayDescription()

		'>>> Now, let's see how the use of subroutines can be truly useful.  Notice all the repetitive (redundant) code below. If we decide to change anything about the formatting, we must remember to do it in all three places.  There's got to be a better way. Comment out this section and uncomment the next section.
		SetFontSize(13)
		SetFontBold()
		SetForegroundColor(Color.Yellow)
		Display("Enter your first name: ")
		ResetFontSize()
		SetFontNormal()
		SetFontItalic()
		SetForegroundColor(Color.LightGreen)
		g_sFirstName = ReadString()

		SetFontSize(13)
		SetFontBold()
		SetForegroundColor(Color.Yellow)
		Display("Enter your middle name: ")
		ResetFontSize()
		SetFontNormal()
		SetFontItalic()
		SetForegroundColor(Color.LightGreen)
		g_sMiddleName = ReadString()

		SetFontSize(13)
		SetFontBold()
		SetForegroundColor(Color.Yellow)
		Display("Enter your last name: ")
		ResetFontSize()
		SetFontNormal()
		SetFontItalic()
		SetForegroundColor(Color.LightGreen)
		g_sLastName = ReadString()
		'>>> END SECTION

		'>>> Next - This version of the code is accomplishing the same thing as the code above, but more efficiently - it's using subroutines to do all the formatting. Uncomment this section, study it carefully, look at the subs that it's calling, and then run it.  Everything should work just as before.  But now we have cleaner, more efficient code.  If we need to make a change to the formatting, we only have to do it in ONE place instead of THREE.  Imagine, if instead of just three names, we had 100 names. You can see how the use of subroutines would really come in handy.  Also, notice how it makes the code in our main Sub easier to read.  But we're just warming up.
		'Call SetFormatting()
		'Display("Enter your first name: ")
		'Call ResetFormatting()
		'g_sFirstName = ReadString()


		'Call SetFormatting()
		'Display("Enter your middle name: ")
		'Call ResetFormatting()
		'g_sMiddleName = ReadString()


		'Call SetFormatting()
		'Display("Enter your last name: ")
		'Call ResetFormatting()
		'g_sLastName = ReadString()
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


End Module