<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddParagraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ParagraphTextBox = New System.Windows.Forms.TextBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ParagraphTextBox
        '
        Me.ParagraphTextBox.AcceptsReturn = True
        Me.ParagraphTextBox.AcceptsTab = True
        Me.ParagraphTextBox.Location = New System.Drawing.Point(12, 12)
        Me.ParagraphTextBox.Multiline = True
        Me.ParagraphTextBox.Name = "ParagraphTextBox"
        Me.ParagraphTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ParagraphTextBox.Size = New System.Drawing.Size(337, 198)
        Me.ParagraphTextBox.TabIndex = 0
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(274, 216)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Location = New System.Drawing.Point(193, 216)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'AddParagraph
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 248)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ParagraphTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddParagraph"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add Paragraph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ParagraphTextBox As TextBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents OKButton As Button
End Class
