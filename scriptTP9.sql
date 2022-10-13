USE [master]
GO
/****** Object:  Database [scriptTP9]    Script Date: 13/10/2022 12:06:26 ******/
CREATE DATABASE [scriptTP9]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'scriptTP9', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\scriptTP9.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'scriptTP9_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\scriptTP9_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [scriptTP9] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [scriptTP9].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [scriptTP9] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [scriptTP9] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [scriptTP9] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [scriptTP9] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [scriptTP9] SET ARITHABORT OFF 
GO
ALTER DATABASE [scriptTP9] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [scriptTP9] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [scriptTP9] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [scriptTP9] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [scriptTP9] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [scriptTP9] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [scriptTP9] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [scriptTP9] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [scriptTP9] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [scriptTP9] SET  DISABLE_BROKER 
GO
ALTER DATABASE [scriptTP9] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [scriptTP9] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [scriptTP9] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [scriptTP9] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [scriptTP9] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [scriptTP9] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [scriptTP9] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [scriptTP9] SET RECOVERY FULL 
GO
ALTER DATABASE [scriptTP9] SET  MULTI_USER 
GO
ALTER DATABASE [scriptTP9] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [scriptTP9] SET DB_CHAINING OFF 
GO
ALTER DATABASE [scriptTP9] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [scriptTP9] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [scriptTP9] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'scriptTP9', N'ON'
GO
ALTER DATABASE [scriptTP9] SET QUERY_STORE = OFF
GO
USE [scriptTP9]
GO
/****** Object:  User [alumno]    Script Date: 13/10/2022 12:06:26 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Foto]    Script Date: 13/10/2022 12:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foto](
	[IdFoto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Foto] PRIMARY KEY CLUSTERED 
(
	[IdFoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 13/10/2022 12:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[IdHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[piso] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[fkNivel] [int] NOT NULL,
	[fkHotel] [int] NOT NULL,
 CONSTRAINT [PK_Habitacion] PRIMARY KEY CLUSTERED 
(
	[IdHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 13/10/2022 12:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[IdHotel] [int] IDENTITY(1,1) NOT NULL,
	[pais] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[IdHotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nivel]    Script Date: 13/10/2022 12:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nivel](
	[IdNivel] [int] IDENTITY(1,1) NOT NULL,
	[nivel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Nivel] PRIMARY KEY CLUSTERED 
(
	[IdNivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoDisponibilidad]    Script Date: 13/10/2022 12:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoDisponibilidad](
	[IdNoDisponible] [int] IDENTITY(1,1) NOT NULL,
	[fechaDia] [date] NOT NULL,
	[fkHabitacion] [int] NOT NULL,
 CONSTRAINT [PK_NoDisponibilidad] PRIMARY KEY CLUSTERED 
(
	[IdNoDisponible] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 13/10/2022 12:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[IdReserva] [int] NOT NULL,
	[fechaIN] [date] NOT NULL,
	[fechaOUT] [date] NOT NULL,
	[fkHotel] [int] NOT NULL,
	[fkHabitacion] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[comprobante] [varchar](50) NOT NULL,
	[estadoComprobante] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Foto] ON 

INSERT [dbo].[Foto] ([IdFoto], [nombre]) VALUES (1, N'bañoNivel1')
INSERT [dbo].[Foto] ([IdFoto], [nombre]) VALUES (2, N'bañoNivel2')
INSERT [dbo].[Foto] ([IdFoto], [nombre]) VALUES (6, N'bañoNivel3')
INSERT [dbo].[Foto] ([IdFoto], [nombre]) VALUES (10, N'CamaNivel2')
INSERT [dbo].[Foto] ([IdFoto], [nombre]) VALUES (11, N'CamaNivel1')
INSERT [dbo].[Foto] ([IdFoto], [nombre]) VALUES (12, N'CamaNivel3')
SET IDENTITY_INSERT [dbo].[Foto] OFF
GO
SET IDENTITY_INSERT [dbo].[Habitacion] ON 

INSERT [dbo].[Habitacion] ([IdHabitacion], [piso], [precio], [nombre], [fkNivel], [fkHotel]) VALUES (1, 2, 35000, N'CR208', 3, 1)
INSERT [dbo].[Habitacion] ([IdHabitacion], [piso], [precio], [nombre], [fkNivel], [fkHotel]) VALUES (2, 1, 10850, N'PAN124', 1, 3)
INSERT [dbo].[Habitacion] ([IdHabitacion], [piso], [precio], [nombre], [fkNivel], [fkHotel]) VALUES (4, 4, 22999, N'THA411', 2, 4)
INSERT [dbo].[Habitacion] ([IdHabitacion], [piso], [precio], [nombre], [fkNivel], [fkHotel]) VALUES (6, 3, 15670, N'MEX309', 2, 2)
SET IDENTITY_INSERT [dbo].[Habitacion] OFF
GO
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([IdHotel], [pais], [nombre]) VALUES (1, N'Costa Rica', N'Pura vida CR')
INSERT [dbo].[Hotel] ([IdHotel], [pais], [nombre]) VALUES (2, N'Mexico', N'Pura vida MEX')
INSERT [dbo].[Hotel] ([IdHotel], [pais], [nombre]) VALUES (3, N'Panamá', N'Pura vida PAN')
INSERT [dbo].[Hotel] ([IdHotel], [pais], [nombre]) VALUES (4, N'Tailandia', N'Pura vida THA')
SET IDENTITY_INSERT [dbo].[Hotel] OFF
GO
SET IDENTITY_INSERT [dbo].[Nivel] ON 

INSERT [dbo].[Nivel] ([IdNivel], [nivel]) VALUES (1, N'Economico')
INSERT [dbo].[Nivel] ([IdNivel], [nivel]) VALUES (2, N'Standar')
INSERT [dbo].[Nivel] ([IdNivel], [nivel]) VALUES (3, N'Premium')
SET IDENTITY_INSERT [dbo].[Nivel] OFF
GO
SET IDENTITY_INSERT [dbo].[NoDisponibilidad] ON 

INSERT [dbo].[NoDisponibilidad] ([IdNoDisponible], [fechaDia], [fkHabitacion]) VALUES (1, CAST(N'2022-11-25' AS Date), 2)
SET IDENTITY_INSERT [dbo].[NoDisponibilidad] OFF
GO
USE [master]
GO
ALTER DATABASE [scriptTP9] SET  READ_WRITE 
GO
