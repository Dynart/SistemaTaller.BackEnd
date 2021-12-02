CREATE FUNCTION fnEstadoDeReparacion_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwEstadoDeReparaciones_SeleccionarTodo