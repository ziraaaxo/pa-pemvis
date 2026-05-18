Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Globalization

Public Class uc_PembayaranStaff

    ' Ganti sesuai konfigurasi database Anda
    Private ReadOnly ConnString As String = "server=localhost;user id=root;password=;database=db_pet_hotel;"
    Private currentBookingId As Integer = 0

#Region "🔹 INITIALIZATION & SETUP"

    Private Sub uc_PembayaranStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGridColumns()
        SetDefaultValues()
    End Sub

    Private Sub SetupGridColumns()
        dgvDetail.Columns.Clear()
        dgvDetail.Columns.Add("colNama", "Jenis Perawatan")
        dgvDetail.Columns.Add("colQty", "Qty")
        dgvDetail.Columns.Add("colSubtotal", "Subtotal (Rp)")
        dgvDetail.Columns("colSubtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetail.Columns("colSubtotal").DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub SetDefaultValues()
        dtTanggal.Value = DateTime.Today
        If cbMetode.Items.Count > 0 Then cbMetode.SelectedIndex = 0
        If cbStatus.Items.Count > 0 Then cbStatus.SelectedIndex = 0
        txtNominalBayar.Text = "0"
        txtKembalian.Text = "Rp 0"
    End Sub

#End Region

#Region "🔍 CARI & LOAD DATA"

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If Not Integer.TryParse(txtIdBooking.Text.Trim(), currentBookingId) OrElse currentBookingId <= 0 Then
            MessageBox.Show("Masukkan ID Booking yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ClearInputFields()
        Try
            Using conn As New MySqlConnection(ConnString)
                conn.Open()
                LoadBookingInfo(conn)
                If currentBookingId = 0 Then Exit Try ' Booking tidak ditemukan

                LoadDetailPerawatan(conn)
                LoadExistingPayment(conn)

                ' Reset pembayaran untuk transaksi baru
                dtTanggal.Value = DateTime.Today
                cbMetode.SelectedIndex = 0
                cbStatus.SelectedIndex = 0
                txtNominalBayar.Text = "0"
                txtNominalBayar.Focus()
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadBookingInfo(conn As MySqlConnection)
        Dim query = "SELECT b.tanggal_checkin, b.tanggal_checkout, b.catatan, " &
                    "h.nama_hewan, h.jenis_hewan, o.nama_owner, o.no_hp, o.alamat, " &
                    "k.nomor_kandang, k.tipe_kandang, k.harga_per_hari " &
                    "FROM booking b " &
                    "JOIN hewan h ON b.id_hewan = h.id_hewan " &
                    "JOIN owner o ON h.id_owner = o.id_owner " &
                    "JOIN kandang k ON b.id_kandang = k.id_kandang " &
                    "WHERE b.id_booking = @id"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", currentBookingId)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtInfo.Text = $"Owner: {reader("nama_owner")} ({reader("no_hp")}){vbCrLf}" &
                                   $"Alamat: {reader("alamat")}{vbCrLf}" &
                                   $"Hewan: {reader("nama_hewan")} ({reader("jenis_hewan")}){vbCrLf}" &
                                   $"Kandang: {reader("nomor_kandang")} | Tipe: {reader("tipe_kandang")}{vbCrLf}" &
                                   $"Check-In: {Convert.ToDateTime(reader("tanggal_checkin")).ToString("dd/MM/yyyy")} → " &
                                   $"Check-Out: {Convert.ToDateTime(reader("tanggal_checkout")).ToString("dd/MM/yyyy")}"

                    txtCatatan.Text = If(IsDBNull(reader("catatan")), "", reader("catatan").ToString())

                    ' Hitung Total Hotel
                    Dim checkIn As Date = Convert.ToDateTime(reader("tanggal_checkin"))
                    Dim checkOut As Date = Convert.ToDateTime(reader("tanggal_checkout"))
                    Dim lamaInap As Integer = Math.Max(1, (checkOut - checkIn).Days)
                    Dim hargaPerHari As Decimal = Convert.ToDecimal(reader("harga_per_hari"))
                    Dim totalHotel As Decimal = lamaInap * hargaPerHari

                    txtTotalHotel.Text = FormatRupiah(totalHotel)
                    HitungGrandTotal()
                Else
                    MessageBox.Show("Data booking tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    currentBookingId = 0
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadDetailPerawatan(conn As MySqlConnection)
        dgvDetail.Rows.Clear()
        Dim totalPerawatan As Decimal = 0
        Dim query = "SELECT p.nama_perawatan, dp.qty, dp.subtotal " &
                    "FROM detail_perawatan dp " &
                    "JOIN perawatan p ON dp.id_perawatan = p.id_perawatan " &
                    "WHERE dp.id_booking = @id"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", currentBookingId)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    Dim subtotal As Decimal = Convert.ToDecimal(reader("subtotal"))
                    dgvDetail.Rows.Add(reader("nama_perawatan"), reader("qty"), subtotal)
                    totalPerawatan += subtotal
                End While
            End Using
        End Using

        txtTotalPerawatan.Text = FormatRupiah(totalPerawatan)
        HitungGrandTotal()
    End Sub

    Private Sub LoadExistingPayment(conn As MySqlConnection)
        Dim query = "SELECT tanggal_bayar, total_bayar, metode_pembayaran, status_pembayaran FROM pembayaran WHERE id_booking = @id"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", currentBookingId)
            Using reader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtTanggal.Value = Convert.ToDateTime(reader("tanggal_bayar"))
                    txtNominalBayar.Text = FormatRupiah(Convert.ToDecimal(reader("total_bayar")))
                    cbMetode.Text = reader("metode_pembayaran").ToString()
                    cbStatus.Text = reader("status_pembayaran").ToString()
                    MessageBox.Show("Pembayaran sudah tercatat. Gunakan tombol UPDATE jika ingin mengubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "💰 KALKULASI OTOMATIS"

    Private Sub txtNominalBayar_TextChanged(sender As Object, e As EventArgs) Handles txtNominalBayar.TextChanged
        HitungKembalian()
    End Sub

    Private Sub txtNominalBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNominalBayar.KeyPress
        ' Hanya izinkan angka, backspace, dan desimal
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HitungGrandTotal()
        Dim hotel As Decimal = ParseRupiah(txtTotalHotel.Text)
        Dim perawatan As Decimal = ParseRupiah(txtTotalPerawatan.Text)
        txtGrandTotal.Text = FormatRupiah(hotel + perawatan)
    End Sub

    Private Sub HitungKembalian()
        Dim grandTotal As Decimal = ParseRupiah(txtGrandTotal.Text)
        Dim bayar As Decimal = ParseRupiah(txtNominalBayar.Text)
        Dim kembalian As Decimal = bayar - grandTotal

        txtKembalian.Text = FormatRupiah(kembalian)
        If kembalian >= 0 Then
            txtKembalian.BackColor = Color.LightGreen
            txtKembalian.ForeColor = Color.DarkGreen
        Else
            txtKembalian.BackColor = Color.LightCoral
            txtKembalian.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Function ParseRupiah(text As String) As Decimal
        If String.IsNullOrWhiteSpace(text) Then Return 0D
        ' Menghapus 'Rp', titik ribuan, dan spasi
        Dim cleanText = text.Replace("Rp", "").Replace(".", "").Trim()

        Dim result As Decimal
        If Decimal.TryParse(cleanText, NumberStyles.Any, CultureInfo.InvariantCulture, result) Then
            Return result
        End If
        Return 0D
    End Function

    Private Function FormatRupiah(value As Decimal) As String
        If value = 0D Then Return "Rp 0"
        Return "Rp " & value.ToString("N0", CultureInfo.GetCultureInfo("id-ID"))
    End Function

#End Region

#Region "💾 CRUD PEMBAYARAN"

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If currentBookingId = 0 Then
            MessageBox.Show("Cari booking terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ParseRupiah(txtNominalBayar.Text) < ParseRupiah(txtGrandTotal.Text) Then
            If MessageBox.Show("Nominal bayar KURANG dari Grand Total. Tetap simpan sebagai BELUM LUNAS?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If

        Try
            Using conn As New MySqlConnection(ConnString)
                conn.Open()

                ' --- FIX ERROR: Cek Duplikat dengan Syntax yang Benar ---
                Dim checkQuery = "SELECT COUNT(*) FROM pembayaran WHERE id_booking = @id"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@id", currentBookingId)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Data pembayaran sudah ada. Gunakan tombol UPDATE.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                End Using
                ' ----------------------------------------------------

                Dim query = "INSERT INTO pembayaran (id_booking, tanggal_bayar, total_hotel, total_perawatan, total_bayar, metode_pembayaran, status_pembayaran) " &
                            "VALUES (@id, @tgl, @hotel, @perawatan, @bayar, @metode, @status)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", currentBookingId)
                    cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value.Date)
                    cmd.Parameters.AddWithValue("@hotel", ParseRupiah(txtTotalHotel.Text))
                    cmd.Parameters.AddWithValue("@perawatan", ParseRupiah(txtTotalPerawatan.Text))
                    cmd.Parameters.AddWithValue("@bayar", ParseRupiah(txtNominalBayar.Text))
                    cmd.Parameters.AddWithValue("@metode", cbMetode.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("✅ Pembayaran berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearInputFields()
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentBookingId = 0 Then
            MessageBox.Show("Cari booking terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(ConnString)
                conn.Open()
                Dim query = "UPDATE pembayaran SET tanggal_bayar=@tgl, total_bayar=@bayar, metode_pembayaran=@metode, status_pembayaran=@status WHERE id_booking=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", currentBookingId)
                    cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value.Date)
                    cmd.Parameters.AddWithValue("@bayar", ParseRupiah(txtNominalBayar.Text))
                    cmd.Parameters.AddWithValue("@metode", cbMetode.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("✅ Data pembayaran berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Data pembayaran tidak ditemukan untuk diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengupdate: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If currentBookingId = 0 Then Return

        If MessageBox.Show("Yakin ingin menghapus data pembayaran ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            Using conn As New MySqlConnection(ConnString)
                conn.Open()
                Dim query = "DELETE FROM pembayaran WHERE id_booking = @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", currentBookingId)
                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("🗑️ Data pembayaran berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearInputFields()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "️ PRINT INVOICE"

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If currentBookingId = 0 Then
            MessageBox.Show("Tidak ada data untuk dicetak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintInvoice_Page
        Dim dlg As New PrintDialog() With {.Document = printDoc}

        If dlg.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintInvoice_Page(sender As Object, e As PrintPageEventArgs)
        Dim g = e.Graphics
        Dim fTitle As New Font("Microsoft PhagsPa", 14, FontStyle.Bold)
        Dim fNormal As New Font("Microsoft PhagsPa", 10)
        Dim fBold As New Font("Microsoft PhagsPa", 10, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim y As Integer = e.MarginBounds.Top + 20
        Dim lineH As Integer = 22
        Dim leftX As Integer = e.MarginBounds.Left + 30

        g.DrawString("PET HOTEL - INVOICE PEMBAYARAN", fTitle, brush, leftX, y)
        y += 40
        g.DrawString($"No. Booking  : #{currentBookingId}", fNormal, brush, leftX, y)
        y += lineH
        g.DrawString($"Tanggal Bayar: {dtTanggal.Value.ToString("dd/MM/yyyy")}", fNormal, brush, leftX, y)
        y += lineH + 10

        ' Info
        Dim lines() As String = txtInfo.Text.Split(vbCrLf)
        For Each line In lines
            g.DrawString(line, fNormal, brush, leftX, y)
            y += lineH
        Next
        y += 10

        ' Tabel Perawatan
        g.DrawString("DETAIL PERAWATAN:", fBold, brush, leftX, y)
        y += lineH + 5
        For Each row As DataGridViewRow In dgvDetail.Rows
            If row.IsNewRow Then Continue For
            g.DrawString($"- {row.Cells(0).Value} (x{row.Cells(1).Value}) : {row.Cells(2).Value}", fNormal, brush, leftX, y)
            y += lineH
        Next
        y += 15

        ' Total
        g.DrawString($"Total Hotel      : {txtTotalHotel.Text}", fNormal, brush, leftX, y)
        y += lineH
        g.DrawString($"Total Perawatan  : {txtTotalPerawatan.Text}", fNormal, brush, leftX, y)
        y += lineH + 5
        g.DrawString($"GRAND TOTAL      : {txtGrandTotal.Text}", fBold, brush, leftX, y)
        y += lineH + 10

        ' Pembayaran
        g.DrawString($"Metode           : {cbMetode.SelectedItem}", fNormal, brush, leftX, y)
        y += lineH
        g.DrawString($"Dibayar          : {txtNominalBayar.Text}", fNormal, brush, leftX, y)
        y += lineH
        g.DrawString($"Kembalian        : {txtKembalian.Text}", fNormal, brush, leftX, y)
        y += lineH + 5
        g.DrawString($"Status           : {cbStatus.SelectedItem}", fBold, brush, leftX, y)

        e.HasMorePages = False
    End Sub

#End Region

#Region "🧹 UTILITIES"

    Private Sub ClearInputFields()
        txtIdBooking.Clear()
        txtInfo.Clear()
        txtCatatan.Clear()
        txtTotalHotel.Clear()
        txtTotalPerawatan.Clear()
        txtGrandTotal.Clear()
        txtNominalBayar.Text = "0"
        txtKembalian.Text = "Rp 0"
        dgvDetail.Rows.Clear()
        currentBookingId = 0
        SetDefaultValues()
    End Sub

#End Region

End Class