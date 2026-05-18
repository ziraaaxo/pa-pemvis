Public Class FormAdmin

    ' =========================
    ' LOAD USER CONTROL
    ' =========================
    Private Sub LoadControl(ctrl As UserControl)

        panelUtama.Controls.Clear()

        ctrl.Dock = DockStyle.Fill

        panelUtama.Controls.Add(ctrl)

    End Sub

    ' =========================
    ' RESET MENU
    ' =========================
    Private Sub ResetMenu()

        panelDashboard.BackColor = Color.Transparent
        panelKandang.BackColor = Color.Transparent
        panelPerawatan.BackColor = Color.Transparent
        panelPembayaran.BackColor = Color.Transparent
        panelUser.BackColor = Color.Transparent
        panelTarif.BackColor = Color.Transparent
        panelLogout.BackColor = Color.Transparent

        panelIndicatorDashboard.BackColor = Color.Transparent
        panelIndicatorKandang.BackColor = Color.Transparent
        panelIndicatorPerawatan.BackColor = Color.Transparent
        panelIndicatorPembayaran.BackColor = Color.Transparent
        panelIndicatorUser.BackColor = Color.Transparent
        panelIndicatorTarif.BackColor = Color.Transparent
        panelIndicatorLogout.BackColor = Color.Transparent

    End Sub

    ' =========================
    ' ACTIVE MENU
    ' =========================
    Private Sub ActiveMenu(menuPanel As Panel,
                           indicatorPanel As Panel)

        ResetMenu()

        menuPanel.BackColor =
            Color.FromArgb(214, 219, 223)

        indicatorPanel.BackColor =
            Color.SteelBlue

    End Sub

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub FormAdmin_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load

        ActiveMenu(panelDashboard,
                   panelIndicatorDashboard)

        LoadControl(New uc_Dashboard)

    End Sub

    ' =========================
    ' DASHBOARD
    ' =========================
    Private Sub panelDashboard_Click(sender As Object,
        e As EventArgs) Handles panelDashboard.Click,
                                lblDashboard.Click

        ActiveMenu(panelDashboard,
                   panelIndicatorDashboard)

        LoadControl(New uc_Dashboard)

    End Sub

    ' =========================
    ' DATA KANDANG
    ' =========================
    Private Sub panelKandang_Click(sender As Object,
        e As EventArgs) Handles panelKandang.Click,
                                lblKandang.Click

        ActiveMenu(panelKandang,
                   panelIndicatorKandang)

        LoadControl(New uc_Kandang)

    End Sub

    ' =========================
    ' DATA PERAWATAN
    ' =========================
    Private Sub panelPerawatan_Click(sender As Object,
        e As EventArgs) Handles panelPerawatan.Click,
                                lblPerawatan.Click

        ActiveMenu(panelPerawatan,
                   panelIndicatorPerawatan)

        LoadControl(New uc_Perawatan)

    End Sub

    ' =========================
    ' METODE PEMBAYARAN
    ' =========================
    Private Sub panelPembayaran_Click(sender As Object,
        e As EventArgs) Handles panelPembayaran.Click,
                                lblPembayaran.Click

        ActiveMenu(panelPembayaran,
                   panelIndicatorPembayaran)

        LoadControl(New uc_MetodePembayaran)

    End Sub

    ' =========================
    ' DATA USER
    ' =========================
    Private Sub panelUser_Click(sender As Object,
        e As EventArgs) Handles panelUser.Click,
                                lblUser.Click

        ActiveMenu(panelUser,
                   panelIndicatorUser)

        LoadControl(New uc_DataUser)

    End Sub

    ' =========================
    ' TARIF
    ' =========================
    Private Sub panelTarif_Click(sender As Object,
        e As EventArgs) Handles panelTarif.Click,
                                lblTarif.Click

        ActiveMenu(panelTarif,
                   panelIndicatorTarif)

        LoadControl(New uc_Tarif)

    End Sub

    ' =========================
    ' HOVER DASHBOARD
    ' =========================
    Private Sub panelDashboard_MouseEnter(sender As Object,
        e As EventArgs) Handles panelDashboard.MouseEnter,
                                lblDashboard.MouseEnter

        If panelIndicatorDashboard.BackColor =
            Color.Transparent Then

            panelDashboard.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelDashboard_MouseLeave(sender As Object,
        e As EventArgs) Handles panelDashboard.MouseLeave,
                                lblDashboard.MouseLeave

        If panelIndicatorDashboard.BackColor =
            Color.Transparent Then

            panelDashboard.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER KANDANG
    ' =========================
    Private Sub panelKandang_MouseEnter(sender As Object,
        e As EventArgs) Handles panelKandang.MouseEnter,
                                lblKandang.MouseEnter

        If panelIndicatorKandang.BackColor =
            Color.Transparent Then

            panelKandang.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelKandang_MouseLeave(sender As Object,
        e As EventArgs) Handles panelKandang.MouseLeave,
                                lblKandang.MouseLeave

        If panelIndicatorKandang.BackColor =
            Color.Transparent Then

            panelKandang.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER PERAWATAN
    ' =========================
    Private Sub panelPerawatan_MouseEnter(sender As Object,
        e As EventArgs) Handles panelPerawatan.MouseEnter,
                                lblPerawatan.MouseEnter

        If panelIndicatorPerawatan.BackColor =
            Color.Transparent Then

            panelPerawatan.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelPerawatan_MouseLeave(sender As Object,
        e As EventArgs) Handles panelPerawatan.MouseLeave,
                                lblPerawatan.MouseLeave

        If panelIndicatorPerawatan.BackColor =
            Color.Transparent Then

            panelPerawatan.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER PEMBAYARAN
    ' =========================
    Private Sub panelPembayaran_MouseEnter(sender As Object,
        e As EventArgs) Handles panelPembayaran.MouseEnter,
                                lblPembayaran.MouseEnter

        If panelIndicatorPembayaran.BackColor =
            Color.Transparent Then

            panelPembayaran.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelPembayaran_MouseLeave(sender As Object,
        e As EventArgs) Handles panelPembayaran.MouseLeave,
                                lblPembayaran.MouseLeave

        If panelIndicatorPembayaran.BackColor =
            Color.Transparent Then

            panelPembayaran.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER USER
    ' =========================
    Private Sub panelUser_MouseEnter(sender As Object,
        e As EventArgs) Handles panelUser.MouseEnter,
                                lblUser.MouseEnter

        If panelIndicatorUser.BackColor =
            Color.Transparent Then

            panelUser.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelUser_MouseLeave(sender As Object,
        e As EventArgs) Handles panelUser.MouseLeave,
                                lblUser.MouseLeave

        If panelIndicatorUser.BackColor =
            Color.Transparent Then

            panelUser.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER TARIF
    ' =========================
    Private Sub panelTarif_MouseEnter(sender As Object,
        e As EventArgs) Handles panelTarif.MouseEnter,
                                lblTarif.MouseEnter

        If panelIndicatorTarif.BackColor =
            Color.Transparent Then

            panelTarif.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelTarif_MouseLeave(sender As Object,
        e As EventArgs) Handles panelTarif.MouseLeave,
                                lblTarif.MouseLeave

        If panelIndicatorTarif.BackColor =
            Color.Transparent Then

            panelTarif.BackColor =
                Color.Transparent

        End If

    End Sub

    Private Sub panelLogout_Click(sender As Object,
    e As EventArgs) Handles panelLogout.Click,
                            lblLogout.Click

        Role = ""
        Username = ""
        NamaUser = ""
        UserID = 0

        Dim x As New Login

        x.Show()

        Me.Close()

    End Sub

End Class