<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userControlBooking
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel9 = New Panel()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Panel10 = New Panel()
        Label2 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel8 = New Panel()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Panel7 = New Panel()
        Panel2 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        ComboBox3 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        ComboBox2 = New ComboBox()
        Label18 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label16 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        Label17 = New Label()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel8.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel5)
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
        Panel9.Controls.Add(TextBox1)
        Panel9.Location = New Point(266, 880)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(562, 93)
        Panel9.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(46, 28)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(479, 45)
        TextBox1.TabIndex = 16
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(664, 1006)
        Button4.Name = "Button4"
        Button4.Size = New Size(164, 55)
        Button4.TabIndex = 25
        Button4.Text = "Cari"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.AliceBlue
        Panel10.Controls.Add(Label2)
        Panel10.Location = New Point(62, 880)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(214, 93)
        Panel10.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(30, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 41)
        Label2.TabIndex = 15
        Label2.Text = "Cari Data"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(455, 1006)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 55)
        Button3.TabIndex = 24
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(259, 1006)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 55)
        Button2.TabIndex = 23
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(62, 1006)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 55)
        Button1.TabIndex = 22
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(DataGridView1)
        Panel8.Controls.Add(Label1)
        Panel8.Location = New Point(896, 426)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(966, 635)
        Panel8.TabIndex = 21
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.AliceBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.ColumnHeadersVisible = False
        DataGridView1.Location = New Point(33, 83)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(896, 519)
        DataGridView1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(33, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 41)
        Label1.TabIndex = 15
        Label1.Text = "Data Booking"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Panel2)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(896, 166)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(966, 221)
        Panel7.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AliceBlue
        Panel2.Controls.Add(RichTextBox1)
        Panel2.Location = New Point(33, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(896, 116)
        Panel2.TabIndex = 16
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(21, 17)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(858, 84)
        RichTextBox1.TabIndex = 21
        RichTextBox1.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(33, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 41)
        Label5.TabIndex = 15
        Label5.Text = "Catatan"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label18)
        Panel5.Location = New Point(62, 426)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(766, 417)
        Panel5.TabIndex = 19
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(ComboBox3)
        Panel6.Controls.Add(DateTimePicker2)
        Panel6.Controls.Add(DateTimePicker1)
        Panel6.Controls.Add(Label24)
        Panel6.Controls.Add(Label23)
        Panel6.Controls.Add(Label22)
        Panel6.Controls.Add(Label21)
        Panel6.Controls.Add(ComboBox2)
        Panel6.Location = New Point(33, 83)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(696, 312)
        Panel6.TabIndex = 16
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Booking", "Check In", "Check Out", "Batal"})
        ComboBox3.Location = New Point(337, 237)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(310, 45)
        ComboBox3.TabIndex = 23
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Location = New Point(337, 170)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(310, 45)
        DateTimePicker2.TabIndex = 22
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(337, 101)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(310, 45)
        DateTimePicker1.TabIndex = 21
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = SystemColors.ControlText
        Label24.Location = New Point(47, 237)
        Label24.Name = "Label24"
        Label24.Size = New Size(95, 37)
        Label24.TabIndex = 20
        Label24.Text = "Status"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlText
        Label23.Location = New Point(47, 176)
        Label23.Name = "Label23"
        Label23.Size = New Size(149, 37)
        Label23.TabIndex = 19
        Label23.Text = "Check Out"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlText
        Label22.Location = New Point(47, 107)
        Label22.Name = "Label22"
        Label22.Size = New Size(125, 37)
        Label22.TabIndex = 18
        Label22.Text = "Check In"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlText
        Label21.Location = New Point(47, 36)
        Label21.Name = "Label21"
        Label21.Size = New Size(130, 37)
        Label21.TabIndex = 17
        Label21.Text = "Kandang"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(337, 36)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(310, 45)
        ComboBox2.TabIndex = 1
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.ControlText
        Label18.Location = New Point(33, 22)
        Label18.Name = "Label18"
        Label18.Size = New Size(226, 41)
        Label18.TabIndex = 15
        Label18.Text = "Detail Booking"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(62, 166)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(766, 221)
        Panel4.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Location = New Point(33, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(696, 112)
        Panel3.TabIndex = 16
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ControlText
        Label16.Location = New Point(47, 39)
        Label16.Name = "Label16"
        Label16.Size = New Size(190, 37)
        Label16.TabIndex = 17
        Label16.Text = "Nama Hewan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft PhagsPa", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(337, 39)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(310, 45)
        ComboBox1.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(33, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 41)
        Label10.TabIndex = 15
        Label10.Text = "Pilih Hewan"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft PhagsPa", 16.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(62, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(289, 55)
        Label17.TabIndex = 20
        Label17.Text = "Form Booking"
        ' 
        ' userControlBooking
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "userControlBooking"
        Size = New Size(1955, 1182)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label2 As Label

End Class
