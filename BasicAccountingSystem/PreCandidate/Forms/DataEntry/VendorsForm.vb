Imports System.ComponentModel

Public Class VendorsForm
    'create unique instance of the form
    Public Shared ActiveInstance As VendorsForm = Nothing
    Public Shared ReadOnly Property GetInstance As VendorsForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New VendorsForm
            End If
            Return ActiveInstance
        End Get
    End Property
    Private Sub VendorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendorsBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.VendorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try

    End Sub

    Private Sub VendorsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub VendorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.CakeDataSet.Vendors)

    End Sub
End Class