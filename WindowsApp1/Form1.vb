Public Class Form1
    Public circle, tms, ranges, memories, mode2, exe, makesure, checked, checked2 As Integer, temp2 As String, doextreme As Boolean
    Public mode As Integer
    Public memo, dodata As Boolean
    Public Area As Integer
    Public Const readme as string ="这里可以显示预览效果."
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If memo = True Then Exit Sub
        Select Case ComboBox1.SelectedItem
            Case Is = "英语/语文模式(正常)"
                mode = 1
                NumericUpDown1.Value = 1
                tms = 1
                ranges = 16
                memories = 0
                doextreme = False
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                dodata = False
                temp2 = "随机数模式已就绪.等待抽号."
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
                dodata = False
                doextreme = True
                Label1.ForeColor = Color.Black
                temp2 = "随机数模式已就绪.等待抽号."
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
                doextreme = False
                dodata = True
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                Button1.Enabled = True
                Label1.ForeColor = Color.Black
                temp2 = "数据驱动模式已就绪.等待抽号."
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
                doextreme = False
                dodata = True
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                Button1.Enabled = True
                exe = 36
                memories = 0
                Label1.ForeColor = Color.Black
                temp2 = "数据驱动模式已就绪.等待抽号."
                ListBox1.Items.Clear()
                ListBox1.Items.Add("模式Premium就绪.")
                ListBox1.ForeColor = Color.DarkGoldenrod
                ToolStripLabel4.Enabled = True
                Label6.Text = Str(exe)
                Label7.Text = Str(NumericUpDown1.Value)
                ComboBox1.ForeColor = Color.DarkGoldenrod
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.SelectedItem
            Case Is = "关于模式的说明..."
                'Form4.Show()
                'ComboBox1.Text = memo
        End Select
        Timer2.Enabled = True
    End Sub
    '切换模式
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
    '更换字体/颜色2
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
    '切换页面

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If dodata = False Then
            ComboBox1.Text = "自定义模式"
            RadioButton4.Checked = True
            RadioButton5.Checked = False
            Label6.Text = Str(ranges)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Else
            ComboBox1.Text = "数据驱动模式Personaize"
            RadioButton4.Checked = False
            RadioButton5.Checked = True
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        End If
    End Sub
    '抽取次数调节
    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        If dodata = True Then
            mode = 4
            pool.Maximum = 100
            pool.Value = 16
            ranges = pool.Value
            ComboBox1.Text = "自定义模式"
            RadioButton5.Checked = True
            RadioButton4.Checked = False
            ToolStripLabel4.Enabled = False
            ListBox2.Enabled = False
            Label6.Text = Str(ranges)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Else
            Exit Sub
        End If
    End Sub
    '随机数开关
    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        If dodata = False Then
            dodata = True
            mode = 7
            pool.Maximum = Area
            pool.Value = Area
            exe = pool.Value
            ComboBox1.Text = "数据驱动模式Personaize"
            RadioButton5.Checked = True
            RadioButton4.Checked = False
            ToolStripLabel4.Enabled = True
            ListBox2.Enabled = True
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Else
            Exit Sub
        End If
    End Sub
    '数据驱动开关
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.Color = Label1.ForeColor
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Label1.ForeColor = ColorDialog1.Color
            Label9.ForeColor = ColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub
    '更换颜色
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
    '更换字体

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case Is = "空间邮件(DP)"
                Me.BackgroundImage = RandomMaker.My.Resources.空间邮件
                ToolStripLabel1.ForeColor = Color.White
                ToolStripLabel2.ForeColor = Color.White
                ToolStripLabel3.ForeColor = Color.White
                ToolStripLabel4.ForeColor = Color.White
                Label2.ForeColor = Color.White
                Label3.ForeColor = Color.White
                Label4.ForeColor = Color.White
                Label5.ForeColor = Color.White
                Label8.ForeColor = Color.White
                CheckBox1.ForeColor = Color.White
                RadioButton4.ForeColor = Color.White
                RadioButton5.ForeColor = Color.White
                RadioButton6.ForeColor = Color.White
            Case Is = "彩嵌邮件(DP)"
                Me.BackgroundImage = RandomMaker.My.Resources.彩嵌邮件
                ToolStripLabel1.ForeColor = Color.Black
                ToolStripLabel2.ForeColor = Color.Black
                ToolStripLabel3.ForeColor = Color.Black
                ToolStripLabel4.ForeColor = Color.Black
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label5.ForeColor = Color.Black
                Label8.ForeColor = Color.Black
                CheckBox1.ForeColor = Color.Black
                RadioButton4.ForeColor = Color.Black
                RadioButton5.ForeColor = Color.Black
                RadioButton6.ForeColor = Color.Black
            Case Is = "青草邮件(DP)"
                Me.BackgroundImage = RandomMaker.My.Resources.青草邮件
                ToolStripLabel1.ForeColor = Color.Black
                ToolStripLabel2.ForeColor = Color.Black
                ToolStripLabel3.ForeColor = Color.Black
                ToolStripLabel4.ForeColor = Color.Black
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label5.ForeColor = Color.Black
                Label8.ForeColor = Color.Black
                CheckBox1.ForeColor = Color.Black
                RadioButton4.ForeColor = Color.Black
                RadioButton5.ForeColor = Color.Black
                RadioButton6.ForeColor = Color.Black
            Case Is = "初次邮件(BW)"
                Me.BackgroundImage = RandomMaker.My.Resources.初次邮件
                ToolStripLabel1.ForeColor = Color.Black
                ToolStripLabel2.ForeColor = Color.Black
                ToolStripLabel3.ForeColor = Color.Black
                ToolStripLabel4.ForeColor = Color.Black
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label5.ForeColor = Color.Black
                Label8.ForeColor = Color.Black
                CheckBox1.ForeColor = Color.Black
                RadioButton4.ForeColor = Color.Black
                RadioButton5.ForeColor = Color.Black
                RadioButton6.ForeColor = Color.Black
            Case Is = "桥梁邮件W(BW)"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｗ
                ToolStripLabel1.ForeColor = Color.Black
                ToolStripLabel2.ForeColor = Color.Black
                ToolStripLabel3.ForeColor = Color.Black
                ToolStripLabel4.ForeColor = Color.Black
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label5.ForeColor = Color.Black
                Label8.ForeColor = Color.Black
                CheckBox1.ForeColor = Color.Black
                RadioButton4.ForeColor = Color.Black
                RadioButton5.ForeColor = Color.Black
                RadioButton6.ForeColor = Color.Black
        End Select
    End Sub
    '更换背景
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Title = "载入配置..."
        OpenFileDialog1.Filter = "抽号发生器配置文件|*.txt"
        OpenFileDialog1.ShowReadOnly = True
        Dim mdname(10), doex(10) As Integer, tp(10) As Boolean, et(19), TypeN As String, mxarea, tomode, cir, extime(10), exrange(10), inde(10) As Integer
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            FileOpen(2, OpenFileDialog1.FileName, OpenMode.Input, OpenAccess.Read)
            EOF(2)
            et(0) = LineInput(2)
            et(1) = LineInput(2)
            TypeN = LineInput(2)
            et(2) = LineInput(2)
            mxarea = LineInput(2)
            et(3) = LineInput(2)
            tomode = LineInput(2)
            et(13) = LineInput(2)
            Timer2.Interval = LineInput(2)
            Timer4.Interval = Timer2.Interval
            For cir = 0 To tomode Step 1
                et(4) = LineInput(2)
                et(5) = LineInput(2)
                mdname(cir) = LineInput(2)
                et(6) = LineInput(2)
                extime(cir) = LineInput(2)
                et(7) = LineInput(2)
                exrange(cir) = LineInput(2)
                et(8) = LineInput(2)
                tp(cir) = LineInput(2)
                et(9) = LineInput(2)
                doex(cir) = LineInput(2)
                et(10) = LineInput(2)
                inde(cir) = LineInput(2)
                ComboBox1.Items.Add(mdname)
                EOF(2)
            Next
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
            FileClose(2)
            Area = mxarea
            ' ComboBox1.SelectedIndex = 0
            '    tms = num(0)
            '    NumericUpDown1.Value = tms
            '    Label7.Text = Str(NumericUpDown1.Value)
            MsgBox("载入成功!", vbInformation + vbOKOnly, "祝贺")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = False Then
            doextreme = True
        Else
            doextreme = False
        End If
    End Sub
    '极限模式
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.SelectedItem
            Case Is = "快"
                Timer2.Interval = 10
                Timer4.Interval = 10
            Case Is = "中"
                Timer2.Interval = 25
                Timer4.Interval = 25
            Case Is = "慢"
                Timer2.Interval = 100
                Timer4.Interval = 100
        End Select
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim iris As Integer
        If readme = Nothing Then Exit Sub
        iris = readme.Length
        checked2 += 1
        Label9.Text = readme.Substring(0, checked2)
        If checked2 > iris - 1 Then
            checked2 = 1
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub ReDiveP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReDiveP.LinkClicked
        Me.BackgroundImage = RandomMaker.My.Resources.空间邮件
        ToolStripLabel1.ForeColor = Color.White
        ToolStripLabel2.ForeColor = Color.White
        ToolStripLabel3.ForeColor = Color.White
        ToolStripLabel4.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label5.ForeColor = Color.White
        Label8.ForeColor = Color.White
        CheckBox1.ForeColor = Color.White
        RadioButton4.ForeColor = Color.White
        RadioButton5.ForeColor = Color.White
        RadioButton6.ForeColor = Color.White
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Const frontline As String = "The configuration of RM MKII"
        Static seo As Integer
        seo = ComboBox1.SelectedIndex
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            SaveFileDialog1.Title = "保存配置..."
            SaveFileDialog1.Filter = "抽号发生器配置文件|*.txt"
            Dim et(15) As String, mymodename As String, temp2, ex(3) As Integer
            Static temp As Integer
            Dim temp3 As Boolean
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
            WriteLine(2, "Speakers:")
            WriteLine(2, Timer2.Interval)
            For temp2 = 0 To temp - 1
                ComboBox1.SelectedIndex = temp2
                temp3 = dodata
                WriteLine(2, "Mode" & temp2 + 1)
                WriteLine(2, "ModeName:")
                WriteLine(2, ComboBox1.SelectedItem)
                ex(0) = Str(NumericUpDown1.Value)
                If dodata = True Then
                    ex(2) = exe
                Else
                    ex(2) = ranges
                End If
                WriteLine(2, "Extract Times:")
                WriteLine(2, ex(0))
                WriteLine(2, "Extract Ranges:")
                WriteLine(2, ex(2))
                WriteLine(2, "ModeType:")
                WriteLine(2, temp3)
                WriteLine(2, "DoExtremeMode")
                WriteLine(2, doextreme)
                WriteLine(2, "Modeindex")
                WriteLine(2, temp + 1)
            Next
            WriteLine(2, "CreateTime:" & Date.Now)
            FileClose(2)
        Else
            Exit Sub
        End If
        MsgBox("保存成功", vbInformation + vbOKOnly, "祝贺")
        ComboBox1.SelectedIndex = seo
        memo = True
        Timer3.Enabled = True
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        OpenFileDialog1.Title = "载入配置..."
        OpenFileDialog1.Filter = "抽号发生器配置文件|*.txt"
        OpenFileDialog1.ShowReadOnly = True
        Dim mdname(10), doex(10) As Integer, tp(10) As Boolean, et(19), TypeN As String, mxarea, tomode, cir, extime(10), exrange(10), inde(10) As Integer
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            FileOpen(2, OpenFileDialog1.FileName, OpenMode.Input, OpenAccess.Read)
            EOF(2)
            et(0) = LineInput(2)
            et(1) = LineInput(2)
            TypeN = LineInput(2)
            et(2) = LineInput(2)
            mxarea = LineInput(2)
            et(3) = LineInput(2)
            tomode = LineInput(2)
            et(13) = LineInput(2)
            Timer2.Interval = LineInput(2)
            Timer4.Interval = Timer2.Interval
            For cir = 0 To tomode Step 1
                et(4) = LineInput(2)
                et(5) = LineInput(2)
                mdname(cir) = LineInput(2)
                et(6) = LineInput(2)
                extime(cir) = LineInput(2)
                et(7) = LineInput(2)
                exrange(cir) = LineInput(2)
                et(8) = LineInput(2)
                tp(cir) = LineInput(2)
                et(9) = LineInput(2)
                doex(cir) = LineInput(2)
                et(10) = LineInput(2)
                inde(cir) = LineInput(2)
                ComboBox1.Items.Add(mdname)
                EOF(2)
            Next
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
            FileClose(2)
            Area = mxarea
            ' ComboBox1.SelectedIndex = 0
            '    tms = num(0)
            '    NumericUpDown1.Value = tms
            '    Label7.Text = Str(NumericUpDown1.Value)
            MsgBox("载入成功!", vbInformation + vbOKOnly, "祝贺")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Pool_ValueChanged(sender As Object, e As EventArgs) Handles pool.ValueChanged
        If dodata = False Then
