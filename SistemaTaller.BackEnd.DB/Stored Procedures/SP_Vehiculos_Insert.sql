CREATE PROCEDURE SP_Vehiculos_Insert
	@Matricula VARCHAR(9),
    @MarcaVehiculo VARCHAR(30),
	@Modelo VARCHAR(15),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO Vehiculos (Matricula, MarcaVehiculo, Modelo, CreadoPor)
	VALUES
	(@Matricula, @MarcaVehiculo, @Modelo, @CreadoPor)
	END