ALTER TABLE [dbo].[tblLibraryGame]
	ADD CONSTRAINT [fk_tblLibraryGame_LibraryId]
	FOREIGN KEY (LibraryId)
	REFERENCES [tblLibrary] (Id)