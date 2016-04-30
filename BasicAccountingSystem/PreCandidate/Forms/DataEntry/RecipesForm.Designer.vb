<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecipesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim RecipeIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecipesForm))
        Me.RecipesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RecipesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
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
        Me.RecipesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.bSupplies = New System.Windows.Forms.Button()
        Me.RecipesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.RecipesTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.JoinRecipeAndInventoryTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.JoinRecipeAndInventoryTableAdapter()
        Me.JoinRecipeAndInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoinRecipeAndInventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.InventoryTableAdapter()
        Me.RecipeIDLabel1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        RecipeIDLabel = New System.Windows.Forms.Label()
        CType(Me.RecipesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecipesBindingNavigator.SuspendLayout()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoinRecipeAndInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoinRecipeAndInventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(32, 92)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(75, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Recipe Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(32, 143)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'RecipeIDLabel
        '
        RecipeIDLabel.AutoSize = True
        RecipeIDLabel.Location = New System.Drawing.Point(32, 38)
        RecipeIDLabel.Name = "RecipeIDLabel"
        RecipeIDLabel.Size = New System.Drawing.Size(84, 13)
        RecipeIDLabel.TabIndex = 8
        RecipeIDLabel.Text = "Recipe Number:"
        '
        'RecipesBindingNavigator
        '
        Me.RecipesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecipesBindingNavigator.BindingSource = Me.RecipesBindingSource
        Me.RecipesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RecipesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RecipesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecipesBindingNavigatorSaveItem})
        Me.RecipesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecipesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecipesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecipesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecipesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecipesBindingNavigator.Name = "RecipesBindingNavigator"
        Me.RecipesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecipesBindingNavigator.Size = New System.Drawing.Size(386, 25)
        Me.RecipesBindingNavigator.TabIndex = 0
        Me.RecipesBindingNavigator.Text = "BindingNavigator1"
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
        'RecipesBindingSource
        '
        Me.RecipesBindingSource.DataMember = "Recipes"
        Me.RecipesBindingSource.DataSource = Me.CakeDataSet
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RecipesBindingNavigatorSaveItem
        '
        Me.RecipesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecipesBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecipesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecipesBindingNavigatorSaveItem.Name = "RecipesBindingNavigatorSaveItem"
        Me.RecipesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RecipesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipesBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(35, 108)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(177, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(35, 159)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(207, 78)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'bSupplies
        '
        Me.bSupplies.Location = New System.Drawing.Point(39, 247)
        Me.bSupplies.Name = "bSupplies"
        Me.bSupplies.Size = New System.Drawing.Size(84, 23)
        Me.bSupplies.TabIndex = 8
        Me.bSupplies.Text = "Add Supplies"
        Me.bSupplies.UseVisualStyleBackColor = True
        '
        'RecipesTableAdapter
        '
        Me.RecipesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Me.JoinRecipeAndInventoryTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Me.RecipesTableAdapter
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'JoinRecipeAndInventoryTableAdapter
        '
        Me.JoinRecipeAndInventoryTableAdapter.ClearBeforeFill = True
        '
        'JoinRecipeAndInventoryBindingSource
        '
        Me.JoinRecipeAndInventoryBindingSource.DataMember = "FK__JoinRecip__Recip__73852659"
        Me.JoinRecipeAndInventoryBindingSource.DataSource = Me.RecipesBindingSource
        '
        'JoinRecipeAndInventoryDataGridView
        '
        Me.JoinRecipeAndInventoryDataGridView.AutoGenerateColumns = False
        Me.JoinRecipeAndInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JoinRecipeAndInventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.JoinRecipeAndInventoryDataGridView.DataSource = Me.JoinRecipeAndInventoryBindingSource
        Me.JoinRecipeAndInventoryDataGridView.Location = New System.Drawing.Point(12, 276)
        Me.JoinRecipeAndInventoryDataGridView.Name = "JoinRecipeAndInventoryDataGridView"
        Me.JoinRecipeAndInventoryDataGridView.Size = New System.Drawing.Size(354, 140)
        Me.JoinRecipeAndInventoryDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "JoinID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "JoinID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RecipeID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RecipeID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InventoryID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.InventoryBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Supplies"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "InventoryID"
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.CakeDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'RecipeIDLabel1
        '
        Me.RecipeIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipesBindingSource, "RecipeID", True))
        Me.RecipeIDLabel1.Location = New System.Drawing.Point(32, 60)
        Me.RecipeIDLabel1.Name = "RecipeIDLabel1"
        Me.RecipeIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.RecipeIDLabel1.TabIndex = 9
        Me.RecipeIDLabel1.Text = "Label1"
        '
        'RecipesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 435)
        Me.Controls.Add(RecipeIDLabel)
        Me.Controls.Add(Me.RecipeIDLabel1)
        Me.Controls.Add(Me.JoinRecipeAndInventoryDataGridView)
        Me.Controls.Add(Me.bSupplies)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.RecipesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecipesForm"
        Me.Text = "Recipes"
        CType(Me.RecipesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecipesBindingNavigator.ResumeLayout(False)
        Me.RecipesBindingNavigator.PerformLayout()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoinRecipeAndInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoinRecipeAndInventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents RecipesBindingSource As BindingSource
    Friend WithEvents RecipesTableAdapter As CakeDataSetTableAdapters.RecipesTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecipesBindingNavigator As BindingNavigator
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
    Friend WithEvents RecipesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents bSupplies As Button
    Friend WithEvents JoinRecipeAndInventoryBindingSource As BindingSource
    Friend WithEvents JoinRecipeAndInventoryTableAdapter As CakeDataSetTableAdapters.JoinRecipeAndInventoryTableAdapter
    Friend WithEvents JoinRecipeAndInventoryDataGridView As DataGridView
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As CakeDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents RecipeIDLabel1 As Label
End Class
