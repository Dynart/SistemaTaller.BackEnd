CREATE TABLE Talleres (
	CedulaJuridica VARCHAR(12),
    Nombre VARCHAR(20) NOT NULL,
    Direccion VARCHAR(255) NOT NULL,
    Telefono VARCHAR(9) NOT NULL,
	Activo BIT DEFAULT(1) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_Taller PRIMARY KEY (CedulaJuridica)
)
GO
--Documentación de tabla
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Talleres mecánicos que el sistema gestiona',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Talleres'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula jurídica del taller',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Talleres', 
    @level2type = N'Column',	@level2name = 'CedulaJuridica'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Nombre del taller',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Talleres', 
    @level2type = N'Column',	@level2name = 'Nombre'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Dirección del taller',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Talleres', 
    @level2type = N'Column',	@level2name = 'Direccion'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Teléfono principal del taller',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Talleres', 
    @level2type = N'Column',	@level2name = 'Telefono'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Talleres', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Talleres', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Talleres', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Talleres', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Talleres', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'