ALTER TABLE [dbo].[tblSystem]
	ADD CONSTRAINT [fk_tblSystem_ManufacturerId]
	FOREIGN KEY (ManufacturerId)
	REFERENCES [tblManufacturer] (Id)