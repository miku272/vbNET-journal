Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myString1 As String = "Naresh "
        Dim myString2 As String = "Sharma "

        MsgBox("My name is " & myString1 + myString2)
    End Sub
End Class
