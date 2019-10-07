Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setUI()

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
            .Items.AddRange(My.Computer.Ports.SerialPortNames.ToArray)
            '.Text = .Items(0)
        End With

        With cbBaud
            .Location = New Point(lblPort.Location.X + space + lbl_width, lblPort.Location.Y + space + cb_height)
            .Width = cb_width
            .Height = cb_height
            .Items.AddRange({"4800", "9600", "19200"})
        End With

        With cbPar
            .Location = New Point(lblPort.Location.X + space + lbl_width, lblPort.Location.Y + 2 * space + 2 * cb_height)
            .Width = cb_width
            .Height = cb_height
            .Items.AddRange({IO.Ports.Parity.Even, IO.Ports.Parity.Odd, IO.Ports.Parity.None})
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
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Do stuff with selected options
        Me.Close()
    End Sub
End Class