Public Class Welcome
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim editor As New Editor
        editor.MdiParent = Form1
        editor.Show()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Label3.Text = "New Template"
        Label2.Text = "Open a new Template Editor window."
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        Label3.Text = "Open Template"
        Label2.Text = "Modify an existing template."
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        Label3.Text = "Tutorial"
        Label2.Text = "Learn how to create your own templates."
    End Sub

    Private Sub Welcome_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Label3.Text = ""
        Label2.Text = ""
    End Sub
End Class