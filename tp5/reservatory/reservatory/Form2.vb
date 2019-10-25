Public Class rsview
    Private Sub Rsview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Seiral Probe"
        Label1.Text = "Received on PC"
        TextBox1.Enabled = False
        Label2.Text = "Sended to PLC"
        TextBox2.Enabled = False
    End Sub

End Class