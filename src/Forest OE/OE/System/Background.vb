Imports ForestOEUtilities

Public Class Background
    Private Sub Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Background Launched")
        ForestOEUtilities.CheckFiles.CheckForFolders()
        ExplorerStatusChanger.KillExplorer()
        Debug.WriteLine("Showing Login Screen")
        Login.Show()
    End Sub
End Class