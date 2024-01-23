CREATE TABLE [dbo].[tblThread] (
    [Id]         INT           NOT NULL,
    [Subject]    VARCHAR (100) NOT NULL,
    [Created]    DATETIME      NOT NULL,
    [CustomerId] INT           NOT NULL,
    [GameId]     INT           NOT NULL,
    CONSTRAINT [PK_tblThread] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblThread_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id]),
    CONSTRAINT [FK_tblThread_tblGame] FOREIGN KEY ([GameId]) REFERENCES [dbo].[tblGame] ([Id])
);



