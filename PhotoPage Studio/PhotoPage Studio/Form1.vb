Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim welcome As New Welcome
        welcome.MdiParent = Me
        welcome.Show()

        Dim C As Control

        For Each C In Me.Controls
            If TypeOf C Is MdiClient Then
                C.BackColor = Me.BackColor
                Exit For
            End If
        Next

        C = Nothing
    End Sub
End Class
