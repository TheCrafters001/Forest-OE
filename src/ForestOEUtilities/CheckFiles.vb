Public Class CheckFiles
    Public Shared Sub CheckForFolders()
        Console.WriteLine("===========================")
        Console.WriteLine("= Check User For Folders  =")
        Console.WriteLine("===========================")
        Console.WriteLine("= This may take a minute  =")
        Console.WriteLine("= Please Wait...          =")
        Console.WriteLine("===========================")
        Dim strSystemDir As String = Environment.GetEnvironmentVariable("SystemDrive")
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE") Then
            MkDir(strSystemDir & "\Forest-OE")
            MkDir(strSystemDir & "\Forest-OE\User")
            Console.WriteLine("Forest-OE Main Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE\User\Standard") Then
            MkDir(strSystemDir & "\Forest-OE\User\Standard")
            Console.WriteLine("Forest-OE Standard Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE\User\Admin") Then
            MkDir(strSystemDir & "\Forest-OE\User\Admin")
            Console.WriteLine("Forest-OE Admin Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE\User\Power User") Then
            MkDir(strSystemDir & "\Forest-OE\User\Power User")
            Console.WriteLine("Forest-OE Power Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE\User\Student") Then
            MkDir(strSystemDir & "\Forest-OE\User\Student")
            Console.WriteLine("Forest-OE Student Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE\User\Teacher") Then
            MkDir(strSystemDir & "\Forest-OE\User\Teacher")
            Console.WriteLine("Forest-OE Teacher Users Folder(s) created.")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(strSystemDir & "\Forest-OE\User\Enterprise") Then
            MkDir(strSystemDir & "\Forest-OE\User\Enterprise")
            Console.WriteLine("Forest-OE Enterprise Users Folder(s) created.")
        End If
        Console.WriteLine("===========================")
        Console.WriteLine("= Check User For Folders  =")
        Console.WriteLine("===========================")
        Console.WriteLine("= Check Complete          =")
        Console.WriteLine("=                         =")
        Console.WriteLine("===========================")
    End Sub
End Class
