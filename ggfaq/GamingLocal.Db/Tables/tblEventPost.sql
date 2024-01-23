CREATE TABLE [dbo].[tblEventPost]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Content] VARCHAR(8000) NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [EventThreadId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [ImagePath] VARCHAR(250) NULL
)
