Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text


Public Class Setup_Page2
    Private Sub Setup_Page2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Dim path As String
            path = "C:\Forest-OS\User\"
            If My.Computer.FileSystem.DirectoryExists(path) = True Then
            Else
            End If
            If UsernameTextBox.Text = "" Then
                UsernameLabel.Text = "Error, More than one character required"
            ElseIf PasswordTextBox.Text = "" Then
                UsernameLabel.Text = "Error, please insert a password"
            Else
                MkDir(path & "Admin" & "\" & UsernameTextBox.Text)
                Dim username As New System.IO.StreamWriter(path & "Admin" & "\" & UsernameTextBox.Text & "\" & "username.dll")
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


                Dim password As New System.IO.StreamWriter(path & "Admin" & "\" & UsernameTextBox.Text & "\" & "password.dll")
                password.Write(ByteArrayToString(tmpHash))
                password.Close()
                UsernameLabel.Text = "Account Verified"
                MsgBox(UsernameLabel.Text)
                MessageBox.Show("Account: " & UsernameTextBox.Text & " created! To use this " & "Admin" & " account, please logout, and login using the information you have given!")
                Button1.Enabled = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setup_Page3.Show()
        Me.Close()
    End Sub
End Class