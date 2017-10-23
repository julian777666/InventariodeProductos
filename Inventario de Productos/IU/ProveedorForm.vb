Public Class ProveedorForm
    Dim operacion_ As String
    Dim Proveedor As New ProveedorClass

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

            Proveedor.idProveedores = CInt(TextBox1.Text)

        End If

        Proveedor.Nombre = TextBox2.Text
        Proveedor.Direccion = TextBox3.Text
        Proveedor.Telefono = CInt(TextBox4.Text)
        Proveedor.Empresa = TextBox5.Text


        Select Case operacion_

            Case "AGREGAR"
                Provedores_list.InsertarProveedor(Proveedor)

            Case "ELIMINAR"
                Provedores_list.EliminarProveedor(Proveedor)

            Case "MODIFICAR"
                Provedores_list.ActualizarProveedor(Proveedor)
                ProveedoresGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELAR.Click
        Close()
    End Sub
End Class