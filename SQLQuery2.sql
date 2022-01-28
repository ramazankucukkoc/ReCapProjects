CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] INT NULL, 
    [Description] NCHAR(50) NULL,
	CONSTRAINT [FK_Cars_Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]),
    CONSTRAINT [FK_Cars_Color] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Color] ([Id])
)