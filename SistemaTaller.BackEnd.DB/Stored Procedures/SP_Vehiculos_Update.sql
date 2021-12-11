CREATE PROCEDURE SP_Vehiculos_Update
	@Matricula VARCHAR(9),
    @MarcaVehiculo VARCHAR(30),
	@Modelo VARCHAR(15),
	@ModificadoPor VARCHAR(60),
	@FechaModificacion DATETIME
	AS
	BEGIN
	UPDATE Vehiculos SET Matricula = @Matricula, MarcaVehiculo = @MarcaVehiculo, Modelo = @Modelo,
	ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion
	WHERE Matricula = @Matricula
	END