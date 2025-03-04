Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbxfakultas.Items.Add("FMIPA")
        cmbxfakultas.Items.Add("FKIP")
        cmbxfakultas.Items.Add("FEB")

        If cmbxfakultas.Items.Count > 0 Then
            cmbxfakultas.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim nip As String = tbxnip.Text
        Dim nama As String = tbxnama.Text
        Dim fakultas As String = cmbxfakultas.Text
        Dim jurusan As String = cmbxjurusan.Text

        Dim message As String = "Hai : " & nip & vbCrLf &
                               "Nip : " & nama & vbCrLf &
                               "Fakultas : " & fakultas & vbCrLf &
                               "Jurusan : " & jurusan

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
End Class
