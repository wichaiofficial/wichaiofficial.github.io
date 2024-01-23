ALTER TABLE [dbo].[tblEventPost]
	ADD CONSTRAINT [fk_tblEventPost_EventThreadId]
	FOREIGN KEY (EventThreadId)
	REFERENCES [tblEventThread] (Id)
