Module actrl
    Private ctrl As Boolean = False
    Private pump As Boolean = False
    Private vin As Boolean = False
    Private vo As Boolean = False
    Private msg() As Char = "s_ToPLC000_e".ToCharArray()

    Friend Sub setCtrl(ByVal val)
        ctrl = val
    End Sub

    Friend Function getCtrl()
        Return ctrl
    End Function

    Friend Function monitLevel(ByRef outs, ByRef level)
        If Not outs(2) Then
            msg(7) = "1"
            msg(8) = "1"
            msg(9) = "0"
            Form1.TextBox1.Hide()
        Else
            msg(7) = "0"
            msg(8) = "0"
        End If

        If outs(2) Then
            msg(9) = "0"
            Form1.TextBox1.Hide()
        End If

        If Not outs(0) Then
            Form1.TextBox1.Show()
            Form1.TextBox1.Enabled = True
            Form1.TextBox1.Text = "TANK IS EMPTY"
        End If

        If outs(3) Then
            msg(7) = "0"
            msg(8) = "0"
            msg(9) = "1"
            Form1.TextBox1.Show()
            Form1.TextBox1.Enabled = True
            Form1.TextBox1.Text = "TANK IS FULL"
        End If

        Return New String(msg)
    End Function

End Module
