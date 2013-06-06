<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mortgagecalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mortgagecalculator))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmortizartionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblLoan = New System.Windows.Forms.Label()
        Me.LblTerm = New System.Windows.Forms.Label()
        Me.LblInterest = New System.Windows.Forms.Label()
        Me.TxtLoan = New System.Windows.Forms.TextBox()
        Me.TxtTerm = New System.Windows.Forms.TextBox()
        Me.TxtInterest = New System.Windows.Forms.TextBox()
        Me.LblStartDate = New System.Windows.Forms.Label()
        Me.GRPInput = New System.Windows.Forms.GroupBox()
        Me.DtPicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.GrpOutput = New System.Windows.Forms.GroupBox()
        Me.TxtMonthly = New System.Windows.Forms.TextBox()
        Me.TxtTotalLoan = New System.Windows.Forms.TextBox()
        Me.LblTotalLoan = New System.Windows.Forms.Label()
        Me.LblMonthly = New System.Windows.Forms.Label()
        Me.PrintMortgage = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolMortgage = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.GRPInput.SuspendLayout()
        Me.GrpOutput.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ClearToolStripMenuItem, Me.AmortizartionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(615, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&file"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'AmortizartionToolStripMenuItem
        '
        Me.AmortizartionToolStripMenuItem.Enabled = False
        Me.AmortizartionToolStripMenuItem.Name = "AmortizartionToolStripMenuItem"
        Me.AmortizartionToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AmortizartionToolStripMenuItem.Text = "&Amortizartion"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("French Script MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(200, 37)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(215, 37)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Mortgage Calculator"
        '
        'LblLoan
        '
        Me.LblLoan.AutoSize = True
        Me.LblLoan.Location = New System.Drawing.Point(6, 26)
        Me.LblLoan.Name = "LblLoan"
        Me.LblLoan.Size = New System.Drawing.Size(141, 13)
        Me.LblLoan.TabIndex = 2
        Me.LblLoan.Text = "Enter the amount of the loan"
        '
        'LblTerm
        '
        Me.LblTerm.AutoSize = True
        Me.LblTerm.Location = New System.Drawing.Point(6, 52)
        Me.LblTerm.Name = "LblTerm"
        Me.LblTerm.Size = New System.Drawing.Size(126, 13)
        Me.LblTerm.TabIndex = 3
        Me.LblTerm.Text = "Enter the term of the loan"
        '
        'LblInterest
        '
        Me.LblInterest.AutoSize = True
        Me.LblInterest.Location = New System.Drawing.Point(6, 78)
        Me.LblInterest.Name = "LblInterest"
        Me.LblInterest.Size = New System.Drawing.Size(113, 13)
        Me.LblInterest.TabIndex = 4
        Me.LblInterest.Text = "Enter the interest Rate"
        '
        'TxtLoan
        '
        Me.TxtLoan.Location = New System.Drawing.Point(175, 23)
        Me.TxtLoan.Name = "TxtLoan"
        Me.TxtLoan.Size = New System.Drawing.Size(113, 20)
        Me.TxtLoan.TabIndex = 5
        '
        'TxtTerm
        '
        Me.TxtTerm.Location = New System.Drawing.Point(175, 49)
        Me.TxtTerm.MaxLength = 3
        Me.TxtTerm.Name = "TxtTerm"
        Me.TxtTerm.Size = New System.Drawing.Size(113, 20)
        Me.TxtTerm.TabIndex = 6
        '
        'TxtInterest
        '
        Me.TxtInterest.Location = New System.Drawing.Point(175, 75)
        Me.TxtInterest.MaxLength = 4
        Me.TxtInterest.Name = "TxtInterest"
        Me.TxtInterest.Size = New System.Drawing.Size(113, 20)
        Me.TxtInterest.TabIndex = 7
        '
        'LblStartDate
        '
        Me.LblStartDate.AutoSize = True
        Me.LblStartDate.Location = New System.Drawing.Point(400, 23)
        Me.LblStartDate.Name = "LblStartDate"
        Me.LblStartDate.Size = New System.Drawing.Size(82, 13)
        Me.LblStartDate.TabIndex = 8
        Me.LblStartDate.Text = "Loan Start Date"
        '
        'GRPInput
        '
        Me.GRPInput.Controls.Add(Me.DtPicker)
        Me.GRPInput.Controls.Add(Me.BtnCalculate)
        Me.GRPInput.Controls.Add(Me.LblLoan)
        Me.GRPInput.Controls.Add(Me.LblTerm)
        Me.GRPInput.Controls.Add(Me.LblInterest)
        Me.GRPInput.Controls.Add(Me.TxtLoan)
        Me.GRPInput.Controls.Add(Me.TxtTerm)
        Me.GRPInput.Controls.Add(Me.LblStartDate)
        Me.GRPInput.Controls.Add(Me.TxtInterest)
        Me.GRPInput.Location = New System.Drawing.Point(34, 77)
        Me.GRPInput.Name = "GRPInput"
        Me.GRPInput.Size = New System.Drawing.Size(538, 157)
        Me.GRPInput.TabIndex = 13
        Me.GRPInput.TabStop = False
        '
        'DtPicker
        '
        Me.DtPicker.Checked = False
        Me.DtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtPicker.Location = New System.Drawing.Point(403, 52)
        Me.DtPicker.Name = "DtPicker"
        Me.DtPicker.Size = New System.Drawing.Size(79, 20)
        Me.DtPicker.TabIndex = 14
        Me.ToolMortgage.SetToolTip(Me.DtPicker, "Select your first payment date")
        Me.DtPicker.Value = New Date(2012, 8, 4, 0, 0, 0, 0)
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCalculate.Location = New System.Drawing.Point(453, 127)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 13
        Me.BtnCalculate.Text = "&Calculate"
        Me.ToolMortgage.SetToolTip(Me.BtnCalculate, "Caculates the mortgage")
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'GrpOutput
        '
        Me.GrpOutput.Controls.Add(Me.TxtMonthly)
        Me.GrpOutput.Controls.Add(Me.TxtTotalLoan)
        Me.GrpOutput.Controls.Add(Me.LblTotalLoan)
        Me.GrpOutput.Controls.Add(Me.LblMonthly)
        Me.GrpOutput.Location = New System.Drawing.Point(34, 233)
        Me.GrpOutput.Name = "GrpOutput"
        Me.GrpOutput.Size = New System.Drawing.Size(538, 103)
        Me.GrpOutput.TabIndex = 14
        Me.GrpOutput.TabStop = False
        '
        'TxtMonthly
        '
        Me.TxtMonthly.Location = New System.Drawing.Point(175, 25)
        Me.TxtMonthly.Name = "TxtMonthly"
        Me.TxtMonthly.ReadOnly = True
        Me.TxtMonthly.Size = New System.Drawing.Size(113, 20)
        Me.TxtMonthly.TabIndex = 5
        Me.TxtMonthly.TabStop = False
        '
        'TxtTotalLoan
        '
        Me.TxtTotalLoan.Location = New System.Drawing.Point(175, 51)
        Me.TxtTotalLoan.Name = "TxtTotalLoan"
        Me.TxtTotalLoan.ReadOnly = True
        Me.TxtTotalLoan.Size = New System.Drawing.Size(113, 20)
        Me.TxtTotalLoan.TabIndex = 4
        Me.TxtTotalLoan.TabStop = False
        '
        'LblTotalLoan
        '
        Me.LblTotalLoan.AutoSize = True
        Me.LblTotalLoan.Location = New System.Drawing.Point(6, 54)
        Me.LblTotalLoan.Name = "LblTotalLoan"
        Me.LblTotalLoan.Size = New System.Drawing.Size(123, 13)
        Me.LblTotalLoan.TabIndex = 1
        Me.LblTotalLoan.Text = "The total loan amount is:"
        '
        'LblMonthly
        '
        Me.LblMonthly.AutoSize = True
        Me.LblMonthly.Location = New System.Drawing.Point(6, 32)
        Me.LblMonthly.Name = "LblMonthly"
        Me.LblMonthly.Size = New System.Drawing.Size(121, 13)
        Me.LblMonthly.TabIndex = 0
        Me.LblMonthly.Text = "The monthly payment is:"
        '
        'PrintMortgage
        '
        Me.PrintMortgage.DocumentName = "document"
        Me.PrintMortgage.Form = Me
        Me.PrintMortgage.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintMortgage.PrinterSettings = CType(resources.GetObject("PrintMortgage.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintMortgage.PrintFileName = Nothing
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Mortgagecalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(615, 377)
        Me.Controls.Add(Me.GrpOutput)
        Me.Controls.Add(Me.GRPInput)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Mortgagecalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mortgage Calculator"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GRPInput.ResumeLayout(False)
        Me.GRPInput.PerformLayout()
        Me.GrpOutput.ResumeLayout(False)
        Me.GrpOutput.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmortizartionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblLoan As System.Windows.Forms.Label
    Friend WithEvents LblTerm As System.Windows.Forms.Label
    Friend WithEvents LblInterest As System.Windows.Forms.Label
    Friend WithEvents TxtLoan As System.Windows.Forms.TextBox
    Friend WithEvents TxtTerm As System.Windows.Forms.TextBox
    Friend WithEvents TxtInterest As System.Windows.Forms.TextBox
    Friend WithEvents LblStartDate As System.Windows.Forms.Label
    Friend WithEvents GRPInput As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents GrpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMonthly As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalLoan As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalLoan As System.Windows.Forms.Label
    Friend WithEvents LblMonthly As System.Windows.Forms.Label
    Friend WithEvents PrintMortgage As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolMortgage As System.Windows.Forms.ToolTip
    Friend WithEvents DtPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
