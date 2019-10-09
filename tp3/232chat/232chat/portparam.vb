Module portparam
    Private port As String
    Private baudrate As Integer
    Private parity As IO.Ports.Parity
    Private valid As Boolean = False


    Public Function getPort() As String
        Return port
    End Function

    Public Function getBaud() As Integer
        Return baudrate
    End Function

    Public Function getParity() As IO.Ports.Parity
        Return parity
    End Function

    Public Function getValid() As Boolean
        Return valid
    End Function

    Public Sub setPort(ByVal a As String)
        port = a
    End Sub

    Public Sub setBaud(ByVal a As Integer)
        baudrate = a
    End Sub

    Public Sub setParity(ByVal a As IO.Ports.Parity)
        parity = a
    End Sub

    Public Sub setvalid(ByVal a As Boolean)
        valid = a
    End Sub

    Public Sub configPort(ByRef serialport As IO.Ports.SerialPort)
        serialport.PortName = getPort()
        serialport.BaudRate = getBaud()
        serialport.Parity = getParity()
    End Sub


End Module
