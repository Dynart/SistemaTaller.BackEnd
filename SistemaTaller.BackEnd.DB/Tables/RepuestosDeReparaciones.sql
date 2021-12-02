CREATE TABLE RepuestosDeReparaciones(
	CodigoRepuesto VARCHAR(12),
	NumeroReparacion INT IDENTITY(1,1),
	PrecioRepuesto DECIMAL(18,3),
	Activo BIT DEFAULT(1) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_RepuestoDeReparaciones PRIMARY KEY(CodigoRepuesto,NumeroReparacion),
	CONSTRAINT FK_Repuestos FOREIGN KEY (CodigoRepuesto) REFERENCES Repuestos (CodigoRepuesto),
	CONSTRAINT FK_Reparaciones FOREIGN KEY (NumeroReparacion) REFERENCES Reparaciones (NumeroReparacion)
)
GO
--Documentación de tabla
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Repuestos para las reparaciones de los vehículos',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'RepuestosDeReparaciones'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Codigo del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
    @level2type = N'Column',	@level2name = 'CodigoRepuesto'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Número consecutivo de reparaciones',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
    @level2type = N'Column',	@level2name = 'NumeroReparacion'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Precio del repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
    @level2type = N'Column',	@level2name = 'PrecioRepuesto'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'RepuestosDeReparaciones', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'