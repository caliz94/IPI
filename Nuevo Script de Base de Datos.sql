USE master
GO

IF DB_ID('IPICASOPRACTICO') IS NOT NULL
BEGIN
	DROP DATABASE IPICASOPRACTICO
END

CREATE DATABASE IPICASOPRACTICO
GO

USE IPICASOPRACTICO
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[IdArticulo] [int] NOT NULL,
	[Descripción_Articulo] [varchar](250) NOT NULL,
	[Existencias] [int] NOT NULL,
	[PrecioUnitario] [money] NOT NULL,
	[IdFabrica] [int] NOT NULL,
	[ArticulosProvistos] [int] NOT NULL,
	[NoFabricasAlternativas] [int] NOT NULL)
--PRIMARY KEY CLUSTERED 
--(
--	[IdArticulo] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] NOT NULL,
	[NombreCliente] [varchar](100) NOT NULL,
	[Saldo] [money] NOT NULL,
	[LimiteCredito] [money] NOT NULL,
	[Descuento] [money] NOT NULL,
	[Activo] [bit] NOT NULL)
--PRIMARY KEY CLUSTERED 
--(
--	[IdCliente] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Pedido]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Pedido](
	[Id] [int] NOT NULL,
	[IdArticulo] [int] NULL,
	[IdPedido] [int] NULL,
	[Cantidad] [int] NOT NULL,
	[Fabrica] [int] NOT NULL)
--PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direcciones]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direcciones](
	[IdDireccion] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Calle] [varchar](25) NOT NULL,
	[Barrio] [varchar](80) NOT NULL,
	[Distrito] [varchar](250) NOT NULL,
	[Activo] [bit] NOT NULL)
--PRIMARY KEY CLUSTERED 
--(
--	[IdDireccion] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fabrica]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabrica](
	[IdFabrica] [int] NOT NULL,
	[NombreFabrica] [varchar](50) NOT NULL,
	[Telefono] [varchar](13) NOT NULL,
	[Activo] [bit] NOT NULL)
--PRIMARY KEY CLUSTERED 
--(
--	[IdFabrica] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdDireccion] [int] NOT NULL,
	[FechaPedido] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL)
