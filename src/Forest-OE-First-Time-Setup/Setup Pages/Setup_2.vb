Imports System
Imports System.Security
Imports System.IO
Imports ForestOSUtilities
Imports System.Security.Cryptography
Imports System.Text

Public Class Setup_2
    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        Try
            If username_txtBox.Text = "" Then
                MessageBox.Show("Cannot have a blank username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ElseIf Not username_txtBox.Text = "" Then
                If password_txtBox.Text = "" Then
                    MessageBox.Show("Cannot have a blank password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                ElseIf Not password_txtBox.Text = "" Then
                    Dim username As String = username_txtBox.Text
                    Dim password As String = password_txtBox.Text

                    Dim wrapper As New Simple3Des(password)
                    Dim cipherText As String = wrapper.EncryptData(username)

                    MkDir(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username)
                    My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username & "\username.dll", username, False)
                    My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username & "\password.dll", cipherText, False)
                    My.Computer.FileSystem.WriteAllText(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\Forest-OS\User\Admin\" & username & "\settings.dll", "Default", False)
                    Setup_3.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error happened. Details are below." & vbCrLf & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class