ALTER TABLE [dbo].[tblThread]
	ADD CONSTRAINT [fk_tblThread_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)