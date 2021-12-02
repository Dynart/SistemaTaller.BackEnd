CREATE FUNCTION fnRepuestos_SeleccionarPorId (@CodigoRepuesto VARCHAR(12))
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwRepuestos_SeleccionarTodo AS Repuestos
	WHERE Repuestos.CodigoRepuesto = @CodigoRepuesto