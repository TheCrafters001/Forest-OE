Imports ForestOSUtilities

Public Class Background
    Private Sub Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForestOSUtilities.CheckFIles.CheckForFolders()
        ExplorerStatusChanger.KillExplorer()
        If My.Settings.FirstTime = True Then
            Setup_Page1.Show()
        ElseIf My.Settings.FirstTime = False Then
            Login.Show()
        End If

    End Sub
End Class