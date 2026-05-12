Public Class FormStaff

    Private Sub ResetMenu()

        panelDashboard.BackColor = Color.Transparent

        panelIndicatorDashboard.BackColor = Color.Transparent

    End Sub

    Private Sub panelDashboard_Click(sender As Object, e As EventArgs) Handles panelDashboard.Click, lblDashboard.Click

        ResetMenu()

        ' ACTIVE MENU
        panelDashboard.BackColor =
        Color.FromArgb(214, 219, 223)

        ' ACTIVE INDICATOR
        panelIndicatorDashboard.BackColor =
        Color.SteelBlue

    End Sub

    Private Sub panelDashboard_MouseEnter(sender As Object, e As EventArgs) Handles panelDashboard.MouseEnter, lblDashboard.MouseEnter

        If panelIndicatorDashboard.BackColor = Color.Transparent Then

            panelDashboard.BackColor =
                Color.FromArgb(214, 219, 223)

        End If

    End Sub

    Private Sub panelDashboard_MouseLeave(sender As Object, e As EventArgs) Handles panelDashboard.MouseLeave, lblDashboard.MouseLeave

        If panelIndicatorDashboard.BackColor = Color.Transparent Then

            panelDashboard.BackColor = Color.Transparent

        End If

    End Sub
End Class