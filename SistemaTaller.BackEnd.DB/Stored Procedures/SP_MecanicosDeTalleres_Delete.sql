CREATE PROCEDURE SP_MecanicosDeTalleres_Delete
	@CedulaMecanico VARCHAR (15)
	AS
	BEGIN
	SELECT * FROM MecanicosDeTalleres WHERE CedulaMecanico = @CedulaMecanico
	UPDATE MecanicosDeTalleres set Activo = 0 WHERE CedulaMecanico = CedulaMecanico
	END