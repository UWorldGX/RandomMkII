Public Class DebugForm
    Private Sub DebugOutput_Click(sender As Object, e As EventArgs) Handles DebugOutput.Click
        Const frontline As String = "=====The Crash Log Of RM MKIV====="
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            SaveFileDialog1.Title = "导出配置..."
            SaveFileDialog1.Filter = "抽号发生器配置文件|*.ini"
            Dim et(15) As String, temp2, ex(3) As Integer
            Static temp As Integer
            Dim temp3 As Boolean
            temp = Form1.ComboBox1.Items.Count
            SaveFileDialog1.CreatePrompt = False
            FileOpen(2, SaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, frontline)
            WriteLine(2, "MaximaArea=" & Form1.Area)
            WriteLine(2, "Speakers=" & Form1.Timer2.Interval)
            WriteLine(2, "totalmode=" & Form1.tomode)
            For temp2 = 0 To temp - 1
                Form1.ComboBox1.SelectedIndex = temp2
                temp3 = Form1.dodata
                WriteLine(2, "=====Mode" & temp2 + 1 & “=====”)
                WriteLine(2, "ModeName:" & Form1.ComboBox1.SelectedItem)
                WriteLine(2, "RealModeName:" & Form1.mdname(temp2))
                WriteLine(2, "Extract Times:" & Form1.tms)
                WriteLine(2, " Real Extract Times1:" & Form1.NumericUpDown1.Value)
                WriteLine(2, " Real Extract Times2:" & Form1.extime(temp2))
                If Form1.dodata = True Then
                    ex(2) = Form1.exe
                Else
                    ex(2) = Form1.ranges
                End If
                WriteLine(2, "Real Extract Ranges:" & ex(2))
                WriteLine(2, "Extract Ranges1:" & Form1.pool.Value)
                WriteLine(2, "Extract Ranges2:" & Form1.exrange(temp2))
                WriteLine(2, "ModeType:" & temp3)
                WriteLine(2, "RealDoExtremeMode" & Form1.doextreme)
                WriteLine(2, "DoExtremeMode1" & Form1.doex(temp2))
                WriteLine(2, "DoExtremeMode2" & Form1.CheckBox2.Checked)
            Next
            WriteLine(2, "Donew=" & Form1.donew)
            WriteLine(2, "ulcheck=" & Form1.ulcheck)
            WriteLine(2, "lock=" & Form1.lock)
            WriteLine(2, "makesure=" & Form1.makesure)
            WriteLine(2, "HaveExtractTimes=" & Form1.memories)
            WriteLine(2, "CreateTime:" & Date.Now)
            WriteLine(2, "使用的模式:")
            WriteLine(2, Form1.ComboBox1.SelectedIndex)
            FileClose(2)
        Else
            Exit Sub
        End If
        MsgBox("保存成功", vbInformation + vbOKOnly, "祝贺")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.makesure = 1
        Dim cir As Int16
        For cir = 1 To 10000
            Call DebugCoreProgram()
        Next
        MsgBox("调试完成.", vbOKOnly)
        Call AutoSaveRecord()

    End Sub
End Class