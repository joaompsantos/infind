<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblPar = New System.Windows.Forms.Label()
        Me.lblBaud = New System.Windows.Forms.Label()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.cbBaud = New System.Windows.Forms.ComboBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(48, 41)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(57, 20)
        Me.lblPort.TabIndex = 0
        Me.lblPort.Text = "Label1"
        '
        'lblPar
        '
        Me.lblPar.AutoSize = True
        Me.lblPar.Location = New System.Drawing.Point(48, 128)
        Me.lblPar.Name = "lblPar"
        Me.lblPar.Size = New System.Drawing.Size(57, 20)
        Me.lblPar.TabIndex = 1
        Me.lblPar.Text = "Label2"
        '
        'lblBaud
        '
        Me.lblBaud.AutoSize = True
        Me.lblBaud.Location = New System.Drawing.Point(48, 90)
        Me.lblBaud.Name = "lblBaud"
        Me.lblBaud.Size = New System.Drawing.Size(57, 20)
        Me.lblBaud.TabIndex = 2
        Me.lblBaud.Text = "Label3"
        '
        'cbPort
        '
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Location = New System.Drawing.Point(183, 38)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(121, 28)
        Me.cbPort.TabIndex = 3
        '
        'cbBaud
        '
        Me.cbBaud.FormattingEnabled = True
        Me.cbBaud.Location = New System.Drawing.Point(183, 82)
        Me.cbBaud.Name = "cbBaud"
        Me.cbBaud.Size = New System.Drawing.Size(121, 28)
        Me.cbBaud.TabIndex = 4
        '
        'cbPar
        '
        Me.cbPar.FormattingEnabled = True
        Me.cbPar.Location = New System.Drawing.Point(183, 120)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(121, 28)
        Me.cbPar.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(183, 185)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Button1"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(52, 185)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Button2"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbPar)
        Me.Controls.Add(Me.cbBaud)
        Me.Controls.Add(Me.cbPort)
        Me.Controls.Add(Me.lblBaud)
        Me.Controls.Add(Me.lblPar)
        Me.Controls.Add(Me.lblPort)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPort As Label
    Friend WithEvents lblPar As Label
    Friend WithEvents lblBaud As Label
    Friend WithEvents cbPort As ComboBox
    Friend WithEvents cbBaud As ComboBox
    Friend WithEvents cbPar As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
End Class
