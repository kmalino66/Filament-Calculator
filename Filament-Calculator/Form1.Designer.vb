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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.printerCostPerHour = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radio_cpm = New System.Windows.Forms.RadioButton()
        Me.costPerMeter = New System.Windows.Forms.TextBox()
        Me.upchargePercent = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.filamentdensity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.filamentdiameter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.spoolmass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radio_o = New System.Windows.Forms.RadioButton()
        Me.radio_m = New System.Windows.Forms.RadioButton()
        Me.workerHourly = New System.Windows.Forms.TextBox()
        Me.filamentamount_meters = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spoolcost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.workerHours = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.filamentusage = New System.Windows.Forms.TextBox()
        Me.button_calculate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.filamentCost = New System.Windows.Forms.TextBox()
        Me.workerCost = New System.Windows.Forms.TextBox()
        Me.totalCost = New System.Windows.Forms.TextBox()
        Me.charge = New System.Windows.Forms.TextBox()
        Me.buildTime = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.setupTime = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.printerTotalCost = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.radio_meters = New System.Windows.Forms.RadioButton()
        Me.radio_mm = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.comboTool = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstrip_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.v = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.make_button = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.label_original = New System.Windows.Forms.Label()
        Me.label_available = New System.Windows.Forms.Label()
        Me.textbox_original = New System.Windows.Forms.TextBox()
        Me.textbox_available = New System.Windows.Forms.TextBox()
        Me.filamentUsedTextBox = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.moneyRecTextBox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.moneySpentTextbox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.textbox_spool_cost = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.combobox_filament_type = New System.Windows.Forms.ComboBox()
        Me.button_new_spool = New System.Windows.Forms.Button()
        Me.button_decommission_spool = New System.Windows.Forms.Button()
        Me.button_useSpool = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.v.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.printerCostPerHour)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radio_cpm)
        Me.GroupBox1.Controls.Add(Me.costPerMeter)
        Me.GroupBox1.Controls.Add(Me.upchargePercent)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.filamentdensity)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.filamentdiameter)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.spoolmass)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.radio_o)
        Me.GroupBox1.Controls.Add(Me.radio_m)
        Me.GroupBox1.Controls.Add(Me.workerHourly)
        Me.GroupBox1.Controls.Add(Me.filamentamount_meters)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.spoolcost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 175)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cost Settings"
        '
        'printerCostPerHour
        '
        Me.printerCostPerHour.Location = New System.Drawing.Point(606, 24)
        Me.printerCostPerHour.Name = "printerCostPerHour"
        Me.printerCostPerHour.Size = New System.Drawing.Size(100, 20)
        Me.printerCostPerHour.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Printer Cost per Hour:"
        '
        'radio_cpm
        '
        Me.radio_cpm.AutoSize = True
        Me.radio_cpm.Location = New System.Drawing.Point(521, 91)
        Me.radio_cpm.Name = "radio_cpm"
        Me.radio_cpm.Size = New System.Drawing.Size(14, 13)
        Me.radio_cpm.TabIndex = 22
        Me.radio_cpm.TabStop = True
        Me.radio_cpm.UseVisualStyleBackColor = True
        '
        'costPerMeter
        '
        Me.costPerMeter.Enabled = False
        Me.costPerMeter.Location = New System.Drawing.Point(626, 88)
        Me.costPerMeter.Name = "costPerMeter"
        Me.costPerMeter.Size = New System.Drawing.Size(100, 20)
        Me.costPerMeter.TabIndex = 10
        '
        'upchargePercent
        '
        Me.upchargePercent.Location = New System.Drawing.Point(121, 49)
        Me.upchargePercent.Name = "upchargePercent"
        Me.upchargePercent.Size = New System.Drawing.Size(51, 20)
        Me.upchargePercent.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(541, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Cost per Meter:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Material Upcharge %:"
        '
        'filamentdensity
        '
        Me.filamentdensity.Location = New System.Drawing.Point(390, 114)
        Me.filamentdensity.Name = "filamentdensity"
        Me.filamentdensity.Size = New System.Drawing.Size(100, 20)
        Me.filamentdensity.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Filament Density:"
        '
        'filamentdiameter
        '
        Me.filamentdiameter.Location = New System.Drawing.Point(390, 139)
        Me.filamentdiameter.Name = "filamentdiameter"
        Me.filamentdiameter.Size = New System.Drawing.Size(100, 20)
        Me.filamentdiameter.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Filament Diameter:"
        '
        'spoolmass
        '
        Me.spoolmass.Location = New System.Drawing.Point(390, 88)
        Me.spoolmass.Name = "spoolmass"
        Me.spoolmass.Size = New System.Drawing.Size(100, 20)
        Me.spoolmass.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Spool Mass:"
        '
        'radio_o
        '
        Me.radio_o.AutoSize = True
        Me.radio_o.Location = New System.Drawing.Point(270, 92)
        Me.radio_o.Name = "radio_o"
        Me.radio_o.Size = New System.Drawing.Size(14, 13)
        Me.radio_o.TabIndex = 7
        Me.radio_o.UseVisualStyleBackColor = True
        '
        'radio_m
        '
        Me.radio_m.AutoSize = True
        Me.radio_m.Location = New System.Drawing.Point(12, 91)
        Me.radio_m.Name = "radio_m"
        Me.radio_m.Size = New System.Drawing.Size(14, 13)
        Me.radio_m.TabIndex = 6
        Me.radio_m.UseVisualStyleBackColor = True
        '
        'workerHourly
        '
        Me.workerHourly.Location = New System.Drawing.Point(366, 24)
        Me.workerHourly.Name = "workerHourly"
        Me.workerHourly.Size = New System.Drawing.Size(100, 20)
        Me.workerHourly.TabIndex = 8
        '
        'filamentamount_meters
        '
        Me.filamentamount_meters.Location = New System.Drawing.Point(147, 88)
        Me.filamentamount_meters.Name = "filamentamount_meters"
        Me.filamentamount_meters.Size = New System.Drawing.Size(100, 20)
        Me.filamentamount_meters.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(247, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Worker Cost per Hour:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount of filament(m):"
        '
        'spoolcost
        '
        Me.spoolcost.Location = New System.Drawing.Point(121, 24)
        Me.spoolcost.Name = "spoolcost"
        Me.spoolcost.Size = New System.Drawing.Size(80, 20)
        Me.spoolcost.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cost of Spool:"
        '
        'workerHours
        '
        Me.workerHours.Location = New System.Drawing.Point(212, 213)
        Me.workerHours.Name = "workerHours"
        Me.workerHours.Size = New System.Drawing.Size(100, 20)
        Me.workerHours.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Minutes Worked not including setup:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estimated Filament Usage:"
        '
        'filamentusage
        '
        Me.filamentusage.Location = New System.Drawing.Point(212, 187)
        Me.filamentusage.Name = "filamentusage"
        Me.filamentusage.Size = New System.Drawing.Size(100, 20)
        Me.filamentusage.TabIndex = 7
        '
        'button_calculate
        '
        Me.button_calculate.Location = New System.Drawing.Point(657, 317)
        Me.button_calculate.Name = "button_calculate"
        Me.button_calculate.Size = New System.Drawing.Size(75, 23)
        Me.button_calculate.TabIndex = 8
        Me.button_calculate.TabStop = False
        Me.button_calculate.Text = "Calculate"
        Me.button_calculate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(553, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Amount to charge customer:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(553, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Filament Cost:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(557, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Worker Cost:"
        '
        'filamentCost
        '
        Me.filamentCost.Enabled = False
        Me.filamentCost.Location = New System.Drawing.Point(632, 187)
        Me.filamentCost.Name = "filamentCost"
        Me.filamentCost.Size = New System.Drawing.Size(100, 20)
        Me.filamentCost.TabIndex = 17
        Me.filamentCost.TabStop = False
        '
        'workerCost
        '
        Me.workerCost.Enabled = False
        Me.workerCost.Location = New System.Drawing.Point(632, 213)
        Me.workerCost.Name = "workerCost"
        Me.workerCost.Size = New System.Drawing.Size(100, 20)
        Me.workerCost.TabIndex = 18
        Me.workerCost.TabStop = False
        '
        'totalCost
        '
        Me.totalCost.Enabled = False
        Me.totalCost.Location = New System.Drawing.Point(632, 268)
        Me.totalCost.Name = "totalCost"
        Me.totalCost.Size = New System.Drawing.Size(100, 20)
        Me.totalCost.TabIndex = 19
        Me.totalCost.TabStop = False
        '
        'charge
        '
        Me.charge.Enabled = False
        Me.charge.Location = New System.Drawing.Point(441, 353)
        Me.charge.Name = "charge"
        Me.charge.Size = New System.Drawing.Size(100, 20)
        Me.charge.TabIndex = 20
        Me.charge.TabStop = False
        '
        'buildTime
        '
        Me.buildTime.Location = New System.Drawing.Point(213, 239)
        Me.buildTime.Name = "buildTime"
        Me.buildTime.Size = New System.Drawing.Size(100, 20)
        Me.buildTime.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Part build time(minutes)"
        '
        'setupTime
        '
        Me.setupTime.Location = New System.Drawing.Point(212, 265)
        Me.setupTime.Name = "setupTime"
        Me.setupTime.Size = New System.Drawing.Size(100, 20)
        Me.setupTime.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(26, 268)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Setup time (minutes):"
        '
        'printerTotalCost
        '
        Me.printerTotalCost.Enabled = False
        Me.printerTotalCost.Location = New System.Drawing.Point(632, 242)
        Me.printerTotalCost.Name = "printerTotalCost"
        Me.printerTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.printerTotalCost.TabIndex = 26
        Me.printerTotalCost.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(562, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Printer Cost:"
        '
        'radio_meters
        '
        Me.radio_meters.AutoSize = True
        Me.radio_meters.Location = New System.Drawing.Point(319, 190)
        Me.radio_meters.Name = "radio_meters"
        Me.radio_meters.Size = New System.Drawing.Size(33, 17)
        Me.radio_meters.TabIndex = 27
        Me.radio_meters.TabStop = True
        Me.radio_meters.Text = "m"
        Me.radio_meters.UseVisualStyleBackColor = True
        '
        'radio_mm
        '
        Me.radio_mm.AutoSize = True
        Me.radio_mm.Location = New System.Drawing.Point(358, 190)
        Me.radio_mm.Name = "radio_mm"
        Me.radio_mm.Size = New System.Drawing.Size(41, 17)
        Me.radio_mm.TabIndex = 28
        Me.radio_mm.TabStop = True
        Me.radio_mm.Text = "mm"
        Me.radio_mm.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboTool, Me.toolstrip_new, Me.DeleteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 27)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'comboTool
        '
        Me.comboTool.Name = "comboTool"
        Me.comboTool.Size = New System.Drawing.Size(121, 23)
        '
        'toolstrip_new
        '
        Me.toolstrip_new.Name = "toolstrip_new"
        Me.toolstrip_new.Size = New System.Drawing.Size(43, 23)
        Me.toolstrip_new.Text = "New"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 511)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Made by Kyle Malinowski"
        '
        'v
        '
        Me.v.Controls.Add(Me.TabPage1)
        Me.v.Controls.Add(Me.TabPage2)
        Me.v.Location = New System.Drawing.Point(12, 30)
        Me.v.Name = "v"
        Me.v.SelectedIndex = 0
        Me.v.Size = New System.Drawing.Size(787, 468)
        Me.v.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.make_button)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.charge)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.printerTotalCost)
        Me.TabPage1.Controls.Add(Me.radio_mm)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.radio_meters)
        Me.TabPage1.Controls.Add(Me.totalCost)
        Me.TabPage1.Controls.Add(Me.workerHours)
        Me.TabPage1.Controls.Add(Me.workerCost)
        Me.TabPage1.Controls.Add(Me.filamentusage)
        Me.TabPage1.Controls.Add(Me.filamentCost)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.setupTime)
        Me.TabPage1.Controls.Add(Me.buildTime)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.button_calculate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(779, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Filament Cost Calculator"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'make_button
        '
        Me.make_button.Location = New System.Drawing.Point(657, 346)
        Me.make_button.Name = "make_button"
        Me.make_button.Size = New System.Drawing.Size(75, 23)
        Me.make_button.TabIndex = 29
        Me.make_button.Text = "Make"
        Me.make_button.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.label_original)
        Me.TabPage2.Controls.Add(Me.label_available)
        Me.TabPage2.Controls.Add(Me.textbox_original)
        Me.TabPage2.Controls.Add(Me.textbox_available)
        Me.TabPage2.Controls.Add(Me.filamentUsedTextBox)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.moneyRecTextBox)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.moneySpentTextbox)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.textbox_spool_cost)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.combobox_filament_type)
        Me.TabPage2.Controls.Add(Me.button_new_spool)
        Me.TabPage2.Controls.Add(Me.button_decommission_spool)
        Me.TabPage2.Controls.Add(Me.button_useSpool)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(779, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = " Spool Tracker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(383, 46)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Original:"
        '
        'label_original
        '
        Me.label_original.AutoSize = True
        Me.label_original.Location = New System.Drawing.Point(383, 46)
        Me.label_original.Name = "label_original"
        Me.label_original.Size = New System.Drawing.Size(0, 13)
        Me.label_original.TabIndex = 25
        '
        'label_available
        '
        Me.label_available.AutoSize = True
        Me.label_available.Location = New System.Drawing.Point(383, 20)
        Me.label_available.Name = "label_available"
        Me.label_available.Size = New System.Drawing.Size(53, 13)
        Me.label_available.TabIndex = 24
        Me.label_available.Text = "Available:"
        '
        'textbox_original
        '
        Me.textbox_original.Location = New System.Drawing.Point(453, 43)
        Me.textbox_original.Name = "textbox_original"
        Me.textbox_original.ReadOnly = True
        Me.textbox_original.Size = New System.Drawing.Size(100, 20)
        Me.textbox_original.TabIndex = 23
        '
        'textbox_available
        '
        Me.textbox_available.Location = New System.Drawing.Point(453, 17)
        Me.textbox_available.Name = "textbox_available"
        Me.textbox_available.ReadOnly = True
        Me.textbox_available.Size = New System.Drawing.Size(100, 20)
        Me.textbox_available.TabIndex = 22
        '
        'filamentUsedTextBox
        '
        Me.filamentUsedTextBox.Location = New System.Drawing.Point(200, 277)
        Me.filamentUsedTextBox.Name = "filamentUsedTextBox"
        Me.filamentUsedTextBox.ReadOnly = True
        Me.filamentUsedTextBox.Size = New System.Drawing.Size(137, 20)
        Me.filamentUsedTextBox.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(117, 280)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Filament Used:"
        '
        'moneyRecTextBox
        '
        Me.moneyRecTextBox.Location = New System.Drawing.Point(200, 251)
        Me.moneyRecTextBox.Name = "moneyRecTextBox"
        Me.moneyRecTextBox.ReadOnly = True
        Me.moneyRecTextBox.Size = New System.Drawing.Size(137, 20)
        Me.moneyRecTextBox.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(39, 254)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(155, 13)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Money Recieved From Printing:"
        '
        'moneySpentTextbox
        '
        Me.moneySpentTextbox.Location = New System.Drawing.Point(200, 225)
        Me.moneySpentTextbox.Name = "moneySpentTextbox"
        Me.moneySpentTextbox.ReadOnly = True
        Me.moneySpentTextbox.Size = New System.Drawing.Size(137, 20)
        Me.moneySpentTextbox.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(64, 228)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Money Spent on Filament:"
        '
        'textbox_spool_cost
        '
        Me.textbox_spool_cost.Location = New System.Drawing.Point(122, 127)
        Me.textbox_spool_cost.Name = "textbox_spool_cost"
        Me.textbox_spool_cost.Size = New System.Drawing.Size(100, 20)
        Me.textbox_spool_cost.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Spool Cost:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Filament Type:"
        '
        'combobox_filament_type
        '
        Me.combobox_filament_type.FormattingEnabled = True
        Me.combobox_filament_type.Items.AddRange(New Object() {"PLA", "ABS"})
        Me.combobox_filament_type.Location = New System.Drawing.Point(101, 100)
        Me.combobox_filament_type.Name = "combobox_filament_type"
        Me.combobox_filament_type.Size = New System.Drawing.Size(121, 21)
        Me.combobox_filament_type.TabIndex = 11
        '
        'button_new_spool
        '
        Me.button_new_spool.Location = New System.Drawing.Point(22, 44)
        Me.button_new_spool.Name = "button_new_spool"
        Me.button_new_spool.Size = New System.Drawing.Size(75, 23)
        Me.button_new_spool.TabIndex = 9
        Me.button_new_spool.Text = "New Spool"
        Me.button_new_spool.UseVisualStyleBackColor = True
        '
        'button_decommission_spool
        '
        Me.button_decommission_spool.Location = New System.Drawing.Point(447, 69)
        Me.button_decommission_spool.Name = "button_decommission_spool"
        Me.button_decommission_spool.Size = New System.Drawing.Size(106, 23)
        Me.button_decommission_spool.TabIndex = 8
        Me.button_decommission_spool.Text = "Decommission"
        Me.button_decommission_spool.UseVisualStyleBackColor = True
        '
        'button_useSpool
        '
        Me.button_useSpool.Location = New System.Drawing.Point(366, 69)
        Me.button_useSpool.Name = "button_useSpool"
        Me.button_useSpool.Size = New System.Drawing.Size(75, 23)
        Me.button_useSpool.TabIndex = 6
        Me.button_useSpool.Text = "Use Spool"
        Me.button_useSpool.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(22, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(293, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 534)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Location = New System.Drawing.Point(785, 450)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "3D Printing Toolkit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.v.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents filamentdensity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents filamentdiameter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents spoolmass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents radio_o As RadioButton
    Friend WithEvents radio_m As RadioButton
    Friend WithEvents filamentamount_meters As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents spoolcost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents filamentusage As TextBox
    Friend WithEvents button_calculate As Button
    Friend WithEvents upchargePercent As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents workerHourly As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents workerHours As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents filamentCost As TextBox
    Friend WithEvents workerCost As TextBox
    Friend WithEvents totalCost As TextBox
    Friend WithEvents charge As TextBox
    Friend WithEvents costPerMeter As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents radio_cpm As RadioButton
    Friend WithEvents printerCostPerHour As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buildTime As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents setupTime As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents printerTotalCost As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents radio_meters As RadioButton
    Friend WithEvents radio_mm As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label19 As Label
    Friend WithEvents toolstrip_new As ToolStripMenuItem
    Friend WithEvents comboTool As ToolStripComboBox
    Friend WithEvents v As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents button_useSpool As Button
    Friend WithEvents textbox_spool_cost As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents combobox_filament_type As ComboBox
    Friend WithEvents button_new_spool As Button
    Friend WithEvents button_decommission_spool As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents filamentUsedTextBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents moneyRecTextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents moneySpentTextbox As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents label_original As Label
    Friend WithEvents label_available As Label
    Friend WithEvents textbox_original As TextBox
    Friend WithEvents textbox_available As TextBox
    Friend WithEvents make_button As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
