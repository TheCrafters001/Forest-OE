<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChromeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirefoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowershellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandPromptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.RunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 577)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToWindowsToolStripMenuItem, Me.ShutdownToolStripMenuItem})
        Me.TestToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.Menu
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TestToolStripMenuItem.Text = "Menu"
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InternetToolStripMenuItem, Me.PowerUserToolStripMenuItem, Me.FileExplorerToolStripMenuItem})
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProgramsToolStripMenuItem.Text = "Programs"
        '
        'InternetToolStripMenuItem
        '
        Me.InternetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChromeToolStripMenuItem, Me.FirefoxToolStripMenuItem})
        Me.InternetToolStripMenuItem.Name = "InternetToolStripMenuItem"
        Me.InternetToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.InternetToolStripMenuItem.Text = "Internet"
        '
        'ChromeToolStripMenuItem
        '
        Me.ChromeToolStripMenuItem.Name = "ChromeToolStripMenuItem"
        Me.ChromeToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ChromeToolStripMenuItem.Text = "Chrome"
        '
        'FirefoxToolStripMenuItem
        '
        Me.FirefoxToolStripMenuItem.Name = "FirefoxToolStripMenuItem"
        Me.FirefoxToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.FirefoxToolStripMenuItem.Text = "Firefox"
        '
        'PowerUserToolStripMenuItem
        '
        Me.PowerUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PowershellToolStripMenuItem, Me.CommandPromptToolStripMenuItem, Me.WinverToolStripMenuItem})
        Me.PowerUserToolStripMenuItem.Name = "PowerUserToolStripMenuItem"
        Me.PowerUserToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PowerUserToolStripMenuItem.Text = "Power User"
        '
        'PowershellToolStripMenuItem
        '
        Me.PowershellToolStripMenuItem.Name = "PowershellToolStripMenuItem"
        Me.PowershellToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PowershellToolStripMenuItem.Text = "Powershell"
        '
        'CommandPromptToolStripMenuItem
        '
        Me.CommandPromptToolStripMenuItem.Name = "CommandPromptToolStripMenuItem"
        Me.CommandPromptToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CommandPromptToolStripMenuItem.Text = "Command Prompt"
        '
        'WinverToolStripMenuItem
        '
        Me.WinverToolStripMenuItem.Name = "WinverToolStripMenuItem"
        Me.WinverToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.WinverToolStripMenuItem.Text = "winver"
        '
        'FileExplorerToolStripMenuItem
        '
        Me.FileExplorerToolStripMenuItem.Name = "FileExplorerToolStripMenuItem"
        Me.FileExplorerToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FileExplorerToolStripMenuItem.Text = "File Explorer"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.Logout
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToWindowsToolStripMenuItem
        '
        Me.ExitToWindowsToolStripMenuItem.Name = "ExitToWindowsToolStripMenuItem"
        Me.ExitToWindowsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToWindowsToolStripMenuItem.Text = "Exit to Windows"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.Poweroff
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1020, 564)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HH:MM:SS TT"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1098, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitToWindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InternetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChromeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirefoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowerUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowershellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommandPromptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
End Class
