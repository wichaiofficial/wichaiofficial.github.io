CREATE TABLE [dbo].[tblGameDeveloper] (
    [Id]              INT          NOT NULL,
    [DeveloperName]   VARCHAR (75) NOT NULL,
    [DateEstablished] DATE         NOT NULL,
    CONSTRAINT [PK_tblGameDeveloper] PRIMARY KEY CLUSTERED ([Id] ASC)
);

