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
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLer = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOper1
        '
        Me.lblOper1.AutoSize = True
        Me.lblOper1.Location = New System.Drawing.Point(12, 9)
        Me.lblOper1.Name = "lblOper1"
        Me.lblOper1.Size = New System.Drawing.Size(57, 20)
        Me.lblOper1.TabIndex = 0
        Me.lblOper1.Text = "Label1"
        '
        'lblOper2
        '
        Me.lblOper2.AutoSize = True
        Me.lblOper2.Location = New System.Drawing.Point(122, 10)
        Me.lblOper2.Name = "lblOper2"
        Me.lblOper2.Size = New System.Drawing.Size(57, 20)
        Me.lblOper2.TabIndex = 1
        Me.lblOper2.Text = "Label2"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(226, 9)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(57, 20)
        Me.lblRes.TabIndex = 2
        Me.lblRes.Text = "Label3"
        '
        'txtOper1
        '
        Me.txtOper1.Location = New System.Drawing.Point(16, 33)
        Me.txtOper1.Name = "txtOper1"
        Me.txtOper1.Size = New System.Drawing.Size(100, 26)
        Me.txtOper1.TabIndex = 3
        '
        'txtOper2
        '
        Me.txtOper2.Location = New System.Drawing.Point(123, 33)
        Me.txtOper2.Name = "txtOper2"
        Me.txtOper2.Size = New System.Drawing.Size(100, 26)
        Me.txtOper2.TabIndex = 4
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(230, 33)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(100, 26)
        Me.txtRes.TabIndex = 5
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(16, 66)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 23)
        Me.btnSum.TabIndex = 6
        Me.btnSum.Text = "Button1"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(123, 66)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(75, 23)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "Button2"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(16, 95)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(75, 23)
        Me.btnTimes.TabIndex = 8
        Me.btnTimes.Text = "Button3"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(126, 96)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnDiv.TabIndex = 9
        Me.btnDiv.Text = "Button4"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(16, 125)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Button5"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLer
        '
        Me.btnLer.Location = New System.Drawing.Point(337, 35)
        Me.btnLer.Name = "btnLer"
        Me.btnLer.Size = New System.Drawing.Size(75, 23)
        Me.btnLer.TabIndex = 11
        Me.btnLer.Text = "Button6"
        Me.btnLer.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(419, 33)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 23)
        Me.btnGravar.TabIndex = 12
        Me.btnGravar.Text = "Button7"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(337, 62)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(157, 26)
        Me.txtFile.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnLer)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnTimes)
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
    Friend WithEvents btnTimes As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnLer As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents txtFile As TextBox
End Class
