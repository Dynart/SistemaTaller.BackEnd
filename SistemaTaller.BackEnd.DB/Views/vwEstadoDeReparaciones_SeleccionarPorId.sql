CREATE VIEW vwEstadoDeReparaciones_SeleccionarPorId
	AS
	SELECT * FROM EstadoReparaciones WHERE IdEstadoReparacion = IdEstadoReparacion AND Activo = 1