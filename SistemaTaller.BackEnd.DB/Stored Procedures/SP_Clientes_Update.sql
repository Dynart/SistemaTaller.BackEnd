CREATE PROCEDURE SP_Clientes_Update
	@CedulaCliente VARCHAR(15),
    @Nombre VARCHAR(40),
    @Apellidos VARCHAR(50),
    @Telefono VARCHAR(10),
    @Email VARCHAR(50),
    @Direccion VARCHAR(255),
	@VehiculoMatricula VARCHAR(9),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE Clientes SET CedulaCliente = @CedulaCliente, Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, Email = @Email, Direccion = @Direccion,
	VehiculoMatricula = @VehiculoMatricula, ModificadoPor = @ModificadoPor, @FechaModificacion = @FechaModificacion
	WHERE CedulaCliente = CedulaCliente
	END