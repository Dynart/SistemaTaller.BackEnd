CREATE FUNCTION fnMecanicosDeTalleres_SeleccionarPorId (@CedulaMecanico VARCHAR(15))
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwMecanicosDeTalleres_SeleccionarTodo AS MecanicosDeTalleres 
	WHERE MecanicosDeTalleres.CedulaMecanico = @CedulaMecanico