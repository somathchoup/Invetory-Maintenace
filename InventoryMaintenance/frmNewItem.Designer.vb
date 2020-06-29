<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblSizeOrManufacturer = New System.Windows.Forms.Label()
        Me.cboSizeOrManufacturer = New System.Windows.Forms.ComboBox()
        Me.rdoPlant = New System.Windows.Forms.RadioButton()
        Me.rdoSupply = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(95, 129)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.Tag = "Price"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 132)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Price:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(210, 171)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(95, 171)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(95, 75)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 20)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.Tag = "Description"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 79)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Description:"
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(95, 49)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(76, 20)
        Me.txtItemNo.TabIndex = 1
        Me.txtItemNo.Tag = "Item no"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Item no:"
        '
        'lblSizeOrManufacturer
        '
        Me.lblSizeOrManufacturer.AutoSize = True
        Me.lblSizeOrManufacturer.Location = New System.Drawing.Point(16, 105)
        Me.lblSizeOrManufacturer.Name = "lblSizeOrManufacturer"
        Me.lblSizeOrManufacturer.Size = New System.Drawing.Size(30, 13)
        Me.lblSizeOrManufacturer.TabIndex = 4
        Me.lblSizeOrManufacturer.Text = "Size:"
        '
        'cboSizeOrManufacturer
        '
        Me.cboSizeOrManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSizeOrManufacturer.FormattingEnabled = True
        Me.cboSizeOrManufacturer.Location = New System.Drawing.Point(95, 101)
        Me.cboSizeOrManufacturer.Name = "cboSizeOrManufacturer"
        Me.cboSizeOrManufacturer.Size = New System.Drawing.Size(121, 21)
        Me.cboSizeOrManufacturer.TabIndex = 5
        '
        'rdoPlant
        '
        Me.rdoPlant.AutoSize = True
        Me.rdoPlant.Checked = True
        Me.rdoPlant.Location = New System.Drawing.Point(83, 13)
        Me.rdoPlant.Name = "rdoPlant"
        Me.rdoPlant.Size = New System.Drawing.Size(49, 17)
        Me.rdoPlant.TabIndex = 10
        Me.rdoPlant.TabStop = True
        Me.rdoPlant.Text = "Plant"
        Me.rdoPlant.UseVisualStyleBackColor = True
        '
        'rdoSupply
        '
        Me.rdoSupply.AutoSize = True
        Me.rdoSupply.Location = New System.Drawing.Point(158, 13)
        Me.rdoSupply.Name = "rdoSupply"
        Me.rdoSupply.Size = New System.Drawing.Size(57, 17)
        Me.rdoSupply.TabIndex = 11
        Me.rdoSupply.TabStop = True
        Me.rdoSupply.Text = "Supply"
        Me.rdoSupply.UseVisualStyleBackColor = True
        '
        'frmNewItem
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(315, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdoSupply)
        Me.Controls.Add(Me.rdoPlant)
        Me.Controls.Add(Me.cboSizeOrManufacturer)
        Me.Controls.Add(Me.lblSizeOrManufacturer)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Inventory Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtPrice As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtItemNo As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lblSizeOrManufacturer As System.Windows.Forms.Label
    Friend WithEvents cboSizeOrManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents rdoPlant As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSupply As System.Windows.Forms.RadioButton
End Class
