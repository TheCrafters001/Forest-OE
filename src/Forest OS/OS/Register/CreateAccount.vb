Imports System
Imports System.Security
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
            If ComboBox1.Text = "" Then
                MessageBox.Show("Cannot create user, no user type selected.")
            ElseIf Not ComboBox1.Text = "" Then
                Dim path As String
                path = "C:\Forest-OS\User\"
                If My.Computer.FileSystem.DirectoryExists(path) = True Then
                Else
                End If
                If UsernameTextBox.Text = "" Then
                    UsernameLabel.Text = "Error, More than one character required"
                ElseIf PasswordTextBox.Text = "" Then
                    UsernameLabel.Text = "Error, please insert a password"
                ElseIf ComboBox1.Text = "" Then
                    Label1.Text = "Please select an Account type."
                Else
                    MkDir(path & ComboBox1.Text & "\" & UsernameTextBox.Text)
                    Dim username As New System.IO.StreamWriter(path & ComboBox1.Text & "\" & UsernameTextBox.Text & "\" & "username.dll")
                    username.Write(UsernameTextBox.Text)
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


                    Dim password As New System.IO.StreamWriter(path & ComboBox1.Text & "\" & UsernameTextBox.Text & "\" & "password.dll")
                    password.Write(ByteArrayToString(tmpHash))
                    password.Close()
                    UsernameLabel.Text = "Account Verified"
                    MsgBox(UsernameLabel.Text)
                    MessageBox.Show("Account: " & UsernameTextBox.Text & " created! To use this " & ComboBox1.Text & " account, please logout, and login using the information you have given!")
                End If
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