EROR:
            pool.Maximum = 100
            ranges = pool.Value
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
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Else
EROR2:
            pool.Maximum = 71
            exe = pool.Value
            If exe = 0 Or exe > 68 Then
                MsgBox("范围不能为0或大于最大值的数!", vbOKOnly, "提示")
                GoTo EROR2
            End If
            mode = 7
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.Text = "数据驱动模式Personaize"
            ComboBox1.ForeColor = Color.Chocolate
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer4.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        memo = False
        Timer3.Enabled = False
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim temp As Integer
            SaveFileDialog1.Title = "保存记录..."
            SaveFileDialog1.Filter = "抽号发生器配置文件|*.txt"
            SaveFileDialog1.CreatePrompt = True
            FileOpen(2, SaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, Date.Now)
            For temp = 1 To memories
                WriteLine(2, ListBox1.Items.Item(temp))
            Next
            WriteLine(2, "抽取次数:" & NumericUpDown1.Value)
            WriteLine(2, "使用的模式:" & ComboBox1.SelectedItem)
            FileClose(2)
            MsgBox("保存成功", vbOKOnly, "祝贺")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim iris As Integer
        If temp2 = Nothing Then Exit Sub
        iris = temp2.Length
        checked += 1
        Label1.Text = temp2.Substring(0, checked)
        If checked > iris - 1 Then
            checked = 1
            Timer2.Enabled = False
        End If
      

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            makesure = 1
        Else
            makesure = 0
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
        Me.BackgroundImage = My.Resources.空间邮件
        ToolStripLabel1.ForeColor = Color.White
        ToolStripLabel2.ForeColor = Color.White
        ToolStripLabel3.ForeColor = Color.White
        ToolStripLabel4.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label5.ForeColor = Color.White
        Label8.ForeColor = Color.White
        CheckBox1.ForeColor = Color.White
        RadioButton4.ForeColor = Color.White
        RadioButton5.ForeColor = Color.White
        RadioButton6.ForeColor = Color.White
        Select Case doextreme
            Case Is = true
                ToolStripLabel4.Enabled = False
                Label6.Text = Str(ranges)
                Label7.Text = Str(NumericUpDown1.Value)
                Label1.Text = "极限模式禁止初始化.请切换模式."
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            Case Else
                Select Case dodata
                    Case Is = False
                        circle = 1
                        tms = 0
                        memories = 0
                        ranges = 16
                        mode2 = 0
                        Label6.Text = Str(ranges)
                        Label7.Text = Str(tms)
                        NumericUpDown1.Value = 1
                        Button1.Enabled = True
                        doextreme = False
                        pool.Value = ranges
                        Label1.ForeColor = Color.Black
                        ToolStripLabel4.Enabled = False
                        ComboBox1.Text = "默认模式"
                        ListBox1.ForeColor = Color.Black
                        Label6.Text = Str(ranges)
                        Label7.Text = Str(NumericUpDown1.Value)
                        Label1.Text = "初始化完毕.等待抽号."
                        ListBox1.Items.Clear()
                        ListBox1.Items.Add("随机数模式就绪")
                        ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
                    Case Is = True
