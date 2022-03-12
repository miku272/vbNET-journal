Public Class Form1
    Dim i As Integer = 0
    Dim colour(9) As Color

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colour(0) = Color.DarkBlue
        colour(1) = Color.Gray
        colour(2) = Color.Khaki
        colour(3) = Color.OliveDrab
        colour(4) = Color.Violet
        colour(5) = Color.Chocolate
        colour(6) = Color.WhiteSmoke
        colour(7) = Color.Magenta
        colour(8) = Color.Bisque
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.BackColor = colour(i)
        Label1.ForeColor = colour(i + 1)

        i += 1

        If i = 8 Then
            i = 0
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Left = False Then
            Label1.Left = Label1.Left + 50

            If Label1.Left >= 700 Then
                Left = True
            End If
        ElseIf Left = True Then
            Label1.Left = Label1.Left - 50

            If Label1.Left <= 10 Then
                Left = False
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub
End Class
