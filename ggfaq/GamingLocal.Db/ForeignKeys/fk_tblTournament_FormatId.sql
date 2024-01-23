ALTER TABLE [dbo].[tblTournament]
	ADD CONSTRAINT [fk_tblTournament_FormatId]
	FOREIGN KEY (FormatId)
	REFERENCES [tblTournamentFormat] (Id)