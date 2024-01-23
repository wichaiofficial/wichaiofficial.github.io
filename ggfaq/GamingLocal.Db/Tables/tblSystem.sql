CREATE TABLE [dbo].[tblSystem]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(100) NOT NULL, 
    [ManufacturerId] INT NOT NULL, 
    [Release] DATE NOT NULL
)
