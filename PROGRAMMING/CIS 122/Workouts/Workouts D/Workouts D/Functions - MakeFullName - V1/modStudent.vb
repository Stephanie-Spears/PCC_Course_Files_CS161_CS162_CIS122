Imports System.IO	'DO NOT DELETE

Module modStudent

	'>>> These are GLOBAL variables. They can be seen and accessed from ANYWHERE in this program. At first, we won't be using them.
	Dim g_sFirstName As String
	Dim g_sMiddleName As String
	Dim g_sLastName As String


	Public Sub RunProject()

		'Name: Make Full Name - V1
		'Purpose: Use functions to construct a person's full name from their first, middle, and last name
		'Author: Michael Passalacqua
		'Date: 10/21/14


		'Variables
		'>>> These variables are declared INSIDE of the subroutine named RunProject.  In VB, a subroutine always begins with the words Public Sub, and ends with the words End Sub.
		'When you declare variables inside of a subroutine (or a function), they are LOCAL variables, i.e. they can only be seen and accessed from INSIDE OF the subroutine (or function) where they are declared.
		Dim sFirstName As String
		Dim sMiddleName As String
		Dim sLastName As String


		'Begin Code
		SetTitle("Make Full Name - V1")

		'>>> The following line of code calls a subroutine named DisplayDescription.  A subroutine is simply a package of one or more lines of code.  It never runs unless it is told to run ("called"). You can call a subroutine simply by using the word 'Call' and then specifying its name.  In VB, a subroutine always begins with the words Public Sub, and ends with the words End Sub.  Scroll down to see what DisplayDescription actually does.  Then, run the code.
		Call DisplayDescription()
		'As you can see, it runs the code inside of the DisplayDescription sub. And then it returns here, and does whatever code comes next - in this case, the thank you message at the bottom of THIS sub. That's the cool thing about calling a subroutine - After the subroutine ends, you automatically come back to the line of code that CALLED the sub.


		'>>> Next - Uncomment the following section - everything up to, but NOT including ">>> END SECTION". Then, run the code.
		'SetFontSize(13)
		'SetFontBold()
		'SetForegroundColor(Color.Yellow)
		'Display("Enter your first name: ")
		'ResetFontSize()
		'SetFontNormal()
		'SetFontItalic()
		'SetForegroundColor(Color.LightGreen)
		'sFirstName = ReadString()

		'SetFontSize(13)
		'SetFontBold()
		'SetForegroundColor(Color.Yellow)
		'Display("Enter your middle name: ")
		'ResetFontSize()
		'SetFontNormal()
		'SetFontItalic()
		'SetForegroundColor(Color.LightGreen)
		'sMiddleName = ReadString()

		'SetFontSize(13)
		'SetFontBold()
		'SetForegroundColor(Color.Yellow)
		'Display("Enter your last name: ")
		'ResetFontSize()
		'SetFontNormal()
		'SetFontItalic()
		'SetForegroundColor(Color.LightGreen)
		'sLastName = ReadString()


		'DisplayLine()
		'SetForegroundColor(Color.Yellow)
		'Display("Your full name is ")
		'SetForegroundColor(Color.Red)
		'SetFontSize(14)
		'Display(sFirstName & " " & sMiddleName & " " & sLastName)
		'>>> END SECTION


		'>>> Next - Let's use a separate subroutine - a "Sub" - to make the full name.
		'Comment out just the SMALL section of code above (it starts with DisplayLine), and uncomment the line below.  
		'Call MakeFullName()
		'The line above is "calling" the MakeFullName() subroutine that you see below - the one that begins with "Public Sub MakeFullName()". That sub does the exact same work as the code you just commented out.  Go ahead and uncomment the entire subroutine - everything from Public Sub MakeFullName() to its End Sub.
		'But there's a problem. Run the program, and see what happens...

		'As you can see, it won't compile. It's telling us that sFirstName, sMiddleName, and sLastName are not declared. That's because we're using LOCAL variables, which can only be seen and accessed from INSIDE the subroutine (or function) where they are declared. Notice the line numbers in the error messages - you'll see that they are all referring to the line inside of MakeFullName that displays sFirstName, sMiddleName, and sLastName.
		'Those variables ARE declared inside of THIS subroutine. But that makes them LOCAL variables, and so they can't be seen from anywhere OUTSIDE this subroutine. As far as MakeFullName is concerned, they don't exist.
		'So how do we fix this?  One solution is to use GLOBAL variables instead of the LOCAL variables we're currently using. Remember - GLOBAL vars can be seen from ANYWHERE in your code. We've got some global variables already declared for us at the top of the program.  Take a look at them and come back here.
		'Now, we need to make use of them. To do this, in the MakeFullName sub, rename the 3 local variables to the GLOBAL vars - sFirstName to g_sFirstName, etc.  
		'Then, rename the 3 local variables in THIS sub to the GLOBAL vars - sFirstName to g_sFirstName, etc.  
		'Whew! At this point, both subs should be referencing only the GLOBAL variables, and not the local ones.  Run the code and see what happens.

		'As you can see, it works!  By using global variables instead of local variables, multiple subroutines can reference (access) the same variables. This can be very useful, as you'll see next.


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


	'Public Sub MakeFullName()

	'	DisplayLine()
	'	SetForegroundColor(Color.Yellow)
	'	Display("Your full name is ")
	'	SetForegroundColor(Color.Red)
	'	SetFontSize(14)
	'	Display(sFirstName & " " & sMiddleName & " " & sLastName)

	'End Sub



End Module