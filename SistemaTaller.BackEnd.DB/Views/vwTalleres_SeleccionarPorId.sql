CREATE VIEW vwTalleres_SeleccionarPorId
	AS
	SELECT * FROM Talleres WHERE CedulaJuridica = CedulaJuridica AND activo = 1