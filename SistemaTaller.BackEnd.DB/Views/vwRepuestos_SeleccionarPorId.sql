CREATE VIEW vwRepuestos_SeleccionarPorId
	AS
	SELECT * FROM Repuestos WHERE CodigoRepuesto = CodigoRepuesto AND Activo = 1