CREATE TABLE [dbo].[tblEventThread]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EventName] VARCHAR(500) NOT NULL, 
    [EventDate] DATETIME NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [Online] TINYINT NOT NULL, 
    [Zip] VARCHAR(5) NULL, 
    [Active] TINYINT NOT NULL
)
