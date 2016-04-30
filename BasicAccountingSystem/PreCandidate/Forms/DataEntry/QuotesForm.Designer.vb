<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuotesForm
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
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim UnitCostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuotesForm))
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.QuotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.QuotesTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.ProductsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ProductsTableAdapter()
        Me.QuotesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.QuotesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitCostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        ProductIDLabel = New System.Windows.Forms.Label()
        UnitCostLabel = New System.Windows.Forms.Label()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuotesBindingNavigator.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(31, 43)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(87, 13)
        ProductIDLabel.TabIndex = 3
        ProductIDLabel.Text = "Product Number:"
        '
        'UnitCostLabel
        '
        UnitCostLabel.AutoSize = True
        UnitCostLabel.Location = New System.Drawing.Point(31, 92)
        UnitCostLabel.Name = "UnitCostLabel"
        UnitCostLabel.Size = New System.Drawing.Size(53, 13)
        UnitCostLabel.TabIndex = 7
        UnitCostLabel.Text = "Unit Cost:"
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuotesBindingSource
        '
        Me.QuotesBindingSource.DataMember = "Quotes"
        Me.QuotesBindingSource.DataSource = Me.CakeDataSet
        '
        'QuotesTableAdapter
        '
        Me.QuotesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Me.QuotesTableAdapter
        Me.TableAdapterManager.RecipesTableAdapter = Nothing
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'QuotesBindingNavigator
        '
        Me.QuotesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QuotesBindingNavigator.BindingSource = Me.QuotesBindingSource
        Me.QuotesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QuotesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QuotesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QuotesBindingNavigatorSaveItem})
        Me.QuotesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QuotesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QuotesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QuotesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QuotesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QuotesBindingNavigator.Name = "QuotesBindingNavigator"
        Me.QuotesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QuotesBindingNavigator.Size = New System.Drawing.Size(296, 25)
        Me.QuotesBindingNavigator.TabIndex = 0
        Me.QuotesBindingNavigator.Text = "BindingNavigator1"
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
        'QuotesBindingNavigatorSaveItem
        '
        Me.QuotesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QuotesBindingNavigatorSaveItem.Image = CType(resources.GetObject("QuotesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QuotesBindingNavigatorSaveItem.Name = "QuotesBindingNavigatorSaveItem"
        Me.QuotesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QuotesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuotesBindingSource, "ProductID", True))
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource, "ProductID", True))
        Me.ProductIDComboBox.DataSource = Me.ProductsBindingSource
        Me.ProductIDComboBox.DisplayMember = "ProductID"
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(34, 59)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProductIDComboBox.TabIndex = 4
        Me.ProductIDComboBox.ValueMember = "ProductID"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.CakeDataSet
        '
        'UnitCostNumericUpDown
        '
        Me.UnitCostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QuotesBindingSource, "UnitCost", True))
        Me.UnitCostNumericUpDown.DecimalPlaces = 2
        Me.UnitCostNumericUpDown.Location = New System.Drawing.Point(34, 108)
        Me.UnitCostNumericUpDown.Name = "UnitCostNumericUpDown"
        Me.UnitCostNumericUpDown.Size = New System.Drawing.Size(121, 20)
        Me.UnitCostNumericUpDown.TabIndex = 8
        '
        'QuotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 158)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDComboBox)
        Me.Controls.Add(UnitCostLabel)
        Me.Controls.Add(Me.UnitCostNumericUpDown)
        Me.Controls.Add(Me.QuotesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuotesForm"
        Me.Text = "Quotes"
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuotesBindingNavigator.ResumeLayout(False)
        Me.QuotesBindingNavigator.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents QuotesBindingSource As BindingSource
    Friend WithEvents QuotesTableAdapter As CakeDataSetTableAdapters.QuotesTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents QuotesBindingNavigator As BindingNavigator
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
    Friend WithEvents QuotesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductIDComboBox As ComboBox
    Friend WithEvents UnitCostNumericUpDown As NumericUpDown
    Friend WithEvents ProductsTableAdapter As CakeDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As BindingSource
End Class
