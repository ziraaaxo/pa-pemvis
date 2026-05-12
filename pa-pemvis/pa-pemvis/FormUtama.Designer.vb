<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        panelLogout = New Panel()
        lblLogout = New Label()
        Panel10 = New Panel()
        panelUser = New Panel()
        lblUser = New Label()
        Panel9 = New Panel()
        panelPembayaran = New Panel()
        lblPembayaran = New Label()
        Panel8 = New Panel()
        panelPerawatan = New Panel()
        lblPerawatan = New Label()
        Panel7 = New Panel()
        panelKandang = New Panel()
        lblKandang = New Label()
        Panel6 = New Panel()
        panelHewan = New Panel()
        lblHewn = New Label()
        Panel5 = New Panel()
        panelOwner = New Panel()
        lblOwner = New Label()
        Panel4 = New Panel()
        panelBooking = New Panel()
        lblBooking = New Label()
        Panel3 = New Panel()
        panelDashboard = New Panel()
        lblDashboard = New Label()
        panelIndicatorDashboard = New Panel()
        Panel1.SuspendLayout()
        panelSidebar.SuspendLayout()
        panelLogout.SuspendLayout()
        panelUser.SuspendLayout()
        panelPembayaran.SuspendLayout()
        panelPerawatan.SuspendLayout()
        panelKandang.SuspendLayout()
        panelHewan.SuspendLayout()
        panelOwner.SuspendLayout()
        panelBooking.SuspendLayout()
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
        Label1.Font = New Font("Microsoft PhagsPa", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightBlue
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(682, 63)
        Label1.TabIndex = 0
        Label1.Text = "Sistem Manajemen Pet Hotel"
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
        panelSidebar.Controls.Add(panelLogout)
        panelSidebar.Controls.Add(panelUser)
        panelSidebar.Controls.Add(panelPembayaran)
        panelSidebar.Controls.Add(panelPerawatan)
        panelSidebar.Controls.Add(panelKandang)
        panelSidebar.Controls.Add(panelHewan)
        panelSidebar.Controls.Add(panelOwner)
        panelSidebar.Controls.Add(panelBooking)
        panelSidebar.Controls.Add(panelDashboard)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(376, 1276)
        panelSidebar.TabIndex = 3
        ' 
        ' panelLogout
        ' 
        panelLogout.Controls.Add(lblLogout)
        panelLogout.Controls.Add(Panel10)
        panelLogout.Location = New Point(3, 979)
        panelLogout.Name = "panelLogout"
        panelLogout.Size = New Size(376, 102)
        panelLogout.TabIndex = 9
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
        ' Panel10
        ' 
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(5, 102)
        Panel10.TabIndex = 0
        ' 
        ' panelUser
        ' 
        panelUser.Controls.Add(lblUser)
        panelUser.Controls.Add(Panel9)
        panelUser.Location = New Point(3, 871)
        panelUser.Name = "panelUser"
        panelUser.Size = New Size(376, 102)
        panelUser.TabIndex = 8
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Dock = DockStyle.Fill
        lblUser.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblUser.Location = New Point(5, 0)
        lblUser.Name = "lblUser"
        lblUser.Padding = New Padding(30, 35, 0, 0)
        lblUser.Size = New Size(98, 69)
        lblUser.TabIndex = 1
        lblUser.Text = "User"
        lblUser.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel9
        ' 
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(5, 102)
        Panel9.TabIndex = 0
        ' 
        ' panelPembayaran
        ' 
        panelPembayaran.Controls.Add(lblPembayaran)
        panelPembayaran.Controls.Add(Panel8)
        panelPembayaran.Location = New Point(3, 763)
        panelPembayaran.Name = "panelPembayaran"
        panelPembayaran.Size = New Size(376, 102)
        panelPembayaran.TabIndex = 7
        ' 
        ' lblPembayaran
        ' 
        lblPembayaran.AutoSize = True
        lblPembayaran.Dock = DockStyle.Fill
        lblPembayaran.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPembayaran.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPembayaran.Location = New Point(5, 0)
        lblPembayaran.Name = "lblPembayaran"
        lblPembayaran.Padding = New Padding(30, 35, 0, 0)
        lblPembayaran.Size = New Size(192, 69)
        lblPembayaran.TabIndex = 1
        lblPembayaran.Text = "Pembayaran"
        lblPembayaran.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel8
        ' 
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(5, 102)
        Panel8.TabIndex = 0
        ' 
        ' panelPerawatan
        ' 
        panelPerawatan.Controls.Add(lblPerawatan)
        panelPerawatan.Controls.Add(Panel7)
        panelPerawatan.Location = New Point(3, 655)
        panelPerawatan.Name = "panelPerawatan"
        panelPerawatan.Size = New Size(376, 102)
        panelPerawatan.TabIndex = 6
        ' 
        ' lblPerawatan
        ' 
        lblPerawatan.AutoSize = True
        lblPerawatan.Dock = DockStyle.Fill
        lblPerawatan.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPerawatan.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPerawatan.Location = New Point(5, 0)
        lblPerawatan.Name = "lblPerawatan"
        lblPerawatan.Padding = New Padding(30, 35, 0, 0)
        lblPerawatan.Size = New Size(169, 69)
        lblPerawatan.TabIndex = 1
        lblPerawatan.Text = "Perawatan"
        lblPerawatan.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(5, 102)
        Panel7.TabIndex = 0
        ' 
        ' panelKandang
        ' 
        panelKandang.Controls.Add(lblKandang)
        panelKandang.Controls.Add(Panel6)
        panelKandang.Location = New Point(3, 547)
        panelKandang.Name = "panelKandang"
        panelKandang.Size = New Size(376, 102)
        panelKandang.TabIndex = 5
        ' 
        ' lblKandang
        ' 
        lblKandang.AutoSize = True
        lblKandang.Dock = DockStyle.Fill
        lblKandang.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKandang.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblKandang.Location = New Point(5, 0)
        lblKandang.Name = "lblKandang"
        lblKandang.Padding = New Padding(30, 35, 0, 0)
        lblKandang.Size = New Size(151, 69)
        lblKandang.TabIndex = 1
        lblKandang.Text = "Kandang"
        lblKandang.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(5, 102)
        Panel6.TabIndex = 0
        ' 
        ' panelHewan
        ' 
        panelHewan.Controls.Add(lblHewn)
        panelHewan.Controls.Add(Panel5)
        panelHewan.Location = New Point(3, 439)
        panelHewan.Name = "panelHewan"
        panelHewan.Size = New Size(376, 102)
        panelHewan.TabIndex = 4
        ' 
        ' lblHewn
        ' 
        lblHewn.AutoSize = True
        lblHewn.Dock = DockStyle.Fill
        lblHewn.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHewn.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblHewn.Location = New Point(5, 0)
        lblHewn.Name = "lblHewn"
        lblHewn.Padding = New Padding(30, 35, 0, 0)
        lblHewn.Size = New Size(190, 69)
        lblHewn.TabIndex = 1
        lblHewn.Text = "Data Hewan"
        lblHewn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(5, 102)
        Panel5.TabIndex = 0
        ' 
        ' panelOwner
        ' 
        panelOwner.Controls.Add(lblOwner)
        panelOwner.Controls.Add(Panel4)
        panelOwner.Location = New Point(3, 331)
        panelOwner.Name = "panelOwner"
        panelOwner.Size = New Size(376, 102)
        panelOwner.TabIndex = 3
        ' 
        ' lblOwner
        ' 
        lblOwner.AutoSize = True
        lblOwner.Dock = DockStyle.Fill
        lblOwner.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOwner.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblOwner.Location = New Point(5, 0)
        lblOwner.Name = "lblOwner"
        lblOwner.Padding = New Padding(30, 35, 0, 0)
        lblOwner.Size = New Size(186, 69)
        lblOwner.TabIndex = 1
        lblOwner.Text = "Data Owner"
        lblOwner.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(5, 102)
        Panel4.TabIndex = 0
        ' 
        ' panelBooking
        ' 
        panelBooking.Controls.Add(lblBooking)
        panelBooking.Controls.Add(Panel3)
        panelBooking.Location = New Point(3, 223)
        panelBooking.Name = "panelBooking"
        panelBooking.Size = New Size(376, 102)
        panelBooking.TabIndex = 2
        ' 
        ' lblBooking
        ' 
        lblBooking.AutoSize = True
        lblBooking.Dock = DockStyle.Fill
        lblBooking.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBooking.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblBooking.Location = New Point(5, 0)
        lblBooking.Name = "lblBooking"
        lblBooking.Padding = New Padding(30, 35, 0, 0)
        lblBooking.Size = New Size(143, 69)
        lblBooking.TabIndex = 1
        lblBooking.Text = "Booking"
        lblBooking.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(5, 102)
        Panel3.TabIndex = 0
        ' 
        ' panelDashboard
        ' 
        panelDashboard.Controls.Add(lblDashboard)
        panelDashboard.Controls.Add(panelIndicatorDashboard)
        panelDashboard.Location = New Point(3, 115)
        panelDashboard.Name = "panelDashboard"
        panelDashboard.Size = New Size(376, 102)
        panelDashboard.TabIndex = 0
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
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2326, 1276)
        Controls.Add(panelSidebar)
        Controls.Add(Panel1)
        Controls.Add(panelUtama)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FormUtama"
        Text = "Sistem Manajemen Pet Hotel"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        panelSidebar.ResumeLayout(False)
        panelLogout.ResumeLayout(False)
        panelLogout.PerformLayout()
        panelUser.ResumeLayout(False)
        panelUser.PerformLayout()
        panelPembayaran.ResumeLayout(False)
        panelPembayaran.PerformLayout()
        panelPerawatan.ResumeLayout(False)
        panelPerawatan.PerformLayout()
        panelKandang.ResumeLayout(False)
        panelKandang.PerformLayout()
        panelHewan.ResumeLayout(False)
        panelHewan.PerformLayout()
        panelOwner.ResumeLayout(False)
        panelOwner.PerformLayout()
        panelBooking.ResumeLayout(False)
        panelBooking.PerformLayout()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelHewan As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHewn As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents panelOwner As Panel
    Friend WithEvents lblOwner As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelLogout As Panel
    Friend WithEvents lblLogout As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents panelUser As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents panelPembayaran As Panel
    Friend WithEvents lblPembayaran As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents panelPerawatan As Panel
    Friend WithEvents lblPerawatan As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents panelKandang As Panel
    Friend WithEvents lblKandang As Label
    Friend WithEvents Panel6 As Panel

End Class
