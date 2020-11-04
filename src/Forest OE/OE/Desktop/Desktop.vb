Imports ForestOEUtilities

Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        QuickLaunchList.Items.Clear()
        BrowserFinder.Finder()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time_lbl.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub shutdownMenuItem_Desktop_Click(sender As Object, e As EventArgs) Handles shutdownMenuItem_Desktop.Click
        ShutdownDialog.Show()
    End Sub

    Private Sub quickLaunch_btn_Click(sender As Object, e As EventArgs) Handles quickLaunch_btn.Click
        If QuickLaunchList.SelectedItem = "Google Chrome" Then
            BrowserFinder.Execute("chrome")
        ElseIf QuickLaunchList.SelectedItem = "FireFox" Then
            BrowserFinder.Execute("firefox")
        ElseIf QuickLaunchList.SelectedItem = "Edge" Then
            BrowserFinder.Execute("edge")
        ElseIf QuickLaunchList.SelectedItem = "Internet Explorer" Then
            BrowserFinder.Execute("ie")
        End If
    End Sub
End Class