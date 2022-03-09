Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox(String.Format("Name: {0}. Gender: Male", TextBox1.Text))
        Else
            MsgBox(String.Format("Name: {0}. Gender: Female", TextBox1.Text))
        End If
    End Sub
End Class
