<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_StatusKandang
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        dgvKandang = New DataGridView()
        CType(dgvKandang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        Label1.Location = New Point(114, 79)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(560, 78)
        Label1.TabIndex = 0
        Label1.Text = "STATUS KANDANG"
        ' 
        ' dgvKandang
        ' 
        dgvKandang.AllowUserToAddRows = False
        dgvKandang.AllowUserToDeleteRows = False
        dgvKandang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKandang.BackgroundColor = Color.White
        dgvKandang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKandang.Location = New Point(128, 186)
        dgvKandang.Margin = New Padding(5, 6, 5, 6)
        dgvKandang.Name = "dgvKandang"
        dgvKandang.ReadOnly = True
        dgvKandang.RowHeadersWidth = 51
        dgvKandang.RowTemplate.Height = 24
        dgvKandang.Size = New Size(1739, 944)
        dgvKandang.TabIndex = 1
        ' 
        ' uc_StatusKandang
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(dgvKandang)
        Margin = New Padding(5, 6, 5, 6)
        Name = "uc_StatusKandang"
        Size = New Size(1955, 1182)
        CType(dgvKandang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvKandang As DataGridView

End Class