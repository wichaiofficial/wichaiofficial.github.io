ALTER TABLE [dbo].[tblGame]
	ADD CONSTRAINT [fk_tblGame_GenreId]
	FOREIGN KEY (GenreId)
	REFERENCES [tblGenre] (Id)