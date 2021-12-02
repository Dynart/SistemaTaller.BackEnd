CREATE PROCEDURE SP_VehiculosDeClientes_Delete
	@Matricula VARCHAR (9)
	AS
	BEGIN
	SELECT * FROM VehiculosDeClientes WHERE Matricula = @Matricula
	UPDATE VehiculosDeClientes SET Activo = 0 WHERE Matricula = Matricula
	END