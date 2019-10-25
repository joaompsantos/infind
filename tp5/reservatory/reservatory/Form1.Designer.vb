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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblLink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConf = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RS232ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbxX0 = New System.Windows.Forms.PictureBox()
        Me.pbxX1 = New System.Windows.Forms.PictureBox()
        Me.pbxX2 = New System.Windows.Forms.PictureBox()
        Me.pbxX3 = New System.Windows.Forms.PictureBox()
        Me.btnPump = New System.Windows.Forms.Button()
        Me.btnVin = New System.Windows.Forms.Button()
        Me.btnVo = New System.Windows.Forms.Button()
        Me.chkPump = New System.Windows.Forms.CheckBox()
        Me.chkVin = New System.Windows.Forms.CheckBox()
        Me.chkVout = New System.Windows.Forms.CheckBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.btnCtrl = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxX0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxX3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLink, Me.lblConf, Me.lbltimer, Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 606)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 32)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblLink
        '
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(180, 25)
        Me.lblLink.Text = "ToolStripStatusLabel1"
        '
        'lblConf
        '
        Me.lblConf.Name = "lblConf"
        Me.lblConf.Size = New System.Drawing.Size(180, 25)
        Me.lblConf.Text = "ToolStripStatusLabel2"
        '
        'lbltimer
        '
        Me.lbltimer.Name = "lbltimer"
        Me.lbltimer.Size = New System.Drawing.Size(180, 25)
        Me.lbltimer.Text = "ToolStripStatusLabel1"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(180, 25)
        Me.lblTime.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LinkToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(151, 34)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LinkToolStripMenuItem
        '
        Me.LinkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RS232ToolStripMenuItem})
        Me.LinkToolStripMenuItem.Name = "LinkToolStripMenuItem"
        Me.LinkToolStripMenuItem.Size = New System.Drawing.Size(59, 29)
        Me.LinkToolStripMenuItem.Text = "Link"
        '
        'RS232ToolStripMenuItem
        '
        Me.RS232ToolStripMenuItem.Name = "RS232ToolStripMenuItem"
        Me.RS232ToolStripMenuItem.Size = New System.Drawing.Size(165, 34)
        Me.RS232ToolStripMenuItem.Text = "RS232"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessagesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'MessagesToolStripMenuItem
        '
        Me.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem"
        Me.MessagesToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.MessagesToolStripMenuItem.Text = "Messages"
        '
        'pbxX0
        '
        Me.pbxX0.BackColor = System.Drawing.Color.Transparent
        Me.pbxX0.Image = CType(resources.GetObject("pbxX0.Image"), System.Drawing.Image)
        Me.pbxX0.Location = New System.Drawing.Point(747, 408)
        Me.pbxX0.Name = "pbxX0"
        Me.pbxX0.Size = New System.Drawing.Size(50, 52)
        Me.pbxX0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX0.TabIndex = 2
        Me.pbxX0.TabStop = False
        '
        'pbxX1
        '
        Me.pbxX1.Image = CType(resources.GetObject("pbxX1.Image"), System.Drawing.Image)
        Me.pbxX1.Location = New System.Drawing.Point(747, 334)
        Me.pbxX1.Name = "pbxX1"
        Me.pbxX1.Size = New System.Drawing.Size(50, 52)
        Me.pbxX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX1.TabIndex = 3
        Me.pbxX1.TabStop = False
        '
        'pbxX2
        '
        Me.pbxX2.Image = CType(resources.GetObject("pbxX2.Image"), System.Drawing.Image)
        Me.pbxX2.Location = New System.Drawing.Point(747, 206)
        Me.pbxX2.Name = "pbxX2"
        Me.pbxX2.Size = New System.Drawing.Size(50, 51)
        Me.pbxX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX2.TabIndex = 4
        Me.pbxX2.TabStop = False
        '
        'pbxX3
        '
        Me.pbxX3.Image = CType(resources.GetObject("pbxX3.Image"), System.Drawing.Image)
        Me.pbxX3.Location = New System.Drawing.Point(747, 149)
        Me.pbxX3.Name = "pbxX3"
        Me.pbxX3.Size = New System.Drawing.Size(50, 51)
        Me.pbxX3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX3.TabIndex = 5
        Me.pbxX3.TabStop = False
        '
        'btnPump
        '
        Me.btnPump.Enabled = False
        Me.btnPump.Location = New System.Drawing.Point(129, 517)
        Me.btnPump.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPump.Name = "btnPump"
        Me.btnPump.Size = New System.Drawing.Size(112, 35)
        Me.btnPump.TabIndex = 6
        Me.btnPump.Text = "Pump"
        Me.btnPump.UseVisualStyleBackColor = True
        '
        'btnVin
        '
        Me.btnVin.Enabled = False
        Me.btnVin.Location = New System.Drawing.Point(370, 389)
        Me.btnVin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVin.Name = "btnVin"
        Me.btnVin.Size = New System.Drawing.Size(112, 35)
        Me.btnVin.TabIndex = 7
        Me.btnVin.Text = "Valve In"
        Me.btnVin.UseVisualStyleBackColor = True
        '
        'btnVo
        '
        Me.btnVo.Enabled = False
        Me.btnVo.Location = New System.Drawing.Point(980, 531)
        Me.btnVo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVo.Name = "btnVo"
        Me.btnVo.Size = New System.Drawing.Size(112, 35)
        Me.btnVo.TabIndex = 8
        Me.btnVo.Text = "Valve Out"
        Me.btnVo.UseVisualStyleBackColor = True
        '
        'chkPump
        '
        Me.chkPump.AutoSize = True
        Me.chkPump.Enabled = False
        Me.chkPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPump.Location = New System.Drawing.Point(129, 206)
        Me.chkPump.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPump.Name = "chkPump"
        Me.chkPump.Size = New System.Drawing.Size(118, 24)
        Me.chkPump.TabIndex = 9
        Me.chkPump.Text = "Y0 - Pump"
        Me.chkPump.UseVisualStyleBackColor = True
        '
        'chkVin
        '
        Me.chkVin.AutoSize = True
        Me.chkVin.Enabled = False
        Me.chkVin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVin.Location = New System.Drawing.Point(360, 174)
        Me.chkVin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkVin.Name = "chkVin"
        Me.chkVin.Size = New System.Drawing.Size(133, 24)
        Me.chkVin.TabIndex = 10
        Me.chkVin.Text = "Y1 - Valve In"
        Me.chkVin.UseVisualStyleBackColor = True
        '
        'chkVout
        '
        Me.chkVout.AutoSize = True
        Me.chkVout.Enabled = False
        Me.chkVout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVout.Location = New System.Drawing.Point(966, 291)
        Me.chkVout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkVout.Name = "chkVout"
        Me.chkVout.Size = New System.Drawing.Size(151, 24)
        Me.chkVout.TabIndex = 11
        Me.chkVout.Text = "Y2 - Valve Out"
        Me.chkVout.UseVisualStyleBackColor = True
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(554, 82)
        Me.lblLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(93, 20)
        Me.lblLevel.TabIndex = 12
        Me.lblLevel.Text = "Water Level"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(660, 77)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(114, 26)
        Me.txtLevel.TabIndex = 13
        '
        'btnCtrl
        '
        Me.btnCtrl.Enabled = False
        Me.btnCtrl.Location = New System.Drawing.Point(1086, 42)
        Me.btnCtrl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCtrl.Name = "btnCtrl"
        Me.btnCtrl.Size = New System.Drawing.Size(156, 66)
        Me.btnCtrl.TabIndex = 14
        Me.btnCtrl.Text = "Automatic OFF"
        Me.btnCtrl.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(65, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1260, 638)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCtrl)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.chkVout)
        Me.Controls.Add(Me.chkVin)
        Me.Controls.Add(Me.chkPump)
        Me.Controls.Add(Me.btnVo)
        Me.Controls.Add(Me.btnVin)
        Me.Controls.Add(Me.btnPump)
        Me.Controls.Add(Me.pbxX3)
        Me.Controls.Add(Me.pbxX2)
        Me.Controls.Add(Me.pbxX1)
        Me.Controls.Add(Me.pbxX0)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxX0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxX3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblLink As ToolStripStatusLabel
    Friend WithEvents lblConf As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbxX0 As PictureBox
    Friend WithEvents pbxX1 As PictureBox
    Friend WithEvents pbxX2 As PictureBox
    Friend WithEvents pbxX3 As PictureBox
    Friend WithEvents btnPump As Button
    Friend WithEvents btnVin As Button
    Friend WithEvents btnVo As Button
    Friend WithEvents chkPump As CheckBox
    Friend WithEvents chkVin As CheckBox
    Friend WithEvents chkVout As CheckBox
    Friend WithEvents lblLevel As Label
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents RS232ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCtrl As Button
    Friend WithEvents lbltimer As ToolStripStatusLabel
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
