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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        If ListView1.SelectedItems.Count = 1 Then
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
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
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

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click, ListView1.MouseMove
        'MouseMove because it works I guess
        If ListView1.SelectedItems.Count = 1 Then
            OpenButton.Show()
            DeleteButton.Show()
            OpenFolderButton.Show()
            RenameButton.Show()
        Else
            OpenButton.Hide()
            DeleteButton.Hide()
            OpenFolderButton.Hide()
            RenameButton.Hide()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If ListView1.SelectedItems.Count = 1 Then
            If MsgBox("Really delete '" & ListView1.SelectedItems.Item(0).Text & "'?", MsgBoxStyle.YesNo, "Delete Project") = DialogResult.Yes Then
                Try
                    My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & ListView1.SelectedItems.Item(0).Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch ex As Exception
                    MsgBox("An error occurred:" & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                End Try
                ListView1.Items.Clear()
                For Each item As String In My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\")
                    ListView1.Items.Add(Path.GetFileNameWithoutExtension(item))
                Next
                OpenButton.Hide()
                DeleteButton.Hide()
                OpenFolderButton.Hide()
                RenameButton.Hide()
            End If
        End If
    End Sub

    Private Sub OpenFolderButton_Click(sender As Object, e As EventArgs) Handles OpenFolderButton.Click
        If ListView1.SelectedItems.Count = 1 Then
            Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & ListView1.SelectedItems.Item(0).Text)
        End If
    End Sub

    Private Sub RenameButton_Click(sender As Object, e As EventArgs) Handles RenameButton.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim dialog As New RenameProjectDialog
            dialog.TextBox1.Text = ListView1.SelectedItems.Item(0).Text
            If dialog.ShowDialog() = DialogResult.OK Then
                If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & dialog.TextBox1.Text) Then
                    MsgBox("There is already a project with the name '" & dialog.TextBox1.Text & ".'")
                Else
                    Try
                        My.Computer.FileSystem.RenameDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & ListView1.SelectedItems.Item(0).Text, dialog.TextBox1.Text)
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & dialog.TextBox1.Text & "\ppg_data\project\pagetitle", dialog.TextBox1.Text, False)
                    Catch ex As Exception
                        MsgBox("An error occurred:" & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                    End Try
                    ListView1.Items.Clear()
                    For Each item As String In My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\")
                        ListView1.Items.Add(Path.GetFileNameWithoutExtension(item))
                    Next
                    OpenButton.Hide()
                    DeleteButton.Hide()
                    OpenFolderButton.Hide()
                    RenameButton.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        About.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        If MsgBox("Please note that PhotoPage Studio hasn't been updated in awhile and may be buggy. It's more recommended right now to create Custom Templates via your favorite text editor, using Analyze mode in PhotoPage as a guide. Launch PhotoPage Studio anyway?", MsgBoxStyle.YesNo, "Hold on!") = MsgBoxResult.Yes Then
            Dim studio As New Studio
            studio.Show()
            Me.Close()
        End If
    End Sub
End Class