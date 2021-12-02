CREATE VIEW vwClientes_SeleccionarPorId
	AS
	SELECT * FROM Clientes WHERE CedulaCliente = CedulaCliente AND Activo = 1