--PRIMARY KEY CLUSTERED 
--(
--	[IdPedido] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
GO
--ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD FOREIGN KEY([IdFabrica])
--REFERENCES [dbo].[Fabrica] ([IdFabrica])
--GO
--ALTER TABLE [dbo].[Detalle_Pedido]  WITH CHECK ADD FOREIGN KEY([Fabrica])
--REFERENCES [dbo].[Fabrica] ([IdFabrica])
--GO
--ALTER TABLE [dbo].[Detalle_Pedido]  WITH CHECK ADD FOREIGN KEY([IdPedido])
--REFERENCES [dbo].[Pedido] ([IdPedido])
--GO
--ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD FOREIGN KEY([IdCliente])
--REFERENCES [dbo].[Cliente] ([IdCliente])
--GO
--ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([IdCliente])
--REFERENCES [dbo].[Cliente] ([IdCliente])
--GO
--ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([IdDireccion])
--REFERENCES [dbo].[Direcciones] ([IdDireccion])
--GO
--ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD CHECK  (([LimiteCredito]<=(3000000)))
--GO
/****** Object:  StoredProcedure [dbo].[sp_actual_direcc]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--actualizar direccion
CREATE PROCEDURE [dbo].[sp_actual_direcc]
(
	@IdDireccion INT,
	@calle VARCHAR(100),
	@Barrio VARCHAR(100),
	@Distrito VARCHAR(100)
)
AS
BEGIN
	UPDATE Direcciones
	SET Calle = @calle,
		Barrio = @Barrio,
		Distrito = @Distrito
	WHERE IdDireccion = @IdDireccion
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_articulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--actualizar articulo

CREATE PROCEDURE [dbo].[sp_actualizar_articulo]
(
@IdArticulo INT ,
@Descripción_Articulo VARCHAR(250),
@Existencias INT,
@PrecioUnitario MONEY,
@IdFabrica INT,
@ArticulosProvistos INT,
@NoFabricasAlternativas INT
)
AS
BEGIN
	UPDATE Articulo 
	SET 
			Descripción_Articulo = @Descripción_Articulo,
			Existencias = @Existencias,
			PrecioUnitario = @PrecioUnitario,
			IdFabrica = @IdFabrica,
			ArticulosProvistos = @ArticulosProvistos,
			NoFabricasAlternativas = @NoFabricasAlternativas
	WHERE IdArticulo = @IdArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarCliente]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ActualizarCliente]
(
@IdCliente INT,
@NombreCliente VARCHAR(100),
@Saldo MONEY,
@Limite MONEY,
@Descuento MONEY,
@Activo BIT
)
AS
BEGIN
	UPDATE dbo.Cliente
	SET NombreCliente = @NombreCliente, Saldo = @Saldo, LimiteCredito = @Limite, Descuento = @Descuento, Activo = @Activo
	WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarFabrica]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_actualizarFabrica]
(
	@IdFabrica INT,
	@NombreFabrica VARCHAR(50),
	@Telefono VARCHAR(13),
	@Activo BIT
)
AS
BEGIN
	UPDATE dbo.Fabrica
	SET NombreFabrica = @NombreFabrica, Telefono = @Telefono, Activo = @Activo
	WHERE IdFabrica = @IdFabrica
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ArticulosProvistosxIdFabrica]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--sp para cargar articulos provistos
CREATE PROCEDURE [dbo].[sp_ArticulosProvistosxIdFabrica]
(
	@IdFabrica INT
)
AS
BEGIN
	SELECT COUNT(IdArticulo) as Articulos_Provistos FROM Articulo WHERE IdFabrica = @IdFabrica
END
GO
/****** Object:  StoredProcedure [dbo].[sp_buscaFabricaxId]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	

CREATE PROCEDURE [dbo].[sp_buscaFabricaxId]
(
@IdFabrica INT
)
AS
BEGIN
	SELECT * FROM Fabrica WHERE IdFabrica LIKE ((CAST(@IdFabrica AS VARCHAR(20)))+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_buscaFabricaxNombre]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_buscaFabricaxNombre]
(
@Nombre VARCHAR(50)
)
AS
BEGIN
--DECLARE @IdFabrica INT
--SET @IdFabrica = 1
	SELECT * FROM Fabrica WHERE NombreFabrica LIKE ('%'+@Nombre+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarComboArticulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_cargarComboArticulo]
AS
BEGIN
	SELECT IdArticulo, ltrim(rtrim(str(IdArticulo))) + ' - ' + ltrim(rtrim(Descripción_Articulo)) AS [NombreArticulo] 
	FROM Articulo WHERE Existencias > 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarComboCliente]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--***************************************** PROCEDIMIENTO VENTAS****************************************************

CREATE PROCEDURE [dbo].[sp_cargarComboCliente]
AS
BEGIN
	SELECT IdCliente, ltrim(rtrim(str(IdCliente))) + ltrim(' - ') + ltrim(rtrim(NombreCliente)) AS [NombreCliente] 
	FROM Cliente WHERE Activo = 1
END

GO
/****** Object:  StoredProcedure [dbo].[sp_cargarComboDirecciones]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DECLARE @cantidad INT
--EXEC sp_validarExistenciaArticulo 1, @cantidad OUTPUT
--SELECT @cantidad

/*************************  VENTAS  ********************************/

--CREATE TYPE detalleVenta AS TABLE
--(
--	Id INT /*IDENTITY PRIMARY KEY*/,
--	IdPedido INT,
--	IdArticulo INT,
--	Cantidad INT, 
--	Fabrica INT
--)
--GO


--CREATE PROCEDURE sp_GuardarVenta
--(
--@IdCliente INT,
--@IdDireccion INT,
--@Cantidad INT,
--@Activo BIT,
--@LstDetalles detalleVenta READONLY
--)
--AS
--BEGIN 
--	DECLARE @IdPedido INT
--	DECLARE @IdVenta INT
--	SELECT @IdPedido = ISNULL(MAX(IdPedido),0)+1 FROM Pedido
	
--	INSERT INTO Pedido (IdPedido, IdCliente, IdDireccion, FechaPedido, Activo) 
--	VALUES (@IdPedido, @IdCliente,@IdDireccion ,GETDATE() ,@Activo)


--	SELECT @IdPedido = ISNULL(MAX(Id),0)+1 FROM Detalle_Pedido
--	SET @IdVenta = @@IDENTITY
--	INSERT INTO Detalle_Pedido (/*Id,*/ IdPedido, IdArticulo, Cantidad, Fabrica)
--	VALUES ()
--	SELECT /*@IdPedido,*/ @IdPedido, IdArticulo, @Cantidad, Fabrica FROM @LstDetalles
	
--END
--GO

--/*
--SELECT * FROM Pedido
--SELECT * FROM Detalle_Pedido
--SELECT * FROM @LstDetalles
--*/
----DECLARE @LstDetalles detalleVenta
----INSERT INTO @LstDetalles (/*Id,*/IdArticulo, IdPedido, Cantidad, Fabrica)
----		VALUES (/*1,*/1,5,12,1)
----INSERT INTO @LstDetalles (/*Id,*/IdArticulo, IdPedido, Cantidad, Fabrica)
----		VALUES (/*2,*/2,10,24,1)
----EXEC dbo.sp_GuardarVenta 1,1,1,@LstDetalles

--go


CREATE PROCEDURE [dbo].[sp_cargarComboDirecciones]
(
@IdCliente INT
)
AS
BEGIN
	SELECT IdCliente, ltrim(rtrim(str(IdDireccion)))+' - '+ltrim(rtrim('Calle: '+ Calle+', Barrio: '+ Barrio+', Distrito: '+ Distrito)) AS [Dirección] 
	FROM Direcciones WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarComboFabrica]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_cargarComboFabrica]
