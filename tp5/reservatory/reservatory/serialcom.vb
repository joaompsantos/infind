Module serialcom
    Private serialport As New IO.Ports.SerialPort

    Friend Sub setCom(ByVal com)
        serialport.PortName = com
    End Sub

    Friend Function getCom()
        Return serialport.PortName.ToString
    End Function

    Friend Sub setBaud(ByVal baud)
        serialport.BaudRate = baud
    End Sub

    Friend Function getBaud()
        Return serialport.BaudRate.ToString
    End Function

    Friend Sub setData(ByVal data)
        serialport.DataBits = data
    End Sub

    Friend Function getData()
        Return serialport.DataBits.ToString
    End Function

    Friend Sub setStop(ByVal stb)
        serialport.StopBits = stb
    End Sub

    Friend Function getStop()
        Return serialport.StopBits.ToString
    End Function

    Friend Sub setPar(ByVal par)
        serialport.Parity = par
    End Sub

    Friend Function getPar()
        Return serialport.Parity.ToString
    End Function

    Friend Sub openPort()
        If serialport.IsOpen() Then
            serialport.Close()
        End If
        serialport.Open()
    End Sub

    Friend Sub closePort()
        serialport.Close()
    End Sub

    Friend Function getClose()
        Return Not serialport.IsOpen()
    End Function

    Friend Function getOpen()
        Return serialport.IsOpen()
    End Function

    Friend Function readMessage()
        Return serialport.ReadExisting()
    End Function

    Friend Function decode(ByRef ins, ByRef outs, ByRef level)
        Dim msg = readMessage()
        Dim toHandler As String = New String("")
        Dim head As Short
        Dim foot As Short

        If Len(msg) >= 16 Then
            head = InStr(msg, "s_ToPC")
            foot = InStr(msg, "_e")

            If head = 1 And foot = 15 Then
                ins(0) = CBool(Mid(msg, 7, 1))
                ins(1) = CBool(Mid(msg, 8, 1))
                ins(2) = CBool(Mid(msg, 9, 1))

                outs(0) = CBool(Mid(msg, 10, 1))
                outs(1) = CBool(Mid(msg, 11, 1))
                outs(2) = CBool(Mid(msg, 12, 1))
                outs(3) = CBool(Mid(msg, 13, 1))

                level = Asc(Mid(msg, 14, 1))
                toHandler = Now.ToString + Mid(msg, 1, 16) + vbCrLf
            End If

        End If
        Return toHandler
    End Function

    Friend Sub writemsg(ByVal msg As String)
        If serialport.IsOpen() Then

            Try
                serialport.Write(msg)
            Catch
            End Try
        End If


    End Sub


End Module
