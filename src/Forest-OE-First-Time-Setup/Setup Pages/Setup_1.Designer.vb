<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_under = New System.Windows.Forms.Label()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.welcome_lbl = New System.Windows.Forms.Label()
        Me.welcomeText_lbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Forest_OS_First_Time_Setup.My.Resources.Resources.Setup_Large
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_under
        '
        Me.lbl_under.AutoSize = True
        Me.lbl_under.Location = New System.Drawing.Point(-3, 301)
        Me.lbl_under.Name = "lbl_under"
        Me.lbl_under.Size = New System.Drawing.Size(595, 13)
        Me.lbl_under.TabIndex = 2
        Me.lbl_under.Text = "_________________________________________________________________________________" &
    "_________________"
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(347, 317)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 3
        Me.next_btn.Text = "&Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'welcome_lbl
        '
        Me.welcome_lbl.AutoSize = True
        Me.welcome_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome_lbl.Location = New System.Drawing.Point(170, 9)
        Me.welcome_lbl.Name = "welcome_lbl"
        Me.welcome_lbl.Size = New System.Drawing.Size(183, 21)
        Me.welcome_lbl.TabIndex = 4
        Me.welcome_lbl.Text = "Welcome to Forest-OS!"
        '
        'welcomeText_lbl
        '
        Me.welcomeText_lbl.Location = New System.Drawing.Point(170, 30)
        Me.welcomeText_lbl.Name = "welcomeText_lbl"
        Me.welcomeText_lbl.Size = New System.Drawing.Size(252, 271)
        Me.welcomeText_lbl.TabIndex = 5
        Me.welcomeText_lbl.Text = resources.GetString("welcomeText_lbl.Text")
        '
        'Setup_1
        '
        Me.AcceptButton = Me.next_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 352)
        Me.Controls.Add(Me.welcomeText_lbl)
        Me.Controls.Add(Me.welcome_lbl)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_under)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Setup_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Forest-OS!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_under As Label
    Friend WithEvents next_btn As Button
    Friend WithEvents welcome_lbl As Label
    Friend WithEvents welcomeText_lbl As Label
End Class
