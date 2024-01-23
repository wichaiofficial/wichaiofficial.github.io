CREATE TABLE [dbo].[tblEventPost] (
    [Id]            INT            NOT NULL,
    [Content]       VARCHAR (8000) NOT NULL,
    [Created]       DATETIME       NOT NULL,
    [EventThreadId] INT            NOT NULL,
    [CustomerId]    INT            NOT NULL,
    [ImagePath]     VARCHAR (250)  NULL,
    CONSTRAINT [PK_tblEventPost] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblEventPost_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id]),
    CONSTRAINT [FK_tblEventPost_tblEventThread] FOREIGN KEY ([EventThreadId]) REFERENCES [dbo].[tblEventThread] ([Id])
);

