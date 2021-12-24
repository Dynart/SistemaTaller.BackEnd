CREATE PROCEDURE SP_VehiculosDeClietes_Update
	@Matricula VARCHAR(9), 
	@CedulaCliente VARCHAR(15),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE VehiculosDeClientes SET Matricula = @Matricula, CedulaCliente = @CedulaCliente, ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion Where Matricula = @Matricula
	END