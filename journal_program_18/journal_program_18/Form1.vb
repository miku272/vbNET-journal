Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String

        name = InputBox("Enter your name", "Program 18")

        MessageBox.Show(String.Format("My name is {0}", name), "My Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
