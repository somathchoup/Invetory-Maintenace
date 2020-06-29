Public Class InvItemList
    Private invItems As List(Of InvItem)

    Public Event Changed(itemList As InvItemList)

    Public Sub New()
        invItems = New List(Of InvItem)
    End Sub

    Public ReadOnly Property Count As Integer
        Get
            Return invItems.Count
        End Get
    End Property

    Default Public Property Item(index As Integer) As InvItem
        Get
            If index < 0 OrElse index >= invItems.Count Then
                Throw New ArgumentOutOfRangeException(index.ToString)
            Else
                Return invItems(index)
            End If
        End Get
        Set(value As InvItem)
            invItems(index) = value
            RaiseEvent Changed(Me)
        End Set
    End Property

    Public Sub Add(invItem As InvItem)
        invItems.Add(invItem)
        RaiseEvent Changed(Me)
    End Sub

    Public Sub Add(itemNo As Integer, description As String, price As Decimal)
        Dim item As New InvItem(itemNo, description, price)
        invItems.Add(item)
        RaiseEvent Changed(Me)
    End Sub

    Public Sub Remove(invItem As InvItem)
        invItems.Remove(invItem)
        RaiseEvent Changed(Me)
    End Sub

    Public Shared Operator +(il As InvItemList, i As InvItem) As InvItemList
        il.Add(i)
        Return il
    End Operator

    Public Shared Operator -(il As InvItemList, i As InvItem) As InvItemList
        il.Remove(i)
        Return il
    End Operator

    Public Sub Fill()
        invItems = InvItemDB.GetItems
    End Sub

    Public Sub Save()
        InvItemDB.SaveItems(invItems)
    End Sub

End Class
