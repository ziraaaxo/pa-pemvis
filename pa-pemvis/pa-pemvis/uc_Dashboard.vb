Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class uc_Dashboard

    ' Event untuk berpindah halaman (dihandle oleh MainForm/Container)
    Public Event SwitchUserControl(sender As Object, controlName As String)

    ' Koneksi Database (disarankan dipindah ke Module Config terpisah)
    Private ReadOnly connString As String = "server=localhost;user=root;password=;database=db_pet_hotel;"

    Private Sub uc_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupPanelInteractions()
        LoadDashboardSummary()
    End Sub

#Region "🔹 Navigasi Panel & Efek UI"

    Private Sub SetupPanelInteractions()
        Dim navPanels() As Panel = {panelOwner, panelHewan, panelBooking, panelPembayaran}
        For Each pnl In navPanels
            pnl.Cursor = Cursors.Hand
            pnl.BackColor = Color.AliceBlue
            AddHandler pnl.Click, AddressOf NavPanel_Click
            AddHandler pnl.MouseEnter, AddressOf NavPanel_Hover
            AddHandler pnl.MouseLeave, AddressOf NavPanel_Leave
        Next
    End Sub

    Private Sub NavPanel_Click(sender As Object, e As EventArgs)
        Dim targetPanel As Panel = CType(sender, Panel)
        Dim controlName As String = ""

        Select Case targetPanel.Name
            Case "panelOwner" : controlName = "uc_OwnerStaff"
            Case "panelHewan" : controlName = "uc_HewanStaff"
            Case "panelBooking" : controlName = "uc_BookingStaff"
            Case "panelPembayaran" : controlName = "uc_PembayaranStaff"
        End Select

        If Not String.IsNullOrWhiteSpace(controlName) Then
            RaiseEvent SwitchUserControl(Me, controlName)
        End If
    End Sub

    Private Sub NavPanel_Hover(sender As Object, e As EventArgs)
        CType(sender, Panel).BackColor = Color.LightSkyBlue
    End Sub

    Private Sub NavPanel_Leave(sender As Object, e As EventArgs)
        CType(sender, Panel).BackColor = Color.AliceBlue
    End Sub

#End Region

#Region "📊 Ringkasan Dashboard (Opsional)"

    Private Sub LoadDashboardSummary()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                ' Jika Anda menambahkan Label Count di designer, bisa diisi di sini:
                ' lblOwnerCount.Text = GetCount(conn, "SELECT COUNT(*) FROM owner") & " Data"
                ' lblHewanCount.Text = GetCount(conn, "SELECT COUNT(*) FROM hewan") & " Data"
            End Using
        Catch ex As Exception
            ' Fail silently agar tidak mengganggu UI dashboard
        End Try
    End Sub

#End Region

#Region "🖨️ Print Laporan Full"

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Try
            Dim printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintFullReport_Handler
            Dim printDialog As New PrintDialog() With {.Document = printDoc}

            If printDialog.ShowDialog() = DialogResult.OK Then
                printDoc.Print()
                MessageBox.Show("Laporan berhasil dikirim ke printer.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal mencetak laporan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintFullReport_Handler(sender As Object, e As PrintPageEventArgs)
        Dim reportContent As String = GenerateFullReportData()
        Dim fontNormal As New Font("Microsoft PhagsPa", 10)
        Dim fontTitle As New Font("Microsoft PhagsPa", 14, FontStyle.Bold)
        Dim fontHeader As New Font("Microsoft PhagsPa", 11, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)

        Dim y As Integer = e.MarginBounds.Top + 20
        Dim lineHeight As Integer = 24

        ' Header
        e.Graphics.DrawString("LAPORAN FULL PET HOTEL", fontTitle, brush, e.MarginBounds.Left + 30, y)
        y += 40
        e.Graphics.DrawString("Tanggal Cetak: " & DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"), fontNormal, brush, e.MarginBounds.Left + 30, y)
        y += 50

        ' Content
        Dim lines() As String = reportContent.Split({vbCrLf, vbLf}, StringSplitOptions.None)
        For Each line In lines
            If String.IsNullOrWhiteSpace(line) Then
                y += 15
                Continue For
            End If

            Dim currentFont As Font = fontNormal
            If line.StartsWith("===") Then
                currentFont = fontHeader
                y += 10
            End If

            e.Graphics.DrawString(line, currentFont, brush, e.MarginBounds.Left + 30, y)
            y += lineHeight

            If y > e.MarginBounds.Bottom - 50 Then
                e.HasMorePages = True
                Return
            End If
        Next

        e.HasMorePages = False
    End Sub

    Private Function GenerateFullReportData() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("=== RINGKASAN DATA ===")

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                sb.AppendLine($"Total Owner       : {GetCount(conn, "SELECT COUNT(*) FROM owner")} item")
                sb.AppendLine($"Total Hewan       : {GetCount(conn, "SELECT COUNT(*) FROM hewan")} item")
                sb.AppendLine($"Total Booking     : {GetCount(conn, "SELECT COUNT(*) FROM booking")} item")
                sb.AppendLine($"Total Pembayaran  : {GetCount(conn, "SELECT COUNT(*) FROM pembayaran")} item")

                Dim totalPendapatan = GetScalar(conn, "SELECT COALESCE(SUM(total_bayar),0) FROM pembayaran WHERE status_pembayaran='Lunas'")
                sb.AppendLine($"Total Pendapatan  : Rp {FormatCurrency(totalPendapatan)} (Lunas)")

                sb.AppendLine(vbCrLf & "=== RIWAYAT PEMBAYARAN TERAKHIR (15 Data) ===")
                Using cmd As New MySqlCommand("
                    SELECT b.id_booking, o.nama_owner, h.nama_hewan, 
                           p.tanggal_bayar, p.total_bayar, p.status_pembayaran 
                    FROM pembayaran p 
                    JOIN booking b ON p.id_booking = b.id_booking 
                    JOIN hewan h ON b.id_hewan = h.id_hewan 
                    JOIN owner o ON h.id_owner = o.id_owner 
                    ORDER BY p.tanggal_bayar DESC LIMIT 15", conn)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If Not reader.HasRows Then
                            sb.AppendLine("(Tidak ada data pembayaran)")
                        Else
                            While reader.Read()
                                Dim tgl As String = Convert.ToDateTime(reader("tanggal_bayar")).ToString("dd/MM/yyyy")
                                Dim bayar As String = FormatCurrency(reader("total_bayar"))
                                Dim status As String = reader("status_pembayaran").ToString()
                                sb.AppendLine($"[#{reader("id_booking")}] {reader("nama_owner")} | {reader("nama_hewan")} | {tgl} | Rp {bayar} | {status}")
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            sb.AppendLine($"(Gagal memuat data: {ex.Message})")
        End Try

        Return sb.ToString()
    End Function

#End Region

#Region "🔧 Helper Functions"

    Private Function GetCount(conn As MySqlConnection, query As String) As String
        Using cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, result.ToString(), "0")
        End Using
    End Function

    Private Function GetScalar(conn As MySqlConnection, query As String) As Object
        Using cmd As New MySqlCommand(query, conn)
            Return cmd.ExecuteScalar()
        End Using
    End Function

    Private Function FormatCurrency(value As Object) As String
        If Decimal.TryParse(value?.ToString(), Nothing) Then
            Return Convert.ToDecimal(value).ToString("N0")
        End If
        Return "0"
    End Function

#End Region

End Class