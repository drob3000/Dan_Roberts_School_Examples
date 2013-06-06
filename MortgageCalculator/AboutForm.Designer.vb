<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblSchool = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.LblCreator = New System.Windows.Forms.Label()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.ToolAbout = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnClose.Location = New System.Drawing.Point(237, 278)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.ToolAbout.SetToolTip(Me.BtnClose, "Close about window")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblSchool
        '
        Me.LblSchool.AutoSize = True
        Me.LblSchool.Location = New System.Drawing.Point(185, 67)
        Me.LblSchool.Name = "LblSchool"
        Me.LblSchool.Size = New System.Drawing.Size(106, 13)
        Me.LblSchool.TabIndex = 3
        Me.LblSchool.Text = "University of Phoenix"
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(118, 108)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(248, 91)
        Me.LblDescription.TabIndex = 4
        Me.LblDescription.Text = resources.GetString("LblDescription.Text")
        '
        'LblCreator
        '
        Me.LblCreator.AutoSize = True
        Me.LblCreator.Location = New System.Drawing.Point(25, 283)
        Me.LblCreator.Name = "LblCreator"
        Me.LblCreator.Size = New System.Drawing.Size(146, 13)
        Me.LblCreator.TabIndex = 5
        Me.LblCreator.Text = "Programmed by: Dan Roberts"
        '
        'PicLogo
        '
        Me.PicLogo.ErrorImage = Nothing
        Me.PicLogo.Image = Global.MortgageCalculator.My.Resources.Resources.images__4_
        Me.PicLogo.Location = New System.Drawing.Point(12, 25)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(91, 125)
        Me.PicLogo.TabIndex = 1
        Me.PicLogo.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("French Script MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(125, 25)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(215, 37)
        Me.LblTitle.TabIndex = 6
        Me.LblTitle.Text = "Mortgage Calculator"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(380, 329)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblCreator)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.LblSchool)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.BtnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AboutForm"
        Me.Text = "About the Mortgage Calculator"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblSchool As System.Windows.Forms.Label
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents LblCreator As System.Windows.Forms.Label
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents ToolAbout As System.Windows.Forms.ToolTip
End Class
