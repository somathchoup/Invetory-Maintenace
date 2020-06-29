' New class that inherics InvItem
Public Class Plant
    Inherits InvItem

    Private m_Size As String

    ' Default constructor
    Public Sub New()

    End Sub

    ' Constructor that accepts four parameters.
    Public Sub New(ItemNo As Integer, description As String, price As Decimal, Size As String)
        ' Calls the base class to initialize the properties
        MyBase.New(ItemNo, description, price)
        ' Sets the size string
        Me.Size = Size
    End Sub

    ' Creates a public property
    Public Property Size As String
        Get
            Return m_Size
        End Get
        Set(value As String)
            m_Size = value
        End Set
    End Property


    ' Overrides the GetDisplayText function
    Public Overrides Function GetDisplayText(sep As String) As String
        Return ItemNo & "    " & Size & " " & Description & " (" & FormatCurrency(Price) & ")"
    End Function

End Class
