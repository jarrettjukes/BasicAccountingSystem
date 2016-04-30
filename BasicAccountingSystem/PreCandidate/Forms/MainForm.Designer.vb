<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesInvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecipesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecipesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsToolStripMenuItem, Me.VendorsToolStripMenuItem, Me.SalesInvoicesToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1037, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'VendorsToolStripMenuItem
        '
        Me.VendorsToolStripMenuItem.Name = "VendorsToolStripMenuItem"
        Me.VendorsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VendorsToolStripMenuItem.Text = "Vendors"
        '
        'SalesInvoicesToolStripMenuItem
        '
        Me.SalesInvoicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.PurchasesToolStripMenuItem})
        Me.SalesInvoicesToolStripMenuItem.Name = "SalesInvoicesToolStripMenuItem"
        Me.SalesInvoicesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SalesInvoicesToolStripMenuItem.Text = "Invoices"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PurchasesToolStripMenuItem.Text = "Purchases"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem1, Me.PurchasesToolStripMenuItem1, Me.ClientsToolStripMenuItem1, Me.VendorsToolStripMenuItem1, Me.RecipesToolStripMenuItem1, Me.InventoryToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SalesToolStripMenuItem1
        '
        Me.SalesToolStripMenuItem1.Name = "SalesToolStripMenuItem1"
        Me.SalesToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.SalesToolStripMenuItem1.Text = "Sales"
        '
        'PurchasesToolStripMenuItem1
        '
        Me.PurchasesToolStripMenuItem1.Name = "PurchasesToolStripMenuItem1"
        Me.PurchasesToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.PurchasesToolStripMenuItem1.Text = "Purchases"
        '
        'ClientsToolStripMenuItem1
        '
        Me.ClientsToolStripMenuItem1.Name = "ClientsToolStripMenuItem1"
        Me.ClientsToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ClientsToolStripMenuItem1.Text = "Clients"
        '
        'VendorsToolStripMenuItem1
        '
        Me.VendorsToolStripMenuItem1.Name = "VendorsToolStripMenuItem1"
        Me.VendorsToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.VendorsToolStripMenuItem1.Text = "Vendors"
        '
        'RecipesToolStripMenuItem1
        '
        Me.RecipesToolStripMenuItem1.Name = "RecipesToolStripMenuItem1"
        Me.RecipesToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.RecipesToolStripMenuItem1.Text = "Recipes"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.InventoryToolStripMenuItem.Text = "Products"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip.Location = New System.Drawing.Point(0, 735)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1037, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.RecipesToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.QuotesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1037, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'RecipesToolStripMenuItem
        '
        Me.RecipesToolStripMenuItem.Name = "RecipesToolStripMenuItem"
        Me.RecipesToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.RecipesToolStripMenuItem.Text = "Recipes"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SuppliersToolStripMenuItem.Text = "Supplies"
        '
        'QuotesToolStripMenuItem
        '
        Me.QuotesToolStripMenuItem.Name = "QuotesToolStripMenuItem"
        Me.QuotesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.QuotesToolStripMenuItem.Text = "Quotes"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1037, 757)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "Basic Accounting System"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesInvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VendorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecipesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecipesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuotesToolStripMenuItem As ToolStripMenuItem
End Class
