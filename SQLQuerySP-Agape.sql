use DB_ActividadesAgape
go

--SP_Guardar_Empleados
create or alter procedure SP_Guardar_Empleados
@CodigoEmpleado int,
@Nombre varchar(50),
@Apellido varchar(50),
@Email varchar(50),
@FechaNacimiento date
as
insert into Empleados ( CodigoEmpleado, Nombre, Apellido, Email, FechaNacimiento)
               values (@CodigoEmpleado,@Nombre,@Apellido,@Email,@FechaNacimiento)
go
--SP_Editar_Empleados
create or alter procedure SP_Editar_Empleados
@IdEmpleado int,
@CodigoEmpleado int,
@Nombre varchar(50),
@Apellido varchar(50),
@Email varchar(50),
@FechaNacimiento date
as
update Empleados set CodigoEmpleado = @CodigoEmpleado,
                     Nombre = @Nombre,  
					 Apellido = @Apellido,  
					 Email = @Email,
					 FechaNacimiento = @FechaNacimiento
				   where IdEmpleado = @IdEmpleado
go
--SP_Buscar_Empleados
create or alter procedure SP_Buscar_Empleados
@CodigoEmpleado int
as
select * 
from Empleados
where CodigoEmpleado like 
     @CodigoEmpleado + '%' 		  
go
--SP_Borrar_Empleados
create or alter procedure SP_Borrar_Empleados
@CodigoEmpleado int
as
delete 
from Empleados
where CodigoEmpleado = @CodigoEmpleado
go
---------------------------------------------------------------------------------------------
--SP_Guardar_Usuarios
create or alter procedure SP_Guardar_Usuarios
@IdEmpleados int,
@IdRoles int,
@_Password varchar(50),
@FechaCreacion datetime
as
insert into Usuarios ( IdEmpleados, IdRoles, _Password, FechaCreacion)
              values (@IdEmpleados,@IdRoles,@_Password,@FechaCreacion)
go
--SP_Editar_Usuarios
create or alter procedure SP_Editar_Usuarios
@IdUsuario int,
@IdEmpleados int,
@IdRoles int,
@_Password varchar(50),
@FechaCreacion datetime
as
update Usuarios set  IdEmpleados = @IdEmpleados,
                     IdRoles = @IdRoles,  
					 _Password = @_Password,  
					 FechaCreacion = @FechaCreacion
			  where  IdUsuario = @IdUsuario
go
--SP_Buscar_Usuarios
create or alter procedure SP_Buscar_Usuarios
@CodigoEmpleado int
as
select * 
from Usuarios
where IdEmpleados like 
     @CodigoEmpleado + '%' 		  
go
--SP_Borrar_Usuarios
create or alter procedure SP_Borrar_Usuarios
@IdUsuario int
as
delete 
from Usuarios
where IdUsuario = @IdUsuario
go
----------------------------------------------------------------------------------------------
--SP_Guardar_Actividades
create or alter procedure SP_Guardar_Actividades
@DescripcionActividad nvarchar(max),
@ValorActividad decimal,
@NivelActividad nvarchar(10),
@NotaActividad nvarchar(max)
as
insert into Actividades ( DescripcionActividad, ValorActividad, NivelActividad, NotaActividad)
                 values (@DescripcionActividad,@ValorActividad,@NivelActividad,@NotaActividad)
go
--SP_Editar_Actividades
create or alter procedure SP_Editar_Actividades
@IdActividad int,
@DescripcionActividad nvarchar(max),
@ValorActividad decimal,
@NivelActividad nvarchar(10),
@NotaActividad nvarchar(max)
as
update Actividades set DescripcionActividad = @DescripcionActividad,
                       ValorActividad = @ValorActividad,  
					   NivelActividad = @NivelActividad,  
					   NotaActividad = @NotaActividad
			     where IdActividad = @IdActividad
go
--SP_Buscar_Actividades
create or alter procedure SP_Buscar_Actividades
@IdActividad int
as
select * 
from Actividades
where IdActividad like 
     @IdActividad + '%' 		  
go
--SP_Borrar_Actividades
create or alter procedure SP_Borrar_Actividades
@IdActividad int
as
delete 
from Actividades
where IdActividad = @IdActividad
go
----------------------------------------------------------------------------------------------
--SP_Guardar_Sucursales
create or alter procedure SP_Guardar_Sucursales
@IdDiviciones int,
@CodigoSucursal int,
@NombreSucursal nvarchar(100)
as
insert into Sucursales ( IdDiviciones, CodigoSucursal, NombreSucursal)
                 values (@IdDiviciones,@CodigoSucursal,@NombreSucursal)
go
--SP_Editar_Sucursales
create or alter procedure SP_Editar_Sucursales
@IdSucursal int,
@IdDiviciones int,
@CodigoSucursal int,
@NombreSucursal nvarchar(100)
as
update Sucursales set IdDiviciones = @IdDiviciones,
                      CodigoSucursal = @CodigoSucursal,  
					  NombreSucursal = @NombreSucursal  
			    where IdSucursal = @IdSucursal
go
--SP_Buscar_Sucursales
create or alter procedure SP_Buscar_Sucursales
@CodigoSucursal int
as
select * 
from Sucursales
where CodigoSucursal like 
     @CodigoSucursal + '%' 		  
go
--SP_Borrar_Sucursales
create or alter procedure SP_Borrar_Sucursales
@IdSucursal int,
@CodigoSucursal int
as
delete 
from Sucursales
where IdSucursal = @IdSucursal or
      CodigoSucursal = @CodigoSucursal
go
----------------------------------------------------------------------------------------------
--SP_Guardar_Registro
create or alter procedure SP_Guardar_Registro
@IdEmpleados int,
@IdActividades int,
@IdSucursales int,
@FechaRegistro datetime
as
insert into RegistroActividades ( IdEmpleados, IdActividades, IdSucursales)
                         values (@IdEmpleados,@IdActividades,@IdSucursales)
go
--SP_Editar_Registro
create or alter procedure SP_Editar_Registro
@IdRegistro int,
@IdEmpleados int,
@IdActividades int,
@IdSucursales int,
@FechaRegistro datetime
as
update RegistroActividades set IdEmpleados = @IdEmpleados,
							   IdActividades = @IdActividades,  
							   IdSucursales = @IdSucursales,
							   FechaRegistro = @FechaRegistro  
						 where IdRegistro = @IdRegistro
go
--SP_Buscar_Registro
create or alter procedure SP_Buscar_Registro
@IdRegistro int
as
select * 
from RegistroActividades
where IdRegistro like 
     @IdRegistro + '%' 		  
go
--SP_Borrar_Registro
create or alter procedure SP_Borrar_Registro
@IdRegistro int,
@IdEmpleados int
as
delete 
from RegistroActividades
where IdRegistro = @IdRegistro and
      IdEmpleados = @IdEmpleados
go