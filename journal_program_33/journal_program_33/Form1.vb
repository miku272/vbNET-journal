Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Sarita Yadav")
        ListBox1.Items.Add("Hetal Sthaliya")
        ListBox1.Items.Add("Ashutosh Umale")
        ListBox1.Items.Add("Heena Purohit")
        ListBox1.Items.Add("Urvi Gami")
        ListBox1.Items.Add("Smit Tailor")
        ListBox1.Items.Add("Jayveer Prajapati")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.SelectedItems)

        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer

        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items.Item(i))
        Next

        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer

        For i = 0 To ListBox1.SelectedItems.Count - 1
            ListBox2.Items.Add(ListBox1.SelectedItems.Item(0))
            ListBox1.Items.Remove(ListBox1.SelectedItems.Item(0))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer

        For i = 0 To ListBox2.SelectedItems.Count - 1
            ListBox1.Items.Add(ListBox2.SelectedItems.Item(0))
            ListBox2.Items.Remove(ListBox2.SelectedItems.Item(0))
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer

        For i = 0 To ListBox2.Items.Count - 1
            ListBox1.Items.Add(ListBox2.Items.Item(0))
        Next

        ListBox2.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
End Class
