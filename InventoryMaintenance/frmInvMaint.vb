Public Class frmInvMaint

    Dim WithEvents invItems As New InvItemList

    Private Sub frmInvMaint_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        invItems.Fill()
        Me.FillItemListBox()
    End Sub

    Private Sub FillItemListBox()
        Dim item As InvItem
        lstItems.Items.Clear()
        For i As Integer = 0 To invItems.Count - 1
            item = invItems(i)
            ' Inserted vbTab as a parameter for the GetDisplayText Function
            lstItems.Items.Add(item.GetDisplayText(vbTab))
        Next i
    End Sub

    Private Sub btnAdd_Click(sender As Object,
            e As EventArgs) Handles btnAdd.Click
        Dim newItemForm As New frmNewItem
        newItemForm.ShowDialog()
        If newItemForm.InvItem IsNot Nothing Then
            invItems += newItemForm.InvItem
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object,
            e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstItems.SelectedIndex
        If i <> -1 Then
            Dim invItem As InvItem = invItems(i)
            Dim message As String = "Are you sure you want to delete " &
                invItem.Description & "?"
            Dim button As DialogResult =
                MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo)
            If button = DialogResult.Yes Then
                invItems -= invItem
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub invItems_Changed(itemList As InvItemList) Handles invItems.Changed
        invItems.Save()
        Me.FillItemListBox()
    End Sub
End Class
