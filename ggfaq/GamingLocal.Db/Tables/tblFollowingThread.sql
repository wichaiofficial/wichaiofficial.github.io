CREATE TABLE [dbo].[tblFollowingThread]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [ThreadId] INT NOT NULL, 
    [Following] TINYINT NOT NULL
)
