Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = vbNullString Then
            Label3.Text = "Please enter some integer value in celsius"
        Else
            Label3.Text = (CInt(TextBox1.Text) * 1.8) + 32 & " Farenheit"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = vbNullString Then
            Label7.Text = "Please enter some integer value in rupees"
            Label10.Text = "Please enter some integer value in rupees"
            Label11.Text = "Please enter some integer value in rupees"
        Else
            Label7.Text = (CInt(TextBox2.Text) * 0.0133) & " Dollar"
            Label10.Text = (CInt(TextBox2.Text) * 0.0099) & " Pound"
            Label11.Text = (CInt(TextBox2.Text) * 0.0119) & " Euro"
        End If
    End Sub
End Class
