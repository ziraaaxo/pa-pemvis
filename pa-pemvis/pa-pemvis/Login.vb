Imports MySql.Data.MySqlClient

Public Class Login
    Private IsDragging As Boolean = False
    Private MouseDownLocation As Point

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDragging = True
            MouseDownLocation = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If IsDragging Then
            Me.Left = Me.Left + (e.X - MouseDownLocation.X)
            Me.Top = Me.Top + (e.Y - MouseDownLocation.Y)
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        IsDragging = False
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Left = Me.Width
        TxtPw.PasswordChar = "*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel2.Left > 12 Then
            Panel2.Left = Int(Panel2.Left - 20)
        Else
            Panel2.Left = 12
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object,
            e As EventArgs) Handles Btnlogin.Click

        ' =========================
        ' VALIDASI KOSONG
        ' =========================
        If txtUsername.Text = "" Or
               TxtPw.Text = "" Then

            MessageBox.Show(
                    "Username dan Password wajib diisi",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

            Exit Sub

        End If

        Try

            OpenConnection

            Dim query =
                    "SELECT *
                 FROM users
                 WHERE username=@username
                 AND password=@password"

            CMD = New MySqlCommand(query, Conn)

            CMD.Parameters.AddWithValue(
                    "@username",
                    txtUsername.Text)

            CMD.Parameters.AddWithValue(
                    "@password",
                    TxtPw.Text)

            DR = CMD.ExecuteReader

            ' =========================
            ' LOGIN BERHASIL
            ' =========================
            If DR.Read Then

                Dim role =
                        DR("role").ToString

                MessageBox.Show(
                        "Login Berhasil",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

                ' =========================
                ' ADMIN
                ' =========================
                If role = "admin" Then

                    FormAdmin.Show

                    ' =========================
                    ' STAFF
                    ' =========================
                ElseIf role = "staff" Then

                    FormStaff.Show

                Else

                    MessageBox.Show(
                            "Role tidak dikenali")

                    Exit Sub

                End If

                ' sembunyikan login
                Hide

            Else

                ' =========================
                ' LOGIN GAGAL
                ' =========================
                MessageBox.Show(
                        "Username atau Password salah",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            CloseConnection

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object,
    e As EventArgs) Handles btnClose.Click

        Application.Exit()

    End Sub

End Class