AS
BEGIN
	SELECT IdFabrica, ltrim(rtrim('Id - '))+ltrim(rtrim(str(IdFabrica))) + '- ' + NombreFabrica AS [NombreFabrica] FROM Fabrica WHERE Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarmasarticulos]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_cargarmasarticulos]
(
	@IdCliente INT,
	@IdDireccion INT,
	@IdArticulo INT, 
	@Cantidad INT, 
	@IdFabrica INT
)
AS
BEGIN 
	DECLARE @IdC INT
	DECLARE @IdDetalle INT
	SELECT @IdDetalle = ISNULL(MAX(Id),0)+1 FROM Detalle_Pedido
	SELECT @IdC = IdPedido FROM Pedido WHERE IdCliente = @IdCliente AND IdDireccion = @IdDireccion
	IF @IdC IS NULL
	BEGIN
		PRINT 'PROCESO FALLIDO'
		RETURN
	END
	ELSE
	BEGIN
		INSERT INTO Detalle_Pedido (Id, IdPedido, IdArticulo, Cantidad, Fabrica) 
		VALUES (@IdDetalle,@IdC,@IdArticulo, @Cantidad, @IdFabrica)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_clientesActivos_direcio]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CREATE TABLE ConsecutivoDirecciones
--(
--Id int primary key,
--IdCliente int,
--IdDirección int
--)
--GO

--mostrar clientes para agregar dire4cciones----
CREATE PROCEDURE [dbo].[sp_clientesActivos_direcio]
AS
BEGIN
	SELECT IdCliente, NombreCliente FROM Cliente WHERE Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_direcciones]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--***************************************DIRECCIONES*****************************************