SX2:
                        mode = 5
                        circle = 1
                        tms = 0
                        memories = 0
                        ranges = 16
                        mode2 = 0
                        exe = Area
                        doextreme = False
                        NumericUpDown1.Value = 1
                        memories = 0
                        Button1.Enabled = True
                        pool.Value = exe
                        Label1.ForeColor = Color.Black
                        ToolStripLabel4.Enabled = True
                        Label1.Text = "初始化完毕.等待抽号."
                        ComboBox1.Text = "数据驱动模式Normal"
                        ListBox1.Items.Clear()
                        ListBox1.Items.Add("数据驱动模式就绪.")
                        Label6.Text = Str(exe)
                        Label7.Text = Str(NumericUpDown1.Value)
                        RadioButton4.Checked = False
                        RadioButton5.Checked = True
                        ListBox1.ForeColor = Color.Purple
                        ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
                End Select
        End select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datas As Integer, temp As String
        tms = NumericUpDown1.Value - 1
        memories = 1 + memories
        ProgressBar1.Value = 10
        If makesure = 0 Then
CX8:
            If doextreme=true Then
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
            temp2 = "抽出数值:" & Str(datas)
            temp = "第" & Str(memories) & "次:" & Str(datas)
            ProgressBar1.Value = 50
            For circle = 1 To tms Step 1
CX2:
                Randomize()
                datas = Rnd() * ranges
                If datas = 0 Then GoTo CX2
                temp2 = temp2 & "/" & Str(datas)
                temp = temp & "/" & Str(datas)
            Next
            ProgressBar1.Value = 75
            ListBox1.Items.Add(temp)
            If doextreme = True Then
                ListBox1.Items.Add("极限模式抽取已结束!")
                Button1.Enabled = False
                ProgressBar1.Value = 99
            End If
            Button7.Visible = True
            Timer2.Enabled = True
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
                temp2 = "抽取对象为:" & temp
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
                    temp2 += "/" & ListBox2.Items.Item(datas)
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
        If doextreme = True Then
            ListBox1.Items.Add("极限模式抽取已结束!")
            Button1.Enabled = False
            ProgressBar1.Value = 80
        End If
        Timer2.Enabled = True
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.Black
        circle = 1
        tms = 0
        mode = 0
        memories = 0
        ranges = 16
        mode2 = 0
        Area = 71
        exe = Area
        makesure = 0
        checked = 1
        checked2 = 1
        memo = False
        dodata = False
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
