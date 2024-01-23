ALTER TABLE [dbo].[tblCustomerAddedGame]
	ADD CONSTRAINT [fk_tblCustomerAddedGame_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)