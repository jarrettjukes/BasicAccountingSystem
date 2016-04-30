Imports System.ComponentModel

Public Class SalesInvoicesForm
    'create unique instance of the form
    Public Shared ActiveInstance As RecipesForm = Nothing
    Public Shared ReadOnly Property GetInstance As RecipesForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New RecipesForm
            End If
            Return ActiveInstance
        End Get
    End Property
    Private Sub SalesInvoicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalesInvoicesBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.SalesInvoicesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try
    End Sub

    Private Sub SalesInvoicesForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub SalesInvoicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CakeDataSet.Clients)
        'TODO: This line of code loads data into the 'CakeDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.CakeDataSet.Products)
        'TODO: This line of code loads data into the 'CakeDataSet.SalesInvoices' table. You can move, or remove it, as needed.
        Me.SalesInvoicesTableAdapter.Fill(Me.CakeDataSet.SalesInvoices)

    End Sub
End Class