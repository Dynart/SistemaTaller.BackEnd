CREATE PROCEDURE SP_Reparaciones_Delete
	@NumeroReparacion INT
	AS
	BEGIN
	SELECT * FROM Reparaciones WHERE NumeroReparacion = @NumeroReparacion
	UPDATE Reparaciones SET Activo = 0 WHERE NumeroReparacion = NumeroReparacion
	END