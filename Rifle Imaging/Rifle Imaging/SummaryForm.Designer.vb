<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryForm))
        Me.LblSummaryTitle = New System.Windows.Forms.Label()
        Me.LblSalesTax = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.LblTip = New System.Windows.Forms.Label()
        Me.LblTotalDue = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.TxtSalesTax = New System.Windows.Forms.TextBox()
        Me.TxtTip = New System.Windows.Forms.TextBox()
        Me.TxtTotalDue = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SummaryField = New System.Windows.Forms.RichTextBox()
        Me.LblSaleDate = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSummaryTitle
        '
        Me.LblSummaryTitle.AutoSize = True
        Me.LblSummaryTitle.Font = New System.Drawing.Font("Old English Text MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSummaryTitle.ForeColor = System.Drawing.Color.Red
        Me.LblSummaryTitle.Location = New System.Drawing.Point(112, 22)
        Me.LblSummaryTitle.Name = "LblSummaryTitle"
        Me.LblSummaryTitle.Size = New System.Drawing.Size(197, 23)
        Me.LblSummaryTitle.TabIndex = 0
        Me.LblSummaryTitle.Text = "Rifle Imaging Consulting"
        '
        'LblSalesTax
        '
        Me.LblSalesTax.AutoSize = True
        Me.LblSalesTax.Location = New System.Drawing.Point(62, 308)
        Me.LblSalesTax.Name = "LblSalesTax"
        Me.LblSalesTax.Size = New System.Drawing.Size(54, 13)
        Me.LblSalesTax.TabIndex = 5
        Me.LblSalesTax.Text = "Sales Tax"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.Location = New System.Drawing.Point(62, 274)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(53, 13)
        Me.LblSubTotal.TabIndex = 3
        Me.LblSubTotal.Text = "Sub Total"
        '
        'LblTip
        '
        Me.LblTip.AutoSize = True
        Me.LblTip.Location = New System.Drawing.Point(62, 342)
        Me.LblTip.Name = "LblTip"
        Me.LblTip.Size = New System.Drawing.Size(22, 13)
        Me.LblTip.TabIndex = 7
        Me.LblTip.Text = "Tip"
        '
        'LblTotalDue
        '
        Me.LblTotalDue.AutoSize = True
        Me.LblTotalDue.Location = New System.Drawing.Point(62, 376)
        Me.LblTotalDue.Name = "LblTotalDue"
        Me.LblTotalDue.Size = New System.Drawing.Size(54, 13)
        Me.LblTotalDue.TabIndex = 9
        Me.LblTotalDue.Text = "Total Due"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(266, 274)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 4
        Me.TxtSubTotal.TabStop = False
        Me.ToolTip.SetToolTip(Me.TxtSubTotal, "Subtotal of sale")
        '
        'TxtSalesTax
        '
        Me.TxtSalesTax.Location = New System.Drawing.Point(266, 308)
        Me.TxtSalesTax.Name = "TxtSalesTax"
        Me.TxtSalesTax.ReadOnly = True
        Me.TxtSalesTax.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalesTax.TabIndex = 6
        Me.TxtSalesTax.TabStop = False
        Me.ToolTip.SetToolTip(Me.TxtSalesTax, "State sales tax")
        '
        'TxtTip
        '
        Me.TxtTip.Location = New System.Drawing.Point(266, 342)
        Me.TxtTip.Name = "TxtTip"
        Me.TxtTip.Size = New System.Drawing.Size(100, 20)
        Me.TxtTip.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.TxtTip, "tip amount to your service provider")
        Me.TxtTip.UseSystemPasswordChar = True
        '
        'TxtTotalDue
        '
        Me.TxtTotalDue.Location = New System.Drawing.Point(266, 376)
        Me.TxtTotalDue.Name = "TxtTotalDue"
        Me.TxtTotalDue.ReadOnly = True
        Me.TxtTotalDue.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalDue.TabIndex = 10
        Me.TxtTotalDue.TabStop = False
        Me.ToolTip.SetToolTip(Me.TxtTotalDue, "total amount due for services")
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(291, 421)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 13
        Me.BtnClose.Text = "C&lose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(187, 421)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 12
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(86, 421)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 11
        Me.BtnCalculate.Text = "&Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'SummaryField
        '
        Me.SummaryField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SummaryField.Location = New System.Drawing.Point(187, 67)
        Me.SummaryField.Name = "SummaryField"
        Me.SummaryField.ReadOnly = True
        Me.SummaryField.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SummaryField.Size = New System.Drawing.Size(179, 160)
        Me.SummaryField.TabIndex = 1
        Me.SummaryField.Text = ""
        Me.SummaryField.WordWrap = False
        '
        'LblSaleDate
        '
        Me.LblSaleDate.AutoSize = True
        Me.LblSaleDate.Location = New System.Drawing.Point(193, 239)
        Me.LblSaleDate.Name = "LblSaleDate"
        Me.LblSaleDate.Size = New System.Drawing.Size(0, 13)
        Me.LblSaleDate.TabIndex = 2
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 456)
        Me.Controls.Add(Me.LblSaleDate)
        Me.Controls.Add(Me.SummaryField)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtTotalDue)
        Me.Controls.Add(Me.TxtTip)
        Me.Controls.Add(Me.TxtSalesTax)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.LblTotalDue)
        Me.Controls.Add(Me.LblTip)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Controls.Add(Me.LblSalesTax)
        Me.Controls.Add(Me.LblSummaryTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SummaryForm"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSummaryTitle As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax As System.Windows.Forms.Label
    Friend WithEvents LblSubTotal As System.Windows.Forms.Label
    Friend WithEvents LblTip As System.Windows.Forms.Label
    Friend WithEvents LblTotalDue As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents TxtTip As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalDue As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents SummaryField As System.Windows.Forms.RichTextBox
    Friend WithEvents LblSaleDate As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
