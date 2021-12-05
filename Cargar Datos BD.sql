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
							@IdFabrica				=	1,	--INT,
							@ArticulosProvistos		=	100,--INT,
							@NoFabricasAlternativas =	0	--INT
						GO

EXEC dbo.sp_nuevo_articulo	@Descripción_Articulo	=	'PLAYSTATION V', --VARCHAR(250),
							@Existencias			=	0,	--INT,
							@PrecioUnitario			=	300,	--MONEY,
							@IdFabrica				=	1,	--INT,
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
EXEC dbo.sp_direcciones @idcliente	= 1,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO
EXEC dbo.sp_direcciones @idcliente	= 1,
						@calle		= '13',			--VARCHAR(25),
						@barrio		= 'Residente',	--VARCHAR(80),
						@distrito	= 'La Calle'	--VARCHAR(250)
						GO



-- SELECT * FROM Articulo
--select * from Fabrica