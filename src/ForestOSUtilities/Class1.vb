Imports System.IO
Imports System.IO.File

Public Class Class1
    Public Shared Sub HashPassword(ByVal Password As String, ByVal UserName As String)
        Try
            Dim path As String
            path = "C:\Forest-OS\User\"
            If Directory.Exists(Path) Then
                Console.WriteLine("That path exists already.")
                Return
            End If
            Dim di As DirectoryInfo = Directory.CreateDirectory(path)
            Dim username_Write As New System.IO.StreamWriter(path & UserName & "username.dll")
            username_Write.Write(UserName)
            username_Write.Close()
            Dim password_Write As New System.IO.StreamWriter(path & UserName & "password.dll")

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
        Catch ex As Exception

        End Try
    End Sub




End Class
