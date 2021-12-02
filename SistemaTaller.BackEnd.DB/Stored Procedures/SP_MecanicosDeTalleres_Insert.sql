CREATE PROCEDURE SP_MecanicosDeTalleres_Insert
	@CedulaMecanico VARCHAR(15), 
	@CedulaJuridica VARCHAR(12),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO MecanicosDeTalleres (CedulaMecanico, CedulaJuridica, CreadoPor)
	VALUES
	(@CedulaMecanico, @CedulaJuridica, @CreadoPor)
	END