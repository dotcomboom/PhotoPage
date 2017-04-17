Imports System.IO

Public Class CoverPhoto
    Private Sub CoverPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each file As String In IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
            If file.EndsWith("mp4") Or file.EndsWith("mp3") Or file.EndsWith("html") Then
            Else
                ListBox1.Items.Add(Path.GetFileName(file))
            End If
        Next
    End Sub
End Class