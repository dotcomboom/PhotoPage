Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim welcome As New Welcome
        welcome.MdiParent = Me
        welcome.Show()
    End Sub
End Class
