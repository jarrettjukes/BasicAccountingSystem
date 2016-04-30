Imports System.ComponentModel

Public Class RecipeReportForm
    'create unique instance of the form
    Public Shared ActiveInstance As RecipeReportForm = Nothing
    Public Shared ReadOnly Property GetInstance As RecipeReportForm
        Get
            If ActiveInstance Is Nothing Then
                ActiveInstance = New RecipeReportForm
            End If
            Return ActiveInstance
        End Get
    End Property

    Private Sub RecipeReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear the instance and close the form
        ActiveInstance = Nothing
    End Sub

    Private Sub RecipeReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CakeDataSet.Recipes' table. You can move, or remove it, as needed.
        Me.RecipesTableAdapter.Fill(Me.CakeDataSet.Recipes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class