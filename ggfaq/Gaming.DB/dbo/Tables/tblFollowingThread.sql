CREATE TABLE [dbo].[tblFollowingThread] (
    [Id]         INT     NOT NULL,
    [CustomerId] INT     NOT NULL,
    [ThreadId]   INT     NOT NULL,
    [Following]  TINYINT NOT NULL,
    CONSTRAINT [PK_tblFollowingThread] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblFollowingThread_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id]),
    CONSTRAINT [FK_tblFollowingThread_tblThread] FOREIGN KEY ([ThreadId]) REFERENCES [dbo].[tblThread] ([Id])
);

