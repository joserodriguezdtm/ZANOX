--Habilitar la depuración del framework:
sp_configure 'show advanced options', 1;
GO
RECONFIGURE;
GO
sp_configure 'clr enabled', 1;
GO
RECONFIGURE;
GO


/*Para poder establecer el nivel de permisos en external_access (nuestro componente accede a recursos externos), 
necesitamos establecer a ON la configuración de nuestra BBDD para la propiedad TRUSTWORTHY, para ello, ejecutamos*/

ALTER DATABASE CHOLLOS SET TRUSTWORTHY ON
ALTER AUTHORIZATION ON DATABASE::CHOLLOS  TO sa


USE [CHOLLOS]
GO

create ASSEMBLY sqlPyO
FROM 'C:\sqlpyo\sqlPyO.dll'
WITH PERMISSION_SET = UNSAFE
GO
create ASSEMBLY [sqlPyO.XmlSerializers.dll] from 'C:\sqlpyo\sqlPyO.XmlSerializers.dll'
WITH PERMISSION_SET = UNSAFE
GO


/****** Object:  UserDefinedFunction [dbo].[GetZanoxSales]    Script Date: 01/09/2014 10:38:34 ******/
CREATE FUNCTION [dbo].[GetZanoxSales](@Fecha [datetime])
RETURNS  TABLE (
	[trackingDate] [nvarchar](4000) NULL,
	[trackingCategory] [nvarchar](4000) NULL,
	[program] [nvarchar](4000) NULL,
	[amount] [nvarchar](4000) NULL,
	[commission] [nvarchar](4000) NULL,
	[currency] [nvarchar](4000) NULL,
	[adSpace] [nvarchar](4000) NULL,
	[reviewState] [nvarchar](4000) NULL,
	[clickDate] [nvarchar](4000) NULL,
	[modifiedDate] [nvarchar](4000) NULL
) WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME sqlpyo.[UserDefinedFunctions].[GetZanoxSales]
GO

CREATE FUNCTION [dbo].[GetBelboonSales](@dias [int])
RETURNS  TABLE (
	eventdate nvarchar(4000) NULL, 
	programmid nvarchar(4000) NULL, 
	programmname nvarchar(4000) NULL, 
	eventcurrency nvarchar(4000) NULL,
	clicks nvarchar(4000) NULL,
	clickcommission nvarchar(4000) NULL,
	views nvarchar(4000) NULL,
	viewcommission nvarchar(4000) NULL,
	leads nvarchar(4000) NULL,
	leadcommission nvarchar(4000) NULL,
	sales nvarchar(4000),
	salecommission nvarchar(4000) NULL,
	totalcommission nvarchar(4000) NULL,
	clickthroughrate nvarchar(4000) NULL,
	leadconversionrate nvarchar(4000) NULL,
	saleconversionrate nvarchar(4000) NULL
) WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME sqlPyO.[UserDefinedFunctions].[GetBelboonSales]
GO
/*
select * from GetZanoxSales(getdate()-1)

select * from dbo.GetBelboonSales(10)
*/