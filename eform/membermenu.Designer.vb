﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class membermenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(membermenu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mobilemember = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pembelianmember = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.claimmember = New System.Windows.Forms.Button()
        Me.maintainmember = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(794, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "FORM PEMBELIAN"
        '
        'mobilemember
        '
        Me.mobilemember.BackColor = System.Drawing.SystemColors.Window
        Me.mobilemember.BackgroundImage = CType(resources.GetObject("mobilemember.BackgroundImage"), System.Drawing.Image)
        Me.mobilemember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mobilemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mobilemember.Image = CType(resources.GetObject("mobilemember.Image"), System.Drawing.Image)
        Me.mobilemember.Location = New System.Drawing.Point(824, 152)
        Me.mobilemember.Name = "mobilemember"
        Me.mobilemember.Size = New System.Drawing.Size(220, 203)
        Me.mobilemember.TabIndex = 21
        Me.mobilemember.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(597, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MEMBER MENU"
        '
        'pembelianmember
        '
        Me.pembelianmember.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pembelianmember.BackgroundImage = CType(resources.GetObject("pembelianmember.BackgroundImage"), System.Drawing.Image)
        Me.pembelianmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pembelianmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pembelianmember.Image = CType(resources.GetObject("pembelianmember.Image"), System.Drawing.Image)
        Me.pembelianmember.Location = New System.Drawing.Point(415, 152)
        Me.pembelianmember.Name = "pembelianmember"
        Me.pembelianmember.Size = New System.Drawing.Size(220, 203)
        Me.pembelianmember.TabIndex = 19
        Me.pembelianmember.UseVisualStyleBackColor = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinanceToolStripMenuItem, Me.StocksToolStripMenuItem, Me.SettingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1221, 24)
        Me.MenuStrip.TabIndex = 23
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FinanceToolStripMenuItem
        '
        Me.FinanceToolStripMenuItem.Image = CType(resources.GetObject("FinanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FinanceToolStripMenuItem.Name = "FinanceToolStripMenuItem"
        Me.FinanceToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.FinanceToolStripMenuItem.Text = "Finance"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Image = CType(resources.GetObject("StocksToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.StocksToolStripMenuItem.Text = "Stocks"
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 31)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "FORM PEMBELIAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(842, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "( MOBILE STOCKIST )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(457, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "( MAINTAIN )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(389, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 31)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "FORM PEMBELIAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(747, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(341, 31)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "FORM CLAIM MAINTAIN"
        '
        'claimmember
        '
        Me.claimmember.BackColor = System.Drawing.SystemColors.Window
        Me.claimmember.BackgroundImage = CType(resources.GetObject("claimmember.BackgroundImage"), System.Drawing.Image)
        Me.claimmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.claimmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.claimmember.Image = CType(resources.GetObject("claimmember.Image"), System.Drawing.Image)
        Me.claimmember.Location = New System.Drawing.Point(824, 480)
        Me.claimmember.Name = "claimmember"
        Me.claimmember.Size = New System.Drawing.Size(220, 203)
        Me.claimmember.TabIndex = 27
        Me.claimmember.UseVisualStyleBackColor = False
        '
        'maintainmember
        '
        Me.maintainmember.BackColor = System.Drawing.SystemColors.ControlDark
        Me.maintainmember.BackgroundImage = CType(resources.GetObject("maintainmember.BackgroundImage"), System.Drawing.Image)
        Me.maintainmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.maintainmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maintainmember.Image = CType(resources.GetObject("maintainmember.Image"), System.Drawing.Image)
        Me.maintainmember.Location = New System.Drawing.Point(415, 480)
        Me.maintainmember.Name = "maintainmember"
        Me.maintainmember.Size = New System.Drawing.Size(220, 203)
        Me.maintainmember.TabIndex = 26
        Me.maintainmember.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(842, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "( MOBILE STOCKIST )"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(77, 631)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(77, 72)
        Me.back.TabIndex = 32
        Me.back.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 706)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "BACK TO MAIN MENU"
        '
        'membermenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1221, 733)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.claimmember)
        Me.Controls.Add(Me.maintainmember)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mobilemember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pembelianmember)
        Me.Name = "membermenu"
        Me.Text = "membermenu"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents mobilemember As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pembelianmember As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FinanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents claimmember As Button
    Friend WithEvents maintainmember As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents back As Button
    Friend WithEvents Label9 As Label
End Class
