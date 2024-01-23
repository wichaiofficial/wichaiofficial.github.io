ALTER TABLE [dbo].[tblPost]
	ADD CONSTRAINT [fk_tblPost_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)