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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Web Browsers", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Settings", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Help", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Advanced Users", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Internet Explorer", 3)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Google Chrome", 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mozilla Firefox", 2)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Microsoft Edge", 1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Settings", 4)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("About", 46)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Create a new User", 5)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Help", 47)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CMD (Forest)", 4)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CMD (Windows)", 49)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChromeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirefoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftEdgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowershellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMDWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandPromptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
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
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.ShutdownToolStripMenuItem})
        Me.TestToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.menu_40px
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
        Me.InternetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChromeToolStripMenuItem, Me.FirefoxToolStripMenuItem, Me.InternetExplorerToolStripMenuItem, Me.MicrosoftEdgeToolStripMenuItem, Me.OperaToolStripMenuItem})
        Me.InternetToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.internet_explorer_9_11_256x256
        Me.InternetToolStripMenuItem.Name = "InternetToolStripMenuItem"
        Me.InternetToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.InternetToolStripMenuItem.Text = "Internet"
        '
        'ChromeToolStripMenuItem
        '
        Me.ChromeToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.chrome_256x256
        Me.ChromeToolStripMenuItem.Name = "ChromeToolStripMenuItem"
        Me.ChromeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ChromeToolStripMenuItem.Text = "Chrome"
        '
        'FirefoxToolStripMenuItem
        '
        Me.FirefoxToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.firefox_256x256
        Me.FirefoxToolStripMenuItem.Name = "FirefoxToolStripMenuItem"
        Me.FirefoxToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FirefoxToolStripMenuItem.Text = "Firefox"
        '
        'InternetExplorerToolStripMenuItem
        '
        Me.InternetExplorerToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.internet_explorer_9_11_256x256
        Me.InternetExplorerToolStripMenuItem.Name = "InternetExplorerToolStripMenuItem"
        Me.InternetExplorerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.InternetExplorerToolStripMenuItem.Text = "Internet Explorer"
        '
        'MicrosoftEdgeToolStripMenuItem
        '
        Me.MicrosoftEdgeToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.edge_256x256
        Me.MicrosoftEdgeToolStripMenuItem.Name = "MicrosoftEdgeToolStripMenuItem"
        Me.MicrosoftEdgeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MicrosoftEdgeToolStripMenuItem.Text = "Microsoft Edge"
        '
        'OperaToolStripMenuItem
        '
        Me.OperaToolStripMenuItem.Name = "OperaToolStripMenuItem"
        Me.OperaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OperaToolStripMenuItem.Text = "Opera"
        '
        'PowerUserToolStripMenuItem
        '
        Me.PowerUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PowershellToolStripMenuItem, Me.CMDWindowsToolStripMenuItem, Me.CommandPromptToolStripMenuItem, Me.WinverToolStripMenuItem})
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
        'CMDWindowsToolStripMenuItem
        '
        Me.CMDWindowsToolStripMenuItem.Name = "CMDWindowsToolStripMenuItem"
        Me.CMDWindowsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CMDWindowsToolStripMenuItem.Text = "CMD (Windows)"
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
        Me.FileExplorerToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.full_image_40px
        Me.FileExplorerToolStripMenuItem.Name = "FileExplorerToolStripMenuItem"
        Me.FileExplorerToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FileExplorerToolStripMenuItem.Text = "File Explorer"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.icons8_settings_64
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.info_popup_40px
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Image = Global.Forest_OS.My.Resources.Resources.close_window_40px
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown..."
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RunToolStripMenuItem.Text = "Run"
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "chrome_256x256.png")
        Me.ImageList1.Images.SetKeyName(1, "edge_256x256.png")
        Me.ImageList1.Images.SetKeyName(2, "firefox_256x256.png")
        Me.ImageList1.Images.SetKeyName(3, "internet-explorer_9-11_256x256.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-settings-64.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-user-group-30.png")
        Me.ImageList1.Images.SetKeyName(6, "active_state_40px.png")
        Me.ImageList1.Images.SetKeyName(7, "add_40px.png")
        Me.ImageList1.Images.SetKeyName(8, "add_to_favorites_40px.png")
        Me.ImageList1.Images.SetKeyName(9, "adjustment_40px.png")
        Me.ImageList1.Images.SetKeyName(10, "advertisement_page_40px.png")
        Me.ImageList1.Images.SetKeyName(11, "animated_40px.png")
        Me.ImageList1.Images.SetKeyName(12, "assistive_technology_40px.png")
        Me.ImageList1.Images.SetKeyName(13, "available_updates_40px.png")
        Me.ImageList1.Images.SetKeyName(14, "buffering_40px.png")
        Me.ImageList1.Images.SetKeyName(15, "bursts_40px.png")
        Me.ImageList1.Images.SetKeyName(16, "category_40px.png")
        Me.ImageList1.Images.SetKeyName(17, "change_theme_40px.png")
        Me.ImageList1.Images.SetKeyName(18, "checked_checkbox_40px.png")
        Me.ImageList1.Images.SetKeyName(19, "checklist_40px.png")
        Me.ImageList1.Images.SetKeyName(20, "checkmark_40px.png")
        Me.ImageList1.Images.SetKeyName(21, "clear_search_40px.png")
        Me.ImageList1.Images.SetKeyName(22, "close_pane_40px.png")
        Me.ImageList1.Images.SetKeyName(23, "close_window_40px.png")
        Me.ImageList1.Images.SetKeyName(24, "content_40px.png")
        Me.ImageList1.Images.SetKeyName(25, "delete_view_40px.png")
        Me.ImageList1.Images.SetKeyName(26, "desktop_40px.png")
        Me.ImageList1.Images.SetKeyName(27, "desktop_mac_40px.png")
        Me.ImageList1.Images.SetKeyName(28, "details_40px.png")
        Me.ImageList1.Images.SetKeyName(29, "deviation_40px.png")
        Me.ImageList1.Images.SetKeyName(30, "discrepancy_40px.png")
        Me.ImageList1.Images.SetKeyName(31, "download_40px.png")
        Me.ImageList1.Images.SetKeyName(32, "downloading_updates_40px.png")
        Me.ImageList1.Images.SetKeyName(33, "downloads_40px.png")
        Me.ImageList1.Images.SetKeyName(34, "dropdown_field_40px.png")
        Me.ImageList1.Images.SetKeyName(35, "email_40px.png")
        Me.ImageList1.Images.SetKeyName(36, "error_40px.png")
        Me.ImageList1.Images.SetKeyName(37, "exit_40px.png")
        Me.ImageList1.Images.SetKeyName(38, "external_40px.png")
        Me.ImageList1.Images.SetKeyName(39, "final_state_40px.png")
        Me.ImageList1.Images.SetKeyName(40, "find_and_replace_40px.png")
        Me.ImageList1.Images.SetKeyName(41, "form_40px.png")
        Me.ImageList1.Images.SetKeyName(42, "full_image_40px.png")
        Me.ImageList1.Images.SetKeyName(43, "google_presentation_40px.png")
        Me.ImageList1.Images.SetKeyName(44, "graph_40px.png")
        Me.ImageList1.Images.SetKeyName(45, "inconsistency_40px.png")
        Me.ImageList1.Images.SetKeyName(46, "info_popup_40px.png")
        Me.ImageList1.Images.SetKeyName(47, "info_squared_40px.png")
        Me.ImageList1.Images.SetKeyName(48, "information_40px.png")
        Me.ImageList1.Images.SetKeyName(49, "initial_state_40px.png")
        Me.ImageList1.Images.SetKeyName(50, "installing_updates_40px.png")
        Me.ImageList1.Images.SetKeyName(51, "internal_40px.png")
        Me.ImageList1.Images.SetKeyName(52, "iphone_spinner_40px.png")
        Me.ImageList1.Images.SetKeyName(53, "large_icons_40px.png")
        Me.ImageList1.Images.SetKeyName(54, "level_up_40px.png")
        Me.ImageList1.Images.SetKeyName(55, "lifebuoy_40px.png")
        Me.ImageList1.Images.SetKeyName(56, "list_40px.png")
        Me.ImageList1.Images.SetKeyName(57, "list_of_thumbnails_40px.png")
        Me.ImageList1.Images.SetKeyName(58, "loader_40px.png")
        Me.ImageList1.Images.SetKeyName(59, "loading_bar_40px.png")
        Me.ImageList1.Images.SetKeyName(60, "maintenance_40px.png")
        Me.ImageList1.Images.SetKeyName(61, "maximize_window_40px.png")
        Me.ImageList1.Images.SetKeyName(62, "medium_icons_40px.png")
        Me.ImageList1.Images.SetKeyName(63, "menu_40px.png")
        Me.ImageList1.Images.SetKeyName(64, "menu_vertical_40px.png")
        Me.ImageList1.Images.SetKeyName(65, "minimize_window_40px.png")
        Me.ImageList1.Images.SetKeyName(66, "natural_user_interface_1_40px.png")
        Me.ImageList1.Images.SetKeyName(67, "natural_user_interface_2_40px.png")
        Me.ImageList1.Images.SetKeyName(68, "new_document_40px.png")
        Me.ImageList1.Images.SetKeyName(69, "new_view_40px.png")
        Me.ImageList1.Images.SetKeyName(70, "one_way_transition_40px.png")
        Me.ImageList1.Images.SetKeyName(71, "open_in_browser_40px.png")
        Me.ImageList1.Images.SetKeyName(72, "open_in_popup_40px.png")
        Me.ImageList1.Images.SetKeyName(73, "open_view_40px.png")
        Me.ImageList1.Images.SetKeyName(74, "open_view_in_new_tab_40px.png")
        Me.ImageList1.Images.SetKeyName(75, "original_size_40px.png")
        Me.ImageList1.Images.SetKeyName(76, "picture_in_picture_40px.png")
        Me.ImageList1.Images.SetKeyName(77, "popup_40px.png")
        Me.ImageList1.Images.SetKeyName(78, "private_40px.png")
        Me.ImageList1.Images.SetKeyName(79, "quick_mode_off_40px.png")
        Me.ImageList1.Images.SetKeyName(80, "quick_mode_on_40px.png")
        Me.ImageList1.Images.SetKeyName(81, "replace_40px.png")
        Me.ImageList1.Images.SetKeyName(82, "restore_window_40px.png")
        Me.ImageList1.Images.SetKeyName(83, "right_navigation_toolbar_40px.png")
        Me.ImageList1.Images.SetKeyName(84, "save_40px.png")
        Me.ImageList1.Images.SetKeyName(85, "save_all_40px.png")
        Me.ImageList1.Images.SetKeyName(86, "save_as_40px.png")
        Me.ImageList1.Images.SetKeyName(87, "save_close_40px.png")
        Me.ImageList1.Images.SetKeyName(88, "select_40px.png")
        Me.ImageList1.Images.SetKeyName(89, "selfies_40px.png")
        Me.ImageList1.Images.SetKeyName(90, "show_non_hidden_views_40px.png")
        Me.ImageList1.Images.SetKeyName(91, "small_icons_40px.png")
        Me.ImageList1.Images.SetKeyName(92, "spinner_40px.png")
        Me.ImageList1.Images.SetKeyName(93, "start_menu_40px.png")
        Me.ImageList1.Images.SetKeyName(94, "states_40px.png")
        Me.ImageList1.Images.SetKeyName(95, "static_view_level1_40px.png")
        Me.ImageList1.Images.SetKeyName(96, "static_view_level2_40px.png")
        Me.ImageList1.Images.SetKeyName(97, "static_views_40px.png")
        Me.ImageList1.Images.SetKeyName(98, "storage_40px.png")
        Me.ImageList1.Images.SetKeyName(99, "stream_40px.png")
        Me.ImageList1.Images.SetKeyName(100, "streaming_40px.png")
        Me.ImageList1.Images.SetKeyName(101, "swirl_40px.png")
        Me.ImageList1.Images.SetKeyName(102, "switch_off_40px.png")
        Me.ImageList1.Images.SetKeyName(103, "switch_on_40px.png")
        Me.ImageList1.Images.SetKeyName(104, "tag_window_40px.png")
        Me.ImageList1.Images.SetKeyName(105, "thumbnails_40px.png")
        Me.ImageList1.Images.SetKeyName(106, "tiles_40px.png")
        Me.ImageList1.Images.SetKeyName(107, "toggle_off_40px.png")
        Me.ImageList1.Images.SetKeyName(108, "toggle_on_40px.png")
        Me.ImageList1.Images.SetKeyName(109, "transition_both_directions_40px.png")
        Me.ImageList1.Images.SetKeyName(110, "unchecked_checkbox_40px.png")
        Me.ImageList1.Images.SetKeyName(111, "uninstalling_updates_40px.png")
        Me.ImageList1.Images.SetKeyName(112, "upload_40px.png")
        Me.ImageList1.Images.SetKeyName(113, "user_manual_40px.png")
        Me.ImageList1.Images.SetKeyName(114, "user_menu_female_40px.png")
        Me.ImageList1.Images.SetKeyName(115, "user_menu_male_40px.png")
        Me.ImageList1.Images.SetKeyName(116, "variation_40px.png")
        Me.ImageList1.Images.SetKeyName(117, "view_all_40px.png")
        Me.ImageList1.Images.SetKeyName(118, "view_details_40px.png")
        Me.ImageList1.Images.SetKeyName(119, "virtual_reality_40px.png")
        Me.ImageList1.Images.SetKeyName(120, "wait_40px.png")
        Me.ImageList1.Images.SetKeyName(121, "web_accessibility_40px.png")
        Me.ImageList1.Images.SetKeyName(122, "windows8_40px.png")
        Me.ImageList1.Images.SetKeyName(123, "xlarge_icons_40px.png")
        Me.ImageList1.Images.SetKeyName(124, "zoom_in_40px.png")
        Me.ImageList1.Images.SetKeyName(125, "zoom_out_40px.png")
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.DarkCyan
        ListViewGroup1.Header = "Web Browsers"
        ListViewGroup1.Name = "Web Browsers"
        ListViewGroup2.Header = "Settings"
        ListViewGroup2.Name = "Settings"
        ListViewGroup3.Header = "Help"
        ListViewGroup3.Name = "Help"
        ListViewGroup4.Header = "Advanced Users"
        ListViewGroup4.Name = "Advanced"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        Me.ListView1.HideSelection = False
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup1
        ListViewItem5.Group = ListViewGroup2
        ListViewItem6.Group = ListViewGroup2
        ListViewItem7.Group = ListViewGroup2
        ListViewItem8.Group = ListViewGroup3
        ListViewItem9.Group = ListViewGroup4
        ListViewItem10.Group = ListViewGroup4
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1074, 549)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
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
        Me.Controls.Add(Me.ListView1)
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
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
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
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents InternetExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MicrosoftEdgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMDWindowsToolStripMenuItem As ToolStripMenuItem
End Class
