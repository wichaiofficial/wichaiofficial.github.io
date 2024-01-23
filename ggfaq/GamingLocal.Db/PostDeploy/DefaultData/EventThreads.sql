BEGIN
	INSERT INTO dbo.tblEventThread(Id, EventName, EventDate, CustomerId, Online, Zip, Active)
	VALUES
	(1, 'Halo Party', '20230502 19:00:00', 1, 0, '54915', 1),
	(2, 'Pokemon Go Raid Party', '20230702 19:00:00', 1, 0, '54915', 0),
	(3, 'NBA 2k23 2v2 Tournament', '20230615 19:00:00', 1, 0, '54915', 0),
	(4, 'Hogwarts Wizards MeetUp', '20230912 19:00:00', 1, 0, '54915', 0),
	(5, 'Fifa Online Challenge', '20230801 19:00:00', 1, 0, '54915', 0)

END