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
        Me.lblOper1 = New System.Windows.Forms.Label()
        Me.lblOper2 = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.txtOper1 = New System.Windows.Forms.TextBox()
        Me.txtOper2 = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOper1
        '
        Me.lblOper1.AutoSize = True
        Me.lblOper1.Location = New System.Drawing.Point(65, 53)
        Me.lblOper1.Name = "lblOper1"
        Me.lblOper1.Size = New System.Drawing.Size(57, 20)
        Me.lblOper1.TabIndex = 0
        Me.lblOper1.Text = "Label1"
        Me.lblOper1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOper2
        '
        Me.lblOper2.AutoSize = True
        Me.lblOper2.Location = New System.Drawing.Point(241, 53)
        Me.lblOper2.Name = "lblOper2"
        Me.lblOper2.Size = New System.Drawing.Size(57, 20)
        Me.lblOper2.TabIndex = 1
        Me.lblOper2.Text = "Label2"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(425, 53)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(57, 20)
        Me.lblRes.TabIndex = 2
        Me.lblRes.Text = "Label3"
        '
        'txtOper1
        '
        Me.txtOper1.Location = New System.Drawing.Point(69, 76)
        Me.txtOper1.Name = "txtOper1"
        Me.txtOper1.Size = New System.Drawing.Size(100, 26)
        Me.txtOper1.TabIndex = 3
        '
        'txtOper2
        '
        Me.txtOper2.Location = New System.Drawing.Point(245, 76)
        Me.txtOper2.Name = "txtOper2"
        Me.txtOper2.Size = New System.Drawing.Size(100, 26)
        Me.txtOper2.TabIndex = 4
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(429, 76)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(100, 26)
        Me.txtRes.TabIndex = 5
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(69, 141)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(100, 43)
        Me.btnSum.TabIndex = 6
        Me.btnSum.Text = "Button1"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(194, 141)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(104, 43)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "Button2"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(331, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 114)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Button3"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(194, 233)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(104, 39)
        Me.btnDiv.TabIndex = 9
        Me.btnDiv.Text = "Button4"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(69, 233)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(100, 39)
        Me.btnTimes.TabIndex = 10
        Me.btnTimes.Text = "Button5"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtOper2)
        Me.Controls.Add(Me.txtOper1)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.lblOper2)
        Me.Controls.Add(Me.lblOper1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOper1 As Label
    Friend WithEvents lblOper2 As Label
    Friend WithEvents lblRes As Label
    Friend WithEvents txtOper1 As TextBox
    Friend WithEvents txtOper2 As TextBox
    Friend WithEvents txtRes As TextBox
    Friend WithEvents btnSum As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnTimes As Button
End Class
