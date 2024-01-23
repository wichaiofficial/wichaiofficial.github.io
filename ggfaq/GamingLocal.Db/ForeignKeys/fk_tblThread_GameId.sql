ALTER TABLE [dbo].[tblThread]
	ADD CONSTRAINT [fk_tblThread_GameId]
	FOREIGN KEY (GameId)
	REFERENCES [tblGame] (Id)