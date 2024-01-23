CREATE TABLE [dbo].[tblRegistration]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TournamentId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [AmountDue] DECIMAL(7, 2) NOT NULL, 
    [TotalCost] DECIMAL(7, 2) NOT NULL, 
    [TeamId] INT NOT NULL
)
