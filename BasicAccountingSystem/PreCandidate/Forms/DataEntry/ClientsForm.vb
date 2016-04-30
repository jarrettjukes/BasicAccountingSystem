Imports System.ComponentModel

Public Class ClientsForm
    'create the unique instance of the form
    Public Shared ActiveInstance As ClientsForm = Nothing

    Public Shared ReadOnly Property GetInstance As ClientsForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New ClientsForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub ClientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.ClientsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try

    End Sub

    Private Sub ClientsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub ClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.CakeDataSet.Clients)

    End Sub
End Class