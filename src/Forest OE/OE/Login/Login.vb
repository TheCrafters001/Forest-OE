Imports System
Imports System.Security
Imports System.IO
Imports ForestOEUtilities
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

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            If UsernameTextBox.Text = "" Then
                ' Error if nothing has been typed in.
                UsernameLabel.Text = "Error, More than one character required"
            ElseIf UserType.Text = "" Then
                Label1.Text = "Please select an Account type."
            ElseIf My.Computer.FileSystem.DirectoryExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & Usertype.Text & "\" & UsernameTextBox.Text) Then ' Check if the Username entered exist.
                ' Start login process.
                If UsernameTextBox.Text = My.Computer.FileSystem.ReadAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & UsernameTextBox.Text & "\username.dll") Then
                    Try
                        Dim cipherText As String = My.Computer.FileSystem.ReadAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & UsernameTextBox.Text & "\password.dll")
                        Dim password As String = PasswordTextBox.Text
                        Dim wrapper As New Simple3Des(password)
                        Dim password_decrypt As String = wrapper.DecryptData(cipherText)
                        If password_decrypt = PasswordTextBox.Text Then
                            ' Gather settings
                            'Dim Theme As String = System.IO.File.ReadAllLines(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & UsernameTextBox.Text & "\settings.dll")(1)
                            'My.Settings.Theme = Theme
                            My.Settings.Username = UsernameTextBox.Text
                            My.Settings.Usertype = UserType.Text
                            ServiceStarter.Show()
                            Me.Close()
                        ElseIf Not password_decrypt = PasswordTextBox.Text Then
                            MessageBox.Show("Your password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf Not UsernameTextBox.Text = My.Computer.FileSystem.ReadAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\" & UserType.Text & "\" & UsernameTextBox.Text & "\username.dll") Then
                    MessageBox.Show("Your Username Does Not Exist, or Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            CrashScreen.Show()
            CrashScreen.Label2.Text = "What Caused Crash: Login Attempt"
            CrashScreen.Label5.Text = ex.Message
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

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        ' Load CreateAccount
        CreateAccount.Show()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ExplorerStatusChanger.StartExplorer()
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserType.SelectedIndex = 1
        My.Computer.Audio.Play(My.Resources.Forest_OS_Startup, AudioPlayMode.Background)
    End Sub
End Class
