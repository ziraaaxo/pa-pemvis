Imports MySql.Data.MySqlClient

Public Class uc_DataOwner

    Sub TampilData()

        Try

            OpenConnection()

            DA = New MySqlDataAdapter(
                "SELECT * FROM owner", Conn)

            DT = New DataTable

            DA.Fill(DT)

            dgvOwner.DataSource = DT

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection()

        End Try

    End Sub

    Private Sub uc_DataOwner_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        TampilData()

    End Sub

    Private Sub btnTambah_Click(sender As Object,
        e As EventArgs) Handles btnTambah.Click

        Try

            OpenConnection

            CMD = New MySqlCommand(
                "INSERT INTO owner
                (nama_owner,no_hp,alamat,email)
                VALUES
                (@nama,@hp,@alamat,@email)", Conn)

            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@hp", txtNoHP.Text)
            CMD.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            CMD.Parameters.AddWithValue("@email", txtEmail.Text)

            CMD.ExecuteNonQuery

            MessageBox.Show("Data berhasil ditambah")

            TampilData

            Bersih

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object,
        e As EventArgs) Handles btnEdit.Click

        Try

            OpenConnection

            CMD = New MySqlCommand(
                "UPDATE owner SET
                nama_owner=@nama,
                no_hp=@hp,
                alamat=@alamat,
                email=@email
                WHERE id_owner=@id", Conn)

            CMD.Parameters.AddWithValue("@id", txtID.Text)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@hp", txtNoHP.Text)
            CMD.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            CMD.Parameters.AddWithValue("@email", txtEmail.Text)

            CMD.ExecuteNonQuery

            MessageBox.Show("Data berhasil diubah")

            TampilData

            Bersih

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection

        End Try

    End Sub

    Private Sub btnHapus_Click(sender As Object,
        e As EventArgs) Handles btnHapus.Click

        Try

            OpenConnection

            CMD = New MySqlCommand(
                "DELETE FROM owner
                WHERE id_owner=@id", Conn)

            CMD.Parameters.AddWithValue("@id", txtID.Text)

            CMD.ExecuteNonQuery

            MessageBox.Show("Data berhasil dihapus")

            TampilData

            Bersih

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection

        End Try

    End Sub

    Private Sub dgvOwner_CellClick(sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles dgvOwner.CellClick

        If e.RowIndex >= 0 Then

            txtID.Text =
                dgvOwner.Rows(e.RowIndex).Cells(0).Value.ToString()

            txtNama.Text =
                dgvOwner.Rows(e.RowIndex).Cells(1).Value.ToString()

            txtNoHP.Text =
                dgvOwner.Rows(e.RowIndex).Cells(2).Value.ToString()

            txtAlamat.Text =
                dgvOwner.Rows(e.RowIndex).Cells(3).Value.ToString()

            txtEmail.Text =
                dgvOwner.Rows(e.RowIndex).Cells(4).Value.ToString()

        End If

    End Sub

    Sub Bersih()

        txtNama.Clear()
        txtNoHP.Clear()
        txtAlamat.Clear()
        txtEmail.Clear()

        txtID.Text = ""

    End Sub

    Private Sub dgvOwner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOwner.CellContentClick

    End Sub
End Class