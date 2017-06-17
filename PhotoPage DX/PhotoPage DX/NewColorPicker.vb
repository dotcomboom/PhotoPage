Public Class NewColorPicker
    Private Sub MakeColor(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged, TrackBar2.ValueChanged, TrackBar3.ValueChanged
        Me.BackColor = Color.FromArgb(1, TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.Color = Color.FromArgb(1, TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            TrackBar1.Value = ColorDialog1.Color.R
            TrackBar2.Value = ColorDialog1.Color.G
            TrackBar3.Value = ColorDialog1.Color.B
        End If
    End Sub
End Class
