Public Class Welcome
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim editor As New Editor
        editor.MdiParent = Form1
        editor.Show()
    End Sub
End Class