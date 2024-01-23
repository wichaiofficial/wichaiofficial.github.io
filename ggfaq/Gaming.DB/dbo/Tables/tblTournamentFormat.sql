CREATE TABLE [dbo].[tblTournamentFormat] (
    [Id]                INT           NOT NULL,
    [FormatType]        VARCHAR (150) NOT NULL,
    [FormatDescription] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_tblTournamentFormat] PRIMARY KEY CLUSTERED ([Id] ASC)
);



