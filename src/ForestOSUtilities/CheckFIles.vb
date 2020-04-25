Public Class CheckFIles
    Public Shared Sub CheckForFolders()
        Dim strSystemDir As String = Environment.GetEnvironmentVariable("SystemDrive")
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS") Then
            MkDir(strSystemDir & "\Forest-OS")
            MkDir(strSystemDir & "\Forest-OS\User")

        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Standard") Then
            MkDir(strSystemDir & "\Forest-OS\User\Standard")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Admin") Then
            MkDir(strSystemDir & "\Forest-OS\User\Admin")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Power User") Then
            MkDir(strSystemDir & "\Forest-OS\User\Power User")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Student") Then
            MkDir(strSystemDir & "\Forest-OS\User\Student")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Teacher") Then
            MkDir(strSystemDir & "\Forest-OS\User\Teacher")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Enterprise") Then
            MkDir(strSystemDir & "\Forest-OS\User\Enterprise")
        End If
    End Sub
End Class
