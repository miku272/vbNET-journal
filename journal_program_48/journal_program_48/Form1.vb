Public Class Form1
    Public Class EmployeeEntity
        Public eid As Integer
        Public ename As String
        Public edoj As New DateTime
    End Class
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim obj As New EmployeeEntity

        obj.eid = TxtId.Text
        obj.ename = TxtName.Text
        obj.edoj = Convert.ToDateTime(TxtDoj.Text)

        ListBox1.Items.Add(obj.eid & "---" & obj.ename & "---" & obj.edoj)
        TxtId.Clear()
        TxtName.Clear()
        TxtDoj.Clear()
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        ComboBox1.Items.Add(ListBox1.Items(0))
        ComboBox1.Items.Add(ListBox1.Items(1))
        ComboBox1.Items.Add(ListBox1.Items(2))
        ComboBox1.Items.Add(ListBox1.Items(3))
        ComboBox1.Items.Add(ListBox1.Items(4))
    End Sub
End Class


