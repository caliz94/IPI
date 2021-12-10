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


-- SELECT * FROM Articulo
--select * from Fabrica


--select * from Articulo WHERE IdFabrica = 1 



--SELECT COUNT(IdArticulo) as Articulos_Provistos FROM Articulo WHERE IdFabrica = 1 

--SELECT * FROM dbo.Cliente
--SELECT * FROM dbo.Pedido
--SELECT * FROM dbo.Detalle_Pedido


--ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD FOREIGN KEY([IdFabrica])
--REFERENCES [dbo].[Fabrica] ([IdFabrica])
--GO
--ALTER TABLE [dbo].[Detalle_Pedido]  WITH CHECK ADD FOREIGN KEY([Fabrica])
--REFERENCES [dbo].[Fabrica] ([IdFabrica])
--GO
--ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD FOREIGN KEY([IdCliente])
--REFERENCES [dbo].[Cliente] ([IdCliente])
--GO
--ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([IdCliente])
--REFERENCES [dbo].[Cliente] ([IdCliente])
--GO
--ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([IdDireccion])
--REFERENCES [dbo].[Direcciones] ([IdDireccion])