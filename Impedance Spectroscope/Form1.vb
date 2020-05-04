Imports System.Math
Imports System.IO.Ports

Public Class Form1
    Dim measurement As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendCommand(Commands.CMD_SET_CH1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SendCommand(Commands.CMD_SET_CH2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendCommand(Commands.CMD_SET_CH3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SendCommand(Commands.CMD_SET_CH4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SendCommand(Commands.CMD_SET_CH5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SendCommand(Commands.CMD_SET_CH6)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Function RefreshState() As String

        Dim stateString As String

        If SerialPort1.IsOpen Then
            Dim cmd2() As Byte = {120, 13}
            SerialPort1.Write(cmd2, 0, 2)
            stateString = SerialPort1.ReadLine()
            Label5.Text = stateString

        End If

        If (stateString(1) = "1") Then
            Button1.BackColor = Color.Green
        Else
            Button1.BackColor = Color.White
        End If

        If (stateString(2) = "1") Then
            Button2.BackColor = Color.Green
        Else
            Button2.BackColor = Color.White
        End If

        If (stateString(3) = "1") Then
            Button3.BackColor = Color.Green
        Else
            Button3.BackColor = Color.White
        End If

        If (stateString(4) = "1") Then
            Button4.BackColor = Color.Green
        Else
            Button4.BackColor = Color.White
        End If

        If (stateString(5) = "1") Then
            Button5.BackColor = Color.Green
        Else
            Button5.BackColor = Color.White
        End If

        If (stateString(6) = "1") Then
            Button6.BackColor = Color.Green
        Else
            Button6.BackColor = Color.White
        End If

        If (stateString(7) = "1") Then
            Button13.BackColor = Color.Green
        Else
            Button13.BackColor = Color.White
        End If

        If (stateString(8) = "1") Then
            Button14.BackColor = Color.Green
        Else
            Button14.BackColor = Color.White
        End If

        If (stateString(9) = "1") Then
            Button15.BackColor = Color.Green
        Else
            Button15.BackColor = Color.White

        End If
        If (stateString(10) = "1") Then
            Button12.BackColor = Color.Green
        Else
            Button12.BackColor = Color.White
        End If

        If (stateString(0) = "1") Then
            Button11.BackColor = Color.Red
            Button11.Text = "Measurement running"
        Else
            Button11.BackColor = Color.Green
            Button11.Text = "Measurement stopped"
        End If

        Return stateString

    End Function

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click

        SerialPort1.Close()
        SerialPort1.PortName = TextBox1.Text
        ' AddHandler SerialPort1.DataReceived, AddressOf DataReceivedHandler
        SerialPort1.Open()

        If SerialPort1.IsOpen Then
            ErrorProvider1.Clear()
            Dim cmd() As Byte = {97, 13}
            SerialPort1.Write(cmd, 0, 2)
            Dim v As String
            v = SerialPort1.ReadLine()
            Label1.Text = v
        End If

        RefreshState()

    End Sub

    Private Sub StartFreq_Click(sender As Object, e As EventArgs) Handles StartFreq.Click
        SendValue(Commands.CMD_RECIEVE_STARTFREQ, TextBox3.Text)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'SendCommand(Commands.CMD_START_MEAS)
        Dim stat As String

        If SerialPort1.IsOpen Then
            Dim cmd() As Byte = {Commands.CMD_DO_SWEEP, 13}
            SerialPort1.Write(cmd, 0, 2)
            stat = SerialPort1.ReadLine()
            Label2.Text = stat
        Else
            ErrorProvider1.SetError(Button6, "Serial port not open!")
        End If

        Dim fields() As String = Split(stat, ",")

        If fields(0) = "DATA" Then

            Dim real As Integer = CInt(fields(2))
            Dim imag As Integer = CInt(fields(4))

            Label10.Text = real
            Label11.Text = imag

            Me.Chart1.Series("Impedancia").Points.AddXY(real, imag)
        End If
    End Sub

    Function GetData()

        Dim data As String
        Dim stat As String

        'While (data <> "CMD_STOP_MEAS")
        Dim cmd() As Byte = {Commands.CMD_DO_SWEEP, 13}
        SerialPort1.Write(cmd, 0, 2)
        stat = SerialPort1.ReadLine()
        If stat = "DATA:" Then
            data = SerialPort1.ReadLine()

            Dim fields() As String = Split(data, ",")
            Dim real As Integer = CInt(fields(1))
            Dim imag As Integer = CInt(fields(3))

            Label10.Text = real
            Label11.Text = imag

            Me.Chart1.Series("Impedancia").Points.AddXY(real, imag)
        ElseIf stat = "MEASUREMENT_RUNNING" Then
            Label2.Text = "MEASUREMENT_RUNNING"
        ElseIf stat = "STATUS_SWEEP_DONE" Then
            Dim cmd1() As Byte = {Commands.CMD_STOP_MEAS, 13}
            SerialPort1.Write(cmd1, 0, 2)
        End If

        'End While

        'Dim data As String
        'data = SerialPort1.ReadLine()

    End Function

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)

        For index As Integer = 0 To 3140 * 2

        Next

    End Sub
    Enum Commands As Byte
        CMD_GETSTATE = 120
        CMD_IDN = 97
        CMD_START_MEAS = 101
        CMD_STOP_MEAS = 100
        CMD_SET_CH1 = 49
        CMD_SET_CH2 = 50
        CMD_SET_CH3 = 51
        CMD_SET_CH4 = 52
        CMD_SET_CH5 = 53
        CMD_SET_CH6 = 54
        CMD_SET_RFB_100R = 55
        CMD_SET_RFB_1k = 56
        CMD_SET_RFB_10k = 57
        CMD_SET_Rin = 48
        CMD_SET_GAIN = 103
        CMD_RECIEVE_STARTFREQ = 105
        CMD_RECIEVE_INCREMENTS = 106
        CMD_RECIEVE_NUMBERINCREMENTS = 107
        CMD_RECIEVE_SETTLING = 108
        CMD_DO_SWEEP = 104
    End Enum
    Function SendCommand(command As Commands)
        If SerialPort1.IsOpen Then
            Dim cmd() As Byte = {command, 13}
            SerialPort1.Write(cmd, 0, 2)
            Label2.Text = SerialPort1.ReadLine()
        Else
            ErrorProvider1.SetError(Button6, "Serial port not open!")
            Return -1
        End If
        RefreshState()
        Return 0
    End Function

    Function SendValue(command As Commands, value As Integer)

        Dim cmd() As Byte = {command}
        SerialPort1.Write(cmd, 0, 1)
        SerialPort1.WriteLine(value)
        Dim newline() As Byte = {13}
        SerialPort1.Write(newline, 0, 1)
        Label2.Text = SerialPort1.ReadLine()
        RefreshState()
        Return 0
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SendCommand(Commands.CMD_SET_GAIN)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        SendCommand(Commands.CMD_SET_RFB_100R)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        SendCommand(Commands.CMD_SET_RFB_1k)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        SendCommand(Commands.CMD_SET_RFB_10k)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SendValue(Commands.CMD_RECIEVE_NUMBERINCREMENTS, TextBox4.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SendValue(Commands.CMD_RECIEVE_INCREMENTS, TextBox5.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SendValue(Commands.CMD_RECIEVE_SETTLING, TextBox6.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'SendCommand(Commands.CMD_START_MEAS)
        Dim stateloc As String
        Dim stat As String

        If SerialPort1.IsOpen Then
            Dim cmd() As Byte = {Commands.CMD_DO_SWEEP, 13}
            SerialPort1.Write(cmd, 0, 2)
            stat = SerialPort1.ReadLine()
            Label2.Text = stat

        Else
            ErrorProvider1.SetError(Button6, "Serial port not open!")
        End If

        stateloc = RefreshState()
        Dim fields() As String = Split(stat, ",")

        If fields(0) = "DATA" And stateloc(0) = "1" Then

            Dim real As Integer = CInt(fields(2))
            Dim imag As Integer = CInt(fields(4))

            Label10.Text = real
            Label11.Text = imag

            Me.Chart1.Series("Impedancia").Points.AddXY(real, imag)
        End If


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        SendCommand(Commands.CMD_START_MEAS)
        Timer1.Enabled = True
    End Sub
End Class