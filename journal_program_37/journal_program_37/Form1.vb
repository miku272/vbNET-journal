Public Class Form1
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label4.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)

        NumericUpDown1.Value = HScrollBar1.Value
        NumericUpDown2.Value = HScrollBar2.Value
        NumericUpDown3.Value = HScrollBar3.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label4.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)

        NumericUpDown1.Value = HScrollBar1.Value
        NumericUpDown2.Value = HScrollBar2.Value
        NumericUpDown3.Value = HScrollBar3.Value
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Label4.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)

        NumericUpDown1.Value = HScrollBar1.Value
        NumericUpDown2.Value = HScrollBar2.Value
        NumericUpDown3.Value = HScrollBar3.Value
    End Sub
End Class
