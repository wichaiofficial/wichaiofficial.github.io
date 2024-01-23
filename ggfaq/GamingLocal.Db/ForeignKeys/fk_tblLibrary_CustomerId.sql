ALTER TABLE [dbo].[tblLibrary]
	ADD CONSTRAINT [fk_tblLibrary_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)