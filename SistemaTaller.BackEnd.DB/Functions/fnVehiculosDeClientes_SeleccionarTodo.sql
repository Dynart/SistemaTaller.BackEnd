CREATE FUNCTION fnVehiculosDeClientes_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwVehiculosDeClientes_SeleccionarTodos