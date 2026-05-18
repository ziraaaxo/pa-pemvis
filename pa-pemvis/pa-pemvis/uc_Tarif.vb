Imports MySql.Data.MySqlClient

Partial Public Class uc_Tarif

    Dim selectedKandangId As Integer = 0
    Dim selectedPerawatanId As Integer = 0

    ' ─────────────────────────────────────────────
    ' LOAD
    ' ─────────────────────────────────────────────
    Private Sub uc_Tarif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKandang()
        LoadPerawatan()
        btnUpdateKandang.Enabled = False
        btnUpdatePerawatan.Enabled = False
    End Sub

    ' ═════════════════════════════════════════════
    '  BAGIAN KANDANG
    ' ═════════════════════════════════════════════

    Private Sub LoadKandang()
        Try
            OpenConnection()
            Dim sql As String =
                "SELECT id_kandang     AS 'ID',
                        nomor_kandang  AS 'Nomor',
                        tipe_kandang   AS 'Tipe',
                        harga_per_hari AS 'Harga/Hari',
                        status_kandang AS 'Status'
                 FROM kandang
                 ORDER BY tipe_kandang, nomor_kandang"

            DA = New MySqlDataAdapter(sql, Conn)
            DT = New DataTable()
            DA.Fill(DT)
            dgvKandang.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data kandang: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Klik baris DGV Kandang → isi form
    Private Sub dgvKandang_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvKandang.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvKandang.Rows(e.RowIndex)

        selectedKandangId = CInt(row.Cells("ID").Value)
        ' Tampilkan info di txtInfoKandang (ReadOnly)
        txtInfoKandang.Text = row.Cells("Nomor").Value.ToString() &
                              " | " & row.Cells("Tipe").Value.ToString()
        txtHargaKandang.Text = row.Cells("Harga/Hari").Value.ToString()

        btnUpdateKandang.Enabled = True
        txtHargaKandang.Focus()
        txtHargaKandang.SelectAll()
    End Sub

    ' Tombol Update Tarif Kandang
    Private Sub btnUpdateKandang_Click(sender As Object, e As EventArgs) _
        Handles btnUpdateKandang.Click

        If selectedKandangId = 0 Then
            MessageBox.Show("Pilih data kandang terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(txtHargaKandang.Text.Trim(), harga) OrElse harga <= 0 Then
            MessageBox.Show("Harga harus berupa angka lebih dari 0!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHargaKandang.Focus() : Exit Sub
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Update tarif '" & txtInfoKandang.Text &
                "' menjadi Rp " & harga.ToString("N0") & "?",
                "Konfirmasi Update",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then Exit Sub

        Try
            OpenConnection()
            CMD = New MySqlCommand(
                "UPDATE kandang SET harga_per_hari = @harga
                 WHERE id_kandang = @id", Conn)
            CMD.Parameters.AddWithValue("@harga", harga)
            CMD.Parameters.AddWithValue("@id", selectedKandangId)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Tarif kandang berhasil diperbarui!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal update tarif: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ' Reset
        txtInfoKandang.Clear()
        txtHargaKandang.Clear()
        selectedKandangId = 0
        btnUpdateKandang.Enabled = False
        dgvKandang.ClearSelection()
        LoadKandang()
    End Sub

    ' ═════════════════════════════════════════════
    '  BAGIAN PERAWATAN
    ' ═════════════════════════════════════════════

    Private Sub LoadPerawatan()
        Try
            OpenConnection()
            Dim sql As String =
                "SELECT id_perawatan   AS 'ID',
                        nama_perawatan AS 'Nama Perawatan',
                        harga          AS 'Harga'
                 FROM perawatan
                 ORDER BY nama_perawatan"

            DA = New MySqlDataAdapter(sql, Conn)
            DT = New DataTable()
            DA.Fill(DT)
            dgvPerawatan.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data perawatan: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Klik baris DGV Perawatan → isi form
    Private Sub dgvPerawatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPerawatan.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvPerawatan.Rows(e.RowIndex)

        selectedPerawatanId = CInt(row.Cells("ID").Value)
        txtInfoPerawatan.Text = row.Cells("Nama Perawatan").Value.ToString()
        txtHargaPerawatan.Text = row.Cells("Harga").Value.ToString()

        btnUpdatePerawatan.Enabled = True
        txtHargaPerawatan.Focus()
        txtHargaPerawatan.SelectAll()
    End Sub

    ' Tombol Update Tarif Perawatan
    Private Sub btnUpdatePerawatan_Click(sender As Object, e As EventArgs) _
        Handles btnUpdatePerawatan.Click

        If selectedPerawatanId = 0 Then
            MessageBox.Show("Pilih data perawatan terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(txtHargaPerawatan.Text.Trim(), harga) OrElse harga <= 0 Then
            MessageBox.Show("Harga harus berupa angka lebih dari 0!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHargaPerawatan.Focus() : Exit Sub
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Update tarif '" & txtInfoPerawatan.Text &
                "' menjadi Rp " & harga.ToString("N0") & "?",
                "Konfirmasi Update",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then Exit Sub

        Try
            OpenConnection()
            CMD = New MySqlCommand(
                "UPDATE perawatan SET harga = @harga
                 WHERE id_perawatan = @id", Conn)
            CMD.Parameters.AddWithValue("@harga", harga)
            CMD.Parameters.AddWithValue("@id", selectedPerawatanId)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Tarif perawatan berhasil diperbarui!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal update tarif: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ' Reset
        txtInfoPerawatan.Clear()
        txtHargaPerawatan.Clear()
        selectedPerawatanId = 0
        btnUpdatePerawatan.Enabled = False
        dgvPerawatan.ClearSelection()
        LoadPerawatan()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvKandang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKandang.CellContentClick

    End Sub

    Private Sub dgvPerawatan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerawatan.CellContentClick

    End Sub
End Class