Imports ForestOSUtilities
Public Class CrashScreen
    Private Sub CrashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Beep()
        Label3.Text = "Time of Crash: " & TimeOfDay
        ForestOSUtilities.ExplorerStatusChanger.StartExplorer()


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
    End Sub
End Class