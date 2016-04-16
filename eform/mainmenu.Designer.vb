<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newmember = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.member = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(601, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 31)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NEW MEMBER"
        '
        'newmember
        '
        Me.newmember.BackColor = System.Drawing.SystemColors.Window
        Me.newmember.BackgroundImage = CType(resources.GetObject("newmember.BackgroundImage"), System.Drawing.Image)
        Me.newmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.newmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newmember.Image = CType(resources.GetObject("newmember.Image"), System.Drawing.Image)
        Me.newmember.Location = New System.Drawing.Point(516, 157)
        Me.newmember.Name = "newmember"
        Me.newmember.Size = New System.Drawing.Size(362, 245)
        Me.newmember.TabIndex = 17
        Me.newmember.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "MEMBER"
        '
        'member
        '
        Me.member.BackColor = System.Drawing.SystemColors.ControlDark
        Me.member.BackgroundImage = CType(resources.GetObject("member.BackgroundImage"), System.Drawing.Image)
        Me.member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.member.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.member.Image = CType(resources.GetObject("member.Image"), System.Drawing.Image)
        Me.member.Location = New System.Drawing.Point(107, 157)
        Me.member.Name = "member"
        Me.member.Size = New System.Drawing.Size(362, 245)
        Me.member.TabIndex = 15
        Me.member.UseVisualStyleBackColor = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinanceToolStripMenuItem, Me.StocksToolStripMenuItem, Me.SettingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(995, 24)
        Me.MenuStrip.TabIndex = 13
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
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(995, 22)
        Me.StatusStrip.TabIndex = 14
        Me.StatusStrip.Text = "StatusStrip"
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 532)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.newmember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.member)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "mainmenu"
        Me.Text = "mainmenu"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents newmember As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents member As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FinanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
End Class
