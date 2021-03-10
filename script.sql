USE [Db_TiAgape]
GO
/****** Object:  Table [dbo].[Tbl_Empleados]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Empleados](
	[IDEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Actividades]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Actividades](
	[IDActividad] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionActividad] [nvarchar](max) NOT NULL,
	[NivelActividad] [nvarchar](10) NOT NULL,
	[ValorActividad] [decimal](18, 0) NOT NULL,
	[NotaActividad] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Marcas]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Marcas](
	[IDMarca] [int] IDENTITY(1,1) NOT NULL,
	[AliasMarca] [nvarchar](10) NOT NULL,
	[NombreMarca] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sucursales]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sucursales](
	[IDSucursal] [int] IDENTITY(1,1) NOT NULL,
	[NombreSucursal] [nvarchar](100) NOT NULL,
	[IdMarcas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_RegistroAct]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_RegistroAct](
	[IdRegistro] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleadosFK] [int] NOT NULL,
	[IdActividadesFK] [int] NOT NULL,
	[IdSucursalesFK] [int] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Fecha] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Registros]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_Registros]
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
/****** Object:  View [dbo].[VW_SucursalesAdm]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [dbo].[VW_SucursalesAdm]
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
/****** Object:  View [dbo].[VW_SucursalesMarca]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SucursalesMarca]
AS
SELECT M.IDMarca,
       M.AliasMarca
  FROM [dbo].[Tbl_Marcas] AS M
GO
/****** Object:  View [dbo].[VW_RegistrosIdScl]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_RegistrosIdScl]
AS
SELECT S.IDSucursal,
       S.NombreSucursal,
	   M.AliasMarca
  FROM  [dbo].[Tbl_Sucursales] AS S
   INNER JOIN [dbo].[Tbl_Marcas] AS M
  ON S.IdMarcas = M.IDMarca

GO
/****** Object:  View [dbo].[VW_RegistrosIdActividad]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_RegistrosIdActividad]
AS
SELECT A.IDActividad,
A.DescripcionActividad
  FROM  [dbo].[Tbl_Actividades] AS A
GO
/****** Object:  View [dbo].[VW_AdmRegistros]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_AdmRegistros]
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
/****** Object:  View [dbo].[vwSucursales]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create    view [dbo].[vwSucursales]
as
select *
from Tbl_Sucursales s
inner join Tbl_Marcas m
on s.IdMarcas = m.IDMarca
GO
/****** Object:  View [dbo].[vwRegistros]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   view [dbo].[vwRegistros]
as
select *
from Tbl_RegistroAct r
inner join Tbl_Empleados e
on r.CodigoEmpleadosFK = e.CodigoEmpleado
inner join Tbl_Actividades a
on r.IdActividadesFK = a.IdActividad
inner join Tbl_Sucursales s
on r.IdSucursalesFK = s.IDSucursal
GO
/****** Object:  View [dbo].[VW_Empleados]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   VIEW  [dbo].[VW_Empleados]
AS
SELECT *
FROM [dbo].[Tbl_Empleados]
GO
/****** Object:  Table [dbo].[Tbl_Roles]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Roles](
	[IDRol] [int] IDENTITY(1,1) NOT NULL,
	[RolUsuario] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Usuarios]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Usuarios](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[_User] [nvarchar](50) NOT NULL,
	[_Pass] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[IdRolesFK] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Usuarios]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   view [dbo].[VW_Usuarios]
as
select us._User 'Usuario',
       ro.RolUsuario 'Rol Usuario',
	   us.FechaCreacion 'FechaCreacion'
from Tbl_Usuarios us
inner join Tbl_Roles ro
on us.IdRolesFK = ro.IDRol
GO
/****** Object:  View [dbo].[vwActividades]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwActividades]
as
select *
from Tbl_Actividades 
GO
/****** Object:  View [dbo].[VW_Sucursales]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [dbo].[VW_Sucursales] 
AS
SELECT S.IDSucursal ,
       S.NombreSucursal,
	   M.AliasMarca
  FROM [dbo].[Tbl_Sucursales] AS S,
       [dbo].[Tbl_Marcas] AS M
  WHERE S.IdMarcas = M.IDMarca
GO
/****** Object:  View [dbo].[VW_Actividades]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [dbo].[VW_Actividades]
AS
SELECT*
FROM [dbo].[Tbl_Actividades] 
GO
/****** Object:  View [dbo].[VW_Marcas]    Script Date: 10/3/2021 6:08:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_Marcas]
AS
SELECT [AliasMarca]
      ,[NombreMarca]
  FROM [dbo].[Tbl_Marcas]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Actividades] ON 

INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (1, N'Incidencias de Oficina', N'Nivel 1', CAST(1 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (2, N'Comprobantes Agotados', N'Nivel 1', CAST(1 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (3, N'Proyectos C+', N'Nivel 1', CAST(1 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (4, N'Ventas Aloha (Grandiar)', N'Nivel 1', CAST(1 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (5, N'Call Center', N'Nivel 1', CAST(1 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (6, N'Hora de llegada', N'Nivel 1', CAST(1 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (7, N'Ordenes externas (Viajes)', N'Nivel 2', CAST(2 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (8, N'Teclas KK', N'Nivel 2', CAST(2 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (9, N'Documentaciones C+', N'Nivel 2', CAST(2 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (10, N'Teclas PJ', N'Nivel 3', CAST(3 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (11, N'Documentaciones B+', N'Nivel 3', CAST(3 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (12, N'Proyectos B+', N'Nivel 3', CAST(3 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (13, N'Post Aloha', N'Nivel 3', CAST(3 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (14, N'Post Micros ', N'Nivel 3', CAST(3 AS Decimal(18, 0)), NULL)
INSERT [dbo].[Tbl_Actividades] ([IDActividad], [DescripcionActividad], [NivelActividad], [ValorActividad], [NotaActividad]) VALUES (15, N'Proyectos A+', N'Nivel 4', CAST(4 AS Decimal(18, 0)), NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Actividades] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Empleados] ON 

INSERT [dbo].[Tbl_Empleados] ([IDEmpleado], [CodigoEmpleado], [Nombre], [Apellido], [Email], [Telefono]) VALUES (4, 12061, N'Juan', N'Cabrera', N'Juan.cabrera@agape.do', N'(829)521-0305')
INSERT [dbo].[Tbl_Empleados] ([IDEmpleado], [CodigoEmpleado], [Nombre], [Apellido], [Email], [Telefono]) VALUES (3, 15089, N'Eloy', N'Del Orbe', N'Eloy.DelOrbe@agape.do', N'(829)345-1430')
INSERT [dbo].[Tbl_Empleados] ([IDEmpleado], [CodigoEmpleado], [Nombre], [Apellido], [Email], [Telefono]) VALUES (2, 15092, N'Kleiver', N'Bravo', N'Kleiver.bravo@agape.do', N'(829)521-0305')
INSERT [dbo].[Tbl_Empleados] ([IDEmpleado], [CodigoEmpleado], [Nombre], [Apellido], [Email], [Telefono]) VALUES (1, 15114, N'Daniel', N'Lopez', N'Daniel.osvaldo@agape.do ', N'(829)521-0306')
SET IDENTITY_INSERT [dbo].[Tbl_Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Marcas] ON 

INSERT [dbo].[Tbl_Marcas] ([IDMarca], [AliasMarca], [NombreMarca]) VALUES (1, N'PJ', N'Papa Johns')
INSERT [dbo].[Tbl_Marcas] ([IDMarca], [AliasMarca], [NombreMarca]) VALUES (2, N'KK', N'Krispy Kreme')
INSERT [dbo].[Tbl_Marcas] ([IDMarca], [AliasMarca], [NombreMarca]) VALUES (3, N'PCD', N'Palacio del Cine')
INSERT [dbo].[Tbl_Marcas] ([IDMarca], [AliasMarca], [NombreMarca]) VALUES (4, N'CC', N'Call Center')
INSERT [dbo].[Tbl_Marcas] ([IDMarca], [AliasMarca], [NombreMarca]) VALUES (5, N'OTF', N'Orange Theory Fitness')
INSERT [dbo].[Tbl_Marcas] ([IDMarca], [AliasMarca], [NombreMarca]) VALUES (6, N'EC', N'Edificios Corporativos')
SET IDENTITY_INSERT [dbo].[Tbl_Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_RegistroAct] ON 

INSERT [dbo].[Tbl_RegistroAct] ([IdRegistro], [CodigoEmpleadosFK], [IdActividadesFK], [IdSucursalesFK], [Hora], [Fecha]) VALUES (1, 15114, 1, 1, CAST(N'10:30:00' AS Time), CAST(N'2021-02-12' AS Date))
SET IDENTITY_INSERT [dbo].[Tbl_RegistroAct] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Roles] ON 

INSERT [dbo].[Tbl_Roles] ([IDRol], [RolUsuario]) VALUES (1, N'Administrador')
INSERT [dbo].[Tbl_Roles] ([IDRol], [RolUsuario]) VALUES (2, N'General')
SET IDENTITY_INSERT [dbo].[Tbl_Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Sucursales] ON 

INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (1, N'Lincoln', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (2, N'Jumbo Luperon', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (3, N'Arroyo Hondo', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (4, N'Terra Mall', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (5, N'Sambil', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (6, N'Nuñez de Caceres', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (7, N'Romulo', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (8, N'Venezuela', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (9, N'Rep. Colombia', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (10, N'Independencia', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (11, N'Higüey', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (12, N'Maximo Gomez', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (13, N'Palma Real', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (14, N'Occideltal Mall', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (15, N'La Romana', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (16, N'La Vega', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (17, N'Carretera Mella', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (18, N'San Isidro', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (19, N'Portal Del Norte', 1)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (20, N'Churchill', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (21, N'Sambil', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (22, N'Nuñez de Caceres', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (23, N'Aila', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (24, N'Maximo Gomez', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (25, N'Tiradentes', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (26, N'Agora', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (27, N'Occidental Mall', 2)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (28, N'Bella Vista', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (29, N'Venezuela', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (30, N'San Francisco', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (31, N'Santiago', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (32, N'Sambil', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (33, N'Agora', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (34, N'Blue Mall', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (35, N'MultiPlaza H', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (36, N'Occidental Mall', 3)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (37, N'Call Center', 4)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (38, N'Novocentro', 5)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (39, N'Bella Vista', 5)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (40, N'Mezzaluna', 5)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (41, N'Santiago', 5)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (42, N'Arroy Hondo', 5)
INSERT [dbo].[Tbl_Sucursales] ([IDSucursal], [NombreSucursal], [IdMarcas]) VALUES (43, N'Edificios Corporativos', 6)
SET IDENTITY_INSERT [dbo].[Tbl_Sucursales] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Usuarios] ON 

INSERT [dbo].[Tbl_Usuarios] ([IDUsuario], [_User], [_Pass], [FechaCreacion], [IdRolesFK]) VALUES (3, N'Admin', N'Admin123', CAST(N'2021-02-06T18:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tbl_Usuarios] ([IDUsuario], [_User], [_Pass], [FechaCreacion], [IdRolesFK]) VALUES (4, N'DLopez', N'Yocomo0623**', CAST(N'2021-02-06T18:00:00.000' AS DateTime), 2)
INSERT [dbo].[Tbl_Usuarios] ([IDUsuario], [_User], [_Pass], [FechaCreacion], [IdRolesFK]) VALUES (5, N'KBravo', N'Yocomo123**', CAST(N'2021-02-06T18:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tbl_Usuarios] ([IDUsuario], [_User], [_Pass], [FechaCreacion], [IdRolesFK]) VALUES (6, N'JCabrera', N'Yocomo1234**', CAST(N'2021-02-06T18:00:00.000' AS DateTime), 2)
INSERT [dbo].[Tbl_Usuarios] ([IDUsuario], [_User], [_Pass], [FechaCreacion], [IdRolesFK]) VALUES (7, N'EDelOrbe', N'Yocomo12345**', CAST(N'2021-02-06T18:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Tbl_Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Tbl_Empl__A9D10534D1BF3465]    Script Date: 10/3/2021 6:08:07 p. m. ******/
ALTER TABLE [dbo].[Tbl_Empleados] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_RegistroAct]  WITH CHECK ADD  CONSTRAINT [FK_Actividad_REGISTROACT] FOREIGN KEY([IdActividadesFK])
REFERENCES [dbo].[Tbl_Actividades] ([IDActividad])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_RegistroAct] CHECK CONSTRAINT [FK_Actividad_REGISTROACT]
GO
ALTER TABLE [dbo].[Tbl_RegistroAct]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_REGISTROACT] FOREIGN KEY([CodigoEmpleadosFK])
REFERENCES [dbo].[Tbl_Empleados] ([CodigoEmpleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_RegistroAct] CHECK CONSTRAINT [FK_Empleado_REGISTROACT]
GO
ALTER TABLE [dbo].[Tbl_RegistroAct]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_REGISTROACT] FOREIGN KEY([IdSucursalesFK])
REFERENCES [dbo].[Tbl_Sucursales] ([IDSucursal])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_RegistroAct] CHECK CONSTRAINT [FK_Sucursal_REGISTROACT]
GO
ALTER TABLE [dbo].[Tbl_Sucursales]  WITH CHECK ADD  CONSTRAINT [FK_Marcas_SUCURALES] FOREIGN KEY([IdMarcas])
REFERENCES [dbo].[Tbl_Marcas] ([IDMarca])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Sucursales] CHECK CONSTRAINT [FK_Marcas_SUCURALES]
GO
ALTER TABLE [dbo].[Tbl_Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Roles_USUARIOS] FOREIGN KEY([IdRolesFK])
REFERENCES [dbo].[Tbl_Roles] ([IDRol])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Usuarios] CHECK CONSTRAINT [FK_Roles_USUARIOS]
GO
