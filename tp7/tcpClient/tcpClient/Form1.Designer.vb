<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.trkPump = New System.Windows.Forms.TrackBar()
        Me.txtPump1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkY2 = New System.Windows.Forms.CheckBox()
        Me.chkY1 = New System.Windows.Forms.CheckBox()
        Me.chkY0 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPump2 = New System.Windows.Forms.TextBox()
        Me.chkX3 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkX2 = New System.Windows.Forms.CheckBox()
        Me.chkX1 = New System.Windows.Forms.CheckBox()
        Me.chkX0 = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.trkPump, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnection
        '
        Me.btnConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnection.Location = New System.Drawing.Point(13, 13)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(188, 113)
        Me.btnConnection.TabIndex = 0
        Me.btnConnection.Text = "Connect"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.trkPump)
        Me.GroupBox1.Controls.Add(Me.txtPump1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkY2)
        Me.GroupBox1.Controls.Add(Me.chkY1)
        Me.GroupBox1.Controls.Add(Me.chkY0)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(207, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 114)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'trkPump
        '
        Me.trkPump.Location = New System.Drawing.Point(66, 63)
        Me.trkPump.Maximum = 100
        Me.trkPump.Name = "trkPump"
        Me.trkPump.Size = New System.Drawing.Size(247, 45)
        Me.trkPump.TabIndex = 6
        '
        'txtPump1
        '
        Me.txtPump1.BackColor = System.Drawing.SystemColors.Window
        Me.txtPump1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPump1.Location = New System.Drawing.Point(319, 63)
        Me.txtPump1.Name = "txtPump1"
        Me.txtPump1.ReadOnly = True
        Me.txtPump1.Size = New System.Drawing.Size(64, 26)
        Me.txtPump1.TabIndex = 5
        Me.txtPump1.Text = "00"
        Me.txtPump1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Engine"
        '
        'chkY2
        '
        Me.chkY2.AutoSize = True
        Me.chkY2.Location = New System.Drawing.Point(263, 25)
        Me.chkY2.Name = "chkY2"
        Me.chkY2.Size = New System.Drawing.Size(48, 24)
        Me.chkY2.TabIndex = 2
        Me.chkY2.Text = "Y2"
        Me.chkY2.UseVisualStyleBackColor = True
        '
        'chkY1
        '
        Me.chkY1.AutoSize = True
        Me.chkY1.Location = New System.Drawing.Point(172, 25)
        Me.chkY1.Name = "chkY1"
        Me.chkY1.Size = New System.Drawing.Size(48, 24)
        Me.chkY1.TabIndex = 1
        Me.chkY1.Text = "Y1"
        Me.chkY1.UseVisualStyleBackColor = True
        '
        'chkY0
        '
        Me.chkY0.AutoSize = True
        Me.chkY0.Location = New System.Drawing.Point(82, 25)
        Me.chkY0.Name = "chkY0"
        Me.chkY0.Size = New System.Drawing.Size(48, 24)
        Me.chkY0.TabIndex = 0
        Me.chkY0.Text = "Y0"
        Me.chkY0.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPump2)
        Me.GroupBox2.Controls.Add(Me.chkX3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkX2)
        Me.GroupBox2.Controls.Add(Me.chkX1)
        Me.GroupBox2.Controls.Add(Me.chkX0)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 126)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outputs"
        '
        'txtPump2
        '
        Me.txtPump2.Enabled = False
        Me.txtPump2.Location = New System.Drawing.Point(126, 79)
        Me.txtPump2.Name = "txtPump2"
        Me.txtPump2.Size = New System.Drawing.Size(50, 26)
        Me.txtPump2.TabIndex = 6
        '
        'chkX3
        '
        Me.chkX3.AutoSize = True
        Me.chkX3.Enabled = False
        Me.chkX3.Location = New System.Drawing.Point(62, 84)
        Me.chkX3.Name = "chkX3"
        Me.chkX3.Size = New System.Drawing.Size(48, 24)
        Me.chkX3.TabIndex = 5
        Me.chkX3.Text = "X3"
        Me.chkX3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(118, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Engine"
        '
        'chkX2
        '
        Me.chkX2.AutoSize = True
        Me.chkX2.Enabled = False
        Me.chkX2.Location = New System.Drawing.Point(62, 37)
        Me.chkX2.Name = "chkX2"
        Me.chkX2.Size = New System.Drawing.Size(48, 24)
        Me.chkX2.TabIndex = 2
        Me.chkX2.Text = "X2"
        Me.chkX2.UseVisualStyleBackColor = True
        '
        'chkX1
        '
        Me.chkX1.AutoSize = True
        Me.chkX1.Enabled = False
        Me.chkX1.Location = New System.Drawing.Point(6, 84)
        Me.chkX1.Name = "chkX1"
        Me.chkX1.Size = New System.Drawing.Size(48, 24)
        Me.chkX1.TabIndex = 1
        Me.chkX1.Text = "X1"
        Me.chkX1.UseVisualStyleBackColor = True
        '
        'chkX0
        '
        Me.chkX0.AutoSize = True
        Me.chkX0.Enabled = False
        Me.chkX0.Location = New System.Drawing.Point(6, 37)
        Me.chkX0.Name = "chkX0"
        Me.chkX0.Size = New System.Drawing.Size(48, 24)
        Me.chkX0.TabIndex = 0
        Me.chkX0.Text = "X0"
        Me.chkX0.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblClock})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 268)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(629, 24)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(92, 19)
        Me.lblStatus.Text = "Not Connected"
        '
        'lblClock
        '
        Me.lblClock.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(39, 19)
        Me.lblClock.Text = "clock"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtLog.Location = New System.Drawing.Point(207, 134)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(403, 126)
        Me.txtLog.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 292)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConnection)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "tcpClient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trkPump, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnection As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkY2 As CheckBox
    Friend WithEvents chkY1 As CheckBox
    Friend WithEvents chkY0 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkX2 As CheckBox
    Friend WithEvents chkX1 As CheckBox
    Friend WithEvents chkX0 As CheckBox
    Friend WithEvents trkPump As TrackBar
    Friend WithEvents txtPump1 As TextBox
    Friend WithEvents txtPump2 As TextBox
    Friend WithEvents chkX3 As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblClock As ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtLog As TextBox
    Friend WithEvents Timer1 As Timer
End Class
