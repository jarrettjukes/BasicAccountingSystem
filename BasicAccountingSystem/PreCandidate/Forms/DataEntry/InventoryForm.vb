Imports System.ComponentModel

Public Class InventoryForm
    'create the unique instance of the form
    Public Shared ActiveInstance As InventoryForm = Nothing
    Public Shared ReadOnly Property GetInstance As InventoryForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New InventoryForm
            End If
            Return ActiveInstance
        End Get
    End Property
    Private Sub InventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.InventoryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try

    End Sub

    Private Sub InventoryForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Recipes' table. You can move, or remove it, as needed.
        Me.RecipesTableAdapter.Fill(Me.CakeDataSet.Recipes)
        'TODO: This line of code loads data into the 'CakeDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.CakeDataSet.Inventory)

    End Sub
End Class