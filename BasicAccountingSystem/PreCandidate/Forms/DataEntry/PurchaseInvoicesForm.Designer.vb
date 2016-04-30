<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseInvoicesForm
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
        Me.components = New System.ComponentModel.Container()
        Dim InventoryIDLabel As System.Windows.Forms.Label
        Dim VendorIDLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim QtyBoughtLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseInvoicesForm))
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.PurchaseInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseInvoicesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.PurchaseInvoicesTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.InventoryTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.InventoryTableAdapter()
        Me.VendorsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.VendorsTableAdapter()
        Me.PurchaseInvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PurchaseInvoicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InventoryIDComboBox = New System.Windows.Forms.ComboBox()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.QtyBoughtNumericUpDown = New System.Windows.Forms.NumericUpDown()
        InventoryIDLabel = New System.Windows.Forms.Label()
        VendorIDLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        QtyBoughtLabel = New System.Windows.Forms.Label()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseInvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseInvoicesBindingNavigator.SuspendLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyBoughtNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventoryIDLabel
        '
        InventoryIDLabel.AutoSize = True
        InventoryIDLabel.Location = New System.Drawing.Point(47, 110)
        InventoryIDLabel.Name = "InventoryIDLabel"
        InventoryIDLabel.Size = New System.Drawing.Size(82, 13)
        InventoryIDLabel.TabIndex = 1
        InventoryIDLabel.Text = "Supply Number:"
        '
        'VendorIDLabel
        '
        VendorIDLabel.AutoSize = True
        VendorIDLabel.Location = New System.Drawing.Point(47, 59)
        VendorIDLabel.Name = "VendorIDLabel"
        VendorIDLabel.Size = New System.Drawing.Size(84, 13)
        VendorIDLabel.TabIndex = 3
        VendorIDLabel.Text = "Vendor Number:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(222, 59)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(48, 207)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 9
        PriceLabel.Text = "Price:"
        '
        'QtyBoughtLabel
        '
        QtyBoughtLabel.AutoSize = True
        QtyBoughtLabel.Location = New System.Drawing.Point(47, 158)
        QtyBoughtLabel.Name = "QtyBoughtLabel"
        QtyBoughtLabel.Size = New System.Drawing.Size(86, 13)
        QtyBoughtLabel.TabIndex = 10
        QtyBoughtLabel.Text = "Quantity Bought:"
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseInvoicesBindingSource
        '
        Me.PurchaseInvoicesBindingSource.DataMember = "PurchaseInvoices"
        Me.PurchaseInvoicesBindingSource.DataSource = Me.CakeDataSet
        '
        'PurchaseInvoicesTableAdapter
        '
        Me.PurchaseInvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Me.PurchaseInvoicesTableAdapter
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Nothing
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Me.VendorsTableAdapter
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'PurchaseInvoicesBindingNavigator
        '
        Me.PurchaseInvoicesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PurchaseInvoicesBindingNavigator.BindingSource = Me.PurchaseInvoicesBindingSource
        Me.PurchaseInvoicesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PurchaseInvoicesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PurchaseInvoicesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PurchaseInvoicesBindingNavigatorSaveItem})
        Me.PurchaseInvoicesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PurchaseInvoicesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PurchaseInvoicesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PurchaseInvoicesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PurchaseInvoicesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PurchaseInvoicesBindingNavigator.Name = "PurchaseInvoicesBindingNavigator"
        Me.PurchaseInvoicesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PurchaseInvoicesBindingNavigator.Size = New System.Drawing.Size(456, 25)
        Me.PurchaseInvoicesBindingNavigator.TabIndex = 0
        Me.PurchaseInvoicesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PurchaseInvoicesBindingNavigatorSaveItem
        '
        Me.PurchaseInvoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PurchaseInvoicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PurchaseInvoicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PurchaseInvoicesBindingNavigatorSaveItem.Name = "PurchaseInvoicesBindingNavigatorSaveItem"
        Me.PurchaseInvoicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PurchaseInvoicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InventoryIDComboBox
        '
        Me.InventoryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseInvoicesBindingSource, "InventoryID", True))
        Me.InventoryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InventoryBindingSource, "InventoryID", True))
        Me.InventoryIDComboBox.DataSource = Me.InventoryBindingSource
        Me.InventoryIDComboBox.DisplayMember = "InventoryID"
        Me.InventoryIDComboBox.FormattingEnabled = True
        Me.InventoryIDComboBox.Location = New System.Drawing.Point(50, 126)
        Me.InventoryIDComboBox.Name = "InventoryIDComboBox"
        Me.InventoryIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.InventoryIDComboBox.TabIndex = 2
        Me.InventoryIDComboBox.ValueMember = "InventoryID"
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.CakeDataSet
        '
        'VendorIDComboBox
        '
        Me.VendorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseInvoicesBindingSource, "VendorID", True))
        Me.VendorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorsBindingSource, "VendorID", True))
        Me.VendorIDComboBox.DataSource = Me.VendorsBindingSource
        Me.VendorIDComboBox.DisplayMember = "VendorID"
        Me.VendorIDComboBox.FormattingEnabled = True
        Me.VendorIDComboBox.Location = New System.Drawing.Point(50, 75)
        Me.VendorIDComboBox.Name = "VendorIDComboBox"
        Me.VendorIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VendorIDComboBox.TabIndex = 4
        Me.VendorIDComboBox.ValueMember = "VendorID"
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.CakeDataSet
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseInvoicesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(225, 75)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(197, 93)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'PriceNumericUpDown
        '
        Me.PriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchaseInvoicesBindingSource, "Price", True))
        Me.PriceNumericUpDown.DecimalPlaces = 2
        Me.PriceNumericUpDown.Location = New System.Drawing.Point(50, 223)
        Me.PriceNumericUpDown.Name = "PriceNumericUpDown"
        Me.PriceNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.PriceNumericUpDown.TabIndex = 10
        '
        'QtyBoughtNumericUpDown
        '
        Me.QtyBoughtNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchaseInvoicesBindingSource, "QtyBought", True))
        Me.QtyBoughtNumericUpDown.Location = New System.Drawing.Point(50, 174)
        Me.QtyBoughtNumericUpDown.Name = "QtyBoughtNumericUpDown"
        Me.QtyBoughtNumericUpDown.Size = New System.Drawing.Size(64, 20)
        Me.QtyBoughtNumericUpDown.TabIndex = 11
        '
        'PurchaseInvoicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 266)
        Me.Controls.Add(QtyBoughtLabel)
        Me.Controls.Add(Me.QtyBoughtNumericUpDown)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceNumericUpDown)
        Me.Controls.Add(InventoryIDLabel)
        Me.Controls.Add(Me.InventoryIDComboBox)
        Me.Controls.Add(VendorIDLabel)
        Me.Controls.Add(Me.VendorIDComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PurchaseInvoicesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PurchaseInvoicesForm"
        Me.Text = "Purchases"
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseInvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchaseInvoicesBindingNavigator.ResumeLayout(False)
        Me.PurchaseInvoicesBindingNavigator.PerformLayout()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyBoughtNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents PurchaseInvoicesBindingSource As BindingSource
    Friend WithEvents PurchaseInvoicesTableAdapter As CakeDataSetTableAdapters.PurchaseInvoicesTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PurchaseInvoicesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PurchaseInvoicesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InventoryIDComboBox As ComboBox
    Friend WithEvents VendorIDComboBox As ComboBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PriceNumericUpDown As NumericUpDown
    Friend WithEvents VendorsTableAdapter As CakeDataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents VendorsBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As CakeDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents QtyBoughtNumericUpDown As NumericUpDown
End Class
