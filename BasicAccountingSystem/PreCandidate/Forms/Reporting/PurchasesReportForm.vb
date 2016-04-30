Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class PurchasesReportForm
    'create unique instance of the form
    Public Shared ActiveInstance As PurchasesReportForm = Nothing
    Public Shared ReadOnly Property GetInstance As PurchasesReportForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New PurchasesReportForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub PurchasesReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub PurchasesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf SubreportProcessor
        Me.PurchaseInvoicesTableAdapter.Fill(Me.CakeDataSet.PurchaseInvoices)
        'TODO: This line of code loads data into the 'CakeDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.CakeDataSet.Vendors)
        'TODO: This line of code loads data into the 'CakeDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.CakeDataSet.Inventory)
        'TODO: This line of code loads data into the 'CakeDataSet.PurchaseInvoices' table. You can move, or remove it, as needed.


        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub SubreportProcessor(ByVal sender As System.Object, ByVal e As SubreportProcessingEventArgs)
        'Add the data sources of the subreports
        e.DataSources.Add(New ReportDataSource("InventoryDataSet", InventoryBindingSource))
        e.DataSources.Add(New ReportDataSource("VendorDataSet", VendorsBindingSource))
    End Sub
End Class