' New class that inherics InvItem
Public Class Supply
    Inherits InvItem

    Private m_Manufacturer As String

    ' Default constructor
    Public Sub New()

    End Sub

    ' Constructor that accepts four parameters.
    Public Sub New(ItemNo As Integer, description As String, price As Decimal, Manufacturer As String)
        ' Calls the base class to initialize the properties
        MyBase.New(ItemNo, description, price)
        ' Sets the Manufacturer string
        Me.Manufacturer = Manufacturer
    End Sub

    ' Creates a public property
    Public Property Manufacturer As String
        Get
            Return m_Manufacturer
        End Get
        Set(value As String)
            m_Manufacturer = value
        End Set
    End Property

    ' Overrides the GetDisplayText function
    Public Overrides Function GetDisplayText(sep As String) As String
        Return ItemNo & "    " & Manufacturer & " " & Description & " (" & FormatCurrency(Price) & ")"
    End Function

End Class
