CREATE PROCEDURE SP_Reparaciones_Update
	@NumeroReparacion INT,
	@MontoManoDeObra DECIMAL(18,3),
	@MontoRepuestos DECIMAL(18,3),
	@CedulaMecanico VARCHAR(15),
	@Matricula VARCHAR(9),
	@IdEstadoReparacion INT,
	@ModificadoPor VARCHAR (60),
	@FechaModificacion DATETIME
	AS 
	BEGIN
	UPDATE Reparaciones SET MontoManoDeObra = @MontoManoDeObra, MontoRepuestos = @MontoRepuestos, 
	CedulaMecanico = @CedulaMecanico, Matricula = @Matricula, IdEstadoReparacion = @IdEstadoReparacion, 
	ModificadoPor = @ModificadoPor, FechaCreacion = GETDATE()
	WHERE NumeroReparacion = @NumeroReparacion
	END