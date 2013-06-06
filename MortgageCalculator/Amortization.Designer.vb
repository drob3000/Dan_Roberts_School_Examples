<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Amortization
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Amortization))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.GrdAmortization = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ToolAmortization = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintAmortization = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.GrdAmortization, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("French Script MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(204, 19)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(221, 37)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "Amortization Schedule"
        '
        'GrdAmortization
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrdAmortization.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdAmortization.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrdAmortization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GrdAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAmortization.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GrdAmortization.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GrdAmortization.Location = New System.Drawing.Point(53, 75)
        Me.GrdAmortization.Name = "GrdAmortization"
        Me.GrdAmortization.ReadOnly = True
        Me.GrdAmortization.RowHeadersVisible = False
        Me.GrdAmortization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdAmortization.Size = New System.Drawing.Size(620, 399)
        Me.GrdAmortization.TabIndex = 3
        Me.GrdAmortization.TabStop = False
        Me.GrdAmortization.VirtualMode = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(598, 504)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.ToolAmortization.SetToolTip(Me.BtnClose, "Close the window")
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(498, 504)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "&Print"
        Me.ToolAmortization.SetToolTip(Me.BtnPrint, "Print the form")
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PrintAmortization
        '
        Me.PrintAmortization.DocumentName = "document"
        Me.PrintAmortization.Form = Me
        Me.PrintAmortization.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintAmortization.PrinterSettings = CType(resources.GetObject("PrintAmortization.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintAmortization.PrintFileName = Nothing
        '
        'Amortization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(736, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrdAmortization)
        Me.Controls.Add(Me.LblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Amortization"
        Me.Text = "Amortization Schedule"
        CType(Me.GrdAmortization, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents GrdAmortization As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ToolAmortization As System.Windows.Forms.ToolTip
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintAmortization As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
