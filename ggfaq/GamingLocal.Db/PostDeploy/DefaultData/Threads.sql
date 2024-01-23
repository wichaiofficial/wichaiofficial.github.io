BEGIN
	INSERT INTO dbo.tblThread(Id, Title, Subject, Created, CustomerId, GameId)
	VALUES
	(1, 'Game Tips', 'this is the first post with information on game tips','20230102 10:21:01', 1, 1),
	(2, 'Game Tips2','this is the second post with information on game tips', '20230102 10:22:57', 1, 2),
	(3, 'Game Tips3','this is the third post with information on game tips', '20230102 10:23:27', 1, 3),
	(4, 'Game Tips4','this is the fourth post with information on game tips', '20230102 11:32:02', 1, 2),
	(5, 'Game Tips5','this is the fifth post with information on game tips', '20230102 12:21:12', 1, 3)



END