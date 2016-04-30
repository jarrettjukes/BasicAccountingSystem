<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorsForm
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
        Dim VendorNameLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim VendorIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorsForm))
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.VendorsTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.VendorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VendorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VendorNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.VendorIDLabel1 = New System.Windows.Forms.Label()
        VendorNameLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        VendorIDLabel = New System.Windows.Forms.Label()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendorsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'VendorNameLabel
        '
        VendorNameLabel.AutoSize = True
        VendorNameLabel.Location = New System.Drawing.Point(29, 98)
        VendorNameLabel.Name = "VendorNameLabel"
        VendorNameLabel.Size = New System.Drawing.Size(75, 13)
        VendorNameLabel.TabIndex = 1
        VendorNameLabel.Text = "Vendor Name:"
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(29, 140)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(78, 13)
        ContactNameLabel.TabIndex = 3
        ContactNameLabel.Text = "Contact Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(29, 184)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(29, 226)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 7
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(29, 273)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 9
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(135, 184)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 11
        ZipLabel.Text = "Zip:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(29, 322)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 13
        CountryLabel.Text = "Country:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(182, 184)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 15
        PhoneLabel.Text = "Phone:"
        '
        'VendorIDLabel
        '
        VendorIDLabel.AutoSize = True
        VendorIDLabel.Location = New System.Drawing.Point(32, 42)
        VendorIDLabel.Name = "VendorIDLabel"
        VendorIDLabel.Size = New System.Drawing.Size(84, 13)
        VendorIDLabel.TabIndex = 17
        VendorIDLabel.Text = "Vendor Number:"
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.CakeDataSet
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Nothing
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Me.VendorsTableAdapter
        '
        'VendorsBindingNavigator
        '
        Me.VendorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VendorsBindingNavigator.BindingSource = Me.VendorsBindingSource
        Me.VendorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VendorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VendorsBindingNavigatorSaveItem})
        Me.VendorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VendorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendorsBindingNavigator.Name = "VendorsBindingNavigator"
        Me.VendorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendorsBindingNavigator.Size = New System.Drawing.Size(305, 25)
        Me.VendorsBindingNavigator.TabIndex = 0
        Me.VendorsBindingNavigator.Text = "BindingNavigator1"
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
        'VendorsBindingNavigatorSaveItem
        '
        Me.VendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VendorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("VendorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VendorsBindingNavigatorSaveItem.Name = "VendorsBindingNavigatorSaveItem"
        Me.VendorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VendorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VendorNameTextBox
        '
        Me.VendorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VendorName", True))
        Me.VendorNameTextBox.Location = New System.Drawing.Point(32, 114)
        Me.VendorNameTextBox.Name = "VendorNameTextBox"
        Me.VendorNameTextBox.Size = New System.Drawing.Size(149, 20)
        Me.VendorNameTextBox.TabIndex = 2
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Location = New System.Drawing.Point(32, 156)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ContactNameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(32, 200)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 6
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(32, 242)
        Me.CityTextBox.MaxLength = 50
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 8
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(32, 289)
        Me.StateTextBox.MaxLength = 10
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 10
        '
        'ZipMaskedTextBox
        '
        Me.ZipMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Zip", True))
        Me.ZipMaskedTextBox.Location = New System.Drawing.Point(138, 200)
        Me.ZipMaskedTextBox.Mask = "00000"
        Me.ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        Me.ZipMaskedTextBox.Size = New System.Drawing.Size(41, 20)
        Me.ZipMaskedTextBox.TabIndex = 12
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(32, 338)
        Me.CountryTextBox.MaxLength = 50
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 14
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Phone", True))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(185, 200)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneMaskedTextBox.TabIndex = 16
        '
        'VendorIDLabel1
        '
        Me.VendorIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VendorID", True))
        Me.VendorIDLabel1.Location = New System.Drawing.Point(32, 66)
        Me.VendorIDLabel1.Name = "VendorIDLabel1"
        Me.VendorIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.VendorIDLabel1.TabIndex = 18
        Me.VendorIDLabel1.Text = "Label1"
        '
        'VendorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 382)
        Me.Controls.Add(VendorIDLabel)
        Me.Controls.Add(Me.VendorIDLabel1)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneMaskedTextBox)
        Me.Controls.Add(VendorNameLabel)
        Me.Controls.Add(Me.VendorNameTextBox)
        Me.Controls.Add(ContactNameLabel)
        Me.Controls.Add(Me.ContactNameTextBox)
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
        Me.Controls.Add(Me.VendorsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VendorsForm"
        Me.Text = "Vendors"
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendorsBindingNavigator.ResumeLayout(False)
        Me.VendorsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents VendorsBindingSource As BindingSource
    Friend WithEvents VendorsTableAdapter As CakeDataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorsBindingNavigator As BindingNavigator
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
    Friend WithEvents VendorsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VendorNameTextBox As TextBox
    Friend WithEvents ContactNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipMaskedTextBox As MaskedTextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents VendorIDLabel1 As Label
End Class
