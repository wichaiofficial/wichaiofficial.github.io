CREATE TABLE [dbo].[tblSystem]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(45) NOT NULL, 
    [ManufacturerId] INT NOT NULL, 
    [Release] DATE NOT NULL
)
