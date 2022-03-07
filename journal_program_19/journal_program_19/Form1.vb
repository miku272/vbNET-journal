Public Class Form1

    Private Function add(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim c As Integer

        c = a + b

        Return c
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = add(22, 32)

        MsgBox(String.Format("The addition of 22 and 32 is {0}", result))
    End Sub
End Class
