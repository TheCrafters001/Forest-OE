Imports ForestOSUtilities.ExplorerStatusChanger
Public Class ExitToWindows
    Private Sub ExitToWindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Close All Applications of Forest-OS
        Dim remainOpenForms As New HashSet(Of String)
        remainOpenForms.Add("Exit to Windows")
        remainOpenForms.Add("Background")

        Timer1.Start()

        ' Create collection of forms to be closed
        Dim formsToClose As New List(Of Form)
        For Each form As Form In Application.OpenForms
            If remainOpenForms.Contains(form.Text) = False Then formsToClose.Add(form)
        Next

        For Each form As Form In formsToClose
            form.Close()
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(5)
        If ProgressBar2.Value = 5 Then
            Me.Text = "Logging out..."
            Label1.Text = "Preparing to logout..."
        End If
        If ProgressBar2.Value = 10 Then
            Label1.Text = "Logging out of Forest-OS..."
            My.Settings.Username = ""
            My.Settings.Usertype = ""
            My.Settings.Save()
        End If
        If ProgressBar2.Value = 15 Then
            Label1.Text = "Playing Logoff Sound..."
            My.Computer.Audio.Play(My.Resources.Forest_OS_Logout, AudioPlayMode.WaitToComplete)
        End If
        If ProgressBar2.Value = 20 Then
            Label1.Text = "Preparing to Shutdown Forest-OS..."
        End If
        If ProgressBar2.Value = 100 Then
            Label1.Text = "Exiting to Windows..."
            StartExplorer()
            End
        End If
    End Sub
End Class