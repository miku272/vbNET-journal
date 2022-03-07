Public Class Form1

    Private Sub swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer

        temp = a
        a = b
        b = temp
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text

        swap(a, b)

        TextBox3.Text = a
        TextBox4.Text = b
    End Sub
End Class
