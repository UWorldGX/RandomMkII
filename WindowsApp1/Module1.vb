Module Module1
    Public Sub DebugCoreProgram()
        Dim datas, tmsreal As Integer, temp As String
        tmsreal = Form1.tms - 1
        Form1.memories += 1
        '随机数模式
        If Form1.dodata = False Then
CX1:
            Randomize()
            datas = Rnd() * Form1.ranges
            If datas = 0 Then GoTo CX1
            Form1.temp2 = "抽出数值:" & Str(datas)
            temp = Str(datas)
            For circle = 1 To tmsreal
CX2:
                Randomize()
                datas = Rnd() * Form1.ranges
                If datas = 0 Then GoTo CX2
                Form1.temp2 = Form1.temp2 & "/" & Str(datas)
                temp = temp & "/" & Str(datas)
            Next
            Form1.ListBox1.Items.Add(temp)
            If Form1.doextreme = True Then
                MsgBox("检测到极限模式已启动.调试失败.")
                Exit Sub
            End If
            Form1.Timer2.Enabled = True
        ElseIf form1.dodata = True Then
            '数据驱动模式1
            Dim repeat(6) As Integer, check, check2 As String, trigger As Integer
            '一次监测
            For trigger = 0 To Form1.exe + tmsreal Step 1
                check2 = Form1.ListBox2.Items.Item(trigger)
                If Form1.ListBox2.SelectedItems.Contains（check2) = False Then
                    GoTo CX7
                End If
                trigger += 1
            Next
CX10:
            MsgBox("监测到异常!" & Chr(13) & Chr(10) & "异常项:第" & Form1.memories & "项", vbCritical + vbOKOnly, "错误")
            Exit Sub
CX7:
            If Form1.exe - trigger <= tmsreal Then GoTo CX10
            Randomize()
            datas = Rnd() * Form1.exe
            If datas >= Form1.Area - 2 Then GoTo CX10
            repeat(0) = datas
            temp = Form1.ListBox2.Items.Item(datas)
            If Form1.ListBox2.SelectedItems.Contains（temp) = False Then
                Form1.temp2 = "抽取对象为:" & temp
                temp = temp
                For circle = 1 To tmsreal Step 1
CX6:
                    Randomize()
                    datas = Rnd() * Form1.exe
                    If datas = 0 Then GoTo CX6
                    check = Form1.ListBox2.Items.Item(datas)
                    If Form1.ListBox2.SelectedItems.Contains（check) = False Then
                        repeat(circle) = datas
                        Dim repeat2 As Integer
                        For repeat2 = 0 To circle - 1 Step 1
                            If repeat(repeat2) = datas Then GoTo CX6
                        Next
                    Else
                        GoTo CX6
                    End If
                    On Error GoTo CX10
                    Form1.temp2 += "/" & Form1.ListBox2.Items.Item(datas)
                    temp = temp & "/" & Form1.ListBox2.Items.Item(datas)
                Next
                On Error GoTo CX10
                Form1.ListBox1.Items.Add(temp)
            Else
                GoTo CX7
            End If
            If Form1.doextreme = True Then
                MsgBox("检测到极限模式已启动.调试失败.")
                Exit Sub
            End If
            Form1.Timer2.Enabled = True
        End If
    End Sub
    '调试核心程序
    Public Sub AutoSaveRecord()
        Form1.RadSaveFileDialog2.FileName = "抽取记录" & Date.Now
        If Form1.RadSaveFileDialog2.ShowDialog = DialogResult.OK Then
            Dim temp As Integer
            FileOpen(2, Form1.RadSaveFileDialog2.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, "抽取时间" & Date.Now)
            For temp = 1 To Form1.memories
                WriteLine(2, Form1.ListBox1.Items.Item(temp))
            Next
            WriteLine(2, "一共抽取了" & Form1.ListBox1.Items.Count - 1 & "次!")
            WriteLine(2, "使用的模式:" & Form1.ComboBox1.SelectedItem)
            FileClose(2)
        Else
            Exit Sub
        End If
    End Sub
End Module
