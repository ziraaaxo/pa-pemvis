Imports MySql.Data.MySqlClient

Partial Public Class uc_Kandang

    Dim selectedId As Integer = 0

    ' ─────────────────────────────────────────────
    ' LOAD
    ' ─────────────────────────────────────────────
    Private Sub UCKandang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()
        LoadKandang("")
        SetButtonState(False)
    End Sub

    ' ─────────────────────────────────────────────
    ' ISI COMBOBOX
    ' ─────────────────────────────────────────────
    Private Sub LoadComboBox()
        cbTipe.Items.Clear()
        cbTipe.Items.AddRange({"Kecil", "Sedang", "Besar"})
        cbTipe.DropDownStyle = ComboBoxStyle.DropDownList

        cbStatus.Items.Clear()
        cbStatus.Items.AddRange({"Kosong", "Terisi"})
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    ' ─────────────────────────────────────────────
    ' LOAD DATA KE DGV (dengan filter opsional)
    ' ─────────────────────────────────────────────
    Private Sub LoadKandang(filter As String)
        Try
            OpenConnection()

            Dim sql As String =
                "SELECT id_kandang     AS 'ID',
                        nomor_kandang  AS 'Nomor Kandang',
                        tipe_kandang   AS 'Tipe',
                        harga_per_hari AS 'Harga/Hari',
                        status_kandang AS 'Status'
                 FROM kandang"

            If filter <> "" Then
                sql &= " WHERE nomor_kandang LIKE @filter
                            OR tipe_kandang  LIKE @filter
                            OR status_kandang LIKE @filter"
            End If

            sql &= " ORDER BY nomor_kandang"

            DA = New MySqlDataAdapter(sql, Conn)
            If filter <> "" Then
                DA.SelectCommand.Parameters.AddWithValue("@filter", "%" & filter & "%")
            End If

            DT = New DataTable()
            DA.Fill(DT)
            dgvKandang.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' ─────────────────────────────────────────────
    ' AKTIFKAN / NONAKTIFKAN btnUpdate & btnHapus
    ' ─────────────────────────────────────────────
    Private Sub SetButtonState(rowSelected As Boolean)
        btnUpdate.Enabled = rowSelected
        btnHapus.Enabled = rowSelected
    End Sub

    Private Sub ClearForm()
        txtNomor.Clear()
        cbTipe.SelectedIndex = -1
        txtHarga.Clear()
        cbStatus.SelectedIndex = -1
        selectedId = 0
        SetButtonState(False)
        dgvKandang.ClearSelection()
    End Sub

    Private Sub dgvKandang_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvKandang.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvKandang.Rows(e.RowIndex)

        selectedId = CInt(row.Cells("ID").Value)
        txtNomor.Text = row.Cells("Nomor Kandang").Value.ToString()
        cbTipe.Text = row.Cells("Tipe").Value.ToString()
        txtHarga.Text = row.Cells("Harga/Hari").Value.ToString()
        cbStatus.Text = row.Cells("Status").Value.ToString()

        SetButtonState(True)
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL SIMPAN 
    ' ─────────────────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Exit Sub

        Try
            OpenConnection()
            Dim sql As String =
                "INSERT INTO kandang (nomor_kandang, tipe_kandang, harga_per_hari, status_kandang)
                 VALUES (@nomor, @tipe, @harga, @status)"

            CMD = New MySqlCommand(sql, Conn)
            CMD.Parameters.AddWithValue("@nomor", txtNomor.Text.Trim())
            CMD.Parameters.AddWithValue("@tipe", cbTipe.Text)
            CMD.Parameters.AddWithValue("@harga", CDec(txtHarga.Text.Trim()))
            CMD.Parameters.AddWithValue("@status", cbStatus.Text)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadKandang("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL UPDATE 
    ' ─────────────────────────────────────────────
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih baris data terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidasiInput() Then Exit Sub

        Try
            OpenConnection()
            Dim sql As String =
                "UPDATE kandang
                 SET nomor_kandang  = @nomor,
                     tipe_kandang   = @tipe,
                     harga_per_hari = @harga,
                     status_kandang = @status
                 WHERE id_kandang = @id"

            CMD = New MySqlCommand(sql, Conn)
            CMD.Parameters.AddWithValue("@nomor", txtNomor.Text.Trim())
            CMD.Parameters.AddWithValue("@tipe", cbTipe.Text)
            CMD.Parameters.AddWithValue("@harga", CDec(txtHarga.Text.Trim()))
            CMD.Parameters.AddWithValue("@status", cbStatus.Text)
            CMD.Parameters.AddWithValue("@id", selectedId)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diupdate!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal mengupdate: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadKandang("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL HAPUS
    ' ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih baris data terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Yakin ingin menghapus data kandang ini?", "Konfirmasi",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then Exit Sub

        Try
            OpenConnection()
            CMD = New MySqlCommand("DELETE FROM kandang WHERE id_kandang = @id", Conn)
            CMD.Parameters.AddWithValue("@id", selectedId)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message & Environment.NewLine &
                            "(Kandang mungkin masih terhubung dengan data booking)",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadKandang("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL CARI & ENTER KEY
    ' ─────────────────────────────────────────────
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadKandang(txtCari.Text.Trim())
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadKandang(txtCari.Text.Trim())
    End Sub

    ' ─────────────────────────────────────────────
    ' VALIDASI INPUT
    ' ─────────────────────────────────────────────
    Private Function ValidasiInput() As Boolean
        If String.IsNullOrWhiteSpace(txtNomor.Text) Then
            MessageBox.Show("Nomor Kandang tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomor.Focus() : Return False
        End If

        If cbTipe.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Tipe Kandang!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbTipe.Focus() : Return False
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(txtHarga.Text.Trim(), harga) OrElse harga <= 0 Then
            MessageBox.Show("Harga Per Hari harus berupa angka lebih dari 0!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus() : Return False
        End If

        If cbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Status Kandang!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbStatus.Focus() : Return False
        End If

        Return True
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
