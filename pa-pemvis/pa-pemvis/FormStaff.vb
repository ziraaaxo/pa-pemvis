Public Class FormStaff

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
        panelBooking.BackColor = Color.Transparent
        panelOwner.BackColor = Color.Transparent
        panelHewan.BackColor = Color.Transparent
        panelKandang.BackColor = Color.Transparent
        panelPerawatan.BackColor = Color.Transparent
        panelPembayaran.BackColor = Color.Transparent
        panelLogout.BackColor = Color.Transparent

        panelIndicatorDashboard.BackColor = Color.Transparent
        panelIndicatorBooking.BackColor = Color.Transparent
        panelIndicatorOwner.BackColor = Color.Transparent
        panelIndicatorHewan.BackColor = Color.Transparent
        panelIndicatorKandang.BackColor = Color.Transparent
        panelIndicatorPerawatan.BackColor = Color.Transparent
        PanelIndicatorPembayaran.BackColor = Color.Transparent
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
    Private Sub FormStaff_Load(sender As Object,
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
    ' BOOKING
    ' =========================
    Private Sub panelBooking_Click(sender As Object,
        e As EventArgs) Handles panelBooking.Click,
                                lblBooking.Click

        ActiveMenu(panelBooking,
                   panelIndicatorBooking)

        LoadControl(New uc_Booking)

    End Sub

    ' =========================
    ' DATA OWNER
    ' =========================
    Private Sub panelDataOwner_Click(sender As Object,
        e As EventArgs) Handles panelOwner.Click,
                                lblOwner.Click

        ActiveMenu(panelOwner,
                   panelIndicatorOwner)

        LoadControl(New uc_DataOwner)

    End Sub

    ' =========================
    ' DATA HEWAN
    ' =========================
    Private Sub panelDataHewan_Click(sender As Object,
        e As EventArgs) Handles panelHewan.Click,
                                lblHewan.Click

        ActiveMenu(panelHewan,
                   panelIndicatorHewan)

        LoadControl(New uc_DataHewan)

    End Sub

    ' =========================
    ' KANDANG
    ' =========================
    Private Sub panelKandang_Click(sender As Object,
        e As EventArgs) Handles panelKandang.Click,
                                lblKandang.Click

        ActiveMenu(panelKandang,
                   panelIndicatorKandang)

        LoadControl(New uc_StatusKandang)

    End Sub

    ' =========================
    ' PERAWATAN
    ' =========================
    Private Sub panelPerawatan_Click(sender As Object,
        e As EventArgs) Handles panelPerawatan.Click,
                                lblPerawatan.Click

        ActiveMenu(panelPerawatan,
                   panelIndicatorPerawatan)

        LoadControl(New uc_PerawatanStaff)

    End Sub

    ' =========================
    ' PEMBAYARAN
    ' =========================
    Private Sub panelPembayaran_Click(sender As Object,
        e As EventArgs) Handles panelPembayaran.Click,
                                lblPembayaran.Click

        ActiveMenu(panelPembayaran,
                   PanelIndicatorPembayaran)

        LoadControl(New uc_PembayaranStaff)

    End Sub

    ' =========================
    ' LOGOUT
    ' =========================
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
    ' HOVER BOOKING
    ' =========================
    Private Sub panelBooking_MouseEnter(sender As Object,
        e As EventArgs) Handles panelBooking.MouseEnter,
                                lblBooking.MouseEnter

        If panelIndicatorBooking.BackColor =
            Color.Transparent Then

            panelBooking.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelBooking_MouseLeave(sender As Object,
        e As EventArgs) Handles panelBooking.MouseLeave,
                                lblBooking.MouseLeave

        If panelIndicatorBooking.BackColor =
            Color.Transparent Then

            panelBooking.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER DATA OWNER
    ' =========================
    Private Sub panelDataOwner_MouseEnter(sender As Object,
        e As EventArgs) Handles panelOwner.MouseEnter,
                                lblOwner.MouseEnter

        If panelIndicatorOwner.BackColor =
            Color.Transparent Then

            panelOwner.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelDataOwner_MouseLeave(sender As Object,
        e As EventArgs) Handles panelOwner.MouseLeave,
                                lblOwner.MouseLeave

        If panelIndicatorOwner.BackColor =
            Color.Transparent Then

            panelOwner.BackColor =
                Color.Transparent

        End If

    End Sub

    ' =========================
    ' HOVER DATA HEWAN
    ' =========================
    Private Sub panelDataHewan_MouseEnter(sender As Object,
        e As EventArgs) Handles panelHewan.MouseEnter,
                                lblHewan.MouseEnter

        If panelIndicatorHewan.BackColor =
            Color.Transparent Then

            panelHewan.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelDataHewan_MouseLeave(sender As Object,
        e As EventArgs) Handles panelHewan.MouseLeave,
                                lblHewan.MouseLeave

        If panelIndicatorHewan.BackColor =
            Color.Transparent Then

            panelHewan.BackColor =
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


End Class