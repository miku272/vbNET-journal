Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str1, str2 As String
        str1 = "Naresh "
        str2 = "Sharma "

        'Length
        MsgBox(str1.Length())

        'Concat
        str1 = String.Concat(str1, str2)
        MsgBox(str1)

        'Copy
        str2 = String.Copy(str1)
        MsgBox(str2)

        'Equals
        MsgBox(String.Equals("NARESH", "Naresh"))

        'Trim
        str1 = str1.Trim(" ")
        MsgBox(str1)

        'EndsWith
        If str1.EndsWith("a") Then
            MsgBox("Correct!")
        Else
            MsgBox("Wrong!")
        End If

        'IndexOf
        Dim no As Integer = str1.IndexOf("N")
        MsgBox(String.Format("N is a {0}th place", no))

        'Substring
        MsgBox(str1.Substring(5))
    End Sub
End Class
