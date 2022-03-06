Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = String.Format("The Sum of {0} and {1} is {2}", TextBox1.Text, TextBox2.Text, CInt(TextBox1.Text) + CInt(TextBox2.Text))
    End Sub
End Class
