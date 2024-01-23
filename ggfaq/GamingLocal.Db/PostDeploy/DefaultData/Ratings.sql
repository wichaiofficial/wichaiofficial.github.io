BEGIN
	INSERT INTO dbo.tblRating(Id, Rating, RatingDescription)
	VALUES
	(1, 'E', 'Content is generally suitable for all ages. May contain minimal caroon, fantasy or mild violence and/or infrequent use of mild language.'),
	(2, 'E10+', 'Content is generally suitable for ages 10 and up. May contain more cartoon, fantasy or mild violence, mild language and/or minmal suggestive themes.'),
	(3, 'T', 'Content is generally suitable for ages 13 and up. May contain violence, suggestive themes, crude humor, minimal blood, simulated gambling and/or infrequent use of strong language.'),
	(4, 'M', 'Content is generally suitable for ages 17 and up. May contain intense violence, blood and gore, sexual content and/or strong language.'),
	(5, 'A', 'Content suitable only for adults ages 18 and up. May include prolonged scenes of intense violence, graphic sexual content and/or gambling with real currency.'),
	(6, 'RP', 'Not yet assigned a final ESRB rating. Appears only in advertising, marketing and promotional materials related to a physical (e.g., boxed) video game that is expected to carry an ESRB rating, and should be replaced by a games rating once it has been assigned.'),
	(7, 'RP17+', 'Not yet assigned a final ESRB rating but anticipated to be rated Mature 17+. Appears only in advertising, marketing, and promotional materials related to a physical (e.g.,boxed) video game that is expected to carry an ESRB rating, and should be replaced by a games rating once it has been assigned.')



END