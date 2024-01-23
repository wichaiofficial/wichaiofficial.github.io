CREATE TABLE [dbo].[tblSystem] (
    [Id]             INT           NOT NULL,
    [Name]           VARCHAR (100) NOT NULL,
    [ManufacturerId] INT           NOT NULL,
    [Release]        DATE          NOT NULL,
    CONSTRAINT [PK_tblSystem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblSystem_tblManufacturer] FOREIGN KEY ([ManufacturerId]) REFERENCES [dbo].[tblManufacturer] ([Id])
);



