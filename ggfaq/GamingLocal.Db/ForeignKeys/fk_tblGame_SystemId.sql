ALTER TABLE [dbo].[tblGame]
	ADD CONSTRAINT [fk_tblGame_SystemId]
	FOREIGN KEY (SystemId)
	REFERENCES [tblSystem] (Id)