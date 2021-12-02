CREATE PROCEDURE SP_RepuestosDeReparaciones_Delete
	@CodigoRepuesto VARCHAR(12)
	AS
	BEGIN
	SELECT * FROM RepuestosDeReparaciones WHERE CodigoRepuesto = @CodigoRepuesto
	UPDATE RepuestosDeReparaciones SET Activo = 0 WHERE CodigoRepuesto = CodigoRepuesto
	END