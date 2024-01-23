CREATE TABLE [dbo].[tblGameUserRating]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GameId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [UserRating] INT NOT NULL
)
