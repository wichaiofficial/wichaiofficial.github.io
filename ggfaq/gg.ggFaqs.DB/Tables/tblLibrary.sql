CREATE TABLE [dbo].[tblLibrary]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GameId] INT NOT NULL, 
    [DateAdded] DATE NOT NULL, 
    [CustomerId] INT NOT NULL
)
