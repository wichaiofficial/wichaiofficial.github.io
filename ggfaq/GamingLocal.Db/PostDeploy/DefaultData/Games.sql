BEGIN
	INSERT INTO dbo.tblGame(Id, SystemId, Title, Release, RatingId, GenreId, GameDeveloperId, GameDescriptionId, ImagePath)
	VALUES
	(1, 1, 'NBA 2K23', '20220908', 1, 1, 1, 1, 'NBA2k23.png'),
	(2, 2, 'FIFA 20', '20220908', 2, 1, 1, 1, 'Fifa20.jpeg'),
	(3, 2, 'Call Of Duty WW2', '20220908', 2, 2, 1, 1, 'CODWW2.jpg'),
	(4, 1, 'Legacy Of Hogwarts', '20220908', 2, 2, 1, 1, 'LegacyOfHogwarts.jpg'),
	(5, 3, 'Call Of Duty WW2', '20220908', 2, 2, 1, 1, 'CODWW2.jpg')
	

END