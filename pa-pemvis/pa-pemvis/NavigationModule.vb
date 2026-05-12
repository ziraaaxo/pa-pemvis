' =========================================================
' LOAD USERCONTROL MODULE
' File : NavigationModule.vb
' =========================================================

Module NavigationModule

    Public Sub LoadPage(
        container As Panel,
        uc As UserControl
    )

        container.Controls.Clear()

        uc.Dock = DockStyle.Fill

        container.Controls.Add(uc)

    End Sub

End Module