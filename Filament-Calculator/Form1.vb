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
End Class
