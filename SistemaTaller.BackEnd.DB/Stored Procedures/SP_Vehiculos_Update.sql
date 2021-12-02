CREATE PROCEDURE SP_Vehiculos_Update
	@Matricula VARCHAR(9),
    @MarcaVehiculo VARCHAR(30),
	@Modelo VARCHAR(15),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE Vehiculos SET Matricula = @Matricula, MarcaVehiculo = @MarcaVehiculo, Modelo = @Modelo,
	ModificadoPor = @ModificadoPor, FechaCreacion = GETDATE()
	WHERE Matricula = Matricula
	END