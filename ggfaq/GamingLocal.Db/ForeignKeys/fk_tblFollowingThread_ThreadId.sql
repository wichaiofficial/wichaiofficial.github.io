ALTER TABLE [dbo].[tblFollowingThread]
	ADD CONSTRAINT [fk_tblFollowingThread_ThreadId]
	FOREIGN KEY (ThreadId)
	REFERENCES [tblThread] (Id)