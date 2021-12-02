CREATE VIEW vwVehiculos_SeleccionarPorId
	AS
	SELECT * FROM Vehiculos WHERE Matricula = Matricula AND Activo = 1