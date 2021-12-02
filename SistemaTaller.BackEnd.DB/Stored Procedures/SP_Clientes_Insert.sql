CREATE PROCEDURE SP_Clientes_Insert
	@CedulaCliente VARCHAR(15),
    @Nombre VARCHAR(40),
    @Apellidos VARCHAR(50),
    @Telefono VARCHAR(10),
    @Email VARCHAR(50),
    @Direccion VARCHAR(255),
	@VehiculoMatricula VARCHAR(9),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO Clientes (CedulaCliente, Nombre, Apellidos, Telefono, Email, Direccion, VehiculoMatricula, CreadoPor)
	VALUES
	(@CedulaCliente, @Nombre, @Apellidos, @Telefono, @Email, @Direccion, @VehiculoMatricula, @CreadoPor)
	END