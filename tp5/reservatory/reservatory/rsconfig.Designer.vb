<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rsconfig
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.cbBaud = New System.Windows.Forms.ComboBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.cbData = New System.Windows.Forms.ComboBox()
        Me.cbStop = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDefine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PORT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BaudRate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Parity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DataBits"
        '
        'cbPort
        '
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Location = New System.Drawing.Point(88, 12)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(121, 21)
        Me.cbPort.TabIndex = 4
        '
        'cbBaud
        '
        Me.cbBaud.FormattingEnabled = True
        Me.cbBaud.Location = New System.Drawing.Point(88, 40)
        Me.cbBaud.Name = "cbBaud"
        Me.cbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cbBaud.TabIndex = 5
        '
        'cbPar
        '
        Me.cbPar.FormattingEnabled = True
        Me.cbPar.Location = New System.Drawing.Point(88, 68)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(121, 21)
        Me.cbPar.TabIndex = 6
        '
        'cbData
        '
        Me.cbData.FormattingEnabled = True
        Me.cbData.Location = New System.Drawing.Point(88, 96)
        Me.cbData.Name = "cbData"
        Me.cbData.Size = New System.Drawing.Size(121, 21)
        Me.cbData.TabIndex = 7
        '
        'cbStop
        '
        Me.cbStop.FormattingEnabled = True
        Me.cbStop.Location = New System.Drawing.Point(88, 123)
        Me.cbStop.Name = "cbStop"
        Me.cbStop.Size = New System.Drawing.Size(121, 21)
        Me.cbStop.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "StopBits"
        '
        'btnDefine
        '
        Me.btnDefine.Location = New System.Drawing.Point(73, 162)
        Me.btnDefine.Name = "btnDefine"
        Me.btnDefine.Size = New System.Drawing.Size(75, 23)
        Me.btnDefine.TabIndex = 10
        Me.btnDefine.Text = "Confirm"
        Me.btnDefine.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 198)
        Me.Controls.Add(Me.btnDefine)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbStop)
        Me.Controls.Add(Me.cbData)
        Me.Controls.Add(Me.cbPar)
        Me.Controls.Add(Me.cbBaud)
        Me.Controls.Add(Me.cbPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPort As ComboBox
    Friend WithEvents cbBaud As ComboBox
    Friend WithEvents cbPar As ComboBox
    Friend WithEvents cbData As ComboBox
    Friend WithEvents cbStop As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDefine As Button
End Class
