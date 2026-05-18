<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataUser
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cbRole = New ComboBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvUser = New DataGridView()
        lblID = New Label()
        Panel1 = New Panel()
        Label17 = New Label()
        CType(dgvUser, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 41)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(60, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 41)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(60, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 41)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(60, 352)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 41)
        Label4.TabIndex = 3
        Label4.Text = "Role"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(300, 45)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(500, 48)
        txtNama.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(300, 145)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(500, 48)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(300, 245)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(500, 48)
        txtPassword.TabIndex = 6
        ' 
        ' cbRole
        ' 
        cbRole.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbRole.Items.AddRange(New Object() {"admin", "staff"})
        cbRole.Location = New Point(300, 344)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(500, 49)
        cbRole.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(980, 78)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(180, 60)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(980, 194)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(180, 60)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(980, 314)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(180, 60)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        ' 
        ' dgvUser
        ' 
        dgvUser.BackgroundColor = Color.AliceBlue
        dgvUser.ColumnHeadersHeight = 34
        dgvUser.Location = New Point(122, 604)
        dgvUser.Name = "dgvUser"
        dgvUser.RowHeadersWidth = 62
        dgvUser.Size = New Size(1726, 500)
        dgvUser.TabIndex = 11
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(0, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(100, 23)
        lblID.TabIndex = 12
        lblID.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cbRole)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUsername)
        Panel1.Location = New Point(62, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1842, 1006)
        Panel1.TabIndex = 13
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(210, 55)
        Label17.TabIndex = 21
        Label17.Text = "Data User"
        ' 
        ' uc_DataUser
        ' 
        Controls.Add(Label17)
        Controls.Add(dgvUser)
        Controls.Add(lblID)
        Controls.Add(Panel1)
        Name = "uc_DataUser"
        Size = New Size(1955, 1182)
        CType(dgvUser, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox

    Friend WithEvents cbRole As ComboBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvUser As DataGridView

    Friend WithEvents lblID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label

End Class