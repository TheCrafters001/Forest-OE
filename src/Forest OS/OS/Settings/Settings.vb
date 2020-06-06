Public Class Settings
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateAccount.Show()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.Usertype = "Admin" Or My.Settings.Usertype = "Power User" Or My.Settings.Usertype = "Enterprise" Then
            UserGroups.Enabled = False
        ElseIf My.Settings.Usertype = "Admin" Or My.Settings.Usertype = "Power User" Or My.Settings.Usertype = "Enterprise" Then
            UserGroups.Enabled = True
        End If
    End Sub
End Class