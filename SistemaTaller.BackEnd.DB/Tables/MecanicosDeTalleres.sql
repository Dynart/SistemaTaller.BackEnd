CREATE TABLE MecanicosDeTalleres(
    CedulaMecanico VARCHAR(15), 
	CedulaJuridica VARCHAR(12),
	Activo BIT NOT NULL DEFAULT 1,
	FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_MecanicosDeTalleres PRIMARY KEY (CedulaMecanico,CedulaJuridica),
	CONSTRAINT FK_Mecanicos_CedulaMecanico FOREIGN KEY (CedulaMecanico) REFERENCES Mecanicos (CedulaMecanico),
	CONSTRAINT FK_Talleres FOREIGN KEY (CedulaJuridica) REFERENCES Talleres (CedulaJuridica)
)
GO
--Documentación de tablas y campos

EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Mecánicos los cuales trabajan en los talleres',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'MecanicosDeTalleres'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula del Mecánico',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
    @level2type = N'Column',	@level2name = 'CedulaMecanico'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula jurídica del Talleres',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
    @level2type = N'Column',	@level2name = 'CedulaJuridica'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'MecanicosDeTalleres', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'