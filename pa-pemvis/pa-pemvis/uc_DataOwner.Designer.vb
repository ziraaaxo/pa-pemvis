<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_DataOwner
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtNoHP = New TextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvOwner = New DataGridView()
        Panel1 = New Panel()
        Label17 = New Label()
        txtID = New TextBox()
        CType(dgvOwner, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(63, 47)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 41)
        Label1.TabIndex = 0
        Label1.Text = "Nama Owner"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(63, 139)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 41)
        Label2.TabIndex = 1
        Label2.Text = "No HP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(63, 223)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 41)
        Label3.TabIndex = 2
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(63, 379)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 41)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(453, 47)
        txtNama.Margin = New Padding(5, 6, 5, 6)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(810, 48)
        txtNama.TabIndex = 4
        ' 
        ' txtNoHP
        ' 
        txtNoHP.Font = New Font("Microsoft PhagsPa", 12F)
        txtNoHP.Location = New Point(453, 139)
        txtNoHP.Margin = New Padding(5, 6, 5, 6)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.Size = New Size(810, 48)
        txtNoHP.TabIndex = 5
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Microsoft PhagsPa", 12F)
        txtAlamat.Location = New Point(453, 223)
        txtAlamat.Margin = New Padding(5, 6, 5, 6)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(810, 122)
        txtAlamat.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Microsoft PhagsPa", 12F)
        txtEmail.Location = New Point(453, 379)
        txtEmail.Margin = New Padding(5, 6, 5, 6)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(810, 48)
        txtEmail.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Microsoft PhagsPa", 12F)
        btnTambah.Location = New Point(1447, 101)
        btnTambah.Margin = New Padding(5, 6, 5, 6)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(180, 60)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Microsoft PhagsPa", 12F)
        btnEdit.Location = New Point(1447, 213)
        btnEdit.Margin = New Padding(5, 6, 5, 6)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(180, 60)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 12F)
        btnHapus.Location = New Point(1447, 325)
        btnHapus.Margin = New Padding(5, 6, 5, 6)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(180, 60)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvOwner
        ' 
        dgvOwner.BackgroundColor = Color.AliceBlue
        dgvOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOwner.Location = New Point(109, 612)
        dgvOwner.Margin = New Padding(5, 6, 5, 6)
        dgvOwner.Name = "dgvOwner"
        dgvOwner.RowHeadersWidth = 51
        dgvOwner.RowTemplate.Height = 24
        dgvOwner.Size = New Size(1726, 478)
        dgvOwner.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtAlamat)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(txtNoHP)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtID)
        Panel1.Location = New Point(62, 146)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1816, 988)
        Panel1.TabIndex = 12
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(249, 55)
        Label17.TabIndex = 21
        Label17.Text = "Data Owner"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(1447, 550)
        txtID.Name = "txtID"
        txtID.Size = New Size(10, 39)
        txtID.TabIndex = 11
        txtID.Visible = False
        ' 
        ' uc_DataOwner
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label17)
        Controls.Add(dgvOwner)
        Controls.Add(Panel1)
        Margin = New Padding(5, 6, 5, 6)
        Name = "uc_DataOwner"
        Size = New Size(1955, 1182)
        CType(dgvOwner, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvOwner As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents txtID As TextBox

End Class