ALTER TABLE [dbo].[tblEventThread]
	ADD CONSTRAINT [fk_tblEventThread_UserId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)
