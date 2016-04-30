Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class ProductsReportForm
    'create unique instance of the form
    Public Shared ActiveInstance As ProductsReportForm = Nothing
    Public Shared ReadOnly Property GetInstance As ProductsReportForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New ProductsReportForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub ProductsReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub ProductsReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf SubreportProcessor
        Me.ProductsTableAdapter.Fill(Me.CakeDataSet.Products)
        'TODO: This line of code loads data into the 'CakeDataSet.Quotes' table. You can move, or remove it, as needed.
        Me.QuotesTableAdapter.Fill(Me.CakeDataSet.Quotes)
        'TODO: This line of code loads data into the 'CakeDataSet.Products' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SubreportProcessor(ByVal sender As System.Object, ByVal e As SubreportProcessingEventArgs)
        'Add the data sources of the subreports
        e.DataSources.Add(New ReportDataSource("QuotesDataSet", QuotesBindingSource))
    End Sub
End Class