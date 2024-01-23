CREATE TABLE [dbo].[tblRating] (
    [Id]                INT           NOT NULL,
    [Rating]            VARCHAR (10)  NOT NULL,
    [RatingDescription] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_tblRating] PRIMARY KEY CLUSTERED ([Id] ASC)
);



