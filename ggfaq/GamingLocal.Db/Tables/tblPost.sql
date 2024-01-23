CREATE TABLE [dbo].[tblPost]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Content] VARCHAR(5000) NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [ThreadId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [ImagePath] VARCHAR(100) NOT NULL
)
