Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        n = 20
        n += 2
        n -= 4
        n *= 3
        n /= 3
        n ^= 2

        MsgBox(String.Format("The value of  n is: {0}", n))
    End Sub
End Class