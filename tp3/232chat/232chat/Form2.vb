Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setUI()
        portparam.setvalid(False)
    End Sub

    Private Sub setUI()

        Dim pad As Short = 15
        Dim space As Short = 5

        Dim lbl_width As Short = 50
        Dim lbl_height As Short = 20

        Dim cb_width As Short = 75
        Dim cb_height As Short = 20

        Dim btn_width As Short = 50
        Dim btn_height As Short = 20

        Me.Text = "Conf"

        'Labels
        With lblPort
            .Location = New Point(pad, pad)
            .Width = lbl_width
            .Height = lbl_height
            .Text = "Port"
        End With

        With lblBaud
            .Location = New Point(lblPort.Location.X, lblPort.Location.Y + space + lbl_height)
            .Width = lbl_width
            .Height = lbl_height
            .Text = "Baudrate"
        End With

        With lblPar
            .Location = New Point(lblPort.Location.X, lblPort.Location.Y + 2 * space + 2 * lbl_height)
            .Width = lbl_width
            .Height = lbl_height
            .Text = "Parity"
        End With

        'ComboCoxs
        With cbPort
            .Location = New Point(lblPort.Location.X + space + lbl_width, lblPort.Location.Y)
            .Width = cb_width
            .Height = cb_height
            .DropDownStyle = ComboBoxStyle.DropDownList
            .Items.Clear()
            .Items.AddRange(My.Computer.Ports.SerialPortNames.ToArray)
            If .Items.Count > 0 Then
                .SelectedItem = .Items(0)
            End If
        End With

        With cbBaud
            .Location = New Point(lblPort.Location.X + space + lbl_width, lblPort.Location.Y + space + cb_height)
            .Width = cb_width
            .Height = cb_height
            .DropDownStyle = ComboBoxStyle.DropDownList
            .Items.Clear()
            .Items.AddRange({"1200", "1800", "2400", "4800", "9600", "19200", "38400", "57600"})
            .SelectedItem = .Items(0)
        End With



        With cbPar
            .Location = New Point(lblPort.Location.X + space + lbl_width, lblPort.Location.Y + 2 * space + 2 * cb_height)
            .Width = cb_width
            .Height = cb_height
            .DropDownStyle = ComboBoxStyle.DropDownList
            .Items.Clear()
            .Items.AddRange({IO.Ports.Parity.Even, IO.Ports.Parity.Odd, IO.Ports.Parity.None})
            .SelectedItem = .Items(2)
        End With

        'Buttons

        With btnOk
            .Location = New Point(lblPort.Location.X, lblPort.Location.Y + 3 * space + 3 * lbl_height)
            .Width = btn_width
            .Height = btn_height
            .Text = "Ok"
        End With

        With btnCancel
            .Location = New Point(lblPort.Location.X + space + lbl_width, lblPort.Location.Y + 3 * space + 3 * lbl_height)
            .Width = btn_width
            .Height = btn_height
            .Text = "Cancel"
        End With

        Me.Width = pad * 3 + lbl_width + cb_width + space
        Me.Height = pad * 4 + lbl_height * 3 + btn_height + space * 4
        Me.FormBorderStyle = FormBorderStyle.Fixed3D

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        portparam.setvalid(False)
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If My.Computer.Ports.SerialPortNames.Count > 0 Then
            portparam.setPort(cbPort.SelectedItem)
            'Console.WriteLine(portparam.getPort())
            portparam.setBaud(CInt(cbBaud.SelectedItem))
            'Console.WriteLine(portparam.getBaud())
            portparam.setParity(cbPar.SelectedItem)
            'Console.WriteLine(portparam.getParity())

            portparam.setvalid(True)
            Me.Close()
        End If

    End Sub

End Class