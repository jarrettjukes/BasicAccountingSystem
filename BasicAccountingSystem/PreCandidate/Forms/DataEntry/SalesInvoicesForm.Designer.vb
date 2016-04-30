<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesInvoicesForm
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
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim DateSoldLabel As System.Windows.Forms.Label
        Dim QtySoldLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesInvoicesForm))
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.SalesInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInvoicesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.SalesInvoicesTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.ClientsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ClientsTableAdapter()
        Me.ProductsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ProductsTableAdapter()
        Me.SalesInvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SalesInvoicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DateSoldDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QtySoldNumericUpDown = New System.Windows.Forms.NumericUpDown()
        ProductIDLabel = New System.Windows.Forms.Label()
        ClientIDLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        DateSoldLabel = New System.Windows.Forms.Label()
        QtySoldLabel = New System.Windows.Forms.Label()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesInvoicesBindingNavigator.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtySoldNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(33, 59)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(87, 13)
        ProductIDLabel.TabIndex = 1
        ProductIDLabel.Text = "Product Number:"
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(33, 155)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(76, 13)
        ClientIDLabel.TabIndex = 3
        ClientIDLabel.Text = "Client Number:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(262, 59)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'DateSoldLabel
        '
        DateSoldLabel.AutoSize = True
        DateSoldLabel.Location = New System.Drawing.Point(33, 204)
        DateSoldLabel.Name = "DateSoldLabel"
        DateSoldLabel.Size = New System.Drawing.Size(57, 13)
        DateSoldLabel.TabIndex = 9
        DateSoldLabel.Text = "Date Sold:"
        '
        'QtySoldLabel
        '
        QtySoldLabel.AutoSize = True
        QtySoldLabel.Location = New System.Drawing.Point(33, 107)
        QtySoldLabel.Name = "QtySoldLabel"
        QtySoldLabel.Size = New System.Drawing.Size(73, 13)
        QtySoldLabel.TabIndex = 10
        QtySoldLabel.Text = "Quantity Sold:"
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesInvoicesBindingSource
        '
        Me.SalesInvoicesBindingSource.DataMember = "SalesInvoices"
        Me.SalesInvoicesBindingSource.DataSource = Me.CakeDataSet
        '
        'SalesInvoicesTableAdapter
        '
        Me.SalesInvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Nothing
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Me.SalesInvoicesTableAdapter
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SalesInvoicesBindingNavigator
        '
        Me.SalesInvoicesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesInvoicesBindingNavigator.BindingSource = Me.SalesInvoicesBindingSource
        Me.SalesInvoicesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesInvoicesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesInvoicesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesInvoicesBindingNavigatorSaveItem})
        Me.SalesInvoicesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesInvoicesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesInvoicesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesInvoicesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesInvoicesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesInvoicesBindingNavigator.Name = "SalesInvoicesBindingNavigator"
        Me.SalesInvoicesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesInvoicesBindingNavigator.Size = New System.Drawing.Size(505, 25)
        Me.SalesInvoicesBindingNavigator.TabIndex = 0
        Me.SalesInvoicesBindingNavigator.Text = "BindingNavigator1"
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
        'SalesInvoicesBindingNavigatorSaveItem
        '
        Me.SalesInvoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesInvoicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesInvoicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesInvoicesBindingNavigatorSaveItem.Name = "SalesInvoicesBindingNavigatorSaveItem"
        Me.SalesInvoicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesInvoicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoicesBindingSource, "ProductID", True))
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource, "ProductID", True))
        Me.ProductIDComboBox.DataSource = Me.ProductsBindingSource
        Me.ProductIDComboBox.DisplayMember = "ProductID"
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(36, 75)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(160, 21)
        Me.ProductIDComboBox.TabIndex = 2
        Me.ProductIDComboBox.ValueMember = "ProductID"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.CakeDataSet
        '
        'ClientIDComboBox
        '
        Me.ClientIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoicesBindingSource, "ClientID", True))
        Me.ClientIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientsBindingSource, "ClientID", True))
        Me.ClientIDComboBox.DataSource = Me.ClientsBindingSource
        Me.ClientIDComboBox.DisplayMember = "ClientID"
        Me.ClientIDComboBox.FormattingEnabled = True
        Me.ClientIDComboBox.Location = New System.Drawing.Point(36, 171)
        Me.ClientIDComboBox.Name = "ClientIDComboBox"
        Me.ClientIDComboBox.Size = New System.Drawing.Size(130, 21)
        Me.ClientIDComboBox.TabIndex = 4
        Me.ClientIDComboBox.ValueMember = "ClientID"
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.CakeDataSet
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoicesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(265, 75)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 98)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'DateSoldDateTimePicker
        '
        Me.DateSoldDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesInvoicesBindingSource, "DateSold", True))
        Me.DateSoldDateTimePicker.Location = New System.Drawing.Point(36, 220)
        Me.DateSoldDateTimePicker.Name = "DateSoldDateTimePicker"
        Me.DateSoldDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateSoldDateTimePicker.TabIndex = 10
        '
        'QtySoldNumericUpDown
        '
        Me.QtySoldNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesInvoicesBindingSource, "QtySold", True))
        Me.QtySoldNumericUpDown.Location = New System.Drawing.Point(36, 123)
        Me.QtySoldNumericUpDown.Name = "QtySoldNumericUpDown"
        Me.QtySoldNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.QtySoldNumericUpDown.TabIndex = 11
        '
        'SalesInvoicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 283)
        Me.Controls.Add(QtySoldLabel)
        Me.Controls.Add(Me.QtySoldNumericUpDown)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDComboBox)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(DateSoldLabel)
        Me.Controls.Add(Me.DateSoldDateTimePicker)
        Me.Controls.Add(Me.SalesInvoicesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesInvoicesForm"
        Me.Text = "Sales"
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesInvoicesBindingNavigator.ResumeLayout(False)
        Me.SalesInvoicesBindingNavigator.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtySoldNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents SalesInvoicesBindingSource As BindingSource
    Friend WithEvents SalesInvoicesTableAdapter As CakeDataSetTableAdapters.SalesInvoicesTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesInvoicesBindingNavigator As BindingNavigator
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
    Friend WithEvents SalesInvoicesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductIDComboBox As ComboBox
    Friend WithEvents ClientIDComboBox As ComboBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DateSoldDateTimePicker As DateTimePicker
    Friend WithEvents ProductsTableAdapter As CakeDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As CakeDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents QtySoldNumericUpDown As NumericUpDown
End Class
