<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReportForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReportForm))
        Me.SalesInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ProductsTableAdapter()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientsTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.ClientsTableAdapter()
        Me.SalesInvoicesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.SalesInvoicesTableAdapter()
        CType(Me.SalesInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesInvoicesBindingSource
        '
        Me.SalesInvoicesBindingSource.DataMember = "SalesInvoices"
        Me.SalesInvoicesBindingSource.DataSource = Me.CakeDataSet
        '
        'CakeDataSet
        '
        Me.CakeDataSet.DataSetName = "CakeDataSet"
        Me.CakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "SalesDataSet"
        ReportDataSource1.Value = Me.SalesInvoicesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BasicAccountingSystem.SalesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(442, 446)
        Me.ReportViewer1.TabIndex = 0
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
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.CakeDataSet
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'SalesInvoicesTableAdapter
        '
        Me.SalesInvoicesTableAdapter.ClearBeforeFill = True
        '
        'SalesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 446)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesReportForm"
        Me.Text = "Sales Reports"
        CType(Me.SalesInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents ProductsTableAdapter As CakeDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As CakeDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents SalesInvoicesBindingSource As BindingSource
    Friend WithEvents SalesInvoicesTableAdapter As CakeDataSetTableAdapters.SalesInvoicesTableAdapter
End Class
