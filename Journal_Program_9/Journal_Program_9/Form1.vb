Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = vbNullString Then
            Label2.Text = "Please input something!"
        Else
            If IsNumeric(TextBox1.Text) Then
                Label2.Text = "The input is numeric"
            Else
                Label2.Text = "The input is not numeric"
            End If
        End If
    End Sub
End Class
