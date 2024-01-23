CREATE TABLE [dbo].[tblThread]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NOT NULL,
    [Subject] VARCHAR(100) NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [GameId] INT NOT NULL
)
