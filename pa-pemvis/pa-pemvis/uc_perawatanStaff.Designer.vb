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
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1115, 742)
        Panel1.TabIndex = 0
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 11.0F)
        btnHapus.Location = New Point(277, 574)
        btnHapus.Margin = New Padding(2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(123, 47)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.AliceBlue
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Location = New Point(23, 16)
        PanelHeader.Margin = New Padding(2)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1069, 59)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft PhagsPa", 14.125F, FontStyle.Bold)
        lblTitle.Location = New Point(19, 14)
        lblTitle.Margin = New Padding(2, 0, 2, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(251, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Form Perawatan "
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Microsoft PhagsPa", 11.0F)
        btnSimpan.Location = New Point(23, 574)
        btnSimpan.Margin = New Padding(2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(123, 47)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft PhagsPa", 11.0F)
        btnUpdate.Location = New Point(150, 574)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(123, 47)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' PanelInput
        ' 
        PanelInput.BackColor = Color.White
        PanelInput.Controls.Add(PanelForm)
        PanelInput.Controls.Add(lblInputTitle)
        PanelInput.Location = New Point(23, 94)
        PanelInput.Margin = New Padding(2)
        PanelInput.Name = "PanelInput"
        PanelInput.Size = New Size(500, 352)
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
        PanelForm.Location = New Point(15, 51)
        PanelForm.Margin = New Padding(2)
        PanelForm.Name = "PanelForm"
        PanelForm.Size = New Size(469, 285)
        PanelForm.TabIndex = 1
        ' 
        ' txtTarif
        ' 
        txtTarif.BackColor = SystemColors.ButtonHighlight
        txtTarif.Font = New Font("Microsoft PhagsPa", 11.0F)
        txtTarif.Location = New Point(15, 242)
        txtTarif.Margin = New Padding(2)
        txtTarif.Name = "txtTarif"
        txtTarif.ReadOnly = True
        txtTarif.Size = New Size(439, 36)
        txtTarif.TabIndex = 4
        ' 
        ' lblTarif
        ' 
        lblTarif.AutoSize = True
        lblTarif.Font = New Font("Microsoft PhagsPa", 11.0F)
        lblTarif.Location = New Point(15, 213)
        lblTarif.Margin = New Padding(2, 0, 2, 0)
        lblTarif.Name = "lblTarif"
        lblTarif.Size = New Size(101, 28)
        lblTarif.TabIndex = 7
        lblTarif.Text = "Tarif (Rp)"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Font = New Font("Microsoft PhagsPa", 11.0F)
        dtTanggal.Location = New Point(15, 173)
        dtTanggal.Margin = New Padding(2)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(439, 36)
        dtTanggal.TabIndex = 3
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Microsoft PhagsPa", 11.0F)
        lblTanggal.Location = New Point(15, 142)
        lblTanggal.Margin = New Padding(2, 0, 2, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(89, 28)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Tanggal"
        ' 
        ' cbJenisPerawatan
        ' 
        cbJenisPerawatan.Font = New Font("Microsoft PhagsPa", 11.0F)
        cbJenisPerawatan.FormattingEnabled = True
        cbJenisPerawatan.Location = New Point(15, 106)
        cbJenisPerawatan.Margin = New Padding(2)
        cbJenisPerawatan.Name = "cbJenisPerawatan"
        cbJenisPerawatan.Size = New Size(439, 36)
        cbJenisPerawatan.TabIndex = 2
        ' 
        ' lblPerawatan
        ' 
        lblPerawatan.AutoSize = True
        lblPerawatan.Font = New Font("Microsoft PhagsPa", 11.0F)
        lblPerawatan.Location = New Point(15, 76)
        lblPerawatan.Margin = New Padding(2, 0, 2, 0)
        lblPerawatan.Name = "lblPerawatan"
        lblPerawatan.Size = New Size(164, 28)
        lblPerawatan.TabIndex = 3
        lblPerawatan.Text = "Jenis Perawatan"
        ' 
        ' cbNamaHewan
        ' 
        cbNamaHewan.Font = New Font("Microsoft PhagsPa", 11.0F)
        cbNamaHewan.FormattingEnabled = True
        cbNamaHewan.Location = New Point(15, 32)
        cbNamaHewan.Margin = New Padding(2)
        cbNamaHewan.Name = "cbNamaHewan"
        cbNamaHewan.Size = New Size(439, 36)
        cbNamaHewan.TabIndex = 1
        ' 
        ' lblHewan
        ' 
        lblHewan.AutoSize = True
        lblHewan.Font = New Font("Microsoft PhagsPa", 11.0F)
        lblHewan.Location = New Point(15, 5)
        lblHewan.Margin = New Padding(2, 0, 2, 0)
        lblHewan.Name = "lblHewan"
        lblHewan.Size = New Size(142, 28)
        lblHewan.TabIndex = 1
        lblHewan.Text = "Nama Hewan"
        ' 
        ' lblInputTitle
        ' 
        lblInputTitle.AutoSize = True
        lblInputTitle.Font = New Font("Microsoft PhagsPa", 12.0F, FontStyle.Bold)
        lblInputTitle.Location = New Point(15, 9)
        lblInputTitle.Margin = New Padding(2, 0, 2, 0)
        lblInputTitle.Name = "lblInputTitle"
        lblInputTitle.Size = New Size(203, 32)
        lblInputTitle.TabIndex = 0
        lblInputTitle.Text = "Input Perawatan"
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.White
        PanelGrid.Controls.Add(dgvPerawatan)
        PanelGrid.Controls.Add(lblDataTitle)
        PanelGrid.Location = New Point(546, 94)
        PanelGrid.Margin = New Padding(2)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Size = New Size(546, 352)
        PanelGrid.TabIndex = 2
        ' 
        ' dgvPerawatan
        ' 
        dgvPerawatan.BackgroundColor = Color.AliceBlue
        dgvPerawatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPerawatan.Location = New Point(15, 47)
        dgvPerawatan.Margin = New Padding(2)
        dgvPerawatan.Name = "dgvPerawatan"
        dgvPerawatan.RowHeadersWidth = 50
        dgvPerawatan.Size = New Size(515, 289)
        dgvPerawatan.TabIndex = 1
        ' 
        ' lblDataTitle
        ' 
        lblDataTitle.AutoSize = True
        lblDataTitle.Font = New Font("Microsoft PhagsPa", 12.0F, FontStyle.Bold)
        lblDataTitle.Location = New Point(10, 9)
        lblDataTitle.Margin = New Padding(2, 0, 2, 0)
        lblDataTitle.Name = "lblDataTitle"
        lblDataTitle.Size = New Size(194, 32)
        lblDataTitle.TabIndex = 0
        lblDataTitle.Text = "Data Perawatan"
        ' 
        ' PanelCatatan
        ' 
        PanelCatatan.BackColor = Color.AliceBlue
        PanelCatatan.Controls.Add(txtCatatan)
        PanelCatatan.Controls.Add(lblCatatan)
        PanelCatatan.Location = New Point(23, 465)
        PanelCatatan.Margin = New Padding(2)
        PanelCatatan.Name = "PanelCatatan"
        PanelCatatan.Size = New Size(1069, 94)
        PanelCatatan.TabIndex = 3
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Font = New Font("Microsoft PhagsPa", 10.875F)
        txtCatatan.Location = New Point(23, 43)
        txtCatatan.Margin = New Padding(2)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.Size = New Size(1030, 36)
        txtCatatan.TabIndex = 1
        txtCatatan.Text = ""
        ' 
        ' lblCatatan
        ' 
        lblCatatan.AutoSize = True
        lblCatatan.Font = New Font("Microsoft PhagsPa", 12.0F, FontStyle.Bold)
        lblCatatan.Location = New Point(15, 9)
        lblCatatan.Margin = New Padding(2, 0, 2, 0)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(101, 32)
        lblCatatan.TabIndex = 0
        lblCatatan.Text = "Catatan"
        ' 
        ' uc_PerawatanStaff
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "uc_PerawatanStaff"
        Size = New Size(1115, 742)
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