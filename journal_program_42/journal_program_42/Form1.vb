Public Class Form1
    Private Sub TrackBarRed_Scroll(sender As Object, e As EventArgs) Handles TrackBarRed.Scroll
        Me.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)

        TextBox1.Text = TrackBarRed.Value
        TextBox2.Text = TrackBarGreen.Value
        TextBox3.Text = TrackBarBlue.Value
    End Sub

    Private Sub TrackBarGreen_Scroll(sender As Object, e As EventArgs) Handles TrackBarGreen.Scroll
        Me.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)

        TextBox1.Text = TrackBarRed.Value
        TextBox2.Text = TrackBarGreen.Value
        TextBox3.Text = TrackBarBlue.Value
    End Sub

    Private Sub TrackBarBlue_Scroll(sender As Object, e As EventArgs) Handles TrackBarBlue.Scroll
        Me.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)

        TextBox1.Text = TrackBarRed.Value
        TextBox2.Text = TrackBarGreen.Value
        TextBox3.Text = TrackBarBlue.Value
    End Sub
End Class
