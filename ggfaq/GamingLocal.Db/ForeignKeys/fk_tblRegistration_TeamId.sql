ALTER TABLE [dbo].[tblRegistration]
	ADD CONSTRAINT [fk_tblRegistration_TeamId]
	FOREIGN KEY (TeamId)
	REFERENCES [tblTeam] (Id)