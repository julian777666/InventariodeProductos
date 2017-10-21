USE [Inventario de Productos]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('Productos') IS NULL

CREATE TABLE [dbo].[Productos](
	[idProducto] [int] NOT NULL,
	[Nombre] [nchar](50) NULL,
	[Cantidad] [int] NULL,
	[Precio] [money] NULL,
	[Descripcion] [nchar](50) NULL,
	[idProveedores] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY (idProducto)
)

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('Proveedores') IS NULL
	
CREATE TABLE [dbo].[Proveedores](
	[idProveedores] [int] NOT NULL,
	[Nombre] [nchar](50) NULL,
	[Direccion] [nchar](50) NULL,
	[Telefono] [int] NULL,
	[Empresa] [nchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY (idProveedores)
)
