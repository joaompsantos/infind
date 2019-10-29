Module autocontrol
    Private active As Boolean
    Private empty As Boolean

    Friend Sub setActive(ByVal val)
        active = val
    End Sub

    Friend Function getActive()
        Return active
    End Function


    Friend Sub toogleItem(ByVal state, ByVal item)
        opcutils.setItem(item, Not state)
    End Sub

    Friend Sub controltank(ByRef state)

        If Not state(4) Then
            ' If X1 didn't Fire
            toogleItem(False, "Y0")
            toogleItem(False, "Y1")
            empty = True
        End If
        If state(4) And Not empty Then
            ' If X1 but still filling do nothing, so we check if X2 already fired
            toogleItem(False, "Y2")
        End If
        If state(5) Then
            empty = False
            toogleItem(True, "Y0")
            toogleItem(True, "Y1")
        End If

        If state(6) Then
            Form1.Button1.BackColor = Color.Red
            Form1.Button1.Text = " TANK FULL"
        End If
        If Not state(3) Then
            Form1.Button1.BackColor = Color.Red
            Form1.Button1.Text = " TANK EMPTY"
        End If
        If state(3) And Not state(6) Then
            Form1.Button1.BackColor = Color.Green
            Form1.Button1.Text = " All Ok"
        End If
    End Sub

End Module
