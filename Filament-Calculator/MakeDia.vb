Imports System.Data.SqlClient

Public Class MakeDia

    Public dbConnection As New SqlConnection
    Public dbCmd As New SqlCommand

    Private Sub MakeDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbConnection.ConnectionString = My.Settings.FilamentProfileConnectionString
        dbConnection.Open()
        dbCmd.Connection = dbConnection
        dbCmd.CommandType = CommandType.Text
        dbCmd.CommandText = "select name from Spool;"

        Dim reader As SqlDataReader = dbCmd.ExecuteReader

        While reader.Read
            Try
                ComboBox1.Items.Add(reader.GetString(0))
            Catch ex As Exception

            End Try
        End While

        reader.Close()
        dbConnection.Close()
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        Form1.makeWithSpool(ComboBox1.Text, Me)
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub
End Class