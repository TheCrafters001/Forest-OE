Imports System
Imports System.Security
Imports ForestOSUtilities
Imports System.Security.Cryptography
Imports System.Text
' Security Imports above.



Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim path As String
        path = "C:\Forest-OS\User\"
        If UsernameTextBox.Text = "" Then
            ' Error if nothing has been typed in.
            UsernameLabel.Text = "Error, More than one character required"
        Else
            ' Start login process.
            If My.Computer.FileSystem.DirectoryExists(path + UsernameTextBox.Text + "\") Then ' Check if the Username entered exist.
                Dim USERREAD As System.IO.StreamReader = New System.IO.StreamReader(path + UsernameTextBox.Text + "\" + "USERNAME.DLL") ' If Exist, read file contents
                Dim userline As String
                Dim PASSREAD As System.IO.StreamReader = New System.IO.StreamReader(path + UsernameTextBox.Text + "\" + "PASSWORD.DLL") ' If Exist, read password.
                Dim passline As String
                Do

                    ' Load all security data.
                    Dim sSourceData As String
                    Dim tmpSource() As Byte
                    Dim tmpHash() As Byte
                    sSourceData = "MySourceData"
                    'Create a byte array from source data.
                    tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData)
                    'Compute hash based on source data.
                    tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpSource)


                    passline = ByteArrayToString(tmpHash)
                    userline = USERREAD.ReadLine
                    Console.WriteLine(passline)
                    Console.WriteLine(userline)
                Loop Until userline Is Nothing
                If PasswordTextBox.Text = "" Then
                    ' Error if no password is entered.
                    PasswordLabel.Text = "Error, please insert a password"
                Else
                    If passline = PASSREAD.ReadLine() = True Then ' start services
                        UsernameLabel.Text = "You're Logged In"
                        ServiceStarter.Show()
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
    End Function

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        ' Load CreateAccount
        CreateAccount.Show()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ExplorerStatusChanger.StartExplorer()
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
