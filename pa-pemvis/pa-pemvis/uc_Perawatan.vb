Imports MySql.Data.MySqlClient

Partial Public Class uc_Perawatan
    Dim selectedId As Integer = 0

    ' ─────────────────────────────────────────────
    ' LOAD
    ' ─────────────────────────────────────────────
    Private Sub uc_Perawatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPerawatan("")
        SetButtonState(False)
    End Sub

    ' ─────────────────────────────────────────────
    ' LOAD DATA KE DGV
    ' ─────────────────────────────────────────────
    Private Sub LoadPerawatan(filter As String)
        Try
            OpenConnection()

            Dim sql As String = "SELECT id_perawatan AS 'ID', nama_perawatan AS 'Nama Perawatan', harga AS 'Harga' FROM perawatan"

            If Not String.IsNullOrWhiteSpace(filter) Then
                sql &= " WHERE nama_perawatan LIKE @filter"
            End If

            sql &= " ORDER BY nama_perawatan"

            Dim DA As New MySqlDataAdapter(sql, Conn)
            If Not String.IsNullOrWhiteSpace(filter) Then
                DA.SelectCommand.Parameters.AddWithValue("@filter", "%" & filter & "%")
            End If

            Dim DT As New DataTable()
            DA.Fill(DT)
            dgvPerawatan.DataSource = DT

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtHarga.Clear()
        selectedId = 0
        SetButtonState(False)
        dgvPerawatan.ClearSelection()
    End Sub

    ' ─────────────────────────────────────────────
    ' KLIK BARIS DGV → ISI FORM
    ' ─────────────────────────────────────────────
    Private Sub dgvPerawatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPerawatan.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvPerawatan.Rows(e.RowIndex)

        selectedId = CInt(row.Cells("ID").Value)
        txtNama.Text = row.Cells("Nama Perawatan").Value.ToString()
        txtHarga.Text = row.Cells("Harga").Value.ToString()

        SetButtonState(True)
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL SIMPAN — INSERT
    ' ─────────────────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Exit Sub

        Try
            OpenConnection()
            Using CMD As New MySqlCommand("INSERT INTO perawatan (nama_perawatan, harga) VALUES (@nama, @harga)", Conn)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
                CMD.Parameters.AddWithValue("@harga", CDec(txtHarga.Text.Trim()))
                CMD.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadPerawatan("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL UPDATE
    ' ─────────────────────────────────────────────
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih baris data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidasiInput() Then Exit Sub

        Try
            OpenConnection()
            Using CMD As New MySqlCommand("UPDATE perawatan SET nama_perawatan = @nama, harga = @harga WHERE id_perawatan = @id", Conn)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
                CMD.Parameters.AddWithValue("@harga", CDec(txtHarga.Text.Trim()))
                CMD.Parameters.AddWithValue("@id", selectedId)
                CMD.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal mengupdate: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadPerawatan("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL HAPUS
    ' ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih baris data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin menghapus data perawatan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then Exit Sub

        Try
            OpenConnection()
            Using CMD As New MySqlCommand("DELETE FROM perawatan WHERE id_perawatan = @id", Conn)
                CMD.Parameters.AddWithValue("@id", selectedId)
                CMD.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message & Environment.NewLine & "(Perawatan mungkin masih terhubung dengan transaksi)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        ClearForm()
        LoadPerawatan("")
    End Sub

    ' ─────────────────────────────────────────────
    ' TOMBOL CARI
    ' ─────────────────────────────────────────────
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadPerawatan(txtCari.Text.Trim())
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadPerawatan(txtCari.Text.Trim())
    End Sub

    ' ─────────────────────────────────────────────
    ' VALIDASI INPUT
    ' ─────────────────────────────────────────────
    Private Function ValidasiInput() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama Perawatan tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return False
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(txtHarga.Text.Trim(), harga) OrElse harga <= 0 Then
            MessageBox.Show("Harga harus berupa angka lebih dari 0!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvPerawatan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerawatan.CellContentClick

    End Sub
End Class
