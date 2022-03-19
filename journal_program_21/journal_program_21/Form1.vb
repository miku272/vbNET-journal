Public Class Form1
    Private Function Add(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim c As Integer = a + b

        Return c
    End Function

    Private Function Add(ByVal a As String, ByVal b As String) As String
        Dim c As String = a + b

        Return c
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(String.Format("My name is {0}", Add("Sarita ", "Yadav")))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(String.Format("The addition of 10 and 20 is {0}", Add(10, 20)))
    End Sub
End Class
