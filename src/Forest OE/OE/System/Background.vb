﻿Imports ForestOEUtilities

Public Class Background
    Private Sub Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ForestOEUtilities.CheckFiles.CheckForFolders()
        ExplorerStatusChanger.KillExplorer()
        Login.Show()
    End Sub
End Class