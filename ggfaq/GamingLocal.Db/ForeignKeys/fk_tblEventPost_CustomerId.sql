ALTER TABLE [dbo].[tblEventPost]
	ADD CONSTRAINT [fk_tblEventPost_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)