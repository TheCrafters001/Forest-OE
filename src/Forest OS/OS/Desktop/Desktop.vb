Imports ForestOSUtilities

Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub ExitToWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToWindowsToolStripMenuItem.Click
        ExitToWindows.Show()
        Me.Close()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Shutdown.Show()
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub FileExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileExplorerToolStripMenuItem.Click
        Explorer.Show()
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        Run.Show()
    End Sub

    Private Sub ChromeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChromeToolStripMenuItem.Click
        Try
            If Not My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)\Google\Chrome\Application") Then ' 64-bit
                Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe")
            ElseIf Not My.Computer.FileSystem.DirectoryExists("C:\Program Files\Google\Chrome\Application") Then ' 32-bit
                Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
            End If
        Catch ex As Exception
            CrashScreen.Show()
            CrashScreen.Label2.Text = "What Caused Crash: Application Launch Event  Failed"
            CrashScreen.Label5.Text = ex.Message
        End Try
    End Sub

    Private Sub InternetExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetExplorerToolStripMenuItem.Click
        Try
            If Not My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)\Internet Explorer\") Then
                Process.Start("C:\Program Files\Internet Explorer\iexplore.exe")
            ElseIf Not My.Computer.FileSystem.DirectoryExists("C:\Program Files\Internet Explorer\") Then
                Process.Start("C:\Program Files (x86)\Internet Explorer\iexplore.exe")
            End If
        Catch ex As Exception
            CrashScreen.Show()
            CrashScreen.Label2.Text = "What Caused Crash: Application Launch Event  Failed"
            CrashScreen.Label5.Text = ex.Message
        End Try
    End Sub
    Private Sub CommandPromptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandPromptToolStripMenuItem.Click
        Dim ProgramStarter As New ProcessStartInfo
        ProgramStarter.FileName = "Forest-OS-Console.exe"
        ProgramStarter.Arguments = ""
        ProgramStarter.UseShellExecute = True
        ProgramStarter.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(ProgramStarter)
    End Sub

    Private Sub CMDWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMDWindowsToolStripMenuItem.Click
        Dim ProgramStarter As New ProcessStartInfo
        ProgramStarter.FileName = "cmd.exe"
        ProgramStarter.Arguments = ""
        ProgramStarter.UseShellExecute = True
        ProgramStarter.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(ProgramStarter)
    End Sub
End Class