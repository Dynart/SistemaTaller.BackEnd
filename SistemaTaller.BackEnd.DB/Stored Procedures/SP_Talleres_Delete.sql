CREATE PROCEDURE SP_Talleres_Delete
	@CedulaJuridica VARCHAR (9)
	AS
	BEGIN
	SELECT* FROM Talleres WHERE CedulaJuridica = @CedulaJuridica
	UPDATE Talleres SET activo = 0 WHERE CedulaJuridica = @CedulaJuridica
	END