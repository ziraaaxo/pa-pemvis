<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_PembayaranStaff
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnPrint = New Button()
        btnHapus = New Button()
        btnUpdate = New Button()
        btnSimpan = New Button()
        PanelHeader = New Panel()
        lblTitle = New Label()
        PanelInput = New Panel()
        PanelForm = New Panel()
        grpBayar = New GroupBox()
        txtKembalian = New TextBox()
        lblKembalian = New Label()
        txtNominalBayar = New TextBox()
        lblNominal = New Label()
        cbStatus = New ComboBox()
        lblStatus = New Label()
        cbMetode = New ComboBox()
        lblMetode = New Label()
        dtTanggal = New DateTimePicker()
        lblTanggal = New Label()
        grpTotal = New GroupBox()
        txtGrandTotal = New TextBox()
        lblGrandTotal = New Label()
        txtTotalPerawatan = New TextBox()
        lblTotalPerawatan = New Label()
        txtTotalHotel = New TextBox()
        lblTotalHotel = New Label()
        grpInfo = New GroupBox()
        txtInfo = New RichTextBox()
        btnCari = New Button()
        txtIdBooking = New TextBox()
        lblBooking = New Label()
        lblInputTitle = New Label()
        PanelGrid = New Panel()
        dgvDetail = New DataGridView()
        lblDataTitle = New Label()
        PanelCatatan = New Panel()
        txtCatatan = New RichTextBox()
        lblCatatan = New Label()
        Panel1.SuspendLayout()
        PanelHeader.SuspendLayout()
        PanelInput.SuspendLayout()
        PanelForm.SuspendLayout()
        grpBayar.SuspendLayout()
        grpTotal.SuspendLayout()
        grpInfo.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(dgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        PanelCatatan.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(PanelHeader)
        Panel1.Controls.Add(PanelInput)
        Panel1.Controls.Add(PanelGrid)
        Panel1.Controls.Add(PanelCatatan)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1450, 950)
        Panel1.TabIndex = 0
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.AliceBlue
        btnPrint.Font = New Font("Microsoft PhagsPa", 11F)
        btnPrint.Location = New Point(1265, 723)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(155, 50)
        btnPrint.TabIndex = 7
        btnPrint.Text = "🖨️ Print Invoice"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 11F)
        btnHapus.Location = New Point(1119, 723)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(134, 51)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft PhagsPa", 11F)
        btnUpdate.Location = New Point(972, 724)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(134, 50)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Microsoft PhagsPa", 11F)
        btnSimpan.Location = New Point(822, 724)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(134, 50)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.AliceBlue
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Location = New Point(30, 17)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1390, 76)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft PhagsPa", 14.125F, FontStyle.Bold)
        lblTitle.Location = New Point(25, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(346, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Form Pembayaran"
        ' 
        ' PanelInput
        ' 
        PanelInput.BackColor = Color.White
        PanelInput.Controls.Add(PanelForm)
        PanelInput.Controls.Add(lblInputTitle)
        PanelInput.Location = New Point(30, 111)
        PanelInput.Name = "PanelInput"
        PanelInput.Size = New Size(744, 658)
        PanelInput.TabIndex = 1
        ' 
        ' PanelForm
        ' 
        PanelForm.BackColor = Color.AliceBlue
        PanelForm.Controls.Add(grpBayar)
        PanelForm.Controls.Add(grpTotal)
        PanelForm.Controls.Add(grpInfo)
        PanelForm.Controls.Add(btnCari)
        PanelForm.Controls.Add(txtIdBooking)
        PanelForm.Controls.Add(lblBooking)
        PanelForm.Location = New Point(20, 65)
        PanelForm.Name = "PanelForm"
        PanelForm.Size = New Size(705, 580)
        PanelForm.TabIndex = 1
        ' 
        ' grpBayar
        ' 
        grpBayar.BackColor = Color.White
        grpBayar.Controls.Add(txtKembalian)
        grpBayar.Controls.Add(lblKembalian)
        grpBayar.Controls.Add(txtNominalBayar)
        grpBayar.Controls.Add(lblNominal)
        grpBayar.Controls.Add(cbStatus)
        grpBayar.Controls.Add(lblStatus)
        grpBayar.Controls.Add(cbMetode)
        grpBayar.Controls.Add(lblMetode)
        grpBayar.Controls.Add(dtTanggal)
        grpBayar.Controls.Add(lblTanggal)
        grpBayar.Font = New Font("Microsoft PhagsPa", 10.5F, FontStyle.Bold)
        grpBayar.Location = New Point(20, 384)
        grpBayar.Name = "grpBayar"
        grpBayar.Padding = New Padding(4)
        grpBayar.Size = New Size(660, 183)
        grpBayar.TabIndex = 5
        grpBayar.TabStop = False
        grpBayar.Text = "Detail Pembayaran"
        ' 
        ' txtKembalian
        ' 
        txtKembalian.BackColor = Color.LightGreen
        txtKembalian.Font = New Font("Microsoft PhagsPa", 10F, FontStyle.Bold)
        txtKembalian.ForeColor = Color.DarkGreen
        txtKembalian.Location = New Point(350, 128)
        txtKembalian.Name = "txtKembalian"
        txtKembalian.ReadOnly = True
        txtKembalian.Size = New Size(286, 42)
        txtKembalian.TabIndex = 5
        txtKembalian.Text = "Rp 0"
        txtKembalian.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblKembalian
        ' 
        lblKembalian.AutoSize = True
        lblKembalian.Font = New Font("Microsoft PhagsPa", 9.5F, FontStyle.Italic)
        lblKembalian.ForeColor = Color.DarkGreen
        lblKembalian.Location = New Point(195, 133)
        lblKembalian.Margin = New Padding(4, 0, 4, 0)
        lblKembalian.Name = "lblKembalian"
        lblKembalian.Size = New Size(140, 33)
        lblKembalian.TabIndex = 6
        lblKembalian.Text = "Kembalian:"
        lblKembalian.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtNominalBayar
        ' 
        txtNominalBayar.BackColor = SystemColors.ButtonHighlight
        txtNominalBayar.Font = New Font("Microsoft PhagsPa", 10F)
        txtNominalBayar.Location = New Point(450, 79)
        txtNominalBayar.Name = "txtNominalBayar"
        txtNominalBayar.Size = New Size(186, 42)
        txtNominalBayar.TabIndex = 4
        txtNominalBayar.Text = "0"
        txtNominalBayar.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblNominal
        ' 
        lblNominal.AutoSize = True
        lblNominal.Font = New Font("Microsoft PhagsPa", 9.5F)
        lblNominal.Location = New Point(346, 83)
        lblNominal.Margin = New Padding(4, 0, 4, 0)
        lblNominal.Name = "lblNominal"
        lblNominal.Size = New Size(108, 33)
        lblNominal.TabIndex = 7
        lblNominal.Text = "Dibayar:"
        lblNominal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cbStatus
        ' 
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.Font = New Font("Microsoft PhagsPa", 9.5F)
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        cbStatus.Location = New Point(130, 79)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(198, 40)
        cbStatus.TabIndex = 3
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Microsoft PhagsPa", 9.5F)
        lblStatus.Location = New Point(26, 83)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(92, 33)
        lblStatus.TabIndex = 8
        lblStatus.Text = "Status:"
        lblStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cbMetode
        ' 
        cbMetode.DropDownStyle = ComboBoxStyle.DropDownList
        cbMetode.Font = New Font("Microsoft PhagsPa", 9.5F)
        cbMetode.FormattingEnabled = True
        cbMetode.Items.AddRange(New Object() {"Cash", "Transfer", "Qris"})
        cbMetode.Location = New Point(450, 35)
        cbMetode.Name = "cbMetode"
        cbMetode.Size = New Size(186, 40)
        cbMetode.TabIndex = 2
        ' 
        ' lblMetode
        ' 
        lblMetode.AutoSize = True
        lblMetode.Font = New Font("Microsoft PhagsPa", 9.5F)
        lblMetode.Location = New Point(346, 38)
        lblMetode.Margin = New Padding(4, 0, 4, 0)
        lblMetode.Name = "lblMetode"
        lblMetode.Size = New Size(111, 33)
        lblMetode.TabIndex = 9
        lblMetode.Text = "Metode:"
        lblMetode.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dtTanggal
        ' 
        dtTanggal.CalendarFont = New Font("Microsoft PhagsPa", 9.5F)
        dtTanggal.Font = New Font("Microsoft PhagsPa", 9.5F)
        dtTanggal.Format = DateTimePickerFormat.Short
        dtTanggal.Location = New Point(131, 35)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(198, 40)
        dtTanggal.TabIndex = 1
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Microsoft PhagsPa", 9.5F)
        lblTanggal.Location = New Point(26, 38)
        lblTanggal.Margin = New Padding(4, 0, 4, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(112, 33)
        lblTanggal.TabIndex = 10
        lblTanggal.Text = "Tanggal:"
        lblTanggal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' grpTotal
        ' 
        grpTotal.Controls.Add(txtGrandTotal)
        grpTotal.Controls.Add(lblGrandTotal)
        grpTotal.Controls.Add(txtTotalPerawatan)
        grpTotal.Controls.Add(lblTotalPerawatan)
        grpTotal.Controls.Add(txtTotalHotel)
        grpTotal.Controls.Add(lblTotalHotel)
        grpTotal.Font = New Font("Microsoft PhagsPa", 10.5F, FontStyle.Bold)
        grpTotal.Location = New Point(20, 237)
        grpTotal.Margin = New Padding(4)
        grpTotal.Name = "grpTotal"
        grpTotal.Padding = New Padding(4)
        grpTotal.Size = New Size(660, 134)
        grpTotal.TabIndex = 4
        grpTotal.TabStop = False
        grpTotal.Text = "Ringkasan Biaya"
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.BackColor = Color.LightSalmon
        txtGrandTotal.Font = New Font("Microsoft PhagsPa", 11F, FontStyle.Bold)
        txtGrandTotal.ForeColor = Color.White
        txtGrandTotal.Location = New Point(346, 83)
        txtGrandTotal.Margin = New Padding(4)
        txtGrandTotal.Name = "txtGrandTotal"
        txtGrandTotal.ReadOnly = True
        txtGrandTotal.Size = New Size(306, 45)
        txtGrandTotal.TabIndex = 3
        txtGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.AutoSize = True
        lblGrandTotal.Font = New Font("Microsoft PhagsPa", 10.5F, FontStyle.Bold)
        lblGrandTotal.ForeColor = Color.Maroon
        lblGrandTotal.Location = New Point(155, 90)
        lblGrandTotal.Margin = New Padding(4, 0, 4, 0)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(180, 37)
        lblGrandTotal.TabIndex = 4
        lblGrandTotal.Text = "Grand Total:"
        ' 
        ' txtTotalPerawatan
        ' 
        txtTotalPerawatan.BackColor = SystemColors.ButtonHighlight
        txtTotalPerawatan.Font = New Font("Microsoft PhagsPa", 10F, FontStyle.Bold)
        txtTotalPerawatan.Location = New Point(480, 33)
        txtTotalPerawatan.Margin = New Padding(4)
        txtTotalPerawatan.Name = "txtTotalPerawatan"
        txtTotalPerawatan.ReadOnly = True
        txtTotalPerawatan.Size = New Size(172, 42)
        txtTotalPerawatan.TabIndex = 2
        txtTotalPerawatan.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblTotalPerawatan
        ' 
        lblTotalPerawatan.AutoSize = True
        lblTotalPerawatan.Font = New Font("Microsoft PhagsPa", 9.5F)
        lblTotalPerawatan.Location = New Point(338, 32)
        lblTotalPerawatan.Margin = New Padding(4, 0, 4, 0)
        lblTotalPerawatan.Name = "lblTotalPerawatan"
        lblTotalPerawatan.Size = New Size(141, 33)
        lblTotalPerawatan.TabIndex = 5
        lblTotalPerawatan.Text = "Perawatan:"
        ' 
        ' txtTotalHotel
        ' 
        txtTotalHotel.BackColor = SystemColors.ButtonHighlight
        txtTotalHotel.Font = New Font("Microsoft PhagsPa", 10F, FontStyle.Bold)
        txtTotalHotel.Location = New Point(164, 32)
        txtTotalHotel.Margin = New Padding(4)
        txtTotalHotel.Name = "txtTotalHotel"
        txtTotalHotel.ReadOnly = True
        txtTotalHotel.Size = New Size(168, 42)
        txtTotalHotel.TabIndex = 1
        txtTotalHotel.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblTotalHotel
        ' 
        lblTotalHotel.AutoSize = True
        lblTotalHotel.Font = New Font("Microsoft PhagsPa", 9.5F)
        lblTotalHotel.Location = New Point(26, 32)
        lblTotalHotel.Margin = New Padding(4, 0, 4, 0)
        lblTotalHotel.Name = "lblTotalHotel"
        lblTotalHotel.Size = New Size(147, 33)
        lblTotalHotel.TabIndex = 6
        lblTotalHotel.Text = "Total Hotel:"
        ' 
        ' grpInfo
        ' 
        grpInfo.Controls.Add(txtInfo)
        grpInfo.Font = New Font("Microsoft PhagsPa", 10.5F, FontStyle.Bold)
        grpInfo.Location = New Point(20, 70)
        grpInfo.Margin = New Padding(4)
        grpInfo.Name = "grpInfo"
        grpInfo.Padding = New Padding(4)
        grpInfo.Size = New Size(660, 154)
        grpInfo.TabIndex = 3
        grpInfo.TabStop = False
        grpInfo.Text = "Info Booking"
        ' 
        ' txtInfo
        ' 
        txtInfo.BackColor = SystemColors.ButtonHighlight
        txtInfo.Font = New Font("Microsoft PhagsPa", 9.5F)
        txtInfo.Location = New Point(20, 32)
        txtInfo.Margin = New Padding(4)
        txtInfo.Name = "txtInfo"
        txtInfo.ReadOnly = True
        txtInfo.Size = New Size(632, 108)
        txtInfo.TabIndex = 0
        txtInfo.Text = ""
        ' 
        ' btnCari
        ' 
        btnCari.Font = New Font("Microsoft PhagsPa", 10F)
        btnCari.Location = New Point(568, 13)
        btnCari.Margin = New Padding(4)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(104, 46)
        btnCari.TabIndex = 2
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' txtIdBooking
        ' 
        txtIdBooking.BackColor = SystemColors.ButtonHighlight
        txtIdBooking.Font = New Font("Microsoft PhagsPa", 11F)
        txtIdBooking.Location = New Point(183, 13)
        txtIdBooking.Margin = New Padding(4)
        txtIdBooking.Name = "txtIdBooking"
        txtIdBooking.Size = New Size(376, 45)
        txtIdBooking.TabIndex = 1
        ' 
        ' lblBooking
        ' 
        lblBooking.AutoSize = True
        lblBooking.Font = New Font("Microsoft PhagsPa", 11F)
        lblBooking.Location = New Point(20, 13)
        lblBooking.Margin = New Padding(4, 0, 4, 0)
        lblBooking.Name = "lblBooking"
        lblBooking.Size = New Size(164, 38)
        lblBooking.TabIndex = 6
        lblBooking.Text = "ID Booking"
        ' 
        ' lblInputTitle
        ' 
        lblInputTitle.AutoSize = True
        lblInputTitle.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold)
        lblInputTitle.Location = New Point(20, 12)
        lblInputTitle.Name = "lblInputTitle"
        lblInputTitle.Size = New Size(293, 42)
        lblInputTitle.TabIndex = 2
        lblInputTitle.Text = "Input Pembayaran"
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.White
        PanelGrid.Controls.Add(dgvDetail)
        PanelGrid.Controls.Add(lblDataTitle)
        PanelGrid.Location = New Point(820, 114)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Size = New Size(599, 593)
        PanelGrid.TabIndex = 2
        ' 
        ' dgvDetail
        ' 
        dgvDetail.BackgroundColor = Color.AliceBlue
        dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetail.Location = New Point(20, 59)
        dgvDetail.Name = "dgvDetail"
        dgvDetail.ReadOnly = True
        dgvDetail.RowHeadersWidth = 50
        dgvDetail.Size = New Size(559, 518)
        dgvDetail.TabIndex = 1
        ' 
        ' lblDataTitle
        ' 
        lblDataTitle.AutoSize = True
        lblDataTitle.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold)
        lblDataTitle.Location = New Point(20, 9)
        lblDataTitle.Name = "lblDataTitle"
        lblDataTitle.Size = New Size(273, 42)
        lblDataTitle.TabIndex = 2
        lblDataTitle.Text = "Detail Perawatan"
        ' 
        ' PanelCatatan
        ' 
        PanelCatatan.BackColor = Color.AliceBlue
        PanelCatatan.Controls.Add(txtCatatan)
        PanelCatatan.Controls.Add(lblCatatan)
        PanelCatatan.Location = New Point(30, 790)
        PanelCatatan.Name = "PanelCatatan"
        PanelCatatan.Size = New Size(1390, 104)
        PanelCatatan.TabIndex = 3
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Font = New Font("Microsoft PhagsPa", 10.875F)
        txtCatatan.Location = New Point(30, 50)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.ReadOnly = True
        txtCatatan.Size = New Size(1338, 40)
        txtCatatan.TabIndex = 1
        txtCatatan.Text = ""
        ' 
        ' lblCatatan
        ' 
        lblCatatan.AutoSize = True
        lblCatatan.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold)
        lblCatatan.Location = New Point(21, 4)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(132, 42)
        lblCatatan.TabIndex = 2
        lblCatatan.Text = "Catatan"
        ' 
        ' uc_PembayaranStaff
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "uc_PembayaranStaff"
        Size = New Size(1450, 950)
        Panel1.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelInput.ResumeLayout(False)
        PanelInput.PerformLayout()
        PanelForm.ResumeLayout(False)
        PanelForm.PerformLayout()
        grpBayar.ResumeLayout(False)
        grpBayar.PerformLayout()
        grpTotal.ResumeLayout(False)
        grpTotal.PerformLayout()
        grpInfo.ResumeLayout(False)
        PanelGrid.ResumeLayout(False)
        PanelGrid.PerformLayout()
        CType(dgvDetail, ComponentModel.ISupportInitialize).EndInit()
        PanelCatatan.ResumeLayout(False)
        PanelCatatan.PerformLayout()
        ResumeLayout(False)
    End Sub

    ' ==========================================
    ' CONTROL DECLARATIONS
    ' ==========================================
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PanelInput As Panel
    Friend WithEvents lblInputTitle As Label
    Friend WithEvents PanelForm As Panel

    Friend WithEvents lblBooking As Label
    Friend WithEvents txtIdBooking As TextBox
    Friend WithEvents btnCari As Button

    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents txtInfo As RichTextBox

    Friend WithEvents grpTotal As GroupBox
    Friend WithEvents txtTotalHotel As TextBox
    Friend WithEvents lblTotalHotel As Label
    Friend WithEvents txtTotalPerawatan As TextBox
    Friend WithEvents lblTotalPerawatan As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents lblGrandTotal As Label

    Friend WithEvents grpBayar As GroupBox
    Friend WithEvents lblTanggal As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents lblMetode As Label
    Friend WithEvents cbMetode As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lblNominal As Label
    Friend WithEvents txtNominalBayar As TextBox
    Friend WithEvents lblKembalian As Label
    Friend WithEvents txtKembalian As TextBox

    Friend WithEvents PanelGrid As Panel
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents lblDataTitle As Label

    Friend WithEvents PanelCatatan As Panel
    Friend WithEvents txtCatatan As RichTextBox
    Friend WithEvents lblCatatan As Label

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnPrint As Button

End Class