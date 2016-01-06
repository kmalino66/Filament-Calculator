Imports Microsoft.VisualBasic

Public Class FSpool

    'We will have all the spools information!!!
    Private spoolName As String = ""
    Private spoolType As String
    Private spoolAvailable As Double
    Private spoolOriginal As Double
    Private spoolCost As Double

    'This is constructor. All vars are required
    Sub New(name As String, type As String, cost As Double, available As Double, original As Double)
        spoolName = name
        spoolAvailable = available
        spoolOriginal = original
        spoolType = type
        spoolCost = cost
    End Sub

    Public Property Name() As String
        Get
            Return spoolName
        End Get
        Set(ByVal value As String)
            spoolName = value
        End Set
    End Property

    Public Property Available() As Double
        Get
            Return spoolAvailable
        End Get
        Set(value As Double)
            spoolAvailable = value
        End Set
    End Property

    Public Property Original() As Double
        Get
            Return spoolOriginal
        End Get
        Set(value As Double)
            spoolOriginal = value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return spoolType
        End Get
        Set(value As String)
            spoolType = value
        End Set
    End Property

    Public Property Cost() As Double
        Get
            Return spoolCost
        End Get
        Set(value As Double)
            spoolCost = value
        End Set
    End Property

End Class
