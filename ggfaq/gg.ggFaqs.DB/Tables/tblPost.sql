CREATE TABLE [dbo].[tblPost]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Content] VARCHAR(2000) NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [ThreadId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [ImagePath] VARCHAR(250) NOT NULL 
)
