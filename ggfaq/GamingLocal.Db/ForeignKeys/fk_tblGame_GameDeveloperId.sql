ALTER TABLE [dbo].[tblGame]
	ADD CONSTRAINT [fk_tblGame_GameDeveloperId]
	FOREIGN KEY (GameDeveloperId)
	REFERENCES [tblGameDeveloper] (Id)