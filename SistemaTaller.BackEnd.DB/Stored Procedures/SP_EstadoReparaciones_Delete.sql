CREATE PROCEDURE SP_EstadoReparaciones_Delete
	@IdEstadoReparacion INT
	AS
	BEGIN
	SELECT * FROM EstadoReparaciones WHERE IdEstadoReparacion = @IdEstadoReparacion
	UPDATE EstadoReparaciones SET Activo = 0 WHERE IdEstadoReparacion = IdEstadoReparacion
	END