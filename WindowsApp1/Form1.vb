Imports System.IO
Imports System.Data
Imports System.Deployment
Imports Telerik.WinForms.UI
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Themes.FluentTheme
Imports Telerik.WinControls.RadMessageBox
Public Class Form1
    Public circle, tms, ranges, memories, exe, makesure, checked, checked2 As Integer, temp2 As String

    '抽取核心变量，不可以更改
    Public memo, dodata, def, ulcheck, doextreme, donew As Boolean, lock As Boolean = True

    '记忆模式，判定变量，不可以修改
    Public Area, mimo, seo As Integer

    '最大范围，单列
    Public Const readme As String = "这里可以显示对话框的预览效果."

    '常量列表
    Public tp(10), TypeN, mdname(10), doex(10) As String, mxarea, tomode As Integer, extime(10), exrange(10) As Integer

    '内部存储
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If memo = True Then Exit Sub
        If def = True Then
            Dim xr As Int16
            lock = True
            donew = False
            xr = ComboBox1.SelectedIndex
            tms = extime(xr)
            NumericUpDown1.Value = tms
            If tp(xr) = "#FALSE#" Then
                ranges = exrange(xr)
                pool.Maximum = 100
                pool.Value = ranges
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                dodata = False
                Label6.Text = Str(ranges)
                If ulcheck = True Then
                    ListBox1.Items.Clear()
                    temp2 = "随机数模式已就绪.等待抽取."
                    ListBox1.Items.Add(mdname(xr) & "就绪.")
                End If
                ToolStripLabel4.Enabled = False
            Else
                exe = exrange(xr)
                pool.Maximum = Area
                pool.Value = exe
                dodata = True
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                Label6.Text = Str(exe)
                If ulcheck = True Then
                    ListBox1.Items.Clear()
                    temp2 = "数据驱动模式已就绪.等待抽取."
                    ListBox1.Items.Add(mdname(xr) & "就绪.")
                End If
                ToolStripLabel4.Enabled = True
            End If
            If ulcheck = True Then
                memories = 0
            End If
            Label7.Text = Str(NumericUpDown1.Value)
            If doex(xr) = "#TRUE#" Then
                RadToggleSwitch1.Value = True
                doextreme = True
                RadButton1.Enabled = True
                Label14.Visible = True
            Else
                RadToggleSwitch1.Value = False
                doextreme = False
                RadButton1.Enabled = True
                Label14.Visible = False
            End If
            ToolStripStatusLabel3.Text = "当前模式:" & mdname(xr)
            Call ColorSwitch(xc:=xr)
        End If
        ToolStripLabel5.Enabled = True
        Timer2.Enabled = True
        lock = False
    End Sub

    '切换模式
    Private Sub 更新记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新记录ToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        ToolStripLabel2.LinkVisited = False
        ToolStripLabel1.LinkVisited = True
        ToolStripLabel3.LinkVisited = False
        ToolStripLabel4.LinkVisited = False
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = True
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        ToolStripLabel2.LinkVisited = False
        ToolStripLabel1.LinkVisited = False
        ToolStripLabel3.LinkVisited = True
        ToolStripLabel4.LinkVisited = False
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = False
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        ToolStripLabel2.LinkVisited = False
        ToolStripLabel1.LinkVisited = False
        ToolStripLabel3.LinkVisited = False
        ToolStripLabel4.LinkVisited = True
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = False
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        ToolStripLabel2.LinkVisited = True
        ToolStripLabel1.LinkVisited = False
        ToolStripLabel3.LinkVisited = False
        ToolStripLabel4.LinkVisited = False
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = False
    End Sub

    '切换页面
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If lock = True Then Exit Sub
        tms = NumericUpDown1.Value
        donew = True
        If dodata = False Then
            ComboBox1.Text = "自定义模式"
            RadioButton4.Checked = True
            RadioButton5.Checked = False
            Label6.Text = Str(ranges)
            Label7.Text = Str(tms)
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Else
            ComboBox1.Text = "数据驱动模式Personaize"
            RadioButton4.Checked = False
            RadioButton5.Checked = True
            Label6.Text = Str(exe)
            Label7.Text = Str(tms)
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        End If
        TextBox1.Text = ComboBox1.Text & dodata - 3
    End Sub

    '抽取次数调节
    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        If dodata = True Then
            dodata = False
            If lock = True Then Exit Sub
            donew = True
            RadioButton5.Checked = True
            RadioButton4.Checked = False
            ToolStripLabel4.Enabled = False
            ListBox2.Enabled = False
            pool.Maximum = 100
            Label6.Text = Str(ranges)
            Label7.Text = Str(tms)
            pool.Value = 16
            ranges = pool.Value
            ComboBox1.Text = "自定义模式"
            ListBox1.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            TextBox1.Text = ComboBox1.Text & dodata - 3
        Else
            Exit Sub
        End If
    End Sub

    '随机数开关
    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        If dodata = False Then
            dodata = True
            If lock = True Then Exit Sub
            donew = True
            pool.Maximum = Area
            pool.Value = Area
            exe = pool.Value
            ComboBox1.Text = "数据驱动模式Personaize"
            RadioButton5.Checked = True
            RadioButton4.Checked = False
            ToolStripLabel4.Enabled = True
            ListBox2.Enabled = True
            Label6.Text = Str(exe)
            Label7.Text = Str(tms)
            ListBox1.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            TextBox1.Text = ComboBox1.Text & dodata - 3
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
        ulcheck = False
        Select Case ComboBox2.Text
            Case Is = "空间邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.空间邮件
                Call Wht()
            Case Is = "彩嵌邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.彩嵌邮件
                Call Bla()
            Case Is = "青草邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.青草邮件
                Call Bla()
            Case Is = "初次邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.初次邮件
                Call Bla()
            Case Is = "钢铁邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.钢铁邮件
                Call Wht()
            Case Is = "回复邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.回复邮件
                Call Bla()
            Case Is = "桥梁邮件W"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｗ
                Call Bla()
            Case Is = "桥梁邮件C"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｃ
                Call Bla()
            Case Is = "桥梁邮件V"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｖ
                Call Bla()
            Case Is = "桥梁邮件H"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｈ
                Call Wht()
            Case Is = "桥梁邮件S"
                Me.BackgroundImage = RandomMaker.My.Resources.桥梁邮件Ｓ
                Call Bla()
            Case Is = "水蓝邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.水蓝邮件
                Call Wht()
            Case Is = "砖块邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.砖块邮件
                Call Wht()
            Case Is = "暴雪邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.暴雪邮件
                Call Bla()
            Case Is = "天空邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.天空邮件
                Call Bla()
            Case Is = "喜爱邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.喜爱邮件
                Call Bla()
            Case Is = "感谢邮件"
                Me.BackgroundImage = RandomMaker.My.Resources.感谢邮件
                Call Bla()
        End Select
        ulcheck = True
    End Sub

    Private Sub Wht()
        ToolStripLabel1.LinkColor = Color.White
        ToolStripLabel2.LinkColor = Color.White
        ToolStripLabel3.LinkColor = Color.White
        ToolStripLabel4.LinkColor = Color.White
        ToolStripLabel5.LinkColor = Color.White
        GroupBox1.ForeColor = Color.White
        GroupBox2.ForeColor = Color.White
        GroupBox3.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label5.ForeColor = Color.White
        Label8.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label10.ForeColor = Color.White
        Label11.ForeColor = Color.White
        Label12.ForeColor = Color.White
        CheckBox1.ForeColor = Color.White
        Label15.ForeColor = Color.White
        RadioButton4.ForeColor = Color.White
        RadioButton5.ForeColor = Color.White
        If lock = True Then Exit Sub
        Call Xs()
    End Sub

    Private Sub Bla()
        ToolStripLabel1.LinkColor = Color.Black
        ToolStripLabel2.LinkColor = Color.Black
        ToolStripLabel3.LinkColor = Color.Black
        ToolStripLabel4.LinkColor = Color.Black
        ToolStripLabel5.LinkColor = Color.Black
        GroupBox1.ForeColor = Color.Black
        GroupBox2.ForeColor = Color.Black
        GroupBox3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label8.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
        Label10.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        CheckBox1.ForeColor = Color.Black
        Label15.ForeColor = Color.Black
        RadioButton4.ForeColor = Color.Black
        RadioButton5.ForeColor = Color.Black
        If lock = True Then Exit Sub
        Call Xs()
    End Sub

    '黑白切换
    Private Sub ColorSwitch(ByVal xc As Integer)
        Select Case xc + 1
            Case Is = 0
                ListBox1.ResetForeColor()
            Case Is = 1
                ListBox1.ForeColor = Color.Blue
            Case Is = 2
                ListBox1.ForeColor = Color.Red
            Case Is = 3
                ListBox1.ForeColor = Color.Purple
            Case Is = 4
                ListBox1.ForeColor = Color.DarkGoldenrod
            Case Is = 5
                ListBox1.ForeColor = Color.Indigo
            Case Is = 6
                ListBox1.ForeColor = Color.DarkOrange
            Case Is = 8
                ListBox1.ForeColor = Color.Gray
            Case Is = 9
                ListBox1.ForeColor = Color.Olive
            Case Is = 10
                ListBox1.ForeColor = Color.DarkCyan
            Case Is = 7
                ListBox1.ForeColor = Color.Brown
        End Select
    End Sub

    Private Sub Debugselect_Click(sender As Object, e As EventArgs) Handles Debugselect.Click
        DebugForm.Show()
    End Sub

    Private Sub RadToggleSwitch1_ValueChanged(sender As Object, e As EventArgs) Handles RadToggleSwitch1.ValueChanged
        If doextreme = False Then
            doextreme = True
            RadButton1.Enabled = True
            Label14.Visible = True
        Else
            doextreme = False
            RadButton1.Enabled = True
            Label14.Visible = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim selCell As DataGridViewCell, lblCellInfoColIndex, lblCellInfoRowIndex As Byte
        selCell = DataGridView1.CurrentCell
        lblCellInfoColIndex = selCell.ColumnIndex
        lblCellInfoRowIndex = selCell.RowIndex

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Select Case ComboBox4.SelectedItem
            Case Is = "E"
                Label1.Image = My.Resources.EDialog
                Label9.Image = My.Resources.EDialog
            Case Is = "Pt(默认)"
                Label1.Image = My.Resources.PtDialog
                Label9.Image = My.Resources.PtDialog
            Case Is = "HGSS"
                Label1.Image = My.Resources.hgssdialog
                Label9.Image = My.Resources.hgssdialog
            Case Is = "DP"
                Label1.Image = My.Resources.DialogDP
                Label9.Image = My.Resources.DialogDP
            Case Is = "ORAS"
                Label1.Image = My.Resources.ORASDialog
                Label9.Image = My.Resources.ORASDialog
        End Select
        If lock = True Then Exit Sub
        ulcheck = False
        Call Xs()
        ulcheck = True
    End Sub

    '更换背景

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
        If lock = True Then Exit Sub
        ulcheck = False
        Call Xs()
        ulcheck = True
        Timer4.Enabled = True
    End Sub

    '语速
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

    Private Sub Xs()
        Const frontline As String = "=====The Configuration Of RandomMakerv5.x====="
        Dim et(15) As String, temp2, ex(3) As Integer
        Dim temp As Integer
        Dim temp3 As Boolean
        seo = ComboBox1.SelectedIndex
        lock = True
        temp = ComboBox1.Items.Count
        FileOpen(2, "D:\RMConfig.ini", OpenMode.Output, OpenAccess.Default)
        WriteLine(2, frontline)
        WriteLine(2, "TypeName:")
        PrintLine(2, "AutoSave" & Date.Now)
        WriteLine(2, "MaximaArea")
        WriteLine(2, Area)
        WriteLine(2, "totalmode")
        WriteLine(2, tomode)
        WriteLine(2, "Speakers:")
        WriteLine(2, Timer2.Interval)
        WriteLine(2, "BackgroundImage:")
        PrintLine(2, ComboBox2.SelectedItem)
        WriteLine(2, "DialogImage:")
        PrintLine(2, ComboBox4.SelectedItem)
        For temp2 = 0 To temp - 1
            ComboBox1.SelectedIndex = temp2
            temp3 = dodata
            WriteLine(2, "=====Mode" & temp2 + 1 & “=====”)
            WriteLine(2, "ModeName:")
            PrintLine(2, ComboBox1.SelectedItem)
            ex(0) = Str(extime(temp2)）
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
        Next
        WriteLine(2, "CreateTime:" & Date.Now)
        WriteLine(2, "使用的模式:")
        ComboBox1.SelectedIndex = seo
        WriteLine(2, ComboBox1.SelectedIndex)
        FileClose(2)
        ComboBox1.Text = mdname(seo)
        lock = False
        Timer3.Enabled = True
    End Sub

    '保存通用过程
    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        Dim xr As Integer
        xr = ComboBox1.SelectedIndex
        donew = False
        ListBox1.Items.Clear()
        ListBox1.Items.Add(ComboBox1.Text & "就绪.")
        Select Case dodata
            Case Is = False
                circle = 1
                tms = extime(xr)
                NumericUpDown1.Value = tms
                Label7.Text = Str(tms)
                memories = 0
                ranges = exrange(xr)
                pool.Maximum = 100
                pool.Value = ranges
                exe = Area
                Label6.Text = Str(ranges)
                Label1.ForeColor = Color.Black
                ToolStripLabel4.Enabled = False
                ComboBox1.Text = mdname(xr)
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                Label6.Text = Str(ranges)
                Label7.Text = Str(tms)
                temp2 = "随机数模式已初始化完毕."
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            Case Is = True
                circle = 1
                tms = extime(xr)
                memories = 0
                exe = exrange(xr)
                NumericUpDown1.Value = tms
                memories = 0
                pool.Maximum = Area
                pool.Value = exe
                Label1.ForeColor = Color.Black
                ToolStripLabel4.Enabled = True
                Label6.Text = Str(exe)
                Label7.Text = Str(tms)
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                temp2 = "数据驱动模式已初始化完毕."
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        End Select
        If doex(xr) = "#TRUE#" Then
            doextreme = True
            Label14.Visible = True
            RadButton1.Enabled = True
            RadToggleSwitch1.Value = True
        Else
            doextreme = False
            Label14.Visible = False
            RadButton1.Enabled = True
            RadToggleSwitch1.Value = False
        End If
        Timer2.Enabled = True
    End Sub

    '初始化
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Dim cx As Integer
    '    For cx = 0 To tomode - 1
    '        If MsgBox("是否删除第" & cx + 1 & "项:" & Chr(13) & Chr(10) & mdname(cx) & "?", vbOKCancel, "提示") = MsgBoxResult.Ok Then ComboBox1.Items.Remove(mdname(cx))
    '    Next
    '    MsgBox("完毕", vbOKOnly + vbInformation, "祝贺")
    'End Sub
    '动画效果预览
    Private Sub ReDiveP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReDiveP.LinkClicked
        Me.BackgroundImage = RandomMaker.My.Resources.天空邮件
        ulcheck = False
        Call Bla()
        ulcheck = True
        Label1.Image = My.Resources.PtDialog
        Label9.Image = My.Resources.PtDialog
    End Sub

    '还原自定义设置
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If MsgBox("即将恢复至默认状态,自定义配置将丢失,确定吗"， vbOKCancel + vbQuestion, "注意") = MsgBoxResult.Ok Then
            Label1.ForeColor = Color.Black
            Dim cir As Byte
            def = True
            lock = True
            donew = False
            ComboBox2.SelectedItem = "天空邮件"
            RadioButton4.Checked = True
            RadioButton5.Checked = False
            lock = False
            circle = 1
            tms = 1
            extime(0) = 1
            extime(1) = 1
            extime(2) = 1
            extime(3) = 1
            memories = 0
            ranges = 16
            exrange(0) = 16
            exrange(1) = 16
            Area = 70
            exe = Area
            exrange(2) = Area
            exrange(3) = 36
            tp(0) = "#FALSE#"
            tp(1) = "#FALSE#"
            tp(2) = "#TRUE#"
            tp(3) = "#TRUE#"
            doex(0) = "#FALSE#"
            doex(1) = "#TRUE#"
            doex(2) = "#FALSE#"
            doex(3) = "#FALSE#"
            makesure = 0
            CheckBox1.Checked = False
            RadToggleSwitch1.Value = False
            checked = 1
            checked2 = 1
            memo = False
            dodata = False
            tomode = 4
            RadButton1.Enabled = True
            Timer1.Enabled = True
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            ToolStripLabel1.LinkVisited = True
            ToolStripLabel2.LinkVisited = False
            ToolStripLabel4.Enabled = False
            Label6.Text = Str(ranges)
            Label7.Text = Str(tms)
            lock = True
            Me.BackgroundImage = RandomMaker.My.Resources.天空邮件
            Label1.Image = My.Resources.PtDialog
            Label9.Image = My.Resources.PtDialog
            mdname(0) = "英语/语文模式(正常)"
            mdname(1) = "英语/语文模式(极限)"
            mdname(2) = "数据驱动模式Normal"
            mdname(3) = "数据驱动模式Premium"
            For cir = 4 To 10
                mdname(cir) = Nothing
                tp(cir) = Nothing
                doex(cir) = Nothing
                extime(cir) = 0
                exrange(cir) = 0
            Next
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("英语/语文模式(正常)")
            ComboBox1.Items.Add("英语/语文模式(极限)")
            ComboBox1.Items.Add("数据驱动模式Normal")
            ComboBox1.Items.Add("数据驱动模式Premium")
            ComboBox1.SelectedIndex = 0
            ListBox1.Items.Clear()
            ListBox1.Items.Add("准备就绪.")
            Label14.Visible = False
            Timer2.Enabled = True
            ulcheck = False
            Call Bla()
            lock = False
            ulcheck = True
            ComboBox1.SelectedIndex = 0
            ComboBox1.Text = ComboBox1.Items(0)
            temp2 = "重置成功."
            Timer2.Enabled = True
            ToolStripStatusLabel2.Text = Date.Now
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Else
            Exit Sub
        End If
    End Sub

    '全重置
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim xr As Integer
        xr = ComboBox1.SelectedIndex
        donew = False
        Select Case dodata
            Case Is = False
                circle = 1
                tms = extime(xr)
                memories = 0
                ranges = exrange(xr)
                exe = Area
                Label6.Text = Str(ranges)
                Label7.Text = Str(tms)
                NumericUpDown1.Value = tms
                pool.Maximum = 100
                pool.Value = ranges
                Label1.ForeColor = Color.Black
                ToolStripLabel4.Enabled = False
                ComboBox1.Text = mdname(xr)
                ListBox1.ForeColor = Color.Black
                RadioButton4.Checked = True
                RadioButton5.Checked = False
                Label6.Text = Str(ranges)
                Label7.Text = Str(tms)
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            Case Is = True
SX2:
                circle = 1
                tms = extime(xr)
                memories = 0
                exe = exrange(xr)
                NumericUpDown1.Value = tms
                memories = 0
                pool.Maximum = Area
                pool.Value = exe
                Label1.ForeColor = Color.Black
                ListBox1.ForeColor = Color.Chocolate
                ToolStripLabel4.Enabled = True
                Label6.Text = Str(exe)
                Label7.Text = Str(tms)
                RadioButton4.Checked = False
                RadioButton5.Checked = True
                ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        End Select
        If doex(xr) = "#TRUE#" Then
            doextreme = True
            Label14.Visible = True
            RadButton1.Enabled = True
            RadToggleSwitch1.Value = True
        Else
            doextreme = False
            Label14.Visible = False
            RadButton1.Enabled = True
            RadToggleSwitch1.Value = False
        End If
    End Sub

    '部分重置

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lock = True
        Const frontline As String = "=====The Configuration Of RM MKIV====="
        If RadSaveFileDialog1.ShowDialog = DialogResult.OK Then
            RadSaveFileDialog1.Filter = "抽号发生器配置文件|*.ini"
            Dim et(15) As String, mymodename As String, temp2, ex(3) As Integer
            Static temp As Integer
            Dim temp3 As Boolean
            temp = ComboBox1.Items.Count
            mymodename = InputBox("为该配置命名?", "保存确认")
            FileOpen(2, RadSaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, frontline)
            WriteLine(2, "TypeName:")
            PrintLine(2, mymodename)
            WriteLine(2, "MaximaArea")
            WriteLine(2, Area)
            WriteLine(2, "totalmode")
            WriteLine(2, tomode)
            WriteLine(2, "Speakers:")
            WriteLine(2, Timer2.Interval)
            WriteLine(2, "BackgroundImage:")
            PrintLine(2, ComboBox2.SelectedItem)
            WriteLine(2, "DialogImage:")
            PrintLine(2, ComboBox4.SelectedItem)
            ulcheck = False
            For temp2 = 0 To temp - 1
                ComboBox1.SelectedIndex = temp2
                temp3 = dodata
                WriteLine(2, "=====Mode" & temp2 + 1 & “=====”)
                WriteLine(2, "ModeName:")
                PrintLine(2, ComboBox1.SelectedItem)
                ex(0) = Str(NumericUpDown1.Value）
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
            Next
            WriteLine(2, "CreateTime:" & Date.Now)
            WriteLine(2, "使用的模式:")
            WriteLine(2, ComboBox1.SelectedIndex)
            FileClose(2)
            ComboBox1.SelectedIndex = seo
            ComboBox1.Text = mdname(seo)
            ulcheck = True
        Else
            Exit Sub
        End If
        MsgBox("保存成功", vbInformation + vbOKOnly, "祝贺")
        lock = False
        'memo = True
        'Timer3.Enabled = True
    End Sub


    Private Sub LoadView_Click(sender As Object, e As EventArgs) Handles LoadView.Click
        If dodata = True Then
            Dim eo(2) As String, mc, ic As Integer
            RadOpenFileDialog1.FileName = "Listview1"
            RadOpenFileDialog1.Filter = "抽号发生器配置文件|*.txt"
            RadOpenFileDialog1.ShowReadOnly = True
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                FileOpen(2, OpenFileDialog1.FileName, OpenMode.Input, OpenAccess.Read)
                EOF(2)
                eo(0) = LineInput(2)
                mc = Val(LineInput(2))
                ReDim eo(mc)
                ListBox2.Items.Clear()
                For ic = 0 To mc - 3 Step 1
                    EOF(2)
                    eo(ic) = LineInput(2)
                    ListBox2.Items.Add(eo(ic))
                    EOF(2)
                Next
                FileClose(2)
            Else
                Exit Sub
            End If
            Area = mc
            exe = Area
            pool.Value = exe
            Form5.Show()
        Else
            Exit Sub
        End If
    End Sub

    '载入列表
    Private Sub SaveView_Click(sender As Object, e As EventArgs) Handles SaveView.Click
        If dodata = True Then
            RadSaveFileDialog1.FileName = "Listview1"
            RadSaveFileDialog1.Filter = "抽号发生器配置文件|*.txt"
            If RadSaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim temp As Integer
                SaveFileDialog2.CreatePrompt = True
                FileOpen(2, RadSaveFileDialog1.FileName, OpenMode.Output, OpenAccess.Default)
                WriteLine(2, Date.Now)
                WriteLine(2, Area)
                For temp = 0 To Area - 1
                    PrintLine(2, ListBox2.Items.Item(temp))
                Next
                FileClose(2)
                MsgBox("保存成功", vbOKOnly, "祝贺")
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    '保存列表
    Private Sub Saver_Click(sender As Object, e As EventArgs) Handles Saver.Click
        If ComboBox1.Items.Count > 10 Then
            MsgBox("最多存在11个模式", vbOKOnly, "提示")
            Exit Sub
        End If
        If lock = True Then Exit Sub
        ComboBox1.Items.Add(TextBox1.Text)
        tomode += 1
        If dodata = True Then
            exrange(tomode - 1) = exe
            tp(tomode - 1) = "#TRUE#"
        Else
            exrange(tomode - 1) = ranges
            tp(tomode - 1) = "#FALSE#"
        End If
        extime(tomode - 1) = tms
        If doextreme = True Then
            doex(tomode - 1) = "#TRUE#"
        Else
            doex(tomode - 1) = "#FALSE#"
        End If
        mdname(tomode - 1) = TextBox1.Text
        donew = False
        MsgBox("保存成功,请返回模式列表查看", vbOKOnly + vbInformation, "祝贺")
        ulcheck = False
        Call Xs()
        ulcheck = True
    End Sub

    '保存自定义模式
    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        RadOpenFileDialog1.Filter = "抽号发生器配置文件|*.ini"
        RadOpenFileDialog1.ShowReadOnly = True
        If RadOpenFileDialog1.ShowDialog = DialogResult.OK Then
            lock = True
            Dim cir As Integer, et(19) As String
            ComboBox1.Items.Clear()
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
            et(14) = LineInput(2)
            ComboBox2.SelectedItem = LineInput(2)
            et(15) = LineInput(2)
            ComboBox4.SelectedItem = LineInput(2)
            For cir = 0 To tomode - 1 Step 1
                EOF(2)
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
                ComboBox1.Items.Add(mdname(cir))
                EOF(2)
            Next
            et(9) = LineInput(2)
            et(9) = LineInput(2)
            mimo = Val(LineInput(2))
            FileClose(2)
            Area = mxarea
            tms = Val(extime(mimo))
            If tp(mimo) = "#FALSE#" Then
                ranges = Val(exrange(mimo))
                pool.Maximum = 100
                pool.Value = ranges
            Else
                exe = Val(exrange(mimo))
                pool.Maximum = Area
                pool.Value = exe
            End If
            NumericUpDown1.Value = tms
            Label6.Text = exrange(mimo)
            Label7.Text = Str(NumericUpDown1.Value)
            If doex(mimo) = "#FALSE#" Then
                doextreme = False
            Else
                doextreme = True
            End If
            ListBox1.Items.Clear()
            ListBox1.Items.Add(mdname(mimo) & "就绪")
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            Form5.Show()
        Else
            Exit Sub
        End If
        ComboBox1.SelectedIndex = mimo
        lock = False
    End Sub

    '加载配置
    Private Sub Pool_ValueChanged(sender As Object, e As EventArgs) Handles pool.ValueChanged
        If lock = True Then Exit Sub
        If dodata = False Then
            pool.Maximum = 100
            ranges = pool.Value
            Label6.Text = Str(ranges)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.Text = "自定义模式"
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            TextBox1.Text = ComboBox1.Text & tomode - 3
        Else
            pool.Maximum = Area
            exe = pool.Value
            Label6.Text = Str(exe)
            Label7.Text = Str(NumericUpDown1.Value)
            ComboBox1.Text = "数据驱动模式Personaize"
            ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
            TextBox1.Text = ComboBox1.Text & tomode - 3
        End If
    End Sub

    '微调范围
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer4.Enabled = True
    End Sub

    '预览效果
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        memo = False
        Timer3.Enabled = False
    End Sub

    '？？
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RadSaveFileDialog2.FileName = "抽取记录" & Date.Now
        If RadSaveFileDialog2.ShowDialog = DialogResult.OK Then
            Dim temp As Integer
            FileOpen(2, RadSaveFileDialog2.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, "抽取时间" & Date.Now)
            For temp = 1 To memories
                WriteLine(2, ListBox1.Items.Item(temp))
            Next
            WriteLine(2, "一共抽取了" & ListBox1.Items.Count - 1 & "次!")
            WriteLine(2, "使用的模式:" & ComboBox1.SelectedItem)
            FileClose(2)
        Else
            Exit Sub
        End If
        MsgBox("保存成功", vbOKOnly + vbInformation, "祝贺")
    End Sub

    '保存抽取记录

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim iris As Integer
        If temp2 = Nothing Then Exit Sub
        iris = temp2.Length
        If checked > iris - 1 Then
            checked = 1
            Timer2.Enabled = False
            Exit Sub
        End If
        checked += 1
        Label1.Text = temp2.Substring(0, checked)
        If checked > iris - 1 Then
            checked = 1
            Timer2.Enabled = False
        End If
    End Sub

    '动画效果主
    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            makesure = 1
        Else
            makesure = 0
        End If
    End Sub

    '确认对话框
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Date.Now
    End Sub

    '实时时间
    Public Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Call CoreProgram()
    End Sub
    '核心程序
    Public Sub CoreProgram()
        Dim datas, tmsreal As Integer, temp As String, ko As Object
        Dim selCell As DataGridViewCell
        tmsreal = tms - 1
        memories = 1 + memories
        RadProgressBar1.Value1 = 10
        If makesure = 0 Then
CX8:
            If doextreme = True Then
                MsgBox("都准备好了吗?" & Chr(13) & Chr(10) & "抽取模式:" & ComboBox1.Text & Chr(13) & Chr(10) & "抽取次数:" & Str(tms) & Chr(13) & Chr(10) & "警告!抽取后将无法重复,确定吗?", vbOKCancel + vbCritical, "确认对话框")
            Else
                MsgBox("都准备好了吗?" & Chr(13) & Chr(10) & "抽取模式:" & ComboBox1.Text & Chr(13) & Chr(10) & "抽取次数:" & Str(tms), vbOKCancel + vbQuestion, "确认对话框")
            End If
        End If
        '随机数模式
        If dodata = False Then
CX1:
            Randomize()
            datas = Rnd() * ranges
            If datas = 0 Then GoTo CX1
            temp2 = "抽出数值:" & Str(datas)
            temp = "第" & Str(memories) & "次:" & Str(datas)
            RadProgressBar1.Value1 = 50
            For circle = 1 To tmsreal
CX2:
                Randomize()
                datas = Rnd() * ranges
                If datas = 0 Then GoTo CX2
                temp2 = temp2 & "/" & Str(datas)
                temp = temp & "/" & Str(datas)
            Next
            RadProgressBar1.Value1 = 75
            ListBox1.Items.Add(temp)
            If doextreme = True Then
                ListBox1.Items.Add("极限模式抽取已结束!")
                RadButton1.Enabled = False
                RadProgressBar1.Value1 = 99
            End If
            Button7.Visible = True
            RadProgressBar1.Value1 = 100
            Timer2.Enabled = True
        ElseIf dodata = True Then
            '数据驱动模式1
            RadProgressBar1.Value1 = 30
            Dim repeat(6) As Integer, check, check2 As String, trigger As Integer
            '一次监测
            For trigger = 1 To exe + tmsreal Step 1
                selCell = DataGridView1(2, trigger)
                check2 = selCell.Value
                If selCell.Value = False Then
                    GoTo CX7
                End If
                trigger += 1
            Next
CX10:
            MsgBox("警告:找不到能被抽取的项!请检查数据驱动设定!" & Chr(13) & Chr(10) & "或检查是否能在不重复的前提下抽取完所有有效对象!", vbCritical + vbOKOnly, "错误")
            Exit Sub
CX7:
            If exe - trigger <= tmsreal Then GoTo CX10
            RadProgressBar1.Value1 = 50
            Randomize()
            datas = Rnd() * exe
            If datas >= Area - 2 Then GoTo CX10
            repeat(0) = datas
            selCell = DataGridView1(1, datas)
            temp = selCell.Value
            selCell = DataGridView1(2, datas)
            If selCell.Value = False Then
                temp2 = "抽取对象为:" & temp
                temp = "第" & Str(memories) & "次:" & temp
                RadProgressBar1.Value1 = 60
                For circle = 1 To tmsreal Step 1
CX6:
                    Randomize()
                    datas = Rnd() * exe
                    If datas = 0 Then GoTo CX6
                    selCell = DataGridView1(1, datas)
                    check = temp = selCell.Value
                    RadProgressBar1.Value1 = 70
                    selCell = DataGridView1(2, datas)
                    If selCell.Value = False Then
                        repeat(circle) = datas
                        Dim repeat2 As Integer
                        For repeat2 = 0 To circle - 1 Step 1
                            If repeat(repeat2) = datas Then GoTo CX6
                        Next
                    Else
                        GoTo CX6
                    End If
                    On Error GoTo CX10
                    selCell = DataGridView1(1, datas)
                    temp2 += "/" & selCell.Value
                    temp = temp & "/" & selCell.Value
                Next
                On Error GoTo CX10
                RadProgressBar1.Value1 = 90
                ListBox1.Items.Add(temp)
            Else
                GoTo CX7
            End If
            If doextreme = True Then
                ListBox1.Items.Add("极限模式抽取已结束!")
                RadButton1.Enabled = False
                RadProgressBar1.Value1 = 80
            End If
        End If
        RadProgressBar1.Value1 = 100
        Button7.Visible = True
        Timer2.Enabled = True

    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“Database1DataSet.Students”中。您可以根据需要移动或删除它。
        Me.StudentsTableAdapter.Fill(Me.Database1DataSet.Students)
        lock = True
        ToolStripStatusLabel2.Text = Date.Now
        Timer1.Enabled = True
        Dim cir As Integer, et(19), TypeN As String
        def = False
        ComboBox1.Items.Clear()
        FileOpen(2, "D:\RMConfig.ini", OpenMode.Input, OpenAccess.Read)
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
        et(14) = LineInput(2)
        ComboBox2.SelectedItem = LineInput(2)
        et(15) = LineInput(2)
        ComboBox4.SelectedItem = LineInput(2)
        For cir = 0 To tomode - 1
            EOF(2)
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
            ComboBox1.Items.Add(mdname(cir))
            EOF(2)
        Next
        et(9) = LineInput(2)
        et(9) = LineInput(2)
        mimo = LineInput(2)
        FileClose(2)
        Area = mxarea
        ulcheck = False
        ComboBox1.SelectedIndex = mimo
        lock = True
        'def = True
        'ComboBox1.SelectedIndex = 0
        tms = Val(extime(mimo))
        If tp(mimo) = "#FALSE#" Then
            ranges = Val(exrange(mimo))
            pool.Maximum = 100
            pool.Value = ranges
            dodata = False
            RadioButton4.Checked = True
            RadioButton5.Checked = False
            ToolStripLabel4.Enabled = False
        Else
            exe = Val(exrange(mimo))
            pool.Maximum = Area
            pool.Value = exe
            dodata = True
            RadioButton4.Checked = False
            RadioButton5.Checked = True
            ToolStripLabel4.Enabled = True
        End If
        NumericUpDown1.Value = tms
        Label6.Text = exrange(mimo)
        Label7.Text = Str(NumericUpDown1.Value)
        If doex(mimo) = "#FALSE#" Then
            doextreme = False
            RadToggleSwitch1.Value = False
            Label14.Visible = False
        Else
            doextreme = True
            RadToggleSwitch1.Value = True
            Label14.Visible = True
        End If
        ToolStripStatusLabel3.Text = "当前模式:" & ComboBox1.Text
        Call ColorSwitch(xc:=mimo)
        def = True
        lock = False
        Timer2.Enabled = True
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        ToolStripLabel1.LinkVisited = True
        ulcheck = True
        Me.Show()
    End Sub

    '初始化数据
End Class