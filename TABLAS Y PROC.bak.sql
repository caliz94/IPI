CREATE DATABASE IPICASOPRACTICO
GO

USE IPICASOPRACTICO
GO

CREATE TABLE Cliente
(
	NoCliente INT IDENTITY(1, 1) PRIMARY KEY,
	NombreCliente VARCHAR(100) NOT NULL,
	Saldo MONEY NOT NULL,
	LimiteCredito MONEY CHECK(LimiteCredito <= 3000000) NOT NULL,
	Descuento MONEY NOT NULL,
	Activo int not null
)
GO

CREATE TABLE Direcciones
(
	NoDireccion INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	NoCliente INT FOREIGN KEY REFERENCES dbo.Cliente(NoCliente) NOT NULL,
	Calle VARCHAR(25) NOT NULL,
	Barrio VARCHAR(80) NOT NULL,
	Distrito VARCHAR(250) NOT NULL
)
GO


CREATE TABLE Fabrica
(
  NoFabrica INT IDENTITY PRIMARY KEY,
  NombreFabrica VARCHAR(50) NOT NULL,
  CodArticulo INT UNIQUE NOT NULL,
  Descripcion_Articulo VARCHAR(250) NOT NULL,
  Existencias INT NOT NULL,
  Telefono VARCHAR(13) NOT NULL
)
GO

CREATE TABLE Articulo
(
	NoArticulo INT IDENTITY(1, 1) PRIMARY KEY,
	CodArticulo INT UNIQUE FOREIGN KEY REFERENCES Fabrica(CodArticulo) NOT NULL,
	Descripción VARCHAR(250) NOT NULL,
	Fabrica INT FOREIGN KEY REFERENCES dbo.Fabrica(NoFabrica) NOT NULL,
	ArticulosProvistos INT NOT NULL,
	NoFabricasAlternativas INT NOT NULL
)
GO

CREATE TABLE Pedido
(
	IdPedido INT IDENTITY(1, 1) PRIMARY KEY,
    NoCliente INT FOREIGN KEY REFERENCES dbo.Cliente(NoCliente) NOT NULL,
	IdDireccion INT FOREIGN KEY REFERENCES dbo.Direcciones(NoDireccion) NOT NULL,
	FechaPedido TIMESTAMP NOT NULL
)
GO

CREATE TABLE Detalle_Pedido
(
	NoArticulo INT FOREIGN KEY REFERENCES dbo.Articulo(CodArticulo),
    NoPedido INT FOREIGN KEY REFERENCES dbo.Pedido(IdPedido),
	Cantidad INT NOT NULL,
	Fabrica INT FOREIGN KEY REFERENCES dbo.Fabrica(NoFabrica) NOT NULL
	PRIMARY KEY(NoArticulo,NoPedido)
)
GO


--PROCEDIMIENTOS ALMACENADOS
--***************************************** FABRICAS**********************************************************************
CREATE PROCEDURE sp_mostrarFabricas
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
BEGIN
    SELECT * FROM dbo.Fabrica
END
GO



--*******************************************CLIENTES**********************************************************************

CREATE PROC SP_NuevoCliente
(
	@NombreCliente VARCHAR(100),
	@Saldo MONEY ,
	@LimiteCredito MONEY,
	@Descuento MONEY,
	@Activo int
)as
INSERT INTO dbo.Cliente

VALUES
(   
	@NombreCliente,   -- NombreCliente - varchar(120)
    @Saldo, -- Saldo - money
    @LimiteCredito, -- LimiteCredito - money
    @Descuento, -- Descuento - money
    @Activo  -- Activo - bit
)
GO
--***************************************DIRECCIONES*****************************************
create procedure sp_direcciones
@idcliente int,
@calle varchar(25),
@barrio varchar(80),
@distrito varchar(250)
AS
begin
	insert into dbo.Direcciones (NoCliente, Calle, Barrio, Distrito) values (@idcliente, @calle, @barrio, @distrito)
end
select * from Cliente
SELECT * FROM Direcciones

EXEC dbo.sp_direcciones @idcliente = 1, -- int
                        @calle = 'Vida nUEVA',    -- varchar(25)
                        @barrio = 'La cruz',   -- varchar(80)
                        @distrito = 'II'  -- varchar(250)
						GO
