<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        panelUtama = New Panel()
        panelSidebar = New Panel()
        Panel2 = New Panel()
        panelTarif = New Panel()
        lblTarif = New Label()
        panelIndicatorTarif = New Panel()
        Label6 = New Label()
        panelUser = New Panel()
        lblUser = New Label()
        panelIndicatorUser = New Panel()
        panelMasterData = New Panel()
        panelPembayaran = New Panel()
        lblPembayaran = New Label()
        panelIndicatorPembayaran = New Panel()
        panelPerawatan = New Panel()
        lblPerawatan = New Label()
        panelIndicatorPerawatan = New Panel()
        panelKandang = New Panel()
        lblKandang = New Label()
        panelIndicatorKandang = New Panel()
        Label2 = New Label()
        picUtama = New PictureBox()
        panelLogout = New Panel()
        lblLogout = New Label()
        panelIndicatorLogout = New Panel()
        panelDashboard = New Panel()
        lblDashboard = New Label()
        panelIndicatorDashboard = New Panel()
        Panel1.SuspendLayout()
        panelSidebar.SuspendLayout()
        Panel2.SuspendLayout()
        panelTarif.SuspendLayout()
        panelUser.SuspendLayout()
        panelMasterData.SuspendLayout()
        panelPembayaran.SuspendLayout()
        panelPerawatan.SuspendLayout()
        panelKandang.SuspendLayout()
        CType(picUtama, ComponentModel.ISupportInitialize).BeginInit()
        panelLogout.SuspendLayout()
        panelDashboard.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(376, -18)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1958, 136)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightBlue
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(878, 63)
        Label1.TabIndex = 0
        Label1.Text = "Sistem Manajemen Pet Hotel - Admin"
        ' 
        ' panelUtama
        ' 
        panelUtama.BackColor = Color.WhiteSmoke
        panelUtama.Location = New Point(376, 115)
        panelUtama.Name = "panelUtama"
        panelUtama.Size = New Size(1955, 1160)
        panelUtama.TabIndex = 2
        ' 
        ' panelSidebar
        ' 
        panelSidebar.BackColor = Color.SteelBlue
        panelSidebar.Controls.Add(panelDashboard)
        panelSidebar.Controls.Add(panelLogout)
        panelSidebar.Controls.Add(Panel2)
        panelSidebar.Controls.Add(panelMasterData)
        panelSidebar.Controls.Add(picUtama)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(376, 1276)
        panelSidebar.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(panelTarif)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(panelUser)
        Panel2.Location = New Point(6, 586)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(373, 262)
        Panel2.TabIndex = 12
        ' 
        ' panelTarif
        ' 
        panelTarif.Controls.Add(lblTarif)
        panelTarif.Controls.Add(panelIndicatorTarif)
        panelTarif.Location = New Point(3, 154)
        panelTarif.Name = "panelTarif"
        panelTarif.Size = New Size(370, 102)
        panelTarif.TabIndex = 3
        ' 
        ' lblTarif
        ' 
        lblTarif.AutoSize = True
        lblTarif.Dock = DockStyle.Fill
        lblTarif.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarif.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblTarif.Location = New Point(12, 0)
        lblTarif.Name = "lblTarif"
        lblTarif.Padding = New Padding(30, 35, 0, 0)
        lblTarif.Size = New Size(240, 69)
        lblTarif.TabIndex = 2
        lblTarif.Text = "Pengaturan Tarif"
        lblTarif.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorTarif
        ' 
        panelIndicatorTarif.Dock = DockStyle.Left
        panelIndicatorTarif.Location = New Point(0, 0)
        panelIndicatorTarif.Name = "panelIndicatorTarif"
        panelIndicatorTarif.Size = New Size(12, 102)
        panelIndicatorTarif.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.MintCream
        Label6.Location = New Point(12, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 31)
        Label6.TabIndex = 0
        Label6.Text = "PENGATURAN"
        ' 
        ' panelUser
        ' 
        panelUser.Controls.Add(lblUser)
        panelUser.Controls.Add(panelIndicatorUser)
        panelUser.Location = New Point(3, 46)
        panelUser.Name = "panelUser"
        panelUser.Size = New Size(370, 102)
        panelUser.TabIndex = 1
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Dock = DockStyle.Fill
        lblUser.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblUser.Location = New Point(12, 0)
        lblUser.Name = "lblUser"
        lblUser.Padding = New Padding(30, 35, 0, 0)
        lblUser.Size = New Size(161, 69)
        lblUser.TabIndex = 2
        lblUser.Text = "Data User"
        lblUser.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorUser
        ' 
        panelIndicatorUser.Dock = DockStyle.Left
        panelIndicatorUser.Location = New Point(0, 0)
        panelIndicatorUser.Name = "panelIndicatorUser"
        panelIndicatorUser.Size = New Size(12, 102)
        panelIndicatorUser.TabIndex = 0
        ' 
        ' panelMasterData
        ' 
        panelMasterData.Controls.Add(panelPembayaran)
        panelMasterData.Controls.Add(panelPerawatan)
        panelMasterData.Controls.Add(panelKandang)
        panelMasterData.Controls.Add(Label2)
        panelMasterData.Location = New Point(3, 220)
        panelMasterData.Name = "panelMasterData"
        panelMasterData.Size = New Size(373, 372)
        panelMasterData.TabIndex = 11
        ' 
        ' panelPembayaran
        ' 
        panelPembayaran.Controls.Add(lblPembayaran)
        panelPembayaran.Controls.Add(panelIndicatorPembayaran)
        panelPembayaran.Location = New Point(3, 262)
        panelPembayaran.Name = "panelPembayaran"
        panelPembayaran.Size = New Size(370, 102)
        panelPembayaran.TabIndex = 4
        ' 
        ' lblPembayaran
        ' 
        lblPembayaran.AutoSize = True
        lblPembayaran.Dock = DockStyle.Fill
        lblPembayaran.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPembayaran.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPembayaran.Location = New Point(12, 0)
        lblPembayaran.Name = "lblPembayaran"
        lblPembayaran.Padding = New Padding(30, 35, 0, 0)
        lblPembayaran.Size = New Size(292, 69)
        lblPembayaran.TabIndex = 2
        lblPembayaran.Text = "Metode Pembayaran"
        lblPembayaran.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorPembayaran
        ' 
        panelIndicatorPembayaran.Dock = DockStyle.Left
        panelIndicatorPembayaran.Location = New Point(0, 0)
        panelIndicatorPembayaran.Name = "panelIndicatorPembayaran"
        panelIndicatorPembayaran.Size = New Size(12, 102)
        panelIndicatorPembayaran.TabIndex = 0
        ' 
        ' panelPerawatan
        ' 
        panelPerawatan.Controls.Add(lblPerawatan)
        panelPerawatan.Controls.Add(panelIndicatorPerawatan)
        panelPerawatan.Location = New Point(3, 154)
        panelPerawatan.Name = "panelPerawatan"
        panelPerawatan.Size = New Size(370, 102)
        panelPerawatan.TabIndex = 3
        ' 
        ' lblPerawatan
        ' 
        lblPerawatan.AutoSize = True
        lblPerawatan.Dock = DockStyle.Fill
        lblPerawatan.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPerawatan.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPerawatan.Location = New Point(12, 0)
        lblPerawatan.Name = "lblPerawatan"
        lblPerawatan.Padding = New Padding(30, 35, 0, 0)
        lblPerawatan.Size = New Size(232, 69)
        lblPerawatan.TabIndex = 2
        lblPerawatan.Text = "Data Perawatan"
        lblPerawatan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorPerawatan
        ' 
        panelIndicatorPerawatan.Dock = DockStyle.Left
        panelIndicatorPerawatan.Location = New Point(0, 0)
        panelIndicatorPerawatan.Name = "panelIndicatorPerawatan"
        panelIndicatorPerawatan.Size = New Size(12, 102)
        panelIndicatorPerawatan.TabIndex = 0
        ' 
        ' panelKandang
        ' 
        panelKandang.Controls.Add(lblKandang)
        panelKandang.Controls.Add(panelIndicatorKandang)
        panelKandang.Location = New Point(3, 46)
        panelKandang.Name = "panelKandang"
        panelKandang.Size = New Size(370, 102)
        panelKandang.TabIndex = 1
        ' 
        ' lblKandang
        ' 
        lblKandang.AutoSize = True
        lblKandang.Dock = DockStyle.Fill
        lblKandang.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKandang.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblKandang.Location = New Point(12, 0)
        lblKandang.Name = "lblKandang"
        lblKandang.Padding = New Padding(30, 35, 0, 0)
        lblKandang.Size = New Size(214, 69)
        lblKandang.TabIndex = 2
        lblKandang.Text = "Data Kandang"
        lblKandang.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorKandang
        ' 
        panelIndicatorKandang.Dock = DockStyle.Left
        panelIndicatorKandang.Location = New Point(0, 0)
        panelIndicatorKandang.Name = "panelIndicatorKandang"
        panelIndicatorKandang.Size = New Size(12, 102)
        panelIndicatorKandang.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MintCream
        Label2.Location = New Point(9, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 31)
        Label2.TabIndex = 0
        Label2.Text = "MASTER DATA"
        ' 
        ' picUtama
        ' 
        picUtama.Location = New Point(89, 8)
        picUtama.Name = "picUtama"
        picUtama.Size = New Size(200, 100)
        picUtama.TabIndex = 10
        picUtama.TabStop = False
        ' 
        ' panelLogout
        ' 
        panelLogout.Controls.Add(lblLogout)
        panelLogout.Controls.Add(panelIndicatorLogout)
        panelLogout.Location = New Point(4, 846)
        panelLogout.Name = "panelLogout"
        panelLogout.Size = New Size(376, 102)
        panelLogout.TabIndex = 13
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Dock = DockStyle.Fill
        lblLogout.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogout.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblLogout.Location = New Point(5, 0)
        lblLogout.Name = "lblLogout"
        lblLogout.Padding = New Padding(30, 35, 0, 0)
        lblLogout.Size = New Size(130, 69)
        lblLogout.TabIndex = 1
        lblLogout.Text = "Logout"
        lblLogout.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorLogout
        ' 
        panelIndicatorLogout.Dock = DockStyle.Left
        panelIndicatorLogout.Location = New Point(0, 0)
        panelIndicatorLogout.Name = "panelIndicatorLogout"
        panelIndicatorLogout.Size = New Size(5, 102)
        panelIndicatorLogout.TabIndex = 0
        ' 
        ' panelDashboard
        ' 
        panelDashboard.Controls.Add(lblDashboard)
        panelDashboard.Controls.Add(panelIndicatorDashboard)
        panelDashboard.Location = New Point(4, 115)
        panelDashboard.Name = "panelDashboard"
        panelDashboard.Size = New Size(376, 102)
        panelDashboard.TabIndex = 14
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Dock = DockStyle.Fill
        lblDashboard.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblDashboard.Location = New Point(5, 0)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Padding = New Padding(30, 35, 0, 0)
        lblDashboard.Size = New Size(175, 69)
        lblDashboard.TabIndex = 1
        lblDashboard.Text = "Dashboard"
        lblDashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' panelIndicatorDashboard
        ' 
        panelIndicatorDashboard.Dock = DockStyle.Left
        panelIndicatorDashboard.Location = New Point(0, 0)
        panelIndicatorDashboard.Name = "panelIndicatorDashboard"
        panelIndicatorDashboard.Size = New Size(5, 102)
        panelIndicatorDashboard.TabIndex = 0
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2334, 1276)
        Controls.Add(panelSidebar)
        Controls.Add(Panel1)
        Controls.Add(panelUtama)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MaximumSize = New Size(2360, 1347)
        MinimumSize = New Size(2360, 1347)
        Name = "FormAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Pet Hotel"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        panelSidebar.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        panelTarif.ResumeLayout(False)
        panelTarif.PerformLayout()
        panelUser.ResumeLayout(False)
        panelUser.PerformLayout()
        panelMasterData.ResumeLayout(False)
        panelMasterData.PerformLayout()
        panelPembayaran.ResumeLayout(False)
        panelPembayaran.PerformLayout()
        panelPerawatan.ResumeLayout(False)
        panelPerawatan.PerformLayout()
        panelKandang.ResumeLayout(False)
        panelKandang.PerformLayout()
        CType(picUtama, ComponentModel.ISupportInitialize).EndInit()
        panelLogout.ResumeLayout(False)
        panelLogout.PerformLayout()
        panelDashboard.ResumeLayout(False)
        panelDashboard.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelUtama As Panel
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents panelDashboard As Panel
    Friend WithEvents panelIndicatorDashboard As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents panelBooking As Panel
    Friend WithEvents lblBooking As Label
    Friend WithEvents panelMasterData As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHewn As Label
    Friend WithEvents panelTarif As Panel
    Friend WithEvents panelLogout As Panel
    Friend WithEvents lblLogout As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents panelUser As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents panelIndicatorLogout As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents panelIndicatorUser As Panel
    Friend WithEvents panelPerawatan As Panel
    Friend WithEvents lblPerawatan As Label
    Friend WithEvents panelUser As Panel
    Friend WithEvents panelKandang As Panel
    Friend WithEvents lblKandang As Label
    Friend WithEvents panelIndicatorTarif As Panel
    Friend WithEvents picUtama As PictureBox
    Friend WithEvents panelIndicatorKandang As Panel
    Friend WithEvents panelIndicatorPerawatan As Panel
    Friend WithEvents panelPembayaran As Panel
    Friend WithEvents lblPembayaran As Label
    Friend WithEvents panelIndicatorPembayaran As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTarif As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblUser As Label

End Class
