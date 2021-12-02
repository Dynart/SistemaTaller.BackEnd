CREATE PROCEDURE SP_RepuestosDeReparaciones_Insert
	@CodigoRepuesto VARCHAR(12),
	@NumeroReparacion INT,
	@PrecioRepuesto DECIMAL(18,3),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO RepuestosDeReparaciones (CodigoRepuesto, NumeroReparacion, PrecioRepuesto, CreadoPor)
	VALUES
	(@CodigoRepuesto, @NumeroReparacion, @PrecioRepuesto, @CreadoPor)
	END