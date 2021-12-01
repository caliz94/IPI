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

CREATE TABLE Cliente
(
	IdCliente INT PRIMARY KEY,
	NombreCliente VARCHAR(100) NOT NULL,
	Saldo MONEY NOT NULL,
	LimiteCredito MONEY CHECK(LimiteCredito <= 3000000) NOT NULL,
	Descuento MONEY NOT NULL,
	Activo BIT not null
)
GO

CREATE TABLE Direcciones
(
	IdDireccion INT PRIMARY KEY NOT NULL,
	IdCliente INT FOREIGN KEY REFERENCES dbo.Cliente(IdCliente) NOT NULL,
	Calle VARCHAR(25) NOT NULL,
	Barrio VARCHAR(80) NOT NULL,
	Distrito VARCHAR(250) NOT NULL,
	Activo BIT NOT NULL
)
GO


CREATE TABLE Fabrica
(
  IdFabrica INT PRIMARY KEY,
  NombreFabrica VARCHAR(50) NOT NULL,
  --CodArticulo INT UNIQUE NOT NULL,
  --Descripcion_Articulo VARCHAR(250) NOT NULL,
  --Existencias INT NOT NULL,
  Telefono VARCHAR(13) NOT NULL,
  Activo BIT NOT NULL
)
GO

CREATE TABLE Articulo
(
	IdArticulo INT PRIMARY KEY,
	--CodArticulo INT UNIQUE FOREIGN KEY REFERENCES Fabrica(CodArticulo) NOT NULL,
	Descripción_Articulo VARCHAR(250) NOT NULL,
	Existencias INT NOT NULL,
	PrecioUnitario MONEY NOT NULL,
	IdFabrica INT FOREIGN KEY REFERENCES dbo.Fabrica(IdFabrica) NOT NULL,
	ArticulosProvistos INT NOT NULL,
	NoFabricasAlternativas INT NOT NULL
)
GO

CREATE TABLE Pedido
(
	IdPedido INT PRIMARY KEY,
    IdCliente INT FOREIGN KEY REFERENCES dbo.Cliente(IdCliente) NOT NULL,
	IdDireccion INT FOREIGN KEY REFERENCES dbo.Direcciones(IdDireccion) NOT NULL,
	FechaPedido TIMESTAMP NOT NULL
)
GO

CREATE TABLE Detalle_Pedido
(
	IdArticulo INT FOREIGN KEY REFERENCES dbo.Articulo(IdArticulo),
    IdPedido INT FOREIGN KEY REFERENCES dbo.Pedido(IdPedido),
	Cantidad INT NOT NULL,
	Fabrica INT FOREIGN KEY REFERENCES dbo.Fabrica(IdFabrica) NOT NULL
	PRIMARY KEY(IdArticulo,IdPedido)
)
GO


--PROCEDIMIENTOS ALMACENADOS
--***************************************** FABRICAS**********************************************************************
CREATE PROCEDURE sp_mostrarFabricas
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
BEGIN
    SELECT * FROM dbo.Fabrica WHERE Activo = 1
END
GO



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

CREATE PROCEDURE sp_EliminarCliente
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


CREATE PROCEDURE SP_NuevoCliente
(
	@NombreCliente VARCHAR(100),
	@Saldo MONEY ,
	@LimiteCredito MONEY,
	@Descuento MONEY
)
AS
BEGIN
	DECLARE @IdCliente INT
	SET @IdCliente = (select max(isnull(IdCliente,0)+1) from Cliente)

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


EXEC dbo.SP_NuevoCliente @NombreCliente = 'Perla del Socorro Jarquin Mendoza',    -- varchar(25)
                        @Saldo = '10000',   -- varchar(80)
                        @LimiteCredito = '30000',  -- varchar(250)
						@Descuento = '300'  -- varchar(250)
						GO

--***************************************DIRECCIONES*****************************************
ALTER PROCEDURE sp_direcciones
@idcliente INT,
@calle VARCHAR(25),
@barrio VARCHAR(80),
@distrito VARCHAR(250)
AS
BEGIN
	DECLARE @iddireccion INT

	SET @iddireccion = (select isnull(max(IdDireccion),1) from Direcciones)

	INSERT INTO dbo.Direcciones (IdDireccion,IdCliente, Calle, Barrio, Distrito, Activo)
	VALUES (@iddireccion, @idcliente, @calle, @barrio, @distrito, 1)
END


select * from Cliente
SELECT * FROM Direcciones

EXEC dbo.sp_direcciones @idcliente = 1, -- int
                        @calle = 'Vida Nueva',    -- varchar(25)
                        @barrio = 'La cruz',   -- varchar(80)
                        @distrito = 'II'  -- varchar(250)
						
						GO
