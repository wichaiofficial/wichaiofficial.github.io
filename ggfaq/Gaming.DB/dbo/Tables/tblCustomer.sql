CREATE TABLE [dbo].[tblCustomer] (
    [Id]           INT            NOT NULL,
    [FirstName]    VARCHAR (50)   NOT NULL,
    [LastName]     VARCHAR (50)   NOT NULL,
    [UserName]     VARCHAR (50)   NOT NULL,
    [Password]     VARCHAR (28)   NOT NULL,
    [Address]      VARCHAR (100)  NOT NULL,
    [City]         VARCHAR (50)   NOT NULL,
    [State]        VARCHAR (2)    NOT NULL,
    [Zip]          VARCHAR (5)    NOT NULL,
    [Phone]        VARCHAR (15)   NULL,
    [MembershipId] INT            CONSTRAINT [DEFAULT_tblCustomer_MembershipId] DEFAULT ((1)) NOT NULL,
    [DisplayName]  VARCHAR (50)   NOT NULL,
    [profileImage] VARCHAR (250)  NOT NULL,
    [AboutMe]      VARCHAR (5000) NULL,
    [SocialSites]  VARCHAR (2000) NULL,
    CONSTRAINT [PK_NewTable] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tblCustomer_tblMembership] FOREIGN KEY ([MembershipId]) REFERENCES [dbo].[tblMembership] ([Id])
);





