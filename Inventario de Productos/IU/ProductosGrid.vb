Public Class ProductosGrid

    Private Sub ProductosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Productos_list
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ProductoForm.operacion = "AGREGAR"
        ProductoForm.Text = "AGREGAR PRODUCTO"
        ProductoForm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ProductoForm.operacion = "ELIMINAR"
        ProductoForm.Text = "ELIMINAR PRODUCTO"
        llenarProductoForm()
        ProductoForm.Show()
    End Sub



    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        ProductoForm.operacion = "MODIFICAR"
        llenarProductoForm()
        ProductoForm.Show()
    End Sub



    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        End
    End Sub

    Private Sub llenarProductoForm()

        ProductoForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ProductoForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ProductoForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ProductoForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ProductoForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

    End Sub


End Class