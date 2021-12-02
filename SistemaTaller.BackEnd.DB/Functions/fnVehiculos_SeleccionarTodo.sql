CREATE FUNCTION fnVehiculos_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN 
	SELECT * FROM vwVehiculos_SeleccionarTodo