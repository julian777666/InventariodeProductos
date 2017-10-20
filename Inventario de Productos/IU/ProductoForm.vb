Public Class ProductoForm
    Dim operacion_ As String
    Dim Producto As New ProductoClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property


    Private Sub ACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACEPTAR.Click

        If operacion_ <> "AGREGAR" Then

            Producto.idProducto = CInt(TextBox1.Text)

        End If

        Producto.Nombre = TextBox2.Text
        Producto.Cantidad = TextBox3.Text
        Producto.Precio = CInt(TextBox4.Text)
        Producto.Descripcion = TextBox5.Text

        Select Case operacion_

            Case "AGREGAR"
                Productos_list.InsertarProducto(Producto)

            Case "ELIMINAR"
                Productos_list.EliminarProducto(Producto)

            Case "MODIFICAR"
                Productos_list.ActualizarProducto(Producto)
                ProductosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELAR.Click
        Close()
    End Sub
End Class
