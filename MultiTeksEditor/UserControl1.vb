Public Class UserControl1
    'masukkin font yang ada di komputer ke combobox
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        'If (FontDialog1.ShowDialog = DialogResult.OK) Then
        'End If
        For Each oFont As FontFamily In FontFamily.Families
            ComboBox1.Items.Add(oFont.Name)
        Next
    End Sub

    '----------------- untuk setting FONT dan SIZE pada notepad -----------------------
    'ini untuk set default font nya arial
    Dim font As String = "Arial"
    'ketika pilih font
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        font = ComboBox1.SelectedItem.ToString
        txtNotepad.Font = New Font(font, NumericUpDown1.Value)
    End Sub
    'ketika form diload (pake defaultnya Arial,8)
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNotepad.Font = New Font(font, NumericUpDown1.Value)
    End Sub
    'ketika size diatur
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        txtNotepad.Font = New Font(font, NumericUpDown1.Value)
    End Sub
    ' ---------------------------- END -------------------------------------

End Class
