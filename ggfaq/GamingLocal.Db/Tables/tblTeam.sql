CREATE TABLE [dbo].[tblTeam]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TeamName] VARCHAR(75) NOT NULL, 
    [PlayerFirstName] VARCHAR(45) NOT NULL, 
    [PlayerLastName] VARCHAR(45) NOT NULL, 
    [Email] VARCHAR(75) NOT NULL, 
    [Age] INT NULL, 
    [AmountDue] DECIMAL(7, 2) NOT NULL, 
    [AmountPaid] DECIMAL(7, 2) NOT NULL
)
