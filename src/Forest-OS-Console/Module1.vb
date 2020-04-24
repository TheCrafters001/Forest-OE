Imports ForestOSUtilities

Module Module1

    Sub Main()
        Console.WriteLine("====================")
        Console.WriteLine("= Create User      =")
        Console.WriteLine("====================")
        Console.Write("Enter Username: ")
        Dim user As String = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Enter Password: ")
        Dim pass As String = Console.ReadLine()
        ForestOSUtilities.Class1.CreateUser(pass, user)
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Username: " & user & " && Password: " & pass)
        Main()
    End Sub

End Module
