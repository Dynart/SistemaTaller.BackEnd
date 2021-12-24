CREATE PROCEDURE SP_Talleres_Update
	@CedulaJuridica VARCHAR(12),
	@Nombre VARCHAR (20),
	@Direccion VARCHAR(255),
	@Telefono VARCHAR(9),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE Talleres set CedulaJuridica = @CedulaJuridica, Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono,
	ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion
	WHERE CedulaJuridica = @CedulaJuridica
	END