Public Class InvItem
    Private m_ItemNo As Integer
    Private m_Description As String
    Private m_Price As Decimal

    Public Sub New()

    End Sub

    Public Sub New(itemNo As Integer, description As String, price As Decimal)
        Me.ItemNo = itemNo
        Me.Description = description
        Me.Price = price
    End Sub

    Public Property ItemNo As Integer
        Get
            Return m_ItemNo
        End Get
        Set(value As Integer)
            m_ItemNo = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return m_Price
        End Get
        Set(value As Decimal)
            m_Price = value
        End Set
    End Property

    ' Creates an overridable function.
    Public Overridable Function GetDisplayText(sep As String) As String
        Return ItemNo & "    " & Description & " (" & FormatCurrency(Price) & ")"
    End Function
End Class
