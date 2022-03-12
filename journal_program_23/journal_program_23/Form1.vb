Public Class Form1
    Dim no1 As Integer
    Dim op As Char
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click, Btn00.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click
        TextBox1.Text &= sender.Text
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click, BtnMin.Click, BtnMul.Click, BtnPlus.Click
        no1 = TextBox1.Text

        TextBox1.Clear()

        op = sender.Text
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        If op = "+" Then
            TextBox1.Text = no1 + Val(TextBox1.Text)
        ElseIf op = "-" Then
            TextBox1.Text = no1 - Val(TextBox1.Text)
        ElseIf op = "*" Then
            TextBox1.Text = no1 * Val(TextBox1.Text)
        ElseIf op = "/" Then
            TextBox1.Text = no1 / Val(TextBox1.Text)
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TextBox1.Clear()
    End Sub
End Class
