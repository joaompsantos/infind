Module opcutils

    ' OPC Server Instance
    Private opc As New FaconSvr.FaconServer

    ' OPC Configuration File
    Private configFile As String

    'Configuration File Flag
    Private config As Boolean

    ' PLC Location
    Private plc As String = "Channel0.Station0.Group0"

    ' Connection Status Flag
    Private linked As Boolean = False


    ''' <summary>
    ''' 
    ''' </summary>
    Friend Sub loadconfig()
        Dim opendialog As OpenFileDialog = New OpenFileDialog
        Dim result As DialogResult

        result = opendialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            configFile = opendialog.FileName
            setvalidconf()
        End If

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    Friend Sub setvalidconf()
        config = True
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    Friend Function getvalidconf() As Boolean
        Return config
    End Function


    ''' <summary>
    ''' Establish Connection with designated OPC Server
    ''' </summary>
    Friend Sub connectOPC()
        If config Then
            Try
                opc.OpenProject(configFile)
                opc.Connect()
                linked = True
            Catch ex As Exception
                MsgBox("Something Bad Happened While Connectiong to OPC")
            End Try
        Else
            MsgBox("Please choose File!!!")
        End If
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Friend Function opclinked() As Boolean
        Return linked
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Friend Function getPLC() As String
        Return plc
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    Friend Sub disconnect()
        If linked Then
            opc.Disconnect()
        End If
    End Sub


    ''' <summary>
    ''' Sets the value of the desired PLC output pin
    ''' </summary>
    ''' <param name="item">PLC Output Pin</param>
    ''' <param name="val">Pin Value</param>
    Friend Sub setItem(ByVal item As String, ByVal val As Boolean)
        Select Case item
            Case "Y0"
                opc.SetItem(plc, "Y0", CInt(val))
            Case "Y1"
                opc.SetItem(plc, "Y1", CInt(val))
            Case "Y2"
                opc.SetItem(plc, "Y2", CInt(val))
        End Select
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="item"></param>
    ''' <returns></returns>
    Friend Sub getItem(ByVal item As String, ByRef out As Boolean)
        Select Case item
            Case "Y0"
                out = opc.GetItem(plc, "Y0")
            Case "Y1"
                out = opc.GetItem(plc, "Y1")
            Case "Y2"
                out = opc.GetItem(plc, "Y2")
            Case "X0"
                out = opc.GetItem(plc, "X0")
            Case "X1"
                out = opc.GetItem(plc, "X1")
            Case "X2"
                out = opc.GetItem(plc, "X2")
            Case "X3"
                out = opc.GetItem(plc, "X3")
        End Select

    End Sub

    Friend Sub getLevel(ByRef out As String)
        out = opc.GetItem(plc, "D300")
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="state"></param>
    Friend Sub readItems(ByRef state As Boolean(), ByRef level As String)
        getItem("Y0", state(0))
        getItem("Y1", state(1))
        getItem("Y2", state(2))
        getItem("X0", state(3))
        getItem("X1", state(4))
        getItem("X2", state(5))
        getItem("X3", state(6))
        getLevel(level)
    End Sub

End Module
