CREATE PROCEDURE SP_Mecanicos_Delete
	@CedulaMecanico VARCHAR(15)
	AS
	BEGIN
	SELECT* FROM Mecanicos WHERE CedulaMecanico = @CedulaMecanico
	UPDATE Mecanicos SET Activo = 0 WHERE CedulaMecanico = @CedulaMecanico
	END