Imports MySql.Data.MySqlClient

Public Class uc_StatusKandang

    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT " &
                "nomor_kandang, " &
                "tipe_kandang, " &
                "harga_per_hari, " &
                "status_kandang " &
                "FROM kandang",
                Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvKandang.DataSource = DT

            dgvKandang.Columns(0).HeaderText = "Nomor Kandang"
            dgvKandang.Columns(1).HeaderText = "Tipe Kandang"
            dgvKandang.Columns(2).HeaderText = "Harga Per Hari"
            dgvKandang.Columns(3).HeaderText = "Status"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub uc_StatusKandang_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub dgvKandang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKandang.CellContentClick

    End Sub
End Class