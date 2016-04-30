<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Dim QtyLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.InventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.InventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.RecipesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecipesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.RecipesTableAdapter()
        Me.QtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        QtyLabel1 = New System.Windows.Forms.Label()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryBindingNavigator.SuspendLayout()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(24, 45)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(24, 71)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description:"
        '
        'QtyLabel1
        '
        QtyLabel1.AutoSize = True
        QtyLabel1.Location = New System.Drawing.Point(24, 163)
        QtyLabel1.Name = "QtyLabel1"
        QtyLabel1.Size = New System.Drawing.Size(49, 13)
        QtyLabel1.TabIndex = 7
        QtyLabel1.Text = "Quantity:"
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.CakeDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Nothing
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'InventoryBindingNavigator
        '
        Me.InventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventoryBindingNavigator.BindingSource = Me.InventoryBindingSource
        Me.InventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventoryBindingNavigatorSaveItem})
        Me.InventoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventoryBindingNavigator.Name = "InventoryBindingNavigator"
        Me.InventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventoryBindingNavigator.Size = New System.Drawing.Size(319, 25)
        Me.InventoryBindingNavigator.TabIndex = 0
        Me.InventoryBindingNavigator.Text = "BindingNavigator1"
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
        'InventoryBindingNavigatorSaveItem
        '
        Me.InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem"
        Me.InventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(93, 42)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(188, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(93, 68)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(188, 87)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'RecipesBindingSource
        '
        Me.RecipesBindingSource.DataMember = "Recipes"
        Me.RecipesBindingSource.DataSource = Me.CakeDataSet
        '
        'RecipesTableAdapter
        '
        Me.RecipesTableAdapter.ClearBeforeFill = True
        '
        'QtyNumericUpDown
        '
        Me.QtyNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InventoryBindingSource, "Qty", True))
        Me.QtyNumericUpDown.Location = New System.Drawing.Point(93, 161)
        Me.QtyNumericUpDown.Name = "QtyNumericUpDown"
        Me.QtyNumericUpDown.Size = New System.Drawing.Size(53, 20)
        Me.QtyNumericUpDown.TabIndex = 8
        Me.QtyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 209)
        Me.Controls.Add(QtyLabel1)
        Me.Controls.Add(Me.QtyNumericUpDown)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.InventoryBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventoryForm"
        Me.Text = "Supplies"
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryBindingNavigator.ResumeLayout(False)
        Me.InventoryBindingNavigator.PerformLayout()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As CakeDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventoryBindingNavigator As BindingNavigator
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
    Friend WithEvents InventoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents RecipesBindingSource As BindingSource
    Friend WithEvents RecipesTableAdapter As CakeDataSetTableAdapters.RecipesTableAdapter
    Friend WithEvents QtyNumericUpDown As NumericUpDown
End Class
