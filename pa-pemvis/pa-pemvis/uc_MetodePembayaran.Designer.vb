<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_MetodePembayaran
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
        Panel6 = New Panel()
        txtCari = New TextBox()
        btnCari = New Button()
        Panel5 = New Panel()
        Label2 = New Label()
        btnHapus = New Button()
        btnUpdate = New Button()
        btnSimpan = New Button()
        Panel4 = New Panel()
        dgvMetode = New DataGridView()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        txtNama = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvMetode, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(btnCari)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1955, 1182)
        Panel1.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(txtCari)
        Panel6.Location = New Point(266, 976)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(562, 93)
        Panel6.TabIndex = 21
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCari.Location = New Point(46, 29)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(478, 45)
        txtCari.TabIndex = 16
        ' 
        ' btnCari
        ' 
        btnCari.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCari.Location = New Point(1679, 992)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(164, 62)
        btnCari.TabIndex = 25
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.AliceBlue
        Panel5.Controls.Add(Label2)
        Panel5.Location = New Point(62, 976)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(214, 93)
        Panel5.TabIndex = 17
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
        btnHapus.Location = New Point(1454, 992)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(180, 62)
        btnHapus.TabIndex = 24
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(1232, 992)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(172, 62)
        btnUpdate.TabIndex = 23
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(968, 992)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(176, 62)
        btnSimpan.TabIndex = 22
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(dgvMetode)
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(895, 166)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(999, 733)
        Panel4.TabIndex = 21
        ' 
        ' dgvMetode
        ' 
        dgvMetode.BackgroundColor = Color.AliceBlue
        dgvMetode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMetode.Location = New Point(32, 83)
        dgvMetode.Name = "dgvMetode"
        dgvMetode.RowHeadersWidth = 82
        dgvMetode.Size = New Size(895, 614)
        dgvMetode.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(32, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(387, 41)
        Label1.TabIndex = 15
        Label1.Text = "Data Metode Pembayaran"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(62, 166)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(765, 733)
        Panel2.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtNama)
        Panel3.Location = New Point(32, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(696, 614)
        Panel3.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images_removebg_preview
        PictureBox1.Location = New Point(0, 235)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(696, 379)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(32, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(202, 37)
        Label4.TabIndex = 17
        Label4.Text = "Nama Metode"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(330, 106)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(310, 45)
        txtNama.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(32, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(397, 41)
        Label3.TabIndex = 15
        Label3.Text = "Input Metode Pembayaran"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(62, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(528, 55)
        Label5.TabIndex = 20
        Label5.Text = "Form Metode Pembayaran"
        ' 
        ' uc_MetodePembayaran
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "uc_MetodePembayaran"
        Size = New Size(1955, 1182)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvMetode, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvMetode As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class