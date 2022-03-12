Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr() As String = Split(TextBox1.Text, " ")

        TextBox2.Text = arr(0)
        TextBox3.Text = arr(1)
    End Sub
End Class
