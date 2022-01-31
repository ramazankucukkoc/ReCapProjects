CREATE TABLE [dbo].[Users] (
    [ID] INT IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (40) NOT NULL,
    [LastName]  NVARCHAR (30) NULL,
    [Email] NVARCHAR (30) NULL,
    [Password] NVARCHAR (60) NULL)