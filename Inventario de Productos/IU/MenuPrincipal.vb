Imports System.Windows.Forms
Public Class MenuPrincipal
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ToolStrip1.Enabled = False

        Dim Productos As New ProductosGrid

        ProductosGrid.MdiParent = Me

        ProductosGrid.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ToolStrip1.Enabled = False

        Dim Proveedores As New ProveedoresGrid

        ProveedoresGrid.MdiParent = Me

        ProveedoresGrid.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        End

    End Sub
End Class