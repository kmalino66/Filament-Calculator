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


        'Get all the profiles
        dbCmd.CommandText = "select name_s from Profile;"

        Dim reader As SqlDataReader = dbCmd.ExecuteReader


        While reader.Read

            Try
                comboTool.Items.Add(reader.GetString(0))


                radio_cpm.Checked = True



            Catch ex As Exception

            End Try


        End While

        reader.Close()


        'Check for other tab
        dbCmd.CommandText = "Select name from Spool;"

        Dim reader1 As SqlDataReader = dbCmd.ExecuteReader

        While reader1.Read

            Try
                ComboBox1.Items.Add(reader1.GetString(0))
            Catch ex As Exception
                'Do nothing
            End Try
        End While

        reader1.Close()

        dbConnection.Close()


    End Sub

    Private Sub radio_cpm_CheckedChanged(sender As Object, e As EventArgs) Handles radio_cpm.CheckedChanged

        If radio_cpm.Checked Then
            radio_m.Checked = False
            radio_o.Checked = False

            amountOfFilamentSection(False)
            spoolMassSection(False)
            costPerMeterSection(True)
        End If

    End Sub

    Private Sub radio_m_CheckedChanged(sender As Object, e As EventArgs) Handles radio_m.CheckedChanged
        If radio_m.Checked Then
            radio_cpm.Checked = False
            radio_o.Checked = False

            amountOfFilamentSection(True)
            spoolMassSection(False)
            costPerMeterSection(False)
        End If
    End Sub

    Private Sub radio_o_CheckedChanged(sender As Object, e As EventArgs) Handles radio_o.CheckedChanged
        If radio_o.Checked Then
            radio_cpm.Checked = False
            radio_m.Checked = False

            amountOfFilamentSection(False)
            spoolMassSection(True)
            costPerMeterSection(False)
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

        updateDatabase()

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
            dbCmd.CommandText = "update Profile set cost_per_meter = '" + costPerMeter.Text + "', work_per_hour = '" + workerHourly.Text &
                "', print_per_hour = '" + printerCostPerHour.Text + "', upcharge = '" + upchargePercent.Text &
                "' where name_s = '" + comboTool.Text + "';"
            dbCmd.ExecuteNonQuery()
        Catch ex As Exception
            'This ends up being run if the program can't update the databse.
            Try
                dbCmd.CommandText = "insert into Profile(name_s, cost_per_meter, work_per_hour, print_per_hour, upcharge values" &
                    "('" + comboTool.Text + "', '" + costPerMeter.Text + "', '" + workerHourly.Text + "', '" &
                    printerCostPerHour.Text + "', '" + upchargePercent.Text + "');"
            Catch ex1 As Exception
                'Do nothing
            End Try
        End Try

        Try
            dbConnection.Close()
        Catch ex As Exception

        End Try






    End Sub

    Public Sub costPerMeterSection(ByVal enab As Boolean)
        costPerMeter.Enabled = enab
    End Sub

    Public Sub spoolMassSection(ByVal enab As Boolean)
        spoolmass.Enabled = enab
        filamentdensity.Enabled = enab
        filamentdiameter.Enabled = enab
    End Sub

    Public Sub amountOfFilamentSection(ByVal enab As Boolean)
        filamentamount_meters.Enabled = enab
    End Sub

    Private Sub comboTool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTool.SelectedIndexChanged


        Dim quote = """"
        Dim name1 As String = comboTool.Text

        dbConnection.Open()
        dbCmd.Connection = dbConnection
        dbCmd.CommandText = "Select * from Profile where name_s like '" + name1 + "';"

        Dim reader As SqlDataReader = dbCmd.ExecuteReader
        reader.Read()


        costPerMeter.Text = reader.GetDouble(1)
        workerHourly.Text = reader.GetDouble(2)
        printerCostPerHour.Text = reader.GetDouble(3)
        upchargePercent.Text = reader.GetDouble(4)

        reader.Close()
        dbConnection.Close()
    End Sub

    Private Sub comboTool_GotFocus(sender As Object, e As EventArgs) Handles comboTool.GotFocus
        Dim name As String = comboTool.Text

        updateDatabase()
    End Sub

    Private Sub toolstrip_new_Click(sender As Object, e As EventArgs) Handles toolstrip_new.Click
        'When they want to create a new profile, we want to bring up a box to ask them the name.
        Dim form As New Form2
        form.Show()
    End Sub

    Public Sub createNewProfile(ByVal profileName As String, ByVal form As Form2)

        Dim temp1Bool As Boolean = False

        dbConnection.Open()
        dbCmd.Connection = dbConnection

        dbCmd.CommandText = "select name_s from Profile;"
        Dim reader As SqlDataReader = dbCmd.ExecuteReader

        While reader.Read
            If profileName Is reader.GetString(0) Then
                temp1Bool = True
            End If
        End While

        reader.Close()

        If temp1Bool Then
            MsgBox("Sorry it appears that this name is already used. Please try again", MsgBoxStyle.OkOnly)
            dbConnection.Close()

        Else
            comboTool.Items.Add(profileName)

            dbCmd.CommandText = "insert into Profile(name_s, cost_per_meter, work_per_hour, print_per_hour, upcharge) values" &
                    "('" + profileName + "', '0', '0', '0', '0');"
            dbCmd.ExecuteNonQuery()
            MsgBox("Success!", MsgBoxStyle.OkOnly, "YAY")
            dbConnection.Close()


            form.Close()
        End If



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'We will want to update the text fields.

        dbConnection.Open()
        dbCmd.Connection = dbConnection
        dbCmd.CommandText = "select * from Spool where name like '" + ComboBox1.Text + "';"

        Dim reader As SqlDataReader = dbCmd.ExecuteReader

        reader.Read()

        Try
            textbox_original.Text = reader.GetDouble(1)
            textbox_available.Text = reader.GetDouble(2)
            combobox_filament_type.Text = (reader.GetString(3)) + ""
            textbox_spool_cost.Text = reader.GetDouble(4)
        Catch ex As Exception

        End Try

        reader.Close()
        dbConnection.Close()


    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus

        'Save info
        dbConnection.Open()
        dbCmd.Connection = dbConnection


        Try
            dbCmd.CommandText = "update Spool set original_filament = '" + textbox_original.Text + "', available_filament = '" + textbox_available.Text &
            "', filament_type = '" + combobox_filament_type.Text + "', spool_cost = '" + textbox_spool_cost.Text + "' where name = '" + ComboBox1.Text + "';"
            dbCmd.ExecuteNonQuery()

        Catch ex As Exception
            dbCmd.CommandText = "insert into Spool(name, original_filament, available_filament, filament_type, spool_cost) values" &
                "('" + ComboBox1.Text + "', '" + textbox_original.Text + "', '" + textbox_available.Text + "', '" + combobox_filament_type.Text &
                "', '" + textbox_spool_cost.Text + "');"
            dbCmd.ExecuteNonQuery()
        End Try

        dbConnection.Close()

    End Sub
End Class
