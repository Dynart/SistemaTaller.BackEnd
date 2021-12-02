CREATE PROCEDURE SP_Vehiculos_Delete
	@Matricula VARCHAR (9)
	AS
	BEGIN
	SELECT * FROM Vehiculos WHERE Matricula = @Matricula
	UPDATE Vehiculos SET Activo = 0 WHERE Matricula = Matricula
	END