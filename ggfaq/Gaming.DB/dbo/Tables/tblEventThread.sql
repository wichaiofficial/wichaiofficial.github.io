CREATE TABLE [dbo].[tblEventThread] (
    [Id]         INT           NOT NULL,
    [EventName]  VARCHAR (500) NOT NULL,
    [EventDate]  DATETIME      NOT NULL,
    [CustomerId] INT           NOT NULL,
    [Online]     TINYINT       NOT NULL,
    [Zip]        VARCHAR (5)   NULL,
    [Active]     TINYINT       NOT NULL,
    CONSTRAINT [PK_tblEventThread] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblEventThread_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id])
);

