<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShutdownDialog
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
        Me.options_grp = New System.Windows.Forms.GroupBox()
        Me.options_cmb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shutdown_btn = New System.Windows.Forms.Button()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.options_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'options_grp
        '
        Me.options_grp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.options_grp.Controls.Add(Me.options_cmb)
        Me.options_grp.Controls.Add(Me.Label1)
        Me.options_grp.Location = New System.Drawing.Point(12, 12)
        Me.options_grp.Name = "options_grp"
        Me.options_grp.Size = New System.Drawing.Size(307, 78)
        Me.options_grp.TabIndex = 0
        Me.options_grp.TabStop = False
        Me.options_grp.Text = "Select Shutdown Option"
        '
        'options_cmb
        '
        Me.options_cmb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.options_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.options_cmb.FormattingEnabled = True
        Me.options_cmb.Location = New System.Drawing.Point(9, 32)
        Me.options_cmb.Name = "options_cmb"
        Me.options_cmb.Size = New System.Drawing.Size(292, 21)
        Me.options_cmb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select an option for shutting down your PC."
        '
        'shutdown_btn
        '
        Me.shutdown_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shutdown_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.shutdown_btn.Location = New System.Drawing.Point(244, 100)
        Me.shutdown_btn.Name = "shutdown_btn"
        Me.shutdown_btn.Size = New System.Drawing.Size(75, 23)
        Me.shutdown_btn.TabIndex = 1
        Me.shutdown_btn.Text = "OK"
        Me.shutdown_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_btn.Location = New System.Drawing.Point(12, 100)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_btn.TabIndex = 2
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'ShutdownDialog
        '
        Me.AcceptButton = Me.shutdown_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_btn
        Me.ClientSize = New System.Drawing.Size(331, 135)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.shutdown_btn)
        Me.Controls.Add(Me.options_grp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShutdownDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown..."
        Me.TopMost = True
        Me.options_grp.ResumeLayout(False)
        Me.options_grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents options_grp As GroupBox
    Friend WithEvents shutdown_btn As Button
    Friend WithEvents options_cmb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel_btn As Button
End Class
