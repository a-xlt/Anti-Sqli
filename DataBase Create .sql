CREATE DATABASE [SQLI]
GO

USE [SQLI]
GO

CREATE TABLE [dbo].[Login](
	[id] [int] NOT NULL IDENTITY(1,1),
	[username] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Books](
	[id] [int] NOT NULL IDENTITY(1,1),
	[BookName] [nvarchar](max) NULL,
	[Details] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


