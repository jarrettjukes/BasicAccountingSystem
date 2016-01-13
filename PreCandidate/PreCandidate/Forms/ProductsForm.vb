Public Class ProductsForm
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)

    End Sub

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Recipes' table. You can move, or remove it, as needed.
        Me.RecipesTableAdapter.Fill(Me.CakeDataSet.Recipes)
        'TODO: This line of code loads data into the 'CakeDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.CakeDataSet.Products)

    End Sub
End Class