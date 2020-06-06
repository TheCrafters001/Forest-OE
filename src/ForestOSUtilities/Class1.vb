Imports System.Security.Cryptography
Imports System.IO

Public NotInheritable Class Class1
    Private TripleDes As TripleDESCryptoServiceProvider ' 3DES cryptographic service provider
    Public Shared Sub CreateUser(ByVal PasswordInput As String, ByVal UsernameInput As String, ByVal Usertype As String)
        If Usertype = "Standard" Or Usertype = "Admin" Or Usertype = "Power User" Or Usertype = "Student" Or Usertype = "Teacher" Or Usertype = "Enterprise" Then
            Dim username As String = UsernameInput
            Dim password As String = PasswordInput

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(username)

            MkDir(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & Usertype & "\" & username)
            My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & Usertype & "\" & username & "\username.dll", username, False)
            My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & Usertype & "\" & username & "\password.dll", cipherText, False)
            Console.WriteLine("User Created.")
        Else
            Console.WriteLine("The user type you have typed, '" + Usertype + "', does not exist in Forest-OS.")
            Console.WriteLine("It may be a typo, if so, please check to see if you typed in the user type correctly.")
        End If
    End Sub

End Class