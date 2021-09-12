Public Class Form1
    Public circle, tms, ranges, memories, mode2 As Integer, temp As String, exe, makesure As Integer
    Public mode As Integer
    Public Area As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim memo As String = ComboBox1.SelectedItem
        Select Case ComboBox1.SelectedItem
            Case Is = "英语/语文模式(正常)"
                mode = 1
                NumericUpDown1.Value = 1
                tms = 1
                ranges = 16
                memories = 0
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                Label1.Text = "随机数模式已就绪.等待抽号."
                ListBox1.Items.Clear()
                Button1.Enabled = True
                Label1.ForeColor = Color.Black
                ListBox1.Items.Add("随机数模式就绪.")
                ListBox1.ForeColor = Color.Blue
                ToolStripLabel4.Enabled = False
                Label6.Text = Str(ranges)
                Label7.Text = Str(NumericUpDown1.Value)
                ComboBox1.ForeColor = Color.Blue
                ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.SelectedItem
            Case Is = "英语/语文模式(极限)"
                mode = 2
                NumericUpDown1.Value = 1
                tms = 1
                ranges = 16
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                memories = 0
                Label1.ForeColor = Color.Black
                Label1.Text = "随机数模式已就绪.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("极限模式就绪.")
                ListBox1.ForeColor = Color.Red
                ToolStripLabel4.Enabled = False
                Label6.Text = Str(ranges)
                Label7.Text = Str(NumericUpDown1.Value)
                ComboBox1.ForeColor = Color.Red
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.SelectedItem
            Case Is = "数据驱动模式Normal"
                mode = 5
                NumericUpDown1.Value = 1
                tms = 1
                ranges = 16
                exe = Area
                memories = 0
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                Button1.Enabled = True
                Label1.ForeColor = Color.Black
                Label1.Text = "数据驱动模式已就绪.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("模式Normal就绪.")
                ListBox1.ForeColor = Color.Purple
                ToolStripLabel4.Enabled = True
                Label6.Text = Str(exe)
                Label7.Text = Str(NumericUpDown1.Value)
                ComboBox1.ForeColor = Color.Purple
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.SelectedItem
            Case Is = "数据驱动模式Premium"
                mode = 6
                NumericUpDown1.Value = 1
                tms = 1
                ranges = 16
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                Button1.Enabled = True
                exe = 36
                memories = 0
                Label1.ForeColor = Color.Black
                Label1.Text = "数据驱动模式已就绪.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("模式Premium就绪.")
                ListBox1.ForeColor = Color.Violet
                ToolStripLabel4.Enabled = True
                Label6.Text = Str(exe)
                Label7.Text = Str(NumericUpDown1.Value)
                ComboBox1.ForeColor = Color.Violet
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.SelectedItem
            Case Is = "关于模式的说明..."
                'Form4.Show()
                'ComboBox1.Text = memo
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FontDialog1.Font = Label1.Font
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Label1.Font = FontDialog1.Font
            Label1.ForeColor = FontDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        ColorDialog1.Color = Label1.ForeColor
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Label1.ForeColor = ColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub
    Private Sub 更新记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新记录ToolStripMenuItem.Click
        Form3.Show()
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Const frontline As String = "The configuration of RM MKII"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            SaveFileDialog1.Title = "保存配置..."
            SaveFileDialog1.Filter = "抽号发生器配置文件|*.txt"
            Dim et(15) As String, mymodename As String, temp2, ex(3) As Integer
            Static temp As Integer
            ComboBox1.SelectedItem = "关于模式的说明..."
            temp = ComboBox1.SelectedIndex
            mymodename = InputBox("该配置叫什么?", "保存确认")
            SaveFileDialog1.CreatePrompt = False
            FileOpen(2, SaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, frontline)
            WriteLine(2, "TypeName:")
            WriteLine(2, mymodename)
            WriteLine(2, "MaximaArea")
            WriteLine(2, Area)
            WriteLine(2, "totalmode")
            WriteLine(2, temp)
            MsgBox("保存成功", vbInformation + vbOKOnly, "祝贺")
            For temp2 = 0 To temp - 1
                ComboBox1.SelectedIndex = temp2
                WriteLine(2, "Mode" & temp2 + 1)
                WriteLine(2, "ModeName:")
                WriteLine(2, ComboBox1.SelectedItem)
                ex(0) = Str(NumericUpDown1.Value)
                Select Case mode
                    Case Is <= 4
                        ex(2) = ranges
                        et(3) = "Number"
                    Case Else
                        ex(2) = exe
                        et(3) = "Data"
                End Select
                WriteLine(2, "Extract Times:")
                WriteLine(2, ex(0))
                WriteLine(2, "Extract Ranges:")
                WriteLine(2, ex(2))
                WriteLine(2, "ModeType:")
                WriteLine(2, et(3))
            Next
            FileClose(2)
        Else
            Exit Sub
        End If
        'If mode = 4 Or 7 Then
        '    If SaveFileDialog1.ShowDialog = DialogResult.OK Then
        '        et(0) = "extract times:"
        '        et(5) = Str(NumericUpDown1.Value)
        '        If mode <= 4 Then
        '            et(1) = "extract ranges:"
        '            et(2) = Str(ranges)
        '        Else
        '            et(1) = "extract ranges:"
        '            et(2) = Str(exe)
        '        End If
        '        Select Case mode
        '            Case Is <= 4
        '                et(3) = "Type:"
        '                et(4) = "Random"
        '            Case Is >= 5
        '                et(3) = "Type:"
        '                et(4) = "Data"
        '        End Select
        '        SaveFileDialog1.CreatePrompt = False
        '        FileOpen(2, SaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
        '        WriteLine(2, frontline)
        '        WriteLine(2, et(0))
        '        PrintLine(2, et(5))
        '        WriteLine(2, et(1))
        '        PrintLine(2, et(2))
        '        WriteLine(2, et(3))
        '        WriteLine(2, et(4))
        '        FileClose(2)
        '        MsgBox("保存成功", vbInformation + vbOKOnly, "祝贺")
        '    Else
        '        Exit Sub
        '    End If
        'Else
        '    MsgBox("你现在使用的是内置模式,无需保存配置", vbOKOnly, "提示")
        '    Exit Sub
        'End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If mode <= 4 Then
            ComboBox1.Text = "自定义模式"
            RadioButton4.Checked = True
            RadioButton5.Checked = False
            Label6.Text = Str(ranges)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        Else
            ComboBox1.Text = "数据驱动模式Personaize"
            RadioButton4.Checked = False
            RadioButton5.Checked = True
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        End If
    End Sub
    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        If mode >= 5 Then
            mode = 4
            ComboBox1.Text = "自定义模式"
            RadioButton5.Checked = True
            RadioButton4.Checked = False
            ToolStripLabel4.Enabled = False
            ListBox2.Enabled = False
            Label6.Text = Str(ranges)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        Else
            Exit Sub
        End If
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        If mode <= 4 Then
            mode = 5
            ComboBox1.Text = "数据驱动模式Personaize"
            RadioButton5.Checked = True
            RadioButton4.Checked = False
            ToolStripLabel4.Enabled = True
            ListBox2.Enabled = True
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.Color = Label1.ForeColor
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Label1.ForeColor = ColorDialog1.Color
            Label9.ForeColor = ColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FontDialog1.Font = Label1.Font
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Label1.Font = FontDialog1.Font
            Label1.ForeColor = FontDialog1.Color
            Label9.Font = FontDialog1.Font
            Label9.ForeColor = FontDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If mode <= 4 Then
