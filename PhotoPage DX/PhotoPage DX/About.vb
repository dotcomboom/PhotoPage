Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Launcher.getVersion()
    End Sub
End Class