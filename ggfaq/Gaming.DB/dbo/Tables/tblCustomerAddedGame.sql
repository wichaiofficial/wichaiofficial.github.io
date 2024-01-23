CREATE TABLE [dbo].[tblCustomerAddedGame] (
    [AddGameId]     INT           NOT NULL,
    [CustomerId]    INT           NOT NULL,
    [GameTitle]     VARCHAR (150) NOT NULL,
    [System]        VARCHAR (50)  NOT NULL,
    [GameDeveloper] VARCHAR (100) NULL,
    [Rating]        VARCHAR (50)  NULL,
    [Genre]         VARCHAR (50)  NULL,
    CONSTRAINT [PK_tblCustomerAddedGame] PRIMARY KEY CLUSTERED ([AddGameId] ASC),
    CONSTRAINT [FK_tblCustomerAddedGame_tblCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[tblCustomer] ([Id])
);

