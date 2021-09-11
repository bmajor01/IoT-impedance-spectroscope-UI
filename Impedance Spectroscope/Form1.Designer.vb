<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.StartFreq = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.startCal = New System.Windows.Forms.Button()
        Me.plottype = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.time_CH4 = New System.Windows.Forms.Label()
        Me.time_CH3 = New System.Windows.Forms.Label()
        Me.time_CH2 = New System.Windows.Forms.Label()
        Me.time_CH1 = New System.Windows.Forms.Label()
        Me.avg_CH1 = New System.Windows.Forms.Label()
        Me.avg_CH2 = New System.Windows.Forms.Label()
        Me.avg_CH3 = New System.Windows.Forms.Label()
        Me.avg_CH4 = New System.Windows.Forms.Label()
        Me.stepDetect = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM7"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(12, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CH1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CH2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CH3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "CH4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 181)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "CH5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 210)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "CH6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "COM7"
        '
        'Connect
        '
        Me.Connect.Location = New System.Drawing.Point(12, 36)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(75, 23)
        Me.Connect.TabIndex = 7
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'StartFreq
        '
        Me.StartFreq.Location = New System.Drawing.Point(12, 281)
        Me.StartFreq.Name = "StartFreq"
        Me.StartFreq.Size = New System.Drawing.Size(137, 23)
        Me.StartFreq.TabIndex = 8
        Me.StartFreq.Text = "Start Frequency"
        Me.StartFreq.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 310)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(137, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Number of increments"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 339)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(137, 23)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Increment"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 368)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(137, 23)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "Settling cycle"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(155, 281)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(51, 20)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "1000"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(155, 310)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(51, 20)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "10"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(155, 339)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(51, 20)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "100"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(155, 368)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(51, 20)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "10"
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.Location = New System.Drawing.Point(12, 397)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(98, 81)
        Me.Button11.TabIndex = 17
        Me.Button11.Text = "Measure"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(220, 42)
        Me.Chart1.Name = "Chart1"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Legend = "Legend1"
        Series7.Name = "Impedancia"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.Name = "Fázis"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(870, 570)
        Me.Chart1.TabIndex = 18
        Me.Chart1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Device IDN"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(74, 123)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 20
        Me.Button12.Text = "Gain 5X"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(74, 152)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 21
        Me.Button13.Text = "Rfb = 100R"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(74, 181)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 22
        Me.Button14.Text = "Rfb = 1k"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(74, 210)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 23
        Me.Button15.Text = "Rfb = 10k"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Device STATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Device resp:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Device state:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(548, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Device resp:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(810, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Real:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(810, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Imag:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(871, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(871, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Label11"
        '
        'Timer1
        '
        '
        'startCal
        '
        Me.startCal.Location = New System.Drawing.Point(116, 542)
        Me.startCal.Name = "startCal"
        Me.startCal.Size = New System.Drawing.Size(98, 23)
        Me.startCal.TabIndex = 36
        Me.startCal.Text = "CAL"
        Me.startCal.UseVisualStyleBackColor = True
        '
        'plottype
        '
        Me.plottype.Location = New System.Drawing.Point(116, 484)
        Me.plottype.Name = "plottype"
        Me.plottype.Size = New System.Drawing.Size(98, 23)
        Me.plottype.TabIndex = 37
        Me.plottype.Text = "TIMESERIES"
        Me.plottype.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(116, 513)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(98, 23)
        Me.save.TabIndex = 38
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(116, 397)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(98, 81)
        Me.Button19.TabIndex = 39
        Me.Button19.Text = "SWEEP"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(12, 484)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(98, 81)
        Me.Button16.TabIndex = 40
        Me.Button16.Text = "RESET"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(990, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Imag:"
        '
        'SaveFileDialog1
        '
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 586)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Lépés idő CH1:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 599)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Lépés idő CH2:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 612)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Lépés idő CH3:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 625)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Lépés idő CH4:"
        '
        'time_CH4
        '
        Me.time_CH4.AutoSize = True
        Me.time_CH4.Location = New System.Drawing.Point(95, 625)
        Me.time_CH4.Name = "time_CH4"
        Me.time_CH4.Size = New System.Drawing.Size(45, 13)
        Me.time_CH4.TabIndex = 47
        Me.time_CH4.Text = "Label17"
        '
        'time_CH3
        '
        Me.time_CH3.AutoSize = True
        Me.time_CH3.Location = New System.Drawing.Point(95, 612)
        Me.time_CH3.Name = "time_CH3"
        Me.time_CH3.Size = New System.Drawing.Size(45, 13)
        Me.time_CH3.TabIndex = 48
        Me.time_CH3.Text = "Label18"
        '
        'time_CH2
        '
        Me.time_CH2.AutoSize = True
        Me.time_CH2.Location = New System.Drawing.Point(95, 599)
        Me.time_CH2.Name = "time_CH2"
        Me.time_CH2.Size = New System.Drawing.Size(45, 13)
        Me.time_CH2.TabIndex = 49
        Me.time_CH2.Text = "Label19"
        '
        'time_CH1
        '
        Me.time_CH1.AutoSize = True
        Me.time_CH1.Location = New System.Drawing.Point(95, 586)
        Me.time_CH1.Name = "time_CH1"
        Me.time_CH1.Size = New System.Drawing.Size(45, 13)
        Me.time_CH1.TabIndex = 50
        Me.time_CH1.Text = "Label20"
        '
        'avg_CH1
        '
        Me.avg_CH1.AutoSize = True
        Me.avg_CH1.Location = New System.Drawing.Point(161, 586)
        Me.avg_CH1.Name = "avg_CH1"
        Me.avg_CH1.Size = New System.Drawing.Size(45, 13)
        Me.avg_CH1.TabIndex = 54
        Me.avg_CH1.Text = "Label21"
        '
        'avg_CH2
        '
        Me.avg_CH2.AutoSize = True
        Me.avg_CH2.Location = New System.Drawing.Point(161, 599)
        Me.avg_CH2.Name = "avg_CH2"
        Me.avg_CH2.Size = New System.Drawing.Size(45, 13)
        Me.avg_CH2.TabIndex = 53
        Me.avg_CH2.Text = "Label22"
        '
        'avg_CH3
        '
        Me.avg_CH3.AutoSize = True
        Me.avg_CH3.Location = New System.Drawing.Point(161, 612)
        Me.avg_CH3.Name = "avg_CH3"
        Me.avg_CH3.Size = New System.Drawing.Size(45, 13)
        Me.avg_CH3.TabIndex = 52
        Me.avg_CH3.Text = "Label23"
        '
        'avg_CH4
        '
        Me.avg_CH4.AutoSize = True
        Me.avg_CH4.Location = New System.Drawing.Point(161, 625)
        Me.avg_CH4.Name = "avg_CH4"
        Me.avg_CH4.Size = New System.Drawing.Size(45, 13)
        Me.avg_CH4.TabIndex = 51
        Me.avg_CH4.Text = "Label24"
        '
        'stepDetect
        '
        Me.stepDetect.Location = New System.Drawing.Point(74, 65)
        Me.stepDetect.Name = "stepDetect"
        Me.stepDetect.Size = New System.Drawing.Size(75, 23)
        Me.stepDetect.TabIndex = 55
        Me.stepDetect.Text = "stepDetect"
        Me.stepDetect.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(990, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Imag:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(139, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Measurement"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(161, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Label19"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(220, 626)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(870, 23)
        Me.ProgressBar1.TabIndex = 60
        Me.ProgressBar1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(155, 255)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(51, 20)
        Me.TextBox2.TabIndex = 61
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "1000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Rcal = "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(161, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(161, 157)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Label21"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(12, 239)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(46, 23)
        Me.Button17.TabIndex = 65
        Me.Button17.Text = "MUX"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.stepDetect)
        Me.Controls.Add(Me.avg_CH1)
        Me.Controls.Add(Me.avg_CH2)
        Me.Controls.Add(Me.avg_CH3)
        Me.Controls.Add(Me.avg_CH4)
        Me.Controls.Add(Me.time_CH1)
        Me.Controls.Add(Me.time_CH2)
        Me.Controls.Add(Me.time_CH3)
        Me.Controls.Add(Me.time_CH4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.plottype)
        Me.Controls.Add(Me.startCal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.StartFreq)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Connect As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents StartFreq As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents startCal As Button
    Friend WithEvents save As Button
    Friend WithEvents plottype As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents time_CH1 As Label
    Friend WithEvents time_CH2 As Label
    Friend WithEvents time_CH3 As Label
    Friend WithEvents time_CH4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents avg_CH1 As Label
    Friend WithEvents avg_CH2 As Label
    Friend WithEvents avg_CH3 As Label
    Friend WithEvents avg_CH4 As Label
    Friend WithEvents stepDetect As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button17 As Button
End Class
