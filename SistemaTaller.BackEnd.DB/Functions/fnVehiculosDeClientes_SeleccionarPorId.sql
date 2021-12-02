CREATE FUNCTION fnVehiculosDeClientes_SeleccionarPorId (@Matricula VARCHAR(9))
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwVehiculosDeClientes_SeleccionarTodos AS VehiculosDeClientes
	WHERE VehiculosDeClientes.Matricula = @Matricula