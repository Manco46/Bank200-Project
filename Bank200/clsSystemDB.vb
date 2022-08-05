Public Class clsSystemDB

    'Declaring the account objects or classes
    Private SavingsCustomers(2) As clsSavingsAccount
    Private CurrentCustomers(2) As clsCurrentAccount

    Public Sub New()

        'Initializing the accoun t object for Savings account
        SavingsCustomers(0) = New clsSavingsAccount
        SavingsCustomers(1) = New clsSavingsAccount
        SavingsCustomers(2) = New clsSavingsAccount

        'Opening Savings account for 3 customers
        SavingsCustomers(0).openAccount(1, 2000)
        SavingsCustomers(1).openAccount(2, 5000)
        SavingsCustomers(2).openAccount(3, 100000)

        'Initializing the accoun t object for Curreny account
        CurrentCustomers(0) = New clsCurrentAccount
        CurrentCustomers(1) = New clsCurrentAccount
        CurrentCustomers(2) = New clsCurrentAccount

        'Opening Current account for 3 customers
        CurrentCustomers(0).openAccount(4)
        CurrentCustomers(1).openAccount(5)
        CurrentCustomers(2).openAccount(6)

        CurrentCustomers(0).Balance = 1000
        CurrentCustomers(1).Balance = -5000
        CurrentCustomers(2).Balance = 50000

        CurrentCustomers(0).setOverdraft = 10000
        CurrentCustomers(1).setOverdraft = 20000
        CurrentCustomers(2).setOverdraft = 100000

    End Sub

    Public Sub TestCurrentOverdraftCalc()
        'Input variables for class method parameter
        Dim CustomerNum As Integer = 4
        Dim AmountToWithdraw As Decimal = 2150

        'For loop, looping through the array object
        For i = 0 To CurrentCustomers.Length - 1
            Console.WriteLine("")
            Console.WriteLine("THESE ARE CURRENT ACCOUNT DETAILS FOR CUSTOMER NUMBER: " & CustomerNum)
            Console.WriteLine(CurrentCustomers(i).Withdraw(CustomerNum, AmountToWithdraw))
            CustomerNum += 1
            AmountToWithdraw *= 2
        Next
    End Sub

    Public Sub TestCurrentDeposit()
        'Input variables for class method parameter
        Dim CustomerNum As Integer = 4
        Dim AmountToWithdraw As Decimal = 1500

        'For loop, looping through the array object
        For i = 0 To CurrentCustomers.Length - 1
            Console.WriteLine("")
            Console.WriteLine("THESE ARE CURRENT ACCOUNT DETAILS FOR CUSTOMER NUMBER: " & CustomerNum)
            Console.WriteLine(CurrentCustomers(i).Deposit(CustomerNum, AmountToWithdraw))
            CustomerNum += 1
            AmountToWithdraw *= 2
        Next
    End Sub


    Public Sub TestAcountExist()
        'Input variables for class method parameter
        Dim CustomerNum As Integer = 1
        Dim AmountToDeposit As Decimal = 5520.95

        'For loop, looping through the array object
        For i = 0 To SavingsCustomers.Length - 1
            Console.WriteLine("")
            Console.WriteLine("THESE ARE SAVINGS ACCOUNT DETAILS FOR CUSTOMER NUMBER: " & CustomerNum)
            Console.WriteLine(SavingsCustomers(i).Deposit(CustomerNum, AmountToDeposit))
            CustomerNum += 3
            AmountToDeposit *= 2
        Next
    End Sub

    Public Sub TestLargeAmountSavingsWidthdraw()
        'Input variables for class method parameter
        Dim CustomerNum As Integer = 1
        Dim amountTowithdraw As Decimal = 2200

        'For loop, looping through the array object
        For i = 0 To SavingsCustomers.Length - 1
            Console.WriteLine("")
            Console.WriteLine("THESE ARE SAVINGS ACCOUNT DETAILS FOR CUSTOMER NUMBER: " & CustomerNum)
            Console.WriteLine(SavingsCustomers(i).Withdraw(CustomerNum, amountTowithdraw))
            CustomerNum += 1
            amountTowithdraw *= 2
        Next
    End Sub

    Public Sub getCustNum_Balance()
        'Input variables for class method parameter


        'For loop, looping through the array object
        For i = 0 To SavingsCustomers.Length - 1
            Console.WriteLine("Customer Number: " & SavingsCustomers(i).getCustomerNum & " And the Balance: " & SavingsCustomers(i).Balance.ToString("C2"))
        Next

        For e = 0 To CurrentCustomers.Length - 1
            Console.WriteLine("Customer Number: " & CurrentCustomers(e).getCustomerNum & " And the Balance: " & CurrentCustomers(e).Balance.ToString("C2"))
        Next

    End Sub

End Class
