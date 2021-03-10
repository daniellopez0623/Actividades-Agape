USE [Db_TiAgape]
GO

CREATE PROC SP_updateEmpleados
@idEmpleados INT
,@CodigoEmpleado INT
,@Nombre NVARCHAR(50)
,@Apellido NVARCHAR(50)
,@Email NVARCHAR(50)
,@Telefono NVARCHAR(15)
AS
UPDATE [dbo].[Tbl_Empleados]
   SET [CodigoEmpleado] = @CodigoEmpleado
      ,[Nombre] = @Nombre
      ,[Apellido] = @Apellido
      ,[Email] = @Email
      ,[Telefono] = @Telefono
 WHERE IDEmpleado = @idEmpleados
GO

CREATE PROCEDURE SP_insertEmpleados
@CodigoEmpleado INT
,@Nombre NVARCHAR(50)
,@Apellido NVARCHAR(50)
,@Email NVARCHAR(50)
,@Telefono NVARCHAR(15)
AS
INSERT INTO [dbo].[Tbl_Empleados]
           ([CodigoEmpleado]
           ,[Nombre]
           ,[Apellido]
           ,[Email]
           ,[Telefono])
     VALUES
           (
		   @CodigoEmpleado
           ,@Nombre
           ,@Apellido
           ,@Email
           ,@Telefono
		   )
GO

CREATE OR ALTER PROC SP_deleteEmpleados
@idEmpleados INT
,@CodigoEmpleado INT
AS
DELETE 
FROM [dbo].[Tbl_Empleados]
WHERE IDEmpleado = @idEmpleados AND
	  CodigoEmpleado = @CodigoEmpleado
GO

CREATE OR ALTER PROC	
@CodigoEmpleado INT
AS
SELECT E.CodigoEmpleado,
       E.Nombre,
	   E.Apellido,
	   E.Telefono,
	   E.Email
FROM [dbo].[Tbl_Empleados] AS E
WHERE CodigoEmpleado  LIKE @CodigoEmpleado + '%'
GO

CREATE OR ALTER PROC SP_selectAdmEmpleados
@CodigoEmpleado INT
AS
SELECT *
FROM [dbo].[Tbl_Empleados]
WHERE CodigoEmpleado = @CodigoEmpleado
GO

CREATE OR ALTER VIEW  VW_Empleados
AS
SELECT [CodigoEmpleado] 'Codigo Empleado'
      ,[Nombre]
      ,[Apellido]     
      ,[Telefono]
	  ,[Email]
FROM [dbo].[Tbl_Empleados]
GO
--------------------SPs--Actividades---------------------------------
CREATE PROC SP_updateActividades
 @idActividades INT
,@DescripcionActividad NVARCHAR(max)
,@NivelActividad NVARCHAR(10)
,@ValorActividad DECIMAL(18,0)
,@NotaActividad NVARCHAR(max)
AS
UPDATE [dbo].[Tbl_Actividades]
   SET [DescripcionActividad] = @DescripcionActividad
      ,[NivelActividad] = @NivelActividad
      ,[ValorActividad] = @ValorActividad
      ,[NotaActividad] = @NotaActividad
 WHERE IDActividad = @idActividades
GO

CREATE PROCEDURE SP_insertActividades
@DescripcionActividad NVARCHAR(max)
,@NivelActividad NVARCHAR(10)
,@ValorActividad DECIMAL(18,0)
,@NotaActividad NVARCHAR(max)
AS
INSERT INTO [dbo].[Tbl_Actividades]
           ([DescripcionActividad]
           ,[NivelActividad]
           ,[ValorActividad]
           ,[NotaActividad])
     VALUES
           (@DescripcionActividad
           ,@NivelActividad
           ,@ValorActividad
           ,@NotaActividad)
GO

CREATE PROCEDURE SP_deleteActividades
@idActividades INT
AS
DELETE FROM [dbo].[Tbl_Actividades]
WHERE IDActividad = @idActividades
GO

CREATE OR ALTER PROCEDURE SP_selectAdmActividades
@DescripcionActividad NVARCHAR(max)
AS
SELECT *
FROM [dbo].[Tbl_Actividades]
WHERE DescripcionActividad LIKE @DescripcionActividad
GO