CREATE PROCEDURE [dbo].[sp_direcciones]
(
	@idcliente INT,
	@calle VARCHAR(25),
	@barrio VARCHAR(80),
	@distrito VARCHAR(250)
)
AS
BEGIN
	DECLARE @iddireccion INT
	
	
	SET @iddireccion = (select isnull(max(IdDireccion),0)+1 from Direcciones)
	
	INSERT INTO dbo.Direcciones (IdDireccion,IdCliente, Calle, Barrio, Distrito, Activo)
	VALUES (@iddireccion, @idcliente, @calle, @barrio, @distrito, 1)

	--DECLARE @Contador INT
	--INSERT INTO ConsecutivoDirecciones VALUES ()


END
GO
/****** Object:  StoredProcedure [dbo].[sp_direciones_cliente]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--mostrar direciones del cliente
CREATE PROCEDURE [dbo].[sp_direciones_cliente]
(
@idcliente int
)
as
BEGIN
	select IdDireccion,Calle,Barrio,Distrito from Direcciones where IdCliente=@idcliente and  Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_articulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--eliminar articulo
create proc [dbo].[sp_eliminar_articulo]
@idArticulo int
as
BEGIN
	delete from Articulo where IdArticulo = @idArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarCliente]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_eliminarCliente]
(
@IdCliente INT
)
AS
BEGIN
	UPDATE dbo.Cliente
	SET Activo = 0
	WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarFabrica]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminarFabrica]
(
	@IdFabrica INT
)
AS
BEGIN
	UPDATE dbo.Fabrica
	SET Activo = 0
	WHERE IdFabrica = @IdFabrica
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FabricasAlternartivas]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_FabricasAlternartivas]
(
@Descripcion VARCHAR(250)
)
AS
BEGIN
	select count(f.NombreFabrica) as fabricas_alternativas from Fabrica as f inner join Articulo as a on a.IdFabrica = f.IdFabrica
	where a.Descripción_Articulo = @Descripcion
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarVenta]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GuardarVenta]
(
@IdCliente INT,
@IdDireccion INT,
@Cantidad INT,
@Activo BIT,
@IdArticulo INT,
@IdFabrica INT
--@LstDetalles detalleVenta READONLY
)
AS
BEGIN 
	DECLARE @IdPedido INT
	DECLARE @estado BIT
	DECLARE @Id INT
	BEGIN TRY  
		BEGIN TRAN 
		SELECT @IdPedido = ISNULL(MAX(IdPedido),0)+1 FROM Pedido

			INSERT INTO Pedido (IdPedido, IdCliente, IdDireccion, FechaPedido, Activo) 
			VALUES (@IdPedido, @IdCliente, @IdDireccion, GETDATE(), @Activo)		
			SET @estado = 1
	
			IF @estado = 1
			BEGIN
				SELECT @Id = ISNULL(MAX(Id),0)+1 FROM Detalle_Pedido
				SELECT @IdPedido = ISNULL(MAX(Id),0)+1 FROM Detalle_Pedido
				INSERT INTO Detalle_Pedido (Id, IdPedido, IdArticulo, Cantidad, Fabrica)
				VALUES (@Id,@IdPedido, @IdArticulo, @Cantidad, @IdFabrica)
				COMMIT TRAN
				PRINT 'FINALIZADO CORRECTAMENTE'
			END
	END TRY  
	BEGIN CATCH  
		ROLLBACK  
		EXEC usp_GetErrorInfo
		PRINT 'SE GENERO UN ERROR'
	END CATCH; 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_artic]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--mostrar articulos
create proc [dbo].[sp_mostrar_artic]
as
BEGIN
	select	a.IdArticulo,
			a.Descripción_Articulo,
			a.Existencias,
			a.PrecioUnitario,
			f.NombreFabrica,
			a.ArticulosProvistos,
			a.NoFabricasAlternativas 
	from Articulo as a inner join Fabrica as f on a.IdFabrica = f.IdFabrica
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarCamposFabricas]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--PROCEDIMIENTOS ALMACENADOS
--***************************************** FABRICAS**********************************************************************
CREATE PROCEDURE [dbo].[sp_mostrarCamposFabricas]
AS
BEGIN
    SELECT IdFabrica, NombreFabrica, Telefono, Activo FROM dbo.Fabrica 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarClientes]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--*******************************************CLIENTES**********************************************************************
CREATE PROCEDURE [dbo].[sp_mostrarClientes]
AS
BEGIN
	SELECT * FROM Cliente --WHERE Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarClientesActivos]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_mostrarClientesActivos]
AS
BEGIN
	SELECT * FROM Cliente WHERE Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarClientesInactivos]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_mostrarClientesInactivos]
AS
BEGIN
	SELECT * FROM Cliente WHERE Activo = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarFabricas]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_mostrarFabricas]
AS
BEGIN
    SELECT IdFabrica, NombreFabrica, Telefono FROM dbo.Fabrica 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarFabricasActivas]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_mostrarFabricasActivas]
AS
BEGIN
	SELECT IdFabrica, NombreFabrica, Telefono FROM Fabrica WHERE Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarFabricasInactivos]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_mostrarFabricasInactivos]
AS
BEGIN
	SELECT IdFabrica, NombreFabrica, Telefono FROM Fabrica WHERE Activo = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_nuevaFabrica]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_nuevaFabrica]
(
	@NombreFabrica VARCHAR(50),
	@Telefono VARCHAR(13)
)
AS
BEGIN
	DECLARE @IdFabrica INT
	SELECT @IdFabrica = (SELECT ISNULL(MAX(IdFabrica),0)+1 FROM Fabrica)

	INSERT INTO dbo.Fabrica (IdFabrica, NombreFabrica, Telefono, Activo)
	VALUES
	(   
		@IdFabrica, -- IdCliente - INT
		@NombreFabrica,   -- NombreCliente - varchar(120)
		@Telefono, -- Saldo - money
		1
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_nuevo_articulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--***********************************************articulos*******************************************************************

--nuevo articulo
CREATE PROCEDURE [dbo].[sp_nuevo_articulo]
(
@Descripción_Articulo VARCHAR(250),
@Existencias INT,
@PrecioUnitario MONEY,
@IdFabrica INT,
@ArticulosProvistos INT,
@NoFabricasAlternativas INT
)
AS
BEGIN
	DECLARE @IdArticulo INT
	SELECT @IdArticulo = ISNULL(MAX(IdArticulo),0)+1 FROM Articulo
	INSERT INTO Articulo VALUES(@IdArticulo,@Descripción_Articulo,@Existencias,@PrecioUnitario,@IdFabrica,@ArticulosProvistos,@NoFabricasAlternativas)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_nuevoCliente]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_nuevoCliente]
(
	@NombreCliente VARCHAR(100),
	@Saldo MONEY ,
	@LimiteCredito MONEY,
	@Descuento MONEY
)
AS
BEGIN
	DECLARE @IdCliente INT
	SET @IdCliente = (select ISNULL(MAX(IdCliente),0)+1 from Cliente)

	INSERT INTO dbo.Cliente
	VALUES
	(   
		@IdCliente, -- IdCliente - INT
		@NombreCliente,   -- NombreCliente - varchar(120)
		@Saldo, -- Saldo - money
		@LimiteCredito, -- LimiteCredito - money
		@Descuento, -- Descuento - money
		1  -- Activo - bit
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_validarExistenciaArticulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_validarExistenciaArticulo]
(
@IdArticulo INT
)
AS
BEGIN
	SELECT A.Existencias FROM Articulo AS A INNER JOIN Fabrica AS F ON A.IdFabrica = F.IdFabrica WHERE IdArticulo = @IdArticulo
	--SELECT IdCliente FROM Cliente WHERE IdCliente = @IdArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_validarPrecioArticulo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_validarPrecioArticulo]
(
@IdArticulo INT
)
AS
BEGIN
	SELECT A.PrecioUnitario FROM Articulo AS A INNER JOIN Fabrica AS F ON A.IdFabrica = F.IdFabrica WHERE IdArticulo = @IdArticulo
	--SELECT IdCliente FROM Cliente WHERE IdCliente = @IdArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetErrorInfo]    Script Date: 9/12/2021 12:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	


	
CREATE PROCEDURE [dbo].[usp_GetErrorInfo]  
AS  
SELECT  
    ERROR_NUMBER() AS ErrorNumber  
    ,ERROR_SEVERITY() AS ErrorSeverity  
    ,ERROR_STATE() AS ErrorState  
    ,ERROR_PROCEDURE() AS ErrorProcedure  
    ,ERROR_LINE() AS ErrorLine  
    ,ERROR_MESSAGE() AS ErrorMessage;  
GO


/****** CREACIÓN DE VISTAS PARA CALCULO DE MONTOS ******/
CREATE VIEW vw_descripcionDetalle 
AS
SELECT DP.Id, DP.IdPedido, DP.IdArticulo, A.Descripción_Articulo, DP.Cantidad, A.PrecioUnitario, DP.Fabrica, (DP.Cantidad * A.PrecioUnitario) AS [Total]
FROM [dbo].[Detalle_Pedido] AS DP 
INNER JOIN Articulo AS A ON DP.IdArticulo = A.IdArticulo
GO

