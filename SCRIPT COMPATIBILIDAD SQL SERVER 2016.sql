USE master
GO

IF DB_ID('IPICASOPRACTICO') IS NOT NULL
BEGIN
		-- Take the Database Offline
	ALTER DATABASE IPICASOPRACTICO SET OFFLINE WITH
	ROLLBACK IMMEDIATE
	
	-- Take the Database Online
	ALTER DATABASE IPICASOPRACTICO SET ONLINE
	

	DROP DATABASE IPICASOPRACTICO
END

CREATE DATABASE IPICASOPRACTICO
GO

USE IPICASOPRACTICO
GO

/****** Object:  Table [dbo].[Articulo]    Script Date: 9/12/2021 10:35:54 a. m. ******/
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
	[NoFabricasAlternativas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Pedido]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Pedido](
	[Id] [int] NOT NULL,
	[IdArticulo] [int] NULL,
	[IdPedido] [int] NULL,
	[Cantidad] [int] NOT NULL,
	[Fabrica] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_descripcionDetalle]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_descripcionDetalle] 
AS
SELECT DP.Id, DP.IdPedido, DP.IdArticulo,IdFabrica, A.Descripción_Articulo, DP.Cantidad, A.PrecioUnitario,(DP.Cantidad * A.PrecioUnitario) AS [Total]
FROM [dbo].[Detalle_Pedido] AS DP 
INNER JOIN Articulo AS A ON DP.IdArticulo = A.IdArticulo
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direcciones]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fabrica]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabrica](
	[IdFabrica] [int] NOT NULL,
	[NombreFabrica] [varchar](50) NOT NULL,
	[Telefono] [varchar](13) NOT NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdDireccion] [int] NOT NULL,
	[FechaPedido] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD CHECK  (([LimiteCredito]<=(3000000)))
GO
/****** Object:  StoredProcedure [dbo].[sp_actual_direcc]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_actualizar_articulo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarCliente]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_actualizarFabrica]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ArticulosProvistosxIdFabrica]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_buscaFabricaxId]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_buscaFabricaxNombre]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
	SELECT * FROM Fabrica WHERE NombreFabrica LIKE ('%'+@Nombre+'%')
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarComboArticulo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_cargarComboCliente]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_cargarComboDirecciones]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
/****** Object:  StoredProcedure [dbo].[sp_cargarComboFabrica]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_cargarmasarticulos]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_clientesActivos_direcio]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--mostrar clientes para agregar dire4cciones----
CREATE PROCEDURE [dbo].[sp_clientesActivos_direcio]
AS
BEGIN
	SELECT IdCliente, NombreCliente FROM Cliente WHERE Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_direcciones]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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

END
GO
/****** Object:  StoredProcedure [dbo].[sp_direciones_cliente]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_eliminar_articulo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_eliminarCliente]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_eliminarFabrica]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_FabricasAlternartivas]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GuardarVenta]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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


CREATE PROCEDURE [dbo].[sp_GuardarVenta]
(
@IdCliente INT,
@IdDireccion INT,
@Cantidad INT,
@Activo BIT,
@IdArticulo INT,
@IdFabrica INT
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
				SELECT @IdPedido = ISNULL(MAX(IdPedido),0) FROM Pedido
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
/****** Object:  StoredProcedure [dbo].[sp_mostrar_artic]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarCamposFabricas]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarClientes]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarClientesActivos]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarClientesInactivos]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarFabricas]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarFabricasActivas]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_mostrarFabricasInactivos]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_nuevaFabrica]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_nuevo_articulo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_nuevoCliente]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtieneDetallePedido]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** OBTIENE EL DETALLE DEL PEDIDO POR IDPEDIDO ******/
CREATE PROCEDURE [dbo].[sp_ObtieneDetallePedido]
(
@IdPedido INT
)
AS
BEGIN
SELECT IdPedido,NombreFabrica,IdArticulo, Descripción_Articulo, Cantidad, PrecioUnitario, Total 
FROM vw_descripcionDetalle AS VW
INNER JOIN Fabrica AS F ON VW.IdFabrica = F.IdFabrica
WHERE IdPedido =  @IdPedido
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtienePedido]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** OBTIENE INFORMACIÓN DEL PEDIDO POR IDPEDIDO ******/
CREATE PROCEDURE [dbo].[sp_ObtienePedido]
(
@IdPedido INT
)
AS
BEGIN

	SELECT	P.IdPedido, 
			--P.IdCliente, 
			C.NombreCliente AS [Nombre del Cliente], 
			--P.IdDireccion, 
			--('Calle: '+D.Calle + ', ' + 'Barrio: '+D.Barrio + ', ' + 'Distrito: '+D.Distrito) AS [Dirección],
			(
				SELECT SUM(Total) FROM vw_descripcionDetalle
				WHERE IdPedido =  @IdPedido
			) AS [Total]
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
	HAVING P.IdPedido =@IdPedido 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_validarExistenciaArticulo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_validarPrecioArticulo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[usp_GetErrorInfo]    Script Date: 9/12/2021 10:35:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** mostrar todos los pedidos ******/
