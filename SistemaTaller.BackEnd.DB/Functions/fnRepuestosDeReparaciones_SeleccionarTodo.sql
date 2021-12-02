CREATE FUNCTION fnRepuestosDeReparaciones_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwRepuestosDeReparacion_SeleccionarTodo