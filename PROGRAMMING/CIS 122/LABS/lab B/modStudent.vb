Imports System.IO	'DO NOT DELETE

Module modStudent

	Public Sub RunProject()
		'Project Header:
		'Name:		Cash Register
		'Purpose: 	Functions as a cash register, calculating a specified number of items and their cumulative prices.
		'Author: 	Stephanie Spears
		'Date: 		4/5/2016


		'Variables
		Dim sItemName As String
		Dim dItemPrice As Double
		Dim sUserHasCoupon As String
		Dim dCouponAmount As Double = 0
		Dim dTotal As Double


		'Begin Code
		SetTitle("Cash Register")
		SetForegroundColor(Color.LightGreen)
		SetFontSize(14)
		SetFontBoldItalic()
		DisplayLine("Welcome to SmallMart!")

		SetFontNormal()
		ResetFontSize()
		DisplayLine("You must purchase exactly 3 items..." & NL)

		SetBackgroundColor(Color.Red)
		SetFontBold()
		DisplayLine("Item 1")

		SetFontNormal()
		ResetBackgroundColor()
		Display("Enter item name: ")
		sItemName = ReadString()
		Display("Enter item price: $")
		dItemPrice = ReadDouble()
		Display("Do you have a coupon for this item (y/n)? ")
		sUserHasCoupon = ReadChar()


		If sUserHasCoupon = "y" Then
			Display("Enter coupon amount: ")
			dCouponAmount = ReadDouble()
			DisplayLine("Coupon: " & "-" & (FormatCurrency(dCouponAmount)))
			dItemPrice = dItemPrice - dCouponAmount
		End If


		dTotal = dTotal + dItemPrice
		SetBackgroundColor(Color.Red)
		DisplayLine("1 " & sItemName & " at " & (FormatCurrency(dItemPrice)))
		DisplayLine(NL)

		SetFontBold()
		DisplayLine("Item 2")

		SetFontNormal()
		ResetBackgroundColor()
		Display("Enter item name: ")
		sItemName = ReadString()
		Display("Enter item price: $")
		dItemPrice = ReadDouble()
		Display("Do you have a coupon for this item (y/n)? ")
		sUserHasCoupon = ReadChar()


		If sUserHasCoupon = "y" Then
			Display("Enter coupon amount: ")
			dCouponAmount = ReadDouble()
			DisplayLine("Coupon: " & "-" & (FormatCurrency(dCouponAmount)))
			dItemPrice = dItemPrice - dCouponAmount
		End If


		dTotal = dTotal + dItemPrice
		SetBackgroundColor(Color.Red)
		DisplayLine("1 " & sItemName & " at " & (FormatCurrency(dItemPrice)))
		DisplayLine(NL)

		SetFontBold()
		DisplayLine("Item 3")

		SetFontNormal()
		ResetBackgroundColor()
		Display("Enter item name: ")
		sItemName = ReadString()
		Display("Enter item price: $")
		dItemPrice = ReadDouble()
		Display("Do you have a coupon for this item (y/n)? ")
		sUserHasCoupon = ReadChar()


		If sUserHasCoupon = "y" Then
			Display("Enter coupon amount: ")
			dCouponAmount = ReadDouble()
			DisplayLine("Coupon: " & "-" & (FormatCurrency(dCouponAmount)))
			dItemPrice = dItemPrice - dCouponAmount
		End If


		dTotal = dTotal + dItemPrice
		SetBackgroundColor(Color.Red)
		DisplayLine("1 " & sItemName & " at " & (FormatCurrency(dItemPrice)))
		DisplayLine(NL & NL & NL)


		SetFontBold()
		DisplayLine("Your total is " & FormatCurrency(dTotal))
		ResetBackgroundColor()
		DisplayLine()

		SetFontSize(14)
		SetFontBoldItalic()
		DisplayLine("Thank you for shopping at SmallMart!")

	End Sub

End Module