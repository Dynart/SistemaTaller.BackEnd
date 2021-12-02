CREATE PROCEDURE SP_Mecanicos_Insert
	@CedulaMecanico VARCHAR(15),
    @Nombre VARCHAR(40),
    @Apellidos VARCHAR(50),
    @Telefono VARCHAR(10),
    @Salario DECIMAL(18,3),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO Mecanicos (CedulaMecanico, Nombre, Apellidos, Telefono, Salario, CreadoPor)
	VALUES
	(@CedulaMecanico, @Nombre, @Apellidos, @Telefono, @Salario, @CreadoPor)
	END