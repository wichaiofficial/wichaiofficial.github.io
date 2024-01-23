BEGIN
	INSERT INTO tblMovie (Id, Title, Description, Cost, RatingId, FormatId, DirectorId, InStkQty, ImagePath)
	VALUES
	(1, 'Godzilla: King of Monsters', 'The new story follows the heroic efforts of the crypto-zoological agency Monarch as its members face off against a battery of god sized monsters, including the mighty Godzilla, who collides with Mothra, Rodan, and his ultimate nemesis, the three headed King Ghidorah.', 13.99, 3, 2, 2, 5, 'kom.jpg'),
	(2, 'Godzilla vs Kong', 'Kong and his protectors undertake a perilous journey to find his true home, and with them is Jia, a young orphaned girl with whom he has formed a unique and powerful bond. But they unexpectedly find themselves in the path of an enraged Godzilla, cutting a swath of destruction across the globe.', 15.99, 3, 2, 3, 5, 'gk.jpg'),
	(3, 'Godzilla','French nuclear tests irradiate an iguana into a giant monster that heads off to New York City. The American military must chase the monster across the city',10.99, 3, 3, 1, 5, 'godzilla1998.jpg')
END