
'Jessica McArthur
'Class example....terminals 
'Lab 9 GUI

'Imports System.Text.RegularExpressions

Public Class Form1
    Dim portState As Boolean
    Dim receiveByte(18) As Byte        'Receive Data Bytes

    Public dataOut As String
    Dim Val, receiveCount, TransmitCount As Double
    Dim newData, readSize As Integer
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer
    Dim TXData(3) As Byte
    Dim byte2 As String
    Dim vOut As String                          'Calculated voltage in for analog inputs
    Dim dOut As String                          'Calculated binary in for analog inputs   


    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub

    'Loads serial settings when load the form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServoTrackBar.Value = 0
        AnInCheckBox.Checked = False
        'Clears old Com Ports
        portState = False                              'Disables serial port

        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity

        Timer1.Enabled = True                           'timer set to 100 ms
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








    'Displays serial port data in a list box
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        dataIn = ""
        PortDataListBox.Items.Clear()
        PortDataListBox.Items.Add("Com port = " & SerialPort1.PortName)  'Show current baud rate
        PortDataListBox.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'Show current baud rate
        PortDataListBox.Items.Add("Data bits = " & SerialPort1.DataBits)
        PortDataListBox.Items.Add("Stop bits = " & SerialPort1.StopBits)
        PortDataListBox.Items.Add("Parity = " & SerialPort1.Parity)


        If portState = True Then
            'Transmit and receive data from analog inputs when radio button enabled
            ' If AnInCheckBox.Checked = True Then
            AnalogIn()

            'End If
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
            RXLabel.Text = Chr(inPut1) & "" & inPut2 & "" & Chr(inPut3) & "" & inPut4 & "" & inPut5 ' & inPut6 & inPut7 & inPut8
            RX2Label.Text = Chr(inPut1) & "" & Hex(inPut2) & "" & Chr(inPut3) & "" & Hex(inPut4) & "" & Hex(inPut5) '& Hex(inPut6) & inPut7 & inPut8
        End If
    End Sub

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




    'Up dated routine to send all characters in list box
    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Timer1.Enabled = False                                  'Stop Timer
        Dim dataLen, TXCount As Integer
        dataLen = Len(TextBox1.Text)   ' get number of characters in Textbox

        dataOut = TextBox1.Text

        If portState = True Then
            If TextBox1.Text IsNot "" Then                         'Test for null characters
                Do Until TXCount = dataLen                          'Do once for each character
                    If SerialPort1.BytesToWrite = 0 Then
                        'grab Character x using the TXCount as an index pointer
                        dataOut = TextBox1.Text.ElementAt(TXCount)
                        SerialPort1.Write(dataOut)     'Sends Character x out
                        TXCount += 1                   'Increment loop count info
                    End If
                Loop
                TransmitCount += dataLen                'Save total bytes send info
                OutTermListBox.Items.Add(TextBox1.Text)     'update output list box
                TXLabel.Text = TextBox1.Text
            Else
                Timer1.Enabled = True  'restart timer
                Exit Sub

            End If

        Else
            MsgBox("Please configure and open serial port to procede")  'Failure if port is not open
            'TextBox1.Text = " "
        End If
        Timer1.Enabled = True


    End Sub


    Private Sub ServoTrackBar_Scroll(sender As Object, e As EventArgs) Handles ServoTrackBar.Scroll
        ' Dim byte2 As String


        ServoStateLabel.Text = ServoTrackBar.Value
        byte2Label.Text = Hex(ServoTrackBar.Value)
        byte2 = ServoTrackBar.Value
        TXData = {36, CInt(byte2), 0}
        'TXData(0) = 36
        'TXData(1) = CInt(byte2)
        'TXData(2) = 0                   'Sends Null


        TextBox1.Text = TXData(0) & TXData(1) & TXData(2)

        SendData()



    End Sub

    'Establishs communication and displays received data from the analog inputs
    Sub AnalogIn()


        If AnInCheckBox.Checked = True Then
            TXData = {36, CInt(byte2), 35}
            'TXData(0) = 36                         'Send command for analog in 1
            'TXData(1) = CInt(byte2)
            'TXData(2) = 35
            TextBox1.Text = TXData(0) & TXData(1) & TXData(2)
            SendData()
            AnVoltage()
            VA1Label.Text = vOut                   'Display input voltage
            DA1Label.Text = dOut                   'Display recieved binary value
            ' PictureBox1.Height = vOut * 20         'Display voltages  picture box level
        End If



    End Sub

    'Converts received byte 1 and 2 to binary value (0 to 1024) and voltage (0 to 3.3)
    Sub AnVoltage()
        Dim vPort As Double             'Variables to manipulate received data
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        Dim n4 As Double

        n1 = dataIn4 * 4
        n2 = dataIn5 / 64
        n3 = Fix(n1 + n2)
        n4 = 3.3 / 1023
        vPort = n4 * n3
        vOut = Format(vPort, "n")
        dOut = n3
    End Sub




    Function SendData() As Byte
        Timer1.Enabled = False                                 'Disable timer when writing to serial port
        If portState = True Then
            SerialPort1.Write(TXData, 0, TXData.Length)                    'Write byte array to serial port
            OutTermListBox.Items.Add(TextBox1.Text)     'update output list box
            'TXLabel.Text = TXData(0) & TXData(1) & TXData(2)   'Value of byte array displayed for user to see
            TXLabel.Text = Chr(TXData(0)) & " " & TXData(1) & " " & Chr(TXData(2))   'Value of byte array displayed for user to see
            TX2Label.Text = Chr(TXData(0)) & " " & Hex(TXData(1)) & " " & Chr(TXData(2))
        Else
            MsgBox("Please configure and open serial port to procede")
        End If
        Timer1.Enabled = True


    End Function


    'Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        'readSize = SerialPort1.BytesToRead

        receiveCount += 1                                           'increment recieve byte counter
        SerialPort1.Read(receiveByte, 0, 4)                         'read serial buffer value

        Select Case newData                                         'test case to determine where to place info
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
                newData = 0                                             'possible over flow, reset newData
                Exit Sub

        End Select
        newData += 1                                                    'Increment newData once loop is complete



    End Sub


    'Clears received data list box
    Private Sub InClearButton_Click(sender As Object, e As EventArgs) Handles InClearButton.Click
        InTermListBox.Items.Clear()
        RXLabel.Text = " "
        RX2Label.Text = " "
    End Sub

    'Clears sent data list box
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