EROR:
            ranges = Val(InputBox("请输入抽号范围(警告:点击取消键将导致bug)", "范围设置"))
            If ranges = 0 Or ranges > 100 Then
                MsgBox("范围不能为0或大于100的数!", vbOKOnly, "提示")
                GoTo EROR
            End If
            mode = 4
            Label6.Text = Str(ranges)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.Text = "自定义模式"
            ComboBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        Else
EROR2:
            exe = Val(InputBox("请输入抽号范围(警告:点击取消键将导致bug)", "范围设置"))
            If exe = 0 Or exe > 68 Then
                MsgBox("范围不能为0或大于班级人数的数!", vbOKOnly, "提示")
                GoTo EROR2
            End If
            mode = 7
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.Text = "数据驱动模式Personaize"
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case Is = "空间邮件(DP)"
                Me.BackgroundImage = RandomMaker.My.Resources.空间邮件
                'For Each combobox In Me.Controls.
                '    combobox.forecolor = Color.Black
                'Next
            Case Is = "彩嵌邮件(DP)"
                Me.BackgroundImage = RandomMaker.My.Resources.彩嵌邮件
            Case Is = "初次邮件(BW)"
                Me.BackgroundImage = RandomMaker.My.Resources.初次邮件
            Case Is = "桥梁邮件W(BW)"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｗ
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'OpenFileDialog1.Title = "载入配置..."
        'OpenFileDialog1.Filter = "抽号发生器配置文件|*.txt"
        'OpenFileDialog1.ShowReadOnly = True
        'Dim et(6) As String, num(3) As Integer
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    FileOpen(2, OpenFileDialog1.FileName, OpenMode.Input, OpenAccess.Read)
        '    EOF(2)
        '    et(0) = LineInput(2)
        '    et(1) = LineInput(2)
        '    num(0) = LineInput(2)
        '    et(3) = LineInput(2)
        '    num(1) = LineInput(2)
        '    et(5) = LineInput(2)
        '    et(6) = LineInput(2)
        '    If et(6) = """Random""" Then
        '        ranges = num(1)
        '        mode = 4
        '        ComboBox1.Text = "自定义模式"
        '        Label6.Text = Str(ranges)
        '        ComboBox1.ForeColor = Color.Black
        '        ListBox1.ForeColor = Color.Black
        '        ListBox1.Items.Clear()
        '        ListBox1.Items.Add("载入成功.自定义模式就绪.")
        '        ToolStripLabel4.Enabled = False
        '        ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        '    ElseIf et(6) = """Data""" Then
        '        exe = num(1)
        '        mode = 7
        '        ComboBox1.Text = "数据驱动模式Personaize"
        '        Label6.Text = Str(exe)
        '        ComboBox1.ForeColor = Color.Chocolate
        '        ListBox1.ForeColor = Color.Chocolate
        '        ListBox1.Items.Clear()
        '        ListBox1.Items.Add("载入成功.数据驱动模式就绪.")
        '        ToolStripLabel4.Enabled = True
        '        ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        '    End If
        '    EOF(2)
        '    FileClose(2)
        '    tms = num(0)
        '    NumericUpDown1.Value = tms
        '    Label7.Text = Str(NumericUpDown1.Value)
        '    MsgBox("载入成功!" & Chr(13) & Chr(10) & "载入的范围:" & Str(num(1)) & Chr(13) & Chr(10) & "载入的次数:" & Str(num(0)) & Chr(13) & Chr(10) & "载入的模式:" & et(6), vbInformation + vbOKOnly, "祝贺")
        'Else
        '    Exit Sub
        'End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim temp As Integer
            SaveFileDialog1.Title = "保存记录..."
            SaveFileDialog1.Filter = "抽号发生器配置文件|*.txt"
            SaveFileDialog1.CreatePrompt = True
            FileOpen(2, SaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, Date.UtcNow)
            For temp = 1 To memories
                WriteLine(2, ListBox1.Items.Item(temp))
            Next
            WriteLine(2, "抽取次数" & NumericUpDown1.Value)
            FileClose(2)
            MsgBox("保存成功", vbOKOnly, "祝贺")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            makesure = 1
        Else
            makesure = 0
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        If mode <= 4 Then
EROR:
            ranges = Val(InputBox("请输入抽号范围(警告:点击取消键将导致bug)", "范围设置"))
            If ranges = 0 Or ranges > 100 Then
                MsgBox("范围不能为0或大于100的数!", vbOKOnly, "提示")
                GoTo EROR
            End If
            mode = 4
            ComboBox1.Text = "自定义模式"
            ComboBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        Else
