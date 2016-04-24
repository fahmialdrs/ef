<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(finance))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DatabaseDataSet1 = New eform.databaseDataSet1()
        Me.AkuntingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AkuntingTableAdapter = New eform.databaseDataSet1TableAdapters.akuntingTableAdapter()
        Me.TableAdapterManager = New eform.databaseDataSet1TableAdapters.TableAdapterManager()
        Me.NoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdFirmax3TDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdO2max3TDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALpcsTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALSetTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaluangmskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProceedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AkuntingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip.TabIndex = 63
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupDatabaseToolStripMenuItem})
        Me.SettingToolStripMenuItem.Image = CType(resources.GetObject("SettingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Image = CType(resources.GetObject("BackupDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.LoginToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(357, 596)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(179, 18)
        Me.Label31.TabIndex = 68
        Me.Label31.Text = "BACK TO MAIN MENU"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(409, 536)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(67, 57)
        Me.back.TabIndex = 67
        Me.back.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(620, 537)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 55)
        Me.Button2.TabIndex = 65
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(833, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 56)
        Me.Button1.TabIndex = 64
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 595)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Delete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(843, 595)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Print"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.NoTelpDataGridViewTextBoxColumn, Me.ProdFirmax3TDataGridViewTextBoxColumn, Me.ProdO2max3TDataGridViewTextBoxColumn, Me.TOTALpcsTDataGridViewTextBoxColumn, Me.TOTALSetTDataGridViewTextBoxColumn, Me.AmountTDataGridViewTextBoxColumn, Me.TotaluangmskDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.OrderedByDataGridViewTextBoxColumn, Me.ProceedByDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AkuntingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 240)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1138, 290)
        Me.DataGridView1.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(509, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 29)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "LAPORAN AKUNTING"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(191, 678)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(897, 19)
        Me.TextBox2.TabIndex = 74
        Me.TextBox2.Text = "Gedung Gajah Unit AP - Jl. Dr. Sahardjo No.111, Tebet Barat, Tebet 12810 Jakarta " &
    "Selatan Telp. 021-8310351"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(463, 641)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(353, 31)
        Me.TextBox1.TabIndex = 73
        Me.TextBox1.Text = "PT. RF3 WORLD INDONESIA "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(522, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "databaseDataSet1"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AkuntingBindingSource
        '
        Me.AkuntingBindingSource.DataMember = "akunting"
        Me.AkuntingBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'AkuntingTableAdapter
        '
        Me.AkuntingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.akuntingTableAdapter = Me.AkuntingTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Form_Claim_Maintain__Mobile_Stockist_TableAdapter = Nothing
        Me.TableAdapterManager.Form_Pembalian_MaintainTableAdapter = Nothing
        Me.TableAdapterManager.Form_Pembelian__Mobile_Stockist_TableAdapter = Nothing
        Me.TableAdapterManager.Form_Pembelian_baruTableAdapter = Nothing
        Me.TableAdapterManager.Form_Pembelian_LamaTableAdapter = Nothing
        Me.TableAdapterManager.Form_RegisterTableAdapter = Nothing
        Me.TableAdapterManager.gudangTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = eform.databaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NoDataGridViewTextBoxColumn
        '
        Me.NoDataGridViewTextBoxColumn.DataPropertyName = "No"
        Me.NoDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoDataGridViewTextBoxColumn.Name = "NoDataGridViewTextBoxColumn"
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'NoTelpDataGridViewTextBoxColumn
        '
        Me.NoTelpDataGridViewTextBoxColumn.DataPropertyName = "No_Telp"
        Me.NoTelpDataGridViewTextBoxColumn.HeaderText = "No_Telp"
        Me.NoTelpDataGridViewTextBoxColumn.Name = "NoTelpDataGridViewTextBoxColumn"
        '
        'ProdFirmax3TDataGridViewTextBoxColumn
        '
        Me.ProdFirmax3TDataGridViewTextBoxColumn.DataPropertyName = "Prod firmax3-T"
        Me.ProdFirmax3TDataGridViewTextBoxColumn.HeaderText = "Prod firmax3-T"
        Me.ProdFirmax3TDataGridViewTextBoxColumn.Name = "ProdFirmax3TDataGridViewTextBoxColumn"
        '
        'ProdO2max3TDataGridViewTextBoxColumn
        '
        Me.ProdO2max3TDataGridViewTextBoxColumn.DataPropertyName = "Prod_O2max3-T"
        Me.ProdO2max3TDataGridViewTextBoxColumn.HeaderText = "Prod_O2max3-T"
        Me.ProdO2max3TDataGridViewTextBoxColumn.Name = "ProdO2max3TDataGridViewTextBoxColumn"
        '
        'TOTALpcsTDataGridViewTextBoxColumn
        '
        Me.TOTALpcsTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_pcs-T"
        Me.TOTALpcsTDataGridViewTextBoxColumn.HeaderText = "TOTAL_pcs-T"
        Me.TOTALpcsTDataGridViewTextBoxColumn.Name = "TOTALpcsTDataGridViewTextBoxColumn"
        '
        'TOTALSetTDataGridViewTextBoxColumn
        '
        Me.TOTALSetTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_Set-T"
        Me.TOTALSetTDataGridViewTextBoxColumn.HeaderText = "TOTAL_Set-T"
        Me.TOTALSetTDataGridViewTextBoxColumn.Name = "TOTALSetTDataGridViewTextBoxColumn"
        '
        'AmountTDataGridViewTextBoxColumn
        '
        Me.AmountTDataGridViewTextBoxColumn.DataPropertyName = "Amount-T"
        Me.AmountTDataGridViewTextBoxColumn.HeaderText = "Amount-T"
        Me.AmountTDataGridViewTextBoxColumn.Name = "AmountTDataGridViewTextBoxColumn"
        '
        'TotaluangmskDataGridViewTextBoxColumn
        '
        Me.TotaluangmskDataGridViewTextBoxColumn.DataPropertyName = "Total-uang-msk"
        Me.TotaluangmskDataGridViewTextBoxColumn.HeaderText = "Total-uang-msk"
        Me.TotaluangmskDataGridViewTextBoxColumn.Name = "TotaluangmskDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'OrderedByDataGridViewTextBoxColumn
        '
        Me.OrderedByDataGridViewTextBoxColumn.DataPropertyName = "Ordered_By"
        Me.OrderedByDataGridViewTextBoxColumn.HeaderText = "Ordered_By"
        Me.OrderedByDataGridViewTextBoxColumn.Name = "OrderedByDataGridViewTextBoxColumn"
        '
        'ProceedByDataGridViewTextBoxColumn
        '
        Me.ProceedByDataGridViewTextBoxColumn.DataPropertyName = "Proceed_By"
        Me.ProceedByDataGridViewTextBoxColumn.HeaderText = "Proceed_By"
        Me.ProceedByDataGridViewTextBoxColumn.Name = "ProceedByDataGridViewTextBoxColumn"
        '
        'finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "finance"
        Me.Text = "finance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AkuntingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label31 As Label
    Friend WithEvents back As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DatabaseDataSet1 As databaseDataSet1
    Friend WithEvents AkuntingBindingSource As BindingSource
    Friend WithEvents AkuntingTableAdapter As databaseDataSet1TableAdapters.akuntingTableAdapter
    Friend WithEvents TableAdapterManager As databaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents NoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoTelpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdFirmax3TDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdO2max3TDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALpcsTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALSetTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotaluangmskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProceedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
