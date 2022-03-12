Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.View = View.Details

        ListView1.Columns.Add("Director", 40, HorizontalAlignment.Left)
        ListView1.Columns.Add("Movies", 40, HorizontalAlignment.Left)
        ListView1.Columns.Add("Reviews", 40, HorizontalAlignment.Left)

        ListView1.Items.Add("Sanjay Leela")
        ListView1.Items.Add("Yash Chopra")
        ListView1.Items.Add("Rakesh")

        ListView1.Items(0).SubItems.Add("Padmavat")
        ListView1.Items(0).SubItems.Add("Great")

        ListView1.Items(1).SubItems.Add("Lamhe")
        ListView1.Items(1).SubItems.Add("Good")

        ListView1.Items(2).SubItems.Add("Krish")
        ListView1.Items(2).SubItems.Add("Awesome")

        Dim node As New TreeNode
        node = TreeView1.Nodes.Item(1)

        MsgBox(node.Text)
    End Sub
End Class
