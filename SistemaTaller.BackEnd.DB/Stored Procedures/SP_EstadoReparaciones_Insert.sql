CREATE PROCEDURE SP_EstadoReparaciones_Insert
	@IdEstadoReparacion INT,
	@NombreEstado VARCHAR(15),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO EstadoReparaciones (IdEstadoReparacion, NombreEstado, CreadoPor)
	VALUES
	(@IdEstadoReparacion, @NombreEstado, @CreadoPor)
	END