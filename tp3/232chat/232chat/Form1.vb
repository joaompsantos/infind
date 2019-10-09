Public Class Form1

    ' TODO:
    '   - Bug on Parity Combo Box 
    '
    '
    '

    Dim rxdata As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Define all GUI related aspects
        Me.Text = "aula3_76552"
        Me.Icon = New Icon("../../assets/ualogo.ico")
        setGUI()
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        Me.StartPosition = FormStartPosition.WindowsDefaultBounds
        serialport.Close()
        timer.Interval = 300
        timer.Enabled = False

        'From the guide
        txtTx.Text = "My First Message!"

    End Sub

    Private Sub setGUI()

        Dim pad As Short = 25
        Dim lbl_Width As Short = 100
        Dim lbl_Height As Short = 10
        Dim space As Short = 10
        Dim txt_Width As Short = 150
        Dim txt_Height As Short = 200
        Dim btn_Width As Short = txt_Width / 2
        Dim btn_Heigth As Short = 25

        ''''''''
        'Labels'
        ''''''''

        With lblTxdata
            .Text = "Data to Send"
            .Width = lbl_Width
            .Height = lbl_Height
            .TextAlign = ContentAlignment.MiddleLeft
            .Location = New Point(pad, pad)
        End With

        With lblRxdata
            .Text = "Received Data"
            .Width = lbl_Width
            .TextAlign = ContentAlignment.MiddleLeft
            .Location = New Point(lblTxdata.Location.X + txt_Width + space, lblTxdata.Location.Y)
        End With

        With lblHist
            .Text = "History"
            .Width = lbl_Width
            .Height = lbl_Height
            .Location = New Point(lblTxdata.Location.X + 3 * space + 2 * txt_Width + btn_Width, lblTxdata.Location.Y)
        End With

        '''''''''''
        'Textboxes'
        '''''''''''

        With txtTx
            .Multiline = True
            .Location = New Point(lblTxdata.Location.X, lblTxdata.Location.Y + lbl_Height + space)
            .Width = txt_Width
            .Height = txt_Height
            .ReadOnly = True
        End With

        With txtRx
            .Multiline = True
            .Location = New Point(lblTxdata.Location.X + txt_Width + space, lblTxdata.Location.Y + lbl_Height + space)
            .Width = txt_Width
            .Height = txt_Height
            .ReadOnly = True
            .BackColor = Color.White
        End With

        With txtHist
            .Multiline = True
            .Height = txt_Height
            .Width = txt_Width
            .Location = New Point(lblTxdata.Location.X + 3 * space + 2 * txt_Width + btn_Width, lblTxdata.Location.Y + space + lbl_Height)
            .ReadOnly = True
            .BackColor = Color.White
        End With

        '''''''''
        'Buttons'
        '''''''''
        With btnSend
            .Text = "Send"
            .Enabled = False
            .Location = New Point(lblTxdata.Location.X + btn_Width / 2, lblTxdata.Location.Y + lbl_Height + txt_Height + 2 * space)
            .Width = btn_Width
            .Height = btn_Heigth
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        With btnConf
            .Text = "Configure Port"
            .Width = btn_Width
            .Height = btn_Heigth
            .Location = New Point(lblTxdata.Location.X + 2 * space + 2 * txt_Width, lblTxdata.Location.Y + space + lbl_Height)
        End With

        With btnOpenport
            .Text = "Open Port"
            .Width = btn_Width
            .Height = btn_Heigth
            .Location = New Point(lblTxdata.Location.X + 2 * space + 2 * txt_Width, lblTxdata.Location.Y + 2 * space + lbl_Height + btn_Heigth)
            .Enabled = False
        End With

        With btnSair
            .Text = "Exit"
            .Height = btn_Heigth
            .Width = btn_Width
            .Location = New Point(lblTxdata.Location.X + 2 * space + 2 * txt_Width, lblTxdata.Location.Y + 2 * space + lbl_Height + txt_Height)
        End With

        Me.Width = 3 * pad + 3 * txt_Width + 3 * space + btn_Width
        Me.Height = 3 * pad + lbl_Height + txt_Height + btn_Heigth + 2 * space


    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Form1_Closed(sender, e)
    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        Form2.StartPosition = FormStartPosition.WindowsDefaultLocation
        Form2.ShowDialog()

        If portparam.getValid() Then
            btnOpenport.Enabled = True
        Else
            btnOpenport.Enabled = False
        End If

    End Sub

    Private Sub BtnOpenport_Click(sender As Object, e As EventArgs) Handles btnOpenport.Click

        Try
            If serialport.IsOpen() Then
                serialport.Close()
                btnOpenport.Text = "Open Port"
                timer.Enabled = False
                txtTx.ReadOnly = True
                btnSend.Enabled = False
                portparam.setvalid(False)
                btnOpenport.Enabled = False
            Else
                portparam.configPort(serialport)
                serialport.Open()
                btnOpenport.Text = "Close Port"
                timer.Enabled = True
                txtTx.ReadOnly = False
                btnSend.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("Error while Interfacing with serial port")
        End Try
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        serialport.Write(txtTx.Text)
        txtHist.Text = TimeOfDay.ToLongTimeString + "-> Tx : " + vbCrLf + txtTx.Text + vbCrLf + txtHist.Text + vbCrLf
        txtTx.Text = ""
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        rxdata = rxdata & serialport.ReadExisting()
        Console.WriteLine("Sasdasd: \n")

        If rxdata.Length > 0 Then
            txtRx.Text = rxdata
            txtHist.Text = TimeOfDay.ToLongTimeString + "-> Rx : " + vbCrLf + rxdata + vbCrLf + txtHist.Text + vbCrLf
            rxdata = ""
        End If

    End Sub
End Class
