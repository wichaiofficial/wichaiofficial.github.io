CREATE TABLE [dbo].[tblGameUserRating] (
    [Id]         INT NOT NULL,
    [GameId]     INT NOT NULL,
    [CustomerId] INT NOT NULL,
    [UserRating] INT NOT NULL,
    CONSTRAINT [PK_tblGameUserRating] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblGameUserRating_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id]),
    CONSTRAINT [FK_tblGameUserRating_tblGame] FOREIGN KEY ([GameId]) REFERENCES [dbo].[tblGame] ([Id])
);

