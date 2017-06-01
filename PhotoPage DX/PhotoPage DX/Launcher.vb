Imports System.IO

Public Class Launcher
    Public Function getVersion()
        Dim year As String
        Dim month As String
        Dim day As String
        Dim revision As String

        year = My.Application.Info.Version.Major
        month = My.Application.Info.Version.Minor
        day = My.Application.Info.Version.Build
        revision = My.Application.Info.Version.Revision

        If month.Length = 1 Then
            month = "0" & month
        End If

        If day.Length = 1 Then
            day = "0" & day
        End If

        Return year & month & day & "." & revision
    End Function
    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "PhotoPage " & getVersion()
        ToolStripStatusLabel1.Text = "PhotoPage " & getVersion()


        For Each item As String In My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\")
            ListView1.Items.Add(Path.GetFileNameWithoutExtension(item))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            If MsgBox("Another instance of PhotoPage may be currently running. Please close it and try again. If no other instance of PhotoPage is currently running, click Yes to delete all temporary files.", MsgBoxStyle.YesNo, "Notice") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Form1.Show()
                Me.Close()
            End If
        Else
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Step1.Hide()
        OpenPanel.Show()
        'If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
        '    If MsgBox("Another instance of PhotoPage may be currently running. Please close it and try again. If no other instance of PhotoPage is currently running, click Yes to delete all temporary files.", MsgBoxStyle.YesNo, "Notice") = MsgBoxResult.Yes Then
        '        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        '        Form1.Show()
        '        Me.Hide()
        '        Form1.OpenProject()
        '        Me.Close()
        '    End If
        'Else
        '    Form1.Show()
        '    Me.Hide()
        '    Form1.OpenProject()
        '    Me.Close()
        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim studio As New Studio
        studio.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Step1.Show()
        OpenPanel.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            If MsgBox("Another instance of PhotoPage may be currently running. Please close it and try again. If no other instance of PhotoPage is currently running, click Yes to delete all temporary files.", MsgBoxStyle.YesNo, "Notice") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Form1.Show()
                Me.Hide()
                Form1.OpenProject(ListView1.SelectedItems.Item(0).Text)
                Me.Close()
            End If
        Else
            Form1.Show()
            Me.Hide()
            Form1.OpenProject(ListView1.SelectedItems.Item(0).Text)
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            If MsgBox("Another instance of PhotoPage may be currently running. Please close it and try again. If no other instance of PhotoPage is currently running, click Yes to delete all temporary files.", MsgBoxStyle.YesNo, "Notice") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Form1.Show()
                Me.Hide()
                Form1.OpenProject()
                Me.Close()
            End If
        Else
            Form1.Show()
            Me.Hide()
            Form1.OpenProject()
            Me.Close()
        End If
    End Sub
End Class