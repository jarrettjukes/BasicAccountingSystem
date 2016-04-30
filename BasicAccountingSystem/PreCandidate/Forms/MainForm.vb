Imports System.Windows.Forms

Public Class MainForm
#Region "AutoCode"
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
#End Region
    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem.Click

    End Sub

    'create the forms w/ respective buttons and instantiate single instance
    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        Dim cf As ClientsForm = ClientsForm.GetInstance
        cf.MdiParent = Me
        cf.WindowState = FormWindowState.Normal
        cf.Show()
        cf.Activate()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        Dim iif As InventoryForm = InventoryForm.GetInstance
        iif.MdiParent = Me
        iif.WindowState = FormWindowState.Normal
        iif.Show()
        iif.Activate()

    End Sub

    Private Sub RecipesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecipesToolStripMenuItem.Click
        Dim rf As RecipesForm = RecipesForm
        rf.MdiParent = Me
        rf.WindowState = FormWindowState.Normal
        rf.Show()
        rf.Activate()
    End Sub

    Private Sub VendorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorsToolStripMenuItem.Click
        Dim vf As VendorsForm = VendorsForm
        vf.MdiParent = Me
        vf.WindowState = FormWindowState.Normal
        vf.Show()
        vf.Activate()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim sif As SalesInvoicesForm = SalesInvoicesForm
        sif.MdiParent = Me
        sif.WindowState = FormWindowState.Normal
        sif.Show()
        sif.Activate()
    End Sub

    Private Sub PurchasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem.Click
        Dim pif As PurchaseInvoicesForm = PurchaseInvoicesForm.GetInstance
        pif.MdiParent = Me
        pif.WindowState = FormWindowState.Normal
        pif.Show()
        pif.Activate()
    End Sub

    Private Sub SalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem1.Click
        Dim srf As SalesReportForm = SalesReportForm.GetInstance
        srf.MdiParent = Me
        srf.WindowState = FormWindowState.Normal
        srf.Show()
        srf.Activate()
    End Sub

    Private Sub RecipesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecipesToolStripMenuItem1.Click
        Dim rrf As RecipeReportForm = RecipeReportForm.GetInstance
        rrf.MdiParent = Me
        rrf.WindowState = FormWindowState.Normal
        rrf.Show()
        rrf.Activate()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim ab As New AboutBox
        ab.ShowDialog()
    End Sub

    Private Sub VendorsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VendorsToolStripMenuItem1.Click
        Dim vrf As VendorReportForm = VendorReportForm.GetInstance
        vrf.MdiParent = Me
        vrf.WindowState = FormWindowState.Normal
        vrf.Show()
        vrf.Activate()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim prf As ProductsReportForm = ProductsReportForm.GetInstance
        prf.MdiParent = Me
        prf.WindowState = FormWindowState.Normal
        prf.Show()
        prf.Activate()
    End Sub

    Private Sub ClientsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem1.Click
        Dim crf As ClientsReportForm = ClientsReportForm.GetInstance
        crf.MdiParent = Me
        crf.WindowState = FormWindowState.Normal
        crf.Show()
        crf.Activate()
    End Sub

    Private Sub PurchasesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem1.Click
        Dim prf As PurchasesReportForm = PurchasesReportForm.GetInstance
        prf.MdiParent = Me
        prf.WindowState = FormWindowState.Normal
        prf.Show()
        prf.Activate()
    End Sub

    Private Sub QuotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuotesToolStripMenuItem.Click
        Dim qf As QuotesForm = QuotesForm.GetInstance
        qf.MdiParent = Me
        qf.WindowState = FormWindowState.Normal
        qf.Show()
        qf.Activate()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim pf As ProductsForm = ProductsForm.GetInstance
        pf.MdiParent = Me
        pf.WindowState = FormWindowState.Normal
        pf.Show()
        pf.Activate()
    End Sub
End Class
