--Creacion de base de datos
create database DB_ActividadesAgape
go
--Usar base de datos
use DB_ActividadesAgape
go
--Table Empleados
create table Empleados(
IdEmpleado int identity(1,1) primary key not null,
CodEmpleado as ('Emp'+right('00'+convert(varchar,IdEmpleado),(2))),
CodigoEmpleado int unique not null,
Nombre nvarchar(50) not null,
Apellido nvarchar(50) not null,
Email nvarchar(50) unique not null,
FechaNacimiento date not null
)
go
-- Tabla Roles
create table Roles(
IdRol int identity(1,1) primary key not null,
CodRol as ('Rls'+right('00'+convert(varchar,IdRol),(2))),
NombreRol varchar(50) not null,
)
go
--Tabla Usuarios
create table Usuarios(
IdUsuario int identity(1,1) primary key not null,
CodUsuario as ('Usr'+right('00'+convert(varchar,IdUsuario),(2))),
IdEmpleados int not null,
IdRoles int not null,
_Password nvarchar(50) not null,
FechaCreacion datetime not null,
constraint FK_Empleados_USUARIO  
foreign key (IdEmpleados) 
references Empleados (IdEmpleado) on delete cascade,
constraint FK_Roles_USUARIO  
foreign key (IdRoles) 
references Roles (IdRol) on delete cascade
)
go
--Tabla Actividades
create table Actividades(
IdActividad int identity(1,1) primary key not null,
CodActividad as ('Act'+right('00'+convert(varchar,IdActividad),(2))),
DescripcionActividad nvarchar(max) not null,
ValorActividad decimal not null,
NivelActividad nvarchar(10) not null,
NotaActividad nvarchar(max) null,
)
go
--Tabla Diviciones
create table Diviciones(
IdDivicion int identity(1,1) primary key not null,
CodDivicion as ('Dvc'+right('00'+convert(varchar,IdDivicion),(2))),
AliasDivicion nvarchar(10) not null,
NombreDivicion nvarchar(50) not null,
)
go
--Tabla Sucursales
create table Sucursales(
IdSucursal int identity(1,1) primary key not null,
CodSucursal as ('Scl'+right('00'+convert(varchar,IdSucursal),(2))),
CodigoSucursal int unique not null,
NombreSucursal nvarchar(100) not null,
IdDiviciones int not null,
constraint FK_Diviciones_SUCURALES 
foreign key (IdDiviciones) 
references Diviciones (IdDivicion) on delete cascade
)
go
--Tabla RegistroActividades
create table RegistroActividades(
IdRegistro int identity(1,1) primary key not null,
CodRegistro as ('Rgt'+right('00'+convert(varchar,IdRegistro),(2))),
IdEmpleados int not null,
IdActividades int not null,
IdSucursales int not null,
FechaRegistro datetime not null,
constraint FK_Empleado_REGISTROACTIVIDAD
foreign key (IdEmpleados) 
references Empleados (IdEmpleado) on delete cascade,
constraint FK_Actividad_REGISTROACTIVIDAD 
foreign key (IdActividades) 
references Actividades (IdActividad) on delete cascade,
constraint FK_Sucursal_REGISTROACTIVIDAD
foreign key (IdSucursales) 
references Sucursales (IdSucursal) on delete cascade
)
go

