Imports MySql.Data.MySqlClient

Public Class Login

    Private IsDragging As Boolean = False
    Private MouseDownLocation As Point

    ' =========================
    ' DRAG FORM
    ' =========================
    Private Sub Panel1_MouseDown(sender As Object,
        e As MouseEventArgs) Handles Panel1.MouseDown

        If e.Button = MouseButtons.Left Then

            IsDragging = True
            MouseDownLocation = e.Location

        End If

    End Sub

    Private Sub Panel1_MouseMove(sender As Object,
        e As MouseEventArgs) Handles Panel1.MouseMove

        If IsDragging Then

            Me.Left = Me.Left + (e.X - MouseDownLocation.X)

            Me.Top = Me.Top + (e.Y - MouseDownLocation.Y)

        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object,
        e As MouseEventArgs) Handles Panel1.MouseUp

        IsDragging = False

    End Sub

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub Login_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        Panel2.Left = Me.Width

        TxtPw.PasswordChar = "*"

    End Sub

    ' =========================
    ' TIMER ANIMATION
    ' =========================
    Private Sub Timer1_Tick(sender As Object,
        e As EventArgs) Handles Timer1.Tick

        If Panel2.Left > 12 Then

            Panel2.Left =
                Int(Panel2.Left - 20)

        Else

            Panel2.Left = 12

            Timer1.Enabled = False

        End If

    End Sub

    ' =========================
    ' LOGIN
    ' =========================
    Private Sub BtnLogin_Click(sender As Object,
        e As EventArgs) Handles Btnlogin.Click

        ' VALIDASI
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

            OpenConnection()

            Dim query As String =
                "SELECT * FROM users
                 WHERE username=@username
                 AND password=@password"

            CMD = New MySqlCommand(query, Conn)

            CMD.Parameters.AddWithValue(
                "@username",
                txtUsername.Text)

            CMD.Parameters.AddWithValue(
                "@password",
                TxtPw.Text)

            DR = CMD.ExecuteReader()

            ' =========================
            ' LOGIN BERHASIL
            ' =========================
            If DR.Read() Then

                ' =========================
                ' SIMPAN SESSION
                ' =========================
                UserID =
                    Convert.ToInt32(DR("id_user"))

                Username =
                    DR("username").ToString()

                Role =
                    DR("role").ToString()

                NamaUser =
                    DR("nama").ToString()

                MessageBox.Show(
                    "Login Berhasil",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                ' =========================
                ' ADMIN
                ' =========================
                If Role = "admin" Then

                    Dim x As New FormAdmin

                    x.Show()

                    ' =========================
                    ' STAFF
                    ' =========================
                ElseIf Role = "staff" Then

                    Dim x As New FormStaff

                    x.Show()

                Else

                    MessageBox.Show(
                        "Role tidak dikenali",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

                    Exit Sub

                End If

                ' SEMBUNYIKAN LOGIN
                Me.Hide()

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

            CloseConnection()

        End Try

    End Sub

    ' =========================
    ' CLOSE
    ' =========================
    Private Sub btnClose_Click(sender As Object,
        e As EventArgs) Handles btnClose.Click

        Application.Exit()

    End Sub

    Private Sub Panel2_Paint(sender As Object,
        e As PaintEventArgs) Handles Panel2.Paint

    End Sub

End Class