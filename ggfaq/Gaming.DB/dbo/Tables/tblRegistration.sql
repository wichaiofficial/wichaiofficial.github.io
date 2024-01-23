CREATE TABLE [dbo].[tblRegistration] (
    [Id]           INT            NOT NULL,
    [TournamentId] INT            NOT NULL,
    [CustomerId]   INT            NOT NULL,
    [AmountDue]    DECIMAL (7, 2) NOT NULL,
    [TotalCost]    DECIMAL (7, 2) NOT NULL,
    [TeamId]       INT            NOT NULL,
    CONSTRAINT [PK_tblRegistration] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblRegistration_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id]),
    CONSTRAINT [FK_tblRegistration_tblTeam] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[tblTeam] ([Id]),
    CONSTRAINT [FK_tblRegistration_tblTournament] FOREIGN KEY ([TournamentId]) REFERENCES [dbo].[tblTournament] ([Id])
);

