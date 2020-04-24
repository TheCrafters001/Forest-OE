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
End Class
