Imports MySql.Data.MySqlClient

Public Class uc_Booking

    Dim selectedId As Integer = 0

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub uc_Booking_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        LoadHewan()
        LoadKandang()
        LoadStatus()
        TampilData()

        btnUpdate.Enabled = False
        btnHapus.Enabled = False

    End Sub

    ' =========================
    ' LOAD HEWAN
    ' =========================
    Sub LoadHewan()

        Try

            OpenConnection()

            cbHewan.Items.Clear()

            CMD = New MySqlCommand(
                "SELECT
                    id_hewan,
                    nama_hewan
                 FROM hewan
                 ORDER BY nama_hewan ASC",
                Conn)

            DR = CMD.ExecuteReader()

            While DR.Read()

                cbHewan.Items.Add(New With {
                    .Text = DR("nama_hewan").ToString(),
                    .Value = DR("id_hewan")
                })

            End While

            DR.Close()

            cbHewan.DisplayMember = "Text"
            cbHewan.ValueMember = "Value"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' LOAD KANDANG
    ' =========================
    Sub LoadKandang()

        Try

            OpenConnection()

            cbKandang.Items.Clear()

            CMD = New MySqlCommand(
                "SELECT
                    id_kandang,
                    nomor_kandang
                 FROM kandang
                 WHERE status_kandang='Kosong'
                 ORDER BY nomor_kandang ASC",
                Conn)

            DR = CMD.ExecuteReader()

            While DR.Read()

                cbKandang.Items.Add(New With {
                    .Text = DR("nomor_kandang").ToString(),
                    .Value = DR("id_kandang")
                })

            End While

            DR.Close()

            cbKandang.DisplayMember = "Text"
            cbKandang.ValueMember = "Value"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' LOAD STATUS
    ' =========================
    Sub LoadStatus()

        cbStatus.Items.Clear()

        cbStatus.Items.Add("Booking")
        cbStatus.Items.Add("Check In")
        cbStatus.Items.Add("Check Out")
        cbStatus.Items.Add("Batal")

        cbStatus.SelectedIndex = 0

    End Sub

    ' =========================
    ' TAMPIL DATA
    ' =========================
    Sub TampilData()

        Try

            OpenConnection()

            Dim sql As String =
                "SELECT
                    b.id_booking,
                    h.nama_hewan,
                    k.nomor_kandang,
                    b.tanggal_checkin,
                    b.tanggal_checkout,
                    b.status_booking,
                    b.catatan
                 FROM booking b
                 JOIN hewan h
                    ON b.id_hewan = h.id_hewan
                 JOIN kandang k
                    ON b.id_kandang = k.id_kandang
                 ORDER BY b.id_booking DESC"

            DA = New MySqlDataAdapter(sql, Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvBooking.DataSource = DT

            ' =========================
            ' HIDE ID
            ' =========================
            dgvBooking.Columns(0).Visible = False

            ' =========================
            ' HEADER
            ' =========================
            dgvBooking.Columns(1).HeaderText =
                "Nama Hewan"

            dgvBooking.Columns(2).HeaderText =
                "Nomor Kandang"

            dgvBooking.Columns(3).HeaderText =
                "Check In"

            dgvBooking.Columns(4).HeaderText =
                "Check Out"

            dgvBooking.Columns(5).HeaderText =
                "Status"

            dgvBooking.Columns(6).HeaderText =
                "Catatan"

            ' =========================
            ' STYLE DATAGRIDVIEW
            ' =========================
            dgvBooking.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvBooking.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvBooking.MultiSelect = False

            dgvBooking.ReadOnly = True

            dgvBooking.AllowUserToAddRows = False

            dgvBooking.RowHeadersVisible = False

            dgvBooking.BackgroundColor = Color.White

            dgvBooking.BorderStyle = BorderStyle.None

            dgvBooking.DefaultCellStyle.SelectionBackColor =
                Color.SteelBlue

            dgvBooking.DefaultCellStyle.SelectionForeColor =
                Color.White

            dgvBooking.ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 10, FontStyle.Bold)

            dgvBooking.DefaultCellStyle.Font =
                New Font("Segoe UI", 10)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' SIMPAN
    ' =========================
    Private Sub btnSimpan_Click(sender As Object,
        e As EventArgs) Handles btnSimpan.Click

        If cbHewan.Text = "" Or
           cbKandang.Text = "" Then

            MessageBox.Show(
                "Data belum lengkap")

            Exit Sub

        End If

        Try

            OpenConnection()

            Dim idHewan As Integer =
                CType(cbHewan.SelectedItem,
                Object).Value

            Dim idKandang As Integer =
                CType(cbKandang.SelectedItem,
                Object).Value

            CMD = New MySqlCommand(
                "INSERT INTO booking
                (
                    id_hewan,
                    id_kandang,
                    tanggal_checkin,
                    tanggal_checkout,
                    status_booking,
                    catatan
                )
                VALUES
                (
                    @id_hewan,
                    @id_kandang,
                    @checkin,
                    @checkout,
                    @status,
                    @catatan
                )",
                Conn)

            CMD.Parameters.AddWithValue(
                "@id_hewan",
                idHewan)

            CMD.Parameters.AddWithValue(
                "@id_kandang",
                idKandang)

            CMD.Parameters.AddWithValue(
                "@checkin",
                dtCheckIn.Value.Date)

            CMD.Parameters.AddWithValue(
                "@checkout",
                dtCheckOut.Value.Date)

            CMD.Parameters.AddWithValue(
                "@status",
                cbStatus.Text)

            CMD.Parameters.AddWithValue(
                "@catatan",
                txtCatatan.Text)

            CMD.ExecuteNonQuery()

            ' =========================
            ' UPDATE STATUS KANDANG
            ' =========================
            CMD = New MySqlCommand(
                "UPDATE kandang
                 SET status_kandang='Terisi'
                 WHERE id_kandang=@id",
                Conn)

            CMD.Parameters.AddWithValue(
                "@id",
                idKandang)

            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Booking berhasil disimpan")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

        ClearForm()
        TampilData()
        LoadKandang()

    End Sub

    ' =========================
    ' CLICK GRID
    ' =========================
    Private Sub dgvBooking_CellClick(sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvBooking.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow =
            dgvBooking.Rows(e.RowIndex)

        selectedId =
            Convert.ToInt32(row.Cells(0).Value)

        ' simpan id booking hidden
        txtIDBooking.Text =
            row.Cells(0).Value.ToString()

        cbHewan.Text =
            row.Cells(1).Value.ToString()

        cbKandang.Text =
            row.Cells(2).Value.ToString()

        dtCheckIn.Value =
            Convert.ToDateTime(row.Cells(3).Value)

        dtCheckOut.Value =
            Convert.ToDateTime(row.Cells(4).Value)

        cbStatus.Text =
            row.Cells(5).Value.ToString()

        txtCatatan.Text =
            row.Cells(6).Value.ToString()

        btnUpdate.Enabled = True
        btnHapus.Enabled = True

    End Sub

    ' =========================
    ' UPDATE
    ' =========================
    Private Sub btnUpdate_Click(sender As Object,
        e As EventArgs) Handles btnUpdate.Click

        If selectedId = 0 Then

            MessageBox.Show(
                "Pilih data terlebih dahulu")

            Exit Sub

        End If

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "UPDATE booking SET
                    tanggal_checkin=@checkin,
                    tanggal_checkout=@checkout,
                    status_booking=@status,
                    catatan=@catatan
                 WHERE id_booking=@id",
                Conn)

            CMD.Parameters.AddWithValue(
                "@checkin",
                dtCheckIn.Value.Date)

            CMD.Parameters.AddWithValue(
                "@checkout",
                dtCheckOut.Value.Date)

            CMD.Parameters.AddWithValue(
                "@status",
                cbStatus.Text)

            CMD.Parameters.AddWithValue(
                "@catatan",
                txtCatatan.Text)

            CMD.Parameters.AddWithValue(
                "@id",
                selectedId)

            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Data berhasil diupdate")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

        ClearForm()
        TampilData()

    End Sub

    ' =========================
    ' HAPUS
    ' =========================
    Private Sub btnHapus_Click(sender As Object,
        e As EventArgs) Handles btnHapus.Click

        If selectedId = 0 Then

            MessageBox.Show(
                "Pilih data terlebih dahulu")

            Exit Sub

        End If

        Dim jawab As DialogResult

        jawab = MessageBox.Show(
            "Hapus data booking ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If jawab = DialogResult.No Then Exit Sub

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "DELETE FROM booking
                 WHERE id_booking=@id",
                Conn)

            CMD.Parameters.AddWithValue(
                "@id",
                selectedId)

            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Data berhasil dihapus")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

        ClearForm()
        TampilData()

    End Sub

    ' =========================
    ' CLEAR FORM
    ' =========================
    Sub ClearForm()

        cbHewan.SelectedIndex = -1
        cbKandang.SelectedIndex = -1

        cbStatus.SelectedIndex = 0

        txtCatatan.Clear()
        txtCari.Clear()

        txtIDBooking.Clear()

        selectedId = 0

        btnUpdate.Enabled = False
        btnHapus.Enabled = False

    End Sub

End Class