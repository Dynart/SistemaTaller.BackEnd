CREATE FUNCTION fnTalleres_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwTalleres_SeleccionarTodo