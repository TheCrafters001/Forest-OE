﻿Public Class CheckFiles
    Public Shared Sub CheckForFolders()
        Console.WriteLine("===========================")
        Console.WriteLine("= Check User For Folders  =")
        Console.WriteLine("===========================")
        Console.WriteLine("= This may take a minute  =")
        Console.WriteLine("= Please Wait...          =")
        Console.WriteLine("===========================")
        Dim strSystemDir As String = Environment.GetEnvironmentVariable("SystemDrive")
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS") Then
            MkDir(strSystemDir & "\Forest-OS")
            MkDir(strSystemDir & "\Forest-OS\User")
            Console.WriteLine("Forest-OS Main Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Standard") Then
            MkDir(strSystemDir & "\Forest-OS\User\Standard")
            Console.WriteLine("Forest-OS Standard Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Admin") Then
            MkDir(strSystemDir & "\Forest-OS\User\Admin")
            Console.WriteLine("Forest-OS Admin Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Power User") Then
            MkDir(strSystemDir & "\Forest-OS\User\Power User")
            Console.WriteLine("Forest-OS Power Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Student") Then
            MkDir(strSystemDir & "\Forest-OS\User\Student")
            Console.WriteLine("Forest-OS Student Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Teacher") Then
            MkDir(strSystemDir & "\Forest-OS\User\Teacher")
            Console.WriteLine("Forest-OS Teacher Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OS\User\Enterprise") Then
            MkDir(strSystemDir & "\Forest-OS\User\Enterprise")
            Console.WriteLine("Forest-OS Enterprise Users Folder(s) created.")
        End If
        Console.WriteLine("===========================")
        Console.WriteLine("= Check User For Folders  =")
        Console.WriteLine("===========================")
        Console.WriteLine("= Check Complete          =")
        Console.WriteLine("=                         =")
        Console.WriteLine("===========================")
    End Sub
End Class