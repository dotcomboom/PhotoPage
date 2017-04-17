Public Class Feedback
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = "Compiling report"
        Dim report = "PhotoPage Version: " & TextBox2.Text & vbNewLine & "Type: " & ComboBox1.SelectedItem & vbNewLine & vbNewLine & "Comments:" & vbNewLine & TextBox1.Text
        Label4.Text = "Contacting server"
        MsgBox(report)
    End Sub
End Class