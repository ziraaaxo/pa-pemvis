<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Dashboard
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
        Label17 = New Label()
        Panel4 = New Panel()
        panelPembayaran = New Panel()
        picPembayaran = New PictureBox()
        lblPembayaran = New Label()
        panelBooking = New Panel()
        picBooking = New PictureBox()
        lblBooking = New Label()
        panelHewan = New Panel()
        picHewan = New PictureBox()
        lblHewan = New Label()
        panelOwner = New Panel()
        picOwner = New PictureBox()
        lblOwner = New Label()
        Label10 = New Label()
        Panel1 = New Panel()
        Panel6 = New Panel()
        btnLaporan = New Button()
        cbBulanLaporan = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        picDashboard = New PictureBox()
        Panel4.SuspendLayout()
        panelPembayaran.SuspendLayout()
        CType(picPembayaran, ComponentModel.ISupportInitialize).BeginInit()
        panelBooking.SuspendLayout()
        CType(picBooking, ComponentModel.ISupportInitialize).BeginInit()
        panelHewan.SuspendLayout()
        CType(picHewan, ComponentModel.ISupportInitialize).BeginInit()
        panelOwner.SuspendLayout()
        CType(picOwner, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        CType(picDashboard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(230, 55)
        Label17.TabIndex = 21
        Label17.Text = "Dashboard"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(panelPembayaran)
        Panel4.Controls.Add(panelBooking)
        Panel4.Controls.Add(panelHewan)
        Panel4.Controls.Add(panelOwner)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(62, 166)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(546, 641)
        Panel4.TabIndex = 22
        ' 
        ' panelPembayaran
        ' 
        panelPembayaran.BackColor = Color.AliceBlue
        panelPembayaran.Controls.Add(picPembayaran)
        panelPembayaran.Controls.Add(lblPembayaran)
        panelPembayaran.Location = New Point(33, 494)
        panelPembayaran.Name = "panelPembayaran"
        panelPembayaran.Size = New Size(476, 112)
        panelPembayaran.TabIndex = 21
        ' 
        ' picPembayaran
        ' 
        picPembayaran.Dock = DockStyle.Left
        picPembayaran.Location = New Point(0, 0)
        picPembayaran.Name = "picPembayaran"
        picPembayaran.Size = New Size(100, 112)
        picPembayaran.TabIndex = 18
        picPembayaran.TabStop = False
        ' 
        ' lblPembayaran
        ' 
        lblPembayaran.AutoSize = True
        lblPembayaran.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPembayaran.ForeColor = SystemColors.ControlText
        lblPembayaran.Location = New Point(121, 35)
        lblPembayaran.Name = "lblPembayaran"
        lblPembayaran.Size = New Size(243, 37)
        lblPembayaran.TabIndex = 17
        lblPembayaran.Text = "Data Pembayaran"
        ' 
        ' panelBooking
        ' 
        panelBooking.BackColor = Color.AliceBlue
        panelBooking.Controls.Add(picBooking)
        panelBooking.Controls.Add(lblBooking)
        panelBooking.Location = New Point(33, 356)
        panelBooking.Name = "panelBooking"
        panelBooking.Size = New Size(476, 112)
        panelBooking.TabIndex = 20
        ' 
        ' picBooking
        ' 
        picBooking.Dock = DockStyle.Left
        picBooking.Location = New Point(0, 0)
        picBooking.Name = "picBooking"
        picBooking.Size = New Size(100, 112)
        picBooking.TabIndex = 18
        picBooking.TabStop = False
        ' 
        ' lblBooking
        ' 
        lblBooking.AutoSize = True
        lblBooking.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBooking.ForeColor = SystemColors.ControlText
        lblBooking.Location = New Point(121, 37)
        lblBooking.Name = "lblBooking"
        lblBooking.Size = New Size(190, 37)
        lblBooking.TabIndex = 17
        lblBooking.Text = "Data Booking"
        ' 
        ' panelHewan
        ' 
        panelHewan.BackColor = Color.AliceBlue
        panelHewan.Controls.Add(picHewan)
        panelHewan.Controls.Add(lblHewan)
        panelHewan.Location = New Point(33, 220)
        panelHewan.Name = "panelHewan"
        panelHewan.Size = New Size(476, 112)
        panelHewan.TabIndex = 19
        ' 
        ' picHewan
        ' 
        picHewan.Dock = DockStyle.Left
        picHewan.Location = New Point(0, 0)
        picHewan.Name = "picHewan"
        picHewan.Size = New Size(100, 112)
        picHewan.TabIndex = 18
        picHewan.TabStop = False
        ' 
        ' lblHewan
        ' 
        lblHewan.AutoSize = True
        lblHewan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHewan.ForeColor = SystemColors.ControlText
        lblHewan.Location = New Point(121, 37)
        lblHewan.Name = "lblHewan"
        lblHewan.Size = New Size(173, 37)
        lblHewan.TabIndex = 17
        lblHewan.Text = "Data Hewan"
        ' 
        ' panelOwner
        ' 
        panelOwner.BackColor = Color.AliceBlue
        panelOwner.Controls.Add(picOwner)
        panelOwner.Controls.Add(lblOwner)
        panelOwner.Location = New Point(33, 83)
        panelOwner.Name = "panelOwner"
        panelOwner.Size = New Size(476, 112)
        panelOwner.TabIndex = 16
        ' 
        ' picOwner
        ' 
        picOwner.Dock = DockStyle.Left
        picOwner.Location = New Point(0, 0)
        picOwner.Name = "picOwner"
        picOwner.Size = New Size(100, 112)
        picOwner.TabIndex = 18
        picOwner.TabStop = False
        ' 
        ' lblOwner
        ' 
        lblOwner.AutoSize = True
        lblOwner.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOwner.ForeColor = SystemColors.ControlText
        lblOwner.Location = New Point(121, 39)
        lblOwner.Name = "lblOwner"
        lblOwner.Size = New Size(169, 37)
        lblOwner.TabIndex = 17
        lblOwner.Text = "Data Owner"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(33, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(262, 41)
        Label10.TabIndex = 15
        Label10.Text = "Data Operasional"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(650, 166)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(766, 332)
        Panel1.TabIndex = 23
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(btnLaporan)
        Panel6.Controls.Add(cbBulanLaporan)
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(33, 83)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(696, 211)
        Panel6.TabIndex = 16
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLaporan.Location = New Point(289, 119)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(362, 46)
        btnLaporan.TabIndex = 19
        btnLaporan.Text = "Print Laporan"
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' cbBulanLaporan
        ' 
        cbBulanLaporan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbBulanLaporan.FormattingEnabled = True
        cbBulanLaporan.Location = New Point(289, 40)
        cbBulanLaporan.Name = "cbBulanLaporan"
        cbBulanLaporan.Size = New Size(362, 45)
        cbBulanLaporan.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(47, 39)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 37)
        Label7.TabIndex = 17
        Label7.Text = "Pilih Bulan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(33, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(253, 41)
        Label8.TabIndex = 15
        Label8.Text = "Laporan Bulanan"
        ' 
        ' picDashboard
        ' 
        picDashboard.Location = New Point(1294, 644)
        picDashboard.Name = "picDashboard"
        picDashboard.Size = New Size(638, 512)
        picDashboard.TabIndex = 24
        picDashboard.TabStop = False
        ' 
        ' uc_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(picDashboard)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(Label17)
        Name = "uc_Dashboard"
        Size = New Size(1955, 1182)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        panelPembayaran.ResumeLayout(False)
        panelPembayaran.PerformLayout()
        CType(picPembayaran, ComponentModel.ISupportInitialize).EndInit()
        panelBooking.ResumeLayout(False)
        panelBooking.PerformLayout()
        CType(picBooking, ComponentModel.ISupportInitialize).EndInit()
        panelHewan.ResumeLayout(False)
        panelHewan.PerformLayout()
        CType(picHewan, ComponentModel.ISupportInitialize).EndInit()
        panelOwner.ResumeLayout(False)
        panelOwner.PerformLayout()
        CType(picOwner, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(picDashboard, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelOwner As Panel
    Friend WithEvents lblOwner As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents panelHewan As Panel
    Friend WithEvents picHewan As PictureBox
    Friend WithEvents lblHewan As Label
    Friend WithEvents picOwner As PictureBox
    Friend WithEvents panelPembayaran As Panel
    Friend WithEvents picPembayaran As PictureBox
    Friend WithEvents lblPembayaran As Label
    Friend WithEvents panelBooking As Panel
    Friend WithEvents picBooking As PictureBox
    Friend WithEvents lblBooking As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnLaporan As Button
    Friend WithEvents cbBulanLaporan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents picDashboard As PictureBox

End Class
