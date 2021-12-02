CREATE PROCEDURE SP_Clientes_Delete
	@CedulaCliente VARCHAR(15)
	AS
	BEGIN
	SELECT * FROM Clientes where CedulaCliente = @CedulaCliente
	UPDATE Clientes SET Activo = 0 WHERE CedulaCliente = CedulaCliente
	END