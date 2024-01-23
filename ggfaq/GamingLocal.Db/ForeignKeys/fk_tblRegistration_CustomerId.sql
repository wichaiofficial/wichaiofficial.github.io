ALTER TABLE [dbo].[tblRegistration]
	ADD CONSTRAINT [fk_tblRegistration_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)