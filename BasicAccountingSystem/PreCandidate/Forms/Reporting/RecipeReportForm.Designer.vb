<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecipeReportForm))
        Me.RecipesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CakeDataSet = New BasicAccountingSystem.CakeDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RecipesTableAdapter = New BasicAccountingSystem.CakeDataSetTableAdapters.RecipesTableAdapter()
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "RecipesDataSet"
        ReportDataSource1.Value = Me.RecipesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BasicAccountingSystem.RecipesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(618, 288)
        Me.ReportViewer1.TabIndex = 0
        '
        'RecipesTableAdapter
        '
        Me.RecipesTableAdapter.ClearBeforeFill = True
        '
        'RecipeReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 288)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecipeReportForm"
        Me.Text = "Recipe Reports"
        CType(Me.RecipesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CakeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RecipesBindingSource As BindingSource
    Friend WithEvents CakeDataSet As CakeDataSet
    Friend WithEvents RecipesTableAdapter As CakeDataSetTableAdapters.RecipesTableAdapter
End Class
