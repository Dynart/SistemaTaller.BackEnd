CREATE FUNCTION fnRepuestosDeReparaciones_SeleccionarPorId (@CodigoRepuesto VARCHAR(12))
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwRepuestosDeReparacion_SeleccionarTodo AS RepuestosDeReparaciones
	WHERE RepuestosDeReparaciones.CodigoRepuesto = @CodigoRepuesto