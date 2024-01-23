CREATE TABLE [dbo].[tblManufacturer] (
    [Id]      INT           NOT NULL,
    [Name]    VARCHAR (75)  NOT NULL,
    [Address] VARCHAR (100) NOT NULL,
    [City]    VARCHAR (50)  NOT NULL,
    [State]   VARCHAR (2)   NOT NULL,
    [Zip]     NCHAR (5)     NOT NULL,
    CONSTRAINT [PK_tblManufacturer] PRIMARY KEY CLUSTERED ([Id] ASC)
);



