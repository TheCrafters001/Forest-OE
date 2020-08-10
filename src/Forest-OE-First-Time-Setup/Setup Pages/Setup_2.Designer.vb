<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_2
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
        Me.welcomeText_lbl = New System.Windows.Forms.Label()
        Me.welcome_lbl = New System.Windows.Forms.Label()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_under = New System.Windows.Forms.Label()
        Me.username_lbl = New System.Windows.Forms.Label()
        Me.username_txtBox = New System.Windows.Forms.TextBox()
        Me.password_txtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'welcomeText_lbl
        '
        Me.welcomeText_lbl.Location = New System.Drawing.Point(169, 30)
        Me.welcomeText_lbl.Name = "welcomeText_lbl"
        Me.welcomeText_lbl.Size = New System.Drawing.Size(252, 271)
        Me.welcomeText_lbl.TabIndex = 10
        Me.welcomeText_lbl.Text = "Please enter the details of the first user you would like to create." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: The f" &
    "irst user created is always an admin, and you are able to make more accounts as " &
    "soon as you login!"
        '
        'welcome_lbl
        '
        Me.welcome_lbl.AutoSize = True
        Me.welcome_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome_lbl.Location = New System.Drawing.Point(169, 9)
        Me.welcome_lbl.Name = "welcome_lbl"
        Me.welcome_lbl.Size = New System.Drawing.Size(110, 21)
        Me.welcome_lbl.TabIndex = 9
        Me.welcome_lbl.Text = "Create a User"
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(346, 317)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 8
        Me.next_btn.Text = "&Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Forest_OE_First_Time_Setup.My.Resources.Resources.Setup_Large
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lbl_under
        '
        Me.lbl_under.AutoSize = True
        Me.lbl_under.Location = New System.Drawing.Point(-4, 301)
        Me.lbl_under.Name = "lbl_under"
        Me.lbl_under.Size = New System.Drawing.Size(595, 13)
        Me.lbl_under.TabIndex = 7
        Me.lbl_under.Text = "_________________________________________________________________________________" &
    "_________________"
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Location = New System.Drawing.Point(170, 108)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(55, 13)
        Me.username_lbl.TabIndex = 11
        Me.username_lbl.Text = "Username"
        '
        'username_txtBox
        '
        Me.username_txtBox.Location = New System.Drawing.Point(172, 124)
        Me.username_txtBox.Name = "username_txtBox"
        Me.username_txtBox.Size = New System.Drawing.Size(249, 20)
        Me.username_txtBox.TabIndex = 12
        '
        'password_txtBox
        '
        Me.password_txtBox.Location = New System.Drawing.Point(172, 163)
        Me.password_txtBox.Name = "password_txtBox"
        Me.password_txtBox.Size = New System.Drawing.Size(249, 20)
        Me.password_txtBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Password"
        '
        'Setup_2
        '
        Me.AcceptButton = Me.next_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 352)
        Me.Controls.Add(Me.password_txtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.username_txtBox)
        Me.Controls.Add(Me.username_lbl)
        Me.Controls.Add(Me.welcomeText_lbl)
        Me.Controls.Add(Me.welcome_lbl)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_under)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Setup_2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creating a User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeText_lbl As Label
    Friend WithEvents welcome_lbl As Label
    Friend WithEvents next_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_under As Label
    Friend WithEvents username_lbl As Label
    Friend WithEvents username_txtBox As TextBox
    Friend WithEvents password_txtBox As TextBox
    Friend WithEvents Label1 As Label
End Class
