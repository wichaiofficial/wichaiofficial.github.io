CREATE TABLE [dbo].[tblTeam] (
    [Id]              INT            NOT NULL,
    [TeamName]        VARCHAR (100)  NOT NULL,
    [PlayerFirstName] VARCHAR (50)   NOT NULL,
    [PlayerLastName]  VARCHAR (50)   NOT NULL,
    [Email]           VARCHAR (75)   NOT NULL,
    [Age]             INT            NULL,
    [AmountDue]       DECIMAL (7, 2) NOT NULL,
    [AmountPaid]      DECIMAL (7, 2) NOT NULL,
    CONSTRAINT [PK_tblTeam] PRIMARY KEY CLUSTERED ([Id] ASC)
);

