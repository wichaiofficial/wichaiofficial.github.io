BEGIN
	INSERT INTO tblOrder (Id, CustomerId, OrderDate, UserId, ShipDate)
	VALUES
	(1, 1, '2022-07-14', 123456, '2022-07-16'),
	(2, 2, '2022-07-22', 332564, '2022-07-24'),
	(3, 3, '2022-08-03', 785614, '2022-08-05')
END