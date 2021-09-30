Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Form1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackgroundImage = My.Resources.PG1
        Timer2.Enabled = True
        Timer1.Enabled = False
        Label1.Text = "Now Loading."
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BackgroundImage = My.Resources.PG3
        Timer3.Enabled = True
        Timer2.Enabled = False
        Label1.Text = "Now Loading.."
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.BackgroundImage = My.Resources.PG2
        Timer4.Enabled = True
        Timer3.Enabled = False
        Label1.Text = "Now Loading..."
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label1.Text = "Done."
        Form1.Show()
        Me.Close()
    End Sub

End Class