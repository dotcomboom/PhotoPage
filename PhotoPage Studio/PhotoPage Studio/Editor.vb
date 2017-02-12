Public Class Editor
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        FastColoredTextBox1.OpenFile("test")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub
End Class