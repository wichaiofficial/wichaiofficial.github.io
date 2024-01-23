CREATE TABLE [dbo].[tblGenre] (
    [Id]               INT           NOT NULL,
    [Genre]            VARCHAR (50)  NOT NULL,
    [GenreDescription] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_tblGenre] PRIMARY KEY CLUSTERED ([Id] ASC)
);

