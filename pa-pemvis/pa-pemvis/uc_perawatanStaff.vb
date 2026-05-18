Imports MySql.Data.MySqlClient
Imports System.Data

Public Class uc_PerawatanStaff

    Private Sub uc_PerawatanStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtTanggal.Value = Date.Today
        btnUpdate.Enabled = False
        btnHapus.Enabled = False

        LoadComboBoxes()
        LoadData()
    End Sub

    Private Sub LoadComboBoxes()
        OpenConnection()
        Try
            CMD = New MySqlCommand("SELECT id, nama FROM hewan", Conn)
            DA = New MySqlDataAdapter(CMD)
            DT = New DataTable
            DA.Fill(DT)
            cbNamaHewan.DataSource = DT
            cbNamaHewan.DisplayMember = "nama"
            cbNamaHewan.ValueMember = "id"

            CMD = New MySqlCommand("SELECT id, nama, harga FROM jenis_perawatan", Conn)
            DA = New MySqlDataAdapter(CMD)
            DT = New DataTable
            DA.Fill(DT)
            cbJenisPerawatan.DataSource = DT
            cbJenisPerawatan.DisplayMember = "nama"
            cbJenisPerawatan.ValueMember = "id"

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data ComboBox: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoadData()
        OpenConnection()
        Try
            Dim query As String = "
                SELECT 
                    p.id, 
                    h.nama AS Hewan, 
                    jp.nama AS Perawatan, 
                    p.tanggal, 
                    p.catatan 
                FROM perawatan p
                JOIN hewan h ON p.id_hewan = h.id
                JOIN jenis_perawatan jp ON p.id_jenis_perawatan = jp.id
                ORDER BY p.tanggal DESC"

            CMD = New MySqlCommand(query, Conn)
            DA = New MySqlDataAdapter(CMD)
            DT = New DataTable
            DA.Fill(DT)
            dgvPerawatan.DataSource = DT
            dgvPerawatan.Columns("id").Visible = False

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data tabel: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ClearInput()
        cbNamaHewan.SelectedIndex = -1
        cbJenisPerawatan.SelectedIndex = -1
        txtTarif.Text = ""
        dtTanggal.Value = Date.Today
        txtCatatan.Clear()
    End Sub

    Private Sub cbJenisPerawatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenisPerawatan.SelectedIndexChanged
        If cbJenisPerawatan.SelectedIndex > -1 Then
            Dim row As DataRowView = CType(cbJenisPerawatan.SelectedItem, DataRowView)
            If row IsNot Nothing Then
                txtTarif.Text = row("harga").ToString()
            End If
        Else
            txtTarif.Text = ""
        End If
    End Sub

    Private Sub dgvPerawatan_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPerawatan.SelectionChanged
        If dgvPerawatan.SelectedRows.Count > 0 Then
            btnUpdate.Enabled = True
            btnHapus.Enabled = True
        Else
            btnUpdate.Enabled = False
            btnHapus.Enabled = False
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If IsComboEmpty(cbNamaHewan) Then Return
        If IsComboEmpty(cbJenisPerawatan) Then Return
        If IsEmpty(txtTarif) Then Return

        Dim idHewan As Integer = CInt(cbNamaHewan.SelectedValue)
        Dim idJenis As Integer = CInt(cbJenisPerawatan.SelectedValue)
        Dim tanggal As Date = dtTanggal.Value
        Dim catatan As String = txtCatatan.Text

        OpenConnection()
        Try
            Dim query As String = "INSERT INTO perawatan (id_hewan, id_jenis_perawatan, tanggal, catatan) VALUES (@idHewan, @idJenis, @tanggal, @catatan)"
            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@idHewan", idHewan)
            CMD.Parameters.AddWithValue("@idJenis", idJenis)
            CMD.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@catatan", catatan)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Perawatan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadData()
            ClearInput()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvPerawatan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin diupdate.")
            Return
        End If

        Dim idPerawatan As Integer = dgvPerawatan.CurrentRow.Cells("id").Value

        If IsComboEmpty(cbNamaHewan) Then Return
        If IsComboEmpty(cbJenisPerawatan) Then Return

        Dim idHewan As Integer = cbNamaHewan.SelectedValue
        Dim idJenis As Integer = cbJenisPerawatan.SelectedValue
        Dim tanggal = dtTanggal.Value
        Dim catatan = txtCatatan.Text

        OpenConnection()

        Try
            Dim query = "UPDATE perawatan SET id_hewan=@idHewan, id_jenis_perawatan=@idJenis, tanggal=@tanggal, catatan=@catatan WHERE id=@idPerawatan"
            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@idHewan", idHewan)
            CMD.Parameters.AddWithValue("@idJenis", idJenis)
            CMD.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@catatan", catatan)
            CMD.Parameters.AddWithValue("@idPerawatan", idPerawatan)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Perawatan berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadData()
            ClearInput()
            btnUpdate.Enabled = False
            btnHapus.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Gagal mengupdate data: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvPerawatan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus.")
            Return
        End If

        Dim idPerawatan As Integer = CInt(dgvPerawatan.CurrentRow.Cells("id").Value)
        Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            OpenConnection()
            Try
                Dim query As String = "DELETE FROM perawatan WHERE id=@idPerawatan"
                CMD = New MySqlCommand(query, Conn)
                CMD.Parameters.AddWithValue("@idPerawatan", idPerawatan)

                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadData()
                ClearInput()
                btnUpdate.Enabled = False
                btnHapus.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

End Class