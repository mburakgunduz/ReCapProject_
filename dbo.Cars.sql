CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] INT NULL, 
    [Description] VARCHAR(MAX) NULL
)
