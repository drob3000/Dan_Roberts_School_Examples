<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GrpService = New System.Windows.Forms.GroupBox()
        Me.RdbPermanentMakeup = New System.Windows.Forms.RadioButton()
        Me.RdbManicure = New System.Windows.Forms.RadioButton()
        Me.RdbHairStyling = New System.Windows.Forms.RadioButton()
        Me.RdbMakeover = New System.Windows.Forms.RadioButton()
        Me.GrpCoupon = New System.Windows.Forms.GroupBox()
        Me.RdbDiscount20 = New System.Windows.Forms.RadioButton()
        Me.RdbDiscount10 = New System.Windows.Forms.RadioButton()
        Me.RdbNoCoupon = New System.Windows.Forms.RadioButton()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnAddToOrder = New System.Windows.Forms.Button()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnNewOrder = New System.Windows.Forms.Button()
        Me.BtnSummary = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpService.SuspendLayout()
        Me.GrpCoupon.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpService
        '
        Me.GrpService.Controls.Add(Me.RdbPermanentMakeup)
        Me.GrpService.Controls.Add(Me.RdbManicure)
        Me.GrpService.Controls.Add(Me.RdbHairStyling)
        Me.GrpService.Controls.Add(Me.RdbMakeover)
        Me.GrpService.Location = New System.Drawing.Point(22, 71)
        Me.GrpService.Name = "GrpService"
        Me.GrpService.Size = New System.Drawing.Size(200, 180)
        Me.GrpService.TabIndex = 1
        Me.GrpService.TabStop = False
        Me.GrpService.Text = "Service"
        Me.ToolTip.SetToolTip(Me.GrpService, "Select service")
        '
        'RdbPermanentMakeup
        '
        Me.RdbPermanentMakeup.AutoSize = True
        Me.RdbPermanentMakeup.Location = New System.Drawing.Point(18, 138)
        Me.RdbPermanentMakeup.Name = "RdbPermanentMakeup"
        Me.RdbPermanentMakeup.Size = New System.Drawing.Size(118, 17)
        Me.RdbPermanentMakeup.TabIndex = 3
        Me.RdbPermanentMakeup.TabStop = True
        Me.RdbPermanentMakeup.Text = "Permanent Makeup"
        Me.RdbPermanentMakeup.UseVisualStyleBackColor = True
        '
        'RdbManicure
        '
        Me.RdbManicure.AutoSize = True
        Me.RdbManicure.Location = New System.Drawing.Point(18, 102)
        Me.RdbManicure.Name = "RdbManicure"
        Me.RdbManicure.Size = New System.Drawing.Size(69, 17)
        Me.RdbManicure.TabIndex = 2
        Me.RdbManicure.TabStop = True
        Me.RdbManicure.Text = "Manicure"
        Me.RdbManicure.UseVisualStyleBackColor = True
        '
        'RdbHairStyling
        '
        Me.RdbHairStyling.AutoSize = True
        Me.RdbHairStyling.Location = New System.Drawing.Point(18, 66)
        Me.RdbHairStyling.Name = "RdbHairStyling"
        Me.RdbHairStyling.Size = New System.Drawing.Size(78, 17)
        Me.RdbHairStyling.TabIndex = 1
        Me.RdbHairStyling.TabStop = True
        Me.RdbHairStyling.Text = "Hair Styling"
        Me.RdbHairStyling.UseVisualStyleBackColor = True
        '
        'RdbMakeover
        '
        Me.RdbMakeover.AutoSize = True
        Me.RdbMakeover.Location = New System.Drawing.Point(18, 30)
        Me.RdbMakeover.Name = "RdbMakeover"
        Me.RdbMakeover.Size = New System.Drawing.Size(73, 17)
        Me.RdbMakeover.TabIndex = 0
        Me.RdbMakeover.TabStop = True
        Me.RdbMakeover.Text = "Makeover"
        Me.RdbMakeover.UseVisualStyleBackColor = True
        '
        'GrpCoupon
        '
        Me.GrpCoupon.Controls.Add(Me.RdbDiscount20)
        Me.GrpCoupon.Controls.Add(Me.RdbDiscount10)
        Me.GrpCoupon.Controls.Add(Me.RdbNoCoupon)
        Me.GrpCoupon.Location = New System.Drawing.Point(241, 71)
        Me.GrpCoupon.Name = "GrpCoupon"
        Me.GrpCoupon.Size = New System.Drawing.Size(200, 134)
        Me.GrpCoupon.TabIndex = 2
        Me.GrpCoupon.TabStop = False
        Me.GrpCoupon.Text = "Coupon"
        Me.ToolTip.SetToolTip(Me.GrpCoupon, "select coupon amount")
        '
        'RdbDiscount20
        '
        Me.RdbDiscount20.AutoSize = True
        Me.RdbDiscount20.Location = New System.Drawing.Point(23, 100)
        Me.RdbDiscount20.Name = "RdbDiscount20"
        Me.RdbDiscount20.Size = New System.Drawing.Size(93, 17)
        Me.RdbDiscount20.TabIndex = 2
        Me.RdbDiscount20.TabStop = True
        Me.RdbDiscount20.Text = "20 % Discount"
        Me.RdbDiscount20.UseVisualStyleBackColor = True
        '
        'RdbDiscount10
        '
        Me.RdbDiscount10.AutoSize = True
        Me.RdbDiscount10.Location = New System.Drawing.Point(23, 65)
        Me.RdbDiscount10.Name = "RdbDiscount10"
        Me.RdbDiscount10.Size = New System.Drawing.Size(93, 17)
        Me.RdbDiscount10.TabIndex = 1
        Me.RdbDiscount10.Text = "10 % Discount"
        Me.RdbDiscount10.UseVisualStyleBackColor = True
        '
        'RdbNoCoupon
        '
        Me.RdbNoCoupon.AutoSize = True
        Me.RdbNoCoupon.Checked = True
        Me.RdbNoCoupon.Location = New System.Drawing.Point(23, 30)
        Me.RdbNoCoupon.Name = "RdbNoCoupon"
        Me.RdbNoCoupon.Size = New System.Drawing.Size(79, 17)
        Me.RdbNoCoupon.TabIndex = 0
        Me.RdbNoCoupon.TabStop = True
        Me.RdbNoCoupon.Text = "No Coupon"
        Me.RdbNoCoupon.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Old English Text MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Red
        Me.LblTitle.Location = New System.Drawing.Point(148, 22)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(197, 23)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Rifle Imaging Consulting"
        '
        'BtnAddToOrder
        '
        Me.BtnAddToOrder.Location = New System.Drawing.Point(365, 227)
        Me.BtnAddToOrder.Name = "BtnAddToOrder"
        Me.BtnAddToOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddToOrder.TabIndex = 3
        Me.BtnAddToOrder.Text = "&Add to Order"
        Me.BtnAddToOrder.UseVisualStyleBackColor = True
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(22, 292)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(82, 13)
        Me.LblPrice.TabIndex = 4
        Me.LblPrice.Text = "Price of Service"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(122, 289)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.ReadOnly = True
        Me.TxtPrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrice.TabIndex = 5
        Me.TxtPrice.TabStop = False
        Me.ToolTip.SetToolTip(Me.TxtPrice, "Price of service after coupon")
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.Location = New System.Drawing.Point(22, 327)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(82, 13)
        Me.LblSubTotal.TabIndex = 6
        Me.LblSubTotal.Text = "Sales Sub Total"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(122, 327)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubTotal.TabIndex = 7
        Me.TxtSubTotal.TabStop = False
        Me.ToolTip.SetToolTip(Me.TxtSubTotal, "Subtotal of sale before taxes")
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(364, 418)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnNewOrder
        '
        Me.BtnNewOrder.Enabled = False
        Me.BtnNewOrder.Location = New System.Drawing.Point(243, 418)
        Me.BtnNewOrder.Name = "BtnNewOrder"
        Me.BtnNewOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewOrder.TabIndex = 9
        Me.BtnNewOrder.Text = "&New Order"
        Me.BtnNewOrder.UseVisualStyleBackColor = True
        '
        'BtnSummary
        '
        Me.BtnSummary.Enabled = False
        Me.BtnSummary.Location = New System.Drawing.Point(122, 418)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(75, 23)
        Me.BtnSummary.TabIndex = 8
        Me.BtnSummary.Text = "&Summary"
        Me.BtnSummary.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 459)
        Me.Controls.Add(Me.BtnSummary)
        Me.Controls.Add(Me.BtnNewOrder)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.BtnAddToOrder)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.GrpCoupon)
        Me.Controls.Add(Me.GrpService)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rifle Image Consulting"
        Me.GrpService.ResumeLayout(False)
        Me.GrpService.PerformLayout()
        Me.GrpCoupon.ResumeLayout(False)
        Me.GrpCoupon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpService As System.Windows.Forms.GroupBox
    Friend WithEvents RdbPermanentMakeup As System.Windows.Forms.RadioButton
    Friend WithEvents RdbManicure As System.Windows.Forms.RadioButton
    Friend WithEvents RdbHairStyling As System.Windows.Forms.RadioButton
    Friend WithEvents RdbMakeover As System.Windows.Forms.RadioButton
    Friend WithEvents GrpCoupon As System.Windows.Forms.GroupBox
    Friend WithEvents RdbDiscount20 As System.Windows.Forms.RadioButton
    Friend WithEvents RdbDiscount10 As System.Windows.Forms.RadioButton
    Friend WithEvents RdbNoCoupon As System.Windows.Forms.RadioButton
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnAddToOrder As System.Windows.Forms.Button
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblSubTotal As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnNewOrder As System.Windows.Forms.Button
    Friend WithEvents BtnSummary As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
