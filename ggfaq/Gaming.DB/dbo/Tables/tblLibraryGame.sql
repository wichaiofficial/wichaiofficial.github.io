CREATE TABLE [dbo].[tblLibraryGame] (
    [Id]        INT  NOT NULL,
    [LibraryId] INT  NOT NULL,
    [GameId]    INT  NOT NULL,
    [DateAdded] DATE NULL,
    CONSTRAINT [PK_tblLibraryGame] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblLibraryGame_tblGame] FOREIGN KEY ([GameId]) REFERENCES [dbo].[tblGame] ([Id]),
    CONSTRAINT [FK_tblLibraryGame_tblLibrary] FOREIGN KEY ([LibraryId]) REFERENCES [dbo].[tblLibrary] ([Id])
);



