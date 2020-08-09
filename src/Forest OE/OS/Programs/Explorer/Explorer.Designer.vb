<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Explorer))
        Me.trvFolders = New System.Windows.Forms.TreeView()
        Me.cmClipboardOp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvFiles = New System.Windows.Forms.ListView()
        Me.cboView = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.iIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmClipboardOp.SuspendLayout()
        Me.SuspendLayout()
        '
        'trvFolders
        '
        Me.trvFolders.ContextMenuStrip = Me.cmClipboardOp
        Me.trvFolders.Location = New System.Drawing.Point(12, 39)
        Me.trvFolders.Name = "trvFolders"
        Me.trvFolders.Size = New System.Drawing.Size(171, 399)
        Me.trvFolders.TabIndex = 0
        '
        'cmClipboardOp
        '
        Me.cmClipboardOp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.cmClipboardOp.Name = "cmClipboardOp"
        Me.cmClipboardOp.Size = New System.Drawing.Size(103, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'lvFiles
        '
        Me.lvFiles.ContextMenuStrip = Me.cmClipboardOp
        Me.lvFiles.HideSelection = False
        Me.lvFiles.Location = New System.Drawing.Point(189, 39)
        Me.lvFiles.Name = "lvFiles"
        Me.lvFiles.Size = New System.Drawing.Size(599, 370)
        Me.lvFiles.TabIndex = 2
        Me.lvFiles.UseCompatibleStateImageBehavior = False
        '
        'cboView
        '
        Me.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboView.FormattingEnabled = True
        Me.cboView.Items.AddRange(New Object() {"Large Icon", "Details", "Small Icon", "List", "Tile"})
        Me.cboView.Location = New System.Drawing.Point(12, 12)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(776, 21)
        Me.cboView.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'iIconList
        '
        Me.iIconList.ImageStream = CType(resources.GetObject("iIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.iIconList.Images.SetKeyName(0, "Forest-OS_Logo_NoText.png")
        '
        'Explorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboView)
        Me.Controls.Add(Me.lvFiles)
        Me.Controls.Add(Me.trvFolders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Explorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Explorer"
        Me.TopMost = True
        Me.cmClipboardOp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents trvFolders As TreeView
    Friend WithEvents cmClipboardOp As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvFiles As ListView
    Friend WithEvents cboView As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents iIconList As ImageList
End Class
