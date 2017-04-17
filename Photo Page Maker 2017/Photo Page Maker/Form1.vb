Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            For Each file As [String] In OpenFileDialog1.FileNames
                Try
                    If PortraitSelector.BackColor = Color.FromArgb(192, 192, 255) Then
                        code.Text = code.Text & imgtemplateP.Text.Replace("[#img#]", Path.GetFileName(file)) & vbNewLine
                        My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\" & Path.GetFileName(file), True)
                        ListBox1.Items.Add(Path.GetFileName(file) & " [P]")
                        PictureBox1.Load(file)
                        PictureBox1.Show()
                    Else
                        code.Text = code.Text & imgtemplateL.Text.Replace("[#img#]", Path.GetFileName(file)) & vbNewLine
                        My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\" & Path.GetFileName(file), True)
                        ListBox1.Items.Add(Path.GetFileName(file) & " [L]")
                        PictureBox1.Load(file)
                        PictureBox1.Show()
                    End If
                Catch
                    MsgBox("Failed to open file.", MsgBoxStyle.Critical, "Guru Meditation")
                End Try
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        code.Text = ""
        ListBox1.Items.Clear()
        PictureBox1.ImageLocation = "clicktoadd.png"
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp") Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp") Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp")
            Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp")
            If (di.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                di.Attributes = di.Attributes Or FileAttributes.Hidden
            End If
        End If
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp") Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "Untitled"
            Me.Text = "PhotoPage - Untitled"
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp")
            Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp")
            If (di.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                di.Attributes = di.Attributes Or FileAttributes.Hidden
            End If
        End If
        If CheckBox1.Checked = False Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\index.html", template.Text.Replace("[#pagetitle#]", TextBox1.Text).Replace("[#description#]", TextBox2.Text).Replace("[#content#]", code.Text).Replace("[#footer#]", footertext.Text).Replace("[#fonts#]", ComboBox1.Text).Replace("[#color#]", TextBox5.Text).Replace("[#bgcolor#]", TextBox4.Text), False)
        Else
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\index.html", My.Computer.FileSystem.ReadAllText(TextBox6.Text).Replace("[#pagetitle#]", TextBox1.Text).Replace("[#description#]", TextBox2.Text).Replace("[#content#]", code.Text).Replace("[#footer#]", footertext.Text).Replace("[#fonts#]", ComboBox1.Text).Replace("[#color#]", TextBox5.Text).Replace("[#bgcolor#]", TextBox4.Text), False)
        End If
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & TextBox1.Text) Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & TextBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        Dim foldername As String = TextBox1.Text
        If TextBox1.Text = "" Then
            foldername = "Untitled"

        Else
            Dim invalid As String = New String(Path.GetInvalidFileNameChars()) & New String(Path.GetInvalidPathChars())
            For Each c As Char In invalid
                foldername = foldername.Replace(c.ToString(), "-")
            Next
        End If
        My.Computer.FileSystem.CopyDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & foldername & "\")
        MsgBox("Successfully created photo page!", MsgBoxStyle.Information, "Success")
        Process.Start((My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage Projects\" & foldername & "\"))
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\index.html", template.Text.Replace("[#pagetitle#]", TextBox1.Text).Replace("[#description#]", TextBox2.Text).Replace("[#content#]", code.Text).Replace("[#footer#]", footertext.Text).Replace("[#fonts#]", ComboBox1.Text).Replace("[#color#]", TextBox5.Text).Replace("[#bgcolor#]", TextBox4.Text), False)
        Else
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\index.html", My.Computer.FileSystem.ReadAllText(TextBox6.Text).Replace("[#pagetitle#]", TextBox1.Text).Replace("[#description#]", TextBox2.Text).Replace("[#content#]", code.Text).Replace("[#footer#]", footertext.Text).Replace("[#fonts#]", ComboBox1.Text).Replace("[#color#]", TextBox5.Text).Replace("[#bgcolor#]", TextBox4.Text), False)
        End If
        WebBrowser1.Navigate(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\index.html")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 0 Then
            Me.Text = "PhotoPage - " & TextBox1.Text
        Else
            Me.Text = "PhotoPage - Untitled"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.ReadOnly = False
            Button4.Enabled = True
            Try
                checkif(TextBox1, "[#pagetitle#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(TextBox2, "[#description#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(footertext, "[#footer#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(ComboBox1, "[#fonts#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(TextBox4, "[#bgcolor#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(Button7, "[#bgcolor#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(TextBox5, "[#color#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
                checkif(Button6, "[#color#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text))
            Catch ex As Exception
            End Try
        Else
            TextBox6.ReadOnly = True
            Button4.Enabled = False
            Try
                checkif(TextBox1, "[#pagetitle#]", template.Text)
                checkif(TextBox2, "[#description#]", template.Text)
                checkif(footertext, "[#footer#]", template.Text)
                checkif(ComboBox1, "[#fonts#]", template.Text)
                checkif(TextBox4, "[#bgcolor#]", template.Text)
                checkif(Button7, "[#bgcolor#]", template.Text)
                checkif(TextBox5, "[#color#]", template.Text)
                checkif(Button6, "[#color#]", template.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox6.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub PreviewCustomization(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, TextBox4.TextChanged, TextBox5.TextChanged, ComboBox1.TextChanged
        WebBrowser2.Navigate("about:<html><head><style>html{font-family:[#fonts#];color:[#color#];background-color:[#bgcolor#];}</style></head><body>The quick brown fox jumps over the lazy dog.</body></html>".Replace("[#fonts#]", ComboBox1.Text).Replace("[#color#]", TextBox5.Text).Replace("[#bgcolor#]", TextBox4.Text))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ColorDialog1.Color = ColorTranslator.FromHtml("#" & TextBox4.Text)
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox4.Text = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(ColorDialog1.Color.ToArgb())).Replace("#", "")
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ColorDialog1.Color = ColorTranslator.FromHtml("#" & TextBox5.Text)
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox5.Text = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(ColorDialog1.Color.ToArgb())).Replace("#", "")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim input As String
        input = InputBox("Please enter some text for the heading:", "Add Heading")
        If input <> "" Then
            code.Text = code.Text & "<h3 class='heading'>" & input & "</h3>" & vbNewLine
            ListBox1.Items.Add("(H) " & input)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim input As String
        input = InputBox("Please enter some text for the paragraph:", "Add Paragraph")
        If input <> "" Then
            code.Text = code.Text & "<p class='paragraph'>" & input & "</p>" & vbNewLine
            ListBox1.Items.Add("(P) " & input)
        End If
    End Sub

    Private Function checkif(control As Control, tag As String, template As String)
        If template.Contains(tag) Then
            control.Enabled = True
            Return True
        Else
            control.Enabled = False
            Return False
        End If
    End Function

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Try
            Dim msg = "The following features are unused in the template and have been disabled:" & vbNewLine
            Dim yay = True
            'If Not checkif(TextBox1, "[#pagetitle#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
            'End If
            If Not checkif(TextBox2, "[#description#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
                msg = msg & vbNewLine & "- Page Description"
                yay = False
            End If
            If Not checkif(footertext, "[#footer#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
                msg = msg & vbNewLine & "- Page Footer"
                yay = False
            End If
            If Not checkif(ComboBox1, "[#fonts#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
                msg = msg & vbNewLine & "- Font Faces"
                yay = False
            End If
            If Not checkif(TextBox4, "[#bgcolor#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
                msg = msg & vbNewLine & "- Background Color"
                yay = False
            End If
            If Not checkif(Button7, "[#bgcolor#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
            End If
            If Not checkif(TextBox5, "[#color#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
                msg = msg & vbNewLine & "- Font Color"
                yay = False
            End If
            If Not checkif(Button6, "[#color#]", My.Computer.FileSystem.ReadAllText(TextBox6.Text)) Then
            End If
            If Not yay Then
                MsgBox(msg, MsgBoxStyle.Information, "Custom Template Feature Check")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TabPage1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabPage1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each file In files
            If PortraitSelector.BackColor = Color.FromArgb(192, 192, 255) Then
                code.Text = code.Text & imgtemplateP.Text.Replace("[#img#]", Path.GetFileName(file)) & vbNewLine
                Try
                    My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\" & Path.GetFileName(file))
                Catch
                End Try
                ListBox1.Items.Add(Path.GetFileName(file) & " [P]")
                PictureBox1.Load(file)
                PictureBox1.Show()
            Else
                code.Text = code.Text & imgtemplateL.Text.Replace("[#img#]", Path.GetFileName(file)) & vbNewLine
                Try
                    My.Computer.FileSystem.CopyFile(file, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PPGTemp\" & Path.GetFileName(file))
                Catch
                End Try
                ListBox1.Items.Add(Path.GetFileName(file) & " [L]")
                PictureBox1.Load(file)
                PictureBox1.Show()
            End If
        Next
    End Sub

    Private Sub TabPage1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabPage1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim SW As New StreamWriter(SaveFileDialog1.FileName)
                SW.WriteLine("[1] " & ComboBox1.Text)
                SW.WriteLine("[2] " & TextBox4.Text)
                SW.WriteLine("[3] " & TextBox5.Text)
                SW.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog3.ShowDialog = DialogResult.OK Then
            Try
                Dim strFileName() As String
                strFileName = IO.File.ReadAllLines(OpenFileDialog3.FileName)
                For Each Line In strFileName '// loop thru Arrays.
                    If Line.StartsWith("[1] ") Then
                        ComboBox1.Text = Line.Replace("[1] ", "")
                    End If
                    If Line.StartsWith("[2] ") Then
                        TextBox4.Text = Line.Replace("[2] ", "")
                    End If
                    If Line.StartsWith("[3] ") Then
                        TextBox5.Text = Line.Replace("[3] ", "")
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles LandscapeSelector.Click
        LandscapeSelector.BackColor = Color.FromArgb(192, 192, 255)
        PortraitSelector.BackColor = Color.White
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PortraitSelector.Click
        PortraitSelector.BackColor = Color.FromArgb(192, 192, 255)
        LandscapeSelector.BackColor = Color.White
    End Sub
End Class
