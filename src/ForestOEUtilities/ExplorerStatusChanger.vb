Public Class ExplorerStatusChanger
    Public Shared Sub KillExplorer()
        Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
        taskKill.WindowStyle = ProcessWindowStyle.Hidden
        Dim Process As Process = New Process()
        Process.StartInfo = taskKill
        Process.Start()
        Process.WaitForExit()
    End Sub
    Public Shared Sub StartExplorer()
        Shell(String.Concat(System.Environment.GetFolderPath(Environment.SpecialFolder.Windows), "\explorer.exe"))
    End Sub
    Public Shared Sub Shutdown()
        Process.Start("shutdown.exe", "/s")
    End Sub
    Public Shared Sub Logout()
        Process.Start("shutdown.exe", "/l")
    End Sub
    Public Shared Sub Restart()
        Process.Start("shutdown.exe", "/r")
    End Sub

End Class
