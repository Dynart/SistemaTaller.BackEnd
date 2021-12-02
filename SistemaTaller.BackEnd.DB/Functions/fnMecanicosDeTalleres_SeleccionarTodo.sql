CREATE FUNCTION fnMecanicosDeTalleres_SeleccionarTodo ()
	RETURNS TABLE
	AS
	RETURN
	SELECT * FROM vwMecanicosDeTalleres_SeleccionarTodo