/****** OBTIENE INFORMACIÓN DEL PEDIDO POR IDPEDIDO ******/
CREATE PROCEDURE sp_ObtienePedido
(
@IdPedido INT
)
AS
BEGIN
	SELECT	P.IdPedido, 
			P.IdCliente, 
			C.NombreCliente AS [Nombre del Cliente], 
			P.IdDireccion, 
			('Calle: '+D.Calle + ', ' + 'Barrio: '+D.Barrio + ', ' + 'Distrito: '+D.Distrito) AS [Dirección],
			(
				SELECT SUM(Total) FROM vw_descripcionDetalle
				WHERE IdPedido = @IdPedido
			) AS [Total Pedido]
	FROM Pedido AS P 
		INNER JOIN vw_descripcionDetalle AS V ON P.IdPedido = V.Id
		INNER JOIN Cliente AS C ON P.IdCliente = C.IdCliente
		INNER JOIN Direcciones AS D ON P.IdDireccion = D.IdDireccion
	GROUP BY 
			P.IdPedido, 
			P.IdCliente, 
			('Calle: '+D.Calle + ', ' + 'Barrio: '+D.Barrio + ', ' + 'Distrito: '+D.Distrito),
			C.NombreCliente, 
			P.IdDireccion
	HAVING P.IdPedido = @IdPedido
