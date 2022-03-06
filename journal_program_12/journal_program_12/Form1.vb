Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DateTime = DateTimePicker1.Value

        Label2.Text = dt
    End Sub
End Class
