CREATE TABLE [dbo].[tblTournament]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GameId] INT NOT NULL, 
    [FormatId] INT NOT NULL, 
    [Online] TINYINT NOT NULL, 
    [Zip] VARCHAR(5) NULL, 
    [CostPerPlayer] DECIMAL(7, 2) NOT NULL, 
    [Active] TINYINT NOT NULL
)
