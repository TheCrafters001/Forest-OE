Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.IO.File
Imports Forest_OS_ConsoleUtilities.ConsoleUtil

Module Module1

    Sub Main()
        StartupText()
        Prompt()
    End Sub

    Sub Prompt()
        Console.Write("Enter a Command: ")
        Dim command As String = Console.ReadLine()
        If command = "help" Then
            Help()
            Prompt()
        ElseIf command = "show" Then
            shownoarg()
            Prompt()
        ElseIf command = "clear" Then
            Console.Clear()
            Prompt()
        ElseIf command = "cls" Then
            Console.Clear()
            Prompt()
        ElseIf command = "license" Then
            License()
            Prompt()
        ElseIf command = "show w" Then
            ShowW()
            Prompt()
        ElseIf command = "show c" Then
            ShowC()
            Prompt()
        ElseIf command = "userc" Then
            CreateUser()
            Prompt()
        ElseIf command = "exit" Then
            ExitConsole()
        ElseIf command = "test" Then 'This command is used to test whatever i'm working on.
            'NoCodeAtTheMoment
            Prompt()
        ElseIf command = "cmd" Then
            WinCMD()
            Prompt()
        ElseIf command = "explorer" Then
            WinExplorer()
            Prompt()
        ElseIf command = "chkusr" Then
            chkusr()
            Prompt()
        ElseIf command = "title" Then
            title()
            Prompt()
        Else
            Console.WriteLine("The command you have entered '" & command & "' does not exist.")
            Console.WriteLine("")
            Prompt()
        End If
    End Sub

End Module
