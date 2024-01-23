CREATE TABLE [dbo].[tblLibrary] (
    [Id]         INT NOT NULL,
    [CustomerId] INT NOT NULL,
    CONSTRAINT [PK_tblLibrary] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblLibrary_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id])
);



