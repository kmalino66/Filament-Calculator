Imports System.ComponentModel
Imports System.IO

Public Class Form1
    Public fileName As String
    Public filamentSettings(0)() As String


    'This handles behavior for when a the radio button is clicked
    Private Sub radio_m_CheckedChanged(sender As Object, e As EventArgs) Handles radio_m.CheckedChanged
        'Make sure to unclick other radio buttons and enable/diable correct fields.

        If radio_m.Checked Then
            radio_o.Checked = False
            radio_cpm.Checked = False
            spoolmass.Enabled = False
            filamentdensity.Enabled = False
            filamentdiameter.Enabled = False
            filamentamount_meters.Enabled = True
            costPerMeter.Enabled = False
            spoolcost.Enabled = True

        End If

    End Sub

    'This handles behavior for when a the radio button is clicked

    Private Sub radio_o_CheckedChanged(sender As Object, e As EventArgs) Handles radio_o.CheckedChanged
        'Make sure to unclick other radio buttons and enable/diable correct fields.

        If radio_o.Checked Then
            radio_m.Checked = False
            radio_cpm.Checked = False
            spoolmass.Enabled = True
            filamentdensity.Enabled = True
            filamentdiameter.Enabled = True
            filamentamount_meters.Enabled = False
            costPerMeter.Enabled = False
            spoolcost.Enabled = True
        End If
    End Sub

    'This is called when the form is loaded.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Selects one of the radio buttones
        radio_m.Checked = True
        radio_meters.Checked = True
        fileName = My.Settings.lastFileName

        SaveFileDialog1.FileName = fileName
        OpenFileDialog1.FileName = fileName

        If fileName IsNot Nothing And fileName IsNot "" Then
            loadProfile(fileName)
        End If

        'Dim temp As New Panel
        ' temp = stencil_panel
        'temp.Visible = True
        ' Dim temp1 = temp.Controls.Find("label_name", False)
        'For counter As Integer = 0 To (temp1.Length - 1)
        'temp1(counter).Text = "magic"
        'Next

        'FlowLayoutPanel1.Controls.Add(temp)
    End Sub

    'Called when calculate button is pressed.
    Private Sub button_calculate_Click(sender As Object, e As EventArgs) Handles button_calculate.Click

        'Calculates the cost of the filament that will be used based on fields the user fills in.
        calcFilamentCost()

        'Calculates how much labor cost based on setup and other time.
        calcWorkerCost()

        'Calculates how much it cost to have the printer running. Build time and setup time.
        calcBuildTime()

        'Calculates the total cost of the build and how much to charge the customer with the upcharge that is given.
        calcTotalCost()

    End Sub

    'Calculates the total cost of the build and how much to charge the customer with the upcharge that is given.
    Public Sub calcTotalCost()

        totalCost.Text = Double.Parse(filamentCost.Text) + Double.Parse(workerCost.Text) + Double.Parse(printerTotalCost.Text)

        charge.Text = Double.Parse(totalCost.Text) + ((Double.Parse(upchargePercent.Text) / 100) * Double.Parse(filamentCost.Text))

    End Sub

    'Calculates how much it cost to have the printer running. Build time and setup time.
    Public Sub calcBuildTime()

        Dim hours As Double
        Dim par As Double

        If Double.TryParse(setupTime.Text, par) Then
            hours += par / 60
        End If

        If Double.TryParse(buildTime.Text, par) Then
            hours += par / 60
        End If

        printerTotalCost.Text = hours * Double.Parse(printerCostPerHour.Text)

    End Sub

    'Calculates how much labor cost based on setup and other time.
    Public Sub calcWorkerCost()

        Dim par As Double
        Dim hours As Double
        Dim cost As Double
        Dim cost1 As Double

        If Double.TryParse(workerHourly.Text, par) AndAlso Double.TryParse(workerHours.Text, par) Then
            hours = Double.Parse(workerHours.Text) / 60
            cost = hours * Double.Parse(workerHourly.Text)
        End If

        If Double.TryParse(workerHourly.Text, par) AndAlso Double.TryParse(setupTime.Text, par) Then
            hours = Double.Parse(setupTime.Text) / 60
            cost1 = Double.Parse(workerHourly.Text) * hours

        End If

        workerCost.Text = cost + cost1


    End Sub

    'Calculates the cost of the filament that will be used based on fields the user fills in.
    Public Sub calcFilamentCost()

        Dim modUse As Double
        'Meters is desireable
        If radio_meters.Checked Then
            modUse = 1
        Else
            modUse = 0.001
        End If

        Dim par As Double
        'This is run if the user put in the cost per meter
        If radio_cpm.Checked AndAlso Double.TryParse(costPerMeter.Text, par) AndAlso Double.TryParse(filamentusage.Text, par) Then
            filamentCost.Text = Double.Parse(costPerMeter.Text) * (Double.Parse(filamentusage.Text) * modUse)
        End If

        'This is run if the user pu in the mass, density, and diameter of the filament.
        If radio_o.Checked AndAlso Double.TryParse(spoolmass.Text, par) AndAlso Double.TryParse(filamentdensity.Text, par) AndAlso Double.TryParse(filamentdiameter.Text, par) AndAlso Double.TryParse(filamentusage.Text, par) AndAlso Double.TryParse(spoolcost.Text, par) Then
            Dim length As Double
            Dim density = Double.Parse(filamentdensity.Text)
            Dim diameter = Double.Parse(filamentdiameter.Text)
            Dim mass = Double.Parse(spoolmass.Text)

            length = mass / (density * Math.PI * Math.Pow(diameter / 2, 2))
            filamentamount_meters.Text = length

            costPerMeter.Text = Double.Parse(spoolcost.Text) / length

            filamentCost.Text = Double.Parse(costPerMeter.Text) * (Double.Parse(filamentusage.Text) * modUse)
        End If

        'This is run if the user put in the amount of filament that came on the spool.
        If radio_m.Checked AndAlso Double.TryParse(spoolcost.Text, par) AndAlso Double.TryParse(filamentamount_meters.Text, par) AndAlso Double.TryParse(filamentusage.Text, par) Then
            costPerMeter.Text = Double.Parse(spoolcost.Text) / Double.Parse(filamentamount_meters.Text)

            filamentCost.Text = Double.Parse(costPerMeter.Text) * (Double.Parse(filamentusage.Text) * modUse)

        End If

        If filamentCost.Text Is "" Then
            filamentCost.Text = 0
        End If

    End Sub

    'This is called when one of the radio buttons is selected.
    Private Sub radio_cpm_CheckedChanged(sender As Object, e As EventArgs) Handles radio_cpm.CheckedChanged

        'Unselects other radio buttons and enables/disables the correct fields.
        If radio_cpm.Checked Then
            radio_m.Checked = False
            radio_o.Checked = False
            filamentamount_meters.Enabled = False
            spoolmass.Enabled = False
            filamentdensity.Enabled = False
            filamentdiameter.Enabled = False
            costPerMeter.Enabled = True
            spoolcost.Enabled = False
        End If
    End Sub

    'This is called when one of the radio buttons is selected.
    Private Sub radio_meters_CheckedChanged(sender As Object, e As EventArgs) Handles radio_meters.CheckedChanged

        If radio_meters.Checked Then
            radio_mm.Checked = False
        End If
    End Sub

    'This is called when one of the radio buttons is selected.
    Private Sub radio_mm_CheckedChanged(sender As Object, e As EventArgs) Handles radio_mm.CheckedChanged

        If radio_mm.Checked Then
            radio_meters.Checked = False
        End If
    End Sub

    'This is run when the user presses ok on the open file dialog
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        'Get the location and name of the file.
        fileName = OpenFileDialog1.FileName
        'Dim objStreamReader As StreamReader

        'objStreamReader = New StreamReader(fileName)
        'costPerMeter.Text = objStreamReader.ReadLine
        'workerHourly.Text = objStreamReader.ReadLine
        'printerCostPerHour.Text = objStreamReader.ReadLine
        'upchargePercent.Text = objStreamReader.ReadLine

        'objStreamReader.Close()


        radio_cpm.Checked = True
        SaveFileDialog1.FileName = fileName
        My.Settings.lastFileName = fileName
        loadProfile(fileName)


    End Sub

    Public Sub loadProfile(fileName1 As String)
        Dim strLine As String
        Dim number As Integer
        number = 0

        Dim reader = New StreamReader(fileName1)

        strLine = reader.ReadLine



        Do While Not strLine Is Nothing

            ReDim Preserve filamentSettings(number)
            Dim buffer() = strLine.Split(":")

            filamentSettings(number) = {buffer(0), buffer(1), buffer(2), buffer(3), buffer(4)}


            strLine = reader.ReadLine

            If strLine IsNot Nothing Then
                number += 1

            End If

        Loop

        For counter As Integer = 0 To (number)

            comboTool.Items.Add(filamentSettings(counter)(0))


        Next

        reader.Close()

        setProfileSpool(0)

    End Sub

    Public Sub setProfileSpool(spoolNumber As Integer)

        comboTool.SelectedIndex = spoolNumber

    End Sub

    'This is run when the user wants to open saved settings, opens the open file dialog.
    Private Sub openSettings_Click(sender As Object, e As EventArgs) Handles openSettings.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    'This is run when the user clicks the save setting button in the menu strip.
    Private Sub saveFilSet_Click(sender As Object, e As EventArgs) Handles saveFilSet.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        fileName = SaveFileDialog1.FileName

        Dim objStreamWriter As StreamWriter

        objStreamWriter = New StreamWriter(fileName)

        For index As Integer = 0 To filamentSettings.Length - 1

            objStreamWriter.WriteLine(filamentSettings(index)(0) + ":" + filamentSettings(index)(1) + ":" + filamentSettings(index)(2) + ":" + filamentSettings(index)(3) + ":" + filamentSettings(index)(4))

        Next

        objStreamWriter.Close()

        OpenFileDialog1.FileName = fileName
        My.Settings.lastFileName = fileName
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comboTool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTool.SelectedIndexChanged




        If filamentSettings(comboTool.SelectedIndex)(0) IsNot Nothing Then

            costPerMeter.Text = filamentSettings(comboTool.SelectedIndex)(1)
            workerHourly.Text = filamentSettings(comboTool.SelectedIndex)(2)
            printerCostPerHour.Text = filamentSettings(comboTool.SelectedIndex)(3)
            upchargePercent.Text = filamentSettings(comboTool.SelectedIndex)(4)

        Else
            costPerMeter.Text = 0
            workerHourly.Text = 0
            printerCostPerHour.Text = 0
            upchargePercent.Text = 0
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim par1 As New Form2
        par1.Show()
    End Sub

    Public Sub createNewEmptySpool(name As String, index As Integer)

        ReDim Preserve filamentSettings(index)

        filamentSettings(index) = {name, 0, 0, 0, 0}
        comboTool.Items.Add(name)
        comboTool.SelectedIndex = index

    End Sub

    Private Sub comboTool_GotFocus(sender As Object, e As EventArgs) Handles comboTool.GotFocus
        Dim index = comboTool.SelectedIndex

        filamentSettings(index)(1) = costPerMeter.Text
        filamentSettings(index)(2) = workerHourly.Text
        filamentSettings(index)(3) = printerCostPerHour.Text
        filamentSettings(index)(4) = upchargePercent.Text
    End Sub
End Class
