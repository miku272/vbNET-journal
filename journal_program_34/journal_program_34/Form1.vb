Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myStr As String
        Dim i As Integer

        For i = 0 To CheckedListBox1.Items.Count - 1
            myStr = CheckedListBox1.Items.Item(i)

            If myStr.StartsWith(TextBox1.Text) = True Then
                CheckedListBox1.SetItemChecked(i, True)
            Else
                CheckedListBox1.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer

        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub
End Class
