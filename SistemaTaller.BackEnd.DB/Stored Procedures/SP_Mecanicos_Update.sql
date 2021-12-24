CREATE PROCEDURE SP_Mecanicos_Update
	@CedulaMecanico VARCHAR(15),
    @Nombre VARCHAR(40),
    @Apellidos VARCHAR(50),
    @Telefono VARCHAR(10),
    @Salario DECIMAL(18,3),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE Mecanicos set CedulaMecanico = @CedulaMecanico, Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, Salario = @Salario,
	ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion
	WHERE CedulaMecanico = @CedulaMecanico
	END