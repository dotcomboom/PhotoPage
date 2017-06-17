Public Class About
    Private counter = 0

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Launcher.getVersion()
    End Sub

    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        counter += 1
        If counter = 100 Then
            Label3.Text = "has no easter eggs"
        End If
        If counter = 125 Then
            Label3.Text = "still has no easter eggs"
        End If
        If counter = 150 Then
            Me.Close()
        End If
    End Sub
End Class