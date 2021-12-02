CREATE FUNCTION fnTalleres_SeleccionarPorId (@CedulaJuridica Varchar (9))
	RETURNS TABLE 
	AS
	RETURN
	SELECT * FROM vwTalleres_SeleccionarTodo AS Talleres
	WHERE Talleres.CedulaJuridica = @CedulaJuridica