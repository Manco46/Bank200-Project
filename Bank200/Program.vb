Imports System

Module Program

    Dim Bank200 As New clsSystemDB
    Dim strInput As String

    Sub Main(args As String())

        Load_Details()

        If strInput.ToUpper = "S" Then
            Console.Clear()
            Console.WriteLine("THIS IS TO TEST IF THE AMOUNT WITHDRAWN FROM SAVINGS ACCOUNT IS NOT ABOVE THE MINIMUIM YOU SHOULD HAVE AS YOUR BALANCE. ")
            Bank200.TestLargeAmountSavingsWidthdraw()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("THIS IS TO TEST IF A ACCOUNT EXIST")
            Bank200.TestAcountExist()
            Console.WriteLine("")
            Console.WriteLine("")

        ElseIf strInput.ToUpper = "C" Then
            Console.Clear()
            Console.WriteLine("THIS IS TO TEST IF THE AMOUNT WITHDRAWN FROM CURRENT ACCOUNT IS NOT ABOVE THE MINIMUIM YOU SHOULD HAVE AS YOUR BALANCE. ")
            Bank200.TestCurrentOverdraftCalc()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("THIS IS TO TEST THE DEPOSIT FOR CURRENT ACCOUNT")
            Bank200.TestCurrentDeposit()
            Console.WriteLine("")
            Console.WriteLine("")

        End If

    End Sub

    Private Sub Load_Details()
        Console.WriteLine("")
        Console.WriteLine("These Are The Default Detail Of The Customers")
        Bank200.getCustNum_Balance()
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("ENTER ""S"" TO SEE TEST RESULTS FOR SAVINGS ACOUNT")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("ENTER ""C"" TO SEE TEST RESULTS FOR CURRENT ACOUNT")
        strInput = Console.ReadLine()
    End Sub



End Module
