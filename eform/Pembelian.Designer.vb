﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembelian))
        Me.noform = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.notelpon = New System.Windows.Forms.TextBox()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.datainput = New System.Windows.Forms.TextBox()
        Me.finalcheck = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tunai = New System.Windows.Forms.RadioButton()
        Me.mandiri = New System.Windows.Forms.RadioButton()
        Me.bca = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.note = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.amountr = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.o2max3r = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.totalpcs = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.firmax3r = New System.Windows.Forms.NumericUpDown()
        Me.totalset = New System.Windows.Forms.TextBox()
        Me.ordered = New System.Windows.Forms.TextBox()
        Me.proceeded = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.o2max3r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firmax3r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'noform
        '
        Me.noform.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noform.Location = New System.Drawing.Point(492, 66)
        Me.noform.Name = "noform"
        Me.noform.Size = New System.Drawing.Size(253, 22)
        Me.noform.TabIndex = 1
        Me.noform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 42)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Formulir Pembelian"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(177, 3)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(840, 20)
        Me.tanggal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "User ID :"
        '
        'notelpon
        '
        Me.notelpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notelpon.Location = New System.Drawing.Point(177, 81)
        Me.notelpon.Name = "notelpon"
        Me.notelpon.Size = New System.Drawing.Size(840, 22)
        Me.notelpon.TabIndex = 5
        Me.notelpon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userid
        '
        Me.userid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Location = New System.Drawing.Point(177, 29)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(840, 22)
        Me.userid.TabIndex = 3
        Me.userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No. Telpon :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama :"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(177, 55)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(840, 22)
        Me.nama.TabIndex = 4
        Me.nama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.notelpon)
        Me.Panel1.Controls.Add(Me.userid)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.nama)
        Me.Panel1.Location = New System.Drawing.Point(37, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 140)
        Me.Panel1.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(225, 477)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 16)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Ordered By :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(719, 477)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 16)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Proceeded By :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(77, 527)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Nama :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(579, 527)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Nama :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.datainput)
        Me.Panel2.Controls.Add(Me.finalcheck)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.tunai)
        Me.Panel2.Controls.Add(Me.mandiri)
        Me.Panel2.Controls.Add(Me.bca)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.note)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(37, 590)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 92)
        Me.Panel2.TabIndex = 32
        '
        'datainput
        '
        Me.datainput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datainput.Location = New System.Drawing.Point(705, 25)
        Me.datainput.Multiline = True
        Me.datainput.Name = "datainput"
        Me.datainput.Size = New System.Drawing.Size(217, 56)
        Me.datainput.TabIndex = 15
        Me.datainput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'finalcheck
        '
        Me.finalcheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalcheck.Location = New System.Drawing.Point(460, 25)
        Me.finalcheck.Multiline = True
        Me.finalcheck.Name = "finalcheck"
        Me.finalcheck.Size = New System.Drawing.Size(217, 56)
        Me.finalcheck.TabIndex = 14
        Me.finalcheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(784, 6)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 16)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "Data Input"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(515, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 16)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Final Check"
        '
        'tunai
        '
        Me.tunai.AutoSize = True
        Me.tunai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tunai.Location = New System.Drawing.Point(371, 59)
        Me.tunai.Name = "tunai"
        Me.tunai.Size = New System.Drawing.Size(60, 20)
        Me.tunai.TabIndex = 13
        Me.tunai.TabStop = True
        Me.tunai.Text = "Tunai"
        Me.tunai.UseVisualStyleBackColor = True
        '
        'mandiri
        '
        Me.mandiri.AutoSize = True
        Me.mandiri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mandiri.Location = New System.Drawing.Point(236, 59)
        Me.mandiri.Name = "mandiri"
        Me.mandiri.Size = New System.Drawing.Size(123, 20)
        Me.mandiri.TabIndex = 12
        Me.mandiri.TabStop = True
        Me.mandiri.Text = "Transfer Mandiri"
        Me.mandiri.UseVisualStyleBackColor = True
        '
        'bca
        '
        Me.bca.AutoSize = True
        Me.bca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bca.Location = New System.Drawing.Point(124, 59)
        Me.bca.Name = "bca"
        Me.bca.Size = New System.Drawing.Size(106, 20)
        Me.bca.TabIndex = 11
        Me.bca.TabStop = True
        Me.bca.Text = "Transfer BCA"
        Me.bca.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(115, 16)
        Me.Label28.TabIndex = 34
        Me.Label28.Text = "Payment Method :"
        '
        'note
        '
        Me.note.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note.Location = New System.Drawing.Point(127, 25)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(304, 22)
        Me.note.TabIndex = 10
        Me.note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 16)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Note :"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1162, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 97)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Submit"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1162, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 97)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Clear"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1162, 468)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 97)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Print"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(1172, 587)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(77, 72)
        Me.back.TabIndex = 19
        Me.back.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.amountr)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.o2max3r)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.totalpcs)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.firmax3r)
        Me.Panel3.Controls.Add(Me.totalset)
        Me.Panel3.Location = New System.Drawing.Point(37, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1046, 200)
        Me.Panel3.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(174, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Rp."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(975, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 16)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "set"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(975, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "pcs"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "( Rp. 1.000.000 x total set )"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "( R - Wallet )"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(409, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "FIRMAX 3"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(40, 87)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 16)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "TOTAL pcs"
        '
        'amountr
        '
        Me.amountr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountr.Location = New System.Drawing.Point(171, 162)
        Me.amountr.Name = "amountr"
        Me.amountr.ReadOnly = True
        Me.amountr.Size = New System.Drawing.Size(846, 22)
        Me.amountr.TabIndex = 22
        Me.amountr.TabStop = False
        Me.amountr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(40, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 16)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "TOTAL Set"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 16)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Produk"
        '
        'o2max3r
        '
        Me.o2max3r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o2max3r.Location = New System.Drawing.Point(610, 58)
        Me.o2max3r.Name = "o2max3r"
        Me.o2max3r.Size = New System.Drawing.Size(262, 22)
        Me.o2max3r.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(40, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 16)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Amount"
        '
        'totalpcs
        '
        Me.totalpcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpcs.Location = New System.Drawing.Point(171, 86)
        Me.totalpcs.Name = "totalpcs"
        Me.totalpcs.ReadOnly = True
        Me.totalpcs.Size = New System.Drawing.Size(846, 22)
        Me.totalpcs.TabIndex = 20
        Me.totalpcs.TabStop = False
        Me.totalpcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(713, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "O2 MAX3"
        '
        'firmax3r
        '
        Me.firmax3r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firmax3r.Location = New System.Drawing.Point(316, 58)
        Me.firmax3r.Name = "firmax3r"
        Me.firmax3r.Size = New System.Drawing.Size(260, 22)
        Me.firmax3r.TabIndex = 6
        '
        'totalset
        '
        Me.totalset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalset.Location = New System.Drawing.Point(171, 125)
        Me.totalset.Name = "totalset"
        Me.totalset.ReadOnly = True
        Me.totalset.Size = New System.Drawing.Size(846, 22)
        Me.totalset.TabIndex = 21
        Me.totalset.TabStop = False
        Me.totalset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ordered
        '
        Me.ordered.Location = New System.Drawing.Point(176, 527)
        Me.ordered.Name = "ordered"
        Me.ordered.Size = New System.Drawing.Size(172, 20)
        Me.ordered.TabIndex = 8
        Me.ordered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'proceeded
        '
        Me.proceeded.Location = New System.Drawing.Point(686, 527)
        Me.proceeded.Name = "proceeded"
        Me.proceeded.Size = New System.Drawing.Size(172, 20)
        Me.proceeded.TabIndex = 9
        Me.proceeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1100, 664)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(212, 18)
        Me.Label31.TabIndex = 78
        Me.Label31.Text = "BACK TO MEMBER MENU"
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.proceeded)
        Me.Controls.Add(Me.ordered)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.noform)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Pembelian"
        Me.Text = "Pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.o2max3r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firmax3r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents noform As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents notelpon As TextBox
    Friend WithEvents userid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents datainput As TextBox
    Friend WithEvents finalcheck As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents tunai As RadioButton
    Friend WithEvents mandiri As RadioButton
    Friend WithEvents bca As RadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents note As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents back As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents amountr As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents o2max3r As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents totalpcs As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents firmax3r As NumericUpDown
    Friend WithEvents totalset As TextBox
    Friend WithEvents ordered As TextBox
    Friend WithEvents proceeded As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label31 As Label
End Class
