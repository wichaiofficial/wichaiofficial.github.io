ALTER TABLE [dbo].[tblGameUserRating]
	ADD CONSTRAINT [fk_tblGameUserRating_GameId]
	FOREIGN KEY (GameId)
	REFERENCES [tblGame] (Id)
