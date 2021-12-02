CREATE PROCEDURE SP_EstadoDeReparaciones_Update
	@IdEstadoReparacion INT,
	@NombreEstado VARCHAR(15),
	@ModificadoPor VARCHAR (60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE EstadoReparaciones SET IdEstadoReparacion = @IdEstadoReparacion, NombreEstado = @NombreEstado, ModificadoPor = @ModificadoPor, FechaCreacion = GETDATE()
	END