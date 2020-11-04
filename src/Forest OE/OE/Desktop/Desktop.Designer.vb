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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Time_lbl = New System.Windows.Forms.Label()
        Me.quickLaunch_btn = New System.Windows.Forms.Button()
        Me.quickLaunch_grp = New System.Windows.Forms.GroupBox()
        Me.QuickLaunchList = New System.Windows.Forms.ListBox()
        Me.desktopMenu_menustrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.shutdownMenuItem_Desktop = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quickLaunch_grp.SuspendLayout()
        Me.desktopMenu_menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Time_lbl
        '
        Me.Time_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Time_lbl.AutoSize = True
        Me.Time_lbl.ForeColor = System.Drawing.Color.White
        Me.Time_lbl.Location = New System.Drawing.Point(1022, 563)
        Me.Time_lbl.Name = "Time_lbl"
        Me.Time_lbl.Size = New System.Drawing.Size(78, 13)
        Me.Time_lbl.TabIndex = 1
        Me.Time_lbl.Text = "HH:MM:SS TT"
        '
        'quickLaunch_btn
        '
        Me.quickLaunch_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.quickLaunch_btn.Location = New System.Drawing.Point(6, 533)
        Me.quickLaunch_btn.Name = "quickLaunch_btn"
        Me.quickLaunch_btn.Size = New System.Drawing.Size(145, 23)
        Me.quickLaunch_btn.TabIndex = 3
        Me.quickLaunch_btn.Text = "Launch"
        Me.quickLaunch_btn.UseVisualStyleBackColor = True
        '
        'quickLaunch_grp
        '
        Me.quickLaunch_grp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.quickLaunch_grp.BackColor = System.Drawing.Color.Transparent
        Me.quickLaunch_grp.Controls.Add(Me.QuickLaunchList)
        Me.quickLaunch_grp.Controls.Add(Me.quickLaunch_btn)
        Me.quickLaunch_grp.Location = New System.Drawing.Point(12, 12)
        Me.quickLaunch_grp.Name = "quickLaunch_grp"
        Me.quickLaunch_grp.Size = New System.Drawing.Size(157, 562)
        Me.quickLaunch_grp.TabIndex = 4
        Me.quickLaunch_grp.TabStop = False
        Me.quickLaunch_grp.Text = "Quick Launch"
        '
        'QuickLaunchList
        '
        Me.QuickLaunchList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.QuickLaunchList.FormattingEnabled = True
        Me.QuickLaunchList.Location = New System.Drawing.Point(6, 19)
        Me.QuickLaunchList.Name = "QuickLaunchList"
        Me.QuickLaunchList.Size = New System.Drawing.Size(145, 511)
        Me.QuickLaunchList.TabIndex = 6
        '
        'desktopMenu_menustrip
        '
        Me.desktopMenu_menustrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.desktopMenu_menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.RunToolStripMenuItem})
        Me.desktopMenu_menustrip.Location = New System.Drawing.Point(0, 576)
        Me.desktopMenu_menustrip.Name = "desktopMenu_menustrip"
        Me.desktopMenu_menustrip.Size = New System.Drawing.Size(1100, 24)
        Me.desktopMenu_menustrip.TabIndex = 5
        Me.desktopMenu_menustrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.shutdownMenuItem_Desktop})
        Me.MenuToolStripMenuItem.Image = Global.Forest_OE.My.Resources.Resources.menu_40px
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'shutdownMenuItem_Desktop
        '
        Me.shutdownMenuItem_Desktop.Image = Global.Forest_OE.My.Resources.Resources.close_pane_40px
        Me.shutdownMenuItem_Desktop.Name = "shutdownMenuItem_Desktop"
        Me.shutdownMenuItem_Desktop.Size = New System.Drawing.Size(137, 22)
        Me.shutdownMenuItem_Desktop.Text = "Shutdown..."
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
        Me.BackgroundImage = Global.Forest_OE.My.Resources.Resources.Wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.quickLaunch_grp)
        Me.Controls.Add(Me.Time_lbl)
        Me.Controls.Add(Me.desktopMenu_menustrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.desktopMenu_menustrip
        Me.Name = "Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.quickLaunch_grp.ResumeLayout(False)
        Me.desktopMenu_menustrip.ResumeLayout(False)
        Me.desktopMenu_menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Time_lbl As Label
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
    Friend WithEvents InternetExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MicrosoftEdgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMDWindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents quickLaunch_btn As Button
    Friend WithEvents quickLaunch_grp As GroupBox
    Friend WithEvents desktopMenu_menustrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents shutdownMenuItem_Desktop As ToolStripMenuItem
    Friend WithEvents QuickLaunchList As ListBox
End Class
