

	
CREATE PROCEDURE usp_GetErrorInfo  
AS  
SELECT  
    ERROR_NUMBER() AS ErrorNumber  
    ,ERROR_SEVERITY() AS ErrorSeverity  
    ,ERROR_STATE() AS ErrorState  
    ,ERROR_PROCEDURE() AS ErrorProcedure  
    ,ERROR_LINE() AS ErrorLine  
    ,ERROR_MESSAGE() AS ErrorMessage;  
GO





CREATE PROCEDURE sp_GuardarVenta
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

	




ALTER PROCEDURE sp_cargarmasarticulos
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


EXEC dbo.sp_GuardarVenta 1,3,10,1,2,1
--EXEC sp_cargarmasarticulos 1,3,2,15,1
BEGIN TRAN
			INSERT INTO Pedido (IdPedido, IdCliente, IdDireccion, FechaPedido, Activo) 
			VALUES (2, 1, 3, GETDATE(), 1)
ROLLBACK

select * from Pedido
Select * from detalle_pedido
--select * from Articulo



/*
The INSERT statement conflicted with the FOREIGN KEY constraint "FK__Detalle_P__IdPed__33D4B598". The conflict occurred in database "IPICASOPRACTICO", table "dbo.Pedido", column 'IdPedido'.

*/