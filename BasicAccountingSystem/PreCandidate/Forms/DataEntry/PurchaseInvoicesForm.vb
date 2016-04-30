Imports System.ComponentModel

Public Class PurchaseInvoicesForm
    'create the unique instance of the form
    Public Shared ActiveInstance As PurchaseInvoicesForm = Nothing
    Public Shared ReadOnly Property GetInstance As PurchaseInvoicesForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New PurchaseInvoicesForm
            End If
            Return ActiveInstance
        End Get
    End Property
    Private Sub PurchaseInvoicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PurchaseInvoicesBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.PurchaseInvoicesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try

    End Sub

    Private Sub PurchaseInvoicesForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub PurchaseInvoicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.CakeDataSet.Inventory)
        'TODO: This line of code loads data into the 'CakeDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.CakeDataSet.Vendors)
        'TODO: This line of code loads data into the 'CakeDataSet.PurchaseInvoices' table. You can move, or remove it, as needed.
        Me.PurchaseInvoicesTableAdapter.Fill(Me.CakeDataSet.PurchaseInvoices)

    End Sub
End Class