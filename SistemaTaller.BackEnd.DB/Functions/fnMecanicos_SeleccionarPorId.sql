CREATE FUNCTION fnMecanicos_SeleccionarPorId (@CedulaMecanico Varchar (15))
	RETURNS TABLE 
	AS
	RETURN
	SELECT * FROM vwMecanicos_SeleccionarTodo AS Mecanicos
	WHERE Mecanicos.CedulaMecanico = @CedulaMecanico