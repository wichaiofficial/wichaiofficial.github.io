ALTER TABLE [dbo].[tblGameUserRating]
	ADD CONSTRAINT [fk_tblGameUserRating_CustomerId]
	FOREIGN KEY (CustomerId)
	REFERENCES [tblCustomer] (Id)
