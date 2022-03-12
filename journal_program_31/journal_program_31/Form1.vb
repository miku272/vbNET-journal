Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = Image.FromFile("D:\practicals\vb.NET projects\Journal Programs\journal_program_31\boy.jpg")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = Image.FromFile("D:\practicals\vb.NET projects\Journal Programs\journal_program_31\girl.jpg")
    End Sub
End Class
