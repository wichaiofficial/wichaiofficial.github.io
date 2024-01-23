CREATE TABLE [dbo].[tblGame] (
    [Id]                INT           NOT NULL,
    [SystemId]          INT           NOT NULL,
    [Title]             VARCHAR (75)  NOT NULL,
    [Release]           DATE          NOT NULL,
    [RatingId]          INT           NOT NULL,
    [GenreId]           INT           NOT NULL,
    [GameDeveloperId]   INT           NOT NULL,
    [GameDescriptionId] INT           NOT NULL,
    [ImagePath]         VARCHAR (250) NULL,
    CONSTRAINT [PK_tblGame] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblGame_tblGameDescription] FOREIGN KEY ([GameDescriptionId]) REFERENCES [dbo].[tblGameDescription] ([Id]),
    CONSTRAINT [FK_tblGame_tblGameDeveloper] FOREIGN KEY ([GameDeveloperId]) REFERENCES [dbo].[tblGameDeveloper] ([Id]),
    CONSTRAINT [FK_tblGame_tblGenre] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[tblGenre] ([Id]),
    CONSTRAINT [FK_tblGame_tblRating] FOREIGN KEY ([RatingId]) REFERENCES [dbo].[tblRating] ([Id]),
    CONSTRAINT [FK_tblGame_tblSystem] FOREIGN KEY ([SystemId]) REFERENCES [dbo].[tblSystem] ([Id])
);



