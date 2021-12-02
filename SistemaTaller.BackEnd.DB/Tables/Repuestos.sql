CREATE TABLE Repuestos(
	CodigoRepuesto VARCHAR(12),
    Marca VARCHAR(25) NOT NULL,
    Tipo VARCHAR(25) NOT NULL,
    FechaCompra DATE NOT NULL,
    Precio DECIMAL(18,3),
	Activo BIT DEFAULT(1) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_Repuesto PRIMARY KEY(CodigoRepuesto)
)
GO
--Documentación de tabla
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Repuestos de los Vehiculos del cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Repuestos'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Codigo del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Repuestos', 
    @level2type = N'Column',	@level2name = 'CodigoRepuesto'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Marca del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Repuestos', 
    @level2type = N'Column',	@level2name = 'Marca'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Tipo del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Repuestos', 
    @level2type = N'Column',	@level2name = 'Tipo'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Fecha de compra del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Repuestos', 
    @level2type = N'Column',	@level2name = 'FechaCompra'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Precio del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Repuestos', 
    @level2type = N'Column',	@level2name = 'Precio'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Repuestos', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Repuestos', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Repuestos', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Repuestos', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Repuestos', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'