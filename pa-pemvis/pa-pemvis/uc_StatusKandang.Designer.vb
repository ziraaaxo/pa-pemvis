<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_StatusKandang
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvKandang = New DataGridView()
        Label17 = New Label()
        Panel1 = New Panel()
        CType(dgvKandang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvKandang
        ' 
        dgvKandang.AllowUserToAddRows = False
        dgvKandang.AllowUserToDeleteRows = False
        dgvKandang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKandang.BackgroundColor = Color.White
        dgvKandang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKandang.Location = New Point(122, 186)
        dgvKandang.Margin = New Padding(5, 6, 5, 6)
        dgvKandang.Name = "dgvKandang"
        dgvKandang.ReadOnly = True
        dgvKandang.RowHeadersWidth = 51
        dgvKandang.RowTemplate.Height = 24
        dgvKandang.Size = New Size(1699, 878)
        dgvKandang.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(320, 55)
        Label17.TabIndex = 22
        Label17.Text = "Status Kandang"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Location = New Point(96, 155)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1749, 938)
        Panel1.TabIndex = 23
        ' 
        ' uc_StatusKandang
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label17)
        Controls.Add(dgvKandang)
        Controls.Add(Panel1)
        Margin = New Padding(5, 6, 5, 6)
        Name = "uc_StatusKandang"
        Size = New Size(1955, 1182)
        CType(dgvKandang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents dgvKandang As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel

End Class