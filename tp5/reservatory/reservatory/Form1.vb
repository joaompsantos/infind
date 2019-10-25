Public Class Form1
    Dim ins() As Boolean = {False, False, False}
    Dim outs() As Boolean = {False, False, False, False}
    Dim level As Short = New Short
    Dim save As Boolean
    Dim mantx() As Char = "s_ToPLC000_e".ToCharArray

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500

        Me.StatusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow

        Me.Text = "Water Level Control - 76552"

        Me.lblLink.Text = "Link"
        Me.lblLink.BorderSides = ToolStripStatusLabelBorderSides.Right
        Me.lblLink.BackColor = Me.StatusStrip1.BackColor

        Me.lblConf.Text = "---"
        Me.lblConf.BackColor = Me.StatusStrip1.BackColor
        Me.lblConf.BorderSides = ToolStripStatusLabelBorderSides.Right

        Me.lblTime.Alignment = ToolStripItemAlignment.Right
        Me.lblTime.BackColor = Me.StatusStrip1.BackColor

        Me.lblTime.BorderSides = ToolStripStatusLabelBorderSides.Left
        Me.lblTime.Text = Now.ToString("yyyy / mm / dd")

        Me.TextBox1.Hide()
        Me.TextBox1.ReadOnly = True
    End Sub

    Private Sub RS232ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RS232ToolStripMenuItem.Click
        rsconfig.ShowDialog()
    End Sub

    Friend Sub setrs232link()
        If getOpen() Then
            lblLink.Text = "RS232"
            lblConf.Text = getCom() + "|" + getBaud() + "|" + getPar() + "|" + getData() + "|" + getStop()
            RS232ToolStripMenuItem.Checked = True
            btnCtrl.Text = "Automatic ON"
            btnPump.Enabled = False
            btnVin.Enabled = False
            btnVo.Enabled = False
            btnCtrl.Enabled = True
            setCtrl(True)
            lbltimer.Text = "Running"
        Else
            lblLink.Text = "Link"
            lblConf.Text = "---"
            RS232ToolStripMenuItem.Checked = False
            btnPump.Enabled = False
            btnVin.Enabled = False
            btnVo.Enabled = False
            btnCtrl.Enabled = False
            lbltimer.Text = "stopped"
        End If
    End Sub

    Private Sub BtnCtrl_Click(sender As Object, e As EventArgs) Handles btnCtrl.Click
        If getCtrl() Then
            setCtrl(False)
            btnCtrl.Text = "Automatic OFF"
            btnPump.Enabled = True
            btnVin.Enabled = True
            btnVo.Enabled = True
        Else
            btnCtrl.Text = "Automatic ON"
            setCtrl(True)
            btnPump.Enabled = False
            btnVin.Enabled = False
            btnVo.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim aux, tx As String
        'update log from the message
        aux = serialcom.decode(ins, outs, level)

        If rsview.Visible Then
            rsview.TextBox1.Text = aux
        End If

        If getCtrl() Then
            tx = monitLevel(outs, level)

        Else
            tx = New String(mantx)
        End If

        updateStatus(outs, ins, level)

        If save Then
            My.Computer.FileSystem.WriteAllText("./assets/log.txt", aux, True)
        End If

        serialcom.writemsg(tx)
        rsview.TextBox2.Text = tx

    End Sub

    Private Sub updateStatus(ByRef outs, ByRef ins, ByRef level)
        chkPump.Checked = ins(0)
        chkVin.Checked = ins(1)
        chkVout.Checked = ins(2)
        Console.Write(outs)
        If outs(0) Then
            pbxX0.Image = My.Resources.led_green
        Else
            pbxX0.Image = My.Resources.led_red
        End If

        If outs(1) Then
            pbxX1.Image = My.Resources.led_green
        Else
            pbxX1.Image = My.Resources.led_red
        End If

        If outs(2) Then
            pbxX2.Image = My.Resources.led_green
        Else
            pbxX2.Image = My.Resources.led_red
        End If

        If outs(3) Then
            pbxX3.Image = My.Resources.led_green
        Else
            pbxX3.Image = My.Resources.led_red
        End If

        txtLevel.Text = level

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Not save Then
            save = True
            SaveToolStripMenuItem.Checked = True
        Else
            save = False
            SaveToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessagesToolStripMenuItem.Click
        rsview.Show()
    End Sub

    Private Sub BtnPump_Click(sender As Object, e As EventArgs) Handles btnPump.Click
        If mantx(7) = "1" Then
            mantx(7) = "0"
        Else
            mantx(7) = "1"
        End If
    End Sub

    Private Sub BtnVin_Click(sender As Object, e As EventArgs) Handles btnVin.Click
        If mantx(8) = "1" Then
            mantx(8) = "0"
        Else
            mantx(8) = "1"
        End If
    End Sub

    Private Sub BtnVo_Click(sender As Object, e As EventArgs) Handles btnVo.Click
        If mantx(9) = "1" Then
            mantx(9) = "0"
        Else
            mantx(9) = "1"
        End If
    End Sub

End Class
