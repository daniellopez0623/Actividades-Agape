create database Db_TiAgape
go

use Db_TiAgape
go
------------------------------------tablas--------------------------------------------------------------
create table Tbl_Empleados(
IDEmpleado int identity(1,1) not null,
CodigoEmpleado int primary key not null,
Nombre nvarchar(50) not null,
Apellido nvarchar(50) not null,
Email nvarchar(50) unique not null,
Telefono nvarchar(15) not null
)
go

create table Tbl_Roles(
IDRol int identity(1,1) primary key not null,
RolUsuario nvarchar(15) not null
)
go

create table Tbl_Usuarios(
IDUsuario int identity(1,1) primary key not null,
_User nvarchar(50) not null,
_Pass nvarchar(50) not null,
FechaCreacion datetime not null,
IdRolesFK int
constraint FK_Roles_USUARIOS 
foreign key (IdRolesFK) 
references Tbl_Roles (IDRol) on delete cascade
)
go

create table Tbl_Actividades(
IDActividad int identity(1,1) primary key not null,
--CodActividad as ('Act'+right('00'+convert(varchar,IdActividad),(2))),
DescripcionActividad nvarchar(max) not null,
NivelActividad nvarchar(10) not null,
ValorActividad decimal not null,
NotaActividad nvarchar(max) null,
)
go

create table Tbl_Marcas(
IDMarca int identity(1,1) primary key not null,
AliasMarca nvarchar(10) not null,
NombreMarca nvarchar(50) not null,
)
go

create table Tbl_Sucursales(
IDSucursal int identity(1,1)primary key  not null,
NombreSucursal nvarchar(100) not null,
IdMarcasFK int not null,
constraint FK_Marcas_SUCURALES 
foreign key (IdMarcasFK) 
references Tbl_Marcas (IDMarca) on delete cascade
)
go

create table Tbl_RegistroAct(
IdRegistro int identity(1,1) primary key not null,
CodigoEmpleadosFK int not null,
IdActividadesFK int not null,
IdSucursalesFK int not null,
Hora time not null,
Fecha date not null,
constraint FK_Empleado_REGISTROACT
foreign key (CodigoEmpleadosFK) 
references Tbl_Empleados (CodigoEmpleado) on delete cascade,
constraint FK_Actividad_REGISTROACT
foreign key (IDActividadesFK) 
references Tbl_Actividades (IDActividad) on delete cascade,
constraint FK_Sucursal_REGISTROACT
foreign key (IdSucursalesFK) 
references Tbl_Sucursales (IDSucursal) on delete cascade
)
go
-----------------------------------------vistas-------------------------------------------------------
create or alter view VW_Empleados
as
select em.CodigoEmpleado 'CodigoEmpleado',
       em.Nombre,
	   em.Apellido,
	   em.Email,
	   em.Telefono
from Tbl_Empleados em
go

create or alter view VW_Usuarios
as
select us._User 'Usuario',
       ro.RolUsuario 'Rol Usuario',
	   us.FechaCreacion 'FechaCreacion'
from Tbl_Usuarios us
inner join Tbl_Roles ro
on us.IdRolesFK = ro.IDRol
go

create view vwActividades
as
select *
from Tbl_Actividades 
go

create or alter  view vwSucursales
as
select *
from Tbl_Sucursales s
inner join Tbl_Marcas m
on s.IdMarcas = m.IDMarca
go

create or alter view vwRegistros
as
select *
from Tbl_RegistroAct r
inner join Tbl_Empleados e
on r.CodigoEmpleadosFK = e.CodigoEmpleado
inner join Tbl_Actividades a
on r.IdActividadesFK = a.IdActividad
inner join Tbl_Sucursales s
on r.IdSucursalesFK = s.IDSucursal
go



select * from Tbl_Usuarios

----------------------------------------------SP----------------------------------------------------
create or alter proc SP_Login
@user varchar(50),
@pass varchar(50)
as
select *
from Tbl_Usuarios 
where _User = @user and
      _Pass = @pass 
go

exec SP_Login 'Admin','yocomo123@'