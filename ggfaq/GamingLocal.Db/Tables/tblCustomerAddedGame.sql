CREATE TABLE [dbo].[tblCustomerAddedGame]
(
	[AddGameId] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [GameTitle] VARCHAR(150) NOT NULL, 
    [System] VARCHAR(50) NOT NULL, 
    [GameDeveloper] VARCHAR(100) NULL, 
    [Rating] VARCHAR(50) NULL, 
    [Genre] VARCHAR(50) NULL, 
    [InSystem] TINYINT NOT NULL 
)
