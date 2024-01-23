CREATE TABLE [dbo].[tblGameDescription] (
    [Id]          INT            NOT NULL,
    [Description] VARCHAR (8000) NOT NULL,
    CONSTRAINT [PK_tblGameDescription] PRIMARY KEY CLUSTERED ([Id] ASC)
);

