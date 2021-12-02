CREATE FUNCTION fnClientes_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwClientes_SeleccionarTodo