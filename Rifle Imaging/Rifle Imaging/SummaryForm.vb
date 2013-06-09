'Project:           Rifle Imaging
'Programmer:        Dan Roberts
'Date:              August 20, 2012
'Description:       Summary form allowing user to add a tip before making payment
'                   view itemized statement and print receipt.

Public Class SummaryForm


    Private Sub BtnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculate.Click
        'Add tip to the summary with validation
        Dim Tip As Double
        Dim Total As Double
        Dim Final As Double

        If Not IsNumeric(TxtTip.Text) Then
            ErrorProvider.SetError(TxtTip, " Enter tip is US currency")
            With TxtTip
                .SelectAll()
                .Focus()
            End With
        Else
            Tip = Double.Parse(TxtTip.Text)
            ErrorProvider.Clear()

        End If
        're-calculate total
        Total = MainForm.TotalDue
        Final = Total + Tip
        TxtTotalDue.Text = Final.ToString("C")
        LblSaleDate.Text = "Date of Sale " & Date.Now

    End Sub
    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        'Print receipt
        PrintForm.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm.Print()

    End Sub
    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        'Reset form and close summary window
        MainForm.Reset()
        Close()

    End Sub

End Class