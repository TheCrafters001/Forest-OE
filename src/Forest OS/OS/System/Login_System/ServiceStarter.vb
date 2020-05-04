Public Class ServiceStarter
    Private Sub ServiceStarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(5)
        If ProgressBar2.Value = 20 Then
            Me.Text = "Logging in..."
            Label1.Text = "Preparing to login..."
        End If
        If ProgressBar2.Value = 40 Then
            Label1.Text = "Starting Desktop Services..."
        End If
        If ProgressBar2.Value = 60 Then
            Label1.Text = "Preparing Desktop..."
        End If
        If ProgressBar2.Value = 100 Then
            Desktop.Show()
            Me.Close()
        End If
    End Sub
End Class