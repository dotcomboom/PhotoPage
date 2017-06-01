Imports System.IO

Public Class Form1

    Public undoing = False
    Public dlg As DialogResult

    Private Sub Ribbon1_OrbClicked(sender As Object, e As EventArgs) Handles Ribbon1.OrbClicked
        Ribbon1.OrbPressed = False
        OrbMenu.Show(Ribbon1, 0, 23)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "PhotoPage " & Launcher.getVersion() & " - Untitled"
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
            Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
            If (di.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                di.Attributes = di.Attributes Or FileAttributes.Hidden
            End If
        End If
        AddPhotosDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        AddVideosDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        AddAudioDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        HistoryListBox.Items.Add("")
        Preview()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Function Preview()
        If RealTimePreviewToolStripMenuItem.Checked Then
            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                If (di.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                    di.Attributes = di.Attributes Or FileAttributes.Hidden
                End If
            End If
            If CustomTemplateButton.Checked = False Then
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\index.html", template.Text.Replace("[#pagetitle#]", PageTitleTextBox.TextBoxText).Replace("[#description#]", DescriptionTextBox.TextBoxText).Replace("[#content#]", code.Text).Replace("[#footer#]", FooterTextBox.TextBoxText).Replace("[#fonts#]", genFonts()).Replace("[#color#]", TextColorChooser.Tag).Replace("[#bgcolor#]", BackgroundColorChooser.Tag).Replace("[#coverphoto#]", coverPhoto.Text), False)
            Else
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\index.html", My.Computer.FileSystem.ReadAllText(CustomTemplateButton.Tag).Replace("[#pagetitle#]", PageTitleTextBox.TextBoxText).Replace("[#description#]", DescriptionTextBox.TextBoxText).Replace("[#content#]", code.Text).Replace("[#footer#]", FooterTextBox.TextBoxText).Replace("[#fonts#]", genFonts()).Replace("[#color#]", TextColorChooser.Tag).Replace("[#bgcolor#]", BackgroundColorChooser.Tag).Replace("[#coverphoto#]", coverPhoto.Text), False)
            End If
            PreviewBrowser.Navigate("file://" & (My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\index.html"))
        End If
        Return True
    End Function

    Private Function Debug()
        DebugInfo.Text = "[#pagetitle#]  " & PageTitleTextBox.TextBoxText & vbNewLine & "[#description#]  " & DescriptionTextBox.TextBoxText & vbNewLine & "[#footer#]  " & FooterTextBox.TextBoxText & vbNewLine & "[#content#]  " & code.Text & vbNewLine & "[#fonts#]  " & genFonts() & vbNewLine & "[#color#]  " & TextColorChooser.Tag & vbNewLine & "[#bgcolor#]  " & BackgroundColorChooser.Tag & vbNewLine & "[#coverphoto#]  " & coverPhoto.Text
        Return True
    End Function

    Private Function checkif(control As Object, tag As String, template As String)
        If template.Contains(tag) Then
            control.Enabled = True
            Return True
        Else
            control.Enabled = False
            Return False
        End If
    End Function

    Private Function genFonts()
        Dim stack As String = ""

        For Each i As String In FontList.Items
            'stack = ", '" & i & "'" & stack
            stack = stack & "'" & i & "', "
        Next

        stack = stack & "sans-serif"

        Return stack
    End Function

    Private Function AddtoProject(file As String)
        StatusLabel.Text = "Adding " & file
        Me.UseWaitCursor = True
        Me.Cursor = Cursors.WaitCursor
        If My.Computer.FileSystem.DirectoryExists(file) Then
            For Each subfile As String In My.Computer.FileSystem.GetFiles(file)
                AddtoProject(subfile)
            Next
        Else
            If file.EndsWith(".mp4") Then
                Try
                    code.Text = code.Text & videotemplate.Text.Replace("[#video#]", Path.GetFileName(file)) & vbNewLine
                    My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\" & Path.GetFileName(file), True)

                    Dim drInfo As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                    Dim filesInfo() As FileInfo = drInfo.GetFiles("*.*", SearchOption.AllDirectories)
                    Dim fileSize As Long = 0
                    For Each fileInfo As FileInfo In filesInfo
                        fileSize += fileInfo.Length
                    Next
                    ProjectSizeLabel.Text = Math.Round(fileSize / 1000000, 2) & " MB"
                Catch ex As Exception
                    MsgBox("Failed to open " & file & ": " & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                End Try
            ElseIf file.EndsWith(".mp3") Then
                Try
                    code.Text = code.Text & audiotemplate.Text.Replace("[#audio#]", Path.GetFileName(file)) & vbNewLine
                    My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\" & Path.GetFileName(file), True)

                    Dim drInfo As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                    Dim filesInfo() As FileInfo = drInfo.GetFiles("*.*", SearchOption.AllDirectories)
                    Dim fileSize As Long = 0
                    For Each fileInfo As FileInfo In filesInfo
                        fileSize += fileInfo.Length
                    Next
                    ProjectSizeLabel.Text = Math.Round(fileSize / 1000000, 2) & " MB"
                Catch ex As Exception
                    MsgBox("Failed to open " & file & ": " & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                End Try
            Else
                Try
                    Dim bitmap = New Bitmap(file, True)
                    code.Text = code.Text & imgtemplate.Text.Replace("[#img#]", Path.GetFileName(file)).Replace("[#width#]", bitmap.Width * (110 / bitmap.Height)) & vbNewLine
                    My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\" & Path.GetFileName(file), True)

                    Dim drInfo As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                    Dim filesInfo() As FileInfo = drInfo.GetFiles("*.*", SearchOption.AllDirectories)
                    Dim fileSize As Long = 0
                    For Each fileInfo As FileInfo In filesInfo
                        fileSize += fileInfo.Length
                    Next
                    ProjectSizeLabel.Text = Math.Round(fileSize / 1000000, 2) & " MB"
                Catch ex As Exception
                    'MsgBox("The file " & file & " could not be identified." & vbNewLine & vbNewLine & ex.ToString & vbNewLine & vbNewLine & "The file has not been added.", MsgBoxStyle.Exclamation, "Notice")
                End Try
            End If
        End If
        Me.UseWaitCursor = False
        Me.Cursor = Cursors.Default
        StatusLabel.Text = ""
        Return True
    End Function

    Private Function buildppgp()
        Dim SB As New System.Text.StringBuilder()
        SB.AppendLine("[1] " & genFonts())
        SB.AppendLine("[2] " & BackgroundColorChooser.Tag)
        SB.AppendLine("[3] " & TextColorChooser.Tag)
        Return SB.ToString
    End Function

    Private Function loadppgp(filename As String)
        Dim strFileName() As String
        strFileName = IO.File.ReadAllLines(filename)
        For Each Line In strFileName '// loop thru Arrays.
            If Line.StartsWith("[1] ") Then
                FontList.Items.Clear()
                For Each i As String In Line.Replace("[1] ", "").Replace(", sans-serif", "").Replace(",sans-serif", "").Replace("'", "").Replace(", ", ",").Split(",")
                    FontList.Items.Add(i)
                Next
            End If
            If Line.StartsWith("[2] ") Then
                'BackgroundColorChooser.Tag = Line.Replace("[2] ", "")
                BackgroundColorChooser.Color = ColorTranslator.FromHtml("#" & Line.Replace("[2] ", ""))
            End If
            If Line.StartsWith("[3] ") Then
                'TextColorChooser.Tag = Line.Replace("[3] ", "")
                TextColorChooser.Color = ColorTranslator.FromHtml("#" & Line.Replace("[3] ", ""))
            End If
        Next
        Return True
    End Function

    Private Function templateCheck(template As String)
        Dim msg = "The following features are unused in the template and have been disabled:" & vbNewLine
        Dim yay = True

        If Not checkif(DescriptionTextBox, "[#description#]", template) Then
            msg = msg & vbNewLine & "- Page Description"
            yay = False
        End If
        If Not checkif(FooterTextBox, "[#footer#]", template) Then
            msg = msg & vbNewLine & "- Page Footer"
            yay = False
        End If
        If Not checkif(RibbonPanel6, "[#fonts#]", template) Then
            msg = msg & vbNewLine & "- Font Faces"
            yay = False
        End If
        If Not checkif(TextColorChooser, "[#color#]", template) Then
            msg = msg & vbNewLine & "- Color 1"
            yay = False
        End If
        If Not checkif(BackgroundColorChooser, "[#bgcolor#]", template) Then
            msg = msg & vbNewLine & "- Color 2"
            yay = False
        End If
        If Not checkif(CoverPhotoButton, "[#coverphoto#]", template) Then
            msg = msg & vbNewLine & "- Cover Photo"
            yay = False
        End If
        If Not yay Then
            MsgBox(msg, MsgBoxStyle.Information, "Feature Check")
        End If
        Return True
    End Function

    Private Sub PreviewTextBoxes(sender As Object, e As EventArgs) Handles PageTitleTextBox.TextBoxTextChanged, DescriptionTextBox.TextBoxTextChanged, FooterTextBox.TextBoxTextChanged, FontList.DrawItem, code.TextChanged
        Debug()
        Preview()
    End Sub

    Private Sub RadButtonElement1_Click(sender As Object, e As EventArgs) Handles AddPhotosButton.Click, AddPhotosQAButton.Click, ToolStripMenuItem2.Click
        If AddPhotosDialog.ShowDialog = DialogResult.OK Then
            For Each file As [String] In AddPhotosDialog.FileNames
                AddtoProject(file)
            Next
        End If
    End Sub

    Private Sub CustomTemplateButton_Click(sender As Object, e As EventArgs) Handles CustomTemplateButton.Click
        If CustomTemplateButton.Checked Then
            CustomTemplateButton.Checked = False
            If OpenTemplateDialog.ShowDialog() = DialogResult.OK Then
                CustomTemplateButton.Tag = OpenTemplateDialog.FileName
                CustomTemplateButton.Checked = True
                Try
                    templateCheck(My.Computer.FileSystem.ReadAllText(CustomTemplateButton.Tag))
                Catch ex As Exception
                    MsgBox("An error occurred while performing the Feature Check: " & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                End Try
            Else
                CustomTemplateButton.Checked = False
            End If
        Else
            Try
                templateCheck(template.Text)
            Catch ex As Exception
                MsgBox("An error occurred while performing the Feature Check: " & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
            End Try
        End If
        Preview()
    End Sub

    Private Sub PageTitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles PageTitleTextBox.TextBoxTextChanged
        Me.Text = "PhotoPage " & Launcher.getVersion() & " - " & PageTitleTextBox.TextBoxText
        If PageTitleTextBox.TextBoxText.Length > 0 Then
            Me.Text = "PhotoPage " & Launcher.getVersion() & " - " & PageTitleTextBox.TextBoxText
        Else
            Me.Text = "PhotoPage " & Launcher.getVersion() & " - Untitled"
        End If
    End Sub

    Private Sub AddHeadingButton_Click(sender As Object, e As EventArgs) Handles AddHeadingButton.Click, AddHeadingToolStripMenuItem.Click, AddHeadingQAButton.Click
        Dim input As String
        input = InputBox("Please enter some text for the heading:", "Add Heading")
        If input <> "" Then
            code.Text = code.Text & "<h3 class='heading'>" & input & "</h3>" & vbNewLine
        End If
        Refresh()
    End Sub

    Private Sub AddParagraphButton_Click(sender As Object, e As EventArgs) Handles AddParagraphButton.Click, AddParagraphToolStripMenuItem.Click, AddParagraphQAButton.Click
        Dim paragraphDialog As New AddParagraph
        If paragraphDialog.ShowDialog() = DialogResult.OK Then
            code.Text = code.Text & "<p class='paragraph'>" & paragraphDialog.ParagraphTextBox.Text.Replace(vbNewLine, "<br>") & "</p>" & vbNewLine
        End If
        Refresh()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
        End If
        code.Text = ""
        ProjectSizeLabel.Text = "0 MB"
    End Sub

    Private Sub PreviewBrowser_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Ribbon1.DragDrop
        StatusLabel.Text = ""
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each file In files
            AddtoProject(file)
        Next
    End Sub

    Private Sub Label1_DragEnter(sender As Object, e As DragEventArgs) Handles Ribbon1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            StatusLabel.Text = "Drop to add files"
        End If
    End Sub

    Private Sub RadButtonElement7_Click(sender As Object, e As EventArgs) Handles OpenPresetButton.Click
        If OpenPresetDialog.ShowDialog = DialogResult.OK Then
            Try
                loadppgp(OpenPresetDialog.FileName)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub RadButtonElement8_Click(sender As Object, e As EventArgs) Handles SavePresetButton.Click
        If SavePresetDialog.ShowDialog = DialogResult.OK Then
            Try

                Dim SW As New StreamWriter(SavePresetDialog.FileName)
                SW.Write(buildppgp())
                SW.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PreviewBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles PreviewBrowser.DocumentCompleted
        If Not PreviewBrowser.Url.AbsoluteUri.EndsWith(".html") Then
            PreviewBrowser.Navigate("file://" & (My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\index.html"))
        End If
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        If MsgBox("Start a new project? All unsaved changes will be lost!", MsgBoxStyle.YesNo, "New Project") = MsgBoxResult.Yes Then
            If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
            End If
            ProjectSizeLabel.Text = "0 MB"

            code.Text = ""

            PageTitleTextBox.TextBoxText = ""
            DescriptionTextBox.TextBoxText = ""
            FooterTextBox.TextBoxText = ""

            FontList.Items.Clear()
            FontList.Items.Add("Segoe UI")
            FontList.Items.Add("Segoe")
            FontList.Items.Add("Tahoma")
            FontList.Items.Add("Geneva")

            CustomTemplateButton.Checked = False

            BackgroundColorChooser.Tag = "FFFFFF"
            TextColorChooser.Tag = "000000"

            BackgroundColorChooser.Color = Color.White
            TextColorChooser.Color = Color.Black

            templateCheck(template.Text)
        End If
    End Sub

    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles MyProjectsToolStripMenuItem.Click
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects")
    End Sub

    Private Sub RadMenuItem3_Click(sender As Object, e As EventArgs) Handles BetaCentralToolStripMenuItem.Click
        Process.Start("https://rink.hockeyapp.net/apps/71b12a2053c44526b47386c53239f6d6/")
    End Sub

    Private Sub RadMenuItem4_Click(sender As Object, e As EventArgs) Handles PhotoPageStudioToolStripMenuItem.Click, CreateTemplateButton.Click
        Dim studio As New Studio
        studio.Show()
    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click, FinishQAButton.Click, ToolStripMenuItem3.Click
        StatusLabel.Text = "Saving project"
        If PageTitleTextBox.TextBoxText = "" Then
            PageTitleTextBox.TextBoxText = "Untitled"
            Me.Text = "PhotoPage " & Launcher.getVersion() & " - Untitled"
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
            Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
            If (di.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                di.Attributes = di.Attributes Or FileAttributes.Hidden
            End If
        End If
        If CustomTemplateButton.Checked = False Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\index.html", template.Text.Replace("[#pagetitle#]", PageTitleTextBox.TextBoxText).Replace("[#description#]", DescriptionTextBox.TextBoxText).Replace("[#content#]", code.Text).Replace("[#footer#]", FooterTextBox.TextBoxText).Replace("[#fonts#]", genFonts()).Replace("[#color#]", TextColorChooser.Tag).Replace("[#bgcolor#]", BackgroundColorChooser.Tag).Replace("[#coverphoto#]", coverPhoto.Text), False)
        Else
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\index.html", My.Computer.FileSystem.ReadAllText(CustomTemplateButton.Tag).Replace("[#pagetitle#]", PageTitleTextBox.TextBoxText).Replace("[#description#]", DescriptionTextBox.TextBoxText).Replace("[#content#]", code.Text).Replace("[#footer#]", FooterTextBox.TextBoxText).Replace("[#fonts#]", genFonts()).Replace("[#color#]", TextColorChooser.Tag).Replace("[#bgcolor#]", BackgroundColorChooser.Tag).Replace("[#coverphoto#]", coverPhoto.Text), False)
        End If
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & PageTitleTextBox.TextBoxText) Then
            If MsgBox("A project with that name already exists. Overwrite it?", MsgBoxStyle.YesNo, "Conflict") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & PageTitleTextBox.TextBoxText, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Else
                MsgBox("Change the name of the project, then try again.", MsgBoxStyle.Critical, "Guru Meditation")
                StatusLabel.Text = ""
                Exit Sub
            End If
        End If
        Dim foldername As String = PageTitleTextBox.TextBoxText
        If PageTitleTextBox.TextBoxText = "" Then
            foldername = "Untitled"
        Else
            Dim invalid As String = New String(Path.GetInvalidFileNameChars()) & New String(Path.GetInvalidPathChars())
            For Each c As Char In invalid
                foldername = foldername.Replace(c.ToString(), "-")
            Next
        End If
        Try
            Dim root = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\ppg_data\"
            Dim project = root & "project\"
            Dim content = root & "content\"
            Dim style = root & "style\"

            My.Computer.FileSystem.CreateDirectory(root)
            My.Computer.FileSystem.CreateDirectory(project)
            My.Computer.FileSystem.CreateDirectory(content)
            My.Computer.FileSystem.CreateDirectory(style)

            My.Computer.FileSystem.WriteAllText(project & "pagetitle", PageTitleTextBox.TextBoxText, False)
            My.Computer.FileSystem.WriteAllText(project & "description", DescriptionTextBox.TextBoxText, False)
            My.Computer.FileSystem.WriteAllText(project & "footer", FooterTextBox.TextBoxText, False)

            My.Computer.FileSystem.WriteAllText(content & "html", code.Text, False)
            Dim historyBuilder As New System.Text.StringBuilder()
            For Each o As Object In HistoryListBox.Items
                historyBuilder.AppendLine("item----")
                historyBuilder.AppendLine(o)
                historyBuilder.AppendLine("----item")
            Next
            My.Computer.FileSystem.WriteAllText(content & "history", historyBuilder.ToString(), False)
            Dim fontsBuilder As New System.Text.StringBuilder()
            For Each o As Object In FontList.Items
                fontsBuilder.AppendLine(o)
            Next

            My.Computer.FileSystem.WriteAllText(style & "ppgp", buildppgp(), False)
            If CustomTemplateButton.Checked Then
                My.Computer.FileSystem.WriteAllText(style & "ppgt-path", CustomTemplateButton.Tag, False)
            End If

            My.Computer.FileSystem.WriteAllText(root & "readme.txt", "This folder is meant to be used internally within the PhotoPage program to hold project information. If you're uploading or sharing this project and don't wish for it to be editable by the program, exclude this folder.", False)
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.CopyDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp" & "\", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & foldername & "\")
            StatusLabel.Text = ""
            MsgBox("Successfully produced page!", MsgBoxStyle.Information, "Success")
            Process.Start((My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & foldername & "\"))
        Catch ex As Exception
            StatusLabel.Text = ""
            MsgBox("Page creation unsuccessful:" & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
        End Try
    End Sub

    Private Sub AboutPhotoPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPhotoPageToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub code_TextChanged(sender As Object, e As EventArgs) Handles code.TextChanged
        If Not undoing Then
            HistoryListBox.Items.Add(code.Text)
        End If
    End Sub

    Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles UndoButton.Click
        If HistoryListBox.Items.Count > 1 Then
            undoing = True
            HistoryListBox.Items.RemoveAt(HistoryListBox.Items.Count - 1)
            code.Text = HistoryListBox.Items.Item(HistoryListBox.Items.Count - 1)
            undoing = False
            For Each File In Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                If Not File.EndsWith(".html") Then
                    If Not code.Text.Contains(Path.GetFileName(File)) Then
                        Try
                            My.Computer.FileSystem.DeleteFile(File, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

                            Dim drInfo As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp")
                            Dim filesInfo() As FileInfo = drInfo.GetFiles("*.*", SearchOption.AllDirectories)
                            Dim fileSize As Long = 0
                            For Each fileInfo As FileInfo In filesInfo
                                fileSize += fileInfo.Length
                            Next
                            ProjectSizeLabel.Text = Math.Round(fileSize / 1000000, 2) & " MB"
                        Catch ex As Exception
                            MsgBox("Unable to delete file (" & File & "):" & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                        End Try
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub AddVideoButton_Click(sender As Object, e As EventArgs) Handles AddVideoButton.Click, ToolStripMenuItem1.Click
        If AddVideosDialog.ShowDialog = DialogResult.OK Then
            For Each file As [String] In AddVideosDialog.FileNames
                AddtoProject(file)
            Next
        End If
    End Sub

    Private Sub AddAudioButton_Click(sender As Object, e As EventArgs) Handles AddAudioButton.Click, AddPhotosToolStripMenuItem.Click
        If AddAudioDialog.ShowDialog = DialogResult.OK Then
            For Each file As [String] In AddAudioDialog.FileNames
                AddtoProject(file)
            Next
        End If
    End Sub

    Private Sub AddFontButton_Click(sender As Object, e As EventArgs) Handles AddFontButton.Click
        Dim fontDialog As New AddFontDialog
        If fontDialog.ShowDialog() = DialogResult.OK Then
            FontList.Items.Insert(0, fontDialog.SelectedFont.Name)
            Preview()
        End If
    End Sub

    Private Sub RemoveFontButton_Click(sender As Object, e As EventArgs) Handles RemoveFontButton.Click
        FontList.Items.Remove(FontList.SelectedItem)
        Preview()
    End Sub

    Private Sub UpFontButton_Click(sender As Object, e As EventArgs) Handles UpFontButton.Click
        If Not FontList.SelectedItem Is Nothing OrElse FontList.SelectedIndex < 0 Then
            Dim newIndex As Integer = FontList.SelectedIndex - 1
            If Not newIndex < 0 OrElse newIndex >= FontList.Items.Count Then
                Dim selected As Object = FontList.SelectedItem
                FontList.Items.Remove(selected)
                FontList.Items.Insert(newIndex, selected)
                FontList.SetSelected(newIndex, True)
            End If
        End If
        Preview()
    End Sub

    Private Sub DownFontButton_Click(sender As Object, e As EventArgs) Handles DownFontButton.Click
        Try
            If Not FontList.SelectedItem Is Nothing OrElse FontList.SelectedIndex < 0 Then
                Dim newIndex As Integer = FontList.SelectedIndex + 1
                If Not newIndex < 0 OrElse newIndex >= FontList.Items.Count Then
                    Dim selected As Object = FontList.SelectedItem
                    FontList.Items.Remove(selected)
                    FontList.Items.Insert(newIndex, selected)
                    FontList.SetSelected(newIndex, True)
                End If
            End If
        Catch ex As Exception
        End Try
        Preview()
    End Sub

    Private Sub BackgroundColorChooser_ColorChanged(sender As Object, e As EventArgs) Handles BackgroundColorChooser.ColorChanged
        BackgroundColorChooser.Tag = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(BackgroundColorChooser.Color.ToArgb())).Replace("#", "")
        Preview()
    End Sub

    Private Sub TextColorChooser_ColorChanged(sender As Object, e As EventArgs) Handles TextColorChooser.ColorChanged
        TextColorChooser.Tag = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(TextColorChooser.Color.ToArgb())).Replace("#", "")
        Preview()
    End Sub

    Private Sub TextColorPicker_ColorSelected() Handles Color1Picker.ColorSelected
        TextColorChooser.CloseDropDown()
        TextColorChooser.Color = Color1Picker.Color
    End Sub

    Private Sub BackgroundColorPicker_ColorSelected() Handles Color2Picker.ColorSelected
        BackgroundColorChooser.CloseDropDown()
        BackgroundColorChooser.Color = Color2Picker.Color
    End Sub

    Private Sub FontList_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles FontList.DrawItem
        If FontList.Items.Count > 0 Then
            ' Set the DrawMode property to draw fixed sized items.
            FontList.DrawMode = DrawMode.OwnerDrawFixed
            ' Draw the background of the ListBox control for each item.
            e.DrawBackground()

            ' Draw the current item text based on the current Font.
            e.Graphics.DrawString(FontList.Items(e.Index), New System.Drawing.Font(Me.FontList.Items(e.Index).ToString, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), Brushes.Black, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            ' If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle()
        End If
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click, PrintToolStripMenuItem.Click
        PreviewBrowser.ShowPrintDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click, RealTimePreviewToolStripMenuItem.Click
        If Not RealTimePreviewToolStripMenuItem.Checked Then
            RealTimePreviewToolStripMenuItem.Checked = True
            Preview()
            RealTimePreviewToolStripMenuItem.Checked = False
        Else
            Preview()
        End If
    End Sub

    Private Sub RealTimePreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealTimePreviewToolStripMenuItem.Click
        Preview()
    End Sub

    Private Sub CoverPhotoButton_Click(sender As Object, e As EventArgs) Handles CoverPhotoButton.Click
        Dim coverDialog As New CoverPhoto
        If coverDialog.ShowDialog() = DialogResult.OK Then
            If coverDialog.ListBox1.SelectedItem.ToString = "[ No cover photo ]" Then
                coverPhoto.Text = ""
            Else
                coverPhoto.Text = coverDialog.ListBox1.SelectedItem.ToString
            End If
        End If
        Preview()
    End Sub

    Private Sub AddSeperatorButton_Click(sender As Object, e As EventArgs) Handles AddSeperatorButton.Click
        code.Text = code.Text & vbNewLine & "<hr class='seperator'>" & vbNewLine
    End Sub

    Private Sub OpenInBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInBrowserToolStripMenuItem.Click
        Process.Start((My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp\index.html"))
    End Sub

    Private Sub DebugButton_Click(sender As Object, e As EventArgs) Handles DebugButton.Click
        DebugInfo.Visible = DebugButton.Checked
    End Sub

    Private Sub Ribbon1_DragLeave(sender As Object, e As EventArgs) Handles Ribbon1.DragLeave
        StatusLabel.Text = ""
    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        'OpenProject()
        Dim lunch As New Launcher
        lunch.Show()
        lunch.Step1.Hide()
        lunch.OpenPanel.Show()
        Me.Close()
    End Sub

    Public Function OpenProject(Optional name As String = Nothing)
        OpenProjectDialog.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects"
        If Not name = Nothing Then
            OpenProjectDialog.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & name
            dlg = DialogResult.OK
        Else
            dlg = OpenProjectDialog.ShowDialog()
        End If
        If dlg = DialogResult.OK Then
            Dim root = OpenProjectDialog.SelectedPath & "\ppg_data\"
            Dim project = root & "project\"
            Dim content = root & "content\"
            Dim style = root & "style\"

            If My.Computer.FileSystem.DirectoryExists(root) Then
                StatusLabel.Text = "Loading project"
                Try
                    PageTitleTextBox.TextBoxText = My.Computer.FileSystem.ReadAllText(project & "pagetitle")
                    DescriptionTextBox.TextBoxText = My.Computer.FileSystem.ReadAllText(project & "description")
                    FooterTextBox.TextBoxText = My.Computer.FileSystem.ReadAllText(project & "footer")

                    code.Text = My.Computer.FileSystem.ReadAllText(content & "html")

                    HistoryListBox.Items.Clear()

                    Dim history = ""
                    Dim line As String
                    Dim sr As New StreamReader(content & "history")

                    Do
                        line = sr.ReadLine
                        If line = "item----" Then
                            history = ""
                        ElseIf line = "----item" Then
                            HistoryListBox.Items.Add(history)
                        Else
                            history = history & line
                        End If
                    Loop Until line Is Nothing

                    loadppgp(style & "ppgp")
                    If My.Computer.FileSystem.FileExists(style & "ppgt-path") Then
                        Dim ppgtpath = My.Computer.FileSystem.ReadAllText(style & "ppgt-path")
                        If My.Computer.FileSystem.FileExists(ppgtpath) Then
                            CustomTemplateButton.Checked = True
                            CustomTemplateButton.Tag = ppgtpath
                            templateCheck(My.Computer.FileSystem.ReadAllText(ppgtpath))
                        Else
                            CustomTemplateButton.Checked = False
                            CustomTemplateButton.Tag = ""
                            templateCheck(template.Text)
                        End If
                    Else
                        CustomTemplateButton.Checked = False
                        CustomTemplateButton.Tag = ""
                    End If

                    Try
                        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp") Then
                            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If
                    Catch
                    End Try

                    My.Computer.FileSystem.CopyDirectory(OpenProjectDialog.SelectedPath, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGDXTemp", True)

                    Preview()

                    StatusLabel.Text = ""
                Catch ex As Exception
                    StatusLabel.Text = ""
                    MsgBox("Error occurred when loading project:" & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Guru Meditation")
                End Try
            Else
                MsgBox("This project doesn't contain a PhotoPage data folder. It may have either been made in a previous version of PhotoPage without saving functionality, or the folder was removed manually.")
            End If
        End If
        Return True
    End Function
End Class
