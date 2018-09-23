Imports System.IO


Public Class Form1
    ' ------------------------- DRAG & DROP -----------------------------------
    'when item has been dropped
    Dim tampFile As List(Of Files) = New List(Of Files)
    Dim newTabe As Integer
    Dim tampUserControl As List(Of UserControl1) = New List(Of UserControl1)
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
            files = dirinfo.GetFiles("*.txt", IO.SearchOption.TopDirectoryOnly)
            Dim err As String
            For Each file In files
                Dim selectedValue As Files
                selectedValue = tampFile.Find(Function(p) p.Path = directory & "\" & file.ToString)
                If (selectedValue Is Nothing) Then
                    Dim filea As Files = New Files(directory & "\" & file.ToString, directory & " - " & file.ToString)
                    tampFile.Add(filea)
                    ListView1.Items.Add(directory & " - " & file.ToString)
                Else
                    err = "Ada yang yang sudah ada di daftar"
                End If
            Next
            If (err Is Nothing) Then
                MsgBox("Folder Berhasil dimasukan ke list")
            Else
                MsgBox(err)
            End If
        End If
    End Sub

    ' --------- menu "BUAT BARU" ---------------
    Private Sub BuatBaruToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuatBaruToolStripMenuItem1.Click
        Dim newPage As New TabPage()
        newPage.Text = "New Tab"
        Dim X As New UserControl1()
        newPage.Controls.Add(X)
        newPage.Name = "New Tab" & newTabe
        X.Path = ""
        X.Name = "New Tab" & newTabe
        newTabe += 1
        TabControl1.TabPages.Add(newPage)
        TabControl1.SelectedTab = newPage
        tampUserControl.Add(X)
    End Sub

    ' --------- menu "BUKA FILE" ---------------
    Private Sub BukaFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFileToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim selectedValue As Files
            selectedValue = tampFile.Find(Function(p) p.Path = OpenFileDialog1.FileName)
            If (selectedValue Is Nothing) Then
                MsgBox("file berhasil di tambah")
                Dim file As Files = New Files(OpenFileDialog1.FileName, Path.GetDirectoryName(OpenFileDialog1.FileName) & " - " & Path.GetFileName(OpenFileDialog1.FileName))
                tampFile.Add(file)
                ListView1.Items.Add(Path.GetDirectoryName(OpenFileDialog1.FileName) & " - " & Path.GetFileName(OpenFileDialog1.FileName))
            Else
                MsgBox("file sudah ada")
            End If

        End If

    End Sub

    ' -------- OPEN TAB DOUBLE KLIK ------------
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        For Each file In tampFile
            If (file.Name) = ListView1.SelectedItems(0).Text Then
                Dim newPage As New TabPage()
                newPage.Text = file.Name
                Dim X As New UserControl1()
                X.txtNotepad.Text = System.IO.File.ReadAllText(file.Path)
                X.Path = file.Path
                X.Name = file.Name
                newPage.Controls.Add(X)
                TabControl1.TabPages.Add(newPage)
                TabControl1.SelectedTab = newPage
                tampUserControl.Add(X)
            End If
        Next
    End Sub

    '---------------- klik kanan "KELUAR" ------------------
    Private Sub KeluarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem2.Click
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        TabControl1.SelectedIndex = 0
    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim dr As DialogResult
        If (TabControl1.SelectedTab.Text = "New Tab") Then
            dr = SaveFileDialog1.ShowDialog()
            If dr = DialogResult.OK Then
                For Each nameFile In tampUserControl
                    If nameFile.Name = TabControl1.SelectedTab.Name Then

                        System.IO.File.WriteAllText(SaveFileDialog1.FileName, nameFile.txtNotepad.Text)
                        'MsgBox(Path.GetFileName(SaveFileDialog1.FileName))
                        Dim file As Files = New Files(SaveFileDialog1.FileName, Path.GetDirectoryName(SaveFileDialog1.FileName) & " - " & Path.GetFileName(SaveFileDialog1.FileName))
                        tampFile.Add(file)
                        ListView1.Items.Add(Path.GetDirectoryName(SaveFileDialog1.FileName) & " - " & Path.GetFileName(SaveFileDialog1.FileName))
                        TabControl1.SelectedTab.Text = Path.GetDirectoryName(SaveFileDialog1.FileName) & " - " & Path.GetFileName(SaveFileDialog1.FileName)
                    End If
                Next
                MsgBox("File Berhasil Tersimpan")
            End If
        Else
            For Each nameFile In tampUserControl
                If nameFile.Name = TabControl1.SelectedTab.Text Then
                    'MsgBox(nameFile.Path)
                    System.IO.File.WriteAllText(nameFile.Path, nameFile.txtNotepad.Text)

                End If
            Next
            MsgBox("File Berhasil Tersimpan")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newTabe = 1
    End Sub
End Class
