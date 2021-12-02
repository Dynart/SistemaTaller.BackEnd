CREATE PROCEDURE SP_VehiculosDeClientes_Insert
	@Matricula VARCHAR(9), 
	@CedulaCliente VARCHAR(15),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO VehiculosDeClientes (Matricula, CedulaCliente, CreadoPor)
	VALUES
	(@Matricula, @CedulaCliente, @CreadoPor)
	END