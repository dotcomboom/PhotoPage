Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage")
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\PhotoPage")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("http://cooltile.neocities.org/sites/ppm/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://cooltile.gitbooks.io/photo-page-maker-2017/content/")
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Label3.Text = "Create"
        Label2.Text = "Open the project creator."
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        Label3.Text = "My Projects"
        Label2.Text = "Open the My Projects folder."
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        Label3.Text = "PhotoPage Website"
        Label2.Text = "Go to the PhotoPage website for product updates, custom templates and more."
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        Label3.Text = "Knowledge Base"
        Label2.Text = "Go to the PhotoPage knowledge base to get information on the product and all it's features."
    End Sub

    Private Sub Menu_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Label3.Text = ""
        Label2.Text = ""
    End Sub
    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        Label3.Text = "Beta Central"
        Label2.Text = "Download new versions and send feedback."
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start("https://rink.hockeyapp.net/apps/71b12a2053c44526b47386c53239f6d6/")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        Dim fb As New Feedback
        fb.Show()
    End Sub
End Class