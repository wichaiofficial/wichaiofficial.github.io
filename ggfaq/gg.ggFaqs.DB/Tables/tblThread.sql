CREATE TABLE [dbo].[tblThread]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Subject] VARCHAR(100) NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [CustomerId] INT NOT NULL
)
