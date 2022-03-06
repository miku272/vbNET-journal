Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = TextBox1.Text

        If num Mod 2 = 0 Then
            Label2.Text = String.Format("{0} is an even number", num)
        Else
            Label2.Text = String.Format("{0} is an odd number", num)
        End If
    End Sub
End Class
