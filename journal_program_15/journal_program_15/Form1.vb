Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Answer will be displayed here!")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim fact As Integer = 1

        For i = 1 To 5
            fact = fact * i
        Next

        ListBox1.Items.Remove("Answer will be displayed here!")
        ListBox1.Items.Add(String.Format("The factorial of 5 is {0}", fact))

    End Sub
End Class
