Imports System.IO 'File Operations
Imports System.Runtime.InteropServices 'APIs

'
'Code Credit https://www.codeguru.com/columns/vb/creating-a-windows-explorer-application-with-visual-studio-2012.htm
'

Public Class Explorer
    Private Sub Explorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trvFolders.Sort() 'Sort Alphabetically
        Dim Tnode As TreeNode = trvFolders.Nodes.Add("(Drive C:)") 'Add Main Node
        AddAllFolders(Tnode, "C:\") 'Add All Folders 
        lvFiles.View = View.Details 'Set View of ListView

        ' Add ListView Columns With Specified Width
        lvFiles.Columns.Add("File Name", 150, HorizontalAlignment.Left)
        lvFiles.Columns.Add("File Type", 80, HorizontalAlignment.Left)
        lvFiles.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
    End Sub

    Private Sub AddAllFolders(ByVal TNode As TreeNode, ByVal FolderPath As String)
        Try
            For Each FolderNode As String In Directory.GetDirectories(FolderPath) 'Load All Sub Folders 
                Dim SubFolderNode As TreeNode = TNode.Nodes.Add(FolderNode.Substring(FolderNode.LastIndexOf("\"c) + 1)) 'Add Each Sub Folder Name
                SubFolderNode.Tag = FolderNode 'Set Tag For Each Sub Folder
                SubFolderNode.Nodes.Add("Loading...")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Something Went Wrong
        End Try
    End Sub
    Private Sub trvFolders_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvFolders.BeforeExpand

        If e.Node.Nodes.Count = 1 AndAlso e.Node.Nodes(0).Text = "Loading..." Then
            e.Node.Nodes.Clear() 'Clear All Items
            AddAllFolders(e.Node, CStr(e.Node.Tag)) 'Add All Folders
        End If
    End Sub
    Private Sub trvFolders_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvFolders.AfterSelect
        Dim FileExtension As String 'Stores File Extension
        Dim SubItemIndex As Integer 'Sub Item Counter
        Dim DateMod As String 'Stores Date Modified Of File
        lvFiles.Items.Clear() 'Clear Existing Items
        If trvFolders.SelectedNode.Nodes.Count = 1 AndAlso trvFolders.SelectedNode.Nodes(0).Text = "Loading..." Then
            trvFolders.SelectedNode.Nodes.Clear() 'Reset
            AddAllFolders(trvFolders.SelectedNode, CStr(trvFolders.SelectedNode.Tag))
        End If
        Dim folder As String = CStr(trvFolders.SelectedNode.Tag) 'Folder Name
        If Not folder Is Nothing AndAlso Directory.Exists(folder) Then
            Try
                For Each file As String In Directory.GetFiles(folder) 'Get Files In Folder
                    FileExtension = Path.GetExtension(file) 'Get File Extension(s)
                    DateMod = IO.File.GetLastWriteTime(file).ToString() 'Get Date Modified For Each File
                    AddImages(file) 'Add Icons
                    lvFiles.Items.Add(file.Substring(file.LastIndexOf("\"c) + 1), file.ToString()) 'Add Files & File Properties To ListView
                    lvFiles.Items(SubItemIndex).SubItems.Add(FileExtension.ToString() & " File")
                    lvFiles.Items(SubItemIndex).SubItems.Add(DateMod.ToString())
                    SubItemIndex += 1
                Next
            Catch ex As Exception 'Something Went Wrong
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub AddImages(ByVal strFileName As String)
        Try
            Dim shInfo As SHFILEINFO 'Create File Info Object
            shInfo = New SHFILEINFO() 'Instantiate File Info Object
            shInfo.szDisplayName = New String(vbNullChar, MAX_PATH) 'Get Display Name
            shInfo.szTypeName = New String(vbNullChar, 80) 'Get File Type
            Dim hIcon As IntPtr 'Get File Type Icon Based On File Association
            hIcon = SHGetFileInfo(strFileName, 0, shInfo, Marshal.SizeOf(shInfo), SHGFI_ICON Or SHGFI_SMALLICON)
            Dim MyIcon As Drawing.Bitmap 'Create icon
            MyIcon = Drawing.Icon.FromHandle(shInfo.hIcon).ToBitmap 'Set Icon
            iIconList.Images.Add(strFileName.ToString(), MyIcon) 'Add To ListView FileNames
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source)
        End Try
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim lvItem As ListViewItem 'ListView item
        Dim lvSel As ListView.SelectedListViewItemCollection = Me.lvFiles.SelectedItems 'ListViewItems
        Dim strFileName As String 'File Name
        For Each lvItem In lvSel 'Loop Through Select File Names In ListView
            strFileName = trvFolders.SelectedNode.Tag & "\" & lvItem.Text 'Get Selected File Name
            Dim clpDataObj As New DataObject() 'Create New Data Object
            Dim cbClipBoardFile(0) As String 'Break File Apart Into A String Array
            cbClipBoardFile(0) = strFileName
            clpDataObj.SetData(DataFormats.FileDrop, True, cbClipBoardFile) 'Put String Array Onto ClipBoard
            Clipboard.SetDataObject(clpDataObj)
            MessageBox.Show("File Copied To Clipboard") 'Inform User
        Next
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim idClipboardData As IDataObject = Clipboard.GetDataObject() 'Get Data Present on ClipBoard
        If idClipboardData.GetDataPresent(DataFormats.FileDrop) Then
            Dim strClipFile As String() = DirectCast(idClipboardData.GetData(DataFormats.FileDrop), String()) 'Convert String Array Back Into File
            Dim i As Integer
            For i = 0 To strClipFile.Length - 1
                'If File Exists, Rename COpied File
                If File.Exists(trvFolders.SelectedNode.Tag & "\" & Path.GetFileName(strClipFile(i))) Then
                    File.Move(trvFolders.SelectedNode.Tag & "\" & Path.GetFileName(strClipFile(i)), trvFolders.SelectedNode.Tag & "temp")
                End If
                'Copy File From ClipbBoard
                File.Copy(strClipFile(i), trvFolders.SelectedNode.Tag & "\" & Path.GetFileName(strClipFile(i)))
            Next
            MessageBox.Show("File Pasted From Clipboard") 'Inform User
        End If
    End Sub
    Private Sub cboView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboView.SelectedIndexChanged
        Dim strSelView = CType(cboView.SelectedItem, String) 'Change ListView ViewMode
        Select Case strSelView
            Case "Large Icon"
                lvFiles.View = View.LargeIcon
            Case "Details"
                lvFiles.View = View.Details
            Case "Small Icon"
                lvFiles.View = View.SmallIcon
            Case "List"
                lvFiles.View = View.List
            Case "Tile"
                lvFiles.View = View.Tile
        End Select
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'Exit
    End Sub
    Private Structure SHFILEINFO 'Contains information about a file object
        Public hIcon As IntPtr            'Icon
        Public iIcon As Integer           'Icondex
        Public dwAttributes As Integer    'SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure
    Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" _
            (ByVal pszPath As String,
             ByVal dwFileAttributes As Integer,
             ByRef psfi As SHFILEINFO,
             ByVal cbFileInfo As Integer,
             ByVal uFlags As Integer) As IntPtr 'Retrieves information about an object in the file system, such as a file, folder, directory, or drive root
    Private Const SHGFI_ICON = &H100 'Icon
    Private Const SHGFI_SMALLICON = &H1 'Small Icon
    Private Const SHGFI_LARGEICON = &H0    ' Large icon
    Private Const MAX_PATH = 260 'Path to Icon
End Class