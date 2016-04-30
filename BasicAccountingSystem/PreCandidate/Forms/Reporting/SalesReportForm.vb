Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class SalesReportForm
    'create unique instance of the form
    Public Shared ActiveInstance As SalesReportForm = Nothing
    Public Shared ReadOnly Property GetInstance As SalesReportForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New SalesReportForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub SalesReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf SubreportProcessor
        'TODO: This line of code loads data into the 'CakeDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.CakeDataSet.Products)
        'TODO: This line of code loads data into the 'CakeDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CakeDataSet.Clients)
        'TODO: This line of code loads data into the 'CakeDataSet.SalesInvoices' table. You can move, or remove it, as needed.
        Me.SalesInvoicesTableAdapter.Fill(Me.CakeDataSet.SalesInvoices)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SubreportProcessor(ByVal sender As System.Object, ByVal e As SubreportProcessingEventArgs)
        'Add the data sources of the subreports
        e.DataSources.Add(New ReportDataSource("ClientsData", ClientsBindingSource))
        e.DataSources.Add(New ReportDataSource("ProductDataSet", ProductsBindingSource))
    End Sub

End Class