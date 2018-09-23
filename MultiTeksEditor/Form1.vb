Imports System.IO
Public Class Form1
    ' ------------------------- DRAG & DROP -----------------------------------
    'when item has been dropped
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        'take dropped items and hold in array
        Dim droppedItems As String() = e.Data.GetData(DataFormats.FileDrop)

        'loop thru all dropped files displaying them
        For Each pathh In droppedItems
            'check isDirectory?
            If Directory.Exists(pathh) Then
                Dim files() As FileInfo
                Dim dirinfo As New DirectoryInfo(pathh)
                files = dirinfo.GetFiles("*.txt", SearchOption.AllDirectories)
                For Each file In files
                    ListView1.Items.Add(pathh & " - " & file.ToString)
                Next
            Else
                ListView1.Items.Add(pathh)
            End If
        Next
    End Sub
    'when mouse drags to form, just about to drop
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    ' ------------------------------- END ---------------------------------------

    ' ------ menu "BUKA FOLDER" --------------
    Private Sub BukaFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFolderToolStripMenuItem.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Dim directory = FolderBrowserDialog1.SelectedPath
            Dim files() As System.IO.FileInfo
            Dim dirinfo As New System.IO.DirectoryInfo(directory)
            files = dirinfo.GetFiles("*.txt", IO.SearchOption.AllDirectories)
            For Each file In files
                ListView1.Items.Add(directory & " - " & file.ToString)
            Next
        End If
    End Sub

    ' --------- menu "BUAT BARU" ---------------
    Private Sub BuatBaruToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuatBaruToolStripMenuItem1.Click
        Dim newPage As New TabPage()
        newPage.Text = "New Tab"
        Dim X As New UserControl1()
        newPage.Controls.Add(X)
        TabControl1.TabPages.Add(newPage)
        TabControl1.SelectedTab = newPage
    End Sub
End Class
