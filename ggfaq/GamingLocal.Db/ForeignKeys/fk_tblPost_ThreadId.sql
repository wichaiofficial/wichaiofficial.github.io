ALTER TABLE [dbo].[tblPost]
	ADD CONSTRAINT [fk_tblPost_ThreadId]
	FOREIGN KEY (ThreadId)
	REFERENCES [tblThread] (Id)