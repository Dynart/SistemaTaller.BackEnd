CREATE VIEW vwReparaciones_SeleccionarPorId
	AS
	SELECT * FROM Reparaciones WHERE NumeroReparacion = NumeroReparacion AND Activo = 1