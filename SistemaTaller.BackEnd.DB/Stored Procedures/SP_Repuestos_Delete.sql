CREATE PROCEDURE SP_Repuestos_Delete
	@CodigoRepuesto VARCHAR(12)
	AS
	BEGIN
	SELECT * FROM Repuestos WHERE CodigoRepuesto = @CodigoRepuesto
	UPDATE Repuestos SET Activo = 0 WHERE CodigoRepuesto = CodigoRepuesto
	END