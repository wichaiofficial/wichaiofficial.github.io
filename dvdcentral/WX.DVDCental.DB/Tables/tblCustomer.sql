﻿CREATE TABLE [dbo].[tblCustomer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL,
    [State] VARCHAR(50) NOT NULL,
    [Zip] VARCHAR(50) NOT NULL, 
    [Phone] VARCHAR(50) NOT NULL, 
    [UserId] INT NOT NULL
)
