CREATE TABLE Reparaciones (
	NumeroReparacion INT IDENTITY(1,1),
    FechaEstimadaDeReparacion DATETIME DEFAULT GETDATE() + 5, --5 días de manera predeterminada
	MontoManoDeObra DECIMAL(18,3),
	MontoRepuestos DECIMAL(18,3),
	MontoTotal AS MontoManoDeObra + MontoRepuestos,
	CedulaMecanico VARCHAR(15) NOT NULL,
	Matricula VARCHAR(9) NOT NULL,
	IdEstadoReparacion INT NOT NULL,--TODO:Falta hacer la tabla de estados
	Activo BIT DEFAULT(1) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_Reparaciones PRIMARY KEY (NumeroReparacion),
	CONSTRAINT FK_Mecanicos FOREIGN KEY (CedulaMecanico) REFERENCES Mecanicos (CedulaMecanico),
	CONSTRAINT FK_Vehiculos FOREIGN KEY (Matricula) REFERENCES Vehiculos (Matricula),
	CONSTRAINT FK_EstadoReparaciones FOREIGN KEY (IdEstadoReparacion) REFERENCES EstadoReparaciones (IdEstadoReparacion)
)
GO
--Documentación de tablas y campos

EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Reparaciones de vehículos de clientes',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Número consecutivo de reparaciones',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'NumeroReparacion'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Fecha estimada de entrega del vehículo reparado',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'FechaEstimadaDeReparacion'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Monto a cobrar por mano de obra',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'MontoManoDeObra'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Monto a cobrar por el repuesto',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'MontoRepuestos'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Monto total a cobrar de la reparación, incluye monto por mano de obra más monto por repuestos',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'MontoTotal'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula del mecánico acargo de la reparación de un vehículo',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'CedulaMecanico'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Matrícula del vehículo por reparar',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'Matricula'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Estado de la reparación',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Reparaciones', 
    @level2type = N'Column',	@level2name = 'IdEstadoReparacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Reparaciones', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Reparaciones', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Reparaciones', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Reparaciones', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Reparaciones', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'