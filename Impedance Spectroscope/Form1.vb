Imports System.Math
Imports System.IO.Ports
Imports System.Numerics
Imports System.IO


Public Class Form1

    'Globals

    Dim measurementNo As Integer = 0

    Dim gainfactor(1) As Double
    Dim systemPhase(1) As Double

    Dim rawReal(1) As Integer
    Dim rawImag(1) As Integer

    Dim Real(1) As Double
    Dim Imag(1) As Double

    Dim Impedance(1) As Double
    Dim savePhase(1) As Double

    Dim sweepRunning As Boolean

    Dim cal As Boolean = False
    Dim systemCalibrated As Boolean = False

    Dim channel As String = "CH1"
    Dim MUX As Boolean = False

    Dim index As Integer
    Dim timeseries As Integer
    Dim mode As Boolean
    Dim plot As Boolean
    Dim saveEnable As Boolean = False

    Dim strFile As String = "C:\Users\Admin\Desktop\VB_outputs\" & DateTime.Today.ToString("yyyy-MMM-dd") & DateTime.Now.ToString("-HH mm") & ".csv"

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
        CMD_RESET = 114
        CMD_CAL = 116
    End Enum


    Function CalibrationSweep()

    End Function

    Function MeasurementSweep()

    End Function

    Function ConvertToImpedance()

    End Function


    Function csvOutput(path As String)
        Dim sw As StreamWriter

        Try
            If (Not File.Exists(strFile)) Then
                sw = File.CreateText(strFile)
                sw.WriteLine("CHANNEL,INDEX,rawReal,rawImag,REAL,IMAG,IMPEDANCE,PHASE")
            Else
                sw = File.AppendText(strFile)
            End If

            For k As Integer = 0 To measurementNo
                sw.WriteLine(channel & "," & k & "," & rawReal(k) & "," & rawImag(k) & "," & Real(k) & "," & Imag(k) & "," & Impedance(k) & "," & savePhase(k))
            Next

            'TODO: Tömbként átadni ezeket az értzékeket!
            'sw.WriteLine(channel & "," & timeseries & "," & TextBox3.Text & "," & magnitude & "," & real & "," & imag & "," & impedance & "," & gainFactor(0))

            sw.Close()
        Catch ex As IOException
            'Console.WriteLine("Error writing to log file.")
        End Try
    End Function

    'Functions
    Function SendCommand(command As Commands)
        If SerialPort1.IsOpen Then
            Dim cmd() As Byte = {command, 13}
            SerialPort1.Write(cmd, 0, 2)
            Label2.Text = SerialPort1.ReadLine()
        Else
            ErrorProvider1.SetError(Connect, "Serial port not open!")
            Return -1
        End If
        RefreshState()
        Return 0
    End Function

    Function SendValue(command As Commands, value As Integer)

        If SerialPort1.IsOpen Then
            Dim cmd() As Byte = {command}
            SerialPort1.Write(cmd, 0, 1)
            SerialPort1.WriteLine(value)
            Dim newline() As Byte = {13}
            SerialPort1.Write(newline, 0, 1)
            Label2.Text = SerialPort1.ReadLine()
        Else
            ErrorProvider1.SetError(Connect, "Serial port not open!")
            Return -1
        End If
        RefreshState()
        Return 0
    End Function

    Function doMeasurement() As Object

        Dim stat As String = "empty"
        Dim DataValid As Boolean = False
        Dim SweepDone As Boolean = False
        Dim Re As Integer = 0
        Dim Im As Integer = 0

        Dim state As String = RefreshState()

        If state(0) = "0" Then
            SendCommand(Commands.CMD_START_MEAS)
        End If

        If SerialPort1.IsOpen Then

            Dim cmd() As Byte = {Commands.CMD_DO_SWEEP, 13}
            SerialPort1.Write(cmd, 0, 2)
            stat = SerialPort1.ReadLine()
            Label2.Text = stat

        Else
            ErrorProvider1.SetError(Connect, "Serial port not open!")
        End If

        Dim fields() As String = Split(stat, ",")

        Label7.Text = stat

        If fields(0) = "DATA" Then

            DataValid = True
            Re = CInt(fields(2))
            Im = CInt(fields(4))

        ElseIf stat = "NO_RESP" & vbCr Then

            DataValid = False

        ElseIf stat = "MEASUREMENT_RUNNING" & vbCr Then

            DataValid = False

        ElseIf stat = "STATUS_SWEEP_DONE" & vbCr Then

            DataValid = False
            SweepDone = True
            SendCommand(Commands.CMD_STOP_MEAS)
            SendCommand(Commands.CMD_RESET)

        End If

        Return {DataValid, SweepDone, Re, Im}

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendCommand(Commands.CMD_SET_CH1)
        If Not MUX Then
            channel = "CH1"
        Else
            channel += "CH1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SendCommand(Commands.CMD_SET_CH2)
        channel = "CH2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendCommand(Commands.CMD_SET_CH3)
        channel = "CH3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SendCommand(Commands.CMD_SET_CH4)
        channel = "CH4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SendCommand(Commands.CMD_SET_CH5)
        channel = "CH5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SendCommand(Commands.CMD_SET_CH6)
        channel = "CH6"
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

        If MUX Then
            Button17.BackColor = Color.Green
        Else
            Button17.BackColor = Color.White
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

        SendCommand(Commands.CMD_STOP_MEAS)
        Dim state As String = RefreshState()

        Dim fields() As String = Split(state, "-")

        TextBox3.Text = fields(1)
        TextBox5.Text = fields(2)
        TextBox4.Text = fields(3)
        TextBox6.Text = fields(4)


    End Sub

    Private Sub StartFreq_Click(sender As Object, e As EventArgs) Handles StartFreq.Click
        SendValue(Commands.CMD_RECIEVE_STARTFREQ, TextBox3.Text)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.BackColor = Color.Red
        Array.Clear(rawReal, 0, rawReal.Length)
        Array.Clear(rawImag, 0, rawImag.Length)
        Array.Clear(Impedance, 0, Impedance.Length)
        Array.Clear(savePhase, 0, savePhase.Length)



        Array.Resize(rawReal, 1)
        Array.Resize(rawImag, 1)
        Array.Resize(Impedance, 1)
        Array.Resize(savePhase, 1)

        measurementNo = 0

        SendCommand(Commands.CMD_STOP_MEAS)
        Timer1.Enabled = Not Timer1.Enabled

    End Sub

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

        Dim measurementData As Object
        measurementData = doMeasurement() 'Polling instrtument

        If TextBox4.Text > 0 Then



            If measurementData(0) And Not measurementData(1) Then 'data available

                If cal Then 'Do calibration sweep

                    rawReal(rawReal.Length - 1) = measurementData(2)


                    rawImag(rawImag.Length - 1) = measurementData(3)

                    Label19.Text = rawReal.Length

                    Dim magnitude As Double = Sqrt(rawReal(rawReal.Length - 1) * rawReal(rawReal.Length - 1) + rawImag(rawImag.Length - 1) * rawImag(rawImag.Length - 1))

                    gainfactor(gainfactor.Length - 1) = (1 / TextBox2.Text) / magnitude
                    systemPhase(systemPhase.Length - 1) = Atan(rawImag(measurementNo) / rawReal(measurementNo))

                    Label21.Text = measurementNo
                    Label20.Text = systemPhase(measurementNo + 1) - systemPhase(systemPhase.Length - 1)

                    Array.Resize(gainfactor, gainfactor.Length + 1)
                    Array.Resize(systemPhase, systemPhase.Length + 1)
                    Array.Resize(rawReal, rawReal.Length + 1)
                    Array.Resize(rawImag, rawImag.Length + 1)


                    If TextBox4.Text > 0 Then
                        measurementNo += 1

                        If TextBox4.Text > 0 Then
                            ProgressBar1.Visible = True
                            ProgressBar1.Maximum = TextBox4.Text
                            ProgressBar1.Minimum = 0
                            ProgressBar1.Step = 1
                            ProgressBar1.Value = measurementNo
                        Else
                            ProgressBar1.Visible = False
                        End If
                    End If

                Else 'Do measurement sweep


                    Dim Magnitude As Double = Sqrt(measurementData(2) * measurementData(2) + measurementData(3) * measurementData(3))
                    Dim Phase As Double = Atan(measurementData(2) / measurementData(3))
                    Dim Zre As Double
                    Dim Zim As Double

                    If measurementData(2) < 0 And measurementData(3) < 0 Then
                        'Phase = Phase - Math.PI
                    ElseIf measurementData(2) < 0 And measurementData(3) > 0 Then
                        Phase += Math.PI 'itt ugrik
                    ElseIf measurementData(2) > 0 And measurementData(3) < 0 Then
                        Phase += Math.PI
                    End If

                    Phase -= systemPhase(measurementNo)

                    Zre = Magnitude * (Cos(Phase))
                    Zim = Magnitude * (Sin(Phase))

                    Real(Real.Length - 1) = Zre
                    Imag(Imag.Length - 1) = Zim

                    savePhase(savePhase.Length - 1) = Phase
                    Impedance(Impedance.Length - 1) = (1 / (gainfactor(measurementNo + 1) * Magnitude))


                    Label21.Text = Phase


                    Label19.Text = 1 / (gainfactor(measurementNo + 1) * Magnitude)
                    Label20.Text = gainfactor(measurementNo + 1)

                    If plot Then

                        Me.Chart1.Series("Impedancia").Points.AddXY(measurementNo + 1, Impedance(Impedance.Length - 1))

                    Else

                        Me.Chart1.Series("Fázis").Points.AddXY(-Zim, Zre)

                    End If

                    Array.Resize(Real, Real.Length + 1)
                    Array.Resize(Imag, Imag.Length + 1)
                    Array.Resize(savePhase, savePhase.Length + 1)
                    Array.Resize(Impedance, Impedance.Length + 1)

                    If TextBox4.Text > 0 Then


                        measurementNo += 1
                        'Array.Resize(Impedance, Impedance.Length + 1)

                        If TextBox4.Text > 0 Then
                            ProgressBar1.Visible = True
                            ProgressBar1.Maximum = TextBox4.Text
                            ProgressBar1.Minimum = 0
                            ProgressBar1.Step = 1
                            ProgressBar1.Value = measurementNo
                        Else
                            ProgressBar1.Visible = False
                        End If

                    End If

                End If

            ElseIf measurementData(1) Then 'Sweep done
                Timer1.Enabled = False
                measurementNo = 0
                cal = False
                startCal.BackColor = Color.Green
                Button11.BackColor = Color.Green
            End If

        Else 'Continous measurement, fixed freq.

            If measurementData(0) And Not measurementData(1) Then 'data available
                If cal Then 'Do calibration

                    rawReal(0) = measurementData(2)
                    rawImag(0) = measurementData(3)

                    Dim magnitude As Double = Sqrt(rawReal(0) * rawReal(0) + rawImag(0) * rawImag(0))

                    gainfactor(0) = (1 / TextBox2.Text) / magnitude
                    systemPhase(0) = Atan(rawImag(0) / rawReal(0))

                    cal = False

                Else 'Do measurement

                    Dim Magnitude As Double = Sqrt(measurementData(2) * measurementData(2) + measurementData(3) * measurementData(3))
                    Dim Phase As Double = Atan(measurementData(2) / measurementData(3))
                    Dim Zre As Double
                    Dim Zim As Double

                    If measurementData(2) < 0 And measurementData(3) < 0 Then
                        'Phase = Phase - Math.PI
                    ElseIf measurementData(2) < 0 And measurementData(3) > 0 Then
                        Phase += Math.PI 'itt ugrik
                    ElseIf measurementData(2) > 0 And measurementData(3) < 0 Then
                        Phase += Math.PI
                    End If

                    Phase -= systemPhase(measurementNo)

                    Zre = Magnitude * (Cos(Phase))
                    Zim = Magnitude * (Sin(Phase))

                    Real(Real.Length - 1) = Zre
                    Array.Resize(Real, Real.Length + 1)
                    Imag(Imag.Length - 1) = Zim
                    Array.Resize(Imag, Imag.Length + 1)
                    savePhase(savePhase.Length - 1) = Phase
                    Array.Resize(savePhase, savePhase.Length + 1)
                    Impedance(Impedance.Length - 1) = 1 / (gainfactor(0) * Magnitude)
                    Array.Resize(Impedance, Impedance.Length + 1)



                    Label19.Text = 1 / (gainfactor(measurementNo) * Magnitude)
                    Label20.Text = gainfactor(measurementNo)

                    If plot Then

                        Me.Chart1.Series("Impedancia").Points.AddXY(measurementNo, Impedance(Impedance.Length - 1))

                    Else

                        Me.Chart1.Series("Fázis").Points.AddXY(-Zim, Zre)

                    End If

                End If

            End If

            End If

        'End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        SendCommand(Commands.CMD_START_MEAS)
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub startCal_Click_1(sender As Object, e As EventArgs) Handles startCal.Click
        cal = Not cal
        Button11.Enabled = True

        Array.Clear(rawReal, 0, rawReal.Length)
        Array.Clear(rawImag, 0, rawImag.Length)
        Array.Resize(rawReal, 1)
        Array.Resize(rawImag, 1)
        measurementNo = 0

        If cal Then

            startCal.BackColor = Color.Red

            SendCommand(Commands.CMD_STOP_MEAS)
            Timer1.Enabled = Not Timer1.Enabled

        Else
            startCal.BackColor = Color.Green
            Timer1.Enabled = False
            Button11.Enabled = True
        End If

    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        SendCommand(Commands.CMD_RESET)
        Timer1.Enabled = False
        Array.Clear(rawReal, 0, rawReal.Length)
        Array.Clear(rawImag, 0, rawImag.Length)
        Array.Resize(rawReal, 1)
        Array.Resize(rawImag, 1)
        measurementNo = 0

        Me.Chart1.Series("Impedancia").Points.Clear()
        Me.Chart1.Series("Fázis").Points.Clear()

    End Sub

    Private Sub plottype_click(sender As Object, e As EventArgs) Handles plottype.Click

        If plot Then
            plottype.Text = "TIMESERIES"
            plot = False
        Else
            plottype.Text = "CPLX"
            plot = True
        End If

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If mode Then
            Button19.Text = "Timeseries"
            mode = False
        Else
            Button19.Text = "Spectroscope"
            SendValue(Commands.CMD_RECIEVE_NUMBERINCREMENTS, 0)
            mode = True
        End If
    End Sub

    Private Sub saveClick(sender As Object, e As EventArgs) Handles save.Click


        'csvOutput(Path)

        SaveFileDialog1.Filter = "csv Files (*.csv*)|*.csv"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, "CHANNEL,INDEX,rawReal,rawImag,REAL,IMAG,IMPEDANCE,PHASE" & vbCrLf, True)

            For k As Integer = 0 To savePhase.Length - 1
                My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, channel & "," & k & "," & Real(k) & "," & Imag(k) & "," & savePhase(k) & "," & Impedance(k) & vbCrLf, True) '& "," & CDec(rawReal(k)) & "," & CDec(rawImag(k)) & "," & CDec(Real(k)) & "," & CDec(Imag(k)) & "," & CDec(Impedance(k)) & "," & CDec(savePhase(k)) & vbCrLf, True)
            Next

        End If

        'Dim saveFileDialog1 As New SaveFileDialog()
        'saveFileDialog1.ShowDialog()
        'Dim myStream As Stream

        ''TODO: Tömbként átadni ezeket az értzékeket!
        ''sw.WriteLine(channel & "," & timeseries & "," & TextBox3.Text & "," & magnitude & "," & real & "," & imag & "," & impedance & "," & gainFactor(0))

        'If saveFileDialog1.ShowDialog() = DialogResult.OK Then
        '    myStream = saveFileDialog1.OpenFile()
        '    Dim path As String = IO.Path.GetDirectoryName(saveFileDialog1.FileName)
        '    If (myStream IsNot Nothing) Then
        '        csvOutput(Path)
        '        myStream.Close()
        '    End If
        'End If

        'Label6.Text = saveFileDialog1.FileName & DateTime.Today.ToString("yyyy-MMM-dd") & DateTime.Now.ToString("-HH mm") & ".csv"

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        save.BackColor = Color.Green
    End Sub

    Private Sub stepDetect_Click(sender As Object, e As EventArgs) Handles stepDetect.Click



        SendCommand(Commands.CMD_STOP_MEAS)
        SendCommand(Commands.CMD_START_MEAS)

        Dim measurementData As String

        Label18.Visible = True

        While measurementData = "0"
            measurementData = doMeasurement()
            Label18.Text = measurementData
        End While
        Label18.Visible = False


    End Sub


    'Tömb betöltés:


    Dim var(1) As Integer


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        MUX = Not MUX
    End Sub
End Class