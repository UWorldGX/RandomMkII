<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugForm
    Inherits System.Windows.Forms.Form

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
        Me.DebugOutput = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
        Me.DotsLineWaitingBarIndicatorElement1 = New Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement()
        Me.RadDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DebugOutput
        '
        Me.DebugOutput.BackColor = System.Drawing.Color.Transparent
        Me.DebugOutput.BackgroundImage = Global.RandomMaker.My.Resources.Resources.bton1
        Me.DebugOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DebugOutput.FlatAppearance.BorderSize = 0
        Me.DebugOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DebugOutput.ForeColor = System.Drawing.Color.White
        Me.DebugOutput.Location = New System.Drawing.Point(216, 198)
        Me.DebugOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DebugOutput.Name = "DebugOutput"
        Me.DebugOutput.Size = New System.Drawing.Size(93, 45)
        Me.DebugOutput.TabIndex = 0
        Me.DebugOutput.Text = "输出崩溃日志"
        Me.DebugOutput.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.InitialDirectory = "D:\"
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(65, 220)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(130, 24)
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
        Me.RadDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItem2, Me.RadMenuItem3})
        Me.RadDropDownButton1.Location = New System.Drawing.Point(76, 175)
        Me.RadDropDownButton1.Name = "RadDropDownButton1"
        Me.RadDropDownButton1.Size = New System.Drawing.Size(119, 39)
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
        Me.RadMenuItem2.Text = "RadMenuItem2"
        '
        'RadMenuItem3
        '
        Me.RadMenuItem3.Name = "RadMenuItem3"
        Me.RadMenuItem3.Text = "RadMenuItem3"
        '
        'DebugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMaker.My.Resources.Resources.桥梁邮件Ｈ
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(333, 256)
        Me.Controls.Add(Me.RadDropDownButton1)
        Me.Controls.Add(Me.RadWaitingBar1)
        Me.Controls.Add(Me.DebugOutput)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DebugForm"
        Me.Text = "Debug页面"
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DebugOutput As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents DotsLineWaitingBarIndicatorElement1 As Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement
    Friend WithEvents RadDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem3 As Telerik.WinControls.UI.RadMenuItem
End Class
