CREATE VIEW vwRepuestosDeReparaciones_SeleccionarPorId
	AS
	SELECT * FROM RepuestosDeReparaciones WHERE CodigoRepuesto = CodigoRepuesto AND Activo = 1