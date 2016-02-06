Public Class New_Spool_Dialog

    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click

        Dim name = spoolname_textbox.Text
        Dim filamentAmount = spool_length_textbox.Text
        Dim cost = spool_cost_textbox.Text

        Form1.addSpool(name, filamentAmount, cost, Me)
    End Sub
End Class