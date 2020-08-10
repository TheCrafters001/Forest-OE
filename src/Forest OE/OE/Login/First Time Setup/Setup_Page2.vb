Imports System
Imports System.Security
Imports System.IO
Imports ForestOEUtilities
Imports System.Security.Cryptography
Imports System.Text


Public Class Setup_Page2
    Private Sub Setup_Page2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Dim username As String = UsernameTextBox.Text
            Dim password As String = PasswordTextBox.Text

            Dim wrapper As New Simple3Des(password)
            Dim cipherText As String = wrapper.EncryptData(username)

            MkDir(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username)
            My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username & "\username.dll", username, False)
            My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username & "\password.dll", cipherText, False)
            MessageBox.Show("Account Created under the username, " & username & ".", "Forest-OS Account Creator", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Setup_Page3.Show()
            Me.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setup_Page3.Show()
        Me.Close()
    End Sub
End Class