create database DB_TI_Agape
go

use DB_TI_Agape
go
------------------------------------tablas--------------------------------------------------------------
create table TblEmpleados(
IdEmpleado int identity(1,1) not null,
CodEmpleado as ('Emp'+right('00'+convert(varchar,IdEmpleado),(2))),
CodigoEmpleado int primary key not null,
Nombre nvarchar(50) not null,
Apellido nvarchar(50) not null,
Email nvarchar(50) unique not null,
FechaNacimiento date not null,
Telefono nvarchar(15) not null
)
go

create table TblUsuarios(
IdUsuario int identity(1,1) primary key not null,
CodUsuario as ('Usr'+right('00'+convert(varchar,IdUsuario),(2))),
NombreUsuario nvarchar(50) not null,
Contraceña nvarchar(50) not null,
RolUsuario nvarchar(15) not null,
FechaCreacion datetime not null
)
go

create table TblActividades(
IdActividad int identity(1,1) primary key not null,
CodActividad as ('Act'+right('00'+convert(varchar,IdActividad),(2))),
DescripcionActividad nvarchar(max) not null,
NivelActividad nvarchar(10) not null,
ValorActividad decimal not null,
NotaActividad nvarchar(max) null,
)
go

create table TblDiviciones(
IdDivicion int identity(1,1) primary key not null,
CodDivicion as ('Dvc'+right('00'+convert(varchar,IdDivicion),(2))),
AliasDivicion nvarchar(10) not null,
NombreDivicion nvarchar(50) not null,
)
go

create table TblSucursales(
IdSucursal int identity(1,1) not null,
CodSucursal as ('Scl'+right('00'+convert(varchar,IdSucursal),(2))),
CodigoSucursal int primary key not null,
NombreSucursal nvarchar(100) not null,
IdDiviciones int not null,
constraint FK_Diviciones_SUCURALES 
foreign key (IdDiviciones) 
references TblDiviciones (IdDivicion) on delete cascade
)
go

create table TblRegistroActividades(
IdRegistro int identity(1,1) primary key not null,
CodRegistro as ('Rgt'+right('00'+convert(varchar,IdRegistro),(2))),
CodigoEmpleados int not null,
IdActividades int not null,
CodigoSucursal int not null,
FechaRegistro datetime not null,
constraint FK_Empleado_REGISTROACTIVIDAD
foreign key (CodigoEmpleados) 
references TblEmpleados (CodigoEmpleado) on delete cascade,
constraint FK_Actividad_REGISTROACTIVIDAD 
foreign key (IdActividades) 
references TblActividades (IdActividad) on delete cascade,
constraint FK_Sucursal_REGISTROACTIVIDAD
foreign key (CodigoSucursal) 
references TblSucursales (CodigoSucursal) on delete cascade
)
go
-----------------------------------------vistas-------------------------------------------------------
create or alter view vwEmpleados
as
select e.CodEmpleado 'ID Empleados',
       e.CodigoEmpleado 'Codigo Empleado',
	   e.Nombre,
	   e.Apellido,
	   e.Telefono,
	   e.Email,
	   e.FechaNacimiento 'Fecha Nacimiento'
from TblEmpleados e
go

create view vwUsuarios
as
select u.CodUsuario 'ID Usuarios',
       u.NombreUsuario 'Nombre Usuario',
	   u.RolUsuario 'Rol Usuario',
	   u.FechaCreacion 'Fecha Creacion'
from TblUsuarios u
go

create view vwActividades
as
select a.CodActividad 'ID Actividades ',
       a.NivelActividad 'Nivel Actividad',
	   a.ValorActividad 'Valor Actividad',
	   a.DescripcionActividad 'Descripcion Actividad',
	   a.NotaActividad 'Nota Actividad'
from TblActividades a
go

create view vwSucursales
as
select s.CodSucursal 'ID Sucursales',
       s.CodigoSucursal 'Codigo Sucursal',
	   s.NombreSucursal 'Nombre Sucursal',
	   d.CodDivicion 'ID Diviciones',
	   d.AliasDivicion 'Alias Divicion'
from TblSucursales s
inner join TblDiviciones d
on s.IdDiviciones = d.IdDivicion
go

select r.CodRegistro,
       r.FechaRegistro,
	   e.CodigoEmpleado,
	   e.Nombre,
	   a.CodActividad,
	   a.ValorActividad,
	   a.DescripcionActividad,
	   s.CodigoSucursal,
	   s.CodigoSucursal,
	   s.NombreSucursal,
	   a.NotaActividad
from TblRegistroActividades r
inner join TblEmpleados e
on r.CodigoEmpleados = e.CodigoEmpleado
inner join TblActividades a
on r.IdActividades = a.IdActividad
inner join TblSucursales s
on r.CodigoSucursal = s.CodigoSucursal
go



select * from TblSucursales