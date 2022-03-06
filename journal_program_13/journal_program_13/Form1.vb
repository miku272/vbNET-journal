Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim num As Integer = InputBox("Enter a number")

        For i = 1 To num
            TextBox1.Text &= i & " "
        Next
    End Sub
End Class
