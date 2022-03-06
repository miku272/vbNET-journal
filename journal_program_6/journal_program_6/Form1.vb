Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = 20

        If n = 20 Then
            MsgBox(String.Format("The number is {0}", n))
        Else
            MsgBox(String.Format("The number is not {0}", n))
        End If
    End Sub
End Class
