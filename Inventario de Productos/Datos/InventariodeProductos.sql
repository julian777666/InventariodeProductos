IF DB_ID('Inventario de Productos') IS NULL
	CREATE DATABASE InventariodeProductos;
 
GO 

USE [Inventario de Productos];


IF OBJECT_ID('Productos') IS not NULL

CREATE TABLE [dbo].[Productos](
	[idProducto] [int]Identity (1,1) ,
	[Nombre] [nchar](50) NULL,
	[Cantidad] [int] NULL,
	[Precio] [money] NULL,
	[Descripcion] [nchar](50) NULL,
	[idProveedores] int FOREIGN KEY REFERENCES Proveedores(idProveedores),
 CONSTRAINT [PK_Productos] PRIMARY KEY (idProducto)
);

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('Proveedores') IS NULL
	
CREATE TABLE [dbo].[Proveedores](
	[idProveedores] [int]Identity(1,1) ,
	[Nombre] [nchar](50) NULL,
	[Direccion] [nchar](50) NULL,
	[Telefono] [int] NULL,
	[Empresa] [nchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY (idProveedores)
)

select * from Productos 

select * from Proveedores
