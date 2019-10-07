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
        Me.lblTxdata = New System.Windows.Forms.Label()
        Me.lblRxdata = New System.Windows.Forms.Label()
        Me.lblHist = New System.Windows.Forms.Label()
        Me.txtTx = New System.Windows.Forms.TextBox()
        Me.txtRx = New System.Windows.Forms.TextBox()
        Me.txtHist = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.btnOpenport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTxdata
        '
        Me.lblTxdata.AutoSize = True
        Me.lblTxdata.Location = New System.Drawing.Point(51, 62)
        Me.lblTxdata.Name = "lblTxdata"
        Me.lblTxdata.Size = New System.Drawing.Size(57, 20)
        Me.lblTxdata.TabIndex = 0
        Me.lblTxdata.Text = "Label1"
        '
        'lblRxdata
        '
        Me.lblRxdata.AutoSize = True
        Me.lblRxdata.Location = New System.Drawing.Point(339, 62)
        Me.lblRxdata.Name = "lblRxdata"
        Me.lblRxdata.Size = New System.Drawing.Size(57, 20)
        Me.lblRxdata.TabIndex = 1
        Me.lblRxdata.Text = "Label2"
        '
        'lblHist
        '
        Me.lblHist.AutoSize = True
        Me.lblHist.Location = New System.Drawing.Point(721, 62)
        Me.lblHist.Name = "lblHist"
        Me.lblHist.Size = New System.Drawing.Size(57, 20)
        Me.lblHist.TabIndex = 2
        Me.lblHist.Text = "Label3"
        '
        'txtTx
        '
        Me.txtTx.Location = New System.Drawing.Point(55, 104)
        Me.txtTx.Name = "txtTx"
        Me.txtTx.Size = New System.Drawing.Size(100, 26)
        Me.txtTx.TabIndex = 3
        '
        'txtRx
        '
        Me.txtRx.Location = New System.Drawing.Point(343, 103)
        Me.txtRx.Name = "txtRx"
        Me.txtRx.Size = New System.Drawing.Size(100, 26)
        Me.txtRx.TabIndex = 4
        '
        'txtHist
        '
        Me.txtHist.Location = New System.Drawing.Point(725, 104)
        Me.txtHist.Name = "txtHist"
        Me.txtHist.Size = New System.Drawing.Size(100, 26)
        Me.txtHist.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(55, 151)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Button1"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(547, 151)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Button2"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(547, 59)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(75, 23)
        Me.btnConf.TabIndex = 8
        Me.btnConf.Text = "Button3"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'btnOpenport
        '
        Me.btnOpenport.Location = New System.Drawing.Point(547, 107)
        Me.btnOpenport.Name = "btnOpenport"
        Me.btnOpenport.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenport.TabIndex = 9
        Me.btnOpenport.Text = "Button4"
        Me.btnOpenport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 651)
        Me.Controls.Add(Me.btnOpenport)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtHist)
        Me.Controls.Add(Me.txtRx)
        Me.Controls.Add(Me.txtTx)
        Me.Controls.Add(Me.lblHist)
        Me.Controls.Add(Me.lblRxdata)
        Me.Controls.Add(Me.lblTxdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTxdata As Label
    Friend WithEvents lblRxdata As Label
    Friend WithEvents lblHist As Label
    Friend WithEvents txtTx As TextBox
    Friend WithEvents txtRx As TextBox
    Friend WithEvents txtHist As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnConf As Button
    Friend WithEvents btnOpenport As Button
End Class
