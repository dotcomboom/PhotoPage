<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedPreview
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FontStack = New System.Windows.Forms.TextBox()
        Me.BackgroundColor = New System.Windows.Forms.TextBox()
        Me.TextColor = New System.Windows.Forms.TextBox()
        Me.PageTitleBox = New System.Windows.Forms.TextBox()
        Me.DescriptionBox = New System.Windows.Forms.TextBox()
        Me.FooterText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Page Title"
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Location = New System.Drawing.Point(116, 195)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(197, 195)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 8
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Footer Text"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Text Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Background Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fonts"
        '
        'FontStack
        '
        Me.FontStack.Location = New System.Drawing.Point(54, 149)
        Me.FontStack.Name = "FontStack"
        Me.FontStack.Size = New System.Drawing.Size(218, 22)
        Me.FontStack.TabIndex = 6
        Me.FontStack.Text = """Segoe UI"", ""Segoe"", ""Tahoma"", ""Geneva"""
        '
        'BackgroundColor
        '
        Me.BackgroundColor.Location = New System.Drawing.Point(226, 123)
        Me.BackgroundColor.Name = "BackgroundColor"
        Me.BackgroundColor.Size = New System.Drawing.Size(46, 22)
        Me.BackgroundColor.TabIndex = 5
        Me.BackgroundColor.Text = "FFFFFF"
        '
        'TextColor
        '
        Me.TextColor.Location = New System.Drawing.Point(226, 95)
        Me.TextColor.Name = "TextColor"
        Me.TextColor.Size = New System.Drawing.Size(46, 22)
        Me.TextColor.TabIndex = 4
        Me.TextColor.Text = "000000"
        '
        'PageTitleBox
        '
        Me.PageTitleBox.Location = New System.Drawing.Point(84, 6)
        Me.PageTitleBox.Name = "PageTitleBox"
        Me.PageTitleBox.Size = New System.Drawing.Size(188, 22)
        Me.PageTitleBox.TabIndex = 1
        Me.PageTitleBox.Text = "PhotoPage Studio"
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Location = New System.Drawing.Point(84, 30)
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(188, 22)
        Me.DescriptionBox.TabIndex = 2
        Me.DescriptionBox.Text = "Template Preview"
        '
        'FooterText
        '
        Me.FooterText.Location = New System.Drawing.Point(84, 56)
        Me.FooterText.Name = "FooterText"
        Me.FooterText.Size = New System.Drawing.Size(188, 22)
        Me.FooterText.TabIndex = 3
        Me.FooterText.Text = "PhotoPage Studio 2017"
        '
        'AdvancedPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 230)
        Me.Controls.Add(Me.FooterText)
        Me.Controls.Add(Me.DescriptionBox)
        Me.Controls.Add(Me.PageTitleBox)
        Me.Controls.Add(Me.TextColor)
        Me.Controls.Add(Me.BackgroundColor)
        Me.Controls.Add(Me.FontStack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdvancedPreview"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Preview Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FontStack As TextBox
    Friend WithEvents BackgroundColor As TextBox
    Friend WithEvents TextColor As TextBox
    Friend WithEvents PageTitleBox As TextBox
    Friend WithEvents DescriptionBox As TextBox
    Friend WithEvents FooterText As TextBox
End Class
