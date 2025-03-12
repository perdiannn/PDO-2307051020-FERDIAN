Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbxfakultas.Items.Add("FMIPA")
        cmbxfakultas.Items.Add("FKIP")
        cmbxfakultas.Items.Add("FEB")

        If cmbxfakultas.Items.Count > 0 Then
            cmbxfakultas.SelectedIndex = 0
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim nip As String = tbxnip.Text
        Dim nama As String = tbxnama.Text
        Dim fakultas As String = cmbxfakultas.Text
        Dim jurusan As String = cmbxjurusan.Text
        Dim jeniskelamin As String = ""
        If rbtnlaki.Checked Then
            jeniskelamin = "Laki-Laki"
        ElseIf rbtnperempuan.Checked Then
            jeniskelamin = "Perempuan"
        End If

        Dim message As String = "Hai : " & nip & vbCrLf &
                                "Nip : " & nama & vbCrLf &
                                "Fakultas : " & fakultas & vbCrLf &
                                "Jurusan : " & jurusan & vbCrLf &
                                "Jenis Kelamin : " & jeniskelamin

        MessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub labelnip_Click(sender As Object, e As EventArgs) Handles labelnip.Click

    End Sub

    Private Sub tbxnip_TextChanged(sender As Object, e As EventArgs) Handles tbxnip.TextChanged

    End Sub

    Private Sub labelnama_Click(sender As Object, e As EventArgs) Handles labelnama.Click

    End Sub

    Private Sub tbxnama_TextChanged(sender As Object, e As EventArgs) Handles tbxnama.TextChanged

    End Sub

    Private Sub labeljeniskelamin_Click(sender As Object, e As EventArgs) Handles labeljeniskelamin.Click

    End Sub

    Private Sub rbtnlaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnlaki.CheckedChanged

    End Sub

    Private Sub rbtnperempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnperempuan.CheckedChanged

    End Sub

    Private Sub labelfakultas_Click(sender As Object, e As EventArgs) Handles labelfakultas.Click

    End Sub

    Private Sub cmbxfakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxfakultas.SelectedIndexChanged
        cmbxjurusan.Items.Clear()

        Dim fakultas As String = cmbxfakultas.Text

        Select Case fakultas
            Case "FMIPA"
                cmbxjurusan.Items.Add("Matematika")
                cmbxjurusan.Items.Add("Kimia")
                cmbxjurusan.Items.Add("Biologi")
                cmbxjurusan.Items.Add("Fisika")
                cmbxjurusan.Items.Add("Ilmu Komputer")

            Case "FKIP"
                cmbxjurusan.Items.Add("Pendidikan Matematika")
                cmbxjurusan.Items.Add("Pendidikan Kimia")
                cmbxjurusan.Items.Add("Pendidikan Biologi")
                cmbxjurusan.Items.Add("Pendidikan Fisika")
                cmbxjurusan.Items.Add("Pendidikan Bahasa Indonesia")

            Case "FEB"
                cmbxjurusan.Items.Add("Manajemen")
                cmbxjurusan.Items.Add("Akuntansi")
                cmbxjurusan.Items.Add("Bisnis Digital")
                cmbxjurusan.Items.Add("Pemasaran")
                cmbxjurusan.Items.Add("Keuangan dan Perbankan")
        End Select

        If cmbxjurusan.Items.Count > 0 Then
            cmbxjurusan.SelectedIndex = 0
        End If
    End Sub

    Private Sub labeljurusan_Click(sender As Object, e As EventArgs) Handles labeljurusan.Click

    End Sub

    Private Sub cmbxjurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxjurusan.SelectedIndexChanged

    End Sub

    Private Sub labelnilai_Click(sender As Object, e As EventArgs) Handles labelnilai.Click

    End Sub

    Private Sub labeltugas_Click(sender As Object, e As EventArgs) Handles labeltugas.Click

    End Sub

    Private Sub tbxtugas_TextChanged(sender As Object, e As EventArgs) Handles tbxtugas.TextChanged

    End Sub

    Private Sub labeluts_Click(sender As Object, e As EventArgs) Handles labeluts.Click

    End Sub

    Private Sub tbxuts_TextChanged(sender As Object, e As EventArgs) Handles tbxuts.TextChanged

    End Sub

    Private Sub labeluas_Click(sender As Object, e As EventArgs) Handles labeluas.Click

    End Sub

    Private Sub tbxuas_TextChanged(sender As Object, e As EventArgs) Handles tbxuas.TextChanged

    End Sub

    Private Sub btngrade_Click(sender As Object, e As EventArgs) Handles btngrade.Click
        Dim tugas As Double = Val(tbxtugas.Text)
        Dim uts As Double = Val(tbxuts.Text)
        Dim uas As Double = Val(tbxuas.Text)

        If tugas < 0 Or tugas > 100 Or uts < 0 Or uts > 100 Or uas < 0 Or uas > 100 Then
            MessageBox.Show("Nilai harus antara 0 - 100", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Hitung nilai akhir berdasarkan bobot
        Dim nilaiAkhir As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        ' Tentukan grade
        Dim grade As String
        If nilaiAkhir >= 78 And nilaiAkhir <= 90 Then
            grade = "A"
        ElseIf nilaiAkhir >= 65 And nilaiAkhir < 78 Then
            grade = "B"
        ElseIf nilaiAkhir >= 50 And nilaiAkhir < 65 Then
            grade = "C"
        ElseIf nilaiAkhir >= 40 And nilaiAkhir < 50 Then
            grade = "D"
        Else
            grade = "E"
        End If

        MessageBox.Show("Nilai Akhir: " & nilaiAkhir.ToString("0.00") & vbCrLf &
                        "Grade: " & grade,
                        "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class