Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ctrl As New Control
        Dim count As Integer = 0
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                count = count + 1
            End If
        Next

        MsgBox(String.Format("Total number of textboxes are: {0}", count))
    End Sub
End Class
