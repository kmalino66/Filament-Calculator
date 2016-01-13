Public Class Form2
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Dim number
        If Form1.filamentSettings Is Nothing Then
            number = 0
        Else
            number = Form1.filamentSettings.Length
        End If


        If spoolNameTextBox.Text IsNot Nothing And spoolNameTextBox.Text IsNot "" Then

            Form1.createNewEmptySpool(spoolNameTextBox.Text, number)

            number = Nothing

            Me.Close()


        End If

    End Sub
End Class