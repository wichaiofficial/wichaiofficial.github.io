CREATE TABLE [dbo].[tblTournament] (
    [Id]            INT            NOT NULL,
    [GameId]        INT            NOT NULL,
    [FormatId]      INT            NOT NULL,
    [Online]        TINYINT        NOT NULL,
    [Zip]           VARCHAR (5)    NULL,
    [CostPerPlayer] DECIMAL (7, 2) NOT NULL,
    [Active]        TINYINT        NOT NULL,
    CONSTRAINT [PK_tblTournament] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblTournament_tblGame] FOREIGN KEY ([GameId]) REFERENCES [dbo].[tblGame] ([Id]),
    CONSTRAINT [FK_tblTournament_tblTournamentFormat] FOREIGN KEY ([FormatId]) REFERENCES [dbo].[tblTournamentFormat] ([Id])
);

