'Project:           Mortgage Calculator
'Programmer:        Dan Roberts
'Date:              August 06,2012
'Description:       Program to take the user input of of the loan amount, term of the loan and the interest rate
'                   the program will calculate the monthly payment (principal and interest only) the user will 
'                   also be able to view the amortization schedule and graph the total of the payments.the user
'                   will also be able to Print the form.

Public Class Mortgagecalculator
    'Assign the variables
    Private TheData As Data
    Private Interest As Double
    Private Loan As Double
    Private Term As Integer
    Private StartDate As Date = Now


    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Print the form
        PrintMortgage.PrintAction = Printing.PrintAction.PrintToPreview
        PrintMortgage.Print()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close and exit the program
        Application.Exit()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Dim table As New DataTable
        'Clear the inputs for a new selection
        With TxtLoan
            .Clear()
            .Focus()
        End With
        TxtInterest.Clear()
        TxtMonthly.Clear()
        TxtTerm.Clear()
        TxtTotalLoan.Clear()
        ErrorProvider.Clear()
        AmortizartionToolStripMenuItem.Enabled = False


    End Sub

    Private Sub AmortizartionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AmortizartionToolStripMenuItem.Click
        'Call Amortization schedule and table
        Dim table As DataTable = Amortization.GetTable()
        Amortization.GrdAmortization.DataSource = table
        Amortization.Show()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        'Call the about form
        AboutForm.ShowDialog()
    End Sub

    Private Sub BtnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculate.Click
        'Input Data, validate and output monthly payment.
        ErrorProvider.Clear()
        DtPicker.MinDate = Now

        Try
            If (IsNumeric(TxtLoan.Text) = False Or TxtLoan.Text <= "0" Or TxtLoan.Text = "") Then
                ErrorProvider.SetError(TxtLoan, "Enter Loan amount")
                With TxtLoan
                    .SelectAll()
                    .Focus()
                End With
            Else
                Loan = Double.Parse(TxtLoan.Text)

            End If

            If (IsNumeric(TxtTerm.Text) = False Or TxtTerm.Text <= "0" Or TxtTerm.Text = "") Then
                ErrorProvider.SetError(TxtTerm, "Enter term in Years")
                With TxtTerm
                    .SelectAll()
                    .Focus()
                End With
            Else
                Term = Integer.Parse(TxtTerm.Text)
            End If

            If (IsNumeric(TxtInterest.Text) = False Or TxtInterest.Text = "") Then
                ErrorProvider.SetError(TxtInterest, "Enter Interest rate")
                With TxtInterest
                    .SelectAll()
                    .Focus()
                End With
            Else
                Interest = Double.Parse(TxtInterest.Text)
            End If
            AmortizartionToolStripMenuItem.Enabled = True
            StartDate = DtPicker.Text
            TheData = New Data(Double.Parse(TxtLoan.Text), _
                            Integer.Parse(TxtTerm.Text), _
                            Double.Parse(TxtInterest.Text), _
                            Date.Parse(DtPicker.Text))

            TheData.Monthly()
            TxtMonthly.Text = Data.MonthlyPayment.ToString("C")
            TxtTotalLoan.Text = Data.LoanTotal.ToString("C")

        Catch ex As Exception

        End Try

    End Sub
End Class


