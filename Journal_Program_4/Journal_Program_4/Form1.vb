Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = vbNullString Then
            TextBox3.Text = "No Values!"
        Else
            TextBox3.Text = CInt(TextBox1.Text) + CInt(TextBox2.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = vbNullString Then
            TextBox3.Text = "No Values!"
        Else
            TextBox3.Text = CInt(TextBox1.Text) - CInt(TextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = vbNullString Then
            TextBox3.Text = "No Values!"
        Else
            TextBox3.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = vbNullString Then
            TextBox3.Text = "No Values!"
        Else
            TextBox3.Text = CInt(TextBox1.Text) / CInt(TextBox2.Text)
        End If
    End Sub
End Class
