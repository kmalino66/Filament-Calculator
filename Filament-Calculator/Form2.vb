﻿Public Class Form2
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Form1.createNewProfile(spoolNameTextBox.Text, Me)
    End Sub
End Class