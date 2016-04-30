<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsForm
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
        Dim ImageLabel As System.Windows.Forms.Label
        Dim RecipeIDLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsForm))
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager()
        Me.RecipesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.RecipesTableAdapter()
        Me.ProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.RecipeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.RecipesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bAddImage = New System.Windows.Forms.Button()
        Me.bRemove = New System.Windows.Forms.Button()
        Me.QuotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.QuotesTableAdapter()
        Me.ProductIDLabel1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        RecipeIDLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsBindingNavigator.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(23, 60)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(78, 13)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Product Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(38, 86)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description:"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.Location = New System.Drawing.Point(298, 60)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(39, 13)
        ImageLabel.TabIndex = 5
        ImageLabel.Text = "Image:"
        '
        'RecipeIDLabel
        '
        RecipeIDLabel.AutoSize = True
        RecipeIDLabel.Location = New System.Drawing.Point(17, 172)
        RecipeIDLabel.Name = "RecipeIDLabel"
        RecipeIDLabel.Size = New System.Drawing.Size(84, 13)
        RecipeIDLabel.TabIndex = 7
        RecipeIDLabel.Text = "Recipe Number:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(14, 31)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(87, 13)
        ProductIDLabel.TabIndex = 11
        ProductIDLabel.Text = "Product Number:"
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.CakeDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.JoinRecipeAndInventoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.PurchaseInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.QuotesTableAdapter = Nothing
        Me.TableAdapterManager.RecipesTableAdapter = Me.RecipesTableAdapter
        Me.TableAdapterManager.SalesInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BasicAccountingSystem.CakeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'RecipesTableAdapter
        '
        Me.RecipesTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingNavigator
        '
        Me.ProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductsBindingNavigator.BindingSource = Me.ProductsBindingSource
        Me.ProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductsBindingNavigatorSaveItem})
        Me.ProductsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductsBindingNavigator.Name = "ProductsBindingNavigator"
        Me.ProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductsBindingNavigator.Size = New System.Drawing.Size(505, 25)
        Me.ProductsBindingNavigator.TabIndex = 0
        Me.ProductsBindingNavigator.Text = "BindingNavigator1"
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
        'ProductsBindingNavigatorSaveItem
        '
        Me.ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductsBindingNavigatorSaveItem.Name = "ProductsBindingNavigatorSaveItem"
        Me.ProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(107, 57)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(171, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(107, 83)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(171, 80)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductsBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(301, 83)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(171, 80)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagePictureBox.TabIndex = 6
        Me.ImagePictureBox.TabStop = False
        '
        'RecipeIDComboBox
        '
        Me.RecipeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "RecipeID", True))
        Me.RecipeIDComboBox.DataSource = Me.RecipesBindingSource
        Me.RecipeIDComboBox.DisplayMember = "RecipeID"
        Me.RecipeIDComboBox.FormattingEnabled = True
        Me.RecipeIDComboBox.Location = New System.Drawing.Point(107, 169)
        Me.RecipeIDComboBox.Name = "RecipeIDComboBox"
        Me.RecipeIDComboBox.Size = New System.Drawing.Size(171, 21)
        Me.RecipeIDComboBox.TabIndex = 8
        Me.RecipeIDComboBox.ValueMember = "RecipeID"
        '
        'RecipesBindingSource
        '
        Me.RecipesBindingSource.DataMember = "Recipes"
        Me.RecipesBindingSource.DataSource = Me.CakeDataSet
        '
        'bAddImage
        '
        Me.bAddImage.Location = New System.Drawing.Point(301, 167)
        Me.bAddImage.Name = "bAddImage"
        Me.bAddImage.Size = New System.Drawing.Size(75, 23)
        Me.bAddImage.TabIndex = 9
        Me.bAddImage.Text = "Add Image"
        Me.bAddImage.UseVisualStyleBackColor = True
        '
        'bRemove
        '
        Me.bRemove.Location = New System.Drawing.Point(397, 167)
        Me.bRemove.Name = "bRemove"
        Me.bRemove.Size = New System.Drawing.Size(75, 23)
        Me.bRemove.TabIndex = 10
        Me.bRemove.Text = "Remove"
        Me.bRemove.UseVisualStyleBackColor = True
        '
        'QuotesBindingSource
        '
        Me.QuotesBindingSource.DataMember = "Products_Quotes"
        Me.QuotesBindingSource.DataSource = Me.ProductsBindingSource
        '
        'QuotesTableAdapter
        '
        Me.QuotesTableAdapter.ClearBeforeFill = True
        '
        'ProductIDLabel1
        '
        Me.ProductIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductID", True))
        Me.ProductIDLabel1.Location = New System.Drawing.Point(104, 31)
        Me.ProductIDLabel1.Name = "ProductIDLabel1"
        Me.ProductIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ProductIDLabel1.TabIndex = 12
        Me.ProductIDLabel1.Text = "Label1"
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 227)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDLabel1)
        Me.Controls.Add(Me.bRemove)
        Me.Controls.Add(Me.bAddImage)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(RecipeIDLabel)
        Me.Controls.Add(Me.RecipeIDComboBox)
        Me.Controls.Add(Me.ProductsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductsForm"
        Me.Text = "Products"
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsBindingNavigator.ResumeLayout(False)
        Me.ProductsBindingNavigator.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As CakeDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As CakeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsBindingNavigator As BindingNavigator
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
    Friend WithEvents ProductsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents RecipeIDComboBox As ComboBox
    Friend WithEvents RecipesTableAdapter As CakeDataSetTableAdapters.RecipesTableAdapter
    Friend WithEvents RecipesBindingSource As BindingSource
    Friend WithEvents bAddImage As Button
    Friend WithEvents bRemove As Button
    Friend WithEvents QuotesBindingSource As BindingSource
    Friend WithEvents QuotesTableAdapter As CakeDataSetTableAdapters.QuotesTableAdapter
    Friend WithEvents ProductIDLabel1 As Label
End Class
