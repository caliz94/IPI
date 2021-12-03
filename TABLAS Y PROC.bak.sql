--USE master
--GO

--IF DB_ID('IPICASOPRACTICO') IS NOT NULL
--BEGIN
--	DROP DATABASE IPICASOPRACTICO
--END

--CREATE DATABASE IPICASOPRACTICO
--GO

USE IPICASOPRACTICO
GO

--CREATE TABLE Cliente
--(
--	IdCliente INT PRIMARY KEY,
--	NombreCliente VARCHAR(100) NOT NULL,
--	Saldo MONEY NOT NULL,
--	LimiteCredito MONEY CHECK(LimiteCredito <= 3000000) NOT NULL,
--	Descuento MONEY NOT NULL,
--	Activo BIT not null
--)
--GO

--CREATE TABLE Direcciones
--(
--	IdDireccion INT PRIMARY KEY NOT NULL,
--	IdCliente INT FOREIGN KEY REFERENCES dbo.Cliente(IdCliente) NOT NULL,
--	Calle VARCHAR(25) NOT NULL,
--	Barrio VARCHAR(80) NOT NULL,
--	Distrito VARCHAR(250) NOT NULL,
--	Activo BIT NOT NULL
--)
--GO


--CREATE TABLE Fabrica
--(
--  IdFabrica INT PRIMARY KEY,
--  NombreFabrica VARCHAR(50) NOT NULL,
--  Telefono VARCHAR(13) NOT NULL,
--  Activo BIT NOT NULL
--)
--GO

--CREATE TABLE Articulo
--(
--	IdArticulo INT PRIMARY KEY,
--	Descripción_Articulo VARCHAR(250) NOT NULL,
--	Existencias INT NOT NULL,
--	PrecioUnitario MONEY NOT NULL,
--	IdFabrica INT FOREIGN KEY REFERENCES dbo.Fabrica(IdFabrica) NOT NULL,
--	ArticulosProvistos INT NOT NULL,
--	NoFabricasAlternativas INT NOT NULL
--)
--GO

--CREATE TABLE Pedido
--(
--	IdPedido INT PRIMARY KEY,
--    IdCliente INT FOREIGN KEY REFERENCES dbo.Cliente(IdCliente) NOT NULL,
--	IdDireccion INT FOREIGN KEY REFERENCES dbo.Direcciones(IdDireccion) NOT NULL,
--	FechaPedido DATETIME NOT NULL,
--	Activo BIT NOT NULL
--)
--GO

--CREATE TABLE Detalle_Pedido
--(
--	IdArticulo INT FOREIGN KEY REFERENCES dbo.Articulo(IdArticulo),
--    IdPedido INT FOREIGN KEY REFERENCES dbo.Pedido(IdPedido),
--	Cantidad INT NOT NULL,
--	Fabrica INT FOREIGN KEY REFERENCES dbo.Fabrica(IdFabrica) NOT NULL
--	PRIMARY KEY(IdArticulo,IdPedido)
--)
--GO


--PROCEDIMIENTOS ALMACENADOS
--***************************************** FABRICAS**********************************************************************
CREATE PROCEDURE sp_mostrarCamposFabricas
AS
BEGIN
    SELECT IdFabrica, NombreFabrica, Telefono, Activo FROM dbo.Fabrica 
END
GO

ALTER PROCEDURE sp_mostrarFabricas
AS
BEGIN
    SELECT IdFabrica, NombreFabrica, Telefono FROM dbo.Fabrica 
END
GO

ALTER PROCEDURE sp_mostrarFabricasActivas
AS
BEGIN
	SELECT IdFabrica, NombreFabrica, Telefono FROM Fabrica WHERE Activo = 1
END
GO

ALTER PROCEDURE sp_mostrarFabricasInactivos
AS
BEGIN
	SELECT IdFabrica, NombreFabrica, Telefono FROM Fabrica WHERE Activo = 0
END
GO

CREATE PROCEDURE sp_eliminarFabrica
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

CREATE PROCEDURE sp_actualizarFabrica
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

CREATE PROCEDURE sp_nuevaFabrica
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
--EXEC sp_nuevaFabrica 'CURACAO', '22685303'


ALTER PROCEDURE sp_cargarComboFabrica
AS
BEGIN
	SELECT IdFabrica, 'Id - '+str(IdFabrica) + ' - ' + NombreFabrica AS [NombreFabrica] FROM Fabrica WHERE Activo = 1
END

--*******************************************CLIENTES**********************************************************************
CREATE PROCEDURE sp_mostrarClientes
AS
BEGIN
	SELECT * FROM Cliente --WHERE Activo = 1
END
GO

CREATE PROCEDURE sp_mostrarClientesActivos
AS
BEGIN
	SELECT * FROM Cliente WHERE Activo = 1
END
GO

CREATE PROCEDURE sp_mostrarClientesInactivos
AS
BEGIN
	SELECT * FROM Cliente WHERE Activo = 0
END
GO

CREATE PROCEDURE sp_eliminarCliente
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

CREATE PROCEDURE sp_ActualizarCliente
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


CREATE PROCEDURE sp_nuevoCliente
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

--EXEC dbo.SP_NuevoCliente @NombreCliente = 'Andres Josias Castro Gutierrez',    -- varchar(25)
--                        @Saldo = '10000',   -- varchar(80)
--                        @LimiteCredito = '30000',  -- varchar(250)
--						@Descuento = '300'  -- varchar(250)
--						GO

--***************************************DIRECCIONES*****************************************
ALTER PROCEDURE sp_direcciones
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


--mostrar clientes para agregar dire4cciones----
ALTER PROCEDURE sp_clientesActivos_direcio
AS
BEGIN
	SELECT IdCliente, NombreCliente FROM Cliente WHERE Activo = 1
END
GO
--mostrar direciones del cliente
ALTER procEDURE sp_direciones_cliente
(
@idcliente int
)
as
BEGIN
	select IdDireccion,Calle,Barrio,Distrito from Direcciones where IdCliente=@idcliente and  Activo = 1
END
go

--actualizar direccion
ALTER PROCEDURE sp_actual_direcc
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
		Distrito =@Distrito
	WHERE IdDireccion = @IdDireccion
END
GO
--***********************************************articulos*******************************************************************

--nuevo articulo
ALTER PROCEDURE sp_nuevo_articulo
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

--actualizar articulo

ALTER PROCEDURE sp_actualizar_articulo
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