CREATE OR ALTER VIEW VW_Actividades
AS
SELECT A.IDActividad 'ID Actividad',
       A.NivelActividad,
	   A.ValorActividad,
	   A.DescripcionActividad
FROM [dbo].[Tbl_Actividades] AS A
GO
------------------SPs--Sucursal----------------------------------
CREATE PROC SP_updateSucursales
@idSucursal INT,
@NombreSucursal NVARCHAR(100),
@IdMarcas INT
AS
UPDATE [dbo].[Tbl_Sucursales]
   SET [NombreSucursal] = @NombreSucursal
      ,[IdMarcas] = @IdMarcas
 WHERE IDSucursal = @idSucursal
GO

CREATE PROCEDURE SP_insertSucursales
@NombreSucursal NVARCHAR(100),
@IdMarcas INT
AS
INSERT INTO [dbo].[Tbl_Sucursales]
           ([NombreSucursal]
           ,[IdMarcas])
     VALUES
           (@NombreSucursal
           ,@IdMarcas)
GO

CREATE PROC SP_deleteSucursal
@idSucursal INT,
@IdMarcas INT
AS
DELETE FROM [dbo].[Tbl_Sucursales]
      WHERE IDSucursal = @idSucursal AND
	        IdMarcas = @IdMarcas
GO

CREATE OR ALTER PROCEDURE SP_selectSucursales
@NombreSucursal NVARCHAR(100)
AS
SELECT S.IDSucursal ,
       S.NombreSucursal,
	   M.AliasMarca
  FROM [dbo].[Tbl_Sucursales] AS S
  INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca
 WHERE S.NombreSucursal LIKE  @NombreSucursal 
GO

CREATE OR ALTER PROC SP_selectAdminSucursal
@NombreSucursal NVARCHAR(100)
AS
SELECT S.IDSucursal,
       S.NombreSucursal,
	   S.IdMarcas,
	   M.AliasMarca,
	   M.NombreMarca
 FROM [dbo].[Tbl_Sucursales] AS S
  INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca
 WHERE S.NombreSucursal LIKE  @NombreSucursal 
GO

CREATE OR ALTER VIEW VW_Sucursales 
AS
SELECT S.IDSucursal ,
       S.NombreSucursal,
	   M.AliasMarca
  FROM [dbo].[Tbl_Sucursales] AS S,
       [dbo].[Tbl_Marcas] AS M
  WHERE S.IdMarcas = M.IDMarca
GO
CREATE OR ALTER VIEW VW_SucursalesAdm
AS
SELECT S.IDSucursal,
       S.NombreSucursal,
	   S.IdMarcas,
	   M.AliasMarca,
	   M.NombreMarca
  FROM [dbo].[Tbl_Sucursales] AS S,
       [dbo].[Tbl_Marcas] AS M
  WHERE S.IdMarcas = M.IDMarca
GO
CREATE VIEW VW_SucursalesMarca
AS
SELECT M.IDMarca,
       M.AliasMarca
  FROM [dbo].[Tbl_Marcas] AS M
GO

------------------------------SPs--Marcas--------------------
CREATE PROCEDURE SP_updateMarcas
@idMarcas INT,
@AliasMarca NVARCHAR(10),
@NombreMarca NVARCHAR(50)
AS
UPDATE [dbo].[Tbl_Marcas]
   SET [AliasMarca] = @AliasMarca
      ,[NombreMarca] = @NombreMarca
 WHERE IDMarca = @idMarcas
GO
 
CREATE PROCEDURE SP_insertMarcas
@AliasMarca NVARCHAR(10),
@NombreMarca NVARCHAR(50)
AS
INSERT INTO [dbo].[Tbl_Marcas]
           ([AliasMarca]
           ,[NombreMarca])
     VALUES
           (@AliasMarca
           ,@NombreMarca)
GO

CREATE PROCEDURE SP_deleteMarcas
@idMarcas INT,
@AliasMarca NVARCHAR(10)
AS
DELETE FROM [dbo].[Tbl_Marcas]
      WHERE IDMarca =  @idMarcas AND
	        AliasMarca = @AliasMarca
GO

CREATE OR ALTER PROCEDURE SP_selectMarcas
@AliasMarca NVARCHAR(10)
AS
SELECT *
  FROM [dbo].[Tbl_Marcas]
  WHERE AliasMarca LIKE @AliasMarca + '%'
GO

