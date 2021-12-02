CREATE FUNCTION fnEstadoDeReparaciones_SeleccionarPorId (@IdEstadoReparacion INT)
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwEstadoDeReparaciones_SeleccionarTodo AS EstadoDeReparacion
	WHERE EstadoDeReparacion.IdEstadoReparacion = @IdEstadoReparacion