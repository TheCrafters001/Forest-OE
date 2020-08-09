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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.UserGroups = New System.Windows.Forms.GroupBox()
        Me.devTools_grp = New System.Windows.Forms.GroupBox()
        Me.UserGroups.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create A New Account"
        '
        'UserGroups
        '
        Me.UserGroups.BackColor = System.Drawing.Color.Transparent
        Me.UserGroups.Controls.Add(Me.LinkLabel1)
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
        Me.devTools_grp.Location = New System.Drawing.Point(21, 344)
        Me.devTools_grp.Name = "devTools_grp"
        Me.devTools_grp.Size = New System.Drawing.Size(751, 205)
        Me.devTools_grp.TabIndex = 0
        Me.devTools_grp.TabStop = False
        Me.devTools_grp.Text = "Developer Tools"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Forest_OS.My.Resources.Resources.settingsBackground
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents UserGroups As GroupBox
    Friend WithEvents devTools_grp As GroupBox
End Class
