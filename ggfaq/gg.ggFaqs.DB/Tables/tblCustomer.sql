CREATE TABLE [dbo].[tblCustomer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Address] VARCHAR(100) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [State] VARCHAR(2) NOT NULL, 
    [Zip] VARCHAR(5) NOT NULL, 
    [Phone] VARCHAR(15) NOT NULL, 
    [UserId] INT NOT NULL, 
    [Membership] VARCHAR(25) NOT NULL 
)
