Public Class ProveedoresGrid

    Private Sub ProveedoresGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Provedores_list
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ProveedorForm.operacion = "AGREGAR"
        ProveedorForm.Text = "AGREGAR PROVEEDOR"
        ProveedorForm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ProveedorForm.operacion = "ELIMINAR"
        ProveedorForm.Text = "ELIMINAR PROVEEDOR"
        llenarProveedorForm()
        ProveedorForm.Show()
    End Sub


    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        ProveedorForm.operacion = "MODIFICAR"
        llenarProveedorForm()
        ProveedorForm.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub
    Private Sub llenarProveedorForm()

        ProveedorForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ProveedorForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ProveedorForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ProveedorForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ProveedorForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

    End Sub
End Class