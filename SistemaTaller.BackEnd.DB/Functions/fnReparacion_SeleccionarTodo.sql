CREATE FUNCTION fnReparacion_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwReparaciones_SeleccionarTodo