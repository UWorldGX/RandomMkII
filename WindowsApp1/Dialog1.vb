Public Class Dialog1
    Dim co(10) As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.Clear()
        Dim cir As Int16
        For cir = 0 To Form1.ComboBox1.Items.Count - 1
            If MsgBox("是否删除" & Form1.mdname(cir) & "项?", vbOKCancel, "提示") = MsgBoxResult.Ok Then
                Form1.ComboBox1.Items.RemoveAt(cir)
            End If
        Next
        For cir = 0 To Form1.ComboBox1.Items.Count - 1
            Form1.ComboBox1.SelectedIndex = cir
            Form1.mdname(cir) = Form1.ComboBox1.SelectedItem

        Next
    End Sub
End Class
