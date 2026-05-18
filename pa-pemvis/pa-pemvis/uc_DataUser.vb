Imports MySql.Data.MySqlClient

Public Class uc_DataUser

    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT * FROM users", Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvUser.DataSource = DT

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub uc_DataUser_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub btnTambah_Click(sender As Object,
        e As EventArgs) Handles btnTambah.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "INSERT INTO users " &
                "(nama,username,password,role) " &
                "VALUES " &
                "(@nama,@username,@password,@role)", Conn)

            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@username", txtUsername.Text)
            CMD.Parameters.AddWithValue("@password", txtPassword.Text)
            CMD.Parameters.AddWithValue("@role", cbRole.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil ditambah")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object,
        e As EventArgs) Handles btnEdit.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "UPDATE users SET " &
                "nama=@nama, " &
                "username=@username, " &
                "password=@password, " &
                "role=@role " &
                "WHERE id_user=@id", Conn)

            CMD.Parameters.AddWithValue("@id", lblID.Text)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@username", txtUsername.Text)
            CMD.Parameters.AddWithValue("@password", txtPassword.Text)
            CMD.Parameters.AddWithValue("@role", cbRole.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diubah")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub btnHapus_Click(sender As Object,
        e As EventArgs) Handles btnHapus.Click

        Try

            OpenConnection()

            CMD = New MySqlCommand(
                "DELETE FROM users " &
                "WHERE id_user=@id", Conn)

            CMD.Parameters.AddWithValue("@id", lblID.Text)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus")

            TampilData()

            Bersih()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub dgvUser_CellClick(sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvUser.CellClick

        If e.RowIndex >= 0 Then

            lblID.Text =
                dgvUser.Rows(e.RowIndex).Cells(0).Value.ToString()

            txtNama.Text =
                dgvUser.Rows(e.RowIndex).Cells(1).Value.ToString()

            txtUsername.Text =
                dgvUser.Rows(e.RowIndex).Cells(2).Value.ToString()

            txtPassword.Text =
                dgvUser.Rows(e.RowIndex).Cells(3).Value.ToString()

            cbRole.Text =
                dgvUser.Rows(e.RowIndex).Cells(4).Value.ToString()

        End If

    End Sub

    Sub Bersih()

        txtNama.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

        cbRole.SelectedIndex = -1

        lblID.Text = ""

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

End Class