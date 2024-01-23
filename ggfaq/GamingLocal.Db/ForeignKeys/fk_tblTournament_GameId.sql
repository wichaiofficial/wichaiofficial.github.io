ALTER TABLE [dbo].[tblTournament]
	ADD CONSTRAINT [fk_tblTournament_GameId]
	FOREIGN KEY (GameId)
	REFERENCES [tblGame] (Id)