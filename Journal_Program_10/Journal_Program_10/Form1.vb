Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = vbNullString Then
            Label2.Text = "Please Enter your age first"
        Else
            If CInt(TextBox1.Text) <= 0 Then
                Label2.Text = "Please Enter proper age"
            ElseIf CInt(TextBox1.Text) <= 5 Then
                Label2.Text = "You are still a kid"
            ElseIf CInt(TextBox1.Text) <= 7 Then
                Label2.Text = "You are in Jr. Kg or Sr. Kg"
            ElseIf CInt(TextBox1.Text) <= 13 Then
                Label2.Text = "You are in primary section"
            ElseIf CInt(TextBox1.Text) <= 15 Then
                Label2.Text = "You are in higher section"
            ElseIf CInt(TextBox1.Text) <= 17 Then
                Label2.Text = "You are in higher secondary section"
            ElseIf CInt(TextBox1.Text) > 18 Then
                Label2.Text = "You are in college and adult"
            End If
        End If
    End Sub
End Class
