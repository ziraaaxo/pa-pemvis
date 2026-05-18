Imports MySql.Data.MySqlClient

Public Class uc_DataHewan

    Sub LoadOwner()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT * FROM owner", Conn)

            DT = New DataTable

            DA.Fill(DT)

            cbOwner.DataSource = DT
            cbOwner.DisplayMember = "nama_owner"
            cbOwner.ValueMember = "id_owner"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' TAMPIL DATA
    ' =========================
    Sub TampilData()

        Try

            OpenConnection()

            Dim sql As String =
            "SELECT
                hewan.id_hewan,
                owner.nama_owner,
                hewan.nama_hewan,
                hewan.jenis_hewan,
                hewan.ras,
                hewan.jenis_kelamin,
                hewan.umur,
                hewan.warna,
                hewan.berat
             FROM hewan
             JOIN owner
                ON hewan.id_owner = owner.id_owner
             ORDER BY hewan.id_hewan DESC"

            DA = New MySqlDataAdapter(sql, Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvHewan.DataSource = DT

            ' =========================
            ' HIDE ID
            ' =========================
            dgvHewan.Columns(0).Visible = False

            ' =========================
            ' HEADER
            ' =========================
            dgvHewan.Columns(1).HeaderText =
            "Nama Owner"

            dgvHewan.Columns(2).HeaderText =
            "Nama Hewan"

            dgvHewan.Columns(3).HeaderText =
            "Jenis Hewan"

            dgvHewan.Columns(4).HeaderText =
            "Ras"

            dgvHewan.Columns(5).HeaderText =
            "Jenis Kelamin"

            dgvHewan.Columns(6).HeaderText =
            "Umur"

            dgvHewan.Columns(7).HeaderText =
            "Warna"

            dgvHewan.Columns(8).HeaderText =
            "Berat"

            ' =========================
            ' STYLE DATAGRIDVIEW
            ' =========================
            dgvHewan.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

            dgvHewan.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

            dgvHewan.MultiSelect = False

            dgvHewan.ReadOnly = True

            dgvHewan.AllowUserToAddRows = False

            dgvHewan.RowHeadersVisible = False

            dgvHewan.BackgroundColor = Color.White

            dgvHewan.BorderStyle = BorderStyle.None

            dgvHewan.DefaultCellStyle.SelectionBackColor =
            Color.SteelBlue

            dgvHewan.DefaultCellStyle.SelectionForeColor =
            Color.White

            dgvHewan.ColumnHeadersDefaultCellStyle.Font =
            New Font("Segoe UI", 10, FontStyle.Bold)

            dgvHewan.DefaultCellStyle.Font =
            New Font("Segoe UI", 10)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub uc_DataHewan_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        LoadOwner()
        TampilData()

    End Sub

    Private Sub btnTambah_Click(sender As Object,
        e As EventArgs) Handles btnTambah.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "INSERT INTO hewan " &
                "(id_owner,nama_hewan,jenis_hewan,ras," &
                "jenis_kelamin,umur,warna,berat) " &
                "VALUES " &
                "(@owner,@nama,@jenis,@ras,@jk,@umur,@warna,@berat)",
                Conn)

            CMD.Parameters.AddWithValue("@owner", cbOwner.SelectedValue)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@jenis", cbJenis.Text)
            CMD.Parameters.AddWithValue("@ras", txtRas.Text)
            CMD.Parameters.AddWithValue("@jk", cbJK.Text)
            CMD.Parameters.AddWithValue("@umur", txtUmur.Text)
            CMD.Parameters.AddWithValue("@warna", txtWarna.Text)
            CMD.Parameters.AddWithValue("@berat", txtBerat.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil ditambah")

            TampilData()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub txtUmur_TextChanged(sender As Object, e As EventArgs) Handles txtUmur.TextChanged

    End Sub

End Class