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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.filemnitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newmnitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openmnitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.savemnitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveasmnitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.StatusStrip()
        Me.lblstatustime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblstatuslog = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblstatuscount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.exitmnitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.status.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filemnitem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mnustrp"
        '
        'filemnitem
        '
        Me.filemnitem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newmnitem, Me.openmnitem, Me.savemnitem, Me.saveasmnitem, Me.exitmnitem})
        Me.filemnitem.Name = "filemnitem"
        Me.filemnitem.Size = New System.Drawing.Size(54, 29)
        Me.filemnitem.Text = "File"
        '
        'newmnitem
        '
        Me.newmnitem.Name = "newmnitem"
        Me.newmnitem.Size = New System.Drawing.Size(270, 34)
        Me.newmnitem.Text = "New"
        '
        'openmnitem
        '
        Me.openmnitem.Name = "openmnitem"
        Me.openmnitem.Size = New System.Drawing.Size(270, 34)
        Me.openmnitem.Text = "Open"
        '
        'savemnitem
        '
        Me.savemnitem.Name = "savemnitem"
        Me.savemnitem.Size = New System.Drawing.Size(270, 34)
        Me.savemnitem.Text = "Save"
        '
        'saveasmnitem
        '
        Me.saveasmnitem.Name = "saveasmnitem"
        Me.saveasmnitem.Size = New System.Drawing.Size(270, 34)
        Me.saveasmnitem.Text = "Save As"
        '
        'txtbox
        '
        Me.txtbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbox.Location = New System.Drawing.Point(10, 40)
        Me.txtbox.Margin = New System.Windows.Forms.Padding(10)
        Me.txtbox.Multiline = True
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(771, 368)
        Me.txtbox.TabIndex = 1
        '
        'status
        '
        Me.status.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblstatustime, Me.lblstatuslog, Me.lblstatuscount})
        Me.status.Location = New System.Drawing.Point(0, 418)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(800, 32)
        Me.status.TabIndex = 2
        Me.status.Text = "StatusStrip1"
        '
        'lblstatustime
        '
        Me.lblstatustime.Name = "lblstatustime"
        Me.lblstatustime.Size = New System.Drawing.Size(180, 25)
        Me.lblstatustime.Text = "ToolStripStatusLabel1"
        '
        'lblstatuslog
        '
        Me.lblstatuslog.Name = "lblstatuslog"
        Me.lblstatuslog.Size = New System.Drawing.Size(180, 25)
        Me.lblstatuslog.Text = "ToolStripStatusLabel2"
        '
        'lblstatuscount
        '
        Me.lblstatuscount.Name = "lblstatuscount"
        Me.lblstatuscount.Size = New System.Drawing.Size(180, 25)
        Me.lblstatuscount.Text = "ToolStripStatusLabel3"
        '
        'exitmnitem
        '
        Me.exitmnitem.Name = "exitmnitem"
        Me.exitmnitem.Size = New System.Drawing.Size(270, 34)
        Me.exitmnitem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "My Text Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents filemnitem As ToolStripMenuItem
    Friend WithEvents newmnitem As ToolStripMenuItem
    Friend WithEvents openmnitem As ToolStripMenuItem
    Friend WithEvents savemnitem As ToolStripMenuItem
    Friend WithEvents saveasmnitem As ToolStripMenuItem
    Friend WithEvents txtbox As TextBox
    Friend WithEvents status As StatusStrip
    Friend WithEvents lblstatustime As ToolStripStatusLabel
    Friend WithEvents lblstatuslog As ToolStripStatusLabel
    Friend WithEvents lblstatuscount As ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents exitmnitem As ToolStripMenuItem
End Class
