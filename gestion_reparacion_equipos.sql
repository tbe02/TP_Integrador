USE [master]
GO
/****** Object:  Database [gestion_reparacion_equipos]    Script Date: 30/9/2024 23:42:07 ******/
CREATE DATABASE [gestion_reparacion_equipos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestion_reparacion_equipos', FILENAME = N'E:\SQLServerExpress2022\MSSQL16.SQLEXPRESS\MSSQL\DATA\gestion_reparacion_equipos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gestion_reparacion_equipos_log', FILENAME = N'E:\SQLServerExpress2022\MSSQL16.SQLEXPRESS\MSSQL\DATA\gestion_reparacion_equipos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [gestion_reparacion_equipos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gestion_reparacion_equipos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ARITHABORT OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET  MULTI_USER 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gestion_reparacion_equipos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gestion_reparacion_equipos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [gestion_reparacion_equipos] SET QUERY_STORE = ON
GO
ALTER DATABASE [gestion_reparacion_equipos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [gestion_reparacion_equipos]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 30/9/2024 23:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[DNI] [varchar](8) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[telefono] [varchar](12) NOT NULL,
	[correo] [varchar](256) NOT NULL,
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([DNI], [nombres], [apellidos], [telefono], [correo], [idCliente], [estado]) VALUES (N'44293877', N'Francisco', N'De Los Santos', N'3795012916', N'frandelosantoss12@gmail.com', 1, N'inactivo')
INSERT [dbo].[Clientes] ([DNI], [nombres], [apellidos], [telefono], [correo], [idCliente], [estado]) VALUES (N'44000000', N'Theo', N'Echeverria', N'3794000000', N'theoecheverria@gmail.com', 2, N'inactivo')
INSERT [dbo].[Clientes] ([DNI], [nombres], [apellidos], [telefono], [correo], [idCliente], [estado]) VALUES (N'44111111', N'Hiras', N'Boneta', N'3794111111', N'hirasboneta@gmail.com', 3, N'inactivo')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NuevosCl__2A586E0B3726D8C6]    Script Date: 30/9/2024 23:42:07 ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NuevosCl__C035B8DD29F5E084]    Script Date: 30/9/2024 23:42:07 ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ('activo') FOR [estado]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD CHECK  (([estado]='inactivo' OR [estado]='activo'))
GO
USE [master]
GO
ALTER DATABASE [gestion_reparacion_equipos] SET  READ_WRITE 
GO
