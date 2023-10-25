<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.OutClearButton = New System.Windows.Forms.Button()
        Me.InClearButton = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.DataInputLabel = New System.Windows.Forms.Label()
        Me.DataInputClearButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.InTermListBox = New System.Windows.Forms.ListBox()
        Me.OutTermListBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RX2Label = New System.Windows.Forms.Label()
        Me.RXLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TX2Label = New System.Windows.Forms.Label()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AInGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VA1Label = New System.Windows.Forms.Label()
        Me.DA1Label = New System.Windows.Forms.Label()
        Me.ServoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServoTrackBar = New System.Windows.Forms.TrackBar()
        Me.ServoStateLabel = New System.Windows.Forms.Label()
        Me.byte2Label = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AnInCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.DataGroupBox.SuspendLayout()
        Me.AInGroupBox.SuspendLayout()
        Me.ServoGroupBox.SuspendLayout()
        CType(Me.ServoTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(815, 504)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(59, 30)
        Me.QuitButton.TabIndex = 54
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'OutClearButton
        '
        Me.OutClearButton.Location = New System.Drawing.Point(307, 266)
        Me.OutClearButton.Name = "OutClearButton"
        Me.OutClearButton.Size = New System.Drawing.Size(175, 42)
        Me.OutClearButton.TabIndex = 64
        Me.OutClearButton.Text = "Clear data out display"
        Me.OutClearButton.UseVisualStyleBackColor = True
        '
        'InClearButton
        '
        Me.InClearButton.Location = New System.Drawing.Point(553, 266)
        Me.InClearButton.Name = "InClearButton"
        Me.InClearButton.Size = New System.Drawing.Size(190, 40)
        Me.InClearButton.TabIndex = 63
        Me.InClearButton.Text = "clear data in display"
        Me.InClearButton.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PortDataListBox)
        Me.TabPage1.Controls.Add(Me.PortOpenButton)
        Me.TabPage1.Controls.Add(Me.ComPortListBox)
        Me.TabPage1.Controls.Add(Me.BaudRateListBox)
        Me.TabPage1.Controls.Add(Me.ComPortButton)
        Me.TabPage1.Controls.Add(Me.BaudRateButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Serial Connection"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(364, 17)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 61
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(399, 253)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(154, 104)
        Me.PortOpenButton.TabIndex = 60
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(248, 37)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 59
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(77, 22)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 204)
        Me.BaudRateListBox.TabIndex = 58
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(239, 248)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(154, 104)
        Me.ComPortButton.TabIndex = 57
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(93, 253)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(127, 95)
        Me.BaudRateButton.TabIndex = 56
        Me.BaudRateButton.Text = "Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'DataInputLabel
        '
        Me.DataInputLabel.AutoSize = True
        Me.DataInputLabel.Location = New System.Drawing.Point(20, 19)
        Me.DataInputLabel.Name = "DataInputLabel"
        Me.DataInputLabel.Size = New System.Drawing.Size(85, 20)
        Me.DataInputLabel.TabIndex = 70
        Me.DataInputLabel.Text = "Data Input"
        '
        'DataInputClearButton
        '
        Me.DataInputClearButton.Location = New System.Drawing.Point(3, 74)
        Me.DataInputClearButton.Name = "DataInputClearButton"
        Me.DataInputClearButton.Size = New System.Drawing.Size(136, 37)
        Me.DataInputClearButton.TabIndex = 69
        Me.DataInputClearButton.Text = "Clear data input "
        Me.DataInputClearButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 68
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(164, 25)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(113, 60)
        Me.SendButton.TabIndex = 67
        Me.SendButton.Text = "Send Packet"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'InTermListBox
        '
        Me.InTermListBox.FormattingEnabled = True
        Me.InTermListBox.ItemHeight = 20
        Me.InTermListBox.Location = New System.Drawing.Point(532, 19)
        Me.InTermListBox.Name = "InTermListBox"
        Me.InTermListBox.Size = New System.Drawing.Size(211, 244)
        Me.InTermListBox.TabIndex = 66
        '
        'OutTermListBox
        '
        Me.OutTermListBox.FormattingEnabled = True
        Me.OutTermListBox.ItemHeight = 20
        Me.OutTermListBox.Location = New System.Drawing.Point(286, 19)
        Me.OutTermListBox.Name = "OutTermListBox"
        Me.OutTermListBox.Size = New System.Drawing.Size(226, 244)
        Me.OutTermListBox.TabIndex = 65
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGroupBox)
        Me.TabPage2.Controls.Add(Me.AInGroupBox)
        Me.TabPage2.Controls.Add(Me.ServoGroupBox)
        Me.TabPage2.Controls.Add(Me.DataInputLabel)
        Me.TabPage2.Controls.Add(Me.DataInputClearButton)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.SendButton)
        Me.TabPage2.Controls.Add(Me.InTermListBox)
        Me.TabPage2.Controls.Add(Me.OutTermListBox)
        Me.TabPage2.Controls.Add(Me.OutClearButton)
        Me.TabPage2.Controls.Add(Me.InClearButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Loop Back Test"
        '
        'DataGroupBox
        '
        Me.DataGroupBox.Controls.Add(Me.Label4)
        Me.DataGroupBox.Controls.Add(Me.RX2Label)
        Me.DataGroupBox.Controls.Add(Me.RXLabel)
        Me.DataGroupBox.Controls.Add(Me.Label3)
        Me.DataGroupBox.Controls.Add(Me.Label2)
        Me.DataGroupBox.Controls.Add(Me.TX2Label)
        Me.DataGroupBox.Controls.Add(Me.TXLabel)
        Me.DataGroupBox.Controls.Add(Me.Label8)
        Me.DataGroupBox.Location = New System.Drawing.Point(284, 309)
        Me.DataGroupBox.Name = "DataGroupBox"
        Me.DataGroupBox.Size = New System.Drawing.Size(459, 141)
        Me.DataGroupBox.TabIndex = 216
        Me.DataGroupBox.TabStop = False
        Me.DataGroupBox.Text = "RX TX Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "Data RX from Pic"
        '
        'RX2Label
        '
        Me.RX2Label.AutoSize = True
        Me.RX2Label.Location = New System.Drawing.Point(338, 115)
        Me.RX2Label.Name = "RX2Label"
        Me.RX2Label.Size = New System.Drawing.Size(66, 20)
        Me.RX2Label.TabIndex = 221
        Me.RX2Label.Text = "RXHEX"
        '
        'RXLabel
        '
        Me.RXLabel.AutoSize = True
        Me.RXLabel.Location = New System.Drawing.Point(338, 64)
        Me.RXLabel.Name = "RXLabel"
        Me.RXLabel.Size = New System.Drawing.Size(32, 20)
        Me.RXLabel.TabIndex = 220
        Me.RXLabel.Text = "RX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = " Data Hex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = " Data Decimal"
        '
        'TX2Label
        '
        Me.TX2Label.AutoSize = True
        Me.TX2Label.Location = New System.Drawing.Point(132, 115)
        Me.TX2Label.Name = "TX2Label"
        Me.TX2Label.Size = New System.Drawing.Size(63, 20)
        Me.TX2Label.TabIndex = 217
        Me.TX2Label.Text = "TXHEX"
        '
        'TXLabel
        '
        Me.TXLabel.AutoSize = True
        Me.TXLabel.Location = New System.Drawing.Point(132, 64)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(29, 20)
        Me.TXLabel.TabIndex = 216
        Me.TXLabel.Text = "TX"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "Data TX to Pic"
        '
        'AInGroupBox
        '
        Me.AInGroupBox.Controls.Add(Me.AnInCheckBox)
        Me.AInGroupBox.Controls.Add(Me.Label6)
        Me.AInGroupBox.Controls.Add(Me.Label5)
        Me.AInGroupBox.Controls.Add(Me.VA1Label)
        Me.AInGroupBox.Controls.Add(Me.DA1Label)
        Me.AInGroupBox.Location = New System.Drawing.Point(14, 295)
        Me.AInGroupBox.Name = "AInGroupBox"
        Me.AInGroupBox.Size = New System.Drawing.Size(237, 149)
        Me.AInGroupBox.TabIndex = 209
        Me.AInGroupBox.TabStop = False
        Me.AInGroupBox.Text = "Analog  Input"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Voltage In"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Binary In"
        '
        'VA1Label
        '
        Me.VA1Label.AutoSize = True
        Me.VA1Label.Location = New System.Drawing.Point(62, 109)
        Me.VA1Label.Name = "VA1Label"
        Me.VA1Label.Size = New System.Drawing.Size(44, 20)
        Me.VA1Label.TabIndex = 209
        Me.VA1Label.Text = "VA1 "
        '
        'DA1Label
        '
        Me.DA1Label.AutoSize = True
        Me.DA1Label.Location = New System.Drawing.Point(136, 109)
        Me.DA1Label.Name = "DA1Label"
        Me.DA1Label.Size = New System.Drawing.Size(45, 20)
        Me.DA1Label.TabIndex = 213
        Me.DA1Label.Text = "DA1 "
        '
        'ServoGroupBox
        '
        Me.ServoGroupBox.Controls.Add(Me.Label1)
        Me.ServoGroupBox.Controls.Add(Me.ServoTrackBar)
        Me.ServoGroupBox.Controls.Add(Me.ServoStateLabel)
        Me.ServoGroupBox.Controls.Add(Me.byte2Label)
        Me.ServoGroupBox.Location = New System.Drawing.Point(14, 127)
        Me.ServoGroupBox.Name = "ServoGroupBox"
        Me.ServoGroupBox.Size = New System.Drawing.Size(249, 162)
        Me.ServoGroupBox.TabIndex = 210
        Me.ServoGroupBox.TabStop = False
        Me.ServoGroupBox.Text = "Servo Control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Servo Control 0- 21"
        '
        'ServoTrackBar
        '
        Me.ServoTrackBar.Location = New System.Drawing.Point(6, 56)
        Me.ServoTrackBar.Maximum = 21
        Me.ServoTrackBar.Name = "ServoTrackBar"
        Me.ServoTrackBar.Size = New System.Drawing.Size(237, 69)
        Me.ServoTrackBar.TabIndex = 55
        '
        'ServoStateLabel
        '
        Me.ServoStateLabel.AutoSize = True
        Me.ServoStateLabel.Location = New System.Drawing.Point(6, 128)
        Me.ServoStateLabel.Name = "ServoStateLabel"
        Me.ServoStateLabel.Size = New System.Drawing.Size(38, 20)
        Me.ServoStateLabel.TabIndex = 72
        Me.ServoStateLabel.Text = "Dec"
        '
        'byte2Label
        '
        Me.byte2Label.AutoSize = True
        Me.byte2Label.Location = New System.Drawing.Point(200, 128)
        Me.byte2Label.Name = "byte2Label"
        Me.byte2Label.Size = New System.Drawing.Size(37, 20)
        Me.byte2Label.TabIndex = 73
        Me.byte2Label.Text = "Hex"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 486)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(807, 453)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(807, 453)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AnInCheckBox
        '
        Me.AnInCheckBox.AutoSize = True
        Me.AnInCheckBox.Location = New System.Drawing.Point(27, 25)
        Me.AnInCheckBox.Name = "AnInCheckBox"
        Me.AnInCheckBox.Size = New System.Drawing.Size(180, 24)
        Me.AnInCheckBox.TabIndex = 223
        Me.AnInCheckBox.Text = "Enable Analog Input"
        Me.AnInCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 546)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Lab 9 "
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.DataGroupBox.ResumeLayout(False)
        Me.DataGroupBox.PerformLayout()
        Me.AInGroupBox.ResumeLayout(False)
        Me.AInGroupBox.PerformLayout()
        Me.ServoGroupBox.ResumeLayout(False)
        Me.ServoGroupBox.PerformLayout()
        CType(Me.ServoTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QuitButton As Button
    Friend WithEvents OutClearButton As Button
    Friend WithEvents InClearButton As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents DataInputLabel As Label
    Friend WithEvents DataInputClearButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents InTermListBox As ListBox
    Friend WithEvents OutTermListBox As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ServoTrackBar As TrackBar
    Friend WithEvents byte2Label As Label
    Friend WithEvents ServoStateLabel As Label
    Friend WithEvents AInGroupBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents VA1Label As Label
    Friend WithEvents DA1Label As Label
    Friend WithEvents ServoGroupBox As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RX2Label As Label
    Friend WithEvents RXLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TX2Label As Label
    Friend WithEvents TXLabel As Label
    Friend WithEvents AnInCheckBox As CheckBox
End Class
