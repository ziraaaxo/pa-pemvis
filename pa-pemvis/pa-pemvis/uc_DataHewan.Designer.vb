<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataHewan
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        cbOwner = New ComboBox()
        txtNama = New TextBox()
        cbJenis = New ComboBox()
        txtRas = New TextBox()
        cbJK = New ComboBox()
        txtUmur = New TextBox()
        txtWarna = New TextBox()
        txtBerat = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvHewan = New DataGridView()
        lblID = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label11 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label17 = New Label()
        CType(dgvHewan, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 49)
        Label1.TabIndex = 0
        Label1.Text = "Owner"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 48)
        Label2.TabIndex = 1
        Label2.Text = "Nama Hewan"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft PhagsPa", 12F)
        Label3.Location = New Point(39, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 33)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Hewan"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft PhagsPa", 12F)
        Label4.Location = New Point(39, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 48)
        Label4.TabIndex = 3
        Label4.Text = "Ras"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft PhagsPa", 12F)
        Label5.Location = New Point(39, 321)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 48)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft PhagsPa", 12F)
        Label6.Location = New Point(39, 391)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 48)
        Label6.TabIndex = 5
        Label6.Text = "Umur"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Microsoft PhagsPa", 12F)
        Label7.Location = New Point(39, 461)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 48)
        Label7.TabIndex = 6
        Label7.Text = "Warna"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Microsoft PhagsPa", 12F)
        Label8.Location = New Point(39, 531)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 48)
        Label8.TabIndex = 7
        Label8.Text = "Berat"
        ' 
        ' cbOwner
        ' 
        cbOwner.Font = New Font("Microsoft PhagsPa", 12F)
        cbOwner.Location = New Point(247, 41)
        cbOwner.Name = "cbOwner"
        cbOwner.Size = New Size(400, 49)
        cbOwner.TabIndex = 8
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft PhagsPa", 12F)
        txtNama.Location = New Point(247, 111)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(400, 48)
        txtNama.TabIndex = 9
        ' 
        ' cbJenis
        ' 
        cbJenis.Font = New Font("Microsoft PhagsPa", 12F)
        cbJenis.Items.AddRange(New Object() {"Kucing", "Anjing", "Kelinci", "Hamster"})
        cbJenis.Location = New Point(247, 181)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(400, 49)
        cbJenis.TabIndex = 10
        ' 
        ' txtRas
        ' 
        txtRas.Font = New Font("Microsoft PhagsPa", 12F)
        txtRas.Location = New Point(247, 251)
        txtRas.Name = "txtRas"
        txtRas.Size = New Size(400, 48)
        txtRas.TabIndex = 11
        ' 
        ' cbJK
        ' 
        cbJK.Font = New Font("Microsoft PhagsPa", 12F)
        cbJK.Items.AddRange(New Object() {"Jantan", "Betina"})
        cbJK.Location = New Point(247, 321)
        cbJK.Name = "cbJK"
        cbJK.Size = New Size(400, 49)
        cbJK.TabIndex = 12
        ' 
        ' txtUmur
        ' 
        txtUmur.Font = New Font("Microsoft PhagsPa", 12F)
        txtUmur.Location = New Point(247, 391)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(202, 48)
        txtUmur.TabIndex = 13
        ' 
        ' txtWarna
        ' 
        txtWarna.Font = New Font("Microsoft PhagsPa", 12F)
        txtWarna.Location = New Point(247, 461)
        txtWarna.Name = "txtWarna"
        txtWarna.Size = New Size(400, 48)
        txtWarna.TabIndex = 14
        ' 
        ' txtBerat
        ' 
        txtBerat.Font = New Font("Microsoft PhagsPa", 12F)
        txtBerat.Location = New Point(247, 531)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(202, 48)
        txtBerat.TabIndex = 15
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Microsoft PhagsPa", 12F)
        btnTambah.Location = New Point(94, 950)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(220, 60)
        btnTambah.TabIndex = 16
        btnTambah.Text = "Tambah"
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Microsoft PhagsPa", 12F)
        btnEdit.Location = New Point(374, 950)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(215, 60)
        btnEdit.TabIndex = 17
        btnEdit.Text = "Edit"
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 12F)
        btnHapus.Location = New Point(644, 950)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(216, 60)
        btnHapus.TabIndex = 18
        btnHapus.Text = "Hapus"
        ' 
        ' dgvHewan
        ' 
        dgvHewan.BackgroundColor = Color.AliceBlue
        dgvHewan.ColumnHeadersHeight = 34
        dgvHewan.Location = New Point(893, 180)
        dgvHewan.Name = "dgvHewan"
        dgvHewan.RowHeadersWidth = 62
        dgvHewan.Size = New Size(978, 830)
        dgvHewan.TabIndex = 19
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(0, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(100, 23)
        lblID.TabIndex = 20
        lblID.Visible = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(94, 180)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(766, 733)
        Panel4.TabIndex = 21
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(cbOwner)
        Panel3.Controls.Add(txtNama)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(cbJenis)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txtRas)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(cbJK)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(txtUmur)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(txtWarna)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtBerat)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(33, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(696, 608)
        Panel3.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Microsoft PhagsPa", 12F)
        Label11.Location = New Point(479, 534)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 48)
        Label11.TabIndex = 17
        Label11.Text = "kg"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Microsoft PhagsPa", 12F)
        Label9.Location = New Point(479, 391)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 48)
        Label9.TabIndex = 16
        Label9.Text = "Bulan"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(33, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(273, 41)
        Label10.TabIndex = 15
        Label10.Text = "Input Data Hewan"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(255, 55)
        Label17.TabIndex = 22
        Label17.Text = "Data Hewan"
        ' 
        ' uc_DataHewan
        ' 
        Controls.Add(Label17)
        Controls.Add(Panel4)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(dgvHewan)
        Controls.Add(lblID)
        Name = "uc_DataHewan"
        Size = New Size(1955, 1182)
        CType(dgvHewan, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

    Friend WithEvents cbOwner As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtRas As TextBox
    Friend WithEvents cbJK As ComboBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtWarna As TextBox
    Friend WithEvents txtBerat As TextBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvHewan As DataGridView

    Friend WithEvents lblID As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label

End Class