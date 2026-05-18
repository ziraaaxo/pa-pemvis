<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_Kandang
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
        dgvKandang = New DataGridView()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        txtNomor = New TextBox()
        Label4 = New Label()
        cbTipe = New ComboBox()
        Label5 = New Label()
        txtHarga = New TextBox()
        Label6 = New Label()
        cbStatus = New ComboBox()
        Label10 = New Label()
        Label17 = New Label()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel8.SuspendLayout()
        CType(dgvKandang, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel9.Location = New Point(266, 978)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(562, 93)
        Panel9.TabIndex = 22
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCari.Location = New Point(46, 24)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(478, 45)
        txtCari.TabIndex = 5
        ' 
        ' btnCari
        ' 
        btnCari.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCari.Location = New Point(1696, 979)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(164, 96)
        btnCari.TabIndex = 25
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.AliceBlue
        Panel10.Controls.Add(Label2)
        Panel10.Location = New Point(62, 978)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(214, 93)
        Panel10.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(29, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 41)
        Label2.TabIndex = 15
        Label2.Text = "Cari Data"
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(1459, 979)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(187, 96)
        btnHapus.TabIndex = 24
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(1220, 979)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(171, 96)
        btnUpdate.TabIndex = 23
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(973, 979)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(176, 96)
        btnSimpan.TabIndex = 22
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(dgvKandang)
        Panel8.Controls.Add(Label1)
        Panel8.Location = New Point(895, 166)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(965, 701)
        Panel8.TabIndex = 21
        ' 
        ' dgvKandang
        ' 
        dgvKandang.AllowUserToAddRows = False
        dgvKandang.AllowUserToDeleteRows = False
        dgvKandang.BackgroundColor = Color.AliceBlue
        dgvKandang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKandang.Location = New Point(32, 83)
        dgvKandang.MultiSelect = False
        dgvKandang.Name = "dgvKandang"
        dgvKandang.ReadOnly = True
        dgvKandang.RowHeadersWidth = 82
        dgvKandang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKandang.Size = New Size(895, 590)
        dgvKandang.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(32, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 41)
        Label1.TabIndex = 15
        Label1.Text = "Data Kandang"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(62, 166)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(767, 701)
        Panel4.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(txtNomor)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(cbTipe)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txtHarga)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(cbStatus)
        Panel3.Location = New Point(32, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(679, 590)
        Panel3.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(47, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 37)
        Label3.TabIndex = 17
        Label3.Text = "Nomor Kandang"
        ' 
        ' txtNomor
        ' 
        txtNomor.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNomor.Location = New Point(336, 70)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(310, 45)
        txtNomor.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(47, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(192, 37)
        Label4.TabIndex = 18
        Label4.Text = "Tipe Kandang"
        ' 
        ' cbTipe
        ' 
        cbTipe.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbTipe.FormattingEnabled = True
        cbTipe.Items.AddRange(New Object() {"Kecil", "Sedang", "Besar"})
        cbTipe.Location = New Point(336, 214)
        cbTipe.Name = "cbTipe"
        cbTipe.Size = New Size(310, 45)
        cbTipe.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(34, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 37)
        Label5.TabIndex = 19
        Label5.Text = "Harga Per Hari"
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHarga.Location = New Point(336, 346)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(310, 45)
        txtHarga.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(36, 483)
        Label6.Name = "Label6"
        Label6.Size = New Size(216, 37)
        Label6.TabIndex = 20
        Label6.Text = "Status Kandang"
        ' 
        ' cbStatus
        ' 
        cbStatus.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Kosong", "Terisi"})
        cbStatus.Location = New Point(336, 478)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(310, 45)
        cbStatus.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(32, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(310, 41)
        Label10.TabIndex = 15
        Label10.Text = "Form Input Kandang"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 67)
        Label17.Name = "Label17"
        Label17.Size = New Size(402, 55)
        Label17.TabIndex = 20
        Label17.Text = "Form Data Kandang"
        ' 
        ' uc_Kandang
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "uc_Kandang"
        Size = New Size(1955, 1182)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(dgvKandang, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTipe As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dgvKandang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents Label17 As Label

End Class