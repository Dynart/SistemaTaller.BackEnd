CREATE FUNCTION fnClientes_SeleccionarPorId(@CedulaCliente VARCHAR(15))
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwClientes_SeleccionarTodo AS Cliente
	WHERE Cliente.CedulaCliente = @CedulaCliente