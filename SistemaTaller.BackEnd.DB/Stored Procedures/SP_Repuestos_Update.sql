CREATE PROCEDURE SP_Repuestos_Update
	@CodigoRepuesto VARCHAR(12),
    @Marca VARCHAR(25),
    @Tipo VARCHAR(25),
    @FechaCompra DATE,
    @Precio DECIMAL(18,3),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE Repuestos SET CodigoRepuesto = @CodigoRepuesto, Marca = @Marca, Tipo = @Tipo, FechaCompra = @FechaCompra, 
	Precio = @Precio, ModificadoPor = @ModificadoPor, @FechaModificacion = GETDATE()
	END