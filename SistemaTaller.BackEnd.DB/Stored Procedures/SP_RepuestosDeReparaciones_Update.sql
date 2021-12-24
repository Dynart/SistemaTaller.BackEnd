CREATE PROCEDURE SP_RepuestosDeReparaciones_Update
	@CodigoRepuesto VARCHAR(12),
	@PrecioRepuesto DECIMAL(18,3),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion VARCHAR(60)
	AS
	BEGIN
	UPDATE RepuestosDeReparaciones SET CodigoRepuesto = @CodigoRepuesto, PrecioRepuesto = @PrecioRepuesto, 
	ModificadoPor = @ModificadoPor, FechaCreacion = @FechaModificacion WHERE CodigoRepuesto = @CodigoRepuesto
	END