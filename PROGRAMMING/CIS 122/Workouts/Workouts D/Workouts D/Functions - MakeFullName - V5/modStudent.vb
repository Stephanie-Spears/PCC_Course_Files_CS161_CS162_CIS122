Imports System.IO	'DO NOT DELETE

Module modStudent

	'>>> These are GLOBAL variables. They can be seen and accessed from ANYWHERE in this program. At first, we won't be using them.
	Dim g_sFirstName As String
	Dim g_sMiddleName As String
	Dim g_sLastName As String


	Public Sub RunProject()

		'Name: Make Full Name - V5
		'Purpose: Use functions to construct a person's full name from their first, middle, and last name
		'Author: Michael Passalacqua
		'Date: 10/21/14


		'Begin Code
		SetTitle("Make Full Name - V5")

		Call DisplayDescription()

        '>>> If you've read the Course Notes, carefully, you know that there is a variation on a subroutine. And that variation is called a "function".  What makes a function special is that it can *return a value* to whoever called it.  This may sound strange and confusing, but you've been doing this every time you call ReadString.  ReadString is a function that returns a string.  We always put it on the right side of an equal sign so that we can take what it returns and assign it to a variable. That's pretty much true any time we call a function that returns a value.
        'Looking at our old code below, we call PromptForName, and then assign g_sName to a variable.  But if we modify PromptForName so that it is a function that returns a value, we can clean up our code once again.
        '	Call PromptForName("Enter your first name: ")
        'g_sFirstName = g_sName
        '
        '    Call PromptForName("Enter your middle name: ")
        '       g_sMiddleName = g_sName

        'Call PromptForName("Enter your last name: ")
        '   g_sLastName = g_sName
        '>>> END SECTION

        '>>> Next - Comment out the previous section and uncomment this section.
        'Now, comment out the old PromptForName subroutine below (everything from Public Sub to End Sub) and UNcomment the new PromptForName *function* below.
        'Look how clean and elegant our code has become.  Are you getting turned on?  Then seek help - that's disgusting.  It's just frackin code, not a supermodel.
        'Take a look at the new PromptForName function, read everything in it, and come back here.
        'So now you know that PromptForName is returning a value to us - the string that the user entered (which is, hopefully, a name). 
        'Because it returns a value, we must DO something with that value. One of the most common things to do Is to assign it to a variable.
        'And that's exactly what we are doing here:
        g_sFirstName = PromptForName("Enter your first name: ")
        g_sMiddleName = PromptForName("Enter your middle name: ")
        g_sLastName = PromptForName("Enter your last name: ")
        '>>> END SECTION

        '>>> And now we call MakeFullName, which as you recall makes use of g_sFirstName, g_sMiddleName, and g_sLastName.  Run the program to be sure everything works as it should.
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

    '
    '  Public Sub PromptForName(p_sPrompt As String)   'Demonstrates use of parameters

    'This function takes one parameter,  p_sPrompt, which it uses to prompt the user for a first name, middle name, or last name, depending on whatever p_sPrompt is set to.  How does p_sPrompt get set, you ask?  When we call PromptForName in our main sub, we have a string inside of the parenentheses. That string gets assigned to p_sPrompt.

    '	SetFontSize(13)
    '       SetFontBold()
    '       SetForegroundColor(Color.Yellow)

    '       Display(p_sPrompt)

    '       ResetFontSize()
    '       SetFontNormal()
    '       SetFontItalic()
    '       SetForegroundColor(Color.LightGreen)

    '       g_sName = ReadString()

    ' End Sub


    Public Function PromptForName(p_sPrompt As String) As String

        '>>> Notice how this begins with Public Function instead of Public Sub.  That's how you know it's a function.  Also, it ends with End Function instead of End Sub.  (Some languages don't distinguish between a sub and a function, but VB does.)
        '	'Notice that after the closing paren above, it says "As String".  This tells us that the function will return a value - a piece of data - to whoever called it, AND the data type will be String.
        '	'As before, the function takes one parameter,  p_sPrompt, which it uses to prompt the user for a first name, middle name, or last name.

        Dim sName As String

        SetFontSize(13)
        SetFontBold()
        SetForegroundColor(Color.Yellow)

        Display(p_sPrompt)

        ResetFontSize()
        SetFontNormal()
        SetFontItalic()
        SetForegroundColor(Color.LightGreen)

        '	'>>> This part is interesting.  As you can see, we are using ReadString to accept input from the user (the name), and we assign it to the local variable named sName.
        '	'In the next line after that, we see the keyword "Return".  The keyword Return will always cause the function to exit (return) IMMEDIATELY.  If there's any code after the Return, it will not execute.  You could use Return all my itself to exit a function at any point.
        '	'But in this case, the Return is followed by our local variable sName.  So, it will exit the function immediately and return to whoever called it.  But additionally, it will take sName with it.
        sName = ReadString()
        Return sName

    End Function


End Module