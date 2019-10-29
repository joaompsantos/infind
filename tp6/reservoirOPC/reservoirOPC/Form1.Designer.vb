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
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLink, Me.lblConf, Me.lblTime})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 391)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusStrip1.Size = New System.Drawing.Size(840, 24)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblLink
        '
        Me.lblLink.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(33, 19)
        Me.lblLink.Text = "Link"
        '
        'lblConf
        '
        Me.lblConf.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblConf.Name = "lblConf"
        Me.lblConf.Size = New System.Drawing.Size(26, 19)
        Me.lblConf.Text = "---"
        '
        'lblTime
        '
        Me.lblTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(41, 19)
        Me.lblTime.Text = "Clock"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LinkToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LinkToolStripMenuItem
        '
        Me.LinkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCItem})
        Me.LinkToolStripMenuItem.Name = "LinkToolStripMenuItem"
        Me.LinkToolStripMenuItem.Size = New System.Drawing.Size(41, 22)
        Me.LinkToolStripMenuItem.Text = "Link"
        '
        'OPCItem
        '
        Me.OPCItem.Name = "OPCItem"
        Me.OPCItem.Size = New System.Drawing.Size(98, 22)
        Me.OPCItem.Text = "OPC"
        '
        'pbxX0
        '
        Me.pbxX0.BackColor = System.Drawing.Color.Transparent
        Me.pbxX0.Image = CType(resources.GetObject("pbxX0.Image"), System.Drawing.Image)
        Me.pbxX0.Location = New System.Drawing.Point(498, 265)
        Me.pbxX0.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxX0.Name = "pbxX0"
        Me.pbxX0.Size = New System.Drawing.Size(33, 34)
        Me.pbxX0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX0.TabIndex = 2
        Me.pbxX0.TabStop = False
        '
        'pbxX1
        '
        Me.pbxX1.Image = CType(resources.GetObject("pbxX1.Image"), System.Drawing.Image)
        Me.pbxX1.Location = New System.Drawing.Point(498, 217)
        Me.pbxX1.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxX1.Name = "pbxX1"
        Me.pbxX1.Size = New System.Drawing.Size(33, 34)
        Me.pbxX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX1.TabIndex = 3
        Me.pbxX1.TabStop = False
        '
        'pbxX2
        '
        Me.pbxX2.Image = CType(resources.GetObject("pbxX2.Image"), System.Drawing.Image)
        Me.pbxX2.Location = New System.Drawing.Point(498, 134)
        Me.pbxX2.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxX2.Name = "pbxX2"
        Me.pbxX2.Size = New System.Drawing.Size(33, 33)
        Me.pbxX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX2.TabIndex = 4
        Me.pbxX2.TabStop = False
        '
        'pbxX3
        '
        Me.pbxX3.Image = CType(resources.GetObject("pbxX3.Image"), System.Drawing.Image)
        Me.pbxX3.Location = New System.Drawing.Point(498, 97)
        Me.pbxX3.Margin = New System.Windows.Forms.Padding(2)
        Me.pbxX3.Name = "pbxX3"
        Me.pbxX3.Size = New System.Drawing.Size(33, 33)
        Me.pbxX3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxX3.TabIndex = 5
        Me.pbxX3.TabStop = False
        '
        'btnPump
        '
        Me.btnPump.Enabled = False
        Me.btnPump.Location = New System.Drawing.Point(86, 336)
        Me.btnPump.Name = "btnPump"
        Me.btnPump.Size = New System.Drawing.Size(75, 23)
        Me.btnPump.TabIndex = 6
        Me.btnPump.Text = "Pump"
        Me.btnPump.UseVisualStyleBackColor = True
        '
        'btnVin
        '
        Me.btnVin.Enabled = False
        Me.btnVin.Location = New System.Drawing.Point(247, 253)
        Me.btnVin.Name = "btnVin"
        Me.btnVin.Size = New System.Drawing.Size(75, 23)
        Me.btnVin.TabIndex = 7
        Me.btnVin.Text = "Valve In"
        Me.btnVin.UseVisualStyleBackColor = True
        '
        'btnVo
        '
        Me.btnVo.Enabled = False
        Me.btnVo.Location = New System.Drawing.Point(653, 345)
        Me.btnVo.Name = "btnVo"
        Me.btnVo.Size = New System.Drawing.Size(75, 23)
        Me.btnVo.TabIndex = 8
        Me.btnVo.Text = "Valve Out"
        Me.btnVo.UseVisualStyleBackColor = True
        '
        'chkPump
        '
        Me.chkPump.AutoSize = True
        Me.chkPump.Enabled = False
        Me.chkPump.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPump.Location = New System.Drawing.Point(86, 134)
        Me.chkPump.Name = "chkPump"
        Me.chkPump.Size = New System.Drawing.Size(84, 17)
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
        Me.chkVin.Location = New System.Drawing.Point(240, 113)
        Me.chkVin.Name = "chkVin"
        Me.chkVin.Size = New System.Drawing.Size(97, 17)
        Me.chkVin.TabIndex = 10
        Me.chkVin.Text = "Y1 - Valve In"
        Me.chkVin.UseVisualStyleBackColor = True
        '
        'chkVout
        '
        Me.chkVout.AutoSize = True
        Me.chkVout.Enabled = False
        Me.chkVout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVout.Location = New System.Drawing.Point(644, 189)
        Me.chkVout.Name = "chkVout"
        Me.chkVout.Size = New System.Drawing.Size(109, 17)
        Me.chkVout.TabIndex = 11
        Me.chkVout.Text = "Y2 - Valve Out"
        Me.chkVout.UseVisualStyleBackColor = True
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(369, 53)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(65, 13)
        Me.lblLevel.TabIndex = 12
        Me.lblLevel.Text = "Water Level"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(440, 50)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(77, 20)
        Me.txtLevel.TabIndex = 13
        '
        'btnCtrl
        '
        Me.btnCtrl.Enabled = False
        Me.btnCtrl.Location = New System.Drawing.Point(724, 27)
        Me.btnCtrl.Name = "btnCtrl"
        Me.btnCtrl.Size = New System.Drawing.Size(104, 43)
        Me.btnCtrl.TabIndex = 14
        Me.btnCtrl.Text = "Automatic OFF"
        Me.btnCtrl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(3, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 53)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "All OK!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.reservoirOPC.My.Resources.Resources.Reservatorio_sem_labels_transparente
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(840, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents OPCItem As ToolStripMenuItem
    Friend WithEvents btnCtrl As Button
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
