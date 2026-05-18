<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_Tarif
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
        Panel5 = New Panel()
        Panel7 = New Panel()
        Label9 = New Label()
        txtInfoPerawatan = New TextBox()
        Label10 = New Label()
        txtHargaPerawatan = New TextBox()
        btnUpdatePerawatan = New Button()
        Panel6 = New Panel()
        dgvPerawatan = New DataGridView()
        Label8 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Label6 = New Label()
        txtInfoKandang = New TextBox()
        Label7 = New Label()
        txtHargaKandang = New TextBox()
        btnUpdateKandang = New Button()
        Panel3 = New Panel()
        dgvKandang = New DataGridView()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        CType(dgvPerawatan, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvKandang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1955, 1182)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(btnUpdatePerawatan)
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(994, 99)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(930, 1030)
        Panel5.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.AliceBlue
        Panel7.Controls.Add(Label9)
        Panel7.Controls.Add(txtInfoPerawatan)
        Panel7.Controls.Add(Label10)
        Panel7.Controls.Add(txtHargaPerawatan)
        Panel7.Location = New Point(32, 690)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(860, 200)
        Panel7.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlText
        Label9.Location = New Point(29, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(252, 37)
        Label9.TabIndex = 0
        Label9.Text = "Perawatan Terpilih"
        ' 
        ' txtInfoPerawatan
        ' 
        txtInfoPerawatan.BackColor = Color.White
        txtInfoPerawatan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInfoPerawatan.Location = New Point(309, 24)
        txtInfoPerawatan.Name = "txtInfoPerawatan"
        txtInfoPerawatan.ReadOnly = True
        txtInfoPerawatan.Size = New Size(310, 45)
        txtInfoPerawatan.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(29, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(221, 37)
        Label10.TabIndex = 2
        Label10.Text = "Harga Baru (Rp)"
        ' 
        ' txtHargaPerawatan
        ' 
        txtHargaPerawatan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHargaPerawatan.Location = New Point(309, 106)
        txtHargaPerawatan.Name = "txtHargaPerawatan"
        txtHargaPerawatan.Size = New Size(310, 45)
        txtHargaPerawatan.TabIndex = 3
        ' 
        ' btnUpdatePerawatan
        ' 
        btnUpdatePerawatan.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdatePerawatan.Location = New Point(32, 915)
        btnUpdatePerawatan.Name = "btnUpdatePerawatan"
        btnUpdatePerawatan.Size = New Size(280, 54)
        btnUpdatePerawatan.TabIndex = 18
        btnUpdatePerawatan.Text = "Update Tarif Perawatan"
        btnUpdatePerawatan.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(dgvPerawatan)
        Panel6.Controls.Add(Label8)
        Panel6.Location = New Point(32, 83)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(860, 579)
        Panel6.TabIndex = 16
        ' 
        ' dgvPerawatan
        ' 
        dgvPerawatan.BackgroundColor = Color.White
        dgvPerawatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPerawatan.Location = New Point(20, 61)
        dgvPerawatan.Name = "dgvPerawatan"
        dgvPerawatan.RowHeadersWidth = 82
        dgvPerawatan.Size = New Size(821, 499)
        dgvPerawatan.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(20, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(368, 37)
        Label8.TabIndex = 0
        Label8.Text = "Klik baris untuk update tarif"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(32, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(235, 41)
        Label4.TabIndex = 15
        Label4.Text = "Tarif Perawatan"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(btnUpdateKandang)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(29, 99)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(930, 1030)
        Panel2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.AliceBlue
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(txtInfoKandang)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(txtHargaKandang)
        Panel4.Location = New Point(32, 690)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(860, 200)
        Panel4.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(29, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(232, 37)
        Label6.TabIndex = 0
        Label6.Text = "Kandang Terpilih"
        ' 
        ' txtInfoKandang
        ' 
        txtInfoKandang.BackColor = Color.White
        txtInfoKandang.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInfoKandang.Location = New Point(280, 32)
        txtInfoKandang.Name = "txtInfoKandang"
        txtInfoKandang.ReadOnly = True
        txtInfoKandang.Size = New Size(310, 45)
        txtInfoKandang.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(29, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(221, 37)
        Label7.TabIndex = 2
        Label7.Text = "Harga Baru (Rp)"
        ' 
        ' txtHargaKandang
        ' 
        txtHargaKandang.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHargaKandang.Location = New Point(280, 106)
        txtHargaKandang.Name = "txtHargaKandang"
        txtHargaKandang.Size = New Size(310, 45)
        txtHargaKandang.TabIndex = 3
        ' 
        ' btnUpdateKandang
        ' 
        btnUpdateKandang.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateKandang.Location = New Point(32, 915)
        btnUpdateKandang.Name = "btnUpdateKandang"
        btnUpdateKandang.Size = New Size(260, 54)
        btnUpdateKandang.TabIndex = 18
        btnUpdateKandang.Text = "Update Tarif Kandang"
        btnUpdateKandang.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(dgvKandang)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(32, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(860, 579)
        Panel3.TabIndex = 16
        ' 
        ' dgvKandang
        ' 
        dgvKandang.BackgroundColor = Color.White
        dgvKandang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKandang.Location = New Point(20, 61)
        dgvKandang.Name = "dgvKandang"
        dgvKandang.RowHeadersWidth = 82
        dgvKandang.Size = New Size(821, 499)
        dgvKandang.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(20, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(368, 37)
        Label3.TabIndex = 0
        Label3.Text = "Klik baris untuk update tarif"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(32, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 41)
        Label2.TabIndex = 15
        Label2.Text = "Tarif Kandang"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(62, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 55)
        Label1.TabIndex = 20
        Label1.Text = "Pengaturan Tarif"
        ' 
        ' uc_Tarif
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "uc_Tarif"
        Size = New Size(1955, 1182)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(dgvPerawatan, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvKandang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvKandang As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInfoKandang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHargaKandang As TextBox
    Friend WithEvents btnUpdateKandang As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvPerawatan As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtInfoPerawatan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHargaPerawatan As TextBox
    Friend WithEvents btnUpdatePerawatan As Button

End Class