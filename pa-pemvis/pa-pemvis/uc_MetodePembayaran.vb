Imports MySql.Data.MySqlClient

Partial Public Class uc_MetodePembayaran

    Dim selectedId As Integer = 0

    ' ─────────────────────────────────────────────
    ' LOAD
    ' ─────────────────────────────────────────────
    Private Sub uc_MetodePembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMetode("")
        SetButtonState(False)
    End Sub

    ' ─────────────────────────────────────────────
    ' LOAD DATA KE DGV
    ' ─────────────────────────────────────────────
    Private Sub LoadMetode(filter As String)
        Try
            OpenConnection()

            Dim sql As String =
                "SELECT id_metode   AS 'ID',
                        nama_metode AS 'Nama Metode'
                 FROM metode_pembayaran"

            If filter <> "" Then
                sql &= " WHERE nama_metode LIKE @filter"
            End If

            sql &= " ORDER BY id_metode"

            DA = New MySqlDataAdapter(sql, Conn)
            If filter <> "" Then
                DA.SelectCommand.Parameters.AddWithValue("@filter", "%" & filter & "%")
            End If

            DT = New DataTable()
            DA.Fill(DT)
            dgvMetode.DataSource = DT

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

    ' ─────────────────────────────────────────────
    ' BERSIHKAN FORM
    ' ─────────────────────────────────────────────
    Private Sub ClearForm()
        txtNama.Clear()
        selectedId = 0
        SetButtonState(False)
        dgvMetode.ClearSelection()
    End Sub

    ' ─────────────────────────────────────────────
    ' KLIK BARIS DGV → ISI FORM
    ' ─────────────────────────────────────────────
    Private Sub dgvMetode_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvMetode.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvMetode.Rows(e.RowIndex)

        selectedId = CInt(row.Cells("ID").Value)
        txtNama.Text = row.Cells("Nama Metode").Value.ToString()

        SetButtonState(True)
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL SIMPAN 
    ' ─────────────────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidasiInput() Then Exit Sub

        Try
            OpenConnection()
            CMD = New MySqlCommand(
                "INSERT INTO metode_pembayaran (nama_metode) VALUES (@nama)", Conn)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
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
        LoadMetode("")
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
            CMD = New MySqlCommand(
                "UPDATE metode_pembayaran
                 SET nama_metode = @nama
                 WHERE id_metode = @id", Conn)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
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
        LoadMetode("")
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
            MessageBox.Show("Yakin ingin menghapus metode ini?", "Konfirmasi",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then Exit Sub

        Try
            OpenConnection()
            CMD = New MySqlCommand(
                "DELETE FROM metode_pembayaran WHERE id_metode = @id", Conn)
            CMD.Parameters.AddWithValue("@id", selectedId)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadMetode("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL CARI
    ' ─────────────────────────────────────────────
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadMetode(txtCari.Text.Trim())
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadMetode(txtCari.Text.Trim())
    End Sub

    ' ─────────────────────────────────────────────
    ' VALIDASI INPUT
    ' ─────────────────────────────────────────────
    Private Function ValidasiInput() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama Metode tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Return False
        End If
        Return True
    End Function

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvMetode_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMetode.CellContentClick

    End Sub
End Class