CREATE VIEW VW_Marcas
AS
SELECT [AliasMarca]
      ,[NombreMarca]
  FROM [dbo].[Tbl_Marcas]
GO

-----------------------SPs--Usuarios-------------------1
CREATE PROCEDURE SP_updateUsuarios
@idUsuarios INT,
@idRoles INT,
@user NVARCHAR(50),
@pass NVARCHAR(50),
@FechaCreacion DATETIME
AS
UPDATE [dbo].[Tbl_Usuarios] 
   SET [_User] = @user
      ,[_Pass] = @pass
      ,[FechaCreacion] = @FechaCreacion
 WHERE IDUsuario = @idUsuarios AND
       [IdRolesFK] = @idRoles
GO

CREATE  PROCEDURE SP_insertUsuario
@idRoles INT,
@user NVARCHAR(50),
@pass NVARCHAR(50),
@FechaCreacion DATETIME
AS
INSERT INTO [dbo].[Tbl_Usuarios]
           ([_User]
           ,[_Pass]
           ,[FechaCreacion]
           ,[IdRolesFK])
     VALUES
           (@user
           ,@pass
           ,@FechaCreacion
           ,@idRoles)
GO

CREATE OR ALTER PROCEDURE SP_deleteUsuarios
@idUsuarios INT,
@user NVARCHAR(50)
AS
DELETE FROM [dbo].[Tbl_Usuarios]
      WHERE IDUsuario = @idUsuarios AND
	        _User = @user
GO

CREATE OR ALTER PROCEDURE SP_selectUsuario
AS
SELECT *
  FROM [dbo].[Tbl_Usuarios] AS U
INNER JOIN [dbo].[Tbl_Roles] AS R
  ON U.IdRolesFK = R.IDRol
GO

SELECT *
  FROM  [dbo].[Tbl_Roles] 

CREATE OR ALTER PROC SP_selectAdmUsuarios
@user NVARCHAR(50)
AS
SELECT *
  FROM [dbo].[Tbl_Usuarios] AS U
  INNER JOIN [dbo].[Tbl_Roles] AS R
  ON U.IdRolesFK = R.IDRol
  WHERE U._User LIKE @user + '%'
GO
--SP_Login
CREATE OR ALTER PROCEDURE SP_LoginUser
@_user NVARCHAR(50),
@_pass NVARCHAR(50)
AS
SELECT U._User,
       U._Pass,
	   R.RolUsuario
  FROM [dbo].[Tbl_Usuarios] AS U
  INNER JOIN [dbo].[Tbl_Roles] AS R
  ON U.IdRolesFK = R.IDRol
  WHERE U._User = @_user AND
        U._Pass = @_pass
GO
exec SP_LoginUser 'dlopez','yocomo0623**'

--------------------SPs--Registos-----------------------------
CREATE OR ALTER PROCEDURE SP_updateRegistoAct
@idRegistro INT,
@CodigoEmpleadosFK INT,
@IdActividadesFK INT,
@IdSucursalesFK INT,
@Hora NVARCHAR(10),
@Fecha NVARCHAR(10)
AS
UPDATE [dbo].[Tbl_RegistroAct]
   SET [IdActividadesFK] = @IdActividadesFK
      ,[IdSucursalesFK] = @IdSucursalesFK
	  ,[Hora] = @Hora
	  ,[Fecha] = @Fecha
 WHERE IdRegistro = @idRegistro AND
 [CodigoEmpleadosFK] = @CodigoEmpleadosFK
GO

CREATE OR ALTER PROCEDURE SP_insertRegistroAct
@CodigoEmpleadosFK INT,
@IdActividadesFK INT,
@IdSucursalesFK INT,
@Hora NVARCHAR(10),
@Fecha NVARCHAR(10)
AS
INSERT INTO [dbo].[Tbl_RegistroAct]
           ([CodigoEmpleadosFK]
           ,[IdActividadesFK]
           ,[IdSucursalesFK]
           ,[Hora]
           ,[Fecha])
     VALUES
           (@CodigoEmpleadosFK
           ,@IdActividadesFK
           ,@IdSucursalesFK
           ,@Hora
           ,@Fecha)
GO

--EXEC SP_insertRegistroAct 15114, 1, 1,'10:30:00','2021-02-12'