CREATE PROCEDURE sp_Mostrar_Todos_Pedidos
AS
BEGIN
SELECT IdPedido,NombreCliente,SUM(TOTAL)TOTAL FROM VW_TOTALXPEDIDO AS T
INNER JOIN Cliente AS C ON C.IdCliente = T.IdCliente
GROUP BY IdPedido,C.NombreCliente ORDER BY IdPedido
END
GO
	


	

USE IPICASOPRACTICO
GO

EXEC sp_nuevaFabrica 'CURACAO', '22685303'
GO
EXEC sp_nuevaFabrica 'DINANT', '22685303'
GO
EXEC sp_nuevaFabrica 'COCA COLA', '22685303'
GO
EXEC sp_nuevaFabrica 'PEPSI', '22685303'
GO
EXEC sp_nuevaFabrica 'DICEPSA', '22685303'
GO

EXEC dbo.sp_nuevo_articulo	@Descripción_Articulo	=	'COLGATE PALMOLIVE', --VARCHAR(250),
							@Existencias			=	100,	--INT,
							@PrecioUnitario			=	30,	--MONEY,
							@IdFabrica				=	2,	--INT,
							@ArticulosProvistos		=	100,--INT,
							@NoFabricasAlternativas =	0	--INT
						GO

EXEC dbo.sp_nuevo_articulo	@Descripción_Articulo	=	'PLAYSTATION V', --VARCHAR(250),
							@Existencias			=	0,	--INT,
							@PrecioUnitario			=	300,	--MONEY,
							@IdFabrica				=	3,	--INT,
							@ArticulosProvistos		=	100,--INT,
							@NoFabricasAlternativas =	0	--INT
						GO

EXEC dbo.sp_nuevo_articulo	@Descripción_Articulo	=	'MONITOR DELL STATUS 01', --VARCHAR(250),
							@Existencias			=	100,	--INT,
							@PrecioUnitario			=	30,	--MONEY,
							@IdFabrica				=	1,	--INT,
							@ArticulosProvistos		=	100,--INT,
							@NoFabricasAlternativas =	0	--INT
						GO


EXEC dbo.SP_NuevoCliente @NombreCliente = 'Perla del Socorro Jiron Mendoza',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO

EXEC dbo.SP_NuevoCliente @NombreCliente = 'Danny Enrique Caliz Treminio',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO

EXEC dbo.SP_NuevoCliente @NombreCliente = 'José Alexander Martínez Briones',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO

EXEC dbo.SP_NuevoCliente @NombreCliente = 'Isadiana del Socorro Perez Morales',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO

EXEC dbo.SP_NuevoCliente @NombreCliente = 'Scannor Capital Sin',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO
EXEC dbo.SP_NuevoCliente @NombreCliente = 'Danny Trejos Machete',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO


EXEC dbo.sp_direcciones @idcliente	= 1,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 1,
						@calle		= '13'		,	--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 1,
						@calle		= '13'	,		--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 2,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 2,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 2,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 3,
						@calle		= '13'		,	--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 3,
						@calle		= '13'	,		--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 3,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 4,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 5,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 5,
						@calle		= '13'		,	--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 5,
						@calle		= '13'	,		--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 6,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 6,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO