Imports MySql.Data.MySqlClient
Imports System.Data

Public Class uc_PerawatanStaff

    ' =====================================
    ' LOAD USERCONTROL
    ' =====================================
    Private Sub uc_PerawatanStaff_Load(sender As Object,
                                       e As EventArgs) _
                                       Handles MyBase.Load

        dtTanggal.Value = Date.Today

        btnUpdate.Enabled = False
        btnHapus.Enabled = False

        txtTarif.ReadOnly = True

        TampilHewan()
        TampilPerawatan()
        TampilData()

    End Sub

    ' =====================================
    ' TAMPIL COMBO HEWAN
    ' =====================================
    Sub TampilHewan()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT
                    id_hewan,
                    nama_hewan
                 FROM hewan
                 ORDER BY nama_hewan ASC",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            cbNamaHewan.DataSource = DT

            cbNamaHewan.DisplayMember =
                "nama_hewan"

            cbNamaHewan.ValueMember =
                "id_hewan"

            cbNamaHewan.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =====================================
    ' TAMPIL COMBO PERAWATAN
    ' =====================================
    Sub TampilPerawatan()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT
                    id_perawatan,
                    nama_perawatan,
                    harga
                 FROM perawatan
                 ORDER BY nama_perawatan ASC",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            cbJenisPerawatan.DataSource = DT

            cbJenisPerawatan.DisplayMember =
                "nama_perawatan"

            cbJenisPerawatan.ValueMember =
                "id_perawatan"

            cbJenisPerawatan.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =====================================
    ' AUTO TAMPIL TARIF
    ' =====================================
    Private Sub cbJenisPerawatan_SelectedIndexChanged(
        sender As Object,
        e As EventArgs) _
        Handles cbJenisPerawatan.SelectedIndexChanged

        Try

            If cbJenisPerawatan.SelectedIndex <> -1 Then

                Dim row As DataRowView =
                    CType(cbJenisPerawatan.SelectedItem,
                    DataRowView)

                txtTarif.Text =
                    row("harga").ToString()

            End If

        Catch ex As Exception

        End Try

    End Sub

    ' =====================================
    ' TAMPIL DATA
    ' =====================================
    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT
                    dp.id_detail,
                    h.nama_hewan,
                    p.nama_perawatan,
                    p.harga,
                    dp.qty,
                    dp.subtotal
                 FROM detail_perawatan dp
                 JOIN booking b
                    ON dp.id_booking = b.id_booking
                 JOIN hewan h
                    ON b.id_hewan = h.id_hewan
                 JOIN perawatan p
                    ON dp.id_perawatan = p.id_perawatan
                 ORDER BY dp.id_detail DESC",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvPerawatan.DataSource = DT

            dgvPerawatan.Columns(0).Visible = False

            dgvPerawatan.Columns(1).HeaderText =
                "Nama Hewan"

            dgvPerawatan.Columns(2).HeaderText =
                "Jenis Perawatan"

            dgvPerawatan.Columns(3).HeaderText =
                "Tarif"

            dgvPerawatan.Columns(4).HeaderText =
                "Qty"

            dgvPerawatan.Columns(5).HeaderText =
                "Subtotal"

            dgvPerawatan.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =====================================
    ' CLEAR FORM
    ' =====================================
    Sub Bersih()

        cbNamaHewan.SelectedIndex = -1

        cbJenisPerawatan.SelectedIndex = -1

        txtTarif.Clear()

        txtCatatan.Clear()

        dtTanggal.Value = Date.Today

    End Sub

    ' =====================================
    ' SIMPAN
    ' =====================================
    Private Sub btnSimpan_Click(sender As Object,
                                e As EventArgs) _
                                Handles btnSimpan.Click

        If cbNamaHewan.Text = "" Then

            MessageBox.Show(
                "Nama hewan wajib dipilih")

            Exit Sub

        End If

        If cbJenisPerawatan.Text = "" Then

            MessageBox.Show(
                "Jenis perawatan wajib dipilih")

            Exit Sub

        End If

        Try

            OpenConnection()

            ' cari id booking berdasarkan hewan
            Dim idBooking As Integer = 0

            CMD = New MySqlCommand(
                "SELECT id_booking
                 FROM booking
                 WHERE id_hewan=@idHewan
                 ORDER BY id_booking DESC
                 LIMIT 1", Conn)

            CMD.Parameters.AddWithValue(
                "@idHewan",
                cbNamaHewan.SelectedValue)

            Dim result = CMD.ExecuteScalar()

            If result IsNot Nothing Then

                idBooking = result

            Else

                MessageBox.Show(
                    "Booking tidak ditemukan")

                Exit Sub

            End If

            ' subtotal = harga
            Dim subtotal As Decimal =
                Val(txtTarif.Text)

            CMD = New MySqlCommand(
                "INSERT INTO detail_perawatan
                (
                    id_booking,
                    id_perawatan,
                    qty,
                    subtotal
                )
                VALUES
                (
                    @idBooking,
                    @idPerawatan,
                    @qty,
                    @subtotal
                )", Conn)

            CMD.Parameters.AddWithValue(
                "@idBooking",
                idBooking)

            CMD.Parameters.AddWithValue(
                "@idPerawatan",
                cbJenisPerawatan.SelectedValue)

            CMD.Parameters.AddWithValue(
                "@qty",
                1)

            CMD.Parameters.AddWithValue(
                "@subtotal",
                subtotal)

            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Data berhasil disimpan")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =====================================
    ' KLIK DATA GRID
    ' =====================================
    Private Sub dgvPerawatan_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvPerawatan.CellClick

        If e.RowIndex >= 0 Then

            btnUpdate.Enabled = True
            btnHapus.Enabled = True

            cbNamaHewan.Text =
                dgvPerawatan.Rows(e.RowIndex).
                Cells(1).Value.ToString()

            cbJenisPerawatan.Text =
                dgvPerawatan.Rows(e.RowIndex).
                Cells(2).Value.ToString()

            txtTarif.Text =
                dgvPerawatan.Rows(e.RowIndex).
                Cells(3).Value.ToString()

        End If

    End Sub

    ' =====================================
    ' UPDATE
    ' =====================================
    Private Sub btnUpdate_Click(sender As Object,
                                e As EventArgs) _
                                Handles btnUpdate.Click

        Try

            OpenConnection()

            Dim subtotal As Decimal =
                Val(txtTarif.Text)

            CMD = New MySqlCommand(
                "UPDATE detail_perawatan SET
                    id_perawatan=@idPerawatan,
                    subtotal=@subtotal
                 WHERE id_detail=@id",
                Conn)

            CMD.Parameters.AddWithValue(
                "@id",
                dgvPerawatan.CurrentRow.
                Cells(0).Value)

            CMD.Parameters.AddWithValue(
                "@idPerawatan",
                cbJenisPerawatan.SelectedValue)

            CMD.Parameters.AddWithValue(
                "@subtotal",
                subtotal)

            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Data berhasil diupdate")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =====================================
    ' HAPUS
    ' =====================================
    Private Sub btnHapus_Click(sender As Object,
                               e As EventArgs) _
                               Handles btnHapus.Click

        Dim jawab As DialogResult

        jawab = MessageBox.Show(
            "Yakin ingin menghapus data?",
            "Konfirmasi",
            MessageBoxButtons.YesNo)

        If jawab = DialogResult.Yes Then

            Try

                OpenConnection()

                CMD = New MySqlCommand(
                    "DELETE FROM detail_perawatan
                     WHERE id_detail=@id",
                    Conn)

                CMD.Parameters.AddWithValue(
                    "@id",
                    dgvPerawatan.CurrentRow.
                    Cells(0).Value)

                CMD.ExecuteNonQuery()

                MessageBox.Show(
                    "Data berhasil dihapus")

                TampilData()

                Bersih()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            Finally

                CloseConnection()

            End Try

        End If

    End Sub

End Class