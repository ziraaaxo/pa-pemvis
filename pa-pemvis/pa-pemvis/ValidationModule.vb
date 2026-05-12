' =========================================================
' VALIDATION MODULE
' File : ValidationModule.vb
' =========================================================

Module ValidationModule

    Public Function IsEmpty(txt As TextBox) As Boolean

        If txt.Text.Trim = "" Then

            MessageBox.Show(
                txt.Name & " tidak boleh kosong",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txt.Focus()

            Return True

        End If

        Return False

    End Function

    Public Function IsComboEmpty(cb As ComboBox) As Boolean

        If cb.Text.Trim = "" Then

            MessageBox.Show(
                cb.Name & " belum dipilih",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cb.Focus()

            Return True

        End If

        Return False

    End Function

End Module