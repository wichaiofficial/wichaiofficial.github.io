CREATE TABLE [dbo].[tblPost] (
    [Id]         INT            NOT NULL,
    [Content]    VARCHAR (5000) NOT NULL,
    [Created]    DATETIME       NOT NULL,
    [ThreadId]   INT            NOT NULL,
    [CustomerId] INT            NOT NULL,
    [ImagePath]  VARCHAR (100)  NOT NULL,
    CONSTRAINT [PK_tblPost] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblPost_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id]),
    CONSTRAINT [FK_tblPost_tblThread] FOREIGN KEY ([ThreadId]) REFERENCES [dbo].[tblThread] ([Id])
);



