CREATE TABLE Mecanicos (
    CedulaMecanico VARCHAR(15),
    Nombre VARCHAR(40) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Telefono VARCHAR(10)NULL,
    Salario DECIMAL(18,3),
	Activo BIT DEFAULT(1) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_Mecanicos PRIMARY KEY (CedulaMecanico)
)
GO
--Documentación de tabla
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Mecánicos los cuales atienden a los clientes',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Mecanicos'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula del mecánico',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Mecanicos', 
    @level2type = N'Column',	@level2name = 'CedulaMecanico'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Nombre del mecánico',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Mecanicos', 
    @level2type = N'Column',	@level2name = 'Nombre'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Apellidos del mecánico',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Mecanicos', 
    @level2type = N'Column',	@level2name = 'Apellidos'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Téléfono del mecánicos',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Mecanicos', 
    @level2type = N'Column',	@level2name = 'Telefono'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Salario del mecánico',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Mecanicos', 
    @level2type = N'Column',	@level2name = 'Salario'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Mecanicos', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Mecanicos', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Mecanicos', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Mecanicos', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Mecanicos', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'