Imports System.IO

Public Class BrowserFinder
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
#Region "Finder"
    Public Shared Sub Finder()
        '
        ' Google Chrome
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
            Desktop.QuickLaunchList.Items.Add("Google Chrome")
            Debug.WriteLine("Google Chrome Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Google\Chrome\Application\chrome.exe") Then
            Desktop.QuickLaunchList.Items.Add("Google Chrome")
            Debug.WriteLine("Google Chrome Added")
        End If
        '
        ' Internet Explorer
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Internet Explorer\iexplore.exe") Then
            Desktop.QuickLaunchList.Items.Add("Internet Explorer")
            Debug.WriteLine("IE Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Internet Explorer\iexplore.exe") Then
            Desktop.QuickLaunchList.Items.Add("Internet Explorer")
            Debug.WriteLine("IE Added")
        End If
        '
        ' FireFox
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Mozilla Firefox\firefox.exe") Then
            Desktop.QuickLaunchList.Items.Add("FireFox")
            Debug.WriteLine("Mozilla FireFox Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Mozilla Firefox\firefox.exe") Then
            Desktop.QuickLaunchList.Items.Add("FireFox")
            Debug.WriteLine("Mozilla FireFox Added")
        End If
        '
        ' Edge
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then
            Desktop.QuickLaunchList.Items.Add("Edge")
            Debug.WriteLine("Microsoft Edge Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Microsoft\Edge\Application\msedge.exe") Then
            Desktop.QuickLaunchList.Items.Add("Edge")
            Debug.WriteLine("Microsoft Edge Added")
        End If

    End Sub
#End Region

    Public Shared Sub Execute(ByVal BrowserName As String)
        Try
            If BrowserName = "chrome" Then
                If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Google\Chrome\Application\chrome.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("Google Chrome Opened")
                ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Google\Chrome\Application\chrome.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Google\Chrome\Application\chrome.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("Google Chrome Opened")
                End If
            ElseIf BrowserName = "firefox" Then
                If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Mozilla Firefox\firefox.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Mozilla Firefox\firefox.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("Firefox Opened")
                ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Mozilla Firefox\firefox.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Mozilla Firefox\firefox.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("Firefox Opened")
                End If
            ElseIf BrowserName = "ie" Then
                If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Internet Explorer\iexplore.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Internet Explorer\iexplore.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("IE Opened")
                ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Internet Explorer\iexplore.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Internet Explorer\iexplore.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("IE Opened")
                End If
            ElseIf BrowserName = "edge" Then
                If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("Edge Opened")
                ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Microsoft\Edge\Application\msedge.exe") Then
                    Dim osk As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Microsoft\Edge\Application\msedge.exe"
                    Dim old As Long
                    If Environment.Is64BitOperatingSystem Then
                        If Wow64DisableWow64FsRedirection(old) Then
                            Process.Start(osk)
                            Wow64EnableWow64FsRedirection(old)
                        End If
                    Else
                        Process.Start(osk)
                    End If
                    Debug.WriteLine("Edge Opened")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & vbCrLf & ex.ToString, "Error")
        End Try

    End Sub
End Class
