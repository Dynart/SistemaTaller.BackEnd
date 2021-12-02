CREATE FUNCTION fnReparaciones_SeleccionarPorId (@NumeroReparacion INT)
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwReparaciones_SeleccionarTodo AS Reparaciones
	WHERE Reparaciones.NumeroReparacion = @NumeroReparacion