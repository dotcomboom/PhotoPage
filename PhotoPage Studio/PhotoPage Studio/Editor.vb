Imports System.IO

Public Class Editor

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        FastColoredTextBox1.SelectAll()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub PageTitleToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PageTitleToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#pagetitle#]")
    End Sub

    Private Sub PageDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageDescriptionToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#description#]")
    End Sub

    Private Sub FooterTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FooterTextToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#footer#]")
    End Sub

    Private Sub ContentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#content#]")
    End Sub

    Private Sub FontsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontsToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#fonts#]")
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#bgcolor#]")
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        FastColoredTextBox1.InsertText("[#color#]")
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FastColoredTextBox1.Text = ""
        Me.Text = "Template Editor - Untitled"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                FastColoredTextBox1.OpenFile(OpenFileDialog1.FileName)
                Me.Text = "Template Editor - " & OpenFileDialog1.SafeFileName
            Catch ex As Exception
                MsgBox("An error occurred while trying to open the template:" & vbNewLine & vbNewLine & ex.ToString(), MsgBoxStyle.Critical, "Guru Meditation")
            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                FastColoredTextBox1.SaveToFile(SaveFileDialog1.FileName, System.Text.Encoding.Default)
                Me.Text = "Template Editor - " & Path.GetFileName(SaveFileDialog1.FileName)
            Catch ex As Exception
                MsgBox("An error occurred while trying to save the template:" & vbNewLine & vbNewLine & ex.ToString(), MsgBoxStyle.Critical, "Guru Meditation")
            End Try
        End If
    End Sub

    Private Sub TemplateCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemplateCheckToolStripMenuItem.Click
        Dim msg = "The following features are unused in the template:" & vbNewLine
        Dim yay = True
        If Not FastColoredTextBox1.Text.Contains("[#description#]") Then
            msg = msg & vbNewLine & "- Page Title"
            yay = False
        End If
        If Not FastColoredTextBox1.Text.Contains("[#description#]") Then
            msg = msg & vbNewLine & "- Page Description"
            yay = False
        End If
        If Not FastColoredTextBox1.Text.Contains("[#footer#]") Then
            msg = msg & vbNewLine & "- Page Footer"
            yay = False
        End If
        If Not FastColoredTextBox1.Text.Contains("[#content#]") Then
            msg = msg & vbNewLine & vbNewLine & "- Content/Photos"
            yay = False
        End If
        If Not FastColoredTextBox1.Text.Contains("[#fonts#]") Then
            msg = msg & vbNewLine & vbNewLine & "- Font Faces"
            yay = False
        End If
        If Not FastColoredTextBox1.Text.Contains("[#bgcolor#]") Then
            msg = msg & vbNewLine & "- Background Color"
            yay = False
        End If
        If Not FastColoredTextBox1.Text.Contains("[#color#]") Then
            msg = msg & vbNewLine & "- Font Color"
            yay = False
        End If
        If yay Then
            msg = "All available features are used in the template."
        End If
        MsgBox(msg, MsgBoxStyle.Information, "Feature Check")
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load

    End Sub
End Class