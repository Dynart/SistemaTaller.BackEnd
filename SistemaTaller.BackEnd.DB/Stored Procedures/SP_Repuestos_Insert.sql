CREATE PROCEDURE SP_Repuestos_Insert
	@CodigoRepuesto VARCHAR(12),
    @Marca VARCHAR(25),
    @Tipo VARCHAR(25),
    @FechaCompra DATE,
    @Precio DECIMAL(18,3),
	@CreadoPor VARCHAR(60)
	AS
	BEGIN
	INSERT INTO Repuestos (CodigoRepuesto, Marca, Tipo, FechaCompra, Precio, CreadoPor)
	VALUES
	(@CodigoRepuesto, @Marca, @Tipo, @FechaCompra, @Precio, @CreadoPor)
	END