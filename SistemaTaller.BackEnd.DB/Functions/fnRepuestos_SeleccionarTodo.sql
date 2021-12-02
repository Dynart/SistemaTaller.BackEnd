CREATE FUNCTION fnRepuestos_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwRepuestos_SeleccionarTodo