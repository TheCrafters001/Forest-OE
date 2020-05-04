Imports ForestOSUtilities
Public Class CrashScreen
    Private Sub CrashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Beep()
        Label3.Text = "Time of Crash: " & TimeOfDay
        ForestOSUtilities.ExplorerStatusChanger.StartExplorer()


        'Close All Applications of Forest-OS
        Login.Close()
        Background.Close()
    End Sub
End Class