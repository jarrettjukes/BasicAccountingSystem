Public Class ClientsForm
    Private Sub ClientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)

    End Sub

    Private Sub ClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CakeDataSet.Clients)

    End Sub
End Class