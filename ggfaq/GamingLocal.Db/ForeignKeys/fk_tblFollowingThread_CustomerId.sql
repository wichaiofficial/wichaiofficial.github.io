ALTER TABLE [dbo].[tblFollowingThread]
	ADD CONSTRAINT [fk_tblFollowingThread_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)