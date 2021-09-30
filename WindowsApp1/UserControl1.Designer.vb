<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Me.RadToggleSwitch1 = New Telerik.WinControls.UI.RadToggleSwitch()
        CType(Me.RadToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadToggleSwitch1
        '
        Me.RadToggleSwitch1.Location = New System.Drawing.Point(21, 68)
        Me.RadToggleSwitch1.Name = "RadToggleSwitch1"
        Me.RadToggleSwitch1.Size = New System.Drawing.Size(101, 31)
        Me.RadToggleSwitch1.TabIndex = 0
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RadToggleSwitch1)
        Me.Name = "UserControl1"
        CType(Me.RadToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadToggleSwitch1 As Telerik.WinControls.UI.RadToggleSwitch
End Class
