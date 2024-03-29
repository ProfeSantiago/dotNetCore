USE [PersonasDB]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 3/19/2014 11:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Cedula] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

CREATE PROCEDURE [dbo].[Cons_Personas] AS
Select * From Personas

GO
/****** Object:  StoredProcedure [dbo].[Ins_Personas]    Script Date: 3/19/2014 11:25:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[Ins_Personas]
	(@Cedula 	[nvarchar](50),
	 @Nombre 	[nvarchar](50),
	 @Telefono 	[nvarchar](50),
	 @Direccion 	[nvarchar](50),
	 @Correo 	[nvarchar](50))

AS INSERT INTO Personas
	
VALUES 
	( @Cedula,
	 @Nombre,
	 @Telefono,
	 @Direccion,
	 @Correo)

GO
