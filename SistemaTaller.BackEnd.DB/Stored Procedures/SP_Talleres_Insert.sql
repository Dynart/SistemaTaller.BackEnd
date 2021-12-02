CREATE PROCEDURE SP_Talleres_Insert
	@CedulaJuridica VARCHAR(12),
	@Nombre VARCHAR (20),
	@Direccion VARCHAR(255),
	@Telefono VARCHAR(9),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO Talleres (CedulaJuridica, Nombre, Direccion, Telefono, CreadoPor)
	VALUES
	(@CedulaJuridica, @Nombre, @Direccion, @Telefono, @CreadoPor)
	END