ALTER TABLE [dbo].[tblCustomer]
	ADD CONSTRAINT [fk_tblCustomer_MembershipId]
	FOREIGN KEY (MembershipId)
	REFERENCES [tblMembership] (Id)
