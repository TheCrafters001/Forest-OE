Public Class Restart
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(2)
        If ProgressBar2.Value = 4 Then
            Me.Text = "Restarting..."
            Label1.Text = "Logging Off..."
        End If
        If ProgressBar2.Value = 10 Then
            Label1.Text = "Stopping Desktop Services..."
        End If
        If ProgressBar2.Value = 20 Then
            My.Settings.Usertype = ""
            My.Settings.Username = ""
            My.Settings.Save()
            Label1.Text = "Ending User Management Services..."
        End If
        If ProgressBar2.Value = 30 Then
            Label1.Text = "Preparing to Restarting Computer..."
        End If
        If ProgressBar2.Value = 100 Then
            Label1.Text = "Restarting Computer..."
            ForestOSUtilities.ExplorerStatusChanger.Restart()
            End
        End If
    End Sub

    Private Sub Restart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Forest_OS_Shutdown, AudioPlayMode.Background)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 50
        Timer1.Start()
        'Close All Applications of Forest-OS
        Dim remainOpenForms As New HashSet(Of String)
        remainOpenForms.Add("Restart")
        remainOpenForms.Add("Background")

        ' Create collection of forms to be closed
        Dim formsToClose As New List(Of Form)
        For Each form As Form In Application.OpenForms
            If remainOpenForms.Contains(form.Text) = False Then formsToClose.Add(form)
        Next

        For Each form As Form In formsToClose
            form.Close()
        Next
    End Sub
End Class