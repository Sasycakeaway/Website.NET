USE [master]
GO
/****** Object:  Database [Sasy]    Script Date: 09/10/2022 17:48:36 ******/
CREATE DATABASE [Sasy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sasy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sasy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sasy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sasy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sasy] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sasy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sasy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sasy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sasy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sasy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sasy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sasy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sasy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sasy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sasy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sasy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sasy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sasy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sasy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sasy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sasy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sasy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sasy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sasy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sasy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sasy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sasy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sasy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sasy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sasy] SET  MULTI_USER 
GO
ALTER DATABASE [Sasy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sasy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sasy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sasy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sasy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sasy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sasy] SET QUERY_STORE = OFF
GO
USE [Sasy]
GO
/****** Object:  Table [dbo].[Newsletter]    Script Date: 09/10/2022 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Newsletter](
	[FK_Email] [nvarchar](100) NOT NULL,
	[PK_Token] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Newsletter] PRIMARY KEY CLUSTERED 
(
	[FK_Email] ASC,
	[PK_Token] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordini]    Script Date: 09/10/2022 17:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordini](
	[PK_ID] [uniqueidentifier] NOT NULL,
	[Nome] [nvarchar](256) NULL,
	[Cognome] [nvarchar](256) NULL,
	[Indirizzo] [nvarchar](256) NULL,
	[Cap] [nvarchar](256) NULL,
	[Domicilio] [nvarchar](256) NULL,
	[FK_Email] [nvarchar](100) NOT NULL,
	[Totale] [int] NULL,
	[Cart] [nvarchar](max) NULL,
	[Timestamp] [datetime] NULL,
 CONSTRAINT [PK_Ordini] PRIMARY KEY CLUSTERED 
(
	[PK_ID] ASC,
	[FK_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecoveryPassword]    Script Date: 09/10/2022 17:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecoveryPassword](
	[UUID] [uniqueidentifier] NULL,
	[FK_Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_RecoveryPassword] PRIMARY KEY CLUSTERED 
(
	[FK_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utenti]    Script Date: 09/10/2022 17:48:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utenti](
	[CF] [nvarchar](256) NULL,
	[Nascita] [nvarchar](256) NULL,
	[Telefono] [nvarchar](256) NULL,
	[PK_Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](256) NULL,
	[Timestamp] [datetime] NULL,
	[News] [binary](50) NULL,
 CONSTRAINT [PK_Utenti] PRIMARY KEY CLUSTERED 
(
	[PK_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ordini] ADD  CONSTRAINT [DF_Ordini_FK_Email]  DEFAULT (NULL) FOR [FK_Email]
GO
ALTER TABLE [dbo].[RecoveryPassword] ADD  CONSTRAINT [DF_RecoveryPassword_FK_Email]  DEFAULT (NULL) FOR [FK_Email]
GO
ALTER TABLE [dbo].[Newsletter]  WITH CHECK ADD  CONSTRAINT [FK_Newsletter_Utenti] FOREIGN KEY([FK_Email])
REFERENCES [dbo].[Utenti] ([PK_Email])
GO
ALTER TABLE [dbo].[Newsletter] CHECK CONSTRAINT [FK_Newsletter_Utenti]
GO
ALTER TABLE [dbo].[Ordini]  WITH CHECK ADD  CONSTRAINT [FK_Ordini_Utenti] FOREIGN KEY([FK_Email])
REFERENCES [dbo].[Utenti] ([PK_Email])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ordini] CHECK CONSTRAINT [FK_Ordini_Utenti]
GO
ALTER TABLE [dbo].[RecoveryPassword]  WITH CHECK ADD  CONSTRAINT [FK_RecoveryPassword_Utenti] FOREIGN KEY([FK_Email])
REFERENCES [dbo].[Utenti] ([PK_Email])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RecoveryPassword] CHECK CONSTRAINT [FK_RecoveryPassword_Utenti]
GO
USE [master]
GO
ALTER DATABASE [Sasy] SET  READ_WRITE 
GO
