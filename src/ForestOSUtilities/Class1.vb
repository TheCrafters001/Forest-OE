Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.IO.File

Public Class Class1
    Public Shared Sub CreateUser(ByVal Password As String, ByVal UserName As String, Usertype As String)
        Try
            Dim path As String
            path = "C:\Forest-OS\User\"
            If Directory.Exists(path) Then
                Console.WriteLine("That path exists already.")
                Return
            End If
            Dim di As DirectoryInfo = Directory.CreateDirectory(path)
            Dim username_Write As New System.IO.StreamWriter(path & Usertype & "\" & UserName & "\username.dll")
            username_Write.Write(UserName)
            username_Write.Close()
            Dim password_Write As New System.IO.StreamWriter(path & Usertype & "\" & UserName & "\password.dll")

            'Generate Hash
            Dim strToHash As String
            strToHash = Password
            Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

            bytesToHash = md5Obj.ComputeHash(bytesToHash)

            Dim strResult As String = ""

            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next



            password_Write.Write(strResult)
            password_Write.Close()
            Console.WriteLine("Created a user called: " & UserName & " that has the account type: " & Usertype)
            Return
        Catch ex As Exception
            Console.WriteLine("Error")
            Debug.WriteLine(ex.Message & "error")
        End Try
    End Sub
End Class