Public Class ProveedorClass
    Dim idProveedores_, Telefono_ As Integer
    Dim Nombre_, Direccion_, Empresa_ As String

    Public Property idProveedores() As Integer
        Get
            Return idProveedores_
        End Get
        Set(ByVal value As Integer)
            idProveedores_ = value
        End Set
    End Property
    Public Property Telefono() As Integer
        Get
            Return Telefono_
        End Get
        Set(ByVal value As Integer)
            Telefono_ = value
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
    Public Property Direccion() As String
        Get
            Return Direccion_

        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property
    Public Property Empresa() As String
        Get
            Return Empresa_

        End Get
        Set(ByVal value As String)
            Empresa_ = value
        End Set
    End Property

End Class
