Imports System.ComponentModel

Public Class ClientsReportForm
    'create unique instance of the form
    Public Shared ActiveInstance As ClientsReportForm = Nothing
    Public Shared ReadOnly Property GetInstance As ClientsReportForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New ClientsReportForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub ClientsReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub ClientsReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CakeDataSet.Clients)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class