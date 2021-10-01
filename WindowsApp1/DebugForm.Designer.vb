<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugForm
    Inherits Telerik.WinControls.UI.RadTabbedForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DebugForm))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
        Me.DotsLineWaitingBarIndicatorElement1 = New Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement()
        Me.RadDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadTabbedFormControl1 = New Telerik.WinControls.UI.RadTabbedFormControl()
        Me.RadTabbedFormControlTab1 = New Telerik.WinControls.UI.RadTabbedFormControlTab()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
        Me.Process1 = New System.Diagnostics.Process()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTabbedFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadTabbedFormControl1.SuspendLayout()
        Me.RadTabbedFormControlTab1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.InitialDirectory = "D:\"
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(212, 261)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(175, 24)
        Me.RadWaitingBar1.TabIndex = 1
        Me.RadWaitingBar1.Text = "RadWaitingBar1"
        Me.RadWaitingBar1.WaitingIndicators.Add(Me.DotsLineWaitingBarIndicatorElement1)
        Me.RadWaitingBar1.WaitingIndicatorSize = New System.Drawing.Size(100, 14)
        Me.RadWaitingBar1.WaitingSpeed = 80
        Me.RadWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine
        '
        'DotsLineWaitingBarIndicatorElement1
        '
        Me.DotsLineWaitingBarIndicatorElement1.Name = "DotsLineWaitingBarIndicatorElement1"
        '
        'RadDropDownButton1
        '
        Me.RadDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItem2})
        Me.RadDropDownButton1.Location = New System.Drawing.Point(393, 252)
        Me.RadDropDownButton1.Name = "RadDropDownButton1"
        Me.RadDropDownButton1.Size = New System.Drawing.Size(119, 45)
        Me.RadDropDownButton1.TabIndex = 3
        Me.RadDropDownButton1.Text = "调试"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "输出10000次"
        '
        'RadMenuItem2
        '
        Me.RadMenuItem2.Name = "RadMenuItem2"
        Me.RadMenuItem2.Text = "测试崩溃日志"
        '
        'RadTabbedFormControl1
        '
        Me.RadTabbedFormControl1.Controls.Add(Me.RadTabbedFormControlTab1)
        Me.RadTabbedFormControl1.LeftItems.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1})
        Me.RadTabbedFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.RadTabbedFormControl1.Name = "RadTabbedFormControl1"
        Me.RadTabbedFormControl1.SelectedTab = Me.RadTabbedFormControlTab1
        Me.RadTabbedFormControl1.ShowNewTabButton = False
        Me.RadTabbedFormControl1.Size = New System.Drawing.Size(528, 355)
        Me.RadTabbedFormControl1.TabIndex = 4
        Me.RadTabbedFormControl1.Text = "Debug页面"
        '
        'RadTabbedFormControlTab1
        '
        Me.RadTabbedFormControlTab1.BackColor = System.Drawing.Color.Transparent
        Me.RadTabbedFormControlTab1.Controls.Add(Me.LinkLabel1)
        Me.RadTabbedFormControlTab1.Controls.Add(Me.Label1)
        Me.RadTabbedFormControlTab1.Controls.Add(Me.RadDropDownButton1)
        Me.RadTabbedFormControlTab1.Controls.Add(Me.RadWaitingBar1)
        Me.RadTabbedFormControlTab1.Location = New System.Drawing.Point(1, 37)
        Me.RadTabbedFormControlTab1.Name = "RadTabbedFormControlTab1"
        Me.RadTabbedFormControlTab1.Size = New System.Drawing.Size(526, 317)
        Me.RadTabbedFormControlTab1.Text = "常规调试"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(255, 108)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(242, 15)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/UWorldGX/RandomMkII"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(103, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 63)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "这里用于调试RandomMaker的各项功能。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "在开始之前确保你知道你在做什么!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如有问题，请询问"
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.ShowBorder = False
        Me.RadButtonElement1.StretchHorizontally = False
        Me.RadButtonElement1.StretchVertically = False
        Me.RadButtonElement1.Text = "调试窗口"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'DebugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMaker.My.Resources.Resources.桥梁邮件Ｈ
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(528, 355)
        Me.Controls.Add(Me.RadTabbedFormControl1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DebugForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.Text = "Debug页面"
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTabbedFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadTabbedFormControl1.ResumeLayout(False)
        Me.RadTabbedFormControlTab1.ResumeLayout(False)
        Me.RadTabbedFormControlTab1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents DotsLineWaitingBarIndicatorElement1 As Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement
    Friend WithEvents RadDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadTabbedFormControl1 As Telerik.WinControls.UI.RadTabbedFormControl
    Friend WithEvents RadTabbedFormControlTab1 As Telerik.WinControls.UI.RadTabbedFormControlTab
    Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Process1 As Process
End Class
