<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Booking
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel9 = New Panel()
        txtCari = New TextBox()
        btnCari = New Button()
        Panel10 = New Panel()
        Label2 = New Label()
        btnHapus = New Button()
        btnUpdate = New Button()
        btnSimpan = New Button()
        Panel8 = New Panel()
        dgvBooking = New DataGridView()
        Label1 = New Label()
        Panel7 = New Panel()
        Panel2 = New Panel()
        txtCatatan = New RichTextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        cbStatus = New ComboBox()
        dtCheckOut = New DateTimePicker()
        dtCheckIn = New DateTimePicker()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        cbKandang = New ComboBox()
        Label18 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label16 = New Label()
        cbHewan = New ComboBox()
        Label10 = New Label()
        Label17 = New Label()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel8.SuspendLayout()
        CType(dgvBooking, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(btnCari)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label17)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1955, 1182)
        Panel1.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(txtCari)
        Panel9.Location = New Point(266, 880)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(562, 93)
        Panel9.TabIndex = 21
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCari.Location = New Point(46, 28)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(479, 45)
        txtCari.TabIndex = 16
        ' 
        ' btnCari
        ' 
        btnCari.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCari.Location = New Point(664, 1006)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(164, 55)
        btnCari.TabIndex = 25
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.AliceBlue
        Panel10.Controls.Add(Label2)
        Panel10.Location = New Point(62, 880)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(214, 93)
        Panel10.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(30, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 41)
        Label2.TabIndex = 15
        Label2.Text = "Cari Data"
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(455, 1006)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(180, 55)
        btnHapus.TabIndex = 24
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(259, 1006)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(172, 55)
        btnUpdate.TabIndex = 23
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(62, 1006)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(175, 55)
        btnSimpan.TabIndex = 22
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(dgvBooking)
        Panel8.Controls.Add(Label1)
        Panel8.Location = New Point(896, 426)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(966, 635)
        Panel8.TabIndex = 21
        ' 
        ' dgvBooking
        ' 
        dgvBooking.BackgroundColor = Color.AliceBlue
        dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooking.ColumnHeadersVisible = False
        dgvBooking.Location = New Point(33, 83)
        dgvBooking.Name = "dgvBooking"
        dgvBooking.RowHeadersWidth = 82
        dgvBooking.Size = New Size(896, 519)
        dgvBooking.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(33, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 41)
        Label1.TabIndex = 15
        Label1.Text = "Data Booking"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Panel2)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(896, 166)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(966, 221)
        Panel7.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AliceBlue
        Panel2.Controls.Add(txtCatatan)
        Panel2.Location = New Point(33, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(896, 116)
        Panel2.TabIndex = 16
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Location = New Point(21, 17)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.Size = New Size(858, 84)
        txtCatatan.TabIndex = 21
        txtCatatan.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(33, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 41)
        Label5.TabIndex = 15
        Label5.Text = "Catatan"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label18)
        Panel5.Location = New Point(62, 426)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(766, 417)
        Panel5.TabIndex = 19
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(cbStatus)
        Panel6.Controls.Add(dtCheckOut)
        Panel6.Controls.Add(dtCheckIn)
        Panel6.Controls.Add(Label24)
        Panel6.Controls.Add(Label23)
        Panel6.Controls.Add(Label22)
        Panel6.Controls.Add(Label21)
        Panel6.Controls.Add(cbKandang)
        Panel6.Location = New Point(33, 83)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(696, 312)
        Panel6.TabIndex = 16
        ' 
        ' cbStatus
        ' 
        cbStatus.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Booking", "Check In", "Check Out", "Batal"})
        cbStatus.Location = New Point(337, 237)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(310, 45)
        cbStatus.TabIndex = 23
        ' 
        ' dtCheckOut
        ' 
        dtCheckOut.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtCheckOut.Location = New Point(337, 170)
        dtCheckOut.Name = "dtCheckOut"
        dtCheckOut.Size = New Size(310, 45)
        dtCheckOut.TabIndex = 22
        ' 
        ' dtCheckIn
        ' 
        dtCheckIn.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtCheckIn.Location = New Point(337, 101)
        dtCheckIn.Name = "dtCheckIn"
        dtCheckIn.Size = New Size(310, 45)
        dtCheckIn.TabIndex = 21
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = SystemColors.ControlText
        Label24.Location = New Point(47, 237)
        Label24.Name = "Label24"
        Label24.Size = New Size(95, 37)
        Label24.TabIndex = 20
        Label24.Text = "Status"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlText
        Label23.Location = New Point(47, 176)
        Label23.Name = "Label23"
        Label23.Size = New Size(149, 37)
        Label23.TabIndex = 19
        Label23.Text = "Check Out"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlText
        Label22.Location = New Point(47, 107)
        Label22.Name = "Label22"
        Label22.Size = New Size(125, 37)
        Label22.TabIndex = 18
        Label22.Text = "Check In"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlText
        Label21.Location = New Point(47, 36)
        Label21.Name = "Label21"
        Label21.Size = New Size(130, 37)
        Label21.TabIndex = 17
        Label21.Text = "Kandang"
        ' 
        ' cbKandang
        ' 
        cbKandang.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbKandang.FormattingEnabled = True
        cbKandang.Location = New Point(337, 36)
        cbKandang.Name = "cbKandang"
        cbKandang.Size = New Size(310, 45)
        cbKandang.TabIndex = 1
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.ControlText
        Label18.Location = New Point(33, 22)
        Label18.Name = "Label18"
        Label18.Size = New Size(226, 41)
        Label18.TabIndex = 15
        Label18.Text = "Detail Booking"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(62, 166)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(766, 221)
        Panel4.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(cbHewan)
        Panel3.Location = New Point(33, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(696, 112)
        Panel3.TabIndex = 16
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ControlText
        Label16.Location = New Point(47, 39)
        Label16.Name = "Label16"
        Label16.Size = New Size(190, 37)
        Label16.TabIndex = 17
        Label16.Text = "Nama Hewan"
        ' 
        ' cbHewan
        ' 
        cbHewan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbHewan.FormattingEnabled = True
        cbHewan.Location = New Point(337, 39)
        cbHewan.Name = "cbHewan"
        cbHewan.Size = New Size(310, 45)
        cbHewan.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(33, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 41)
        Label10.TabIndex = 15
        Label10.Text = "Pilih Hewan"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(289, 55)
        Label17.TabIndex = 20
        Label17.Text = "Form Booking"
        ' 
        ' userControlBooking
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "userControlBooking"
        Size = New Size(1955, 1182)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(dgvBooking, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents dtCheckOut As DateTimePicker
    Friend WithEvents dtCheckIn As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cbKandang As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents cbHewan As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCatatan As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label2 As Label

End Class
