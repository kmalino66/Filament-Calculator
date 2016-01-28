Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    Public dbConnection As New SqlConnection
    Public dbCmd As New SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbConnection.ConnectionString = My.Settings.FilamentProfileConnectionString
        dbConnection.Open()
        dbCmd.Connection = dbConnection
        dbCmd.CommandType = CommandType.Text

        'just put command text in.
        dbCmd.CommandText = "select * from Profile;"

        Dim reader As SqlDataReader = dbCmd.ExecuteReader

        If reader.HasRows Then
            reader.Read()
        End If

        While reader.GetString(0) IsNot Nothing

            Try
                comboTool.Items.Add(reader.GetString(0))
                costPerMeter.Text = reader.GetDouble(1)
                workerHourly.Text = reader.GetDouble(2)
                printerCostPerHour.Text = reader.GetDouble(3)
                upchargePercent.Text = reader.GetDouble(4)

                'TODO Add handler for when the radio selected is changed.
                radio_cpm.Checked = True



            Catch ex As Exception

            End Try

            reader.Read()

        End While


        dbConnection.Close()


    End Sub

    Private Sub radio_cpm_CheckedChanged(sender As Object, e As EventArgs) Handles radio_cpm.CheckedChanged

        If radio_cpm.Checked Then
            radio_m.Checked = False
            radio_o.Checked = False
        End If

    End Sub

    Private Sub radio_m_CheckedChanged(sender As Object, e As EventArgs) Handles radio_m.CheckedChanged
        If radio_m.Checked Then
            radio_cpm.Checked = False
            radio_o.Checked = False
        End If
    End Sub

    Private Sub radio_o_CheckedChanged(sender As Object, e As EventArgs) Handles radio_o.CheckedChanged
        If radio_o.Checked Then
            radio_cpm.Checked = False
            radio_m.Checked = False
        End If
    End Sub

    Private Sub radio_meters_CheckedChanged(sender As Object, e As EventArgs) Handles radio_meters.CheckedChanged
        If radio_meters.Checked Then
            radio_mm.Checked = False
        End If
    End Sub

    Private Sub radio_mm_CheckedChanged(sender As Object, e As EventArgs) Handles radio_mm.CheckedChanged
        If radio_mm.Checked Then
            radio_meters.Checked = False
        End If
    End Sub

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

    'Calculates the total cost of the build and how much to charge the customer with the upcharge that is given.
    Public Sub calcTotalCost()

        totalCost.Text = Double.Parse(filamentCost.Text) + Double.Parse(workerCost.Text) + Double.Parse(printerTotalCost.Text)

        charge.Text = Double.Parse(totalCost.Text) + ((Double.Parse(upchargePercent.Text) / 100) * Double.Parse(filamentCost.Text))

    End Sub

    'When called this method does something special, it updates the database.
    Public Sub updateDatabase()

        ' dbConnection.ConnectionString = My.Settings.FilamentProfileConnectionString
        'dbConnection.Open()
        'dbCmd.Connection = dbConnection
        'dbCmd.CommandType = CommandType.Text

        Try
            dbConnection.Open()
            dbCmd.Connection = dbConnection

        Catch ex As Exception

        End Try

        Try
            dbCmd.CommandText = "update Profile set cost_per_meter = " + costPerMeter.Text + ", work_per_hour = " + workerHourly.Text &
                "print_per_hour = " + printerCostPerHour.Text + ", upcharge = " + upchargePercent.Text &
                "where name = " + comboTool.Text + ";"
            dbCmd.ExecuteNonQuery()
        Catch ex As Exception
            'This ends up being run if the program can't update the databse.
            Try
                dbCmd.CommandText = "insert into Profile(name, cost_per_meter, work_per_hour, print_per_hour, upcharge values" &
                    "(" + comboTool.Text + ", " + costPerMeter.Text + ", " + workerHourly.Text + ", " &
                    printerCostPerHour.Text + ", " + upchargePercent.Text + ");"
            Catch ex1 As Exception
                'Do nothing
            End Try
        End Try






    End Sub

    Private Sub comboTool_GotFocus(sender As Object, e As EventArgs) Handles comboTool.GotFocus
        updateDatabase()

    End Sub
End Class
