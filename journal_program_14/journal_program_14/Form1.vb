Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, result
        Dim str As String

        For n = 1 To 10
            str = 5 & "*" & n & "="
            result = 5 * n
            TextBox1.Text = TextBox1.Text & str & result & vbNewLine
        Next
    End Sub
End Class
