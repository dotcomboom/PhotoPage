Imports System.IO

Public Class Studio

    Public PreviewDialog As New AdvancedPreview

    Private Sub Ribbon1_OrbClicked(sender As Object, e As EventArgs) Handles Ribbon1.OrbClicked
        Ribbon1.OrbPressed = False
        OrbMenu.Show(Ribbon1, 0, 47)
    End Sub

    Private Function Preview()
        PreviewBrowser.DocumentText = (CodeEditor.Text.Replace("[#pagetitle#]", PreviewDialog.PageTitleBox.Text).Replace("[#description#]", PreviewDialog.DescriptionBox.Text).Replace("[#content#]", "<h3 class='heading'>This is a heading</h3><p>This is a paragraph.</p><h3 class='heading'>Landscape</h3><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><h3 class='heading'>Portrait</h3><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><h3 class='heading'>Mixed</h3><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a>").Replace("[#footer#]", PreviewDialog.FooterText.Text).Replace("[#fonts#]", PreviewDialog.FontStack.Text).Replace("[#color#]", PreviewDialog.TextColor.Text).Replace("[#bgcolor#]", "#" & PreviewDialog.BackgroundColor.Text).Replace("[#coverphoto#]", "http://lorempixel.com/1920/1920/city/"))
        Return True
    End Function

    Private Sub CodeEditor_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles CodeEditor.TextChanged
        If RealTimePreviewToolStripMenuItem.Checked Then
            Preview()
        End If
    End Sub

    Private Sub RadButtonElement1_Click(sender As Object, e As EventArgs) Handles PasteButton.Click, PasteToolStripMenuItem.Click
        CodeEditor.Paste()
    End Sub

    Private Sub RadButtonElement2_Click(sender As Object, e As EventArgs) Handles CutButton.Click, CutToolStripMenuItem.Click
        CodeEditor.Cut()
    End Sub

    Private Sub RadButtonElement3_Click(sender As Object, e As EventArgs) Handles CopyButton.Click, CopyToolStripMenuItem.Click
        CodeEditor.Copy()
    End Sub

    Private Sub RadButtonElement7_Click(sender As Object, e As EventArgs) Handles UndoButton.Click, UndoQAButton.Click
        CodeEditor.Undo()
    End Sub

    Private Sub RadButtonElement8_Click(sender As Object, e As EventArgs) Handles RedoButton.Click, RedoQAButton.Click
        CodeEditor.Redo()
    End Sub

    Private Sub RadButtonElement4_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        CodeEditor.ShowFindDialog()
    End Sub

    Private Sub RadButtonElement5_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
        CodeEditor.ShowReplaceDialog()
    End Sub

    Private Sub RadButtonElement6_Click(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        CodeEditor.SelectAll()
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        CodeEditor.Clear()
    End Sub

    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenTemplateDialog.ShowDialog = DialogResult.OK Then
            Try
                CodeEditor.OpenFile(OpenTemplateDialog.FileName)
                Me.Text = "PhotoPage Studio - " & OpenTemplateDialog.SafeFileName
                Ribbon1.Text = "PhotoPage Studio - " & OpenTemplateDialog.SafeFileName
            Catch ex As Exception
                MsgBox("An error occurred while trying to open the template:" & vbNewLine & vbNewLine & ex.ToString(), MsgBoxStyle.Critical, "Guru Meditation")
            End Try
        End If
    End Sub

    Private Sub RadMenuItem3_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveTemplateQAButton.Click
        If SaveTemplateDialog.ShowDialog = DialogResult.OK Then
            Try
                CodeEditor.SaveToFile(SaveTemplateDialog.FileName, System.Text.Encoding.Default)
                Me.Text = "PhotoPage Studio - " & Path.GetFileName(SaveTemplateDialog.FileName)
                Ribbon1.Text = "PhotoPage Studio - " & Path.GetFileName(SaveTemplateDialog.FileName)
            Catch ex As Exception
                MsgBox("An error occurred while trying to save the template:" & vbNewLine & vbNewLine & ex.ToString(), MsgBoxStyle.Critical, "Guru Meditation")
            End Try
        End If
    End Sub

    Private Sub RadButtonElement9_Click(sender As Object, e As EventArgs) Handles FeatureCheckButton.Click
        Dim msg = "The following features are unused in the template:" & vbNewLine
        Dim yay = True
        If Not CodeEditor.Text.Contains("[#description#]") Then
            msg = msg & vbNewLine & "- Page Title"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#description#]") Then
            msg = msg & vbNewLine & "- Page Description"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#footer#]") Then
            msg = msg & vbNewLine & "- Page Footer"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#content#]") Then
            msg = msg & vbNewLine & vbNewLine & "- Content/Photos"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#fonts#]") Then
            msg = msg & vbNewLine & vbNewLine & "- Font Faces"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#color#]") Then
            msg = msg & vbNewLine & "- Color 1"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#bgcolor#]") Then
            msg = msg & vbNewLine & "- Color 2"
            yay = False
        End If
        If Not CodeEditor.Text.Contains("[#coverphoto#]") Then
            msg = msg & vbNewLine & "- Cover Photo"
            yay = False
        End If
        If yay Then
            msg = "All available features are used in the template."
        End If
        MsgBox(msg, MsgBoxStyle.Information, "Feature Check")
    End Sub

    Private Sub RadButtonElement10_Click(sender As Object, e As EventArgs) Handles TitleFeatureButton.Click
        CodeEditor.InsertText("[#pagetitle#]")
    End Sub

    Private Sub RadButtonElement11_Click(sender As Object, e As EventArgs) Handles DescriptionFeatureButton.Click
        CodeEditor.InsertText("[#description#]")
    End Sub

    Private Sub RadButtonElement12_Click(sender As Object, e As EventArgs) Handles FooterFeatureButton.Click
        CodeEditor.InsertText("[#footer#]")
    End Sub

    Private Sub RadButtonElement13_Click(sender As Object, e As EventArgs) Handles ContentFeatureButton.Click
        CodeEditor.InsertText("[#content#]")
    End Sub

    Private Sub RadButtonElement14_Click(sender As Object, e As EventArgs) Handles FontsFeatureButton.Click
        CodeEditor.InsertText("[#fonts#]")
    End Sub

    Private Sub RadButtonElement16_Click(sender As Object, e As EventArgs) Handles TextColorFeatureButton.Click
        CodeEditor.InsertText("[#color#]")
    End Sub

    Private Sub RadButtonElement15_Click(sender As Object, e As EventArgs) Handles BackgroundColorFeatureButton.Click
        CodeEditor.InsertText("[#bgcolor#]")
    End Sub

    Private Sub Studio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = Launcher.getVersion()
        PreviewBrowser.DocumentText = (CodeEditor.Text.Replace("[#pagetitle#]", "PhotoPage Studio").Replace("[#description#]", "Template Preview").Replace("[#content#]", "<h3 class='heading'>This is a heading</h3><p>This is a paragraph.</p><h3 class='heading'>Landscape</h3><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><h3 class='heading'>Portrait</h3><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><h3 class='heading'>Mixed</h3><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a><a href='http://lorempixel.com/160/110/city/'><img src='http://lorempixel.com/160/110/city/' alt='http://lorempixel.com/160/110/city/' class='img-landscape' width=160 height=110></a><a href='http://lorempixel.com/83/110/city/'><img src='http://lorempixel.com/83/110/city/' alt='http://lorempixel.com/83/110/city/' class='img-portrait' width=83 height=110></a>").Replace("[#footer#]", "PhotoPage Studio 2017").Replace("[#fonts#]", "Arial, Verdana, sans-serif").Replace("[#color#]", "000000").Replace("[#bgcolor#]", "FFFFFF"))
    End Sub

    Private Sub LandscapeClassButton_Click(sender As Object, e As EventArgs) Handles PhotoClassButton.Click
        CodeEditor.InsertText(".photo {}")
    End Sub

    Private Sub PortraitClassButton_Click(sender As Object, e As EventArgs)
        CodeEditor.InsertText(".img-portrait {}")
    End Sub

    Private Sub HeadingClassButton_Click(sender As Object, e As EventArgs) Handles HeadingClassButton.Click
        CodeEditor.InsertText(".heading {}")
    End Sub

    Private Sub ParagraphClassButton_Click(sender As Object, e As EventArgs) Handles ParagraphClassButton.Click
        CodeEditor.InsertText(".paragraph {}")
    End Sub

    Private Sub VideoClassButton_Click(sender As Object, e As EventArgs) Handles VideoClassButton.Click
        CodeEditor.InsertText(".video {}")
    End Sub

    Private Sub AudioClassButton_Click(sender As Object, e As EventArgs) Handles AudioClassButton.Click
        CodeEditor.InsertText(".audio {}")
    End Sub

    Private Sub AboutPhotoPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPhotoPageToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub BetaCentralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BetaCentralToolStripMenuItem.Click
        Process.Start("https://rink.hockeyapp.net/apps/71b12a2053c44526b47386c53239f6d6/")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        If Not RealTimePreviewToolStripMenuItem.Checked Then
            RealTimePreviewToolStripMenuItem.Checked = True
            Preview()
            RealTimePreviewToolStripMenuItem.Checked = False
        Else
            Preview()
        End If
    End Sub

    Private Sub CoverPhotoFeatureButton_Click(sender As Object, e As EventArgs) Handles CoverPhotoFeatureButton.Click
        CodeEditor.InsertText("[#coverphoto#]")
    End Sub

    Private Sub SeperatorClassButton_Click(sender As Object, e As EventArgs) Handles SeperatorClassButton.Click
        CodeEditor.InsertText(".seperator {}")
    End Sub

    Private Sub AdvancedPreviewButton_Click(sender As Object, e As EventArgs) Handles AdvancedPreviewButton.Click
        PreviewDialog.ShowDialog()
    End Sub

    Private Sub OpenInBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInBrowserToolStripMenuItem.Click
        Preview()
        Try
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\StudioTemp\")
        Catch ex As Exception
        End Try
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\StudioTemp\index.html", PreviewBrowser.DocumentText, False)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\StudioTemp\index.html")
        System.Threading.Thread.Sleep(2500)
        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\StudioTemp\index.html")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PreviewBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles PreviewBrowser.DocumentCompleted
        If PreviewBrowser.Url.AbsoluteUri.Contains(".png") Then
            Preview()
        End If
    End Sub
End Class