EROR2:
            exe = Val(InputBox("请输入抽号范围(警告:点击取消键将导致bug)", "范围设置"))
            If exe = 0 Or exe >= 68 Then
                MsgBox("范围不能为0或大于班级人数的数!", vbOKOnly, "提示")
                GoTo EROR2
            End If
            mode = 7
            ComboBox1.Text = "数据驱动模式Personaize"
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
        End If
    End Sub
    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Date.Now
    End Sub
    Private Sub 一键初始化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 一键初始化ToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.MELOETTA
        Select Case mode
            Case Is = 2
                ToolStripLabel4.Enabled = False
                Label6.Text = Str(ranges)
                Label7.Text = Str(NumericUpDown1.Value)
                Label1.Text = "该模式禁止初始化.请切换模式."
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            Case Is <= 1
                circle = 1
                tms = 0
                memories = 0
                ranges = 16
                mode2 = 0
                Label6.Text = Str(ranges)
                Label7.Text = Str(tms)
                NumericUpDown1.Value = 1
                Button1.Enabled = True
                Label1.ForeColor = Color.Black
                ToolStripLabel4.Enabled = False
                ComboBox1.Text = "默认模式"
                ListBox1.ForeColor = Color.Black
                Label6.Text = Str(ranges)
                Label7.Text = Str(NumericUpDown1.Value)
                Label1.Text = "初始化完毕.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("模式一就绪")
                ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
            Case Is = 5
SX2:
                mode = 5
                circle = 1
                tms = 0
                memories = 0
                ranges = 16
                mode2 = 0
                exe = Area
                NumericUpDown1.Value = 1
                memories = 0
                Button1.Enabled = True
                Label1.ForeColor = Color.Black
                ToolStripLabel4.Enabled = True
                Label1.Text = "初始化完毕.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("模式Normal就绪.")
                Label6.Text = Str(exe)
                Label7.Text = Str(NumericUpDown1.Value)
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                ListBox1.ForeColor = Color.Purple
                ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
            Case Is = 6
                circle = 1
                tms = 0
                memories = 0
                mode2 = 0
                mode = 6
                NumericUpDown1.Value = 1
                ranges = 16
                exe = 36
                memories = 0
                Button1.Enabled = True
                Label1.ForeColor = Color.Black
                ToolStripLabel4.Enabled = True
                Label1.Text = "初始化完毕.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("模式Premium就绪.")
                ListBox1.ForeColor = Color.Violet
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                Label6.Text = Str(exe)
                Label7.Text = Str(NumericUpDown1.Value)
                ToolStripStatusLabel3.Text = "当前模式" & ComboBox1.Text
            Case Is >= 7
                GoTo SX2
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datas As Integer
        tms = NumericUpDown1.Value - 1
        memories = 1 + memories
        ProgressBar1.Value = 10
        If makesure = 0 Then
