Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LCase(Trim(TextBox1.Text)) = "sai ram" And LCase(Trim(TextBox2.Text)) = "123" Then
            MsgBox("Logged in Successfully!", MsgBoxStyle.Information, "Welcome")
        Else
            MsgBox("Access Denied!", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
