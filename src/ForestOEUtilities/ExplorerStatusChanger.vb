Imports System.Windows.Forms

Public Class ExplorerStatusChanger
    Public Shared Sub KillExplorer()
        Try
            Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
            taskKill.WindowStyle = ProcessWindowStyle.Hidden
            Dim Process As Process = New Process()
            Process.StartInfo = taskKill
            Process.Start()
            Process.WaitForExit()
            Debug.WriteLine("Killed Explorer Process")
        Catch ex As Exception
            Debug.WriteLine("Error " & ex.ToString & " happened")
            MessageBox.Show("Error " & ex.ToString & " happened")
        End Try
    End Sub
    Public Shared Sub StartExplorer()
        Try
            Shell(String.Concat(System.Environment.GetFolderPath(Environment.SpecialFolder.Windows), "\explorer.exe"))
        Catch ex As Exception
            Debug.WriteLine("Error " & ex.ToString & " happened")
            MessageBox.Show("Error " & ex.ToString & " happened")
        End Try
    End Sub
    Public Shared Sub Shutdown()
        Process.Start("shutdown.exe", "/s /t 01")
    End Sub
    Public Shared Sub Logout()
        Process.Start("shutdown.exe", "/l")
    End Sub
    Public Shared Sub Restart()
        Process.Start("shutdown.exe", "/r /t 01")
    End Sub

End Class
