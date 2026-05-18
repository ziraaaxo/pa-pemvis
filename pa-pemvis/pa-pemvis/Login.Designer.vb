<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel2 = New Panel()
        btnClose = New Button()
        Btnlogin = New Button()
        Label2 = New Label()
        TxtPw = New TextBox()
        Label1 = New Label()
        txtUsername = New TextBox()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(975, 240)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.kaki_anjing_removebg_preview
        PictureBox1.Location = New Point(587, 70)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(254, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft PhagsPa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(244, 96)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(304, 70)
        Label3.TabIndex = 4
        Label3.Text = "PET HOTEL"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AliceBlue
        Panel2.Controls.Add(btnClose)
        Panel2.Controls.Add(Btnlogin)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TxtPw)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtUsername)
        Panel2.Location = New Point(0, 240)
        Panel2.Margin = New Padding(5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(975, 602)
        Panel2.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.White
        btnClose.Font = New Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(244, 319)
        btnClose.Margin = New Padding(5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(236, 64)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Btnlogin
        ' 
        Btnlogin.BackColor = Color.LightSkyBlue
        Btnlogin.Font = New Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnlogin.Location = New Point(504, 319)
        Btnlogin.Margin = New Padding(5)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(228, 63)
        Btnlogin.TabIndex = 2
        Btnlogin.Text = "Login"
        Btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 10.2F)
        Label2.Location = New Point(244, 200)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 36)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TxtPw
        ' 
        TxtPw.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPw.Location = New Point(244, 248)
        TxtPw.Margin = New Padding(5)
        TxtPw.MaxLength = 10
        TxtPw.Name = "TxtPw"
        TxtPw.PasswordChar = "."c
        TxtPw.Size = New Size(485, 42)
        TxtPw.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 10.2F)
        Label1.Location = New Point(244, 72)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 36)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.HighlightText
        txtUsername.Font = New Font("Microsoft PhagsPa", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(244, 120)
        txtUsername.Margin = New Padding(5)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(485, 42)
        txtUsername.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(975, 800)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btnlogin As Button
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As Button
End Class