Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Contains(TextBox1.Text) Then
            ListBox1.Items.Remove(TextBox1.Text)
        Else
            MsgBox("Item not found in the list")
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Insert(TextBox2.Text, TextBox3.Text)

        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
