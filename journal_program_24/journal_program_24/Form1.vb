Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = TextBox1.Text
        Dim flag As Boolean
        Dim i As Integer

        For i = 2 To num - 1
            If num Mod i = 0 Then
                flag = False
            End If
        Next

        If flag = False Then
            Label2.Text = String.Format("{0} is not a prime number", num)
        Else
            Label2.Text = String.Format("{0} is a prime number", num)
        End If
    End Sub
End Class
