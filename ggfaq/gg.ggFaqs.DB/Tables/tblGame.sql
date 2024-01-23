CREATE TABLE [dbo].[tblGame]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SystemId] INT NOT NULL, 
    [Title] VARCHAR(75) NOT NULL, 
    [Release] DATE NOT NULL, 
    [RatingId] INT NOT NULL, 
    [GenreId] INT NOT NULL, 
    [GameDeveloperId] INT NOT NULL
)
