CREATE TABLE [dbo].[tblManufacturer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(75) NOT NULL, 
    [Address] VARCHAR(100) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [State] VARCHAR(2) NOT NULL, 
    [Zip] VARCHAR(5) NOT NULL
)
