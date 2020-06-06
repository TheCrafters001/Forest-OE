Imports ForestOSUtilities.ExplorerStatusChanger
Public Class ExitToWindows
    Private Sub ExitToWindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Close All Applications of Forest-OS
        Dim remainOpenForms As New HashSet(Of String)
        remainOpenForms.Add("Exit To Windows")

        ' Create collection of forms to be closed
        Dim formsToClose As New List(Of Form)
        For Each form As Form In Application.OpenForms
            If remainOpenForms.Contains(form.Text) = False Then formsToClose.Add(form)
        Next

        For Each form As Form In formsToClose
            form.Close()
        Next

        My.Settings.Username = ""
        My.Settings.Usertype = ""
        My.Settings.Save()
        StartExplorer()
        My.Computer.Audio.Play(My.Resources.Forest_OS_Logout, AudioPlayMode.WaitToComplete)
        End
    End Sub
End Class