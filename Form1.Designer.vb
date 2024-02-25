<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChezSouSad
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
        Me.lblDishes = New System.Windows.Forms.Label()
        Me.lblSelectedRaw = New System.Windows.Forms.Label()
        Me.lblSelectedPrep = New System.Windows.Forms.Label()
        Me.lblPreppedItems = New System.Windows.Forms.Label()
        Me.lblRawIngredients = New System.Windows.Forms.Label()
        Me.lstRaw = New System.Windows.Forms.ListBox()
        Me.lstPreppedItems = New System.Windows.Forms.ListBox()
        Me.lstSelectedRaw = New System.Windows.Forms.ListBox()
        Me.lstSelectedPrep = New System.Windows.Forms.ListBox()
        Me.lstDishes = New System.Windows.Forms.ListBox()
        Me.btnAddRaw = New System.Windows.Forms.Button()
        Me.btnAddPreppedItem = New System.Windows.Forms.Button()
        Me.btnAddDish = New System.Windows.Forms.Button()
        Me.txtAddPreppedItem = New System.Windows.Forms.TextBox()
        Me.txtAddDish = New System.Windows.Forms.TextBox()
        Me.txtRaw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDishes
        '
        Me.lblDishes.AutoSize = True
        Me.lblDishes.Location = New System.Drawing.Point(9, 18)
        Me.lblDishes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDishes.Name = "lblDishes"
        Me.lblDishes.Size = New System.Drawing.Size(86, 13)
        Me.lblDishes.TabIndex = 0
        Me.lblDishes.Text = "List of all Dishes:"
        '
        'lblSelectedRaw
        '
        Me.lblSelectedRaw.AutoSize = True
        Me.lblSelectedRaw.Location = New System.Drawing.Point(11, 299)
        Me.lblSelectedRaw.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedRaw.Name = "lblSelectedRaw"
        Me.lblSelectedRaw.Size = New System.Drawing.Size(209, 13)
        Me.lblSelectedRaw.TabIndex = 1
        Me.lblSelectedRaw.Text = "Raw Ingredients in Selected Prepped Item:"
        '
        'lblSelectedPrep
        '
        Me.lblSelectedPrep.AutoSize = True
        Me.lblSelectedPrep.Location = New System.Drawing.Point(11, 121)
        Me.lblSelectedPrep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedPrep.Name = "lblSelectedPrep"
        Me.lblSelectedPrep.Size = New System.Drawing.Size(158, 13)
        Me.lblSelectedPrep.TabIndex = 2
        Me.lblSelectedPrep.Text = "Prepped Items in Selected Dish:"
        '
        'lblPreppedItems
        '
        Me.lblPreppedItems.AutoSize = True
        Me.lblPreppedItems.Location = New System.Drawing.Point(425, 138)
        Me.lblPreppedItems.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreppedItems.Name = "lblPreppedItems"
        Me.lblPreppedItems.Size = New System.Drawing.Size(119, 13)
        Me.lblPreppedItems.TabIndex = 3
        Me.lblPreppedItems.Text = "List of all Prepped Items"
        '
        'lblRawIngredients
        '
        Me.lblRawIngredients.AutoSize = True
        Me.lblRawIngredients.Location = New System.Drawing.Point(425, 325)
        Me.lblRawIngredients.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRawIngredients.Name = "lblRawIngredients"
        Me.lblRawIngredients.Size = New System.Drawing.Size(131, 13)
        Me.lblRawIngredients.TabIndex = 4
        Me.lblRawIngredients.Text = "List of all Raw Ingredients:"
        '
        'lstRaw
        '
        Me.lstRaw.AllowDrop = True
        Me.lstRaw.FormattingEnabled = True
        Me.lstRaw.Location = New System.Drawing.Point(428, 340)
        Me.lstRaw.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRaw.Name = "lstRaw"
        Me.lstRaw.Size = New System.Drawing.Size(370, 108)
        Me.lstRaw.TabIndex = 5
        '
        'lstPreppedItems
        '
        Me.lstPreppedItems.AllowDrop = True
        Me.lstPreppedItems.FormattingEnabled = True
        Me.lstPreppedItems.Location = New System.Drawing.Point(428, 153)
        Me.lstPreppedItems.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPreppedItems.Name = "lstPreppedItems"
        Me.lstPreppedItems.Size = New System.Drawing.Size(367, 108)
        Me.lstPreppedItems.TabIndex = 6
        '
        'lstSelectedRaw
        '
        Me.lstSelectedRaw.AllowDrop = True
        Me.lstSelectedRaw.FormattingEnabled = True
        Me.lstSelectedRaw.Location = New System.Drawing.Point(14, 325)
        Me.lstSelectedRaw.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSelectedRaw.Name = "lstSelectedRaw"
        Me.lstSelectedRaw.Size = New System.Drawing.Size(364, 147)
        Me.lstSelectedRaw.TabIndex = 7
        '
        'lstSelectedPrep
        '
        Me.lstSelectedPrep.AllowDrop = True
        Me.lstSelectedPrep.FormattingEnabled = True
        Me.lstSelectedPrep.Location = New System.Drawing.Point(12, 138)
        Me.lstSelectedPrep.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSelectedPrep.Name = "lstSelectedPrep"
        Me.lstSelectedPrep.Size = New System.Drawing.Size(366, 147)
        Me.lstSelectedPrep.TabIndex = 8
        '
        'lstDishes
        '
        Me.lstDishes.FormattingEnabled = True
        Me.lstDishes.Location = New System.Drawing.Point(11, 34)
        Me.lstDishes.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDishes.Name = "lstDishes"
        Me.lstDishes.Size = New System.Drawing.Size(786, 56)
        Me.lstDishes.TabIndex = 9
        '
        'btnAddRaw
        '
        Me.btnAddRaw.Location = New System.Drawing.Point(428, 460)
        Me.btnAddRaw.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRaw.Name = "btnAddRaw"
        Me.btnAddRaw.Size = New System.Drawing.Size(85, 40)
        Me.btnAddRaw.TabIndex = 13
        Me.btnAddRaw.Text = "Add Raw Ingredient"
        Me.btnAddRaw.UseVisualStyleBackColor = True
        '
        'btnAddPreppedItem
        '
        Me.btnAddPreppedItem.Location = New System.Drawing.Point(428, 272)
        Me.btnAddPreppedItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddPreppedItem.Name = "btnAddPreppedItem"
        Me.btnAddPreppedItem.Size = New System.Drawing.Size(85, 40)
        Me.btnAddPreppedItem.TabIndex = 15
        Me.btnAddPreppedItem.Text = "Add New Prepped Item"
        Me.btnAddPreppedItem.UseVisualStyleBackColor = True
        '
        'btnAddDish
        '
        Me.btnAddDish.Location = New System.Drawing.Point(428, 94)
        Me.btnAddDish.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddDish.Name = "btnAddDish"
        Me.btnAddDish.Size = New System.Drawing.Size(85, 40)
        Me.btnAddDish.TabIndex = 16
        Me.btnAddDish.Text = "Add New Dish"
        Me.btnAddDish.UseVisualStyleBackColor = True
        '
        'txtAddPreppedItem
        '
        Me.txtAddPreppedItem.Location = New System.Drawing.Point(530, 283)
        Me.txtAddPreppedItem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddPreppedItem.Name = "txtAddPreppedItem"
        Me.txtAddPreppedItem.Size = New System.Drawing.Size(265, 20)
        Me.txtAddPreppedItem.TabIndex = 17
        '
        'txtAddDish
        '
        Me.txtAddDish.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddDish.Location = New System.Drawing.Point(530, 105)
        Me.txtAddDish.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddDish.Name = "txtAddDish"
        Me.txtAddDish.Size = New System.Drawing.Size(264, 20)
        Me.txtAddDish.TabIndex = 18
        '
        'txtRaw
        '
        Me.txtRaw.Location = New System.Drawing.Point(530, 471)
        Me.txtRaw.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRaw.Name = "txtRaw"
        Me.txtRaw.Size = New System.Drawing.Size(268, 20)
        Me.txtRaw.TabIndex = 19
        '
        'frmChezSouSad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 513)
        Me.Controls.Add(Me.txtRaw)
        Me.Controls.Add(Me.txtAddDish)
        Me.Controls.Add(Me.txtAddPreppedItem)
        Me.Controls.Add(Me.btnAddDish)
        Me.Controls.Add(Me.btnAddPreppedItem)
        Me.Controls.Add(Me.btnAddRaw)
        Me.Controls.Add(Me.lstDishes)
        Me.Controls.Add(Me.lstSelectedPrep)
        Me.Controls.Add(Me.lstSelectedRaw)
        Me.Controls.Add(Me.lstPreppedItems)
        Me.Controls.Add(Me.lstRaw)
        Me.Controls.Add(Me.lblRawIngredients)
        Me.Controls.Add(Me.lblPreppedItems)
        Me.Controls.Add(Me.lblSelectedPrep)
        Me.Controls.Add(Me.lblSelectedRaw)
        Me.Controls.Add(Me.lblDishes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmChezSouSad"
        Me.Text = "Chez SouSad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDishes As Label
    Friend WithEvents lblSelectedRaw As Label
    Friend WithEvents lblSelectedPrep As Label
    Friend WithEvents lblPreppedItems As Label
    Friend WithEvents lblRawIngredients As Label
    Friend WithEvents lstRaw As ListBox
    Friend WithEvents lstPreppedItems As ListBox
    Friend WithEvents lstSelectedRaw As ListBox
    Friend WithEvents lstSelectedPrep As ListBox
    Friend WithEvents lstDishes As ListBox
    Friend WithEvents btnAddRaw As Button
    Friend WithEvents btnAddPreppedItem As Button
    Friend WithEvents btnAddDish As Button
    Friend WithEvents txtAddPreppedItem As TextBox
    Friend WithEvents txtAddDish As TextBox
    Friend WithEvents txtRaw As TextBox
End Class
