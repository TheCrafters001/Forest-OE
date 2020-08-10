Public Class ConsoleUtil
    Public Shared Sub StartupText()
        Console.Title = "Forest-OE Console"
        Console.WriteLine("=====================================")
        Console.WriteLine("= Forest-OE Console                 =")
        Console.WriteLine("= Base code by TheCrafters001       =")
        Console.WriteLine("= Copyright (C) TheCrafters001 2020 =")
        Console.WriteLine("=====================================")
        Console.WriteLine("Forest-OE Console Copyright (C) 2020 TheCrafters001")
        Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.")
        Console.WriteLine("This is free software, and you are welcome to redistribute it")
        Console.WriteLine("under certain conditions; type `show c' for details.")
        Console.WriteLine("")
        Console.WriteLine("")
        '
        ' All the text above displays when the console is ran.
        ' This should not be removed, as it contains important information.
        '
    End Sub
#Region "User Management"
    Public Shared Sub CreateUser()
        Console.WriteLine("====================")
        Console.WriteLine("= Create User      =")
        Console.WriteLine("====================")
        Console.Write("Enter Username: ")
        Dim user As String = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("When entering your password, the text will appear invisible, this is normal, and not a bug.")
        Console.WriteLine("")
        Console.Write("Enter Password: ")
        Dim password As String = Nothing

        While True ' This hides the password while the user is typing.
            Dim key = System.Console.ReadKey(True)
            If key.Key = ConsoleKey.Enter Then Exit While
            password += key.KeyChar
        End While

        Console.WriteLine("")
        Console.Write("Select a user type (Admin, Standard, Power User, Student, Teacher, or Enterprise): ")
        Dim type As String = Console.ReadLine()
        Console.WriteLine("")
        Try
            ForestOEUtilities.UserShell.CreateUser(password.ToString, user.ToString, type.ToString)
        Catch ex As Exception
            Console.WriteLine("An error occured.")
            Console.WriteLine(ex)
            Console.WriteLine("If it is an ""Path/File Access"" error, then the user account may already exist.")
            Debug.WriteLine(ex)
        End Try
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Attempted to create user: ")
        Console.WriteLine("Username: " & user & " && Password: ********* && Usertype: " & type)
    End Sub
#End Region
#Region "Info"
    Public Shared Sub Help()
        Console.WriteLine("========")
        Console.WriteLine("= Help =")
        Console.WriteLine("========")
        Console.WriteLine("help ------ pulls up this menu")
        Console.WriteLine("title ----- changes title of console")
        Console.WriteLine("clear ----- clears console")
        Console.WriteLine("cmd ------- opens Windows command prompt")
        Console.WriteLine("explorer -- opens Windows File Explorer, may break Forest-OE")
        Console.WriteLine("license --- show the license")
        Console.WriteLine("show w ---- shows warranty info")
        Console.WriteLine("show c ---- shows redistribution info")
        Console.WriteLine("userc ----- create user")
        Console.WriteLine("chkusr ---- check user files for missing folders; will not modify any existing files")
        Console.WriteLine("exit ------ closes console")
        Console.WriteLine("")
        '
        ' All the code above displays help information.
        ' This should be updated as soon as new commands are added,
        ' old commands are removed, or if there is a change to a command.
        '
    End Sub
    Public Shared Sub ShowNoArg()
        Console.WriteLine("Forest-OE Console Copyright (C) 2020 TheCrafters001")
        Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.")
        Console.WriteLine("This is free software, and you are welcome to redistribute it")
        Console.WriteLine("under certain conditions; type `show c' for details.")
        Console.WriteLine("")
        '
        ' This should be displayed when the user types "show" without
        ' any arguments (like c or w)
        '
    End Sub
    Public Shared Sub ShowW()
        Console.WriteLine("This program is distributed in the hope that it will be useful,")
        Console.WriteLine("but WITHOUT ANY WARRANTY; without even the implied warranty of")
        Console.WriteLine("MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the")
        Console.WriteLine("GNU General Public License for more details.")
        Console.WriteLine("")
        '
        ' DO NOT REMOVE
        '
    End Sub
    Public Shared Sub ShowC()
        Console.WriteLine("This program is free software: you can redistribute it and/or modify")
        Console.WriteLine("it under the terms of the GNU General Public License as published by")
        Console.WriteLine("the Free Software Foundation, either version 3 of the License, or")
        Console.WriteLine("(at your option) any later version.")
        Console.WriteLine("")
        '
        ' DO NOT REMOVE
        '
    End Sub

    Public Shared Sub License()
        Console.WriteLine("A Program to help make the Windows experience better.")
        Console.WriteLine("Copyright (C) 2020 TheCrafters001")
        Console.WriteLine("")
        Console.WriteLine("This program is free software: you can redistribute it and/or modify")
        Console.WriteLine("it under the terms of the GNU General Public License as published by")
        Console.WriteLine("the Free Software Foundation, either version 3 of the License, or")
        Console.WriteLine("(at your option) any later version.")
        Console.WriteLine("")
        Console.WriteLine("This program is distributed in the hope that it will be useful,")
        Console.WriteLine("but WITHOUT ANY WARRANTY; without even the implied warranty of")
        Console.WriteLine("MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the")
        Console.WriteLine("GNU General Public License for more details.")
        Console.WriteLine("")
        Console.WriteLine("You should have received a copy of the GNU General Public License")
        Console.WriteLine("along with this program.  If not, see <https://www.gnu.org/licenses/>.")
        Console.WriteLine("")
        '
        ' Display full license. DO NOT REMOVE
        '
    End Sub
#End Region
#Region "File Checker"
    Public Shared Sub chkusr()
        ForestOEUtilities.CheckFiles.CheckForFolders()
    End Sub
#End Region
#Region "Misc"
    Public Shared Sub title()
        Dim title As String
        Dim prompt As String
        Console.WriteLine("")
        Console.Write("Enter title: ")
        prompt = Console.ReadLine()
        title = prompt
        If title = "" Then
            title = "Forest-OE Console"
        End If
        Console.Title = title
    End Sub
    Public Shared Sub ExitConsole()

        ' Ends Session
    End Sub
    Public Shared Sub WinExplorer()
        Console.WriteLine("Opening Windows File Explorer....")
        Console.WriteLine("This May Break Forest-OE")
        Process.Start("explorer.exe")
    End Sub
    Public Shared Sub WinCMD()
        Console.WriteLine("Opening Windows CMD...")
        Process.Start("cmd.exe")
    End Sub
#End Region
End Class
