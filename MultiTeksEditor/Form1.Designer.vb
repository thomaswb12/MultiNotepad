<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TampilkanDalamFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuatBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatBaruToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TabControl1.Location = New System.Drawing.Point(361, 57)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(689, 482)
        Me.TabControl1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.KeluarToolStripMenuItem2, Me.ToolStripMenuItem1, Me.TampilkanDalamFolderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(236, 82)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.SaveToolStripMenuItem.Text = "Simpan"
        '
        'KeluarToolStripMenuItem2
        '
        Me.KeluarToolStripMenuItem2.Name = "KeluarToolStripMenuItem2"
        Me.KeluarToolStripMenuItem2.Size = New System.Drawing.Size(235, 24)
        Me.KeluarToolStripMenuItem2.Text = "Keluar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(232, 6)
        '
        'TampilkanDalamFolderToolStripMenuItem
        '
        Me.TampilkanDalamFolderToolStripMenuItem.Name = "TampilkanDalamFolderToolStripMenuItem"
        Me.TampilkanDalamFolderToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.TampilkanDalamFolderToolStripMenuItem.Text = "Tampilkan dalam folder"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(8, 23)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(328, 474)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatBaruToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuatBaruToolStripMenuItem
        '
        Me.BuatBaruToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatBaruToolStripMenuItem1, Me.BukaFileToolStripMenuItem, Me.BukaFolderToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.KeluarToolStripMenuItem1})
        Me.BuatBaruToolStripMenuItem.Name = "BuatBaruToolStripMenuItem"
        Me.BuatBaruToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.BuatBaruToolStripMenuItem.Text = "File"
        '
        'BuatBaruToolStripMenuItem1
        '
        Me.BuatBaruToolStripMenuItem1.Name = "BuatBaruToolStripMenuItem1"
        Me.BuatBaruToolStripMenuItem1.Size = New System.Drawing.Size(162, 26)
        Me.BuatBaruToolStripMenuItem1.Text = "Buat Baru"
        '
        'BukaFileToolStripMenuItem
        '
        Me.BukaFileToolStripMenuItem.Name = "BukaFileToolStripMenuItem"
        Me.BukaFileToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.BukaFileToolStripMenuItem.Text = "Buka File"
        '
        'BukaFolderToolStripMenuItem
        '
        Me.BukaFolderToolStripMenuItem.Name = "BukaFolderToolStripMenuItem"
        Me.BukaFolderToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.BukaFolderToolStripMenuItem.Text = "Buka Folder"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(159, 6)
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(162, 26)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.txt"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text File|*.txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.txt"
        Me.SaveFileDialog1.FileName = "Untitled.txt"
        Me.SaveFileDialog1.Filter = "Text File|*.txt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(345, 506)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Catatan"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ListView1 As ListView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BuatBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatBaruToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BukaFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents TampilkanDalamFolderToolStripMenuItem As ToolStripMenuItem
End Class
