<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_PerawatanStaff
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
        btnHapus = New Button()
        PanelHeader = New Panel()
        lblTitle = New Label()
        btnSimpan = New Button()
        btnUpdate = New Button()
        PanelInput = New Panel()
        PanelForm = New Panel()
        txtTarif = New TextBox()
        lblTarif = New Label()
        dtTanggal = New DateTimePicker()
        lblTanggal = New Label()
        cbJenisPerawatan = New ComboBox()
        lblPerawatan = New Label()
        cbNamaHewan = New ComboBox()
        lblHewan = New Label()
        lblInputTitle = New Label()
        PanelGrid = New Panel()
        dgvPerawatan = New DataGridView()
        lblDataTitle = New Label()
        PanelCatatan = New Panel()
        txtCatatan = New RichTextBox()
        lblCatatan = New Label()
        Panel1.SuspendLayout()
        PanelHeader.SuspendLayout()
        PanelInput.SuspendLayout()
        PanelForm.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(dgvPerawatan, ComponentModel.ISupportInitialize).BeginInit()
        PanelCatatan.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(PanelHeader)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(PanelInput)
        Panel1.Controls.Add(PanelGrid)
        Panel1.Controls.Add(PanelCatatan)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1450, 950)
        Panel1.TabIndex = 0
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 11F)
        btnHapus.Location = New Point(360, 735)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(160, 60)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.AliceBlue
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Location = New Point(30, 20)
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
        lblTitle.Size = New Size(322, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Form Perawatan "
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Microsoft PhagsPa", 11F)
        btnSimpan.Location = New Point(30, 735)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(160, 60)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft PhagsPa", 11F)
        btnUpdate.Location = New Point(195, 735)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(160, 60)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' PanelInput
        ' 
        PanelInput.BackColor = Color.White
        PanelInput.Controls.Add(PanelForm)
        PanelInput.Controls.Add(lblInputTitle)
        PanelInput.Location = New Point(30, 120)
        PanelInput.Name = "PanelInput"
        PanelInput.Size = New Size(650, 451)
        PanelInput.TabIndex = 1
        ' 
        ' PanelForm
        ' 
        PanelForm.BackColor = Color.AliceBlue
        PanelForm.Controls.Add(txtTarif)
        PanelForm.Controls.Add(lblTarif)
        PanelForm.Controls.Add(dtTanggal)
        PanelForm.Controls.Add(lblTanggal)
        PanelForm.Controls.Add(cbJenisPerawatan)
        PanelForm.Controls.Add(lblPerawatan)
        PanelForm.Controls.Add(cbNamaHewan)
        PanelForm.Controls.Add(lblHewan)
        PanelForm.Location = New Point(20, 65)
        PanelForm.Name = "PanelForm"
        PanelForm.Size = New Size(610, 365)
        PanelForm.TabIndex = 1
        ' 
        ' txtTarif
        ' 
        txtTarif.BackColor = SystemColors.ButtonHighlight
        txtTarif.Font = New Font("Microsoft PhagsPa", 11F)
        txtTarif.Location = New Point(20, 310)
        txtTarif.Name = "txtTarif"
        txtTarif.ReadOnly = True
        txtTarif.Size = New Size(570, 45)
        txtTarif.TabIndex = 4
        ' 
        ' lblTarif
        ' 
        lblTarif.AutoSize = True
        lblTarif.Font = New Font("Microsoft PhagsPa", 11F)
        lblTarif.Location = New Point(20, 273)
        lblTarif.Name = "lblTarif"
        lblTarif.Size = New Size(136, 38)
        lblTarif.TabIndex = 7
        lblTarif.Text = "Tarif (Rp)"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Font = New Font("Microsoft PhagsPa", 11F)
        dtTanggal.Location = New Point(20, 221)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(570, 45)
        dtTanggal.TabIndex = 3
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Microsoft PhagsPa", 11F)
        lblTanggal.Location = New Point(20, 182)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(123, 38)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Tanggal"
        ' 
        ' cbJenisPerawatan
        ' 
        cbJenisPerawatan.Font = New Font("Microsoft PhagsPa", 11F)
        cbJenisPerawatan.FormattingEnabled = True
        cbJenisPerawatan.Location = New Point(20, 136)
        cbJenisPerawatan.Name = "cbJenisPerawatan"
        cbJenisPerawatan.Size = New Size(570, 45)
        cbJenisPerawatan.TabIndex = 2
        ' 
        ' lblPerawatan
        ' 
        lblPerawatan.AutoSize = True
        lblPerawatan.Font = New Font("Microsoft PhagsPa", 11F)
        lblPerawatan.Location = New Point(20, 97)
        lblPerawatan.Name = "lblPerawatan"
        lblPerawatan.Size = New Size(226, 38)
        lblPerawatan.TabIndex = 3
        lblPerawatan.Text = "Jenis Perawatan"
        ' 
        ' cbNamaHewan
        ' 
        cbNamaHewan.Font = New Font("Microsoft PhagsPa", 11F)
        cbNamaHewan.FormattingEnabled = True
        cbNamaHewan.Location = New Point(20, 41)
        cbNamaHewan.Name = "cbNamaHewan"
        cbNamaHewan.Size = New Size(570, 45)
        cbNamaHewan.TabIndex = 1
        ' 
        ' lblHewan
        ' 
        lblHewan.AutoSize = True
        lblHewan.Font = New Font("Microsoft PhagsPa", 11F)
        lblHewan.Location = New Point(20, 6)
        lblHewan.Name = "lblHewan"
        lblHewan.Size = New Size(194, 38)
        lblHewan.TabIndex = 1
        lblHewan.Text = "Nama Hewan"
        ' 
        ' lblInputTitle
        ' 
        lblInputTitle.AutoSize = True
        lblInputTitle.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold)
        lblInputTitle.Location = New Point(20, 12)
        lblInputTitle.Name = "lblInputTitle"
        lblInputTitle.Size = New Size(265, 42)
        lblInputTitle.TabIndex = 0
        lblInputTitle.Text = "Input Perawatan"
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.White
        PanelGrid.Controls.Add(dgvPerawatan)
        PanelGrid.Controls.Add(lblDataTitle)
        PanelGrid.Location = New Point(710, 120)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Size = New Size(710, 451)
        PanelGrid.TabIndex = 2
        ' 
        ' dgvPerawatan
        ' 
        dgvPerawatan.BackgroundColor = Color.AliceBlue
        dgvPerawatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPerawatan.Location = New Point(20, 60)
        dgvPerawatan.Name = "dgvPerawatan"
        dgvPerawatan.RowHeadersWidth = 50
        dgvPerawatan.Size = New Size(670, 370)
        dgvPerawatan.TabIndex = 1
        ' 
        ' lblDataTitle
        ' 
        lblDataTitle.AutoSize = True
        lblDataTitle.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold)
        lblDataTitle.Location = New Point(13, 12)
        lblDataTitle.Name = "lblDataTitle"
        lblDataTitle.Size = New Size(255, 42)
        lblDataTitle.TabIndex = 0
        lblDataTitle.Text = "Data Perawatan"
        ' 
        ' PanelCatatan
        ' 
        PanelCatatan.BackColor = Color.AliceBlue
        PanelCatatan.Controls.Add(txtCatatan)
        PanelCatatan.Controls.Add(lblCatatan)
        PanelCatatan.Location = New Point(30, 595)
        PanelCatatan.Name = "PanelCatatan"
        PanelCatatan.Size = New Size(1390, 120)
        PanelCatatan.TabIndex = 3
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Font = New Font("Microsoft PhagsPa", 10.875F)
        txtCatatan.Location = New Point(30, 55)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.Size = New Size(1338, 45)
        txtCatatan.TabIndex = 1
        txtCatatan.Text = ""
        ' 
        ' lblCatatan
        ' 
        lblCatatan.AutoSize = True
        lblCatatan.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold)
        lblCatatan.Location = New Point(20, 12)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(132, 42)
        lblCatatan.TabIndex = 0
        lblCatatan.Text = "Catatan"
        ' 
        ' uc_PerawatanStaff
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "uc_PerawatanStaff"
        Size = New Size(1450, 950)
        Panel1.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelInput.ResumeLayout(False)
        PanelInput.PerformLayout()
        PanelForm.ResumeLayout(False)
        PanelForm.PerformLayout()
        PanelGrid.ResumeLayout(False)
        PanelGrid.PerformLayout()
        CType(dgvPerawatan, ComponentModel.ISupportInitialize).EndInit()
        PanelCatatan.ResumeLayout(False)
        PanelCatatan.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PanelInput As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents lblTarif As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents lblTanggal As Label
    Friend WithEvents cbJenisPerawatan As ComboBox
    Friend WithEvents lblPerawatan As Label
    Friend WithEvents cbNamaHewan As ComboBox
    Friend WithEvents lblHewan As Label
    Friend WithEvents lblInputTitle As Label
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents dgvPerawatan As DataGridView
    Friend WithEvents lblDataTitle As Label
    Friend WithEvents PanelCatatan As Panel
    Friend WithEvents txtCatatan As RichTextBox
    Friend WithEvents lblCatatan As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSimpan As Button

End Class