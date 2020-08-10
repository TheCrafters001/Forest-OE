<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.userAccountLink_lnk = New System.Windows.Forms.LinkLabel()
        Me.UserGroups = New System.Windows.Forms.GroupBox()
        Me.devTools_grp = New System.Windows.Forms.GroupBox()
        Me.testLink1_lnk = New System.Windows.Forms.LinkLabel()
        Me.UserGroups.SuspendLayout()
        Me.devTools_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'userAccountLink_lnk
        '
        Me.userAccountLink_lnk.AutoSize = True
        Me.userAccountLink_lnk.Location = New System.Drawing.Point(6, 16)
        Me.userAccountLink_lnk.Name = "userAccountLink_lnk"
        Me.userAccountLink_lnk.Size = New System.Drawing.Size(116, 13)
        Me.userAccountLink_lnk.TabIndex = 0
        Me.userAccountLink_lnk.TabStop = True
        Me.userAccountLink_lnk.Text = "Create A New Account"
        '
        'UserGroups
        '
        Me.UserGroups.BackColor = System.Drawing.Color.Transparent
        Me.UserGroups.Controls.Add(Me.userAccountLink_lnk)
        Me.UserGroups.Location = New System.Drawing.Point(12, 12)
        Me.UserGroups.Name = "UserGroups"
        Me.UserGroups.Size = New System.Drawing.Size(128, 100)
        Me.UserGroups.TabIndex = 1
        Me.UserGroups.TabStop = False
        Me.UserGroups.Text = "User Management"
        '
        'devTools_grp
        '
        Me.devTools_grp.BackColor = System.Drawing.Color.Transparent
        Me.devTools_grp.Controls.Add(Me.testLink1_lnk)
        Me.devTools_grp.Location = New System.Drawing.Point(21, 344)
        Me.devTools_grp.Name = "devTools_grp"
        Me.devTools_grp.Size = New System.Drawing.Size(751, 205)
        Me.devTools_grp.TabIndex = 0
        Me.devTools_grp.TabStop = False
        Me.devTools_grp.Text = "Developer Tools"
        '
        'testLink1_lnk
        '
        Me.testLink1_lnk.AutoSize = True
        Me.testLink1_lnk.Location = New System.Drawing.Point(6, 16)
        Me.testLink1_lnk.Name = "testLink1_lnk"
        Me.testLink1_lnk.Size = New System.Drawing.Size(58, 13)
        Me.testLink1_lnk.TabIndex = 0
        Me.testLink1_lnk.TabStop = True
        Me.testLink1_lnk.Text = "Test Crash"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Forest_OE.My.Resources.Resources.settingsBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.devTools_grp)
        Me.Controls.Add(Me.UserGroups)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TopMost = True
        Me.UserGroups.ResumeLayout(False)
        Me.UserGroups.PerformLayout()
        Me.devTools_grp.ResumeLayout(False)
        Me.devTools_grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userAccountLink_lnk As LinkLabel
    Friend WithEvents UserGroups As GroupBox
    Friend WithEvents devTools_grp As GroupBox
    Friend WithEvents testLink1_lnk As LinkLabel
End Class
