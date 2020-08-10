Public Class ShutdownDialog
    Private Sub shutdown_btn_Click(sender As Object, e As EventArgs) Handles shutdown_btn.Click
        Try
            If options_cmb.Text = "Shutdown" Then
                Dim dlgRslt As DialogResult = MessageBox.Show("Are you sure you want to shutdown? Doing this will shutdown the computer.  Any changes made to any files will be lost.", "Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlgRslt = DialogResult.Yes Then
                    Shutdown.Show()
                    Me.Close()
                ElseIf dlgRslt = DialogResult.No Then
                    MessageBox.Show("The system will not shutdown.")
                End If
            ElseIf options_cmb.Text = "Logoff Windows" Then
                Dim dlgRslt As DialogResult = MessageBox.Show("Are you sure you want to Logout? Any changes made to any files will be lost.", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlgRslt = DialogResult.Yes Then
                    Logout.Show()
                    Me.Close()
                ElseIf dlgRslt = DialogResult.No Then
                    MessageBox.Show("Forest-OS will not log you out.")
                End If
            ElseIf options_cmb.Text = "Exit to Windows" Then
                Dim dlgRslt As DialogResult = MessageBox.Show("Are you sure you want to Exit to Windows? Any changes made to any files will be lost.", "Exit Forest-OS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlgRslt = DialogResult.Yes Then
                    ExitToWindows.Show()
                    Me.Close()
                ElseIf dlgRslt = DialogResult.No Then
                    MessageBox.Show("Forest-OS will not Exit to Windows.")
                End If
            ElseIf options_cmb.Text = "Restart" Then
                Dim dlgRslt As DialogResult = MessageBox.Show("Are you sure you want to Exit to Windows? Any changes made to any files will be lost.", "Exit Forest-OS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlgRslt = DialogResult.Yes Then
                    'Restart.Show()
                    Me.Close()
                ElseIf dlgRslt = DialogResult.No Then
                    MessageBox.Show("Forest-OS will not Exit to Windows.")
                End If
            End If
        Catch ex As Exception
            CrashScreen.Show()
            CrashScreen.Label2.Text = "What Caused Crash: Shutdown Attempt"
            CrashScreen.Label5.Text = ex.Message
        End Try
    End Sub

    Private Sub ShutdownDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        options_cmb.Items.Add("Logoff Windows")
        options_cmb.Items.Add("Exit to Windows")
        options_cmb.Items.Add("Shutdown")
        options_cmb.Items.Add("Restart")
        options_cmb.SelectedIndex = 1
    End Sub
End Class