Imports System.ComponentModel

Public Class QuotesForm
    'create the unique instance of the form
    Public Shared ActiveInstance As QuotesForm = Nothing

    Public Shared ReadOnly Property GetInstance As QuotesForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New QuotesForm
            End If
            Return ActiveInstance
        End Get
    End Property
    Private Sub QuotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles QuotesBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.QuotesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try

    End Sub

    Private Sub QuotesForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub QuotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.CakeDataSet.Products)
        'TODO: This line of code loads data into the 'CakeDataSet.Quotes' table. You can move, or remove it, as needed.
        Me.QuotesTableAdapter.Fill(Me.CakeDataSet.Quotes)

    End Sub
End Class