Imports System.ComponentModel
Imports System.Text
Public Class ProductosCollection

    Inherits BindingList(Of ProductoClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New ProductoClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean

        Get
            Return True
        End Get

    End Property
    Public Sub New()

        Me.TraerProcuctos()

    End Sub
    Public Function TraerProcuctos() As ProductosCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim Producto As ProductoClass

        objBaseDatos.objTabla = "Productos"

        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Producto = New ProductoClass

            Producto.idProducto = CInt(dr("idProducto"))
            Producto.Nombre = CStr(dr("Nombre"))
            Producto.Cantidad = CStr(dr("Cantidad"))
            Producto.Precio = CStr(dr("Precio"))
            Producto.Descripcion = CStr(dr("Descripcion"))
            Me.Add(Producto)

        Next

        Return Me

    End Function
    Public Sub InsertarProducto(ByVal Producto As ProductoClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Productos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(idProducto")
        vSQL.Append(",Nombre")
        vSQL.Append(",Cantidad")
        vSQL.Append(",Precio)")
        vSQL.Append(",Descripcion")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Producto.idProducto & "'")
        vSQL.Append("'" & Producto.Nombre & "'")
        vSQL.Append("'" & Producto.Cantidad & "'")
        vSQL.Append("'" & Producto.Precio & "'")
        vSQL.Append(",'" & Producto.Descripcion & "')")

        Producto.idProducto = objBaseDatos.Insertar(vSQL.ToString)

        If Producto.idProducto = 0 Then
            MsgBox("No fue posible agregar el Producto " + Producto.idProducto)
            Exit Sub
        End If

        Me.Add(Producto)

    End Sub

    Public Sub EliminarProducto(ByVal Producto As ProductoClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Productos"

        Dim resultado As Boolean

        resultado = objBaseDatos.Eliminar(Producto.idProducto)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar el Productos " + Producto.idProducto)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Producto)
        Dim myProperty As PropertyDescriptor = properties.Find("idProducto", True)
        Me.RemoveAt(Me.FindCore(myProperty, Producto.idProducto))

    End Sub
    Public Sub ActualizarProducto(ByVal Producto As ProductoClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Productos"
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("idProducto='" & Producto.idProducto & "'")
        vSQL.Append(",Nombre='" & Producto.Nombre & "'")
        vSQL.Append(",Cantidad='" & Producto.Cantidad & "'")
        vSQL.Append(",Precio='" & Producto.Precio & "'")
        vSQL.Append(",Descripcion='" & Producto.Descripcion & "'")

        Dim resultado As Boolean

        resultado = objBaseDatos.Actualizar(vSQL.ToString, Producto.idProducto)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el Producto " + Producto.idProducto)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Producto)
        Dim myProperty As PropertyDescriptor = properties.Find("idProducto", True)
        Me.Items.Item(Me.FindCore(myProperty, Producto.idProducto)) = Producto

    End Sub

End Class
