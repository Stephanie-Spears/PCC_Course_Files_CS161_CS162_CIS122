Module modStudent

	Public Sub RunProject()

		'Name: CIS 122 Basic Demo 1
		'Purpose: A demonstration of basic programming
		'Author: Michael Passalacqua
		'Date: 

		'Instructions: Comment and uncomment out the lines of code as instructed. Forgot how to do that? - read the Commenting Your Code topic in the Variables section of our Course Notes.

		'Variables (our variables will be declared in this section)
		Dim sName As String = ""
		Dim sFirstName As String = ""
		Dim sLastName As String = ""

		'Begin Code

		'>>> Uncomment the next line of code and run the project by pressing F5. What do you notice?
		SetTitle("CIS 122 Basic Demo 1")

		'>>> Uncomment the next line of code and run the project
		SetForegroundColor(Color.White)
		SetBackgroundColor(Color.Blue)
		DisplayLine("Hello World!")

		'>>> Cut and paste the following two lines just before the DisplayLine code above. Uncomment them and run.
	

		'>>> Uncomment and run - notice the missing space after Hello. Can you fix that yourself?
		DisplayLine("Hello " & "World" & "!!!")

		'>>> This next line declares a string variable and sets it to an empty string. Cut & paste it into the Variables section above. Uncomment it.


		'>>> Uncomment the next two lines and run.
		sName = "Tyler"
		DisplayLine(sName)

		'>>> Uncomment & run
		DisplayLine("Hello " & sName & "!!!")


		'>>> ReadString() reads a string from the keyboard. Uncomment & run.
		sName = ReadString()
		'>>> Problem: the user gets prompted, but doesn't know what we're asking for. Let's fix that now

		'Uncomment the next 3 lines of code & run
		Display("Enter your name: ")
		sName = ReadString()

		DisplayLine("Hello " & sName & "!!")

		'>>> That's ok, but notice how the cursor appears at the beginning of the NEXT line. Personally, I think it's better design if it appears just to the right of the text. How can we do this?
		'The DisplayLine function not only displays the text. It also moves the cursor to the beginning of the next line. But there's a variation that's just called Display. Does the exact same thing as DisplayLine, but doesn't move the cursor.
		'So, change the line above that displays "Enter your name: " so that it calls Display instead of DisplayLine. Run the code and notice the difference.


		'>>> Cut & paste these variables declarations into the Variables section above.  Uncomment them.
		

		'>>> Uncomment this section & run
		Display("Enter first name: ")
		sFirstName = ReadString()
		Display("Enter last name: ")
		sLastName = ReadString()

		'>>> Uncomment & run.
		DisplayLine("Hello " & sFirstName & " " & sLastName & "!!")

	End Sub

End Module
