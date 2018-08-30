<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scenariodefaults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scenariodefaults))
        Me.start_time_inc = New System.Windows.Forms.TrackBar()
        Me.start_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Current_time = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.player1 = New System.Windows.Forms.TextBox()
        Me.player2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gameturn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.nextturn = New System.Windows.Forms.Button()
        Me.loadscenario = New System.Windows.Forms.Button()
        Me.savescenario = New System.Windows.Forms.Button()
        Me.newscenario = New System.Windows.Forms.Button()
        Me.player1_init = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.player2_init = New System.Windows.Forms.TextBox()
        Me.p1_direct_fire = New System.Windows.Forms.Button()
        Me.p2_direct_fire = New System.Windows.Forms.Button()
        Me.p1_indirectfire = New System.Windows.Forms.Button()
        Me.p2_indirectfire = New System.Windows.Forms.Button()
        Me.p1_aircombat = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sunrise = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.sunset = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.scenario_name = New System.Windows.Forms.TextBox()
        Me.p2_aircombat = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.p1_quality = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.p2_quality = New System.Windows.Forms.TextBox()
        CType(Me.start_time_inc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'start_time_inc
        '
        Me.start_time_inc.AutoSize = False
        Me.start_time_inc.BackColor = System.Drawing.SystemColors.Control
        Me.start_time_inc.Enabled = False
        Me.start_time_inc.Location = New System.Drawing.Point(319, 105)
        Me.start_time_inc.Maximum = 23
        Me.start_time_inc.Name = "start_time_inc"
        Me.start_time_inc.Size = New System.Drawing.Size(262, 30)
        Me.start_time_inc.TabIndex = 0
        Me.start_time_inc.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'start_time
        '
        Me.start_time.AutoSize = True
        Me.start_time.BackColor = System.Drawing.Color.White
        Me.start_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.start_time.Enabled = False
        Me.start_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_time.Location = New System.Drawing.Point(171, 105)
        Me.start_time.MaximumSize = New System.Drawing.Size(125, 30)
        Me.start_time.MinimumSize = New System.Drawing.Size(125, 30)
        Me.start_time.Name = "start_time"
        Me.start_time.Size = New System.Drawing.Size(125, 30)
        Me.start_time.TabIndex = 1
        Me.start_time.Text = "0"
        Me.start_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(364, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dawn"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-1, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Current Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Current_time
        '
        Me.Current_time.AutoSize = True
        Me.Current_time.BackColor = System.Drawing.Color.White
        Me.Current_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Current_time.Enabled = False
        Me.Current_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_time.Location = New System.Drawing.Point(171, 156)
        Me.Current_time.MaximumSize = New System.Drawing.Size(125, 30)
        Me.Current_time.MinimumSize = New System.Drawing.Size(125, 30)
        Me.Current_time.Name = "Current_time"
        Me.Current_time.Size = New System.Drawing.Size(125, 30)
        Me.Current_time.TabIndex = 7
        Me.Current_time.Text = "0"
        Me.Current_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(389, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Player 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'player1
        '
        Me.player1.Enabled = False
        Me.player1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1.Location = New System.Drawing.Point(374, 264)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(132, 35)
        Me.player1.TabIndex = 10
        Me.player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'player2
        '
        Me.player2.Enabled = False
        Me.player2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2.Location = New System.Drawing.Point(512, 264)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(132, 35)
        Me.player2.TabIndex = 11
        Me.player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(523, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Player 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gameturn
        '
        Me.gameturn.Enabled = False
        Me.gameturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameturn.Location = New System.Drawing.Point(485, 157)
        Me.gameturn.Name = "gameturn"
        Me.gameturn.Size = New System.Drawing.Size(125, 35)
        Me.gameturn.TabIndex = 14
        Me.gameturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(336, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Game Turn"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nextturn
        '
        Me.nextturn.Enabled = False
        Me.nextturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextturn.Location = New System.Drawing.Point(12, 591)
        Me.nextturn.Name = "nextturn"
        Me.nextturn.Size = New System.Drawing.Size(120, 42)
        Me.nextturn.TabIndex = 15
        Me.nextturn.Text = "Next Turn"
        Me.nextturn.UseVisualStyleBackColor = True
        '
        'loadscenario
        '
        Me.loadscenario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadscenario.Location = New System.Drawing.Point(12, 498)
        Me.loadscenario.Name = "loadscenario"
        Me.loadscenario.Size = New System.Drawing.Size(120, 40)
        Me.loadscenario.TabIndex = 16
        Me.loadscenario.Text = "Load Scenario"
        Me.loadscenario.UseVisualStyleBackColor = True
        '
        'savescenario
        '
        Me.savescenario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savescenario.Location = New System.Drawing.Point(12, 545)
        Me.savescenario.Name = "savescenario"
        Me.savescenario.Size = New System.Drawing.Size(120, 40)
        Me.savescenario.TabIndex = 17
        Me.savescenario.Text = "Save Scenario"
        Me.savescenario.UseVisualStyleBackColor = True
        '
        'newscenario
        '
        Me.newscenario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newscenario.Location = New System.Drawing.Point(12, 451)
        Me.newscenario.Name = "newscenario"
        Me.newscenario.Size = New System.Drawing.Size(120, 40)
        Me.newscenario.TabIndex = 18
        Me.newscenario.Text = "New Scenario"
        Me.newscenario.UseVisualStyleBackColor = True
        '
        'player1_init
        '
        Me.player1_init.Enabled = False
        Me.player1_init.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1_init.Location = New System.Drawing.Point(374, 305)
        Me.player1_init.Name = "player1_init"
        Me.player1_init.Size = New System.Drawing.Size(132, 35)
        Me.player1_init.TabIndex = 12
        Me.player1_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(286, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 29)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(258, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 29)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Initiative"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'player2_init
        '
        Me.player2_init.Enabled = False
        Me.player2_init.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2_init.Location = New System.Drawing.Point(512, 305)
        Me.player2_init.Name = "player2_init"
        Me.player2_init.Size = New System.Drawing.Size(132, 35)
        Me.player2_init.TabIndex = 13
        Me.player2_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p1_direct_fire
        '
        Me.p1_direct_fire.Enabled = False
        Me.p1_direct_fire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_direct_fire.Location = New System.Drawing.Point(374, 389)
        Me.p1_direct_fire.Name = "p1_direct_fire"
        Me.p1_direct_fire.Size = New System.Drawing.Size(132, 35)
        Me.p1_direct_fire.TabIndex = 19
        Me.p1_direct_fire.UseVisualStyleBackColor = True
        '
        'p2_direct_fire
        '
        Me.p2_direct_fire.Enabled = False
        Me.p2_direct_fire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_direct_fire.Location = New System.Drawing.Point(512, 389)
        Me.p2_direct_fire.Name = "p2_direct_fire"
        Me.p2_direct_fire.Size = New System.Drawing.Size(132, 35)
        Me.p2_direct_fire.TabIndex = 21
        Me.p2_direct_fire.UseVisualStyleBackColor = True
        '
        'p1_indirectfire
        '
        Me.p1_indirectfire.Enabled = False
        Me.p1_indirectfire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_indirectfire.Location = New System.Drawing.Point(374, 430)
        Me.p1_indirectfire.Name = "p1_indirectfire"
        Me.p1_indirectfire.Size = New System.Drawing.Size(132, 35)
        Me.p1_indirectfire.TabIndex = 25
        Me.p1_indirectfire.UseVisualStyleBackColor = True
        '
        'p2_indirectfire
        '
        Me.p2_indirectfire.Enabled = False
        Me.p2_indirectfire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_indirectfire.Location = New System.Drawing.Point(512, 430)
        Me.p2_indirectfire.Name = "p2_indirectfire"
        Me.p2_indirectfire.Size = New System.Drawing.Size(132, 35)
        Me.p2_indirectfire.TabIndex = 26
        Me.p2_indirectfire.UseVisualStyleBackColor = True
        '
        'p1_aircombat
        '
        Me.p1_aircombat.Enabled = False
        Me.p1_aircombat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_aircombat.Location = New System.Drawing.Point(374, 471)
        Me.p1_aircombat.Name = "p1_aircombat"
        Me.p1_aircombat.Size = New System.Drawing.Size(132, 35)
        Me.p1_aircombat.TabIndex = 27
        Me.p1_aircombat.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd MMM yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 51)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1939, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(187, 35)
        Me.DateTimePicker1.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(22, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 29)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Game Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sunrise
        '
        Me.sunrise.BackColor = System.Drawing.Color.White
        Me.sunrise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sunrise.Enabled = False
        Me.sunrise.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sunrise.Location = New System.Drawing.Point(439, 55)
        Me.sunrise.MaximumSize = New System.Drawing.Size(75, 30)
        Me.sunrise.MinimumSize = New System.Drawing.Size(0, 30)
        Me.sunrise.Name = "sunrise"
        Me.sunrise.Size = New System.Drawing.Size(75, 30)
        Me.sunrise.TabIndex = 31
        Me.sunrise.Text = "24:00"
        Me.sunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(520, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 29)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Dusk"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sunset
        '
        Me.sunset.BackColor = System.Drawing.Color.White
        Me.sunset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sunset.Enabled = False
        Me.sunset.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sunset.Location = New System.Drawing.Point(590, 55)
        Me.sunset.MaximumSize = New System.Drawing.Size(75, 30)
        Me.sunset.MinimumSize = New System.Drawing.Size(0, 30)
        Me.sunset.Name = "sunset"
        Me.sunset.Size = New System.Drawing.Size(75, 30)
        Me.sunset.TabIndex = 33
        Me.sunset.Text = "24:00"
        Me.sunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(48, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 29)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Scenario"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'scenario_name
        '
        Me.scenario_name.Enabled = False
        Me.scenario_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scenario_name.Location = New System.Drawing.Point(171, 9)
        Me.scenario_name.Name = "scenario_name"
        Me.scenario_name.Size = New System.Drawing.Size(187, 35)
        Me.scenario_name.TabIndex = 14
        '
        'p2_aircombat
        '
        Me.p2_aircombat.Enabled = False
        Me.p2_aircombat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_aircombat.Location = New System.Drawing.Point(512, 471)
        Me.p2_aircombat.Name = "p2_aircombat"
        Me.p2_aircombat.Size = New System.Drawing.Size(132, 35)
        Me.p2_aircombat.TabIndex = 34
        Me.p2_aircombat.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(232, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Direct Fire"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(214, 430)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 29)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Indirect Fire"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(226, 471)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 29)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Air Combat"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'p1_quality
        '
        Me.p1_quality.Enabled = False
        Me.p1_quality.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_quality.Location = New System.Drawing.Point(374, 346)
        Me.p1_quality.Name = "p1_quality"
        Me.p1_quality.Size = New System.Drawing.Size(132, 35)
        Me.p1_quality.TabIndex = 13
        Me.p1_quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(274, 349)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 29)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Quality"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'p2_quality
        '
        Me.p2_quality.Enabled = False
        Me.p2_quality.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_quality.Location = New System.Drawing.Point(512, 346)
        Me.p2_quality.Name = "p2_quality"
        Me.p2_quality.Size = New System.Drawing.Size(132, 35)
        Me.p2_quality.TabIndex = 14
        Me.p2_quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'scenariodefaults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.p2_aircombat)
        Me.Controls.Add(Me.sunset)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.sunrise)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.p1_aircombat)
        Me.Controls.Add(Me.p2_indirectfire)
        Me.Controls.Add(Me.p1_indirectfire)
        Me.Controls.Add(Me.p2_direct_fire)
        Me.Controls.Add(Me.p2_quality)
        Me.Controls.Add(Me.player2_init)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.p1_quality)
        Me.Controls.Add(Me.player1_init)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.p1_direct_fire)
        Me.Controls.Add(Me.newscenario)
        Me.Controls.Add(Me.savescenario)
        Me.Controls.Add(Me.loadscenario)
        Me.Controls.Add(Me.nextturn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.scenario_name)
        Me.Controls.Add(Me.gameturn)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Current_time)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.start_time)
        Me.Controls.Add(Me.start_time_inc)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "scenariodefaults"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Control and Defaults"
        CType(Me.start_time_inc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start_time_inc As System.Windows.Forms.TrackBar
    Friend WithEvents start_time As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Current_time As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents player1 As System.Windows.Forms.TextBox
    Friend WithEvents player2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gameturn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents nextturn As System.Windows.Forms.Button
    Friend WithEvents loadscenario As System.Windows.Forms.Button
    Friend WithEvents savescenario As System.Windows.Forms.Button
    Friend WithEvents newscenario As System.Windows.Forms.Button
    Friend WithEvents player1_init As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents player2_init As System.Windows.Forms.TextBox
    Friend WithEvents p1_direct_fire As System.Windows.Forms.Button
    Friend WithEvents p2_direct_fire As System.Windows.Forms.Button
    Friend WithEvents p1_indirectfire As Button
    Friend WithEvents p2_indirectfire As Button
    Friend WithEvents p1_aircombat As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents sunrise As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents sunset As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents scenario_name As TextBox
    Friend WithEvents p2_aircombat As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents p1_quality As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents p2_quality As TextBox
End Class
