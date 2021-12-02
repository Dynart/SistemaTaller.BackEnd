CREATE PROCEDURE SP_Reparaciones_Insert
	@NumeroReparacion INT,
	@MontoManoDeObra DECIMAL(18,3),
	@MontoRepuestos DECIMAL(18,3),
	@CedulaMecanico VARCHAR(15),
	@Matricula VARCHAR(9),
	@IdEstadoReparacion INT,
	@CreadoPor VARCHAR (60)
	AS
	BEGIN
	INSERT INTO Reparaciones (NumeroReparacion, MontoManoDeObra, MontoRepuestos, CedulaMecanico, Matricula, IdEstadoReparacion, CreadoPor)
	VALUES
	(@NumeroReparacion, @MontoManoDeObra, @MontoRepuestos, @CedulaMecanico, @Matricula, @IdEstadoReparacion, @CreadoPor)
	END