﻿Imports System.Data.SqlClient

Public Class Use_Spool_Dialogue

    Public dbConnection As New SqlConnection
    Public dbCmd As New SqlCommand

    Private Sub Use_Spool_Dialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbConnection.ConnectionString = My.Settings.FilamentProfileConnectionString

        dbConnection.Open()
        dbCmd.Connection = dbConnection
        dbCmd.CommandType = CommandType.Text
        dbCmd.CommandText = "select * from Spool"

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

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        Me.Close()
    End Sub

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        Dim money As Double = Double.Parse(money_charged_textbox.Text)
        Dim fil_used As Double = Double.Parse(text_fil.Text)

        Form1.useSpool(ComboBox1.Text, money, fil_used, Me)
    End Sub
End Class