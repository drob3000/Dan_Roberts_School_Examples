'Project:           Rifle Imaging
'Programmer:        Dan Roberts
'Date:              August 20, 2012
'Description:       Program to calculate the sales of services and apply any discount coupons
'                   that are apply the summary page will allow the user to see subtotal, taxes
'                   and tips and the final total.

Public Class MainForm
    'Calculation Constants.
    Const MAKEOVER = 125D
    Const HAIR_STYLING = 60D
    Const MANICURE = 35D
    Const PERMANENT_MAKEUP = 200D
    Const DISCOUNT_10 = 0.1D
    Const DISCOUNT_20 = 0.2D
    Const SALES_TAX = 0.093D
    'Varables 
    Private SubTotal As Double
    Private PriceCheck As Double
    Private Tax As Double
    Friend TotalDue As Double


    Private Sub BtnAddToOrder_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddToOrder.Click
        'Add to order button selection which calls the radio button sub routine
        Selection()
        TxtPrice.Text = PriceCheck.ToString("C")
        SubTotal += PriceCheck
        TxtSubTotal.Text = SubTotal.ToString("C")
        BtnNewOrder.Enabled = True
        BtnSummary.Enabled = True

    End Sub

    Private Sub BtnSummary_Click(sender As System.Object, e As System.EventArgs) Handles BtnSummary.Click
        'Calculations
        Tax = SubTotal * SALES_TAX
        TotalDue = SubTotal + Tax
        'Call Summary Form
        SummaryForm.TxtSubTotal.Text = SubTotal.ToString("C")
        SummaryForm.TxtSalesTax.Text = Tax.ToString("C")
        SummaryForm.TxtTotalDue.Text = TotalDue.ToString("C")
        SummaryForm.Show()
    End Sub

    Private Sub BtnNewOrder_Click(sender As System.Object, e As System.EventArgs) Handles BtnNewOrder.Click
        'Call Reset sub routine
        Reset()

    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        'Exit and close the application
        Application.Exit()

    End Sub
    Friend Sub Reset()
        'Resets the Radio buttons and text fields for new selection
        RdbDiscount10.Checked = False
        RdbDiscount20.Checked = False
        RdbHairStyling.Checked = False
        RdbMakeover.Checked = False
        RdbManicure.Checked = False
        RdbPermanentMakeup.Checked = False
        RdbNoCoupon.Checked = True
        SubTotal = 0
        TxtPrice.Clear()
        TxtSubTotal.Clear()
        BtnNewOrder.Enabled = False
        BtnSummary.Enabled = False

    End Sub
    Private Sub Selection()
        'Radio Button selection sub routine
        Dim Service As Double
        Dim Discount As Double
        Dim ServiceMessage As String
        Dim DiscountMessage As String

        If RdbHairStyling.Checked Then
            Service = HAIR_STYLING
            ServiceMessage = "Hair Styling                   "
        ElseIf RdbMakeover.Checked Then
            Service = MAKEOVER
            ServiceMessage = "Makeover                   "
        ElseIf RdbManicure.Checked Then
            Service = MANICURE
            ServiceMessage = "Manicure                      "
        ElseIf RdbPermanentMakeup.Checked Then
            Service = PERMANENT_MAKEUP
            ServiceMessage = "Permanent Makeup    "
        End If
        If RdbNoCoupon.Checked Then
            Discount = 0
            DiscountMessage = "No Discount                 "
        ElseIf RdbDiscount10.Checked Then
            Discount = Service * DISCOUNT_10
            DiscountMessage = "Discount of 10%          "
        ElseIf RdbDiscount20.Checked Then
            Discount = Service * DISCOUNT_20
            DiscountMessage = "Discount of 20%          "
        End If

        PriceCheck = Service - Discount
        'receipt box ouput
        SummaryForm.SummaryField.Text += ServiceMessage & Service.ToString("C") & Environment.NewLine _
            & DiscountMessage & "- " & Discount.ToString("C") & Environment.NewLine & Environment.NewLine

    End Sub
   
End Class
