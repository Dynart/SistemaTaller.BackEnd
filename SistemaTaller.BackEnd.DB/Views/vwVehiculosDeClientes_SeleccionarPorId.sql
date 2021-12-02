CREATE VIEW vwVehiculosDeClientes_SeleccionarPorId
	AS
	SELECT * FROM VehiculosDeClientes WHERE Matricula = Matricula AND Activo = 1