ALTER TABLE [dbo].[tblRegistration]
	ADD CONSTRAINT [fk_tblRegistration_TournamentId]
	FOREIGN KEY (TournamentId)
	REFERENCES [tblTournament] (Id)