Imports System.ComponentModel

Public Class ProductsForm
    'create the unique instance of the form
    Public Shared ActiveInstance As ProductsForm = Nothing
    Public Shared ReadOnly Property GetInstance As ProductsForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New ProductsForm
            End If
            Return ActiveInstance
        End Get
    End Property
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        'Make sure the data is acceptable to save.
        Try
            Me.Validate()
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CakeDataSet)
        Catch ex As Exception
            MessageBox.Show("Make sure each field has proper data.")
        End Try

    End Sub

    Private Sub ProductsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Quotes' table. You can move, or remove it, as needed.
        Me.QuotesTableAdapter.Fill(Me.CakeDataSet.Quotes)
        'TODO: This line of code loads data into the 'CakeDataSet.Recipes' table. You can move, or remove it, as needed.
        Me.RecipesTableAdapter.Fill(Me.CakeDataSet.Recipes)
        'TODO: This line of code loads data into the 'CakeDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.CakeDataSet.Products)

    End Sub

    Private Sub bAddImage_Click(sender As Object, e As EventArgs) Handles bAddImage.Click
        'Open file dialog with filters
        Dim ofd As New OpenFileDialog

        'Could only pick one format for the reports
        ofd.Filter = "JPEG|*.jpg"
        'Add the image to the picture box if it exists
        If ofd.CheckFileExists And ofd.CheckPathExists Then
            If ofd.ShowDialog = DialogResult.OK Then
                ImagePictureBox.Image = Image.FromFile(ofd.FileName)
            End If
        End If
    End Sub

    Private Sub bRemove_Click(sender As Object, e As EventArgs) Handles bRemove.Click
        'Clear the image
        ImagePictureBox.Image = Nothing
    End Sub
End Class