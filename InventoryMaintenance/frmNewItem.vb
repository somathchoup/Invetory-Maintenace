Public Class frmNewItem

    Public InvItem As InvItem

    Private Sub frmNewItem_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        Me.LoadComboBox()
    End Sub

    Private Sub LoadComboBox()
        cboSizeOrManufacturer.Items.Clear()
        If rdoPlant.Checked Then
            cboSizeOrManufacturer.Items.Add("1 gallon")
            cboSizeOrManufacturer.Items.Add("5 gallon")
            cboSizeOrManufacturer.Items.Add("15 gallon")
            cboSizeOrManufacturer.Items.Add("24-inch box")
            cboSizeOrManufacturer.Items.Add("36-inch box")
        Else
            cboSizeOrManufacturer.Items.Add("Bayer")
            cboSizeOrManufacturer.Items.Add("Jobe's")
            cboSizeOrManufacturer.Items.Add("Ortho")
            cboSizeOrManufacturer.Items.Add("Roundup")
            cboSizeOrManufacturer.Items.Add("Scotts")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object,
            e As EventArgs) Handles btnSave.Click
        If IsValidData() Then
            ' Creates new items depending on checkbox selected.
            If rdoPlant.Checked Then
                InvItem = New Plant(CInt(txtItemNo.Text),
                                  txtDescription.Text, CDec(txtPrice.Text), cboSizeOrManufacturer.Text)
            Else
                InvItem = New Supply(CInt(txtItemNo.Text),
                                  txtDescription.Text, CDec(txtPrice.Text), cboSizeOrManufacturer.Text)
            End If

            Me.Close()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Return Validator.IsPresent(txtItemNo) AndAlso
               Validator.IsInt32(txtItemNo) AndAlso
               Validator.IsPresent(txtDescription) AndAlso
               Validator.IsPresent(txtPrice) AndAlso
               Validator.IsDecimal(txtPrice)
    End Function

    Private Sub btnCancel_Click(sender As Object,
            e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rdoPlant_CheckedChanged(sender As Object,
            e As EventArgs) Handles rdoPlant.CheckedChanged
        If rdoPlant.Checked Then
            lblSizeOrManufacturer.Text = "Size:"
        Else
            lblSizeOrManufacturer.Text = "Manufacturer:"
        End If
        Me.LoadComboBox()
        txtItemNo.Select()
    End Sub
End Class