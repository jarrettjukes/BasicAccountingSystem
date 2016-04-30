<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchasesReportForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchasesReportForm))
        Me.PurchaseInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.VendorsTableAdapter()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.InventoryTableAdapter()
        Me.PurchaseInvoicesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.PurchaseInvoicesTableAdapter()
        CType(Me.PurchaseInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseInvoicesBindingSource
        '
        Me.PurchaseInvoicesBindingSource.DataMember = "PurchaseInvoices"
        Me.PurchaseInvoicesBindingSource.DataSource = Me.CakeDataSet
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PurchasesDataSet"
        ReportDataSource1.Value = Me.PurchaseInvoicesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BasicAccountingSystem.PurchasesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(568, 353)
        Me.ReportViewer1.TabIndex = 0
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
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.CakeDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'PurchaseInvoicesTableAdapter
        '
        Me.PurchaseInvoicesTableAdapter.ClearBeforeFill = True
        '
        'PurchasesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 353)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PurchasesReportForm"
        Me.Text = "Purchase Reports"
        CType(Me.PurchaseInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VendorsBindingSource As BindingSource
    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents VendorsTableAdapter As CakeDataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As CakeDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents PurchaseInvoicesBindingSource As BindingSource
    Friend WithEvents PurchaseInvoicesTableAdapter As CakeDataSetTableAdapters.PurchaseInvoicesTableAdapter
End Class
