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
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.openSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveFilSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.comboTool = New System.Windows.Forms.ToolStripComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
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
        Me.workerHours.Location = New System.Drawing.Point(195, 233)
        Me.workerHours.Name = "workerHours"
        Me.workerHours.Size = New System.Drawing.Size(100, 20)
        Me.workerHours.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Minutes Worked not including setup:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estimated Filament Usage:"
        '
        'filamentusage
        '
        Me.filamentusage.Location = New System.Drawing.Point(195, 207)
        Me.filamentusage.Name = "filamentusage"
        Me.filamentusage.Size = New System.Drawing.Size(100, 20)
        Me.filamentusage.TabIndex = 7
        '
        'button_calculate
        '
        Me.button_calculate.Location = New System.Drawing.Point(663, 356)
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
        Me.Label8.Location = New System.Drawing.Point(559, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Amount to charge customer:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(559, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Filament Cost:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(563, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Worker Cost:"
        '
        'filamentCost
        '
        Me.filamentCost.Enabled = False
        Me.filamentCost.Location = New System.Drawing.Point(638, 226)
        Me.filamentCost.Name = "filamentCost"
        Me.filamentCost.Size = New System.Drawing.Size(100, 20)
        Me.filamentCost.TabIndex = 17
        Me.filamentCost.TabStop = False
        '
        'workerCost
        '
        Me.workerCost.Enabled = False
        Me.workerCost.Location = New System.Drawing.Point(638, 252)
        Me.workerCost.Name = "workerCost"
        Me.workerCost.Size = New System.Drawing.Size(100, 20)
        Me.workerCost.TabIndex = 18
        Me.workerCost.TabStop = False
        '
        'totalCost
        '
        Me.totalCost.Enabled = False
        Me.totalCost.Location = New System.Drawing.Point(638, 307)
        Me.totalCost.Name = "totalCost"
        Me.totalCost.Size = New System.Drawing.Size(100, 20)
        Me.totalCost.TabIndex = 19
        Me.totalCost.TabStop = False
        '
        'charge
        '
        Me.charge.Enabled = False
        Me.charge.Location = New System.Drawing.Point(378, 353)
        Me.charge.Name = "charge"
        Me.charge.Size = New System.Drawing.Size(100, 20)
        Me.charge.TabIndex = 20
        Me.charge.TabStop = False
        '
        'buildTime
        '
        Me.buildTime.Location = New System.Drawing.Point(196, 259)
        Me.buildTime.Name = "buildTime"
        Me.buildTime.Size = New System.Drawing.Size(100, 20)
        Me.buildTime.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Part build time(minutes)"
        '
        'setupTime
        '
        Me.setupTime.Location = New System.Drawing.Point(195, 285)
        Me.setupTime.Name = "setupTime"
        Me.setupTime.Size = New System.Drawing.Size(100, 20)
        Me.setupTime.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Setup time (minutes):"
        '
        'printerTotalCost
        '
        Me.printerTotalCost.Enabled = False
        Me.printerTotalCost.Location = New System.Drawing.Point(638, 281)
        Me.printerTotalCost.Name = "printerTotalCost"
        Me.printerTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.printerTotalCost.TabIndex = 26
        Me.printerTotalCost.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(568, 284)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Printer Cost:"
        '
        'radio_meters
        '
        Me.radio_meters.AutoSize = True
        Me.radio_meters.Location = New System.Drawing.Point(302, 210)
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
        Me.radio_mm.Location = New System.Drawing.Point(341, 210)
        Me.radio_mm.Name = "radio_mm"
        Me.radio_mm.Size = New System.Drawing.Size(41, 17)
        Me.radio_mm.TabIndex = 28
        Me.radio_mm.TabStop = True
        Me.radio_mm.Text = "mm"
        Me.radio_mm.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.comboTool, Me.NewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(769, 27)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openSettings, Me.saveFilSet})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(37, 23)
        Me.File.Text = "File"
        '
        'openSettings
        '
        Me.openSettings.Name = "openSettings"
        Me.openSettings.Size = New System.Drawing.Size(192, 22)
        Me.openSettings.Text = "Open Settings"
        '
        'saveFilSet
        '
        Me.saveFilSet.Name = "saveFilSet"
        Me.saveFilSet.Size = New System.Drawing.Size(192, 22)
        Me.saveFilSet.Text = "Save Filament Settings"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 386)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Made by Kyle Malinowski"
        '
        'comboTool
        '
        Me.comboTool.Name = "comboTool"
        Me.comboTool.Size = New System.Drawing.Size(121, 23)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 411)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.radio_mm)
        Me.Controls.Add(Me.radio_meters)
        Me.Controls.Add(Me.printerTotalCost)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.setupTime)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.buildTime)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.charge)
        Me.Controls.Add(Me.totalCost)
        Me.Controls.Add(Me.workerCost)
        Me.Controls.Add(Me.filamentCost)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.button_calculate)
        Me.Controls.Add(Me.filamentusage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.workerHours)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Location = New System.Drawing.Point(785, 450)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(785, 450)
        Me.Name = "Form1"
        Me.Text = "3D Print Cost Estimation Calc."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents openSettings As ToolStripMenuItem
    Friend WithEvents saveFilSet As ToolStripMenuItem
    Friend WithEvents Label19 As Label
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents comboTool As ToolStripComboBox
End Class
