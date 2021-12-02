CREATE TABLE VehiculosDeClientes(
	Matricula VARCHAR(9), 
	CedulaCliente VARCHAR(15), 
	Activo BIT NOT NULL DEFAULT 1,
	FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_VehiculosDeClientes PRIMARY KEY (Matricula,CedulaCliente),
	CONSTRAINT FK_Vehiculos_Matricula FOREIGN KEY (Matricula) REFERENCES Vehiculos (Matricula),
	CONSTRAINT FK_Clientes FOREIGN KEY (CedulaCliente) REFERENCES Clientes (CedulaCliente)
)
GO
--Documentación de tablas y campos

EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Vehículos de los Clientes',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'VehiculosDeClientes'
GO
----Documentación a campos

EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Matricula del vehículo',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
    @level2type = N'Column',	@level2name = 'Matricula'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula del Cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
    @level2type = N'Column',	@level2name = 'CedulaCliente'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'VehiculosDeClientes', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'