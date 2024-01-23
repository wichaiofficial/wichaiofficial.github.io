ALTER TABLE [dbo].[tblLibraryGame]
	ADD CONSTRAINT [fk_tblLibraryGame_GameId]
	FOREIGN KEY (GameId)
	REFERENCES [tblGame] (Id)