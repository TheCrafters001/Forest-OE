Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.IO.File

Module Module1

    Sub Main()
        Console.WriteLine("=====================================")
        Console.WriteLine("= Forest-OS Console                 =")
        Console.WriteLine("= Base code by TheCrafters001       =")
        Console.WriteLine("= Copyright (C) TheCrafters001 2020 =")
        Console.WriteLine("=====================================")
        Console.WriteLine("Forest-OS-Console Copyright (C) 2020 TheCrafters001")
        Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.")
        Console.WriteLine("This is free software, and you are welcome to redistribute it")
        Console.WriteLine("under certain conditions; type `show c' for details.")
        Console.WriteLine("")
        Console.WriteLine("")
        Prompt()
    End Sub

    Sub Prompt()
        Console.Write("Enter a Command: ")
        Dim command As String = Console.ReadLine()
        If command = "help" Then
            Console.WriteLine("========")
            Console.WriteLine("= Help =")
            Console.WriteLine("========")
            Console.WriteLine("help ------ pulls up this menu")
            Console.WriteLine("clear ----- clears console")
            Console.WriteLine("license --- show the license")
            Console.WriteLine("show w ---- shows warranty info")
            Console.WriteLine("show c ---- shows redistribution info")
            Console.WriteLine("userc ----- create user")
            Console.WriteLine("")
            Prompt()
        ElseIf command = "show" Then
            Console.WriteLine("Forest-OS-Console Copyright (C) 2020 TheCrafters001")
            Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.")
            Console.WriteLine("This is free software, and you are welcome to redistribute it")
            Console.WriteLine("under certain conditions; type `show c' for details.")
            Console.WriteLine("")
            Prompt()
        ElseIf command = "clear" Then
            Console.Clear()
            Prompt()
        ElseIf command = "license" Then
            Console.WriteLine("A progam to help make the Windows Experince better.")
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
            Prompt()
        ElseIf command = "show w" Then
            Console.WriteLine("This program is distributed in the hope that it will be useful,")
            Console.WriteLine("but WITHOUT ANY WARRANTY; without even the implied warranty of")
            Console.WriteLine("MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the")
            Console.WriteLine("GNU General Public License for more details.")
            Console.WriteLine("")
            Prompt()
        ElseIf command = "show c" Then
            Console.WriteLine("This program is free software: you can redistribute it and/or modify")
            Console.WriteLine("it under the terms of the GNU General Public License as published by")
            Console.WriteLine("the Free Software Foundation, either version 3 of the License, or")
            Console.WriteLine("(at your option) any later version.")
            Console.WriteLine("")
            Prompt()
        ElseIf command = "userc" Then
            Console.WriteLine("====================")
            Console.WriteLine("= Create User      =")
            Console.WriteLine("====================")
            Console.Write("Enter Username: ")
            Dim user As String = Console.ReadLine()
            Console.WriteLine("")
            Console.Write("Enter Password: ")
            Dim pass As String = Console.ReadLine()
            Console.WriteLine("")
            Console.Write("Select a user type (Admin, Standard, Power User, Student, Teacher, or Enterprise): ")
            Dim type As String = Console.ReadLine()
            Console.WriteLine("")
            ForestOSUtilities.Class1.CreateUser(pass.ToString, user.ToString, type.ToString)
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("Username: " & user & " && Password: ********* && Usertype: " & type)
            Main()
            Prompt()
        Else
            Console.WriteLine("The command you have entered '" & command & "' does not exist.")
            Console.WriteLine("")
            Prompt()
        End If
    End Sub

End Module
