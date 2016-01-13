Public Class RecipesForm
    Private Sub RecipesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RecipesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RecipesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)

    End Sub

    Private Sub RecipesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.CakeDataSet.Inventory)
        'TODO: This line of code loads data into the 'CakeDataSet.Recipes' table. You can move, or remove it, as needed.
        Me.RecipesTableAdapter.Fill(Me.CakeDataSet.Recipes)

    End Sub
End Class