CREATE FUNCTION fnMecanicos_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwMecanicos_SeleccionarTodo