CX8:
            If mode = 2 Then
                MsgBox("都准备好了吗?" & Chr(13) & Chr(10) & "抽取模式:" & ComboBox1.Text & Chr(13) & Chr(10) & "抽取次数:" & Str(NumericUpDown1.Value) & Chr(13) & Chr(10) & "警告!抽取后将无法重复,确定吗?", vbOKCancel + vbCritical, "确认对话框")
            Else
                MsgBox("都准备好了吗?" & Chr(13) & Chr(10) & "抽取模式:" & ComboBox1.Text & Chr(13) & Chr(10) & "抽取次数:" & Str(NumericUpDown1.Value), vbOKCancel + vbQuestion, "确认对话框")
            End If
        End If
        '随机数模式
        If mode <= 4 Then
CX1:
            Randomize()
            datas = Rnd() * ranges
            If datas = 0 Then GoTo CX1
            Label1.Text = "抽出数值:" & Str(datas)
            temp = "第" & Str(memories) & "次:" & Str(datas)
            ProgressBar1.Value = 50
            For circle = 1 To tms Step 1
CX2:
                Randomize()
                datas = Rnd() * ranges
                If datas = 0 Then GoTo CX2
                Label1.Text = Label1.Text & "/" & Str(datas)
                temp = temp & "/" & Str(datas)
            Next
            ProgressBar1.Value = 75
                ListBox1.Items.Add(temp)
            If mode = 2 Then
                ListBox1.Items.Add("极限模式抽取已结束!")
                Button1.Enabled = False
                ProgressBar1.Value = 80
            End If
        ElseIf mode >= 5 Then
            '数据驱动模式
            ProgressBar1.Value = 30
            Dim repeat(6) As Integer, check, check2 As String, trigger As Integer
            '一次监测
            For trigger = 0 To exe + tms Step 1
                check2 = ListBox2.Items.Item(trigger)
                If ListBox2.SelectedItems.Contains（check2) = False Then
                    GoTo CX7
                End If
                trigger += 1
            Next
CX10:
            MsgBox("警告:找不到能被抽取的项!请检查数据驱动设定!" & Chr(13) & Chr(10) & "或检查是否能在不重复的前提下抽取完所有有效对象!", vbCritical + vbOKOnly, "错误")
            Exit Sub
CX7:
            If exe - trigger <= tms Then GoTo CX10
            ProgressBar1.Value = 50
            Randomize()
            datas = Rnd() * exe
            repeat(0) = datas
            temp = ListBox2.Items.Item(datas)
            If ListBox2.SelectedItems.Contains（temp) = False Then
                Label1.Text = "抽取对象为:" & temp
                temp = "第" & Str(memories) & "次:" & temp
                ProgressBar1.Value = 60
                For circle = 1 To tms Step 1
CX6:
                    Randomize()
                    datas = Rnd() * exe
                    If datas = 0 Then GoTo CX6
                    check = ListBox2.Items.Item(datas)
                    ProgressBar1.Value = 70
                    If ListBox2.SelectedItems.Contains（check) = False Then
                        repeat(circle) = datas
                        Dim repeat2 As Integer
                        For repeat2 = 0 To circle - 1 Step 1
                            If repeat(repeat2) = datas Then GoTo CX6

                        Next
                    Else
                        GoTo CX6
                    End If
                    On Error GoTo CX10
                    Label1.Text = Label1.Text & "/" & ListBox2.Items.Item(datas)
                    temp = temp & "/" & ListBox2.Items.Item(datas)
                Next
                On Error GoTo CX10
                ProgressBar1.Value = 90
                ListBox1.Items.Add(temp)
            Else
                GoTo CX7
            End If
        End If
        ProgressBar1.Value = 100
        Button7.Visible = True
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.Black
        circle = 1
        tms = 0
        mode = 0
        memories = 0
        ranges = 16
        mode2 = 0
        Area = 70
        exe = Area
        makesure = 0
        ComboBox1.Text = "默认模式"
        ToolStripStatusLabel2.Text = Date.Now
        ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Timer1.Enabled = True
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        ToolStripLabel4.Enabled = False
        Label6.Text = Str(ranges)
        Label7.Text = Str(tms + 1)
        Me.Show()
    End Sub
End Class
