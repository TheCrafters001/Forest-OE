Imports ForestOSUtilities

Public Class Background
    Private Sub Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExplorerStatusChanger.KillExplorer()
        Login.Show()
    End Sub
End Class