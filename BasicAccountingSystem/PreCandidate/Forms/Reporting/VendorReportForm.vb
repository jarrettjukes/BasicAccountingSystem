Imports System.ComponentModel

Public Class VendorReportForm
    'create unique instance of the form
    Public Shared ActiveInstance As VendorReportForm = Nothing
    Public Shared ReadOnly Property GetInstance As VendorReportForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New VendorReportForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub VendorReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub VendorReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.CakeDataSet.Vendors)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class