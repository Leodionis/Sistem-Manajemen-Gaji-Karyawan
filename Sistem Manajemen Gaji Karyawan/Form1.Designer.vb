<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        cmbbenefit = New ComboBox()
        cmbposisi = New ComboBox()
        txtgajipokok = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Label8 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-4, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(950, 150)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(103, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(758, 47)
        Label1.TabIndex = 0
        Label1.Text = "SISTEM MANAJEMEN GAJI KARYAWAN "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(CheckBox6)
        GroupBox1.Controls.Add(CheckBox5)
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(cmbbenefit)
        GroupBox1.Controls.Add(cmbposisi)
        GroupBox1.Controls.Add(txtgajipokok)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonFace
        GroupBox1.Location = New Point(12, 169)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(544, 395)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detail Karyawan"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox6.Location = New Point(396, 332)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(149, 25)
        CheckBox6.TabIndex = 13
        CheckBox6.Text = "keperluan 12%"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox5.Location = New Point(396, 268)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(133, 25)
        CheckBox5.TabIndex = 12
        CheckBox5.Text = "transport 9%"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox4.Location = New Point(229, 332)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(156, 25)
        CheckBox4.TabIndex = 11
        CheckBox4.Text = "benefit lainnya "
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(229, 268)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(157, 25)
        CheckBox3.TabIndex = 10
        CheckBox3.Text = "kendaraan 8.5%"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(20, 332)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(177, 25)
        CheckBox2.TabIndex = 9
        CheckBox2.Text = "manfaat medis 7%"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(20, 268)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(205, 25)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "tunjangan rumah 35%"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' cmbbenefit
        ' 
        cmbbenefit.FormattingEnabled = True
        cmbbenefit.Items.AddRange(New Object() {"Bonus Tahun Baru ", "Bonus Hari Raya ", "Bonus Lembur "})
        cmbbenefit.Location = New Point(203, 198)
        cmbbenefit.Name = "cmbbenefit"
        cmbbenefit.Size = New Size(267, 33)
        cmbbenefit.TabIndex = 7
        ' 
        ' cmbposisi
        ' 
        cmbposisi.FormattingEnabled = True
        cmbposisi.Items.AddRange(New Object() {"Project Manager ", "IT Programer ", "Sales Marketing ", "Customer Service ", "Security "})
        cmbposisi.Location = New Point(203, 110)
        cmbposisi.Name = "cmbposisi"
        cmbposisi.Size = New Size(267, 33)
        cmbposisi.TabIndex = 6
        ' 
        ' txtgajipokok
        ' 
        txtgajipokok.Location = New Point(203, 156)
        txtgajipokok.Name = "txtgajipokok"
        txtgajipokok.Size = New Size(267, 31)
        txtgajipokok.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(203, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(267, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 25)
        Label5.TabIndex = 3
        Label5.Text = "Benefit "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 25)
        Label4.TabIndex = 2
        Label4.Text = "Gaji Pokok"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 1
        Label3.Text = "Posisi Karyawan "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 25)
        Label2.TabIndex = 0
        Label2.Text = "Nama Karyawan "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(582, 186)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(352, 355)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 579)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 30)
        Label6.TabIndex = 4
        Label6.Text = "Gaji Kotor "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 633)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 30)
        Label7.TabIndex = 5
        Label7.Text = "Gaji Bersih "
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Menu
        TextBox3.Location = New Point(141, 579)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(267, 31)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Menu
        TextBox4.Location = New Point(141, 633)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(267, 31)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Font = New Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(652, 579)
        Button1.Margin = New Padding(50)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 64)
        Button1.TabIndex = 8
        Button1.Text = "TOTAL"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 677)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 30)
        Label8.TabIndex = 9
        Label8.Text = "Pajak "
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Menu
        TextBox2.Location = New Point(141, 677)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(267, 31)
        TextBox2.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkRed
        Button2.Font = New Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(652, 658)
        Button2.Margin = New Padding(50)
        Button2.Name = "Button2"
        Button2.Size = New Size(190, 65)
        Button2.TabIndex = 11
        Button2.Text = "HAPUS "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(946, 735)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Sistem Manajemen Gaji Karyawan "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbbenefit As ComboBox
    Friend WithEvents cmbposisi As ComboBox
    Friend WithEvents txtgajipokok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button

End Class
