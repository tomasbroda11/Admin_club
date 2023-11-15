USE [master]
GO
/****** Object:  Database [db_club]    Script Date: 9/10/2023 5:55:34 p. m. ******/
CREATE DATABASE [db_club]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_club', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_club.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_club_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\db_club_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [db_club] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_club].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_club] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_club] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_club] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_club] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_club] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_club] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_club] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_club] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_club] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_club] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_club] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_club] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_club] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_club] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_club] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_club] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_club] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_club] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_club] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_club] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_club] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_club] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_club] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_club] SET  MULTI_USER 
GO
ALTER DATABASE [db_club] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_club] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_club] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_club] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_club] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_club] SET QUERY_STORE = OFF
GO
USE [db_club]
GO
/****** Object:  User [MS-11\ALUMNO]    Script Date: 9/10/2023 5:55:34 p. m. ******/
CREATE USER [MS-11\ALUMNO] FOR LOGIN [MS-11\ALUMNO] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [MS-11\ALUMNO]
GO
/****** Object:  Table [dbo].[actividades]    Script Date: 9/10/2023 5:55:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actividades](
	[idActividad] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[costo] [float] NOT NULL,
 CONSTRAINT [PK_actividades] PRIMARY KEY CLUSTERED 
(
	[idActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuotas]    Script Date: 9/10/2023 5:55:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuotas](
	[idSocio] [int] NOT NULL,
	[mes] [varchar](50) NOT NULL,
	[anio] [varchar](50) NOT NULL,
	[monto] [float] NOT NULL,
	[pagado] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[instalaciones]    Script Date: 9/10/2023 5:55:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[instalaciones](
	[idInstalacion] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[idActividad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idInstalacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 9/10/2023 5:55:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservas]    Script Date: 9/10/2023 5:55:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservas](
	[idReservas] [int] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[idInstalacion] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[fechaHora] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idReservas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cuotas]  WITH CHECK ADD  CONSTRAINT [FK_cuotas_socio] FOREIGN KEY([idSocio])
REFERENCES [dbo].[personas] ([dni])
GO
ALTER TABLE [dbo].[cuotas] CHECK CONSTRAINT [FK_cuotas_socio]
GO
ALTER TABLE [dbo].[instalaciones]  WITH CHECK ADD FOREIGN KEY([idActividad])
REFERENCES [dbo].[actividades] ([idActividad])
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD FOREIGN KEY([dni])
REFERENCES [dbo].[personas] ([dni])
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD FOREIGN KEY([idInstalacion])
REFERENCES [dbo].[instalaciones] ([idInstalacion])
GO
USE [master]
GO
ALTER DATABASE [db_club] SET  READ_WRITE 
GO
