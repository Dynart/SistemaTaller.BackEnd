CREATE PROCEDURE SP_MecanicosDeTalleres_Update
	@CedulaMecanico VARCHAR(15), 
	@CedulaJuridica VARCHAR(12),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE MecanicosDeTalleres SET CedulaMecanico = @CedulaMecanico, CedulaJuridica = @CedulaJuridica, ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion
	WHERE CedulaMecanico = @CedulaMecanico
	END