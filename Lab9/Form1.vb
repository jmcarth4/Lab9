
'Jessica McArthur 
'Lab 9 GUI 
'Serial Communication with PIC 16f883
'27 Oct 2023

Public Class Form1
    Dim portState As Boolean                     'Enable serial port
    Dim receiveByte(18) As Byte                  'Receive Data Bytes
    Public dataOut As String                     'Sends data out for loop back test
    Dim receiveCount, TransmitCount As Double    'Used to receive and transmit asynchronous
    Dim newData As Integer
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer
    Dim TXData(3) As Byte                       'Byte array to transmit data
    Dim byte2 As String                         'decmial value of byte 2
    Dim vOut As String                          'Calculated voltage in for ADC input
    Dim dOut As String                          'Calculated binary in for ADC input  
    Dim tOut As String                          'Calculated temperature out for temperature sensor

    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub

    'Loads serial settings when load the form and sets RX and TX controls to 0 or off
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServoTrackBar.Value = 0
        AnInCheckBox.Checked = False
        TempLabel.Text = Chr(176) & Chr(70)            'Displays "°F" 
        TempCheckBox.Checked = False
        VA1Label.Text = "0"
        DA1Label.Text = "0"
        'Clears old Com Ports
        portState = False                              'Disables serial port
        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity
        Timer1.Enabled = True                          'timer set to 100 ms
    End Sub

    'Finds and list all com ports present on the system
    Private Sub ComPortButton_Click(sender As Object, e As EventArgs) Handles ComPortButton.Click
        ComPortListBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortListBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
    End Sub

    'Activates selected comport
    Private Sub PortOpenButton_Click(sender As Object, e As EventArgs) Handles PortOpenButton.Click
        If PortOpenButton.Text = "Connect" Then                     'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                PortOpenButton.Text = "Disconnect"                  'Displays that con port is connected
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                PortOpenButton.Text = "Connect"
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            PortOpenButton.Text = "Connect"
        End If
    End Sub

    'Displays serial port data in a list box for loop back test. Sends tx signal when using ADC of PIC
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        dataIn = ""
        PortDataListBox.Items.Clear()
        PortDataListBox.Items.Add("Com port = " & SerialPort1.PortName)  'Show current baud rate
        PortDataListBox.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'Show current baud rate
        PortDataListBox.Items.Add("Data bits = " & SerialPort1.DataBits)
        PortDataListBox.Items.Add("Stop bits = " & SerialPort1.StopBits)
        PortDataListBox.Items.Add("Parity = " & SerialPort1.Parity)

        If portState = True Then   'Only send data when com port is connected
            AnalogIn()   'Transmit and receive data from ADC
        End If

        'updates output listbox
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer

        If newData > 0 Then                             'Test newData if >0 there is information to display
            Select Case newData
                Case = 8
                    inPut8 = dataIn8
                    newData -= 1
            End Select
            Select Case newData
                Case = 7
                    inPut7 = dataIn7
                    newData -= 1
            End Select
            Select Case newData
                Case = 6
                    inPut6 = dataIn6
                    newData -= 1
            End Select
            Select Case newData
                Case = 5
                    inPut5 = dataIn5
                    newData -= 1
            End Select
            Select Case newData
                Case = 4
                    inPut4 = dataIn4
                    newData -= 1
            End Select
            Select Case newData
                Case = 3
                    inPut3 = dataIn3
                    newData -= 1
            End Select
            Select Case newData
                Case = 2
                    inPut2 = dataIn2
                    newData -= 1
            End Select
            Select Case newData
                Case = 1
                    inPut1 = dataIn1
                    newData -= 1
            End Select
            'Update input listbox with new data
            InTermListBox.Items.Add(Chr(inPut1) & Chr(inPut2) & Chr(inPut3) & Chr(inPut4) & Chr(inPut5) & Chr(inPut6) & Chr(inPut7) & Chr(inPut8))
            'Load input from PIC into display labels
            'Handshakes displayed as ascii characters
            'One label shows other data in decimal values the other as hex 
            RXLabel.Text = Chr(inPut1) & " " & inPut2 & " " & Chr(inPut3) & " " & inPut4 & " " & inPut5
            RX2Label.Text = Chr(inPut1) & " " & Hex(inPut2) & " " & Chr(inPut3) & " " & Hex(inPut4) & " " & Hex(inPut5)
        End If
    End Sub

    'Connects com port in list box index
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortListBox.SelectedIndexChanged
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

        PortOpenButton.Text = "Connect"
        portState = False
        Try
            SerialPort1.BaudRate = ComPortListBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortListBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub

    'Loads baud rate values into list box
    'Not used in this code
    Private Sub BaudRateButton_Click(sender As Object, e As EventArgs) Handles BaudRateButton.Click
        BaudRateListBox.Items.Clear()                          'Clear list box and load baud rate values
        BaudRateListBox.Items.Add(1200)
        BaudRateListBox.Items.Add(2400)
        BaudRateListBox.Items.Add(4800)
        BaudRateListBox.Items.Add(9600)
        BaudRateListBox.Items.Add(19200)
        BaudRateListBox.Items.Add(38400)
        BaudRateListBox.Items.Add(57600)
        BaudRateListBox.Items.Add(115200)
        BaudRateListBox.Items.Add(230400)
        BaudRateListBox.Items.Add(230400)
        BaudRateListBox.Items.Add(460800)
        BaudRateListBox.Items.Add(921600)
    End Sub

    'Send all characters in list box (for loopback test)
    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Timer1.Enabled = False                                      'Stop Timer
        Dim dataLen, TXCount As Integer
        dataLen = Len(TextBox1.Text)                'Get number of characters in Textbox

        dataOut = TextBox1.Text

        If portState = True Then
            If TextBox1.Text IsNot "" Then                          'Test for null characters
                Do Until TXCount = dataLen                          'Do once for each character
                    If SerialPort1.BytesToWrite = 0 Then
                        'grab Character x using the TXCount as an index pointer
                        dataOut = TextBox1.Text.ElementAt(TXCount)
                        SerialPort1.Write(dataOut)     'Sends Character x out
                        TXCount += 1                   'Increment loop count info
                    End If
                Loop
                TransmitCount += dataLen                    'Save total bytes send info
                OutTermListBox.Items.Add(TextBox1.Text)     'Update output list box
                TXLabel.Text = TextBox1.Text
            Else
                Timer1.Enabled = True                       'Restart timer
                Exit Sub
            End If

        Else
            MsgBox("Please configure and open serial port to procede")  'Failure if port is not open
            'TextBox1.Text = " "
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub ServoTrackBar_Scroll_1(sender As Object, e As EventArgs) Handles ServoTrackBar.Scroll
        ServoStateLabel.Text = ServoTrackBar.Value    'Displays value of track bar
        byte2Label.Text = Hex(ServoTrackBar.Value)    'Displays hex equalient of track bar value
        byte2 = ServoTrackBar.Value                   'Sets value of byte to TX
        'Loads handshake, one byte of data and null character into TX array
        'Handshake = $ (ascii decimal equalient of 36)
        'Decimal values are loaded into byte array
        'Byte array converts numbers to hex.
        TXData = {36, CInt(byte2), 0}
        'Display send data to text box in loop back test
        TextBox1.Text = TXData(0) & TXData(1) & TXData(2)
        'Call sub to send data
        SendData()
    End Sub

    'Establishes communication and displays received data from the ADC
    Sub AnalogIn()
        'ADC input enabled with checkbox
        If AnInCheckBox.Checked = True Then
            'Loads handshake, one byte of data and ADC handshake into TX array
            'Handshake = $ (ascii decimal equalient of 36)
            'ADC handshake = # (ascii decimal equalient of 35)
            'Decimal values are loaded into byte array
            'Byte array converts numbers to hex.
            TXData = {36, CInt(byte2), 35}
            'Display send data to text box in loop back test
            TextBox1.Text = TXData(0) & TXData(1) & TXData(2)
            'Call sub to send data
            SendData()
            'Call sub to convert RX data from PIC to Voltages and number of bits
            AnVoltage()

            VA1Label.Text = vOut                   'Display input voltage of ADC (0-5V)
            DA1Label.Text = dOut                   'Display recieved binary value (0-1023)
            'Display temperature from temperature sensor when check box is true
            If TempCheckBox.Checked = True Then
                TempLabel.Text = tOut & Chr(176) & Chr(70)   'Displays temperature and "°F" 
            ElseIf TempCheckBox.Checked = False Then
                TempLabel.Text = Chr(176) & Chr(70)   'Displays "°F" 
            End If
        End If
    End Sub

    'Converts received bytes 4 and 5 from PIC
    'Calculations for ADC input and output and temperature sensor
    Sub AnVoltage()
        Dim vPort As Double             'Variables to manipulate received data
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        Dim n4 As Double

        n1 = dataIn4 * 4                'RX high byte multipled by 4 
        n2 = dataIn5 / 64               'RX low byte is divided by 64
        n3 = Fix(n1 + n2)               'Limits number to 2 decimal places
        n4 = 5 / 1023                   'Resolution of ADC
        vPort = n4 * n3                 'Calculates voltage in of ADC
        vOut = Format(vPort, "n")       'Format results to 2 decimal palces 
        dOut = n3                       'Result of bits out of ADC
        tOut = vOut / 0.01              'Calculates temperature from ADC input voltage
    End Sub

    'Function to tramsmit serial data
    Function SendData() As Byte
        Timer1.Enabled = False                                 'Disable timer when writing to serial port
        If portState = True Then
            SerialPort1.Write(TXData, 0, TXData.Length)        'Write byte array to serial port
            OutTermListBox.Items.Add(TextBox1.Text)            'Update output list box (loopback test)
            'Display content of byte array in labels
            'Handshakes displayed as ascii characters
            'One label shows other data in decimal values the other as hex
            TXLabel.Text = Chr(TXData(0)) & " " & TXData(1) & " " & Chr(TXData(2))
            TX2Label.Text = Chr(TXData(0)) & " " & Hex(TXData(1)) & " " & Chr(TXData(2))
        Else                                                     'Alerts user if com port not connected
            MsgBox("Please configure and open serial port to procede")
        End If
        Timer1.Enabled = True
    End Function

    'Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        receiveCount += 1                                   'Increment recieve byte counter
        SerialPort1.Read(receiveByte, 0, 4)                 'Read serial buffer value

        Select Case newData                                 'Test case to determine where to place info
            Case = 0
                dataIn1 = receiveByte(0)
            Case = 1
                dataIn2 = receiveByte(0)
            Case = 2
                dataIn3 = receiveByte(0)
            Case = 3
                dataIn4 = receiveByte(0)
            Case = 4
                dataIn5 = receiveByte(0)
            Case = 5
                dataIn6 = receiveByte(0)
            Case = 6
                dataIn7 = receiveByte(0)
            Case = 7
                dataIn8 = receiveByte(0)

            Case Else
                newData = 0                                   'Possible over flow, reset newData
                Exit Sub

        End Select
        newData += 1                                          'Increment newData once loop is complete
    End Sub

    'Clears received data list box and labels
    Private Sub InClearButton_Click(sender As Object, e As EventArgs) Handles InClearButton.Click
        InTermListBox.Items.Clear()
        RXLabel.Text = " "
        RX2Label.Text = " "
    End Sub

    'Clears sent data list box and labels
    Private Sub OutClearButton_Click(sender As Object, e As EventArgs) Handles OutClearButton.Click
        OutTermListBox.Items.Clear()
        TXLabel.Text = " "
        TX2Label.Text = " "
    End Sub

    'Clears data input text box
    Private Sub DataInputClearButton_Click(sender As Object, e As EventArgs) Handles DataInputClearButton.Click
        TextBox1.Text = " "
    End Sub

    'Exits Program when button is pressed 
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class




