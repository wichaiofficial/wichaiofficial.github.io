CREATE TABLE [dbo].[tblMembership] (
    [Id]          INT           NOT NULL,
    [Membership]  VARCHAR (45)  NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_tblMembership] PRIMARY KEY CLUSTERED ([Id] ASC)
);

