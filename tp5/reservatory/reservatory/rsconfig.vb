Imports System.ComponentModel

Public Class rsconfig

    Private Sub BtnDefine_Click(sender As Object, e As EventArgs) Handles btnDefine.Click

        serialcom.closePort()

        'Set Settings
        serialcom.setCom(cbPort.SelectedItem)
        serialcom.setBaud(cbBaud.SelectedItem)
        serialcom.setData(cbData.SelectedItem)
        serialcom.setStop(cbStop.SelectedItem)
        serialcom.setPar(cbPar.SelectedItem)

        'Try open Port 
        Try
            serialcom.openPort()
            Form1.Timer1.Start()
            Me.Close()
        Catch ex As Exception
            MsgBox("Cound't Open Port, try again")
        End Try

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPort.Items.Clear()
        cbPort.Items.AddRange(My.Computer.Ports.SerialPortNames.ToArray)
        cbPort.SelectedIndex = 0
        cbBaud.Items.Clear()
        cbBaud.Items.AddRange({"2400", "4800", "9600", "19200", "38400"})
        cbBaud.SelectedIndex = 2
        cbPar.Items.Clear()
        cbPar.Items.AddRange({IO.Ports.Parity.Even, IO.Ports.Parity.None, IO.Ports.Parity.Odd})
        cbPar.SelectedIndex = 1
        cbData.Items.Clear()
        cbData.Items.AddRange({"7", "8"})
        cbData.SelectedIndex = 1
        cbStop.Items.Clear()
        cbStop.Items.AddRange({"1", "2"})
        cbStop.SelectedIndex = 0
        serialcom.closePort()
        Form1.Timer1.Stop()
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.setrs232link()
    End Sub
End Class