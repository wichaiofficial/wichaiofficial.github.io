ALTER TABLE [dbo].[tblGame]
	ADD CONSTRAINT [fk_tblGame_RatingId]
	FOREIGN KEY (RatingId)
	REFERENCES [tblRating] (Id)