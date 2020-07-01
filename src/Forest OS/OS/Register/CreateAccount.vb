Imports System
Imports System.Security
Imports System.IO
Imports ForestOSUtilities
Imports System.Security.Cryptography
Imports System.Text
' Security Imports above.


Public Class CreateAccount
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            If UserType.Text = "" Then
                MessageBox.Show("Cannot create user, no user type selected.")
            ElseIf Not UserType.Text = "" Then
                Dim username As String = UsernameTextBox.Text
                Dim password As String = PasswordTextBox.Text

                Dim wrapper As New Simple3Des(password)
                Dim cipherText As String = wrapper.EncryptData(username)

                MkDir(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & username)
                My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & username & "\username.dll", username, False)
                My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & username & "\password.dll", cipherText, False)
                My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & username & "\settings.dll", "Default", False)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error happened.")
        End Try
    End Sub

    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'Login.Show()
        Me.Close()
    End Sub

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
