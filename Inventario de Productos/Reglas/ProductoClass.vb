Public Class ProductoClass
    Dim idProducto_, Cantidad_, Precio_, idProveedores_ As Integer
    Dim Nombre_, Descripcion_ As String

    Public Property idProducto() As Integer
        Get
            Return idProducto_
        End Get
        Set(ByVal value As Integer)
            idProducto_ = value
        End Set
    End Property
    Public Property idProveedores() As Integer
        Get
            Return idProveedores_
        End Get
        Set(ByVal value As Integer)
            idProveedores_ = value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As Integer)
            Cantidad_ = value
        End Set
    End Property
    Public Property Precio() As Integer
        Get
            Return Precio_
        End Get
        Set(ByVal value As Integer)
            Precio_ = value
        End Set
    End Property
    
    Public Property Nombre() As String
        Get
            Return Nombre_

        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property
   
End Class
