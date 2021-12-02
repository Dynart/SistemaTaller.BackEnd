CREATE TABLE Clientes (
	CedulaCliente VARCHAR(15) ,
    Nombre VARCHAR(40) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Telefono VARCHAR(10),
    Email VARCHAR(50),
    Direccion VARCHAR(255),
	VehiculoMatricula VARCHAR(9) NOT NULL, --TODO: Se debe crear una tabla intermedia para crear varios vehículos del cliente
	Activo BIT DEFAULT(1) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE() NOT NULL,
	FechaModificacion DATETIME,
	CreadoPor VARCHAR(60),
	ModificadoPor VARCHAR(60),
	CONSTRAINT PK_Cliente PRIMARY KEY (CedulaCliente),
	CONSTRAINT FK_Vehiculos_VehiculoMatricula FOREIGN KEY (VehiculoMatricula) REFERENCES Vehiculos (Matricula)
)
GO
--Documentación de tabla
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Clientes los cuales necesitan los servicios de reparación de vehículos',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Clientes'
GO
----Documentación a campos
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Cédula del cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Clientes', 
    @level2type = N'Column',	@level2name = 'CedulaCliente'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Apellidos del cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Clientes', 
    @level2type = N'Column',	@level2name = 'Apellidos'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Téléfono del cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Clientes', 
    @level2type = N'Column',	@level2name = 'Telefono'
GO
EXEC sp_addextendedproperty
    @name = N'MS_Description',	@value = 'Email del cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Clientes', 
    @level2type = N'Column',	@level2name = 'Email'
GO
EXEC sp_addextendedproperty 
    @name = N'MS_Description',	@value = 'Dirección del cliente',
    @level0type = N'Schema',	@level0name = 'dbo',
    @level1type = N'Table',		@level1name = 'Clientes', 
    @level2type = N'Column',	@level2name = 'Direccion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Condición en la que se encuentra el registro: 1 = Activo; 0 = Inactivo o Borrado',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Clientes', 
   	@level2type = N'Column',	@level2name = 'Activo'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de creación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Clientes', 
   	@level2type = N'Column',	@level2name = 'FechaCreacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Fecha de modificación del registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Clientes', 
   	@level2type = N'Column',	@level2name = 'FechaModificacion'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que crea el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Clientes', 
   	@level2type = N'Column',	@level2name = 'CreadoPor'
GO
EXEC sp_addextendedproperty 
	@name = N'MS_Description',	@value = 'Nombre del usuario que modifica el registro',
   	@level0type = N'Schema',	@level0name = 'dbo',
   	@level1type = N'Table',		@level1name = 'Clientes', 
   	@level2type = N'Column',	@level2name = 'ModificadoPor'