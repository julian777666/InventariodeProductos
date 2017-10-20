Option Strict On
Option Explicit Off
Imports System.IO
Module ModuloPrincipal

    Public Productos_list As ProductosCollection
    Public Provedores_list As ProveedoresCollection

    Sub main()

        Productos_list = New ProductosCollection
        Provedores_list = New ProveedoresCollection

        Application.Run(MenuPrincipal)

    End Sub
End Module