END
GO

/****** OBTIENE EL DETALLE DEL PEDIDO POR IDPEDIDO ******/
create PROCEDURE sp_ObtieneDetallePedido
(
@IdPedido INT
)
AS
BEGIN
	SELECT IdPedido, IdArticulo, Descripción_Articulo, Cantidad, PrecioUnitario, Fabrica AS [IdFabrica], Total FROM vw_descripcionDetalle WHERE IdPedido = @IdPedido
END
GO

alter PROCEDURE sp_Mostrar_Todos_Pedidos
AS
BEGIN
	SELECT	P.IdPedido, 
			P.IdCliente, 
			C.NombreCliente AS [Nombre del Cliente], 
			P.IdDireccion, 
			('Calle: '+D.Calle + ', ' + 'Barrio: '+D.Barrio + ', ' + 'Distrito: '+D.Distrito) AS [Dirección],
			(
				SELECT SUM(Total) FROM vw_descripcionDetalle
				--WHERE IdPedido = @IdPedido
			) AS [Total Pedido]
	FROM Pedido AS P 
		INNER JOIN vw_descripcionDetalle AS V ON P.IdPedido = V.Id
		INNER JOIN Cliente AS C ON P.IdCliente = C.IdCliente
		INNER JOIN Direcciones AS D ON P.IdDireccion = D.IdDireccion
	GROUP BY 
			P.IdPedido, 
			P.IdCliente, 
			('Calle: '+D.Calle + ', ' + 'Barrio: '+D.Barrio + ', ' + 'Distrito: '+D.Distrito),
			C.NombreCliente, 
			P.IdDireccion
	--HAVING P.IdPedido = @IdPedido
END
GO