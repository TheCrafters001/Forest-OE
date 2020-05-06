Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.IO.File

Public Class Class1
    Public Shared Sub CreateUser(ByVal PasswordInput As String, ByVal UsernameInput As String, ByVal Usertype As String)
        Dim path As String
        path = "C:\Forest-OS\User\"
        'If Directory.Exists(path) Then
        'Console.WriteLine("That path exists already.")
        'Return
        'End If
        MkDir(path & Usertype & "\" & UsernameInput)
        Dim username As New System.IO.StreamWriter(path & Usertype & "\" & UsernameInput & "\" & "username.dll")
        username.Write(UsernameInput)
        username.Close()

        ' Load all security data.
        Dim sSourceData As String
        Dim tmpSource() As Byte
        Dim tmpHash() As Byte
        sSourceData = "MySourceData"
        'Create a byte array from source data.
        tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData)
        'Compute hash based on source data.
        tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpSource)


        Dim password As New System.IO.StreamWriter(path & Usertype & "\" & UsernameInput & "\" & "password.dll")
        password.Write(ByteArrayToString(tmpHash))
        password.Close()
    End Sub
    Public Shared Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function
End Class