<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientsForm
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
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientsForm))
        Me.ClientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ClientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ClientsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ClientsTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.ClientIDLabel1 = New System.Windows.Forms.Label()
        ClientNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        ClientIDLabel = New System.Windows.Forms.Label()
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientsBindingNavigator.SuspendLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.Location = New System.Drawing.Point(37, 84)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(67, 13)
        ClientNameLabel.TabIndex = 1
        ClientNameLabel.Text = "Client Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(37, 123)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 3
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(39, 168)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 5
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(39, 207)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 7
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(143, 123)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 9
        ZipLabel.Text = "Zip:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(41, 249)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 11
        CountryLabel.Text = "Country:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(188, 120)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "Phone:"
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(37, 40)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(76, 13)
        ClientIDLabel.TabIndex = 15
        ClientIDLabel.Text = "Client Number:"
        '
        'ClientsBindingNavigator
        '
        Me.ClientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientsBindingNavigator.BindingSource = Me.ClientsBindingSource
        Me.ClientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientsBindingNavigatorSaveItem})
        Me.ClientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientsBindingNavigator.Name = "ClientsBindingNavigator"
        Me.ClientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientsBindingNavigator.Size = New System.Drawing.Size(311, 25)
        Me.ClientsBindingNavigator.TabIndex = 0
        Me.ClientsBindingNavigator.Text = "BindingNavigator1"
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
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.CakeDataSet
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
        'ClientsBindingNavigatorSaveItem
        '
        Me.ClientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientsBindingNavigatorSaveItem.Name = "ClientsBindingNavigatorSaveItem"
        Me.ClientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientNameTextBox
        '
        Me.ClientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientName", True))
        Me.ClientNameTextBox.Location = New System.Drawing.Point(40, 100)
        Me.ClientNameTextBox.Name = "ClientNameTextBox"
        Me.ClientNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClientNameTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(40, 139)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 4
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(40, 184)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 6
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(40, 223)
        Me.StateTextBox.MaxLength = 10
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(72, 20)
        Me.StateTextBox.TabIndex = 8
        '
        'ZipMaskedTextBox
        '
        Me.ZipMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Zip", True))
        Me.ZipMaskedTextBox.Location = New System.Drawing.Point(146, 139)
        Me.ZipMaskedTextBox.Mask = "00000"
        Me.ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        Me.ZipMaskedTextBox.Size = New System.Drawing.Size(39, 20)
        Me.ZipMaskedTextBox.TabIndex = 10
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(42, 265)
        Me.CountryTextBox.MaxLength = 10
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 12
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Phone", True))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(191, 139)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.PhoneMaskedTextBox.TabIndex = 14
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Nothing
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'ClientIDLabel1
        '
        Me.ClientIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "ClientID", True))
        Me.ClientIDLabel1.Location = New System.Drawing.Point(37, 61)
        Me.ClientIDLabel1.Name = "ClientIDLabel1"
        Me.ClientIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ClientIDLabel1.TabIndex = 16
        Me.ClientIDLabel1.Text = "Label1"
        '
        'ClientsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 310)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDLabel1)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneMaskedTextBox)
        Me.Controls.Add(ClientNameLabel)
        Me.Controls.Add(Me.ClientNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipMaskedTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.ClientsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClientsForm"
        Me.Text = "Clients"
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientsBindingNavigator.ResumeLayout(False)
        Me.ClientsBindingNavigator.PerformLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As CakeDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientsBindingNavigator As BindingNavigator
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
    Friend WithEvents ClientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClientNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipMaskedTextBox As MaskedTextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents ClientIDLabel1 As Label
End Class
