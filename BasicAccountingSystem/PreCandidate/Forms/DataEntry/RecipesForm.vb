Imports System.ComponentModel

Public Class RecipesForm
    'create the unique instance of the form
    Public Shared ActiveInstance As RecipesForm = Nothing
    Public Shared ReadOnly Property GetInstance As RecipesForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New RecipesForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub MakeSureRecipeIsSaved() Handles JoinRecipeAndInventoryDataGridView.GotFocus
        'Keep any changes made in the data grid
        'dont need a try because the data grid isnt strictly saving the data
        If JoinRecipeAndInventoryDataGridView.Focus = True Then
            Exit Sub
        End If

        Me.Validate()
        Me.RecipesBindingSource.EndEdit()

    End Sub

    'Attempt at making code more readable
    Private Sub Save()
        Me.Validate()
        Me.RecipesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
    End Sub

    Private Sub RecipesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RecipesBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Save()
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try
    End Sub

    Private Sub RecipesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load data and disable data grid controls
        Me.JoinRecipeAndInventoryTableAdapter.Fill(Me.CakeDataSet.JoinRecipeAndInventory)
        Me.InventoryTableAdapter.Fill(Me.CakeDataSet.Inventory)
        Me.RecipesTableAdapter.Fill(Me.CakeDataSet.Recipes)
        toggleControls(True)
    End Sub

    Private Sub toggleControls(ByVal enable As Boolean)
        'disable data grid view
        JoinRecipeAndInventoryDataGridView.Enabled = Not enable
    End Sub

    Private Sub bSupplies_Click(sender As Object, e As EventArgs) Handles bSupplies.Click
        'Save the main controls' data and enable data grid view
        Save()
        toggleControls(False)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'Disable data grid view controls
        toggleControls(True)
    End Sub

    Private Sub RecipesForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub
End Class