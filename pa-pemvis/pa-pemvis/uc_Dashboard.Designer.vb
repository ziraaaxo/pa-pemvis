<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_Dashboard
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
        lblInfoLaporan = New Label()
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
        Label17.Location = New Point(48, 53)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(176, 42)
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
        Panel4.Location = New Point(48, 130)
        Panel4.Margin = New Padding(2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(420, 501)
        Panel4.TabIndex = 22
        ' 
        ' panelPembayaran
        ' 
        panelPembayaran.BackColor = Color.AliceBlue
        panelPembayaran.Controls.Add(picPembayaran)
        panelPembayaran.Controls.Add(lblPembayaran)
        panelPembayaran.Location = New Point(25, 386)
        panelPembayaran.Margin = New Padding(2)
        panelPembayaran.Name = "panelPembayaran"
        panelPembayaran.Size = New Size(366, 88)
        panelPembayaran.TabIndex = 21
        ' 
        ' picPembayaran
        ' 
        picPembayaran.Dock = DockStyle.Left
        picPembayaran.Location = New Point(0, 0)
        picPembayaran.Margin = New Padding(2)
        picPembayaran.Name = "picPembayaran"
        picPembayaran.Size = New Size(77, 88)
        picPembayaran.TabIndex = 18
        picPembayaran.TabStop = False
        ' 
        ' lblPembayaran
        ' 
        lblPembayaran.AutoSize = True
        lblPembayaran.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPembayaran.ForeColor = SystemColors.ControlText
        lblPembayaran.Location = New Point(93, 27)
        lblPembayaran.Margin = New Padding(2, 0, 2, 0)
        lblPembayaran.Name = "lblPembayaran"
        lblPembayaran.Size = New Size(182, 28)
        lblPembayaran.TabIndex = 17
        lblPembayaran.Text = "Data Pembayaran"
        ' 
        ' panelBooking
        ' 
        panelBooking.BackColor = Color.AliceBlue
        panelBooking.Controls.Add(picBooking)
        panelBooking.Controls.Add(lblBooking)
        panelBooking.Location = New Point(25, 278)
        panelBooking.Margin = New Padding(2)
        panelBooking.Name = "panelBooking"
        panelBooking.Size = New Size(366, 88)
        panelBooking.TabIndex = 20
        ' 
        ' picBooking
        ' 
        picBooking.Dock = DockStyle.Left
        picBooking.Location = New Point(0, 0)
        picBooking.Margin = New Padding(2)
        picBooking.Name = "picBooking"
        picBooking.Size = New Size(77, 88)
        picBooking.TabIndex = 18
        picBooking.TabStop = False
        ' 
        ' lblBooking
        ' 
        lblBooking.AutoSize = True
        lblBooking.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBooking.ForeColor = SystemColors.ControlText
        lblBooking.Location = New Point(93, 29)
        lblBooking.Margin = New Padding(2, 0, 2, 0)
        lblBooking.Name = "lblBooking"
        lblBooking.Size = New Size(142, 28)
        lblBooking.TabIndex = 17
        lblBooking.Text = "Data Booking"
        ' 
        ' panelHewan
        ' 
        panelHewan.BackColor = Color.AliceBlue
        panelHewan.Controls.Add(picHewan)
        panelHewan.Controls.Add(lblHewan)
        panelHewan.Location = New Point(25, 172)
        panelHewan.Margin = New Padding(2)
        panelHewan.Name = "panelHewan"
        panelHewan.Size = New Size(366, 88)
        panelHewan.TabIndex = 19
        ' 
        ' picHewan
        ' 
        picHewan.Dock = DockStyle.Left
        picHewan.Location = New Point(0, 0)
        picHewan.Margin = New Padding(2)
        picHewan.Name = "picHewan"
        picHewan.Size = New Size(77, 88)
        picHewan.TabIndex = 18
        picHewan.TabStop = False
        ' 
        ' lblHewan
        ' 
        lblHewan.AutoSize = True
        lblHewan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHewan.ForeColor = SystemColors.ControlText
        lblHewan.Location = New Point(93, 29)
        lblHewan.Margin = New Padding(2, 0, 2, 0)
        lblHewan.Name = "lblHewan"
        lblHewan.Size = New Size(129, 28)
        lblHewan.TabIndex = 17
        lblHewan.Text = "Data Hewan"
        ' 
        ' panelOwner
        ' 
        panelOwner.BackColor = Color.AliceBlue
        panelOwner.Controls.Add(picOwner)
        panelOwner.Controls.Add(lblOwner)
        panelOwner.Location = New Point(25, 65)
        panelOwner.Margin = New Padding(2)
        panelOwner.Name = "panelOwner"
        panelOwner.Size = New Size(366, 88)
        panelOwner.TabIndex = 16
        ' 
        ' picOwner
        ' 
        picOwner.Dock = DockStyle.Left
        picOwner.Location = New Point(0, 0)
        picOwner.Margin = New Padding(2)
        picOwner.Name = "picOwner"
        picOwner.Size = New Size(77, 88)
        picOwner.TabIndex = 18
        picOwner.TabStop = False
        ' 
        ' lblOwner
        ' 
        lblOwner.AutoSize = True
        lblOwner.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOwner.ForeColor = SystemColors.ControlText
        lblOwner.Location = New Point(93, 30)
        lblOwner.Margin = New Padding(2, 0, 2, 0)
        lblOwner.Name = "lblOwner"
        lblOwner.Size = New Size(127, 28)
        lblOwner.TabIndex = 17
        lblOwner.Text = "Data Owner"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(25, 17)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(197, 31)
        Label10.TabIndex = 15
        Label10.Text = "Data Operasional"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(500, 130)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(589, 259)
        Panel1.TabIndex = 23
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(btnLaporan)
        Panel6.Controls.Add(lblInfoLaporan)
        Panel6.Location = New Point(25, 65)
        Panel6.Margin = New Padding(2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(535, 165)
        Panel6.TabIndex = 16
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Font = New Font("Microsoft PhagsPa", 11.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLaporan.Location = New Point(128, 74)
        btnLaporan.Margin = New Padding(2)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(278, 51)
        btnLaporan.TabIndex = 19
        btnLaporan.Text = "📄 Print Laporan "
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' lblInfoLaporan
        ' 
        lblInfoLaporan.Font = New Font("Microsoft PhagsPa", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInfoLaporan.ForeColor = SystemColors.ControlText
        lblInfoLaporan.Location = New Point(23, 16)
        lblInfoLaporan.Margin = New Padding(2, 0, 2, 0)
        lblInfoLaporan.Name = "lblInfoLaporan"
        lblInfoLaporan.Size = New Size(489, 47)
        lblInfoLaporan.TabIndex = 17
        lblInfoLaporan.Text = "Laporan akan mencakup seluruh data operasional, booking, hewan, owner, dan pembayaran dari awal hingga saat ini."
        lblInfoLaporan.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft PhagsPa", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(25, 17)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 31)
        Label8.TabIndex = 15
        Label8.Text = "Laporan "
        ' 
        ' picDashboard
        ' 
        picDashboard.Location = New Point(500, 408)
        picDashboard.Margin = New Padding(2)
        picDashboard.Name = "picDashboard"
        picDashboard.Size = New Size(585, 400)
        picDashboard.TabIndex = 24
        picDashboard.TabStop = False
        ' 
        ' uc_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(picDashboard)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(Label17)
        Margin = New Padding(2)
        Name = "uc_Dashboard"
        Size = New Size(1504, 923)
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
    Friend WithEvents lblInfoLaporan As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents picDashboard As PictureBox

End Class