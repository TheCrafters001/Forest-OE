Imports ForestOEUtilities
Public Class CrashScreen
    Private Sub CrashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Beep()
        My.Computer.Audio.Play(My.Resources.Forest_OS_Critical_Stop, AudioPlayMode.Background)
        Label3.Text = "Time of Crash: " & TimeOfDay
        ForestOEUtilities.ExplorerStatusChanger.StartExplorer()


        'Close All Applications of Forest-OS
        Dim remainOpenForms As New HashSet(Of String)
        remainOpenForms.Add("Oh no!")

        ' Create collection of forms to be closed
        Dim formsToClose As New List(Of Form)
        For Each form As Form In Application.OpenForms
            If remainOpenForms.Contains(form.Text) = False Then formsToClose.Add(form)
        Next

        For Each form As Form In formsToClose
            form.Close()
        Next
        My.Settings.Usertype = ""
        My.Settings.Username = ""
        My.Settings.Save()
    End Sub
End Class