CREATE FUNCTION fnVehiculos_SeleccionarPorId (@Matricula VARCHAR(9))
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwVehiculos_SeleccionarTodo AS Vehiculos
	WHERE Vehiculos.Matricula = @Matricula