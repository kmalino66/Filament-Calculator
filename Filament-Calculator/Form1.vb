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

            dbConnection.Close()

        End If

    End Sub
End Class