CREATE PROCEDURE SP_deleteRegistroAct
@idRegistro INT,
@CodigoEmpleadosFK INT
AS
DELETE FROM [dbo].[Tbl_RegistroAct]
      WHERE IdRegistro = @idRegistro AND
	        CodigoEmpleadosFK =@CodigoEmpleadosFK
GO

CREATE OR ALTER PROCEDURE SP_selectAdminRegistroAct
@CodigoEmpleadosFK INT,
@IdActividadesFK INT,
@IdSucursalesFK INT
AS
SELECT *
  FROM [dbo].[Tbl_RegistroAct] AS R
  INNER JOIN [dbo].[Tbl_Empleados] AS E
  ON R.CodigoEmpleadosFK = E.CodigoEmpleado
  INNER JOIN [dbo].[Tbl_Actividades] AS A
  ON R.IdActividadesFK = A.IDActividad
  INNER JOIN [dbo].[Tbl_Sucursales] AS S
  ON R.IdSucursalesFK = S.IDSucursal
    INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca 
WHERE E.CodigoEmpleado = @CodigoEmpleadosFK AND
      A.IDActividad = @IdActividadesFK AND
	  S.IDSucursal = @IdSucursalesFK 
GO

CREATE OR ALTER PROCEDURE SP_selectRegistroAct
@CodigoEmpleadosFK INT,
@IdActividadesFK INT,
@IdSucursalesFK INT
AS
SELECT  R.IdRegistro,
	   R.Hora,
	   R.Fecha,
       A.IDActividad,
	   A.DescripcionActividad,    
       E.CodigoEmpleado,
	   E.Nombre,	  
	   A.ValorActividad,
	   S.IDSucursal,
	   S.NombreSucursal,
	   M.AliasMarca
  FROM  [dbo].[Tbl_RegistroAct] AS R 
  INNER JOIN [dbo].[Tbl_Empleados] AS E
  ON R.CodigoEmpleadosFK = E.CodigoEmpleado
  INNER JOIN [dbo].[Tbl_Actividades] AS A
  ON R.IdActividadesFK = A.IDActividad
  INNER JOIN [dbo].[Tbl_Sucursales] AS S
  ON R.IdSucursalesFK = S.IDSucursal
  INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca
WHERE E.CodigoEmpleado = @CodigoEmpleadosFK  AND
      A.IDActividad = @IdActividadesFK  AND
	  S.IDSucursal = @IdSucursalesFK  
GO
CREATE VIEW VW_Registros
AS
SELECT R.IdRegistro,
       E.CodigoEmpleado,
	   E.Nombre,
	   A.IDActividad,
	   A.DescripcionActividad,
	   A.ValorActividad,
	   S.IDSucursal,
	   S.NombreSucursal,
	   M.AliasMarca
  FROM  [dbo].[Tbl_RegistroAct] AS R 
  INNER JOIN [dbo].[Tbl_Empleados] AS E
  ON R.CodigoEmpleadosFK = E.CodigoEmpleado
  INNER JOIN [dbo].[Tbl_Actividades] AS A
  ON R.IdActividadesFK = A.IDActividad
  INNER JOIN [dbo].[Tbl_Sucursales] AS S
  ON R.IdSucursalesFK = S.IDSucursal
  INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca
GO
CREATE VIEW VW_AdmRegistros
AS
SELECT *
  FROM  [dbo].[Tbl_RegistroAct] AS R 
  INNER JOIN [dbo].[Tbl_Empleados] AS E
  ON R.CodigoEmpleadosFK = E.CodigoEmpleado
  INNER JOIN [dbo].[Tbl_Actividades] AS A
  ON R.IdActividadesFK = A.IDActividad
  INNER JOIN [dbo].[Tbl_Sucursales] AS S
  ON R.IdSucursalesFK = S.IDSucursal
  INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca
GO

SELECT * FROM VW_AdmRegistros

CREATE VIEW VW_RegistrosIdScl
AS
SELECT S.IDSucursal,
       S.NombreSucursal,
	   M.AliasMarca
  FROM  [dbo].[Tbl_Sucursales] AS S
   INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca
GO
CREATE VIEW VW_RegistrosIdActividad
AS
SELECT A.IDActividad,
A.DescripcionActividad
  FROM  [dbo].[Tbl_Actividades] AS A
GO

SELECT*
  FROM VW_RegistrosIdScl