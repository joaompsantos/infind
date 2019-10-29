Imports System.Net

Public Class Form1
    Dim ip_address As IPAddress = IPAddress.Parse("127.0.0.1")

    Dim client As New Sockets.TcpClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClock.Alignment = ToolStripItemAlignment.Right
        btnConnection.Text = "Connect " + ip_address.ToString()
        setUI(False)

    End Sub

    Private Sub trkPump_ValueChanged(sender As Object, e As EventArgs) Handles trkPump.ValueChanged
        txtPump1.Text = CStr(trkPump.Value)
    End Sub

    Private Sub BtnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click

        If Not client.Connected Then

            lblStatus.Text = "Connecting to Server"
            addlog("Connecting ...")
            Try
                client.Connect(ip_address, 81)
                lblStatus.Text = "Connected"
                btnConnection.Text = "Disconnect " + ip_address.ToString()
                setUI(True)
                addlog("Connected")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                lblStatus.Text = "Not Connected"
                addlog("Attempt Failed ...")
            End Try

        Else
            lblStatus.Text = "Disconnecting to Server"
            addlog("Disconnecting ...")
            Try
                client.Close()
                lblStatus.Text = "Disconnected"
                btnConnection.Text = "Connect " + ip_address.ToString()
                addlog("Connection Closed")
                setUI(False)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                lblStatus.Text = "Connected"
                addlog("Disconnect Failed ...")
            End Try

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Now.Date.ToString("yyyy/mm/dd")
    End Sub

    Private Sub setUI(ByVal lock As Boolean)
        chkY0.Enabled = lock
        chkY1.Enabled = lock
        chkY2.Enabled = lock
        trkPump.Enabled = lock
        txtPump1.Enabled = lock
    End Sub

    Private Sub addlog(ByVal str As String)
        txtLog.Text = txtLog.Text + vbCrLf + Date.Now.ToString("hh:mm:ss") + ": " + str
    End Sub

    Private Sub controlchanged(sender As Object, e As EventArgs) Handles chkY0.CheckedChanged, chkY1.CheckedChanged, chkY2.CheckedChanged, txtPump1.TextChanged

        Dim buffer(5) As Byte
        Dim msg As Sockets.NetworkStream

        If client.Connected() Then
            buffer(0) = chkY0.CheckState + 48
            buffer(1) = chkY1.CheckState + 48
            buffer(2) = chkY2.CheckState + 48
            buffer(3) = CInt(txtPump1.Text)
            msg = client.GetStream()
            msg.Write(buffer, 0, 4)
        End If

    End Sub
End Class
