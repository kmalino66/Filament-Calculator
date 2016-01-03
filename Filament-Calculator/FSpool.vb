Imports Microsoft.VisualBasic

Public Class FSpool
    Private spoolName As String
    Private spoolAvailable As Double
    Private spoolOriginal As Double

    Sub New(name As String, available As Double, original As Double)
        spoolName = name
        spoolAvailable = available
        spoolOriginal = original
    End Sub

    Public Sub getSpoolName()
        Return spoolName
    End Sub

    Public Sub getSpoolAvailable()
        Return spoolAvailable
    End Sub

    Public Sub getSpoolOriginal()
        Return getSpoolOriginal()
    End Sub

    Public Sub getUsedPercent()
        Return (spoolAvailable / spoolOriginal) * 100
    End Sub

End Class
