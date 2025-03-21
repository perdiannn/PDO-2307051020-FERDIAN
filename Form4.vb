Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menyiapkan DataGridView
        DataGridView1.ColumnCount = 7
        DataGridView1.Columns(0).Name = "NIP"
        DataGridView1.Columns(1).Name = "Nama"
        DataGridView1.Columns(2).Name = "Jenis Kelamin"
        DataGridView1.Columns(3).Name = "Jurusan"
        DataGridView1.Columns(4).Name = "Mata Kuliah"
        DataGridView1.Columns(5).Name = "Tugas"
        DataGridView1.Columns(6).Name = "UTS"
        DataGridView1.Columns.Add("UAS", "UAS")
        DataGridView1.Columns.Add("Grade", "Grade")

        ' Mengisi ComboBox Jurusan
        cmbxjurusan.Items.Add("Sistem Informasi")
        cmbxjurusan.Items.Add("Ilmu Komputer")
        cmbxjurusan.Items.Add("D3 Manajemen Informatika")
    End Sub

    Private Sub cmbxjurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxjurusan.SelectedIndexChanged
        Dim jurusan As String = cmbxjurusan.SelectedItem
        cmbxmatkul.Items.Clear()
        Select Case (jurusan)
            Case "Sistem Informasi"
                cmbxmatkul.Items.Add("Logika")
                cmbxmatkul.Items.Add("Matematika Diskrit")
                cmbxmatkul.Items.Add("Aljabar Linear")
                cmbxmatkul.Items.Add("Basis Data")
                cmbxmatkul.Items.Add("Pengantar Sistem Informasi")
            Case "Ilmu Komputer"
                cmbxmatkul.Items.Add("Kecerdasan Buatan")
                cmbxmatkul.Items.Add("IOT")
                cmbxmatkul.Items.Add("Robotika")
                cmbxmatkul.Items.Add("Sistem Operasi")
                cmbxmatkul.Items.Add("Algoritma dan Struktur Data")
            Case "D3 Manajemen Informatika"
                cmbxmatkul.Items.Add("Pemrograman Desktop")
                cmbxmatkul.Items.Add("OOP")
                cmbxmatkul.Items.Add("Pemrograman Web")
                cmbxmatkul.Items.Add("Pemrograman Mobile")
                cmbxmatkul.Items.Add("Keamanan Sistem Informasi")
        End Select
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        ' Membersihkan field input
        tbxnip.Enabled = True
        tbxnip.Clear()
        tbxnama.Clear()
        cmbxjurusan.SelectedIndex = -1
        cmbxmatkul.SelectedIndex = -1
        tbxtugas.Clear()
        tbxuts.Clear()
        tbxuas.Clear()
        labelnilai.Text = ""
        rbtnlaki.Checked = False
        rbtnperempuan.Checked = False
        tbxnip.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Validasi input
        If (DataGridView1.SelectedRows.Count > 0) Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells(0).Value = tbxnip.Text
            selectedRow.Cells(1).Value = tbxnama.Text
            selectedRow.Cells(2).Value = rbtnlaki.Text
            selectedRow.Cells(3).Value = cmbxjurusan.Text
            selectedRow.Cells(4).Value = cmbxmatkul.Text
            selectedRow.Cells(5).Value = tbxtugas.Text
        End If

        ' Menghitung nilai akhir dan grade
        Dim tugas As Double = Convert.ToDouble(tbxtugas.Text) * 0.3
        Dim uts As Double = Convert.ToDouble(tbxuts.Text) * 0.3
        Dim uas As Double = Convert.ToDouble(tbxuas.Text) * 0.4
        Dim nilaiAkhir As Double = tugas + uts + uas
        Dim grade As String = HitungGrade(nilaiAkhir)
        labelnilai.Text = grade

        ' Menentukan jenis kelamin
        Dim jenisKelamin As String = If(rbtnlaki.Checked, "Laki-laki", "Perempuan")

        ' Periksa apakah NIP sudah ada (update) atau baru (insert)
        Dim found As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("NIP").Value IsNot Nothing AndAlso row.Cells("NIP").Value.ToString() = tbxnip.Text Then
                row.Cells("Nama").Value = tbxnama.Text
                row.Cells("Jenis Kelamin").Value = jenisKelamin
                row.Cells("Jurusan").Value = cmbxjurusan.Text
                row.Cells("Mata Kuliah").Value = cmbxmatkul.Text
                row.Cells("Tugas").Value = tbxtugas.Text
                row.Cells("UTS").Value = tbxuts.Text
                row.Cells("UAS").Value = tbxuas.Text
                row.Cells("Grade").Value = grade
                found = True
                Exit For
            End If
        Next

        ' Jika data baru, tambahkan ke DataGridView
        If Not found Then
            DataGridView1.Rows.Add(tbxnip.Text, tbxnama.Text, jenisKelamin,
                                   cmbxjurusan.Text, cmbxmatkul.Text,
                                   tbxtugas.Text, tbxuts.Text, tbxuas.Text, grade)
        End If

        ' Bersihkan input
        btnnew.PerformClick()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Konfirmasi sebelum menghapus
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
                btnnew.PerformClick()
            End If
        Else
            MessageBox.Show("Pilih baris yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Menampilkan data dari DataGridView ke input field
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            tbxnip.Text = row.Cells("NIP").Value.ToString()
            tbxnama.Text = row.Cells("Nama").Value.ToString()
            cmbxjurusan.Text = row.Cells("Jurusan").Value.ToString()
            cmbxmatkul.Text = row.Cells("Mata Kuliah").Value.ToString()
            tbxtugas.Text = row.Cells("Tugas").Value.ToString()
            tbxuts.Text = row.Cells("UTS").Value.ToString()
            tbxuas.Text = row.Cells("UAS").Value.ToString()
            labelnilai.Text = row.Cells("Grade").Value.ToString()
            tbxnip.Enabled = False

            ' Set radio button berdasarkan jenis kelamin
            If row.Cells("Jenis Kelamin").Value.ToString() = "Laki-laki" Then
                rbtnlaki.Checked = True
            Else
                rbtnperempuan.Checked = True
            End If
        End If
    End Sub

    Private Function HitungGrade(nilai As Double) As String
        Select Case nilai
            Case Is >= 78 : Return "A"
            Case Is >= 65 : Return "B"
            Case Is >= 50 : Return "C"
            Case Is >= 40 : Return "D"
            Case Else : Return "E"
        End Select
    End Function

    Private Sub cmbxmatkul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxmatkul.SelectedIndexChanged

    End Sub
End Class