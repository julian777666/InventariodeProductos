Imports System.ComponentModel
Imports System.Text
Public Class ProveedoresCollection
    Inherits BindingList(Of ProveedorClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New ProveedorClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean

        Get
            Return True
        End Get

    End Property

    Public Function TraerProveedores() As ProveedoresCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim Proveedor As ProveedorClass

        objBaseDatos.objTabla = "Proveedores"

        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows
            Proveedor = New ProveedorClass

            Proveedor.idProveedores = CInt(dr("idProveedores"))
            Proveedor.NombreP = CStr(dr("NombreP"))
            Proveedor.Direccion = CStr(dr("Direccion"))
            Proveedor.Telefono = CStr(dr("Telefono"))
            Proveedor.Empresa = CStr(dr("Empresa"))
            Me.Add(Proveedor)

        Next

        Return Me

    End Function

    Public Sub InsertarProveedor(ByVal Proveedor As ProveedorClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Proveedores"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(idProveedor")
        vSQL.Append(",NombreP")
        vSQL.Append(",Direccion")
        vSQL.Append(",Telefono")
        vSQL.Append(",Empresa)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Proveedor.idProveedores & "'")
        vSQL.Append("'" & Proveedor.NombreP & "'")
        vSQL.Append("'" & Proveedor.Direccion & "'")
        vSQL.Append("'" & Proveedor.Telefono & "'")
        vSQL.Append(",'" & Proveedor.Empresa & "')")

        Proveedor.idProveedores = objBaseDatos.Insertar(vSQL.ToString)

        If Proveedor.idProveedores = 0 Then
            MsgBox("No fue posible agregar el Proveedor " + Proveedor.idProveedores)
            Exit Sub
        End If

        Me.Add(Proveedor)

    End Sub

    Public Sub EliminarProveedor(ByVal Proveedor As ProveedorClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Proveedores"

        Dim resultado As Boolean

        resultado = objBaseDatos.Eliminar(Proveedor.idProveedores)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar el Proveedor " + Proveedor.idProveedores)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Proveedor)
        Dim myProperty As PropertyDescriptor = properties.Find("idProveedor", True)
        Me.RemoveAt(Me.FindCore(myProperty, Proveedor.idProveedores))

    End Sub


    Public Sub ActualizarProveedor(ByVal Proveedor As ProveedorClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Proveedores"
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("idProveedor='" & Proveedor.idProveedores & "'")
        vSQL.Append(",NombreP='" & Proveedor.NombreP & "'")
        vSQL.Append(",Cantidad='" & Proveedor.Direccion & "'")
        vSQL.Append(",Precio='" & Proveedor.Telefono & "'")
        vSQL.Append(",Descripcion='" & Proveedor.Empresa & "'")

        Dim resultado As Boolean

        resultado = objBaseDatos.Actualizar(vSQL.ToString, Proveedor.idProveedores)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el Proveedor " + Proveedor.idProveedores)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Proveedor)
        Dim myProperty As PropertyDescriptor = properties.Find("idProveedor", True)
        Me.Items.Item(Me.FindCore(myProperty, Proveedor.idProveedores)) = Proveedor

    End Sub


End Class
