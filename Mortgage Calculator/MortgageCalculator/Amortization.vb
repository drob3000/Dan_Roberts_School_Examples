'Project:           Mortgage Calculator
'Programmer:        Dan Roberts
'Date:              August 06,2012
'Description:       Amortization Schedule Displays the payment schedule for the
'                   loan to full termand displays principal and interest percentage
'                   for each payment.

Public Class Amortization
    ' Assign variables
    Private Table As New DataTable
    Private PrincipalPaid As Double
    Private Principal As Double
    Private CurInterest As Double
    Private Balance As Double
    Private Payment As Double
    Private MonthlyInt As Double
    Private StartDate As Date
    Private TotalInterest As Double

    Function GetTable() As DataTable
        'Call Date to the form
        Balance = Mortgagecalculator.TxtLoan.Text
        Payment = Data.MonthlyPayment
        MonthlyInt = Data.MonthInterest
        StartDate = Data.PayDate
        GrdAmortization.DataSource = Nothing
        GrdAmortization.DataSource = Table

        'Create Title Columns 
        Try

            Table.Columns.Add("Due Date", GetType(String))
            Table.Columns.Add("Payment", GetType(String))
            Table.Columns.Add("Principal", GetType(String))
            Table.Columns.Add("Interest", GetType(String))
            Table.Columns.Add("Total Interest", GetType(String))
            Table.Columns.Add("Balance", GetType(String))

            For count = 1 To Data.numPayments
                

                StartDate.GetTypeCode()
                'calculate Interest paid, principal paid and the balance
                CurInterest = (Balance * MonthlyInt)
                PrincipalPaid = (Payment - CurInterest)
                Balance = (Balance - PrincipalPaid)
                TotalInterest = TotalInterest + CurInterest

                'Output data to the table
                Table.Rows.Add((StartDate.ToString("Y")), (Payment.ToString("C")), _
                            (PrincipalPaid.ToString("C")), (CurInterest.ToString("C")), _
                            (TotalInterest.ToString("C")), (Balance.ToString("C")))

                StartDate = StartDate.AddMonths(1)
            Next count
        Catch ex As DuplicateNameException

        End Try
        Return Table

    End Function

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        ' Close the window
        Me.Close()

    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        'Print the form
        PrintAmortization.PrintAction = Printing.PrintAction.PrintToPreview
        PrintAmortization.Print()

    End Sub
End Class