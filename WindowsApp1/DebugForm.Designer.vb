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
        Me.DebugOutput = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
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
        Me.DebugOutput.Location = New System.Drawing.Point(216, 185)
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
        'DebugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMaker.My.Resources.Resources.桥梁邮件Ｈ
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(333, 256)
        Me.Controls.Add(Me.DebugOutput)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DebugForm"
        Me.Text = "DebugForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DebugOutput As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
