Public Class Form1
    Dim state() As Boolean = {False, False, False, False, False, False, False}
    Dim level As String = New String("")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Main Window graphics
        Me.Text = "Water Level Control - 76552"
        Me.Icon = New Icon("./assets/ualogo.ico")
        Me.lblTime.Alignment = ToolStripItemAlignment.Right

        'Timer ticking
        Me.Timer1.Interval = 500
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    Friend Sub setlinkstate()
        If opcutils.opclinked() Then
            lblLink.Text = "OPC"
            lblConf.Text = opcutils.getPLC()
            OPCItem.Checked = True
            btnCtrl.Text = "Automatic ON"
            ' Create Function to disable all buttons
            btnPump.Enabled = False
            btnVin.Enabled = False
            btnVo.Enabled = False
            btnCtrl.Enabled = True

            setActive(True)
        Else
            lblLink.Text = "Link"
            lblConf.Text = "---"
            OPCItem.Checked = False
            btnPump.Enabled = False
            btnVin.Enabled = False
            btnVo.Enabled = False
            btnCtrl.Enabled = False
        End If
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCtrl_Click(sender As Object, e As EventArgs) Handles btnCtrl.Click
        If getActive() Then
            setActive(False)
            btnCtrl.Text = "Automatic OFF"
            btnPump.Enabled = True
            btnVin.Enabled = True
            btnVo.Enabled = True

        Else
            btnCtrl.Text = "Automatic ON"
            setActive(True)
            btnPump.Enabled = False
            btnVin.Enabled = False
            btnVo.Enabled = False
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ' Fetch Information
            opcutils.readItems(state, level)
        Catch
            Me.Timer1.Stop()
            Me.OPCItem.Checked = False
            Try
                opcutils.disconnect()
            Catch
            End Try

            MsgBox("Connection Lost")
            End Try

            ' Automatic Control ?
            If autocontrol.getActive() Then
            autocontrol.controltank(state)
        End If

        ' Monitoring Update
        updateStatus(state, level)

        lblTime.Text = Now.ToString()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="state"></param>
    ''' <param name="level"></param>
    Private Sub updateStatus(ByRef state, ByRef level)

        chkPump.Checked = state(0)
        chkVin.Checked = state(1)
        chkVout.Checked = state(2)


        If state(3) Then
            pbxX0.Image = My.Resources.led_green
        Else
            pbxX0.Image = My.Resources.led_red
        End If

        If state(4) Then
            pbxX1.Image = My.Resources.led_green
        Else
            pbxX1.Image = My.Resources.led_red
        End If

        If state(5) Then
            pbxX2.Image = My.Resources.led_green
        Else
            pbxX2.Image = My.Resources.led_red
        End If

        If state(6) Then
            pbxX3.Image = My.Resources.led_green
        Else
            pbxX3.Image = My.Resources.led_red
        End If

        txtLevel.Text = level

    End Sub


    ''' <summary>
    ''' Attempt to initiate link with OPC server when button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param> 

    Private Sub OPCItem_Click(sender As Object, e As EventArgs) Handles OPCItem.Click
        'Define Server File
        opcutils.loadconfig()
        'Connect to Server
        opcutils.connectOPC()
        'Set Link Information
        Me.setlinkstate()
        'Start Timer
        Me.Timer1.Start()
    End Sub

    Private Sub BtnPump_Click(sender As Object, e As EventArgs) Handles btnPump.Click
        autocontrol.toogleItem(state(0), "Y0")
    End Sub

    Private Sub BtnVin_Click(sender As Object, e As EventArgs) Handles btnVin.Click
        autocontrol.toogleItem(state(1), "Y1")
    End Sub

    Private Sub BtnVo_Click(sender As Object, e As EventArgs)
        autocontrol.toogleItem(state(2), "Y2")
    End Sub
End Class
